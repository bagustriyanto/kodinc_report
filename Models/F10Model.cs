using Domain = ReportService.Domains;

namespace ReportService.Models
{
    public class F10Model
    {
        public Guid Id { get; set; }
        public string? GLAccount { get; set; }
        public string? GLAccountLongText { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string? SourceFile { get; set; }
        public Domain.F10Model MapToDomain()
        {
            return new Domain.F10Model()
            {
                Id = this.Id,
                GLAccount = this.GLAccount,
                GLAccountLongText = this.GLAccountLongText,
                CreatedAt = this.CreatedAt,
                UpdatedAt = this.UpdatedAt,
                SourceFile = this.SourceFile,
            };
        }
    }
}