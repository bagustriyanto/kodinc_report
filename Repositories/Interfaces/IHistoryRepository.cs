using System.Linq.Expressions;
using ReportService.Domains;

namespace ReportService.Repositories.Interfaces
{
    public interface IHistoryRepository
    {
        Task Create(HistoryModel model, CancellationToken cancellationToken);
        void Update(HistoryModel model);
        Task<HistoryModel> GetLastHistory(string status, CancellationToken cancellationToken);
        Task<HistoryModel> GetById(Guid id);
        Task<HistoryModel> GetByFilter(Expression<Func<HistoryModel, bool>> func, CancellationToken cancellationToken);
    }
}