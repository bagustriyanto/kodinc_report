using Domain = ReportService.Domains;

namespace ReportService.Models
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
        public DateTime CreatedAt { get; set; }
        public int LastRowSuccess { get; set; }
        public int TotalRows { get; set; }

        public Domain.HistoryModel MapToDomain()
        {
            return new Domain.HistoryModel()
            {
                FileName = this.FileName,
                FilePath = this.FilePath,
                Type = this.Type,
                StartTime = this.StartTime,
                FinishTime = this.FinishTime,
                Status = this.Status,
                Remark = this.Remark,
                CreatedAt = this.CreatedAt,
                LastRowSuccess = this.LastRowSuccess,
                TotalRows = this.TotalRows
            };
        }

        public HistoryModel MapFromDomain(Domain.HistoryModel model)
        {
            return new HistoryModel()
            {
                Id = model.Id,
                FileName = model.FileName,
                FilePath = model.FilePath,
                Type = model.FilePath,
                StartTime = model.StartTime,
                FinishTime = model.FinishTime,
                Status = model.Status,
                Remark = model.Remark,
                LastRowSuccess = model.LastRowSuccess,
                TotalRows = model.TotalRows,
                CreatedAt = model.CreatedAt
            };
        }
    }
}