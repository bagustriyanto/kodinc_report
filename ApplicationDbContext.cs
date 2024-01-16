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

        public virtual DbSet<FileHistoryModel> FileHistoryModels { get; set; }
        public virtual DbSet<HistoryModel> HistoryModels { get; set; }
        public virtual DbSet<MKVGModel> MKVGModels { get; set; }
        public virtual DbSet<BKPFModel> BKPFModels { get; set; }
        public virtual DbSet<BSEGModel> BSEGModels { get; set; }
        public virtual DbSet<F10Model> F10Models { get; set; }
    }
}