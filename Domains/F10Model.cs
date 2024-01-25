using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReportService.Domains
{
    public class F10Model
    {
        public Guid Id { get; set; }
        public string? GLAccount { get; set; }
        public string? GLAccountLongText { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string? SourceFile { get; set; }
    }
}