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
        public string Type { get; set; } = "upload";
        public DateTime StartTime { get; set; }
        public DateTime FinishTime { get; set; }
        public string Status { get; set; } = "initialize";
        public string Remark { get; set; }
        public int LastRowSuccess { get; set; }
        public int TotalRows { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}