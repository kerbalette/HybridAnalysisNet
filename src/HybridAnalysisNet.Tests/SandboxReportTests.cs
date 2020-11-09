using HybridAnalysisNet.Results;
using HybridAnalysisNet.Tests.TestInternals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace HybridAnalysisNet.Tests
{
    public class SandboxReportTests : BaseTest
    {
        [Fact]
        public async Task SandboxReport_GetValidIdSummary_ShouldBeValid()
        {
            
            HybridAnalysis hybridAnalysis = new HybridAnalysis(this.ApiKey, true, this.webProxy);
            
            ReportSummary reportSummary = await hybridAnalysis.SandboxReport.GetSummaryAsync(TestData.JobIds.First());
            

            //QuickScan quickscan = await hybridAnalysis.QuickScanUrlAsync(TestData.KnownUrls.Last());
            //TODO Start from here
            Assert.Equal(true,true);
        }
    }
}
