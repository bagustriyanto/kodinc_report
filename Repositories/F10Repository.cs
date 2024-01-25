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
    public class F10Repository : IF10Repository
    {
        private readonly ApplicationDbContext applicationDbContext;

        public F10Repository(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }
        public async Task Create(F10Model model, CancellationToken cancellationToken)
        {
            await applicationDbContext.F10Models.AddAsync(model, cancellationToken);
        }

        public async Task<F10Model> GetOneByFilter(Expression<Func<F10Model, bool>> filter, CancellationToken cancellationToken)
        {
            return await applicationDbContext.F10Models.Where(filter).FirstOrDefaultAsync(cancellationToken);
        }

        public void Update(F10Model model)
        {
            applicationDbContext.Entry(model).State = EntityState.Modified;
        }
    }
}