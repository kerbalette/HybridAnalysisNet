using System.Collections.Generic;
using HybridAnalysisNet.Objects;
using Newtonsoft.Json;

namespace HybridAnalysisNet.Results
{
    public class QuickScan
    {
        [JsonProperty("submission_type")]
        public string SubmissionType { get; set; }
        public string Id { get; set; }
        public string Sha256 { get; set; }
        public List<ScanEngine> Scanners { get; set; }
        public List<string> Reports { get; set; }
        public bool Finished { get; set; }
    }
}
