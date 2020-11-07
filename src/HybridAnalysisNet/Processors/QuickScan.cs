using HybridAnalysisNet.Repository;
using HybridAnalysisNet.Results;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace HybridAnalysisNet.Processors
{
    public class QuickScan
    {
        private RespositoryHttp _respositoryHttp;

        public QuickScan(string apiKey, bool bypassCertificateCheck = false)
        {
            _respositoryHttp = new RespositoryHttp(apiKey, bypassCertificateCheck);

            WebProxy webProxy = new WebProxy { Address = new Uri("http://192.168.88.16:8080") };
            _respositoryHttp.Proxy = webProxy;
        }

        public Task<QuickScanUrl> GetUrlAsync(string url)
        {
            return _respositoryHttp.GetUrl(url);
        }
    }
}
