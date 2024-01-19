using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ReportService.Repositories.Interfaces;

namespace ReportService.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext applicationDbContext;
        public UnitOfWork(ApplicationDbContext applicationDbContext, IFileHistoryRepository _fileHistoryRepository, IHistoryRepository _historyRepository,
        IBKPFRepository bkpfRepository, IBSEGRepository bsegRepository)
        {
            this.applicationDbContext = applicationDbContext;
            fileHistoryRepository = _fileHistoryRepository;
            historyRepository = _historyRepository;
            this.bkpfRepository = bkpfRepository;
            this.bsegRepository = bsegRepository;
        }
        public IFileHistoryRepository fileHistoryRepository { get; }
        public IHistoryRepository historyRepository { get; }
        public IBKPFRepository bkpfRepository { get; }
        public IBSEGRepository bsegRepository { get; }

        public void Dispose()
        {
            applicationDbContext.Dispose();
        }

        public async Task Save()
        {
            await applicationDbContext.SaveChangesAsync();
        }
    }
}