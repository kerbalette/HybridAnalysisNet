using HybridAnalysisNet.Exceptions;
using HybridAnalysisNet.Internal;
using HybridAnalysisNet.Results;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HybridAnalysisNet.Repository
{


    internal class RespositoryHttp
    {
        private readonly HttpClient _client;
        private readonly HttpClientHandler _httpClientHandler;
        private readonly Dictionary<string, string> _headerValues;
        private readonly JsonSerializer _serializer;
        private readonly string _apiUrl = "https://www.hybrid-analysis.com/api/v2";

        private string _userAgent;

        public string UserAgent
        {
            get => _userAgent;
            set
            {
                _userAgent = value;
                _client.DefaultRequestHeaders.UserAgent.Clear();
                _client.DefaultRequestHeaders.UserAgent.ParseAdd(value);
            }
        }

        public RespositoryHttp(string apiKey, bool bypassCertificateCheck = false)
        {
            if (string.IsNullOrWhiteSpace(apiKey))
                throw new ArgumentException("An API key is required in order for this to function.", nameof(apiKey));

            if (apiKey.Length != 64)
                throw new ArgumentException("API key is not correct", nameof(apiKey));

            _headerValues = new Dictionary<string, string>(1);
            _headerValues.Add("api-key", apiKey);

            _httpClientHandler = new HttpClientHandler();
            _httpClientHandler.AllowAutoRedirect = true;

            if (bypassCertificateCheck)
                _httpClientHandler.ServerCertificateCustomValidationCallback = (message, cert, chain, errors) => { return true; };

            _client = new HttpClient(_httpClientHandler);
            _client.DefaultRequestHeaders.Add("api-key", _headerValues["api-key"]);
            _client.DefaultRequestHeaders.Accept.Clear();
            _client.DefaultRequestHeaders.Accept.ParseAdd("application/json");

            JsonSerializerSettings jsonConfiguration = new JsonSerializerSettings();
            jsonConfiguration.NullValueHandling = NullValueHandling.Ignore;
            jsonConfiguration.Formatting = Formatting.None;
            _serializer = JsonSerializer.Create(jsonConfiguration);

            SetupDefaultUserAgent();
        }

        /// <summary>
        /// Get or set a proxy
        /// </summary>
        public IWebProxy Proxy
        {
            get => _httpClientHandler.Proxy;
            set
            {
                _httpClientHandler.UseProxy = true;
                _httpClientHandler.Proxy = value;
            }
        }

        private void SetupDefaultUserAgent()
        {
            var assemblyName = Assembly.GetCallingAssembly().GetName().Name;
            var assemblyVersion = Assembly.GetCallingAssembly().GetName().Version.ToString();
            var os = Environment.OSVersion.VersionString;
            UserAgent = $"{assemblyName}/{assemblyVersion} ({os})";
        }

        protected internal Task<ReportSummary> GetSummary(string jobId)
        {
            return GetResponse<ReportSummary>($"{_apiUrl}/report/{jobId}/summary", HttpMethod.Get, null);
        }

        protected internal Task<QuickScanUrl> GetUrl(string url)
        {
            IDictionary<string, string> values = new Dictionary<string, string>();
            values.Add("scan_type", "all");
            values.Add("url", url);

            return GetResponse<QuickScanUrl>(_apiUrl + "/quick-scan/url", HttpMethod.Post, CreateURLEncodedContent(values));
        }

        private async Task<T> GetResponse<T>(string url, HttpMethod method, HttpContent content)
        {
            HttpResponseMessage response = await SendRequest(url, method, content).ConfigureAwait(false);

            using (Stream responseStream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false))
            using (StreamReader sr = new StreamReader(responseStream, Encoding.UTF8))
            using (JsonTextReader jsonTextReader = new JsonTextReader(sr))
            {
                jsonTextReader.CloseInput = false;
                return _serializer.Deserialize<T>(jsonTextReader);
            }
        }

        private async Task<HttpResponseMessage> SendRequest(string url, HttpMethod method, HttpContent content)
        {
            HttpRequestMessage request = new HttpRequestMessage(method, url);
            request.Content = content;

            HttpResponseMessage response = await _client.SendAsync(request).ConfigureAwait(false);

            if (response.StatusCode == HttpStatusCode.Forbidden)
                throw new AccessDeniedException("You do not have permission to access this resource");

            return response;
        }

        private HttpContent CreateURLEncodedContent(IDictionary<string, string> values)
        {
            return new CustomURLEncodedContent(values);
        }

        private HttpContent CreateDocPart()
        {
            HttpContent httpContent = new StringContent(_headerValues["api-key"]);
            httpContent.Headers.ContentDisposition = new ContentDispositionHeaderValue("form-data")
            {
                Name = "\"apikey\""
            };

            return httpContent;
        }

        private HttpContent CreateFileContent(Stream stream, string fileName, bool includeSize = true)
        {
            StreamContent fileContent = new StreamContent(stream);

            ContentDispositionHeaderValue disposition = new ContentDispositionHeaderValue("form-data");
            disposition.Name = "\"file\"";
            disposition.FileName = "\"" + fileName + "\"";

            if (includeSize)
                disposition.Size = stream.Length;

            fileContent.Headers.ContentDisposition = disposition;
            fileContent.Headers.ContentType = new MediaTypeHeaderValue("application/octet-stream");
            return fileContent;
        }
    }
}
