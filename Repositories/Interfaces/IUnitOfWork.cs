

namespace ReportService.Repositories.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IFileHistoryRepository fileHistoryRepository { get; }
        IHistoryRepository historyRepository { get; }
        IBKPFRepository bkpfRepository { get; }
        IBSEGRepository bsegRepository { get; }
        Task Save();
    }
}