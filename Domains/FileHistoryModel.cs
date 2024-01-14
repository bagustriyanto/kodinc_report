using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReportService.Domains
{
    public class FileHistoryModel
    {
        public Guid id { get; set; }
        public string file_name { get; set; }
        public string file_timestamp { get; set; }
        public string created_at { get; set; }
    }
}