using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using ReportService.Domains;

namespace ReportService.Repositories.Interfaces
{
    public interface IMKVGRepository
    {
        Task Create(MKVGModel model, CancellationToken cancellationToken);
        void Update(MKVGModel model);
        Task<MKVGModel> GetOneByFilter(Expression<Func<MKVGModel, bool>> filter, CancellationToken cancellationToken);
    }
}