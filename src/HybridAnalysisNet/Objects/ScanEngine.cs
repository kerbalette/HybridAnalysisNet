using Newtonsoft.Json;

namespace HybridAnalysisNet.Objects
{
    public class ScanEngine
    {
        public string Name { get; set; }

        public string Status { get; set; }

        [JsonProperty("error_message")]
        public string ErrorMessage { get; set; }

        public int Progress { get; set; }

        public int Total { get; set; }

        public int Positives { get; set; }

        public int Percent { get; set; }
    }
}
