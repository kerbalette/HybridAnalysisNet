#define PROXY

using HybridAnalysisNet.Tests.TestInternals;
using HybridAnalysisNet.Exceptions;
using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;



namespace HybridAnalysisNet.Tests
{

    public class GeneralTests : BaseTest
    {
        [Fact]
        public async Task UnauthorisedScan()
        {
            HybridAnalysis hybridAnalysis = new HybridAnalysis("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx", true);

#if (PROXY)

            WebProxy webProxy = new WebProxy {Address = new Uri("http://127.0.0.1:8080")};
            hybridAnalysis.Proxy = webProxy;
#endif

            await Assert.ThrowsAsync<AccessDeniedException>(async () =>
                await hybridAnalysis.QuickScanUrlAsync(TestData.KnownUrls.First()));

        }
    }
}
