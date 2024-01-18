using Microsoft.EntityFrameworkCore;
using ReportService.Domains;
using ReportService.Repositories.Interfaces;
using System.Linq;
using System.Linq.Expressions;

namespace ReportService.Repositories
{
    public class BKPFRepository : IBKPFRepository
    {
        private readonly ApplicationDbContext applicationDbContext;
        public BKPFRepository(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }
        public async Task Create(BKPFModel model, CancellationToken cancellationToken)
        {
            await applicationDbContext.BKPFModels.AddAsync(model, cancellationToken);
        }

        public async Task<BKPFModel> GetOneByFilter(Expression<Func<BKPFModel, bool>> filter, CancellationToken cancellationToken)
        {
            return await applicationDbContext.BKPFModels.Where(filter).FirstOrDefaultAsync(cancellationToken);
        }

        public void Update(BKPFModel model)
        {
            applicationDbContext.Entry(model).State = EntityState.Modified;
        }
    }
}