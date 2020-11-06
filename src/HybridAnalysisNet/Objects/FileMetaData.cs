using System;
using System.Collections.Generic;
using System.Text;

namespace HybridAnalysisNet.Objects
{
    public class FileMetaData
    {
        public List<string> File_Compositions { get; set; }
        public List<string> Imported_Objects { get; set; }
        public List<string> File_Analysis { get; set; }
        public int Total_File_Compositions_Imports { get; set; }
    }
}
