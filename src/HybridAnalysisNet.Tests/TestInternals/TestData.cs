
using System.Text;

namespace HybridAnalysisNet.Tests.TestInternals
{
    internal static class TestData
    {
        internal static readonly string[] KnownUrls =
            {"www.google.com.au", "hybrid-analysis.com", "www.lifelabs.vn/api/get.php?id=aW5mb0BzYXBjdXBncmFkZXMuY29t"};

        internal static readonly string[] MaliciousSha256Hashes =
            {"178ba564b39bd07577e974a9b677dfd86ffa1f1d0299dfd958eb883c5ef6c3e1"};

        internal static readonly string[] JobIds =
            {"5ea6e801c04958569e750022"};

        internal static readonly string[] SubmissionsIds =
            {"5f25f3b4c430d203081cd134", "5ea6e801c04958569e750023" };

    }
}
