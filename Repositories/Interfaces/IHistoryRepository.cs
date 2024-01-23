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
        Task<int> GetTotal(CancellationToken cancellationToken);
        Task<HistoryModel> GetByFilter(Expression<Func<HistoryModel, bool>> func, CancellationToken cancellationToken);
        Task<IReadOnlyList<HistoryModel>> GetByFilterList(Expression<Func<HistoryModel, bool>> func, int page, int limit, CancellationToken cancellationToken);
    }
}