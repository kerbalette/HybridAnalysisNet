using HybridAnalysisNet.Objects;
using HybridAnalysisNet.Results.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace HybridAnalysisNet.Results
{
    public class ReportSummary : IResult
    {
        public string Job_Id { get; set; }
        public int Environment_Id { get; set; }
        public string Environment_Description { get; set; }
        public int Size { get; set; }
        public string Type { get; set; }
        public List<string> Type_Short { get; set; }
        public string Target_Url { get; set; }
        public string State { get; set; }
        public string Error_Type { get; set; }
        public string Error_Origin { get; set; }
        public string Submit_Name { get; set; }
        public string Md5 { get; set; }
        public string Sha1 { get; set; }
        public string Sha256 { get; set; }
        public string Sha512 { get; set; }
        public string SsDeep { get; set; }
        public string ImpHash { get; set; }
        public int Av_Detect { get; set; }
        public string Vx_Family { get; set; }
        public bool Url_Analysis { get; set; }
        public DateTime Analysis_Start_Time { get; set; }
        public int Threat_Score { get; set; }
        public bool Interesting { get; set; }
        public int Threat_Level { get; set; }
        public string Verdict { get; set; }
        public List<string> Domains { get; set; }
        public List<string> Compromised_Hosts { get; set; }
        public List<string> Hosts { get; set; }
        public int Total_Network_Connections { get; set; }
        public int Total_Processes { get; set; }
        public int Total_Signatures { get; set; }
        public FileMetaData File_MetaData { get; set; }
        public List<ExtractedFiles> Extracted_Files { get; set; }
        public List<Processes> Processes { get; set; }
        public List<Submissions> Submissions { get; set; }
    }
}
