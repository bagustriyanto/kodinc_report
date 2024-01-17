using Domain = ReportService.Domains;

namespace ReportService.Models
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

        public Domain.HistoryModel MapToDomain()
        {
            return new Domain.HistoryModel()
            {
                FileName = this.FileName,
                FilePath = this.FilePath,
                Type = this.FilePath,
                StartTime = this.StartTime,
                FinishTime = this.FinishTime,
                Status = this.Status,
                Remark = this.Remark,
                CreatedAt = this.CreatedAt
            };
        }
    }
}