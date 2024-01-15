using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReportService.Domains
{
    public class HistoryModel
    {
        public Guid Id { get; set; }
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public string Type { get; set; } = "UPLOAD";
        public DateTime StartTime { get; set; }
        public DateTime FinishTime { get; set; }
        public string Status { get; set; } = "INITIALIZE";
        public string Remark { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}