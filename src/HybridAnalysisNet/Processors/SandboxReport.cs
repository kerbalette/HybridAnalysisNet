using HybridAnalysisNet.Repository;
using HybridAnalysisNet.Results;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace HybridAnalysisNet.Processors
{
    public class SandboxReport
    {
        private RespositoryHttp _respositoryHttp;

        public SandboxReport(string apiKey, bool bypassCertificateCheck = false, WebProxy webProxy = null)
        {
            _respositoryHttp = new RespositoryHttp(apiKey, bypassCertificateCheck);
            
            if (webProxy != null)
                _respositoryHttp.Proxy = webProxy;
        }

        public Task<ReportSummary> GetSummaryAsync(string jobId)
        {
            if (jobId.Length != 24)
                throw new ArgumentException("jobId is not correct length", nameof(jobId));

            return _respositoryHttp.GetSummary(jobId);
        }
    }
}
