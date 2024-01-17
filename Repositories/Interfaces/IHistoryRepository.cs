using ReportService.Domains;

namespace ReportService.Repositories.Interfaces
{
    public interface IHistoryRepository
    {
        Task Create(HistoryModel model, CancellationToken cancellationToken);
        void Update(HistoryModel model);
        Task<HistoryModel> GetLastHistory(string status, CancellationToken cancellationToken);
    }
}