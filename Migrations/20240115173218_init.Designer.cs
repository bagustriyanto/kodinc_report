﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ReportService;

#nullable disable

namespace ReportService.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240115173218_init")]
    partial class init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ReportService.Domains.BKPFModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("AltRefNumber")
                        .HasColumnType("longtext");

                    b.Property<string>("BranchNo")
                        .HasColumnType("longtext");

                    b.Property<string>("CT")
                        .HasColumnType("longtext");

                    b.Property<string>("CT2")
                        .HasColumnType("longtext");

                    b.Property<string>("Calculate")
                        .HasColumnType("longtext");

                    b.Property<string>("CalculateTax")
                        .HasColumnType("longtext");

                    b.Property<bool>("Cash")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Changed")
                        .HasColumnType("longtext");

                    b.Property<string>("CoCd")
                        .HasColumnType("longtext");

                    b.Property<string>("CrossCCodeNo")
                        .HasColumnType("longtext");

                    b.Property<string>("Currency")
                        .HasColumnType("longtext");

                    b.Property<string>("CustomerBillBeforeDueDate")
                        .HasColumnType("longtext");

                    b.Property<string>("DT")
                        .HasColumnType("longtext");

                    b.Property<string>("DisDoc")
                        .HasColumnType("longtext");

                    b.Property<string>("DocDate")
                        .HasColumnType("longtext");

                    b.Property<string>("DocHeaderText")
                        .HasColumnType("longtext");

                    b.Property<string>("DocNameArchiveSys")
                        .HasColumnType("longtext");

                    b.Property<string>("DocOriMultiCurrency")
                        .HasColumnType("longtext");

                    b.Property<string>("DocStatus")
                        .HasColumnType("longtext");

                    b.Property<string>("DocType")
                        .HasColumnType("longtext");

                    b.Property<string>("DocType2")
                        .HasColumnType("longtext");

                    b.Property<string>("DocumentNo")
                        .HasColumnType("longtext");

                    b.Property<string>("ERTy")
                        .HasColumnType("longtext");

                    b.Property<string>("ERTy2")
                        .HasColumnType("longtext");

                    b.Property<string>("ERTy3")
                        .HasColumnType("longtext");

                    b.Property<string>("EntryDate")
                        .HasColumnType("longtext");

                    b.Property<decimal>("ExcRate")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("ExcRate2")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("ExcRate3")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ExtractID")
                        .HasColumnType("longtext");

                    b.Property<string>("FMA")
                        .HasColumnType("longtext");

                    b.Property<string>("FileNumber")
                        .HasColumnType("longtext");

                    b.Property<string>("FollowOnDocIndicator")
                        .HasColumnType("longtext");

                    b.Property<string>("GI")
                        .HasColumnType("longtext");

                    b.Property<string>("GroupCurrency")
                        .HasColumnType("longtext");

                    b.Property<decimal>("GroupExcRate")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("I")
                        .HasColumnType("longtext");

                    b.Property<string>("IF")
                        .HasColumnType("longtext");

                    b.Property<string>("IRDate")
                        .HasColumnType("longtext");

                    b.Property<string>("InterestCalcDate")
                        .HasColumnType("longtext");

                    b.Property<string>("LCurr")
                        .HasColumnType("longtext");

                    b.Property<string>("LCurr2")
                        .HasColumnType("longtext");

                    b.Property<string>("LCurr3")
                        .HasColumnType("longtext");

                    b.Property<string>("LastUpdate")
                        .HasColumnType("longtext");

                    b.Property<string>("Ld")
                        .HasColumnType("longtext");

                    b.Property<string>("Ledger")
                        .HasColumnType("longtext");

                    b.Property<string>("LogSystem")
                        .HasColumnType("longtext");

                    b.Property<string>("Mand")
                        .HasColumnType("longtext");

                    b.Property<decimal>("MarketData")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("MarketData2")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("MarketDateExcRate")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("NetDocType")
                        .HasColumnType("longtext");

                    b.Property<string>("ObjectKey")
                        .HasColumnType("longtext");

                    b.Property<string>("Pages")
                        .HasColumnType("longtext");

                    b.Property<string>("ParkedBy")
                        .HasColumnType("longtext");

                    b.Property<string>("ParkedWith")
                        .HasColumnType("longtext");

                    b.Property<string>("ParkingDate")
                        .HasColumnType("longtext");

                    b.Property<string>("Posting")
                        .HasColumnType("longtext");

                    b.Property<string>("PostingDate")
                        .HasColumnType("longtext");

                    b.Property<string>("RT")
                        .HasColumnType("longtext");

                    b.Property<string>("Reason")
                        .HasColumnType("longtext");

                    b.Property<string>("RecEntDoc")
                        .HasColumnType("longtext");

                    b.Property<string>("RefKey1")
                        .HasColumnType("longtext");

                    b.Property<string>("RefKey2")
                        .HasColumnType("longtext");

                    b.Property<string>("RefProc")
                        .HasColumnType("longtext");

                    b.Property<string>("Reference")
                        .HasColumnType("longtext");

                    b.Property<string>("Region")
                        .HasColumnType("longtext");

                    b.Property<string>("Reorg")
                        .HasColumnType("longtext");

                    b.Property<string>("RepDate")
                        .HasColumnType("longtext");

                    b.Property<string>("RequestNo")
                        .HasColumnType("longtext");

                    b.Property<string>("ResubmissionDate")
                        .HasColumnType("longtext");

                    b.Property<string>("RevReas")
                        .HasColumnType("longtext");

                    b.Property<string>("RevWith")
                        .HasColumnType("longtext");

                    b.Property<string>("Reversal")
                        .HasColumnType("longtext");

                    b.Property<string>("ReversalDate")
                        .HasColumnType("longtext");

                    b.Property<string>("ReversalFlag")
                        .HasColumnType("longtext");

                    b.Property<string>("S")
                        .HasColumnType("longtext");

                    b.Property<string>("S2")
                        .HasColumnType("longtext");

                    b.Property<string>("SC")
                        .HasColumnType("longtext");

                    b.Property<string>("SC2")
                        .HasColumnType("longtext");

                    b.Property<string>("SCCd")
                        .HasColumnType("longtext");

                    b.Property<string>("SessionName")
                        .HasColumnType("longtext");

                    b.Property<string>("SplitPosting")
                        .HasColumnType("longtext");

                    b.Property<string>("StatusDataTransferNextRelease")
                        .HasColumnType("longtext");

                    b.Property<string>("Subs")
                        .HasColumnType("longtext");

                    b.Property<string>("TCode")
                        .HasColumnType("longtext");

                    b.Property<string>("TaxDetailChanged")
                        .HasColumnType("longtext");

                    b.Property<string>("TaxRate")
                        .HasColumnType("longtext");

                    b.Property<string>("TaxRateLC")
                        .HasColumnType("longtext");

                    b.Property<string>("Time")
                        .HasColumnType("longtext");

                    b.Property<string>("Time2")
                        .HasColumnType("longtext");

                    b.Property<string>("Tran")
                        .HasColumnType("longtext");

                    b.Property<string>("TransIDDate")
                        .HasColumnType("longtext");

                    b.Property<string>("Translation")
                        .HasColumnType("longtext");

                    b.Property<string>("TranslationDate")
                        .HasColumnType("longtext");

                    b.Property<string>("UnDelCts")
                        .HasColumnType("longtext");

                    b.Property<string>("Username")
                        .HasColumnType("longtext");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("BKPFModels");
                });

            modelBuilder.Entity("ReportService.Domains.BSEGModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("AT")
                        .HasColumnType("longtext");

                    b.Property<string>("AccTy")
                        .HasColumnType("longtext");

                    b.Property<decimal>("AdditionalTax")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Asset")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("AssetValDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Assignment")
                        .HasColumnType("longtext");

                    b.Property<string>("Aut")
                        .HasColumnType("longtext");

                    b.Property<string>("BSAcct")
                        .HasColumnType("longtext");

                    b.Property<string>("BillDoc")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("BlineDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Branch")
                        .HasColumnType("longtext");

                    b.Property<string>("BusA")
                        .HasColumnType("longtext");

                    b.Property<string>("COAr")
                        .HasColumnType("longtext");

                    b.Property<string>("CS")
                        .HasColumnType("longtext");

                    b.Property<decimal>("CashDiscount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Cl")
                        .HasColumnType("longtext");

                    b.Property<string>("Clearing")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("ClgEntDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("ClrngDoc")
                        .HasColumnType("longtext");

                    b.Property<string>("CoCd")
                        .HasColumnType("longtext");

                    b.Property<string>("CostCtr")
                        .HasColumnType("longtext");

                    b.Property<string>("Curr")
                        .HasColumnType("longtext");

                    b.Property<string>("DC")
                        .HasColumnType("longtext");

                    b.Property<string>("Day1")
                        .HasColumnType("longtext");

                    b.Property<string>("Day2")
                        .HasColumnType("longtext");

                    b.Property<string>("Dis")
                        .HasColumnType("longtext");

                    b.Property<string>("DocumentNo")
                        .HasColumnType("longtext");

                    b.Property<string>("FBI")
                        .HasColumnType("longtext");

                    b.Property<string>("GLAcct")
                        .HasColumnType("longtext");

                    b.Property<string>("GLCustomer")
                        .HasColumnType("longtext");

                    b.Property<string>("GLSupplier")
                        .HasColumnType("longtext");

                    b.Property<decimal>("GeneralLedgerAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("GrI")
                        .HasColumnType("longtext");

                    b.Property<string>("GroupAcct")
                        .HasColumnType("longtext");

                    b.Property<decimal>("HedgedAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("HedgedER")
                        .HasColumnType("longtext");

                    b.Property<string>("IndividSet")
                        .HasColumnType("longtext");

                    b.Property<string>("IntBlock")
                        .HasColumnType("longtext");

                    b.Property<string>("InvestmentID")
                        .HasColumnType("longtext");

                    b.Property<string>("Item")
                        .HasColumnType("longtext");

                    b.Property<string>("ItemsCannotBeCopiedIndicator")
                        .HasColumnType("longtext");

                    b.Property<string>("Itm")
                        .HasColumnType("longtext");

                    b.Property<decimal>("LCProvision")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("LCTaxAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("LCTaxBaseAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("LID")
                        .HasColumnType("longtext");

                    b.Property<string>("Level")
                        .HasColumnType("longtext");

                    b.Property<bool>("LineItemDisplayPossible")
                        .HasColumnType("tinyint(1)");

                    b.Property<decimal>("LocCurrAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Net")
                        .HasColumnType("longtext");

                    b.Property<string>("NotInUse")
                        .HasColumnType("longtext");

                    b.Property<string>("OIManagement")
                        .HasColumnType("longtext");

                    b.Property<string>("OS")
                        .HasColumnType("longtext");

                    b.Property<string>("Order")
                        .HasColumnType("longtext");

                    b.Property<decimal>("OrigReduction")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("OriginalTaxBaseAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("PK")
                        .HasColumnType("int");

                    b.Property<string>("PS")
                        .HasColumnType("longtext");

                    b.Property<string>("PayT")
                        .HasColumnType("longtext");

                    b.Property<string>("Payment")
                        .HasColumnType("longtext");

                    b.Property<string>("PersNo")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("PlanDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("PlanGrp")
                        .HasColumnType("longtext");

                    b.Property<decimal>("PlannedAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("SG")
                        .HasColumnType("longtext");

                    b.Property<string>("SLNo")
                        .HasColumnType("longtext");

                    b.Property<string>("SNo")
                        .HasColumnType("longtext");

                    b.Property<string>("SP")
                        .HasColumnType("longtext");

                    b.Property<string>("SalesDoc")
                        .HasColumnType("longtext");

                    b.Property<string>("SlIndicator")
                        .HasColumnType("longtext");

                    b.Property<string>("SpGLAssignment")
                        .HasColumnType("longtext");

                    b.Property<string>("TPBA")
                        .HasColumnType("longtext");

                    b.Property<string>("TTy")
                        .HasColumnType("longtext");

                    b.Property<string>("TTyAsset")
                        .HasColumnType("longtext");

                    b.Property<decimal>("TaxAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("TaxBase")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Text")
                        .HasColumnType("longtext");

                    b.Property<string>("TrPrt")
                        .HasColumnType("longtext");

                    b.Property<string>("TrTy")
                        .HasColumnType("longtext");

                    b.Property<string>("TransType")
                        .HasColumnType("longtext");

                    b.Property<string>("TrgtSpecialGLInd")
                        .HasColumnType("longtext");

                    b.Property<string>("Trs")
                        .HasColumnType("longtext");

                    b.Property<string>("Tx")
                        .HasColumnType("longtext");

                    b.Property<string>("Typ")
                        .HasColumnType("longtext");

                    b.Property<decimal>("ValuationDifference")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("ValuationDifference2")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("ValueDate")
                        .HasColumnType("datetime(6)");

                    b.Property<int?>("VersionNumberComponent")
                        .HasColumnType("int");

                    b.Property<string>("WD")
                        .HasColumnType("longtext");

                    b.Property<string>("WT")
                        .HasColumnType("longtext");

                    b.Property<string>("WTaxBase")
                        .HasColumnType("longtext");

                    b.Property<string>("XANET")
                        .HasColumnType("longtext");

                    b.Property<string>("XFAKT")
                        .HasColumnType("longtext");

                    b.Property<string>("XUMAN")
                        .HasColumnType("longtext");

                    b.Property<int?>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("BSEGModels");
                });

            modelBuilder.Entity("ReportService.Domains.F10Model", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("GLAccount")
                        .HasColumnType("longtext");

                    b.Property<string>("GLAccountLongText")
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.ToTable("F10Models");
                });

            modelBuilder.Entity("ReportService.Domains.FileHistoryModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("CreatedAt")
                        .HasColumnType("longtext");

                    b.Property<string>("FileName")
                        .HasColumnType("longtext");

                    b.Property<string>("FileTimestamp")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("FileHistoryModels");
                });

            modelBuilder.Entity("ReportService.Domains.HistoryModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("FileName")
                        .HasColumnType("longtext");

                    b.Property<string>("FilePath")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("FinishTime")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Remark")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Status")
                        .HasColumnType("longtext");

                    b.Property<string>("Type")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("HistoryModels");
                });

            modelBuilder.Entity("ReportService.Domains.MKVGModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("AccountGroup")
                        .HasColumnType("longtext");

                    b.Property<string>("Address")
                        .HasColumnType("longtext");

                    b.Property<bool>("CentralDelFlag")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("City")
                        .HasColumnType("longtext");

                    b.Property<string>("Country")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("DeleteFlagPurchaseOrg")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Incoterms")
                        .HasColumnType("longtext");

                    b.Property<string>("Incoterms2")
                        .HasColumnType("longtext");

                    b.Property<decimal>("MinOrderVal")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("OneTimeAccount")
                        .HasColumnType("longtext");

                    b.Property<string>("OrderCurrency")
                        .HasColumnType("longtext");

                    b.Property<string>("PostalCode")
                        .HasColumnType("longtext");

                    b.Property<string>("PurchaseOrg")
                        .HasColumnType("longtext");

                    b.Property<string>("PurchaseOrgDesc")
                        .HasColumnType("longtext");

                    b.Property<string>("SearchTerm")
                        .HasColumnType("longtext");

                    b.Property<string>("Supplier")
                        .HasColumnType("longtext");

                    b.Property<string>("TermsOfPayment")
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("VendorName")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("MKVGModels");
                });
#pragma warning restore 612, 618
        }
    }
}
