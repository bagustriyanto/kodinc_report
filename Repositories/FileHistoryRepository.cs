using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ReportService.Domains;
using ReportService.Repositories.Interfaces;

namespace ReportService.Repositories
{
    public class FileHistoryRepository : IFileHistoryRepository
    {
        private readonly ApplicationDbContext applicationDbContext;

        public FileHistoryRepository(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }
        public async Task Create(FileHistoryModel model, CancellationToken cancellationToken)
        {
            await applicationDbContext.FileHistoryModels.AddAsync(model, cancellationToken);
        }

        public Task<List<FileHistoryModel>> GetFileHistory()
        {
            throw new NotImplementedException();
        }

        public async Task<FileHistoryModel> GetFileHistoryByName(string filename, CancellationToken cancellationToken)
        {
            return await applicationDbContext.FileHistoryModels.Where(w => w.FileName.Equals(filename)).FirstOrDefaultAsync(cancellationToken);
        }
    }
}