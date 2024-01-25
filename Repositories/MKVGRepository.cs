using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ReportService.Domains;
using ReportService.Repositories.Interfaces;

namespace ReportService.Repositories
{
    public class MKVGRepository : IMKVGRepository
    {
        private readonly ApplicationDbContext applicationDbContext;
        public MKVGRepository(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;

        }
        public async Task Create(MKVGModel model, CancellationToken cancellationToken)
        {
            await applicationDbContext.MKVGModels.AddAsync(model, cancellationToken);
        }

        public async Task<MKVGModel> GetOneByFilter(Expression<Func<MKVGModel, bool>> filter, CancellationToken cancellationToken)
        {
            return await applicationDbContext.MKVGModels.Where(filter).FirstOrDefaultAsync(cancellationToken);
        }

        public void Update(MKVGModel model)
        {
            applicationDbContext.Entry(model).State = EntityState.Modified;
        }
    }
}