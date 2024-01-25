using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Threading.Tasks;

namespace ReportService.Domains
{
    public class MKVGModel
    {
        public Guid Id { get; set; }
        public string Supplier { get; set; }
        public string VendorName { get; set; }
        public string Address { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        public string AccountGroup { get; set; }
        public string SearchTerm { get; set; }
        public string OneTimeAccount { get; set; }
        public string PurchaseOrg { get; set; }
        public string PurchaseOrgDesc { get; set; }
        public string TermsOfPayment { get; set; }
        public string Incoterms { get; set; }
        public string Incoterms2 { get; set; }
        public decimal MinOrderVal { get; set; }
        public string OrderCurrency { get; set; }
        public bool CentralDelFlag { get; set; }
        public bool DeleteFlagPurchaseOrg { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string? SourceFile { get; set; }
    }
}