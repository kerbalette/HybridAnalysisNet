using System;
using System.Collections.Generic;
using System.Text;

namespace HybridAnalysisNet.Objects
{
    public class SampleVerdict
    {
        public string Job_Id  {get; set; }
        public int Environment_Id { get;}
        public string State {get; set; }
        public string Error_Type   {get; set; }
        public string Error_Origin  { get; set; }
        public string Sha256 { get; set; }
        public string Verdict { get; set; }
    }
}
