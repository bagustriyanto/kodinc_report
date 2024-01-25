
using System.Linq.Expressions;
using ReportService.Domains;

namespace ReportService.Repositories.Interfaces
{
    public interface IF10Repository
    {
        Task Create(F10Model model, CancellationToken cancellationToken);
        void Update(F10Model model);
        Task<F10Model> GetOneByFilter(Expression<Func<F10Model, bool>> filter, CancellationToken cancellationToken);
    }
}