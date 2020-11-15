using System;
using System.Collections.Generic;
using System.Text;

namespace HybridAnalysisNet.Objects
{
    public class SubmissionStatus
    {
        public string Job_Id { get; set; }
        public string Submission_Id { get; set; }
        public int Environment_Id { get; set; }
        public string Sha256 { get; set; }
    }
}
