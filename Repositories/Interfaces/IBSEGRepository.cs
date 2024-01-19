using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using ReportService.Domains;

namespace ReportService.Repositories.Interfaces
{
    public interface IBSEGRepository
    {
        Task Create(BSEGModel model, CancellationToken cancellationToken);
        void Update(BSEGModel model);
        Task<BSEGModel> GetOneByFilter(Expression<Func<BSEGModel, bool>> filter, CancellationToken cancellationToken);
    }
}