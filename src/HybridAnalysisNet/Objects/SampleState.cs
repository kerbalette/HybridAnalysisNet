using System;
using System.Collections.Generic;
using System.Text;

namespace HybridAnalysisNet.Objects
{
    public class SampleState
    {
        public string State { get; set; }
        public string Error_Type { get; set; }
        public string Error_Origin { get; set; }
        public string Error { get; set; }
        public List<SampleVerdict> Related_Reports { get; set; }
    }
}
