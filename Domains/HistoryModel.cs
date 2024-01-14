using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReportService.Domains
{
    public class HistoryModel
    {
        public Guid id { get; set; }
        public string file_name { get; set; }
        public string file_path { get; set; }
        public string type { get; set; } = "UPLOAD";
        public DateTime start_time { get; set; }
        public DateTime finish_time { get; set; }
        public string status { get; set; } = "INITIALIZE";
        public string remark { get; set; }
        public DateTime created_at { get; set; }
    }
}