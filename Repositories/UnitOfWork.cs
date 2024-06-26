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
        IBKPFRepository bkpfRepository, IBSEGRepository bsegRepository,
        IF10Repository f10Repository,
        IMKVGRepository mkvgRepository)
        {
            this.applicationDbContext = applicationDbContext;
            fileHistoryRepository = _fileHistoryRepository;
            historyRepository = _historyRepository;
            this.bkpfRepository = bkpfRepository;
            this.bsegRepository = bsegRepository;
            this.f10Repository = f10Repository;
            this.mkvgRepository = mkvgRepository;
        }
        public IFileHistoryRepository fileHistoryRepository { get; }
        public IHistoryRepository historyRepository { get; }
        public IBKPFRepository bkpfRepository { get; }
        public IBSEGRepository bsegRepository { get; }

        public IF10Repository f10Repository { get; }

        public IMKVGRepository mkvgRepository { get; }

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