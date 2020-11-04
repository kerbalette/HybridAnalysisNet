using System;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using HybridAnalysisNet.Results;
using HybridAnalysisNet.Tests.TestInternals;
using Xunit;

namespace HybridAnalysisNet.Tests
{
    public class QuickScanTests : BaseTest
    {
        [Fact]
        public async Task QuickScanKnownUrl()
        {
            HybridAnalysis hybridAnalysis = new HybridAnalysis(this.ApiKey, true);
            WebProxy webProxy = new WebProxy { Address = new Uri("http://127.0.0.1:8080") };
            hybridAnalysis.Proxy = webProxy;

            QuickScan quickscan = await hybridAnalysis.QuickScanUrlAsync(TestData.KnownUrls.Last());
            //TODO Start from here
            Assert.Equal(true || false, quickscan.Finished);
        }

        [Fact]
        public async Task QuickScanFile()
        {
            HybridAnalysis hybridAnalysis = new HybridAnalysis(this.ApiKey, true);
            WebProxy webProxy = new WebProxy { Address = new Uri("http://127.0.0.1:8080") };
            hybridAnalysis.Proxy = webProxy;

            QuickScan quickScan = await hybridAnalysis.QuickScanFileAsync(@"filename");
        }
    }
}
