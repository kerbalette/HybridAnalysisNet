using System;
using System.Collections.Generic;
using System.Text;

namespace HybridAnalysisNet.Objects
{
    public class MitreAttacks
    {
        public string Tactic { get; set; }
        public string Technique { get; set; }
        public string Attack_Id { get; set; }
        public string Attack_Id_Wiki { get; set; }
        public int Malicious_Identifiers_Count { get; set; }
        public List<string> Malicious_Identifiers { get; set; }
        public int Suspicious_Identifiers_Count { get; set; }
        public List<string> Suspicious_Identifiers { get; set; }
        public int Informative_Identifiers_Count { get; set; }
        public List<string> Informative_Identifiers { get; set; }
    }
}
