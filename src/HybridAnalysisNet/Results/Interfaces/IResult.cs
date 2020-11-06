using HybridAnalysisNet.Objects;
using System;
using System.Collections.Generic;
using System.Text;

namespace HybridAnalysisNet.Results.Interfaces
{
    public interface IResult
    {
        string Job_Id { get; set; }
        int Environment_Id { get; set; }
        string Environment_Description { get; set; }
        int Size { get; set; }
        string Type { get; set; }
        List<string> Type_Short { get; set; }
        string Target_Url { get; set; }
        string State { get; set; }
        string Error_Type { get; set; }
        string Error_Origin { get; set; }
        string Submit_Name { get; set; }
        string Md5 { get; set; }
        string Sha1 { get; set; }
        string Sha256 { get; set; }
        string Sha512 { get; set; }
        string SsDeep { get; set; }
        string ImpHash { get; set; }
        int Av_Detect { get; set; }
        string Vx_Family { get; set; }
        bool Url_Analysis { get; set; }
        DateTime Analysis_Start_Time { get; set; }
        int Threat_Score { get; set; }
        bool Interesting { get; set; }
        int Threat_Level { get; set; }
        string Verdict { get; set; }
        List<string> Domains { get; set; }
        List<string> Compromised_Hosts { get; set; }
        List<string> Hosts { get; set; }
        int Total_Network_Connections { get; set; }
        int Total_Processes { get; set; }
        int Total_Signatures { get; set; }
        List<ExtractedFiles> Extracted_Files { get; set; }
        FileMetaData File_MetaData { get; set; }
        List<Processes> Processes { get; set; }
        List<Submissions> Submissions { get; set; }
    }
}
