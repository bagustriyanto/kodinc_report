using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using ReportService.Domains;

namespace ReportService.Repositories.Interfaces
{
    public interface IBKPFRepository
    {
        Task Create(BKPFModel model, CancellationToken cancellationToken);
        void Update(BKPFModel model);
        Task<BKPFModel> GetOneByFilter(Expression<Func<BKPFModel, bool>> filter, CancellationToken cancellationToken);
    }
}