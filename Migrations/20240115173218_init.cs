using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ReportService.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "BKPFModels",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false),
                    GI = table.Column<string>(type: "longtext", nullable: true),
                    CoCd = table.Column<string>(type: "longtext", nullable: true),
                    DocumentNo = table.Column<string>(type: "longtext", nullable: true),
                    Year = table.Column<int>(type: "int", nullable: false),
                    DocType = table.Column<string>(type: "longtext", nullable: true),
                    DocDate = table.Column<string>(type: "longtext", nullable: true),
                    PostingDate = table.Column<string>(type: "longtext", nullable: true),
                    Posting = table.Column<string>(type: "longtext", nullable: true),
                    EntryDate = table.Column<string>(type: "longtext", nullable: true),
                    Time = table.Column<string>(type: "longtext", nullable: true),
                    Changed = table.Column<string>(type: "longtext", nullable: true),
                    LastUpdate = table.Column<string>(type: "longtext", nullable: true),
                    TransIDDate = table.Column<string>(type: "longtext", nullable: true),
                    Username = table.Column<string>(type: "longtext", nullable: true),
                    TCode = table.Column<string>(type: "longtext", nullable: true),
                    CrossCCodeNo = table.Column<string>(type: "longtext", nullable: true),
                    Reference = table.Column<string>(type: "longtext", nullable: true),
                    RecEntDoc = table.Column<string>(type: "longtext", nullable: true),
                    RevWith = table.Column<string>(type: "longtext", nullable: true),
                    DocHeaderText = table.Column<string>(type: "longtext", nullable: true),
                    Currency = table.Column<string>(type: "longtext", nullable: true),
                    ExcRate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    GroupCurrency = table.Column<string>(type: "longtext", nullable: true),
                    GroupExcRate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    S = table.Column<string>(type: "longtext", nullable: true),
                    NetDocType = table.Column<string>(type: "longtext", nullable: true),
                    UnDelCts = table.Column<string>(type: "longtext", nullable: true),
                    I = table.Column<string>(type: "longtext", nullable: true),
                    Tran = table.Column<string>(type: "longtext", nullable: true),
                    SessionName = table.Column<string>(type: "longtext", nullable: true),
                    DocNameArchiveSys = table.Column<string>(type: "longtext", nullable: true),
                    ExtractID = table.Column<string>(type: "longtext", nullable: true),
                    DT = table.Column<string>(type: "longtext", nullable: true),
                    RefProc = table.Column<string>(type: "longtext", nullable: true),
                    ObjectKey = table.Column<string>(type: "longtext", nullable: true),
                    FMA = table.Column<string>(type: "longtext", nullable: true),
                    LCurr = table.Column<string>(type: "longtext", nullable: true),
                    LCurr2 = table.Column<string>(type: "longtext", nullable: true),
                    LCurr3 = table.Column<string>(type: "longtext", nullable: true),
                    ExcRate2 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ExcRate3 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SC = table.Column<string>(type: "longtext", nullable: true),
                    SC2 = table.Column<string>(type: "longtext", nullable: true),
                    Translation = table.Column<string>(type: "longtext", nullable: true),
                    TranslationDate = table.Column<string>(type: "longtext", nullable: true),
                    ReversalFlag = table.Column<string>(type: "longtext", nullable: true),
                    ReversalDate = table.Column<string>(type: "longtext", nullable: true),
                    Calculate = table.Column<string>(type: "longtext", nullable: true),
                    CT = table.Column<string>(type: "longtext", nullable: true),
                    CT2 = table.Column<string>(type: "longtext", nullable: true),
                    ERTy = table.Column<string>(type: "longtext", nullable: true),
                    ERTy2 = table.Column<string>(type: "longtext", nullable: true),
                    CalculateTax = table.Column<string>(type: "longtext", nullable: true),
                    SCCd = table.Column<string>(type: "longtext", nullable: true),
                    TaxDetailChanged = table.Column<string>(type: "longtext", nullable: true),
                    StatusDataTransferNextRelease = table.Column<string>(type: "longtext", nullable: true),
                    LogSystem = table.Column<string>(type: "longtext", nullable: true),
                    TaxRate = table.Column<string>(type: "longtext", nullable: true),
                    TaxRateLC = table.Column<string>(type: "longtext", nullable: true),
                    RequestNo = table.Column<string>(type: "longtext", nullable: true),
                    CustomerBillBeforeDueDate = table.Column<string>(type: "longtext", nullable: true),
                    RevReas = table.Column<string>(type: "longtext", nullable: true),
                    ParkedBy = table.Column<string>(type: "longtext", nullable: true),
                    ParkingDate = table.Column<string>(type: "longtext", nullable: true),
                    Time2 = table.Column<string>(type: "longtext", nullable: true),
                    ParkedWith = table.Column<string>(type: "longtext", nullable: true),
                    BranchNo = table.Column<string>(type: "longtext", nullable: true),
                    Pages = table.Column<string>(type: "longtext", nullable: true),
                    DisDoc = table.Column<string>(type: "longtext", nullable: true),
                    RefKey1 = table.Column<string>(type: "longtext", nullable: true),
                    RefKey2 = table.Column<string>(type: "longtext", nullable: true),
                    Reversal = table.Column<string>(type: "longtext", nullable: true),
                    IRDate = table.Column<string>(type: "longtext", nullable: true),
                    Ld = table.Column<string>(type: "longtext", nullable: true),
                    Ledger = table.Column<string>(type: "longtext", nullable: true),
                    Mand = table.Column<string>(type: "longtext", nullable: true),
                    AltRefNumber = table.Column<string>(type: "longtext", nullable: true),
                    RepDate = table.Column<string>(type: "longtext", nullable: true),
                    DocType2 = table.Column<string>(type: "longtext", nullable: true),
                    SplitPosting = table.Column<string>(type: "longtext", nullable: true),
                    Cash = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    FollowOnDocIndicator = table.Column<string>(type: "longtext", nullable: true),
                    Reorg = table.Column<string>(type: "longtext", nullable: true),
                    Subs = table.Column<string>(type: "longtext", nullable: true),
                    ERTy3 = table.Column<string>(type: "longtext", nullable: true),
                    MarketDateExcRate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MarketData = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MarketData2 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DocOriMultiCurrency = table.Column<string>(type: "longtext", nullable: true),
                    ResubmissionDate = table.Column<string>(type: "longtext", nullable: true),
                    DocStatus = table.Column<string>(type: "longtext", nullable: true),
                    RT = table.Column<string>(type: "longtext", nullable: true),
                    Reason = table.Column<string>(type: "longtext", nullable: true),
                    Region = table.Column<string>(type: "longtext", nullable: true),
                    S2 = table.Column<string>(type: "longtext", nullable: true),
                    FileNumber = table.Column<string>(type: "longtext", nullable: true),
                    IF = table.Column<string>(type: "longtext", nullable: true),
                    InterestCalcDate = table.Column<string>(type: "longtext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BKPFModels", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "BSEGModels",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false),
                    Cl = table.Column<string>(type: "longtext", nullable: true),
                    CoCd = table.Column<string>(type: "longtext", nullable: true),
                    DocumentNo = table.Column<string>(type: "longtext", nullable: true),
                    Year = table.Column<int>(type: "int", nullable: true),
                    Itm = table.Column<string>(type: "longtext", nullable: true),
                    LID = table.Column<string>(type: "longtext", nullable: true),
                    Clearing = table.Column<string>(type: "longtext", nullable: true),
                    ClgEntDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ClrngDoc = table.Column<string>(type: "longtext", nullable: true),
                    PK = table.Column<int>(type: "int", nullable: true),
                    AccTy = table.Column<string>(type: "longtext", nullable: true),
                    SG = table.Column<string>(type: "longtext", nullable: true),
                    TransType = table.Column<string>(type: "longtext", nullable: true),
                    TrgtSpecialGLInd = table.Column<string>(type: "longtext", nullable: true),
                    DC = table.Column<string>(type: "longtext", nullable: true),
                    BusA = table.Column<string>(type: "longtext", nullable: true),
                    TPBA = table.Column<string>(type: "longtext", nullable: true),
                    Tx = table.Column<string>(type: "longtext", nullable: true),
                    WT = table.Column<string>(type: "longtext", nullable: true),
                    LocCurrAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OrigReduction = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    GeneralLedgerAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Curr = table.Column<string>(type: "longtext", nullable: true),
                    OriginalTaxBaseAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    LCTaxAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TaxAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    LCTaxBaseAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TaxBase = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    LCProvision = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AdditionalTax = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CashDiscount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    VersionNumberComponent = table.Column<int>(type: "int", nullable: true),
                    Typ = table.Column<string>(type: "longtext", nullable: true),
                    GrI = table.Column<string>(type: "longtext", nullable: true),
                    Trs = table.Column<string>(type: "longtext", nullable: true),
                    WTaxBase = table.Column<string>(type: "longtext", nullable: true),
                    HedgedER = table.Column<string>(type: "longtext", nullable: true),
                    HedgedAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ValuationDifference = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ValuationDifference2 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ValueDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Assignment = table.Column<string>(type: "longtext", nullable: true),
                    Text = table.Column<string>(type: "longtext", nullable: true),
                    IntBlock = table.Column<string>(type: "longtext", nullable: true),
                    TrPrt = table.Column<string>(type: "longtext", nullable: true),
                    TTy = table.Column<string>(type: "longtext", nullable: true),
                    GroupAcct = table.Column<string>(type: "longtext", nullable: true),
                    TrTy = table.Column<string>(type: "longtext", nullable: true),
                    Level = table.Column<string>(type: "longtext", nullable: true),
                    PlanGrp = table.Column<string>(type: "longtext", nullable: true),
                    PlannedAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PlanDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    FBI = table.Column<string>(type: "longtext", nullable: true),
                    COAr = table.Column<string>(type: "longtext", nullable: true),
                    CostCtr = table.Column<string>(type: "longtext", nullable: true),
                    NotInUse = table.Column<string>(type: "longtext", nullable: true),
                    Order = table.Column<string>(type: "longtext", nullable: true),
                    BillDoc = table.Column<string>(type: "longtext", nullable: true),
                    SalesDoc = table.Column<string>(type: "longtext", nullable: true),
                    Item = table.Column<string>(type: "longtext", nullable: true),
                    SLNo = table.Column<string>(type: "longtext", nullable: true),
                    Asset = table.Column<string>(type: "longtext", nullable: true),
                    SNo = table.Column<string>(type: "longtext", nullable: true),
                    TTyAsset = table.Column<string>(type: "longtext", nullable: true),
                    AssetValDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    PersNo = table.Column<string>(type: "longtext", nullable: true),
                    SlIndicator = table.Column<string>(type: "longtext", nullable: true),
                    LineItemDisplayPossible = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    OIManagement = table.Column<string>(type: "longtext", nullable: true),
                    IndividSet = table.Column<string>(type: "longtext", nullable: true),
                    CS = table.Column<string>(type: "longtext", nullable: true),
                    OS = table.Column<string>(type: "longtext", nullable: true),
                    SP = table.Column<string>(type: "longtext", nullable: true),
                    PS = table.Column<string>(type: "longtext", nullable: true),
                    XFAKT = table.Column<string>(type: "longtext", nullable: true),
                    XUMAN = table.Column<string>(type: "longtext", nullable: true),
                    XANET = table.Column<string>(type: "longtext", nullable: true),
                    WD = table.Column<string>(type: "longtext", nullable: true),
                    InvestmentID = table.Column<string>(type: "longtext", nullable: true),
                    Dis = table.Column<string>(type: "longtext", nullable: true),
                    Aut = table.Column<string>(type: "longtext", nullable: true),
                    ItemsCannotBeCopiedIndicator = table.Column<string>(type: "longtext", nullable: true),
                    Payment = table.Column<string>(type: "longtext", nullable: true),
                    GLAcct = table.Column<string>(type: "longtext", nullable: true),
                    GLCustomer = table.Column<string>(type: "longtext", nullable: true),
                    GLSupplier = table.Column<string>(type: "longtext", nullable: true),
                    Branch = table.Column<string>(type: "longtext", nullable: true),
                    BSAcct = table.Column<string>(type: "longtext", nullable: true),
                    AT = table.Column<string>(type: "longtext", nullable: true),
                    SpGLAssignment = table.Column<string>(type: "longtext", nullable: true),
                    BlineDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    PayT = table.Column<string>(type: "longtext", nullable: true),
                    Day1 = table.Column<string>(type: "longtext", nullable: true),
                    Day2 = table.Column<string>(type: "longtext", nullable: true),
                    Net = table.Column<string>(type: "longtext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BSEGModels", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "F10Models",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false),
                    GLAccount = table.Column<string>(type: "longtext", nullable: true),
                    GLAccountLongText = table.Column<string>(type: "longtext", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_F10Models", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "FileHistoryModels",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false),
                    FileName = table.Column<string>(type: "longtext", nullable: true),
                    FileTimestamp = table.Column<string>(type: "longtext", nullable: true),
                    CreatedAt = table.Column<string>(type: "longtext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FileHistoryModels", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "HistoryModels",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false),
                    FileName = table.Column<string>(type: "longtext", nullable: true),
                    FilePath = table.Column<string>(type: "longtext", nullable: true),
                    Type = table.Column<string>(type: "longtext", nullable: true),
                    StartTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    FinishTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Status = table.Column<string>(type: "longtext", nullable: true),
                    Remark = table.Column<string>(type: "longtext", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistoryModels", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "MKVGModels",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false),
                    Supplier = table.Column<string>(type: "longtext", nullable: true),
                    VendorName = table.Column<string>(type: "longtext", nullable: true),
                    Address = table.Column<string>(type: "longtext", nullable: true),
                    Country = table.Column<string>(type: "longtext", nullable: true),
                    PostalCode = table.Column<string>(type: "longtext", nullable: true),
                    City = table.Column<string>(type: "longtext", nullable: true),
                    AccountGroup = table.Column<string>(type: "longtext", nullable: true),
                    SearchTerm = table.Column<string>(type: "longtext", nullable: true),
                    OneTimeAccount = table.Column<string>(type: "longtext", nullable: true),
                    PurchaseOrg = table.Column<string>(type: "longtext", nullable: true),
                    PurchaseOrgDesc = table.Column<string>(type: "longtext", nullable: true),
                    TermsOfPayment = table.Column<string>(type: "longtext", nullable: true),
                    Incoterms = table.Column<string>(type: "longtext", nullable: true),
                    Incoterms2 = table.Column<string>(type: "longtext", nullable: true),
                    MinOrderVal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OrderCurrency = table.Column<string>(type: "longtext", nullable: true),
                    CentralDelFlag = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    DeleteFlagPurchaseOrg = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MKVGModels", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BKPFModels");

            migrationBuilder.DropTable(
                name: "BSEGModels");

            migrationBuilder.DropTable(
                name: "F10Models");

            migrationBuilder.DropTable(
                name: "FileHistoryModels");

            migrationBuilder.DropTable(
                name: "HistoryModels");

            migrationBuilder.DropTable(
                name: "MKVGModels");
        }
    }
}
