using System;
using System.Collections.Generic;
using System.Text;

namespace HybridAnalysisNet.Objects
{
    public class ExtractedFiles
    {
        public string Name { get; set; }
        public string File_Path { get; set; }
        public int File_Size { get; set; }
        public string Sha1 { get; set; }
        public string Sha256 { get; set; }
        public string Md5 { get; set; }
        public List<string> Type_Tags { get; set; }
        public string Description { get; set; }
        public string Runtime_Process { get; set; }
        public int Threat_Level { get; set; }
        public string Threat_Level_Readable { get; set; }
        public string AV_Level { get; set; }
        public int AV_Matched { get; set; }
        public int AV_Total { get; set; }
        public string File_Available_To_Download { get; set; }
    }
}
