using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using HybridAnalysisNet.Exceptions;
using HybridAnalysisNet.Internal;
using HybridAnalysisNet.Processors;
using HybridAnalysisNet.Results;
using Newtonsoft.Json;

namespace HybridAnalysisNet
{
    public class HybridAnalysis
    {
        private SandboxReport _sandboxReport;
        private QuickScan _quickScan;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="apiKey">The API key v2 from hybrid-analysis.com</param>
        public HybridAnalysis(string apiKey, bool bypassCertificateCheck = false, WebProxy webProxy = null)
        {
            _sandboxReport = new SandboxReport(apiKey, bypassCertificateCheck, webProxy);
            _quickScan = new QuickScan(apiKey, bypassCertificateCheck, webProxy);
        }
        public SandboxReport SandboxReport
        {
            get
            {
                return _sandboxReport;
            }
        }

        public QuickScan QuickScan
        {
            get
            {
                return _quickScan;
            }
        }

        //public async Task<QuickScan> QuickScanFileAsync(string filePath)
        //{
        //    if (!File.Exists(filePath))
        //        throw new FileNotFoundException("File has not been found.", filePath);

        //    string fileName = filePath;

        //    using (Stream fs = File.OpenRead(fileName))
        //        return await QuickScanFileAsync(fs, fileName);
        //}

        //public Task<QuickScan> QuickScanFileAsync(Stream stream, string fileName)
        //{
        //    MultipartFormDataContent multi = new MultipartFormDataContent();
        //    multi.Add(CreateDocPart());
        //    multi.Add(CreateFileContent(stream, fileName));

        //    return GetResponse<QuickScan>(_apiUrl + "/quick-scan/file", HttpMethod.Post, multi);

        //}

        



    }
}
