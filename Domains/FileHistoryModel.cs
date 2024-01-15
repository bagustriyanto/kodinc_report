using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReportService.Domains
{
    public class FileHistoryModel
    {
        public Guid Id { get; set; }
        public string FileName { get; set; }
        public string FileTimestamp { get; set; }
        public string CreatedAt { get; set; }
    }
}