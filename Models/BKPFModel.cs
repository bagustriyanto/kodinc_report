using Domain = ReportService.Domains;

namespace ReportService.Models
{
    public class BKPFModel
    {
        public Guid Id { get; set; }
        public string GI { get; set; }
        public string CoCd { get; set; }
        public string DocumentNo { get; set; }
        public int Year { get; set; }
        public string DocType { get; set; }
        public string DocDate { get; set; }
        public string PostingDate { get; set; }
        public string Posting { get; set; }
        public string EntryDate { get; set; }
        public string Time { get; set; }
        public string Changed { get; set; }
        public string LastUpdate { get; set; }
        public string TransIDDate { get; set; }
        public string Username { get; set; }
        public string TCode { get; set; }
        public string CrossCCodeNo { get; set; }
        public string Reference { get; set; }
        public string RecEntDoc { get; set; }
        public string RevWith { get; set; }
        public string DocHeaderText { get; set; }
        public string Currency { get; set; }
        public decimal ExcRate { get; set; }
        public string GroupCurrency { get; set; }
        public decimal GroupExcRate { get; set; }
        public string S { get; set; }
        public string NetDocType { get; set; }
        public string UnDelCts { get; set; }
        public string I { get; set; }
        public string Tran { get; set; }
        public string SessionName { get; set; }
        public string DocNameArchiveSys { get; set; }
        public string ExtractID { get; set; }
        public string DT { get; set; }
        public string RefProc { get; set; }
        public string ObjectKey { get; set; }
        public string FMA { get; set; }
        public string LCurr { get; set; }
        public string LCurr2 { get; set; }
        public string LCurr3 { get; set; }
        public decimal ExcRate2 { get; set; }
        public decimal ExcRate3 { get; set; }
        public string SC { get; set; }
        public string SC2 { get; set; }
        public string Translation { get; set; }
        public string TranslationDate { get; set; }
        public string ReversalFlag { get; set; }
        public string ReversalDate { get; set; }
        public string Calculate { get; set; }
        public string CT { get; set; }
        public string CT2 { get; set; }
        public string ERTy { get; set; }
        public string ERTy2 { get; set; }
        public string CalculateTax { get; set; }
        public string SCCd { get; set; }
        public string TaxDetailChanged { get; set; }
        public string StatusDataTransferNextRelease { get; set; }
        public string LogSystem { get; set; }
        public string TaxRate { get; set; }
        public string TaxRateLC { get; set; }
        public string RequestNo { get; set; }
        public string CustomerBillBeforeDueDate { get; set; }
        public string RevReas { get; set; }
        public string ParkedBy { get; set; }
        public string ParkingDate { get; set; }
        public string Time2 { get; set; }
        public string ParkedWith { get; set; }
        public string BranchNo { get; set; }
        public string Pages { get; set; }
        public string DisDoc { get; set; }
        public string RefKey1 { get; set; }
        public string RefKey2 { get; set; }
        public string Reversal { get; set; }
        public string IRDate { get; set; }
        public string Ld { get; set; }
        public string Ledger { get; set; }
        public string Mand { get; set; }
        public string AltRefNumber { get; set; }
        public string RepDate { get; set; }
        public string DocType2 { get; set; }
        public string SplitPosting { get; set; }
        public bool Cash { get; set; }
        public string FollowOnDocIndicator { get; set; }
        public string Reorg { get; set; }
        public string Subs { get; set; }
        public string ERTy3 { get; set; }
        public decimal MarketDateExcRate { get; set; }
        public decimal MarketData { get; set; }
        public decimal MarketData2 { get; set; }
        public string DocOriMultiCurrency { get; set; }
        public string ResubmissionDate { get; set; }
        public string DocStatus { get; set; }
        public string RT { get; set; }
        public string Reason { get; set; }
        public string Region { get; set; }
        public string S2 { get; set; }
        public string FileNumber { get; set; }
        public string IF { get; set; }
        public string InterestCalcDate { get; set; }

        public Domain.BKPFModel MapToDomain()
        {
            return new Domain.BKPFModel
            {
                Id = this.Id,
                GI = this.GI,
                CoCd = this.CoCd,
                DocumentNo = this.DocumentNo,
                Year = this.Year,
                DocType = this.DocType,
                DocDate = this.DocDate,
                PostingDate = this.PostingDate,
                Posting = this.Posting,
                EntryDate = this.EntryDate,
                Time = this.Time,
                Changed = this.Changed,
                LastUpdate = this.LastUpdate,
                TransIDDate = this.TransIDDate,
                Username = this.Username,
                TCode = this.TCode,
                CrossCCodeNo = this.CrossCCodeNo,
                Reference = this.Reference,
                RecEntDoc = this.RecEntDoc,
                RevWith = this.RevWith,
                DocHeaderText = this.DocHeaderText,
                Currency = this.Currency,
                ExcRate = this.ExcRate,
                GroupCurrency = this.GroupCurrency,
                GroupExcRate = this.GroupExcRate,
                S = this.S,
                NetDocType = this.NetDocType,
                UnDelCts = this.UnDelCts,
                I = this.I,
                Tran = this.Tran,
                SessionName = this.SessionName,
                DocNameArchiveSys = this.DocNameArchiveSys,
                ExtractID = this.ExtractID,
                DT = this.DT,
                RefProc = this.RefProc,
                ObjectKey = this.ObjectKey,
                FMA = this.FMA,
                LCurr = this.LCurr,
                LCurr2 = this.LCurr2,
                LCurr3 = this.LCurr3,
                ExcRate2 = this.ExcRate2,
                ExcRate3 = this.ExcRate3,
                SC = this.SC,
                SC2 = this.SC2,
                Translation = this.Translation,
                TranslationDate = this.TranslationDate,
                ReversalFlag = this.ReversalFlag,
                ReversalDate = this.ReversalDate,
                Calculate = this.Calculate,
                CT = this.CT,
                CT2 = this.CT2,
                ERTy = this.ERTy,
                ERTy2 = this.ERTy2,
                CalculateTax = this.CalculateTax,
                SCCd = this.SCCd,
                TaxDetailChanged = this.TaxDetailChanged,
                StatusDataTransferNextRelease = this.StatusDataTransferNextRelease,
                LogSystem = this.LogSystem,
                TaxRate = this.TaxRate,
                TaxRateLC = this.TaxRateLC,
                RequestNo = this.RequestNo,
                CustomerBillBeforeDueDate = this.CustomerBillBeforeDueDate,
                RevReas = this.RevReas,
                ParkedBy = this.ParkedBy,
                ParkingDate = this.ParkingDate,
                Time2 = this.Time2,
                ParkedWith = this.ParkedWith,
                BranchNo = this.BranchNo,
                Pages = this.Pages,
                DisDoc = this.DisDoc,
                RefKey1 = this.RefKey1,
                RefKey2 = this.RefKey2,
                Reversal = this.Reversal,
                IRDate = this.IRDate,
                Ld = this.Ld,
                Ledger = this.Ledger,
                Mand = this.Mand,
                AltRefNumber = this.AltRefNumber,
                RepDate = this.RepDate,
                DocType2 = this.DocType2,
                SplitPosting = this.SplitPosting,
                Cash = this.Cash,
                FollowOnDocIndicator = this.FollowOnDocIndicator,
                Reorg = this.Reorg,
                Subs = this.Subs,
                ERTy3 = this.ERTy3,
                MarketDateExcRate = this.MarketDateExcRate,
                MarketData = this.MarketData,
                MarketData2 = this.MarketData2,
                DocOriMultiCurrency = this.DocOriMultiCurrency,
                ResubmissionDate = this.ResubmissionDate,
                DocStatus = this.DocStatus,
                RT = this.RT,
                Reason = this.Reason,
                Region = this.Region,
                S2 = this.S2,
                FileNumber = this.FileNumber,
                IF = this.IF,
                InterestCalcDate = this.InterestCalcDate
            };
        }
    }
}