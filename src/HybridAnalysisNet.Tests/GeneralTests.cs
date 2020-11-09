using HybridAnalysisNet.Tests.TestInternals;
using HybridAnalysisNet.Exceptions;
using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;


namespace HybridAnalysisNet.Tests
{

    public class GeneralTests : BaseTest
    {
        [Fact]
        public async Task UnauthorisedScan()
        {
            HybridAnalysis hybridAnalysis = new HybridAnalysis("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx", true);
            await Assert.ThrowsAsync<AccessDeniedException>(async () =>
                await hybridAnalysis.QuickScan.GetUrlAsync(TestData.KnownUrls.Last()));

        }

        public GeneralTests(ITestOutputHelper output) : base(output)
        {
        }
    }
}
