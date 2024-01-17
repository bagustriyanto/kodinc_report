using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ReportService.Domains;

namespace ReportService.Repositories.Interfaces
{
    public interface IFileHistoryRepository
    {
        Task Create(FileHistoryModel model, CancellationToken cancellationToken);
        Task<List<FileHistoryModel>> GetFileHistory();
        Task<FileHistoryModel> GetFileHistoryByName(string filename, CancellationToken cancellationToken);
    }
}