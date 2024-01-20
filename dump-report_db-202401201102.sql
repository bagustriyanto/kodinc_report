-- MySQL dump 10.13  Distrib 5.5.62, for Win64 (AMD64)
--
-- Host: localhost    Database: report_db
-- ------------------------------------------------------
-- Server version	5.5.5-10.11.6-MariaDB-1:10.11.6+maria~ubu2204

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `BKPFModels`
--

DROP TABLE IF EXISTS `BKPFModels`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `BKPFModels` (
  `Id` char(36) NOT NULL,
  `GI` longtext DEFAULT NULL,
  `CoCd` longtext DEFAULT NULL,
  `DocumentNo` longtext DEFAULT NULL,
  `Year` int(11) NOT NULL,
  `DocType` longtext DEFAULT NULL,
  `DocDate` longtext DEFAULT NULL,
  `PostingDate` longtext DEFAULT NULL,
  `Posting` longtext DEFAULT NULL,
  `EntryDate` longtext DEFAULT NULL,
  `Time` longtext DEFAULT NULL,
  `Changed` longtext DEFAULT NULL,
  `LastUpdate` longtext DEFAULT NULL,
  `TransIDDate` longtext DEFAULT NULL,
  `Username` longtext DEFAULT NULL,
  `TCode` longtext DEFAULT NULL,
  `CrossCCodeNo` longtext DEFAULT NULL,
  `Reference` longtext DEFAULT NULL,
  `RecEntDoc` longtext DEFAULT NULL,
  `RevWith` longtext DEFAULT NULL,
  `DocHeaderText` longtext DEFAULT NULL,
  `Currency` longtext DEFAULT NULL,
  `ExcRate` decimal(18,2) NOT NULL,
  `GroupCurrency` longtext DEFAULT NULL,
  `GroupExcRate` decimal(18,2) NOT NULL,
  `S` longtext DEFAULT NULL,
  `NetDocType` longtext DEFAULT NULL,
  `UnDelCts` longtext DEFAULT NULL,
  `I` longtext DEFAULT NULL,
  `Tran` longtext DEFAULT NULL,
  `SessionName` longtext DEFAULT NULL,
  `DocNameArchiveSys` longtext DEFAULT NULL,
  `ExtractID` longtext DEFAULT NULL,
  `DT` longtext DEFAULT NULL,
  `RefProc` longtext DEFAULT NULL,
  `ObjectKey` longtext DEFAULT NULL,
  `FMA` longtext DEFAULT NULL,
  `LCurr` longtext DEFAULT NULL,
  `LCurr2` longtext DEFAULT NULL,
  `LCurr3` longtext DEFAULT NULL,
  `ExcRate2` decimal(18,2) NOT NULL,
  `ExcRate3` decimal(18,2) NOT NULL,
  `SC` longtext DEFAULT NULL,
  `SC2` longtext DEFAULT NULL,
  `Translation` longtext DEFAULT NULL,
  `TranslationDate` longtext DEFAULT NULL,
  `ReversalFlag` longtext DEFAULT NULL,
  `ReversalDate` longtext DEFAULT NULL,
  `Calculate` longtext DEFAULT NULL,
  `CT` longtext DEFAULT NULL,
  `CT2` longtext DEFAULT NULL,
  `ERTy` longtext DEFAULT NULL,
  `ERTy2` longtext DEFAULT NULL,
  `CalculateTax` longtext DEFAULT NULL,
  `SCCd` longtext DEFAULT NULL,
  `TaxDetailChanged` longtext DEFAULT NULL,
  `StatusDataTransferNextRelease` longtext DEFAULT NULL,
  `LogSystem` longtext DEFAULT NULL,
  `TaxRate` longtext DEFAULT NULL,
  `TaxRateLC` longtext DEFAULT NULL,
  `RequestNo` longtext DEFAULT NULL,
  `CustomerBillBeforeDueDate` longtext DEFAULT NULL,
  `RevReas` longtext DEFAULT NULL,
  `ParkedBy` longtext DEFAULT NULL,
  `ParkingDate` longtext DEFAULT NULL,
  `Time2` longtext DEFAULT NULL,
  `ParkedWith` longtext DEFAULT NULL,
  `BranchNo` longtext DEFAULT NULL,
  `Pages` longtext DEFAULT NULL,
  `DisDoc` longtext DEFAULT NULL,
  `RefKey1` longtext DEFAULT NULL,
  `RefKey2` longtext DEFAULT NULL,
  `Reversal` longtext DEFAULT NULL,
  `IRDate` longtext DEFAULT NULL,
  `Ld` longtext DEFAULT NULL,
  `Ledger` longtext DEFAULT NULL,
  `Mand` longtext DEFAULT NULL,
  `AltRefNumber` longtext DEFAULT NULL,
  `RepDate` longtext DEFAULT NULL,
  `DocType2` longtext DEFAULT NULL,
  `SplitPosting` longtext DEFAULT NULL,
  `Cash` tinyint(1) NOT NULL,
  `FollowOnDocIndicator` longtext DEFAULT NULL,
  `Reorg` longtext DEFAULT NULL,
  `Subs` longtext DEFAULT NULL,
  `ERTy3` longtext DEFAULT NULL,
  `MarketDateExcRate` decimal(18,2) NOT NULL,
  `MarketData` decimal(18,2) NOT NULL,
  `MarketData2` decimal(18,2) NOT NULL,
  `DocOriMultiCurrency` longtext DEFAULT NULL,
  `ResubmissionDate` longtext DEFAULT NULL,
  `DocStatus` longtext DEFAULT NULL,
  `RT` longtext DEFAULT NULL,
  `Reason` longtext DEFAULT NULL,
  `Region` longtext DEFAULT NULL,
  `S2` longtext DEFAULT NULL,
  `FileNumber` longtext DEFAULT NULL,
  `IF` longtext DEFAULT NULL,
  `InterestCalcDate` longtext DEFAULT NULL,
  `CreatedAt` timestamp NULL DEFAULT NULL,
  `UpdatedAt` timestamp NULL DEFAULT NULL,
  `SourceFile` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `BKPFModels`
--

LOCK TABLES `BKPFModels` WRITE;
/*!40000 ALTER TABLE `BKPFModels` DISABLE KEYS */;
INSERT INTO `BKPFModels` VALUES ('061f90a9-1419-4e2a-9291-9dfd842cf78c','100','ID05','0100000009',2022,'AB','2022-01-02','2022-01-02','1','2022-01-02','00.17.34','','','2022-01-02','APACBATCH','FB1S','','','','','Autom.clearing SAPF124','IDR',0.00,'',0.00,'','','0','','RFBU','','','','','BKPF','0100000009ID052022','','IDR','USD','',0.07,0.00,'1','','3','','','','','30','','M','','','','','','','0','0','','M','','','','00.00.00','','','0','','','VANSTOEAP:4503377201','','','','','','','','','',0,'','','','M',0.00,0.00,0.00,'','','','','','','','','','','2024-01-19 00:35:55','2024-01-19 00:36:01','BKPF_20220104220102.xlsx'),('1c85bd4e-4c8f-475b-96e9-4169ae79a64a','100','ID05','0100000004',2022,'AB','2022-01-01','2022-01-01','1','2022-01-01','02.00.23','','','2022-01-01','APACBATCH','FB1S','','','','','Autom.clearing SAPF124','IDR',0.00,'',0.00,'','','0','','RFBU','','','','','BKPF','0100000004ID052022','','IDR','USD','',0.07,0.00,'1','','3','','','','','30','','M','','','','','','','0','0','','M','','','','00.00.00','','','0','','','','','','','','','','','','',0,'','','','M',0.00,0.00,0.00,'','','','','','','','','','','2024-01-19 00:35:55','2024-01-19 00:36:01','BKPF_20220104220102.xlsx'),('2e51b239-a7bf-4ecd-a9ac-a15b40035b00','100','ID05','0100000008',2022,'AB','2022-01-02','2022-01-02','1','2022-01-02','00.17.33','','','2022-01-02','APACBATCH','FB1S','','','','','Autom.clearing SAPF124','IDR',0.00,'',0.00,'','','0','','RFBU','','','','','BKPF','0100000008ID052022','','IDR','USD','',0.07,0.00,'1','','3','','','','','30','','M','','','','','','','0','0','','M','','','','00.00.00','','','0','','','VANSTOEAP:4503377199','','','','','','','','','',0,'','','','M',0.00,0.00,0.00,'','','','','','','','','','','2024-01-19 00:35:55','2024-01-19 00:36:01','BKPF_20220104220102.xlsx'),('5020a42a-6063-465e-a224-0e3e5916b9e3','100','ID05','0100000001',2022,'AB','2022-01-03','2022-01-03','1','2022-01-01','00.19.07','','','2022-01-03','APACBATCH','FB1S','','','','','Autom.clearing SAPF124','IDR',0.00,'',0.00,'','','0','','RFBU','','','','','BKPF','0100000001ID052022','','IDR','USD','',0.07,0.00,'1','','3','','','','','30','','M','','','','','','','0','0','','M','','','','00.00.00','','','0','','','VANSOEAP:08570013130','','','','','','','','','',0,'','','','M',0.00,0.00,0.00,'','','','','','','','','','','2024-01-19 00:35:55','2024-01-19 00:36:01','BKPF_20220104220102.xlsx'),('6b9f6b74-be5a-47c3-abdf-ebbcce510622','100','ID05','0100000000',2022,'AB','2022-01-03','2022-01-03','1','2022-01-01','00.19.06','','','2022-01-03','APACBATCH','FB1S','','','','','Autom.clearing SAPF124','IDR',0.00,'',0.00,'','','0','','RFBU','','','','','BKPF','0100000000ID052022','','IDR','USD','',0.07,0.00,'1','','3','','','','','30','','M','','','','','','','0','0','','M','','','','00.00.00','','','0','','','VANSOEAP:06570615281','','','','','','','','','',0,'','','','M',0.00,0.00,0.00,'','','','','','','','','','','2024-01-19 00:35:55','2024-01-19 00:36:01','BKPF_20220104220102.xlsx'),('8c561a9b-96f1-4fc9-8ebf-e36dac8f043b','100','ID05','0100000010',2022,'AB','2022-01-02','2022-01-02','1','2022-01-02','00.17.34','','','2022-01-02','APACBATCH','FB1S','','','','','Autom.clearing SAPF124','IDR',0.00,'',0.00,'','','0','','RFBU','','','','','BKPF','0100000010ID052022','','IDR','USD','',0.07,0.00,'1','','3','','','','','30','','M','','','','','','','0','0','','M','','','','00.00.00','','','0','','','VANSTOEAP:4503379853','','','','','','','','','',0,'','','','M',0.00,0.00,0.00,'','','','','','','','','','','2024-01-19 00:35:55','2024-01-19 00:36:01','BKPF_20220104220102.xlsx'),('8df69ade-27f0-49f7-b886-35c765b7f548','100','ID05','0100000007',2022,'AB','2022-01-02','2022-01-02','1','2022-01-02','00.17.33','','','2022-01-02','APACBATCH','FB1S','','','','','Autom.clearing SAPF124','IDR',0.00,'',0.00,'','','0','','RFBU','','','','','BKPF','0100000007ID052022','','IDR','USD','',0.07,0.00,'1','','3','','','','','30','','M','','','','','','','0','0','','M','','','','00.00.00','','','0','','','VANSTOEAP:4503377196','','','','','','','','','',0,'','','','M',0.00,0.00,0.00,'','','','','','','','','','','2024-01-19 00:35:55','2024-01-19 00:36:01','BKPF_20220104220102.xlsx'),('b72f36a4-9285-494e-ad87-6b17fa08e438','100','ID05','0100000002',2022,'AB','2022-01-03','2022-01-03','1','2022-01-01','00.19.07','','','2022-01-03','APACBATCH','FB1S','','','','','Autom.clearing SAPF124','IDR',0.00,'',0.00,'','','0','','RFBU','','','','','BKPF','0100000002ID052022','','IDR','USD','',0.07,0.00,'1','','3','','','','','30','','M','','','','','','','0','0','','M','','','','00.00.00','','','0','','','VANSOEAP:08570013132','','','','','','','','','',0,'','','','M',0.00,0.00,0.00,'','','','','','','','','','','2024-01-19 00:35:55','2024-01-19 00:36:01','BKPF_20220104220102.xlsx'),('d737b152-a36c-4409-b0de-ee0eb66f6fba','100','ID05','0100000003',2022,'AB','2022-01-01','2022-01-01','1','2022-01-01','01.00.25','','','2022-01-01','APACBATCH','FB1S','','','','','Autom.clearing SAPF124','IDR',0.00,'',0.00,'','','0','','RFBU','','','','','BKPF','0100000003ID052022','','IDR','USD','',0.07,0.00,'1','','3','','','','','30','','M','','','','','','','0','0','','M','','','','00.00.00','','','0','','','','','','','','','','','','',0,'','','','M',0.00,0.00,0.00,'','','','','','','','','','','2024-01-19 00:35:55','2024-01-19 00:36:01','BKPF_20220104220102.xlsx'),('de5efd2f-cdf4-42b4-9683-be5e49308de8','100','ID05','0100000006',2022,'AB','2022-01-02','2022-01-02','1','2022-01-02','00.17.32','','','2022-01-02','APACBATCH','FB1S','','','','','Autom.clearing SAPF124','IDR',0.00,'',0.00,'','','0','','RFBU','','','','','BKPF','0100000006ID052022','','IDR','USD','',0.07,0.00,'1','','3','','','','','30','','M','','','','','','','0','0','','M','','','','00.00.00','','','0','','','VANSTOEAP:4503377195','','','','','','','','','',0,'','','','M',0.00,0.00,0.00,'','','','','','','','','','','2024-01-19 00:35:55','2024-01-19 00:36:01','BKPF_20220104220102.xlsx'),('f340b1e1-7654-48e7-ba50-f1dadf82c8f2','100','ID05','0100000005',2022,'AB','2022-01-02','2022-01-02','1','2022-01-02','00.17.31','','','2022-01-02','APACBATCH','FB1S','','','','','Autom.clearing SAPF124','IDR',0.00,'',0.00,'','','0','','RFBU','','','','','BKPF','0100000005ID052022','','IDR','USD','',0.07,0.00,'1','','3','','','','','30','','M','','','','','','','0','0','','M','','','','00.00.00','','','0','','','VANSTOEAP:4503370361','','','','','','','','','',0,'','','','M',0.00,0.00,0.00,'','','','','','','','','','','2024-01-19 00:35:55','2024-01-19 00:36:01','BKPF_20220104220102.xlsx');
/*!40000 ALTER TABLE `BKPFModels` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `BSEGModels`
--

DROP TABLE IF EXISTS `BSEGModels`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `BSEGModels` (
  `Id` char(36) NOT NULL,
  `Cl` longtext DEFAULT NULL,
  `CoCd` longtext DEFAULT NULL,
  `DocumentNo` longtext DEFAULT NULL,
  `Year` int(11) DEFAULT NULL,
  `Itm` longtext DEFAULT NULL,
  `LID` longtext DEFAULT NULL,
  `Clearing` longtext DEFAULT NULL,
  `ClgEntDate` datetime(6) NOT NULL,
  `ClrngDoc` longtext DEFAULT NULL,
  `PK` int(11) DEFAULT NULL,
  `AccTy` longtext DEFAULT NULL,
  `SG` longtext DEFAULT NULL,
  `TransType` longtext DEFAULT NULL,
  `TrgtSpecialGLInd` longtext DEFAULT NULL,
  `DC` longtext DEFAULT NULL,
  `BusA` longtext DEFAULT NULL,
  `TPBA` longtext DEFAULT NULL,
  `Tx` longtext DEFAULT NULL,
  `WT` longtext DEFAULT NULL,
  `LocCurrAmount` decimal(18,2) NOT NULL,
  `Amount` decimal(18,2) NOT NULL,
  `OrigReduction` decimal(18,2) NOT NULL,
  `GeneralLedgerAmount` decimal(18,2) NOT NULL,
  `Curr` longtext DEFAULT NULL,
  `OriginalTaxBaseAmount` decimal(18,2) NOT NULL,
  `LCTaxAmount` decimal(18,2) NOT NULL,
  `TaxAmount` decimal(18,2) NOT NULL,
  `LCTaxBaseAmount` decimal(18,2) NOT NULL,
  `TaxBase` decimal(18,2) NOT NULL,
  `LCProvision` decimal(18,2) NOT NULL,
  `AdditionalTax` decimal(18,2) NOT NULL,
  `CashDiscount` decimal(18,2) NOT NULL,
  `VersionNumberComponent` int(11) DEFAULT NULL,
  `Typ` longtext DEFAULT NULL,
  `GrI` longtext DEFAULT NULL,
  `Trs` longtext DEFAULT NULL,
  `WTaxBase` decimal(18,2) DEFAULT NULL,
  `HedgedER` decimal(18,2) DEFAULT NULL,
  `HedgedAmount` decimal(18,2) NOT NULL,
  `ValuationDifference` decimal(18,2) NOT NULL,
  `ValuationDifference2` decimal(18,2) NOT NULL,
  `ValueDate` datetime(6) NOT NULL,
  `Assignment` longtext DEFAULT NULL,
  `Text` longtext DEFAULT NULL,
  `IntBlock` longtext DEFAULT NULL,
  `TrPrt` longtext DEFAULT NULL,
  `TTy` longtext DEFAULT NULL,
  `GroupAcct` longtext DEFAULT NULL,
  `TrTy` longtext DEFAULT NULL,
  `Level` longtext DEFAULT NULL,
  `PlanGrp` longtext DEFAULT NULL,
  `PlannedAmount` decimal(18,2) NOT NULL,
  `PlanDate` datetime(6) NOT NULL,
  `FBI` longtext DEFAULT NULL,
  `COAr` longtext DEFAULT NULL,
  `CostCtr` longtext DEFAULT NULL,
  `NotInUse` longtext DEFAULT NULL,
  `Order` longtext DEFAULT NULL,
  `BillDoc` longtext DEFAULT NULL,
  `SalesDoc` longtext DEFAULT NULL,
  `Item` longtext DEFAULT NULL,
  `SLNo` longtext DEFAULT NULL,
  `Asset` longtext DEFAULT NULL,
  `SNo` longtext DEFAULT NULL,
  `TTyAsset` longtext DEFAULT NULL,
  `AssetValDate` datetime(6) NOT NULL,
  `PersNo` longtext DEFAULT NULL,
  `SlIndicator` longtext DEFAULT NULL,
  `LineItemDisplayPossible` tinyint(1) NOT NULL,
  `OIManagement` longtext DEFAULT NULL,
  `IndividSet` longtext DEFAULT NULL,
  `CS` longtext DEFAULT NULL,
  `OS` longtext DEFAULT NULL,
  `SP` longtext DEFAULT NULL,
  `PS` longtext DEFAULT NULL,
  `XFAKT` longtext DEFAULT NULL,
  `XUMAN` longtext DEFAULT NULL,
  `XANET` longtext DEFAULT NULL,
  `WD` longtext DEFAULT NULL,
  `InvestmentID` longtext DEFAULT NULL,
  `Dis` longtext DEFAULT NULL,
  `Aut` longtext DEFAULT NULL,
  `ItemsCannotBeCopiedIndicator` longtext DEFAULT NULL,
  `Payment` longtext DEFAULT NULL,
  `GLAcct` longtext DEFAULT NULL,
  `GLCustomer` longtext DEFAULT NULL,
  `GLSupplier` longtext DEFAULT NULL,
  `Branch` longtext DEFAULT NULL,
  `BSAcct` longtext DEFAULT NULL,
  `AT` longtext DEFAULT NULL,
  `SpGLAssignment` longtext DEFAULT NULL,
  `BlineDate` datetime(6) NOT NULL,
  `PayT` longtext DEFAULT NULL,
  `Day1` longtext DEFAULT NULL,
  `Day2` longtext DEFAULT NULL,
  `Net` longtext DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `BSEGModels`
--

LOCK TABLES `BSEGModels` WRITE;
/*!40000 ALTER TABLE `BSEGModels` DISABLE KEYS */;
/*!40000 ALTER TABLE `BSEGModels` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `F10Models`
--

DROP TABLE IF EXISTS `F10Models`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `F10Models` (
  `Id` char(36) NOT NULL,
  `GLAccount` longtext DEFAULT NULL,
  `GLAccountLongText` longtext DEFAULT NULL,
  `CreatedAt` datetime(6) NOT NULL,
  `UpdatedAt` datetime(6) DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `F10Models`
--

LOCK TABLES `F10Models` WRITE;
/*!40000 ALTER TABLE `F10Models` DISABLE KEYS */;
/*!40000 ALTER TABLE `F10Models` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `FileHistoryModels`
--

DROP TABLE IF EXISTS `FileHistoryModels`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `FileHistoryModels` (
  `Id` char(36) NOT NULL,
  `FileName` longtext DEFAULT NULL,
  `FileTimestamp` longtext DEFAULT NULL,
  `CreatedAt` timestamp NULL DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `FileHistoryModels`
--

LOCK TABLES `FileHistoryModels` WRITE;
/*!40000 ALTER TABLE `FileHistoryModels` DISABLE KEYS */;
INSERT INTO `FileHistoryModels` VALUES ('3f17e143-863c-4512-9b25-94404010fd36','BKPF_20220104220102.xlsx','20220104220102','2024-01-19 00:18:19'),('ca7a6352-0f74-4398-9c06-4458c904f5fd','BKPF_20220104220101.xlsx','20220104220101','2024-01-19 00:18:19');
/*!40000 ALTER TABLE `FileHistoryModels` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `HistoryModels`
--

DROP TABLE IF EXISTS `HistoryModels`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `HistoryModels` (
  `Id` char(36) NOT NULL,
  `FileName` longtext DEFAULT NULL,
  `FilePath` longtext DEFAULT NULL,
  `Type` longtext DEFAULT NULL,
  `StartTime` datetime(6) NOT NULL,
  `FinishTime` datetime(6) NOT NULL,
  `Status` longtext DEFAULT NULL,
  `Remark` longtext DEFAULT NULL,
  `CreatedAt` datetime(6) NOT NULL,
  `LastRowSuccess` int(11) DEFAULT NULL,
  `TotalRows` int(11) DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `HistoryModels`
--

LOCK TABLES `HistoryModels` WRITE;
/*!40000 ALTER TABLE `HistoryModels` DISABLE KEYS */;
INSERT INTO `HistoryModels` VALUES ('1ea73bd8-f536-4eb6-86bc-217ec8b8e9ba','BKPF_20220104220102.xlsx','C:\\ProjectTestDoc\\BKPF_20220104220102.xlsx','upload','2024-01-19 00:36:01.107405','2024-01-19 00:36:01.816805','finish',NULL,'2024-01-19 00:18:19.679437',0,0),('cb2699e8-a8a2-4887-8f84-c15533fc8956','BKPF_20220104220101.xlsx','C:\\ProjectTestDoc\\BKPF_20220104220101.xlsx','upload','2024-01-19 00:35:54.611731','2024-01-19 00:35:56.047055','finish',NULL,'2024-01-19 00:18:19.356022',0,0);
/*!40000 ALTER TABLE `HistoryModels` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `MKVGModels`
--

DROP TABLE IF EXISTS `MKVGModels`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `MKVGModels` (
  `Id` char(36) NOT NULL,
  `Supplier` longtext DEFAULT NULL,
  `VendorName` longtext DEFAULT NULL,
  `Address` longtext DEFAULT NULL,
  `Country` longtext DEFAULT NULL,
  `PostalCode` longtext DEFAULT NULL,
  `City` longtext DEFAULT NULL,
  `AccountGroup` longtext DEFAULT NULL,
  `SearchTerm` longtext DEFAULT NULL,
  `OneTimeAccount` longtext DEFAULT NULL,
  `PurchaseOrg` longtext DEFAULT NULL,
  `PurchaseOrgDesc` longtext DEFAULT NULL,
  `TermsOfPayment` longtext DEFAULT NULL,
  `Incoterms` longtext DEFAULT NULL,
  `Incoterms2` longtext DEFAULT NULL,
  `MinOrderVal` decimal(18,2) NOT NULL,
  `OrderCurrency` longtext DEFAULT NULL,
  `CentralDelFlag` tinyint(1) NOT NULL,
  `DeleteFlagPurchaseOrg` tinyint(1) NOT NULL,
  `CreatedAt` datetime(6) NOT NULL,
  `UpdatedAt` datetime(6) DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `MKVGModels`
--

LOCK TABLES `MKVGModels` WRITE;
/*!40000 ALTER TABLE `MKVGModels` DISABLE KEYS */;
/*!40000 ALTER TABLE `MKVGModels` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `__EFMigrationsHistory`
--

DROP TABLE IF EXISTS `__EFMigrationsHistory`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `__EFMigrationsHistory` (
  `MigrationId` varchar(150) NOT NULL,
  `ProductVersion` varchar(32) NOT NULL,
  PRIMARY KEY (`MigrationId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `__EFMigrationsHistory`
--

LOCK TABLES `__EFMigrationsHistory` WRITE;
/*!40000 ALTER TABLE `__EFMigrationsHistory` DISABLE KEYS */;
INSERT INTO `__EFMigrationsHistory` VALUES ('20240115173218_init','8.0.1');
/*!40000 ALTER TABLE `__EFMigrationsHistory` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping routines for database 'report_db'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-01-20 11:02:12
