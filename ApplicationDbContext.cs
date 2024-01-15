using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ReportService.Domains;

namespace ReportService
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        DbSet<FileHistoryModel> FileHistoryModels { get; set; }
        DbSet<HistoryModel> HistoryModels { get; set; }
        DbSet<MKVGModel> MKVGModels { get; set; }
        DbSet<BKPFModel> BKPFModels { get; set; }
        DbSet<BSEGModel> BSEGModels { get; set; }
        DbSet<F10Model> F10Models { get; set; }
    }
}