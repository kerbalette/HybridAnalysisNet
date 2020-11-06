using System;
using System.Collections.Generic;
using System.Text;

namespace HybridAnalysisNet.Objects
{
    public class Processes
    {
        public string Uid { get; set; }
        public string ParentUid { get; set; }
        public string Name { get; set; }
        public string Normalized_Path { get; set; }
        public string Command_Line { get; set; }
        public string Sha256 { get; set; }
        public string AV_label { get; set; }
        public int AV_matched { get; set; }
        public int AV_total { get; set; }
        public int pid { get; set; }
        public string Icon { get; set; }
        public List<string> File_Accesses { get; set; }
        public List<string> Created_Files { get; set; }
        public List<string> Registry { get; set; }
        public List<string> Mutants { get; set; }
        public List<string> Handles { get; set; }
        public List<string> Streams { get; set; }
        public List<string> Script_Calls { get; set; }
        public List<string> Process_Flags { get; set; }
    }
}
