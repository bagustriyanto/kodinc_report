using Newtonsoft.Json;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using ReportService.Helpers;
using ReportService.Models;
using ReportService.Repositories.Interfaces;

namespace ReportService.Services
{
    public sealed class PopulateBSEGQueueService : IHostedService
    {
        private readonly AppLogger logger;
        private readonly IServiceScopeFactory serviceScopeFactory;
        private readonly IUnitOfWork unitOfWork;
        private readonly ICacheRepository cacheRepository;
        public PopulateBSEGQueueService(AppLogger logger, IServiceScopeFactory serviceScopeFactory, ICacheRepository cacheRepository)
        {
            this.cacheRepository = cacheRepository;
            this.logger = logger;
            this.serviceScopeFactory = serviceScopeFactory;

            unitOfWork = serviceScopeFactory.CreateScope().ServiceProvider.GetRequiredService<IUnitOfWork>();
        }
        public Task StartAsync(CancellationToken cancellationToken)
        {
            Task.Run(async () =>
            {
                while (!cancellationToken.IsCancellationRequested)
                {
                    await Task.Delay(5000);
                    try
                    {
                        var historyCache = cacheRepository.Get("UploadHistory");
                        HistoryModel historyData = null;
                        var historyInProgressOrFailedData = await unitOfWork.historyRepository.GetByFilter(m => m.Status.Equals(AppConstant.PROGRESS) || m.Status.Equals(AppConstant.FAILED), cancellationToken);

                        if (!string.IsNullOrEmpty(historyCache))
                        {
                            historyData = JsonConvert.DeserializeObject<HistoryModel>(historyCache);
                        }
                        else
                        {
                            var historyDataDb = await unitOfWork.historyRepository.GetLastHistory(AppConstant.INITIALIZE, cancellationToken);

                            if (historyDataDb is not null && historyInProgressOrFailedData is null)
                            {
                                historyData = new HistoryModel();
                                historyData = historyData.MapFromDomain(historyDataDb);

                                cacheRepository.Add("UploadHistory", JsonConvert.SerializeObject(historyData), null);
                            }
                        }

                        if (historyData is not null && historyInProgressOrFailedData is null)
                        {
                            // update upload history to processing
                            var existingHistory = await unitOfWork.historyRepository.GetById(historyData.Id);
                            if (existingHistory != null && existingHistory.Status == AppConstant.INITIALIZE)
                            {
                                existingHistory.Status = AppConstant.PROGRESS;
                                existingHistory.StartTime = DateTime.Now;

                                unitOfWork.historyRepository.Update(existingHistory);
                                await unitOfWork.Save();

                                cacheRepository.Add("UploadHistory", JsonConvert.SerializeObject(existingHistory), null);

                                int lastRowSuccess = existingHistory.LastRowSuccess;

                                // get rows from file and then insert to the db
                                //logger.Info(nameof(PopulateBSEGQueueService), "Start read file");
                                IWorkbook workbook = new XSSFWorkbook(historyData.FilePath);
                                //logger.Info(nameof(PopulateBSEGQueueService), "Finish read file");
                                ISheet sheet = workbook.GetSheetAt(0);

                                bool loop_continue = true;
                                for (int rowIndex = lastRowSuccess; rowIndex <= sheet.LastRowNum - 1; rowIndex++)
                                {
                                    IRow row = sheet.GetRow(rowIndex);

                                    if (rowIndex > 0)
                                    {
                                        if (row is not null && historyData.FileName.Contains("BKPF"))
                                        {
                                            loop_continue = await ProcessingBKPFFile(row, historyData.Id, historyData.FileName, cancellationToken);

                                            if (!loop_continue)
                                            {
                                                break;
                                            }
                                        }
                                        else if (row is not null && historyData.FileName.Contains("BSEG"))
                                        {
                                            loop_continue = await ProcessingBSEGFile(row, historyData.FileName, cancellationToken);

                                            if (!loop_continue)
                                            {
                                                break;
                                            }
                                        }
                                    }
                                }

                                workbook.Close();

                                existingHistory.Status = AppConstant.FINISH;
                                if (!loop_continue)
                                {
                                    existingHistory.Status = AppConstant.FAILED;
                                }

                                existingHistory.FinishTime = DateTime.Now;
                                unitOfWork.historyRepository.Update(existingHistory);
                                await unitOfWork.Save();

                                cacheRepository.Remove("UploadHistory");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        logger.Error(nameof(PopulateBSEGQueueService), ex.Message, ex);
                    }
                }
            });

            return Task.CompletedTask;
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }

        private async Task<bool> ProcessingBKPFFile(IRow row, Guid historyId, string sourceFile, CancellationToken cancellationToken)
        {
            try
            {
                if (row is not null)
                {
                    BKPFModel model = new BKPFModel();

                    model.Id = Guid.NewGuid();
                    model.GI = row.GetCell(0).StringCellValue;
                    model.CoCd = row.GetCell(1).StringCellValue;
                    model.DocumentNo = row.GetCell(2).StringCellValue;
                    model.Year = row.GetCell(3).StringCellValue != null ? int.Parse(row.GetCell(3).StringCellValue.Replace("'", "")) : 0;
                    model.DocType = row.GetCell(4).StringCellValue;
                    model.DocDate = row.GetCell(5).DateCellValue.ToString("yyyy-MM-dd");
                    model.PostingDate = row.GetCell(6).DateCellValue.ToString("yyyy-MM-dd");
                    model.Posting = row.GetCell(7).StringCellValue;
                    model.EntryDate = row.GetCell(8).DateCellValue.ToString("yyyy-MM-dd");
                    model.Time = row.GetCell(9).DateCellValue.ToString("HH:mm:ss");
                    model.Changed = row.GetCell(10).StringCellValue;
                    model.LastUpdate = row.GetCell(11).StringCellValue;
                    model.TransIDDate = row.GetCell(12).DateCellValue.ToString("yyyy-MM-dd");
                    model.Username = row.GetCell(13).StringCellValue;
                    model.TCode = row.GetCell(14).StringCellValue;
                    model.CrossCCodeNo = row.GetCell(15) != null ? row.GetCell(15).StringCellValue : "";
                    model.Reference = row.GetCell(16) != null ? row.GetCell(16).StringCellValue : "";
                    model.RecEntDoc = row.GetCell(17) != null ? row.GetCell(17).StringCellValue : "";
                    model.RevWith = row.GetCell(18) != null ? row.GetCell(18).StringCellValue : "";
                    model.DocHeaderText = row.GetCell(20) != null ? row.GetCell(20).StringCellValue : "";
                    model.Currency = row.GetCell(21) != null ? row.GetCell(21).StringCellValue : "";
                    model.ExcRate = decimal.Parse(row.GetCell(22).NumericCellValue.ToString());
                    model.GroupCurrency = row.GetCell(23) != null ? row.GetCell(23).StringCellValue : "";
                    model.GroupExcRate = decimal.Parse(row.GetCell(24).NumericCellValue.ToString());
                    model.S = row.GetCell(25) != null ? row.GetCell(25).StringCellValue : "";
                    model.NetDocType = row.GetCell(26) != null ? row.GetCell(26).StringCellValue : "";
                    model.UnDelCts = row.GetCell(27) != null ? row.GetCell(27).NumericCellValue.ToString() : "";
                    model.I = row.GetCell(28) != null ? row.GetCell(28).StringCellValue : "";
                    model.Tran = row.GetCell(29) != null ? row.GetCell(29).StringCellValue : "";
                    model.SessionName = row.GetCell(30) != null ? row.GetCell(30).StringCellValue : "";
                    model.DocNameArchiveSys = row.GetCell(31) != null ? row.GetCell(31).StringCellValue : "";
                    model.ExtractID = row.GetCell(32) != null ? row.GetCell(32).StringCellValue : "";
                    model.DT = row.GetCell(33) != null ? row.GetCell(33).StringCellValue : "";
                    model.RefProc = row.GetCell(34) != null ? row.GetCell(34).StringCellValue : "";
                    model.ObjectKey = row.GetCell(35) != null ? row.GetCell(35).StringCellValue : "";
                    model.FMA = row.GetCell(36) != null ? row.GetCell(36).StringCellValue : "";
                    model.LCurr = row.GetCell(37) != null ? row.GetCell(37).StringCellValue : "";
                    model.LCurr2 = row.GetCell(38) != null ? row.GetCell(38).StringCellValue : "";
                    model.LCurr3 = row.GetCell(39) != null ? row.GetCell(39).StringCellValue : "";
                    model.ExcRate2 = decimal.Parse(row.GetCell(40).NumericCellValue.ToString());
                    model.ExcRate3 = decimal.Parse(row.GetCell(41).NumericCellValue.ToString());
                    model.SC = row.GetCell(42) != null ? row.GetCell(42).StringCellValue : "";
                    model.SC2 = row.GetCell(43) != null ? row.GetCell(43).StringCellValue : "";
                    model.Translation = row.GetCell(44) != null ? row.GetCell(44).StringCellValue : "";
                    model.TranslationDate = row.GetCell(45) != null ? row.GetCell(45).StringCellValue : "";
                    model.ReversalFlag = row.GetCell(46) != null ? row.GetCell(46).StringCellValue : "";
                    model.ReversalDate = row.GetCell(47) != null ? row.GetCell(47).StringCellValue : "";
                    model.Calculate = row.GetCell(48) != null ? row.GetCell(48).StringCellValue : "";
                    model.CT = row.GetCell(49) != null ? row.GetCell(49).StringCellValue : "";
                    model.CT2 = row.GetCell(50) != null ? row.GetCell(50).StringCellValue : "";
                    model.ERTy = row.GetCell(51) != null ? row.GetCell(51).StringCellValue : "";
                    model.ERTy2 = row.GetCell(52) != null ? row.GetCell(52).StringCellValue : "";
                    model.CalculateTax = row.GetCell(53) != null ? row.GetCell(53).StringCellValue : "";
                    model.SCCd = row.GetCell(54) != null ? row.GetCell(54).StringCellValue : "";
                    model.TaxDetailChanged = row.GetCell(55) != null ? row.GetCell(55).StringCellValue : "";
                    model.StatusDataTransferNextRelease = row.GetCell(56) != null ? row.GetCell(56).StringCellValue : "";
                    model.LogSystem = row.GetCell(57) != null ? row.GetCell(57).StringCellValue : "";
                    model.TaxRate = row.GetCell(58) != null ? row.GetCell(58).NumericCellValue.ToString() : "";
                    model.TaxRateLC = row.GetCell(59) != null ? row.GetCell(59).NumericCellValue.ToString() : "";
                    model.RequestNo = row.GetCell(60) != null ? row.GetCell(60).StringCellValue : "";
                    model.CustomerBillBeforeDueDate = row.GetCell(51) != null ? row.GetCell(51).StringCellValue : "";
                    model.RevReas = row.GetCell(62) != null ? row.GetCell(62).StringCellValue : "";
                    model.ParkedBy = row.GetCell(63) != null ? row.GetCell(63).StringCellValue : "";
                    model.ParkingDate = row.GetCell(64) != null ? row.GetCell(64).StringCellValue : "";
                    model.Time2 = row.GetCell(65) != null ? row.GetCell(65).DateCellValue.ToString("HH:mm:ss") : "";
                    model.ParkedWith = row.GetCell(66) != null ? row.GetCell(66).StringCellValue : "";
                    model.BranchNo = row.GetCell(67) != null ? row.GetCell(67).StringCellValue : "";
                    model.Pages = row.GetCell(68) != null ? row.GetCell(68).StringCellValue : "";
                    model.DisDoc = row.GetCell(69) != null ? row.GetCell(69).StringCellValue : "";
                    model.RefKey1 = row.GetCell(70) != null ? row.GetCell(70).StringCellValue : "";
                    model.RefKey2 = row.GetCell(71) != null ? row.GetCell(71).StringCellValue : "";
                    model.Reversal = row.GetCell(72) != null ? row.GetCell(72).StringCellValue : "";
                    model.IRDate = row.GetCell(73) != null ? row.GetCell(73).StringCellValue : "";
                    model.Ld = row.GetCell(74) != null ? row.GetCell(74).StringCellValue : "";
                    model.Ledger = row.GetCell(75) != null ? row.GetCell(75).StringCellValue : "";
                    model.Mand = row.GetCell(76) != null ? row.GetCell(76).StringCellValue : "";
                    model.AltRefNumber = row.GetCell(77) != null ? row.GetCell(77).StringCellValue : "";
                    model.RepDate = row.GetCell(78) != null ? row.GetCell(78).StringCellValue : "";
                    model.DocType2 = row.GetCell(79) != null ? row.GetCell(79).StringCellValue : "";
                    model.SplitPosting = row.GetCell(80) != null ? row.GetCell(80).StringCellValue : "";
                    model.Cash = row.GetCell(81).StringCellValue != null ? bool.Parse(row.GetCell(81).StringCellValue) : false;
                    model.FollowOnDocIndicator = row.GetCell(82) != null ? row.GetCell(82).StringCellValue : "";
                    model.Reorg = row.GetCell(83) != null ? row.GetCell(83).StringCellValue : "";
                    model.Subs = row.GetCell(84) != null ? row.GetCell(84).StringCellValue : "";
                    model.ERTy3 = row.GetCell(85) != null ? row.GetCell(85).StringCellValue : "";
                    model.MarketDateExcRate = decimal.Parse(row.GetCell(86).NumericCellValue.ToString());
                    model.MarketData = decimal.Parse(row.GetCell(87).NumericCellValue.ToString());
                    model.MarketData2 = decimal.Parse(row.GetCell(88).NumericCellValue.ToString());
                    model.DocOriMultiCurrency = row.GetCell(89) != null ? row.GetCell(89).StringCellValue : "";
                    model.ResubmissionDate = row.GetCell(90) != null ? row.GetCell(90).StringCellValue : "";
                    model.DocStatus = row.GetCell(91) != null ? row.GetCell(91).StringCellValue : "";
                    model.RT = row.GetCell(92) != null ? row.GetCell(92).StringCellValue : "";
                    model.Reason = row.GetCell(93) != null ? row.GetCell(93).StringCellValue : "";
                    model.Region = row.GetCell(94) != null ? row.GetCell(94).StringCellValue : "";
                    model.S2 = row.GetCell(95) != null ? row.GetCell(95).StringCellValue : "";
                    model.FileNumber = row.GetCell(96) != null ? row.GetCell(96).StringCellValue : "";
                    model.IF = row.GetCell(97) != null ? row.GetCell(97).StringCellValue : "";
                    model.InterestCalcDate = row.GetCell(98) != null ? row.GetCell(98).StringCellValue : "";

                    var checkRowExist = await unitOfWork.bkpfRepository.GetOneByFilter(w => w.DocumentNo.Contains(model.DocumentNo), cancellationToken);

                    if (checkRowExist is null)
                    {
                        var map = model.MapToDomain();
                        map.CreatedAt = DateTime.Now;
                        map.SourceFile = sourceFile;
                        await unitOfWork.bkpfRepository.Create(map, cancellationToken);
                    }
                    else
                    {
                        checkRowExist.UpdatedAt = DateTime.Now;
                        checkRowExist.SourceFile = sourceFile;
                        unitOfWork.bkpfRepository.Update(checkRowExist);
                    }

                    await unitOfWork.Save();

                    logger.Info(nameof(PopulateBSEGQueueService), "BKPF Row data", JsonConvert.SerializeObject(model));
                }
                return true;
            }
            catch (Exception ex)
            {
                logger.Error(nameof(PopulateBSEGQueueService), ex.Message, ex);

                return false;
            }
        }

        private async Task<bool> ProcessingBSEGFile(IRow row, string sourceFile, CancellationToken cancellationToken)
        {
            try
            {
                if (row is not null)
                {
                    BSEGModel model = new BSEGModel();
                    model.Cl = row.GetCell(0).StringCellValue.Replace("'", "");
                    model.CoCd = row.GetCell(1).StringCellValue;
                    model.DocumentNo = row.GetCell(2).StringCellValue.Replace("'", "");
                    model.Year = int.Parse(row.GetCell(3).StringCellValue.Replace("'", ""));
                    model.Itm = row.GetCell(4).StringCellValue.Replace("'", "");
                    model.LID = row.GetCell(5) != null ? row.GetCell(5).StringCellValue : "";
                    model.Clearing = row.GetCell(6).DateCellValue.ToString("yyyy-MM-dd");
                    model.ClgEntDate = row.GetCell(7).DateCellValue;
                    model.ClrngDoc = row.GetCell(8).StringCellValue.Replace("'", "");
                    model.PK = int.Parse(row.GetCell(9).StringCellValue.Replace("'", ""));
                    model.AccTy = row.GetCell(10).StringCellValue;
                    model.SG = row.GetCell(11) != null ? row.GetCell(11).StringCellValue : "";
                    model.TransType = row.GetCell(12) != null ? row.GetCell(12).StringCellValue : "";
                    model.TrgtSpecialGLInd = row.GetCell(13) != null ? row.GetCell(13).StringCellValue : "";
                    model.DC = row.GetCell(14).StringCellValue;
                    model.BusA = row.GetCell(15) != null ? row.GetCell(15).StringCellValue : "";
                    model.TPBA = row.GetCell(16) != null ? row.GetCell(16).StringCellValue : "";
                    model.Tx = row.GetCell(17) != null ? row.GetCell(17).StringCellValue : "";
                    model.WT = row.GetCell(18) != null ? row.GetCell(18).StringCellValue : "";
                    model.LocCurrAmount = decimal.Parse(row.GetCell(19).NumericCellValue.ToString());
                    model.Amount = decimal.Parse(row.GetCell(20).NumericCellValue.ToString());
                    model.OrigReduction = decimal.Parse(row.GetCell(21).NumericCellValue.ToString());
                    model.GeneralLedgerAmount = decimal.Parse(row.GetCell(22).NumericCellValue.ToString());
                    model.Curr = row.GetCell(23).StringCellValue;
                    model.OriginalTaxBaseAmount = decimal.Parse(row.GetCell(24).NumericCellValue.ToString());
                    model.LCTaxAmount = decimal.Parse(row.GetCell(25).NumericCellValue.ToString());
                    model.TaxAmount = decimal.Parse(row.GetCell(26).NumericCellValue.ToString());
                    model.LCTaxBaseAmount = decimal.Parse(row.GetCell(27).NumericCellValue.ToString());
                    model.TaxBase = decimal.Parse(row.GetCell(28).NumericCellValue.ToString());
                    model.LCProvision = decimal.Parse(row.GetCell(29).NumericCellValue.ToString());
                    model.AdditionalTax = decimal.Parse(row.GetCell(30).NumericCellValue.ToString());
                    model.CashDiscount = row.GetCell(31) != null ? decimal.Parse(row.GetCell(31).StringCellValue) : 0;
                    model.VersionNumberComponent = row.GetCell(32) != null ? int.Parse(row.GetCell(32).StringCellValue) : 0;
                    model.Typ = row.GetCell(33) != null ? row.GetCell(33).StringCellValue : "";
                    model.GrI = row.GetCell(32).StringCellValue;
                    model.Trs = row.GetCell(33) != null ? row.GetCell(33).StringCellValue : "";
                    model.WTaxBase = decimal.Parse(row.GetCell(34).NumericCellValue.ToString());
                    model.HedgedER = decimal.Parse(row.GetCell(35).NumericCellValue.ToString());
                    model.HedgedAmount = decimal.Parse(row.GetCell(36).NumericCellValue.ToString());
                    model.ValuationDifference = decimal.Parse(row.GetCell(37).NumericCellValue.ToString());
                    model.ValuationDifference2 = decimal.Parse(row.GetCell(38).NumericCellValue.ToString());
                    model.ValueDate = row.GetCell(39) != null ? row.GetCell(39).DateCellValue : null;
                    model.Assignment = row.GetCell(40).StringCellValue;
                    model.Text = row.GetCell(41) != null ? row.GetCell(41).StringCellValue : "";
                    model.IntBlock = row.GetCell(42) != null ? row.GetCell(42).StringCellValue : "";
                    model.TrPrt = row.GetCell(43) != null ? row.GetCell(43).StringCellValue : "";
                    model.TTy = row.GetCell(44) != null ? row.GetCell(44).StringCellValue : "";
                    model.GroupAcct = row.GetCell(45) != null ? row.GetCell(45).StringCellValue : "";
                    model.TrTy = row.GetCell(46) != null ? row.GetCell(46).StringCellValue : "";
                    model.Level = row.GetCell(47) != null ? row.GetCell(47).StringCellValue : "";
                    model.PlanGrp = row.GetCell(48) != null ? row.GetCell(48).StringCellValue : "";
                    model.PlannedAmount = decimal.Parse(row.GetCell(49).NumericCellValue.ToString());
                    model.PlanDate = row.GetCell(50) != null ? row.GetCell(50).DateCellValue : null;
                    model.FBI = row.GetCell(51) != null ? row.GetCell(51).StringCellValue.Replace("'", "") : "";
                    model.COAr = row.GetCell(52) != null ? row.GetCell(52).StringCellValue : "";
                    model.CostCtr = row.GetCell(53) != null ? row.GetCell(53).StringCellValue : "";
                    model.NotInUse = row.GetCell(54) != null ? row.GetCell(54).StringCellValue : "";
                    model.Order = row.GetCell(55) != null ? row.GetCell(55).StringCellValue : "";
                    model.BillDoc = row.GetCell(56) != null ? row.GetCell(56).StringCellValue : "";
                    model.SalesDoc = row.GetCell(57) != null ? row.GetCell(57).StringCellValue : "";
                    model.Item = row.GetCell(58) != null ? row.GetCell(58).StringCellValue.Replace("'", "") : "";
                    model.SLNo = row.GetCell(59) != null ? row.GetCell(59).StringCellValue.Replace("'", "") : "";
                    model.Asset = row.GetCell(60) != null ? row.GetCell(60).StringCellValue.Replace("'", "") : "";
                    model.SNo = row.GetCell(61) != null ? row.GetCell(61).StringCellValue.Replace("'", "") : "";
                    model.TTyAsset = row.GetCell(62) != null ? row.GetCell(62).StringCellValue.Replace("'", "") : "";
                    model.AssetValDate = row.GetCell(63) != null ? row.GetCell(63).DateCellValue : null;
                    model.PersNo = row.GetCell(64) != null ? row.GetCell(64).StringCellValue.Replace("'", "") : "";
                    model.Sl = row.GetCell(65) != null ? row.GetCell(65).StringCellValue.Replace("'", "") : "";
                    model.Indicator = row.GetCell(66) != null ? row.GetCell(66).StringCellValue.Replace("'", "") : "";
                    model.LineItemDisplayPossible = row.GetCell(67) != null ? row.GetCell(67).StringCellValue.Replace("'", "") == "X" ? true : false : false;
                    model.OIManagement = row.GetCell(68) != null ? row.GetCell(68).StringCellValue.Replace("'", "") : "";
                    model.IndividSet = row.GetCell(69) != null ? row.GetCell(69).StringCellValue.Replace("'", "") : "";
                    model.CS = row.GetCell(70) != null ? row.GetCell(70).StringCellValue.Replace("'", "") : "";
                    model.OS = row.GetCell(71) != null ? row.GetCell(71).StringCellValue.Replace("'", "") : "";
                    model.SP = row.GetCell(72) != null ? row.GetCell(72).StringCellValue.Replace("'", "") : "";
                    model.PS = row.GetCell(73) != null ? row.GetCell(73).StringCellValue.Replace("'", "") : "";
                    model.XFAKT = row.GetCell(74) != null ? row.GetCell(74).StringCellValue.Replace("'", "") : "";
                    model.XUMAN = row.GetCell(75) != null ? row.GetCell(75).StringCellValue.Replace("'", "") : "";
                    model.XANET = row.GetCell(76) != null ? row.GetCell(76).StringCellValue.Replace("'", "") : "";
                    model.WD = row.GetCell(77) != null ? row.GetCell(77).StringCellValue.Replace("'", "") : "";
                    model.InvestmentID = row.GetCell(79) != null ? row.GetCell(79).StringCellValue.Replace("'", "") : "";
                    model.Dis = row.GetCell(80) != null ? row.GetCell(80).StringCellValue.Replace("'", "") : "";
                    model.Aut = row.GetCell(81) != null ? row.GetCell(81).StringCellValue.Replace("'", "") : "";
                    model.ItemsCannotBeCopiedIndicator = row.GetCell(82) != null ? row.GetCell(82).StringCellValue.Replace("'", "") : "";
                    model.Payment = row.GetCell(83) != null ? row.GetCell(83).StringCellValue.Replace("'", "") : "";
                    model.GLAcct = row.GetCell(84) != null ? row.GetCell(84).StringCellValue.Replace("'", "") : "";
                    model.GLCustomer = row.GetCell(85) != null ? row.GetCell(85).StringCellValue.Replace("'", "") : "";
                    model.GLSupplier = row.GetCell(86) != null ? row.GetCell(86).StringCellValue.Replace("'", "") : "";
                    model.Branch = row.GetCell(87) != null ? row.GetCell(87).StringCellValue.Replace("'", "") : "";
                    model.BSAcct = row.GetCell(88) != null ? row.GetCell(88).StringCellValue.Replace("'", "") : "";
                    model.AT = row.GetCell(89) != null ? row.GetCell(89).StringCellValue.Replace("'", "") : "";
                    model.SpGLAssignment = row.GetCell(90) != null ? row.GetCell(90).StringCellValue.Replace("'", "") : "";
                    model.BlineDate = row.GetCell(91) != null ? row.GetCell(91).DateCellValue : null;
                    model.PayT = row.GetCell(92) != null ? row.GetCell(92).StringCellValue.Replace("'", "") : "";
                    model.Day1 = row.GetCell(93).NumericCellValue.ToString();
                    model.Day2 = row.GetCell(94).NumericCellValue.ToString();
                    model.Net = row.GetCell(95).NumericCellValue.ToString();

                    var checkRowExist = await unitOfWork.bsegRepository.GetOneByFilter(w => w.DocumentNo.Contains(model.DocumentNo), cancellationToken);

                    if (checkRowExist is null)
                    {
                        var map = model.MapToDomain();
                        map.CreatedAt = DateTime.Now;
                        map.SourceFile = sourceFile;
                        await unitOfWork.bsegRepository.Create(map, cancellationToken);
                    }
                    else
                    {
                        checkRowExist.UpdatedAt = DateTime.Now;
                        checkRowExist.SourceFile = sourceFile;
                        unitOfWork.bsegRepository.Update(checkRowExist);
                    }

                    await unitOfWork.Save();

                    logger.Info(nameof(PopulateBSEGQueueService), "BSEG Row data", JsonConvert.SerializeObject(model));
                }

                return true;
            }
            catch (Exception ex)
            {

                logger.Error(nameof(PopulateBSEGQueueService), ex.Message, ex);

                return false;
            }
        }
    }
}