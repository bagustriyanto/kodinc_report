using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReportService.Models
{
    public class BSEGModel
    {
        public Guid Id { get; set; }
        public string Cl { get; set; }
        public string CoCd { get; set; }
        public string DocumentNo { get; set; }
        public int? Year { get; set; }
        public string Itm { get; set; }
        public string LID { get; set; }
        public string Clearing { get; set; }
        public DateTime ClgEntDate { get; set; }
        public string ClrngDoc { get; set; }
        public int? PK { get; set; }
        public string AccTy { get; set; }
        public string SG { get; set; }
        public string TransType { get; set; }
        public string TrgtSpecialGLInd { get; set; }
        public string DC { get; set; }
        public string BusA { get; set; }
        public string TPBA { get; set; }
        public string Tx { get; set; }
        public string WT { get; set; }
        public decimal LocCurrAmount { get; set; }
        public decimal Amount { get; set; }
        public decimal OrigReduction { get; set; }
        public decimal GeneralLedgerAmount { get; set; }
        public string Curr { get; set; }
        public decimal OriginalTaxBaseAmount { get; set; }
        public decimal LCTaxAmount { get; set; }
        public decimal TaxAmount { get; set; }
        public decimal LCTaxBaseAmount { get; set; }
        public decimal TaxBase { get; set; }
        public decimal LCProvision { get; set; }
        public decimal AdditionalTax { get; set; }
        public decimal CashDiscount { get; set; }
        public int? VersionNumberComponent { get; set; }
        public string Typ { get; set; }
        public string GrI { get; set; }
        public string Trs { get; set; }
        public decimal WTaxBase { get; set; }
        public decimal HedgedER { get; set; }
        public decimal HedgedAmount { get; set; }
        public decimal ValuationDifference { get; set; }
        public decimal ValuationDifference2 { get; set; }
        public DateTime? ValueDate { get; set; }
        public string Assignment { get; set; }
        public string Text { get; set; }
        public string IntBlock { get; set; }
        public string TrPrt { get; set; }
        public string TTy { get; set; }
        public string GroupAcct { get; set; }
        public string TrTy { get; set; }
        public string Level { get; set; }
        public string PlanGrp { get; set; }
        public decimal PlannedAmount { get; set; }
        public DateTime? PlanDate { get; set; }
        public string FBI { get; set; }
        public string COAr { get; set; }
        public string CostCtr { get; set; }
        public string NotInUse { get; set; }
        public string Order { get; set; }
        public string BillDoc { get; set; }
        public string SalesDoc { get; set; }
        public string Item { get; set; }
        public string SLNo { get; set; }
        public string Asset { get; set; }
        public string SNo { get; set; }
        public string TTyAsset { get; set; }
        public DateTime? AssetValDate { get; set; }
        public string PersNo { get; set; }
        public string Sl { get; set; }
        public string Indicator { get; set; }
        public bool LineItemDisplayPossible { get; set; }
        public string OIManagement { get; set; }
        public string IndividSet { get; set; }
        public string CS { get; set; }
        public string OS { get; set; }
        public string SP { get; set; }
        public string PS { get; set; }
        public string XFAKT { get; set; }
        public string XUMAN { get; set; }
        public string XANET { get; set; }
        public string WD { get; set; }
        public string InvestmentID { get; set; }
        public string Dis { get; set; }
        public string Aut { get; set; }
        public string ItemsCannotBeCopiedIndicator { get; set; }
        public string Payment { get; set; }
        public string GLAcct { get; set; }
        public string GLCustomer { get; set; }
        public string GLSupplier { get; set; }
        public string Branch { get; set; }
        public string BSAcct { get; set; }
        public string AT { get; set; }
        public string SpGLAssignment { get; set; }
        public DateTime? BlineDate { get; set; }
        public string PayT { get; set; }
        public string Day1 { get; set; }
        public string Day2 { get; set; }
        public string Net { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string SourceFile { get; set; }

        public Domains.BSEGModel MapToDomain()
        {
            return new Domains.BSEGModel()
            {
                Id = this.Id,
                Cl = this.Cl,
                CoCd = this.CoCd,
                DocumentNo = this.DocumentNo,
                Year = this.Year,
                Itm = this.Itm,
                LID = this.LID,
                Clearing = this.Clearing,
                ClgEntDate = this.ClgEntDate,
                ClrngDoc = this.ClrngDoc,
                PK = this.PK,
                AccTy = this.AccTy,
                SG = this.SG,
                TransType = this.TransType,
                TrgtSpecialGLInd = this.TrgtSpecialGLInd,
                DC = this.DC,
                BusA = this.BusA,
                TPBA = this.TPBA,
                Tx = this.Tx,
                WT = this.WT,
                LocCurrAmount = this.LocCurrAmount,
                Amount = this.Amount,
                OrigReduction = this.OrigReduction,
                GeneralLedgerAmount = this.GeneralLedgerAmount,
                Curr = this.Curr,
                OriginalTaxBaseAmount = this.OriginalTaxBaseAmount,
                LCTaxAmount = this.LCTaxAmount,
                TaxAmount = this.TaxAmount,
                LCTaxBaseAmount = this.LCTaxBaseAmount,
                TaxBase = this.TaxBase,
                LCProvision = this.LCProvision,
                AdditionalTax = this.AdditionalTax,
                CashDiscount = this.CashDiscount,
                VersionNumberComponent = this.VersionNumberComponent,
                Typ = this.Typ,
                GrI = this.GrI,
                Trs = this.Trs,
                WTaxBase = this.WTaxBase,
                HedgedER = this.HedgedER,
                HedgedAmount = this.HedgedAmount,
                ValuationDifference = this.ValuationDifference,
                ValuationDifference2 = this.ValuationDifference2,
                ValueDate = this.ValueDate,
                Assignment = this.Assignment,
                Text = this.Text,
                IntBlock = this.IntBlock,
                TrPrt = this.TrPrt,
                TTy = this.TTy,
                GroupAcct = this.GroupAcct,
                TrTy = this.TrTy,
                Level = this.Level,
                PlanGrp = this.PlanGrp,
                PlannedAmount = this.PlannedAmount,
                PlanDate = this.PlanDate,
                FBI = this.FBI,
                COAr = this.COAr,
                CostCtr = this.CostCtr,
                NotInUse = this.NotInUse,
                Order = this.Order,
                BillDoc = this.BillDoc,
                SalesDoc = this.SalesDoc,
                Item = this.Item,
                SLNo = this.SLNo,
                Asset = this.Asset,
                SNo = this.SNo,
                TTyAsset = this.TTyAsset,
                AssetValDate = this.AssetValDate,
                PersNo = this.PersNo,
                Sl = this.Sl,
                Indicator = this.Indicator,
                LineItemDisplayPossible = this.LineItemDisplayPossible,
                OIManagement = this.OIManagement,
                IndividSet = this.IndividSet,
                CS = this.CS,
                OS = this.OS,
                SP = this.SP,
                PS = this.PS,
                XFAKT = this.XFAKT,
                XUMAN = this.XUMAN,
                XANET = this.XANET,
                WD = this.WD,
                InvestmentID = this.InvestmentID,
                Dis = this.Dis,
                Aut = this.Aut,
                ItemsCannotBeCopiedIndicator = this.ItemsCannotBeCopiedIndicator,
                Payment = this.Payment,
                GLAcct = this.GLAcct,
                GLCustomer = this.GLCustomer,
                GLSupplier = this.GLSupplier,
                Branch = this.Branch,
                BSAcct = this.BSAcct,
                AT = this.AT,
                SpGLAssignment = this.SpGLAssignment,
                BlineDate = this.BlineDate,
                PayT = this.PayT,
                Day1 = this.Day1,
                Day2 = this.Day2,
                Net = this.Net,
            };
        }
    }
}