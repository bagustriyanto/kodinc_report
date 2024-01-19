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
    public class BSEGRepository : IBSEGRepository
    {
        private readonly ApplicationDbContext applicationDbContext;

        public BSEGRepository(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }
        public async Task Create(BSEGModel model, CancellationToken cancellationToken)
        {
            await applicationDbContext.BSEGModels.AddAsync(model, cancellationToken);
        }

        public async Task<BSEGModel> GetOneByFilter(Expression<Func<BSEGModel, bool>> filter, CancellationToken cancellationToken)
        {
            return await applicationDbContext.BSEGModels.Where(filter).FirstOrDefaultAsync(cancellationToken);
        }

        public void Update(BSEGModel model)
        {
            applicationDbContext.Entry(model).State = EntityState.Modified;
        }
    }
}