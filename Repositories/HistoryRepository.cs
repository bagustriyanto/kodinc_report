using Microsoft.EntityFrameworkCore;
using ReportService.Domains;
using ReportService.Repositories.Interfaces;

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

        public async Task<HistoryModel> GetLastHistory(string status, CancellationToken cancellationToken)
        {
            HistoryModel history = new HistoryModel();

            history = await applicationDbContext.HistoryModels
            .Where(m => m.Status.ToLower().Equals(status))
            .AsNoTracking()
            .FirstOrDefaultAsync(cancellationToken);

            return history;
        }

        public void Update(HistoryModel model)
        {
            applicationDbContext.Entry(model).State = EntityState.Modified;
        }
    }
}