using Domain = ReportService.Domains;

namespace ReportService.Models
{
    public class FileHistoryModel
    {
        public Guid Id { get; set; }
        public string FileName { get; set; }
        public string FileTimestamp { get; set; }
        public DateTime CreatedAt { get; set; }

        public Domain.FileHistoryModel MapToDomain()
        {
            return new Domain.FileHistoryModel()
            {
                FileName = this.FileName,
                FileTimestamp = this.FileTimestamp,
                CreatedAt = this.CreatedAt
            };
        }

        public FileHistoryModel MapFromDomain(Domain.FileHistoryModel fileHistoryModel)
        {
            return new FileHistoryModel()
            {
                FileName = fileHistoryModel.FileName,
                FileTimestamp = fileHistoryModel.FileTimestamp,
                CreatedAt = fileHistoryModel.CreatedAt
            };
        }
    }
}