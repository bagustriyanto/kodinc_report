using Microsoft.EntityFrameworkCore;
using ReportService.Domains;
using ReportService.Repositories.Interfaces;
using System.Linq;
using System.Linq.Expressions;

namespace ReportService.Repositories
{
    public class HistoryRepository : IHistoryRepository
    {
        private readonly ApplicationDbContext applicationDbContext;

        public HistoryRepository(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }
        public async Task Create(HistoryModel model, CancellationToken cancellationToken)
        {
            await applicationDbContext.HistoryModels.AddAsync(model, cancellationToken);
        }

        public async Task<HistoryModel> GetByFilter(Expression<Func<HistoryModel, bool>> func, CancellationToken cancellationToken)
        {
            return await applicationDbContext.HistoryModels.Where(func).FirstOrDefaultAsync(cancellationToken);
        }

        public async Task<HistoryModel> GetById(Guid id)
        {
            return await applicationDbContext.HistoryModels.FindAsync(id);
        }

        public async Task<HistoryModel> GetLastHistory(string status, CancellationToken cancellationToken)
        {
            HistoryModel history = new HistoryModel();

            history = await applicationDbContext.HistoryModels
            .Where(m => m.Status.ToLower().Equals(status))
            .OrderBy(m => m.CreatedAt)
            .AsNoTracking()
            .FirstOrDefaultAsync(cancellationToken);

            return history is not null ? history : null;
        }

        public void Update(HistoryModel model)
        {
            applicationDbContext.Entry(model).State = EntityState.Modified;
        }
    }
}