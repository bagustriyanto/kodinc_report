

namespace ReportService.Repositories.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IFileHistoryRepository fileHistoryRepository { get; }
        IHistoryRepository historyRepository { get; }
        Task Save();
    }
}