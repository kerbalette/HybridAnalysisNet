using System;
using System.Collections.Generic;
using System.Text;

namespace HybridAnalysisNet.Objects
{
    public class SampleSummary
    {
        public string Job_Id { get; set; }
        public int Environment_Id { get; set; }
        public string Environment_Description { get; set; }
        public int size { get; set; }
        public int type { get; set; }
        //type_short	[...]
        public string target_url { get; set; }
        public string state { get; set; }
        public string error_type { get; set; }
        public string error_origin { get; set; }
        public string submit_name { get; set; }
        public string md5 { get; set; }
        public string sha1 { get; set; }
        public string sha256 { get; set; }
        public string sha512 { get; set; }
        public string Ssdeep { get; set; }
        public string Imphash { get; set; }
        public string av_detect { get; set; }
        public string vx_family { get; set; }
        public bool url_analysis { get; set; }
        public DateTime analysis_start_time { get; set; }
        public int threat_score { get; set; }
        public bool interesting { get; set; }
        public int threat_level { get; set; }
        public string verdict { get; set; }
        public List<Certificate> Certificates { get; set; }
        public List<string> Domains { get; set; }

        public List<string> classification_tags { get; set; }

        public List<string> compromised_hosts { get; set; }


        hosts[...]
        total_network_connections integer
        total_processes integer
        total_signatures integer
        extracted_files[...]
        file_metadata   FileMetadata{...}
    processes[...]
    tags[...]
    mitre_attcks[...]
    submissions[...]
    }
}
