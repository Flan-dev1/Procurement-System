USE [master]
GO
/****** Object:  Database [ProcurementSystem]    Script Date: 1/27/2023 6:16:44 PM ******/
CREATE DATABASE [ProcurementSystem]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ProcurementSystemTwo', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\ProcurementSystemTwo.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ProcurementSystemTwo_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\ProcurementSystemTwo_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [ProcurementSystem] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ProcurementSystem].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ProcurementSystem] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ProcurementSystem] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ProcurementSystem] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ProcurementSystem] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ProcurementSystem] SET ARITHABORT OFF 
GO
ALTER DATABASE [ProcurementSystem] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ProcurementSystem] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ProcurementSystem] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ProcurementSystem] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ProcurementSystem] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ProcurementSystem] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ProcurementSystem] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ProcurementSystem] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ProcurementSystem] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ProcurementSystem] SET  ENABLE_BROKER 
GO
ALTER DATABASE [ProcurementSystem] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ProcurementSystem] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ProcurementSystem] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ProcurementSystem] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ProcurementSystem] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ProcurementSystem] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ProcurementSystem] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ProcurementSystem] SET RECOVERY FULL 
GO
ALTER DATABASE [ProcurementSystem] SET  MULTI_USER 
GO
ALTER DATABASE [ProcurementSystem] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ProcurementSystem] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ProcurementSystem] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ProcurementSystem] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ProcurementSystem] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [ProcurementSystem] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'ProcurementSystemTwo', N'ON'
GO
ALTER DATABASE [ProcurementSystem] SET QUERY_STORE = OFF
GO
USE [ProcurementSystem]
GO
/****** Object:  Table [dbo].[Supplier]    Script Date: 1/27/2023 6:16:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Supplier](
	[SupplierID] [int] IDENTITY(1000,1) NOT NULL,
	[SupplierName] [varchar](100) NOT NULL,
	[Address] [varchar](100) NOT NULL,
	[SupplierEmail] [varchar](100) NOT NULL,
	[PaymentTermsID] [int] NOT NULL,
	[Archived] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[SupplierID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DirectPurchaseOrderDetails]    Script Date: 1/27/2023 6:16:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DirectPurchaseOrderDetails](
	[DirectPODetailsID] [int] IDENTITY(1000,1) NOT NULL,
	[DirectPOID] [int] NOT NULL,
	[SupplierID] [int] NOT NULL,
	[PurchaseOrderStatus] [varchar](255) NOT NULL,
	[AccountPayableID] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[DirectPODetailsID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[AccountPayableID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QuotationPurchaseOrder]    Script Date: 1/27/2023 6:16:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QuotationPurchaseOrder](
	[PurchaseOrderID] [int] IDENTITY(1000,1) NOT NULL,
	[EmployeeID] [int] NULL,
	[CreatedDate] [date] NOT NULL,
	[Remarks] [text] NULL,
	[PurchaseOrderStatus] [varchar](10) NOT NULL,
	[SupplierID] [int] NOT NULL,
	[QuotationID] [int] NOT NULL,
	[AccountPayableID] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[PurchaseOrderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  View [dbo].[SupplierPOCount]    Script Date: 1/27/2023 6:16:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[SupplierPOCount] AS
SELECT TOP 5 S.SupplierName, 
(COUNT(QPO.PurchaseOrderID) + 
COUNT(DPD.DirectPODetailsID)) AS 'Total Count' FROM QuotationPurchaseOrder QPO
FULL JOIN Supplier S
ON QPO.SupplierID = S.SupplierID
FULL JOIN DirectPurchaseOrderDetails DPD
ON S.SupplierID = DPD.SupplierID
GROUP BY S.SupplierName ORDER BY (COUNT(QPO.PurchaseOrderID) + COUNT(DPD.DirectPODetailsID)) DESC
GO
/****** Object:  Table [dbo].[NetSaving]    Script Date: 1/27/2023 6:16:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NetSaving](
	[NetSavingID] [int] IDENTITY(1000,1) NOT NULL,
	[AccountPayableID] [int] NULL,
	[TotalSaving] [float] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[NetSavingID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AccountsPayable]    Script Date: 1/27/2023 6:16:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AccountsPayable](
	[AccountPayableID] [int] IDENTITY(1000,1) NOT NULL,
	[TotalAmount] [float] NOT NULL,
	[isPaid] [bit] NOT NULL,
	[SupplierID] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[AccountPayableID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[TotalSupplierNetDiscount]    Script Date: 1/27/2023 6:16:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[TotalSupplierNetDiscount] AS
SELECT TOP 5 S.SupplierName, 
CASE WHEN
	SUM(NS.TotalSaving) IS NULL THEN 0
	WHEN SUM(NS.TotalSaving) > 0 THEN 
	SUM(NS.TotalSaving)
END 'Total Net Saving'
FROM NetSaving NS
FULL JOIN AccountsPayable
AP ON NS.AccountPayableID = AP.AccountPayableID
LEFT JOIN DirectPurchaseOrderDetails DPD
ON AP.SupplierID = DPD.AccountPayableID
LEFT JOIN QuotationPurchaseOrder QPO
ON AP.AccountPayableID = QPO.AccountPayableID
FULL JOIN Supplier S
ON AP.SupplierID = S.SupplierID
GROUP BY S.SupplierName ORDER BY SUM(NS.TotalSaving) DESC
GO
/****** Object:  Table [dbo].[SupplierItem]    Script Date: 1/27/2023 6:16:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SupplierItem](
	[ItemID] [int] IDENTITY(1000,1) NOT NULL,
	[ItemName] [varchar](100) NOT NULL,
	[CategoryID] [int] NOT NULL,
	[ItemTypeID] [int] NOT NULL,
	[Archived] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[ItemID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[ItemName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SupplierItemDetails]    Script Date: 1/27/2023 6:16:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SupplierItemDetails](
	[ProductID] [int] IDENTITY(1000,1) NOT NULL,
	[ItemID] [int] NOT NULL,
	[SupplierID] [int] NULL,
	[Color] [varchar](100) NOT NULL,
	[UnitPrice] [float] NOT NULL,
	[Stocks] [int] NOT NULL,
	[Description] [text] NULL,
	[Discount] [float] NULL,
	[Archived] [bit] NULL,
	[QuotationItemID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  View [dbo].[NetDiscountInfo]    Script Date: 1/27/2023 6:16:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[NetDiscountInfo] AS
SELECT SII.ItemID, SI.ItemName, SII.Stocks AS 'Item On Hand', SII.UnitPrice,
S.SupplierName AS 'Supplier Provider',
FORMAT((SII.UnitPrice * (SII.Discount/100)), 'c', 'en-PH') AS 'Discount Per Unit Price',
FORMAT((SII.UnitPrice * (SII.Discount/100) * SII.Stocks), 'c', 'en-PH') AS 'Net Discount Total',
S.SupplierID
FROM SupplierItemDetails SII
INNER JOIN SupplierItem SI
ON SII.ItemID = SI.ItemID
INNER JOIN Supplier S
ON SII.SupplierID = S.SupplierID
GO
/****** Object:  View [dbo].[TotalSupplierDiscount]    Script Date: 1/27/2023 6:16:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[TotalSupplierDiscount] AS
SELECT SUM(TotalSaving) AS 'Total Discount', S.SupplierName FROM NetSaving NS
INNER JOIN AccountsPayable AP
ON NS.AccountPayableID = AP.AccountPayableID
INNER JOIN Supplier S
ON AP.SupplierID = S.SupplierID
GROUP BY S.SupplierName
GO
/****** Object:  Table [dbo].[DirectPurchaseOrderItem]    Script Date: 1/27/2023 6:16:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DirectPurchaseOrderItem](
	[DirectPOItemID] [int] IDENTITY(1000,1) NOT NULL,
	[ItemID] [int] NOT NULL,
	[Quantity] [int] NOT NULL,
	[DirectPODetailsID] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[DirectPOItemID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[DirectPOItems]    Script Date: 1/27/2023 6:16:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[DirectPOItems] AS
SELECT DPOI.ItemID  AS 'Item ID', SI.ItemName, SII.Color, DPOI.ItemID, DPOI.Quantity FROM DirectPurchaseOrderItem DPOI
INNER JOIN SupplierItem SI
ON DPOI.ItemID = SI.ItemID
INNER JOIN DirectPurchaseOrderDetails DPOD
ON DPOI.DirectPODetailsID = DPOD.DirectPODetailsID
INNER JOIN SupplierItemDetails SII
ON SI.ItemID = SII.ItemID
AND DPOD.SupplierID = SII.SupplierID
GO
/****** Object:  View [dbo].[TotalItems]    Script Date: 1/27/2023 6:16:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[TotalItems] AS
SELECT COALESCE(SI.ItemName, 'Grand Total') AS 'Item Name', SUM(Stocks) AS 'Total Count' FROM SupplierItemDetails SII INNER JOIN
SupplierItem SI ON SII.ItemID = SI.ItemID GROUP BY ROLLUP(SI.ItemName)
GO
/****** Object:  Table [dbo].[RequestForQuotation]    Script Date: 1/27/2023 6:16:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RequestForQuotation](
	[QuotationID] [int] IDENTITY(1000,1) NOT NULL,
	[EmployeeID] [int] NULL,
	[Status] [varchar](50) NOT NULL,
	[CreatedDate] [date] NOT NULL,
	[Remarks] [text] NULL,
	[ExpirationDate] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[QuotationID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RFQSupplierDetails]    Script Date: 1/27/2023 6:16:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RFQSupplierDetails](
	[QuotationID] [int] NOT NULL,
	[SupplierID] [int] NOT NULL,
	[QuoteReceived] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[QuotationID] ASC,
	[SupplierID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[PendingQuotation]    Script Date: 1/27/2023 6:16:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[PendingQuotation] AS
SELECT COUNT(RFQ.QuotationID) AS 'Total Pending Quotations' FROM RequestForQuotation RFQ INNER JOIN RFQSupplierDetails 
RFQS ON RFQ.QuotationID = RFQS.QuotationID WHERE QuoteReceived=0
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 1/27/2023 6:16:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee](
	[EmployeeID] [int] IDENTITY(1000,1) NOT NULL,
	[FirstName] [varchar](100) NOT NULL,
	[MiddleName] [varchar](100) NOT NULL,
	[LastName] [varchar](100) NOT NULL,
	[Gender] [varchar](10) NOT NULL,
	[UserID] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[EmployeeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PaymentTerms]    Script Date: 1/27/2023 6:16:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PaymentTerms](
	[PaymentTermsID] [int] IDENTITY(1000,1) NOT NULL,
	[PaymentName] [varchar](50) NOT NULL,
	[Discount] [float] NOT NULL,
	[DiscountValidity] [int] NULL,
	[Validity] [int] NULL,
	[Archived] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[PaymentTermsID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DirectPurchaseOrder]    Script Date: 1/27/2023 6:16:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DirectPurchaseOrder](
	[DirectPOID] [int] IDENTITY(1000,1) NOT NULL,
	[EmployeeID] [int] NOT NULL,
	[CreatedDate] [date] NOT NULL,
	[Remarks] [varchar](max) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[DirectPOID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  View [dbo].[DirectPO]    Script Date: 1/27/2023 6:16:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[DirectPO] AS
SELECT DPO.DirectPoID, CONCAT(E.FirstName, ' ', E.LastName) AS 'Employee Name', 
DPOI.ItemID, SI.ItemName, SII.Color, SII.UnitPrice, DPOI.Quantity, DPOD.SupplierID,
DPO.Remarks, DPO.CreatedDate, S.SupplierName, S.Address, S.SupplierEmail, PT.PaymentName,(SII.UnitPrice * DPOI.Quantity) AS 'Total Sum', DPOD.DirectPODetailsID
FROM DirectPurchaseOrderItem DPOI
INNER JOIN DirectPurchaseOrderDetails DPOD
ON DPOI.DirectPODetailsID = DPOD.DirectPODetailsID
INNER JOIN DirectPurchaseOrder DPO
ON DPOD.DirectPOID = DPO.DirectPOID
INNER JOIN SupplierItemDetails SII
ON DPOI.ItemID = SII.ProductID AND
DPOD.SupplierID = SII.SupplierID
INNER JOIN SupplierItem SI
ON SII.ItemID = SI.ItemID
INNER JOIN Employee E ON
DPO.EmployeeID = E.EmployeeID 
INNER JOIN Supplier S
INNER JOIN PaymentTerms PT
ON S.PaymentTermsID = PT.PaymentTermsID
ON DPOD.SupplierID = S.SupplierID 
GO
/****** Object:  View [dbo].[PendingQPO]    Script Date: 1/27/2023 6:16:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[PendingQPO] AS
SELECT COUNT(PurchaseOrderID) AS 'Total Pending Quotations ' FROM QuotationPurchaseOrder WHERE PurchaseOrderStatus='Pending'
GO
/****** Object:  View [dbo].[DPOSupplierItem]    Script Date: 1/27/2023 6:16:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[DPOSupplierItem] AS
SELECT DPOI.ItemID, SI.ItemName AS 'Item Name', SII.Color, DPOI.Quantity, SII.UnitPrice, (SII.UnitPrice * DPOI.Quantity) AS 'TotalPrice', 
DPOS.DirectPODetailsID, DPOS.SupplierID FROM DirectPurchaseOrderItem DPOI
INNER JOIN SupplierItemDetails SII
ON SII.ProductID = DPOI.ItemID
INNER JOIN SupplierItem SI
ON SII.ItemID = SI.ItemID
INNER JOIN DirectPurchaseOrderDetails DPOS
ON SII.SupplierID = DPOS.SupplierID
AND DPOI.DirectPODetailsID = DPOS.DirectPODetailsID
GO
/****** Object:  Table [dbo].[QPOItemSupplier]    Script Date: 1/27/2023 6:16:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QPOItemSupplier](
	[QuotationItemID] [int] NOT NULL,
	[SupplierID] [int] NOT NULL,
	[Price] [float] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[QuotationItemID] ASC,
	[SupplierID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[RFQSupplierCount]    Script Date: 1/27/2023 6:16:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[RFQSupplierCount] AS SELECT S.SupplierName, COUNT(QPOIS.SupplierID) AS 'Count' FROM QPOItemSupplier QPOIS INNER JOIN Supplier S ON QPOIS.SupplierID = S.SupplierID GROUP BY S.SupplierName
GO
/****** Object:  View [dbo].[DPOIDetails]    Script Date: 1/27/2023 6:16:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[DPOIDetails] AS
SELECT SI.ItemName, SII.Color, DPOI.Quantity, (SII.UnitPrice * DPOI.Quantity) AS 'Total Price', 
DPOD.DirectPODetailsID FROM DirectPurchaseOrderItem DPOI
INNER JOIN SupplierItemDetails SII
ON DPOI.ItemID = SII.ProductID
INNER JOIN SupplierItem SI
ON SII.ItemID = SI.ItemID
INNER JOIN DirectPurchaseOrderDetails DPOD
ON DPOD.DirectPODetailsID = DPOI.DirectPODetailsID
GO
/****** Object:  Table [dbo].[Category]    Script Date: 1/27/2023 6:16:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[CategoryID] [int] IDENTITY(1000,1) NOT NULL,
	[CategoryName] [varchar](50) NOT NULL,
	[Archived] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[CategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[InventoryReport]    Script Date: 1/27/2023 6:16:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[InventoryReport](
	[ItemReportID] [int] IDENTITY(1000,1) NOT NULL,
	[ItemID] [int] NOT NULL,
	[SupplierID] [int] NOT NULL,
	[SoldDate] [date] NOT NULL,
	[SoldQuantity] [int] NOT NULL,
	[EmployeeID] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ItemReportID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QuotationItems]    Script Date: 1/27/2023 6:16:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QuotationItems](
	[QuotationItemID] [int] IDENTITY(1000,1) NOT NULL,
	[ItemName] [varchar](100) NOT NULL,
	[Color] [varchar](20) NULL,
	[Quantity] [int] NOT NULL,
	[QuotationID] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[QuotationItemID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[NonFastMovingItemReport]    Script Date: 1/27/2023 6:16:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[NonFastMovingItemReport] AS
SELECT IR.ItemID, SI.ItemName, S.SupplierName, C.CategoryName, SII.Stocks AS 'Item On Hand', 
IR.SoldQuantity AS 'Quantity Sold', IR.SoldDate, SUM(SII.UnitPrice * IR.SoldQuantity) AS 'Sold Total',
CONCAT(SII.Discount,'%') AS 'Discount', SII.UnitPrice AS 'Purchase Price', (SII.UnitPrice - SII.UnitPrice * (SII.Discount/100)) AS 'Discounted Price',
(SII.UnitPrice * (SII.Discount/100)) AS 'Net Discount',
CAST(SII.Description AS nvarchar(100)) AS 'Description'
FROM InventoryReport IR INNER JOIN SupplierItemDetails SII
ON IR.ItemID = SII.ItemID AND IR.SupplierID = SII.SupplierID
INNER JOIN SupplierItem SI ON IR.ItemID = SI.ItemID
LEFT JOIN QuotationItems QI ON QI.ItemName = SI.ItemName
INNER JOIN Supplier S ON SII.SupplierID = S.SupplierID
INNER JOIN Category C ON SI.CategoryID = C.CategoryID
WHERE SI.ItemTypeID=1005
GROUP BY IR.SoldDate, IR.ItemID, SI.CategoryID, SII.Stocks, IR.SoldQuantity, 
CAST(SII.Description AS nvarchar(100)), SII.Discount, SII.UnitPrice, SI.ItemName, S.SupplierName, C.CategoryName
GO
/****** Object:  Table [dbo].[GRPOItem]    Script Date: 1/27/2023 6:16:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GRPOItem](
	[GRPOItemID] [int] IDENTITY(1000,1) NOT NULL,
	[ItemName] [varchar](max) NOT NULL,
	[Color] [varchar](50) NOT NULL,
	[OrderedQuantity] [int] NOT NULL,
	[DeliveredQuantity] [int] NOT NULL,
	[Comment] [varchar](max) NOT NULL,
	[GoodReceiptID] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[GRPOItemID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GRPO]    Script Date: 1/27/2023 6:16:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GRPO](
	[GoodsReceiptID] [int] IDENTITY(1000,1) NOT NULL,
	[PurchaseOrderID] [int] NOT NULL,
	[IsPartial] [bit] NOT NULL,
	[TotalPrice] [float] NOT NULL,
	[EmployeeID] [int] NOT NULL,
	[ReceivedDate] [date] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[GoodsReceiptID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[QGRPOReceipt]    Script Date: 1/27/2023 6:16:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[QGRPOReceipt] AS
SELECT GRPOI.GRPOItemID, CONCAT(EMP.FirstName,' ',EMP.LastName) AS 'EmployeeName', S.SupplierEmail, S.Address,
G.ReceivedDate, G.GoodsReceiptID, G.TotalPrice,
GRPOI.ItemName, GRPOI.Color, GRPOI.OrderedQuantity, GRPOI.DeliveredQuantity, QPO.PurchaseOrderID, 
S.SupplierName, GRPOI.Comment FROM GRPOItem GRPOI
INNER JOIN GRPO G ON GRPOI.GoodReceiptID = G.GoodsReceiptID
INNER JOIN QuotationPurchaseOrder QPO ON G.PurchaseOrderID = QPO.PurchaseOrderID 
INNER JOIN Supplier S ON QPO.SupplierID = S.SupplierID
INNER JOIN Employee EMP ON G.EmployeeID = EMP.EmployeeID
GO
/****** Object:  View [dbo].[DirectPODetails]    Script Date: 1/27/2023 6:16:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[DirectPODetails] AS
SELECT DPOD.DirectPOID AS 'ID', DPOD.DirectPODetailsID AS 'DirectPO ID', S.SupplierName AS 'Supplier Name', DPOD.PurchaseOrderStatus AS 'PO Status', SUM(DPOI.Quantity) AS 'Total Items' 
FROM DirectPurchaseOrderDetails DPOD
INNER JOIN Supplier S ON 
DPOD.SupplierID = S.SupplierID
INNER JOIN DirectPurchaseOrderItem DPOI
ON DPOD.DirectPODetailsID = DPOI.DirectPODetailsID
GROUP BY S.SupplierName,DPOD.PurchaseOrderStatus,DPOD.DirectPOID, DPOD.DirectPODetailsID
GO
/****** Object:  Table [dbo].[DirectGRPOItem]    Script Date: 1/27/2023 6:16:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DirectGRPOItem](
	[GRPOItemID] [int] IDENTITY(1000,1) NOT NULL,
	[ItemName] [varchar](max) NOT NULL,
	[Color] [varchar](50) NOT NULL,
	[OrderedQuantity] [int] NOT NULL,
	[DeliveredQuantity] [int] NOT NULL,
	[Comment] [varchar](max) NULL,
	[GoodReceiptID] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[GRPOItemID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DGRPO]    Script Date: 1/27/2023 6:16:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DGRPO](
	[GoodsReceiptID] [int] IDENTITY(1000,1) NOT NULL,
	[DirectPoID] [int] NOT NULL,
	[IsPartial] [bit] NOT NULL,
	[TotalPrice] [float] NOT NULL,
	[EmployeeID] [int] NULL,
	[ReceivedDate] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[GoodsReceiptID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[DGRPOReceipt]    Script Date: 1/27/2023 6:16:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[DGRPOReceipt] AS
SELECT DPOI.ItemID, CONCAT(E.FirstName,' ',E.LastName) AS 'EmployeeName', 
DGRPO.GoodsReceiptID, DGRPOI.ItemName, DGRPOI.Color, DGRPOI.OrderedQuantity, DGRPOI.DeliveredQuantity, 
DGRPOI.Comment, S.SupplierID, S.SupplierName, DGRPO.TotalPrice,
S.SupplierEmail, S.Address FROM DirectGRPOItem DGRPOI
INNER JOIN DGRPO ON DGRPOI.GoodReceiptID = DGRPO.GoodsReceiptID
INNER JOIN DirectPurchaseOrderDetails DPD ON
DGRPO.DirectPoID = DPD.DirectPODetailsID
INNER JOIN Supplier S ON
DPD.SupplierID = S.SupplierID
INNER JOIN DirectPurchaseOrderItem DPOI
ON DPD.DirectPODetailsID = DPOI.DirectPODetailsID
INNER JOIN SupplierItemDetails SII
ON DPOI.ItemID = SII.ProductID AND DGRPOI.Color = SII.Color 
INNER JOIN Employee E ON DGRPO.EmployeeID = E.EmployeeID
GO
/****** Object:  Table [dbo].[JournalEntry]    Script Date: 1/27/2023 6:16:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[JournalEntry](
	[JournalEntryID] [int] IDENTITY(1000,1) NOT NULL,
	[AccountPayableID] [int] NOT NULL,
	[BusinessWalletID] [int] NOT NULL,
	[CreatedDate] [date] NOT NULL,
	[AmountPaid] [float] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[JournalEntryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[DPOAPDetails]    Script Date: 1/27/2023 6:16:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[DPOAPDetails] AS
SELECT DPOD.DirectPODetailsID AS 'ID', DPO.CreatedDate, 
DATEADD(day, PT.Validity, DPO.CreatedDate) AS 'Due Date', 
AP.TotalAmount AS 'Remaining AP Balance', SUM(JE.AmountPaid) AS 
'Total Paid', S.SupplierName, AP.isPaid, AP.SupplierID FROM DirectPurchaseOrderDetails DPOD
INNER JOIN Supplier S ON DPOD.SupplierID = S.SupplierID
INNER JOIN DirectPurchaseOrderItem DPOI ON
DPOD.DirectPODetailsID = DPOI.DirectPODetailsID
INNER JOIN DirectPurchaseOrder DPO
ON DPOD.DirectPOID = DPO.DirectPOID
INNER JOIN PaymentTerms PT ON
S.PaymentTermsID = PT.PaymentTermsID
INNER JOIN AccountsPayable AP ON
DPOD.AccountPayableID = AP.AccountPayableID
LEFT JOIN JournalEntry JE ON
AP.AccountPayableID = JE.AccountPayableID
GROUP BY DPOD.DirectPODetailsID, DPO.CreatedDate, 
DATEADD(day, PT.Validity, DPO.CreatedDate), S.SupplierName, AP.isPaid, AP.SupplierID, AP.TotalAmount
GO
/****** Object:  View [dbo].[QPOAPDetails]    Script Date: 1/27/2023 6:16:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[QPOAPDetails] AS
SELECT QPO.PurchaseOrderID AS 'ID', QPO.CreatedDate, DATEADD(day, PT.Validity, QPO.CreatedDate) AS 'Due Date', SUM(AP.TotalAmount) 
AS 'Remaining AP Balance', SUM(JE.AmountPaid) AS 'Total Paid',  AP.isPaid,
S.SupplierName, S.SupplierID FROM QuotationPurchaseOrder QPO INNER JOIN AccountsPayable AP ON QPO.AccountPayableID = AP.AccountPayableID 
INNER JOIN GRPO ON QPO.PurchaseOrderID = GRPO.PurchaseOrderID INNER JOIN Supplier S ON QPO.SupplierID = S.SupplierID INNER 
JOIN PaymentTerms PT ON PT.PaymentTermsID = S.PaymentTermsID  LEFT JOIN JournalEntry JE ON 
AP.AccountPayableID = JE.AccountPayableID 
GROUP BY QPO.PurchaseOrderID, QPO.CreatedDate, QPO.CreatedDate, DATEADD(day, PT.Validity, QPO.CreatedDate), S.SupplierName, S.SupplierID, AP.isPaid
GO
/****** Object:  View [dbo].[GetAPInfo]    Script Date: 1/27/2023 6:16:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[GetAPInfo] AS
SELECT DPOI.ItemID, DPOD.AccountPayableID, AP.TotalAmount, DPOD.DirectPODetailsID FROM SupplierItemDetails SII
INNER JOIN DirectPurchaseOrderItem DPOI
ON SII.ProductID = DPOI.ItemID
INNER JOIN SupplierItem S
ON SII.ItemID = S.ItemID
INNER JOIN DirectPurchaseOrderDetails DPOD
ON DPOI.DirectPODetailsID = DPOD.DirectPODetailsID
AND SII.SupplierID = DPOD.SupplierID
INNER JOIN AccountsPayable AP
ON DPOD.AccountPayableID = AP.AccountPayableID
GO
/****** Object:  View [dbo].[APQPO]    Script Date: 1/27/2023 6:16:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[APQPO] AS
SELECT QPO.PurchaseOrderID, QPO.CreatedDate, DATEADD(day, PT.Validity, QPO.CreatedDate) AS 'Due Date', 
SUM(AP.TotalAmount) AS 'Remaining AP Balance', SUM(JE.AmountPaid) AS 'Total Paid', S.SupplierName, AP.isPaid, AP.SupplierID FROM 
QuotationPurchaseOrder QPO INNER JOIN AccountsPayable AP ON QPO.AccountPayableID = AP.AccountPayableID 
INNER JOIN GRPO ON QPO.PurchaseOrderID = GRPO.PurchaseOrderID INNER JOIN Supplier S ON QPO.SupplierID = 
S.SupplierID INNER JOIN PaymentTerms PT ON PT.PaymentTermsID = S.PaymentTermsID  LEFT JOIN JournalEntry 
JE ON AP.AccountPayableID = JE.AccountPayableID GROUP BY 
QPO.PurchaseOrderID, QPO.CreatedDate, QPO.CreatedDate, DATEADD(day, PT.Validity, QPO.CreatedDate), S.SupplierName, AP.isPaid, AP.SupplierID
GO
/****** Object:  View [dbo].[DirectPOQuantities]    Script Date: 1/27/2023 6:16:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[DirectPOQuantities] AS
SELECT SUM(DPOI.Quantity) AS 'Total Quantities', DPOD.SupplierID FROM DirectPurchaseOrderItem DPOI INNER JOIN 
DirectPurchaseOrderDetails DPOD ON DPOI.DirectPODetailsID = DPOD.DirectPODetailsID
GROUP BY DPOI.DirectPODetailsID, DPOD.SupplierID
GO
/****** Object:  View [dbo].[DGRPOInfo]    Script Date: 1/27/2023 6:16:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[DGRPOInfo] AS
SELECT DGRPOI.ItemName, (DGRPOI.DeliveredQuantity) 'Received Quantity', DPD.DirectPODetailsID FROM DirectGRPOItem DGRPOI
INNER JOIN DGRPO ON DGRPOI.GoodReceiptID = DGRPO.GoodsReceiptID
INNER JOIN DirectPurchaseOrderDetails DPD ON
DGRPO.DirectPoID = DPD.DirectPODetailsID 
INNER JOIN DirectPurchaseOrderItem DPOI
ON DPD.DirectPODetailsID = DPOI.DirectPODetailsID
GROUP BY DGRPOI.ItemName,DPD.DirectPODetailsID, DGRPOI.DeliveredQuantity
GO
/****** Object:  View [dbo].[PendingAP]    Script Date: 1/27/2023 6:16:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[PendingAP] AS
SELECT COUNT(AccountPayableID) AS 'Total Count' FROM AccountsPayable WHERE isPaid=0 AND TotalAmount > 0 GROUP BY SupplierID
GO
/****** Object:  View [dbo].[PendingDPO]    Script Date: 1/27/2023 6:16:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[PendingDPO] AS
SELECT COUNT(DirectPODetailsID) As 'Total Pending DPO' FROM DirectPurchaseOrderDetails 
WHERE PurchaseOrderStatus='Pending' OR PurchaseOrderStatus='Partial'
GO
/****** Object:  View [dbo].[TotalReport]    Script Date: 1/27/2023 6:16:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[TotalReport] AS
SELECT IR.ItemID, SI.ItemName, S.SupplierName, C.CategoryName, SII.Stocks AS 'Item On Hand', 
IR.SoldQuantity AS 'Quantity Sold', IR.SoldDate, 
SUM(SII.UnitPrice * IR.SoldQuantity) AS 'Sold Total',
CONCAT(SII.Discount,'%') AS 'Discount', FORMAT(SII.UnitPrice, 'c', 'en-PH') AS 'Purchase Price', 
FORMAT((SII.UnitPrice - SII.UnitPrice * (SII.Discount/100)), 'c', 'en-PH') AS 'Discounted Price',
FORMAT((SII.UnitPrice * (SII.Discount/100)), 'c', 'en-PH') AS 'Discount Per Unit Price',
CAST(SII.Description AS nvarchar(100)) AS 'Description'
FROM InventoryReport IR INNER JOIN SupplierItemDetails SII
ON IR.ItemID = SII.ItemID AND IR.SupplierID = SII.SupplierID
INNER JOIN SupplierItem SI ON IR.ItemID = SI.ItemID
LEFT JOIN QuotationItems QI ON QI.ItemName = SI.ItemName
INNER JOIN Supplier S ON SII.SupplierID = S.SupplierID
INNER JOIN Category C ON SI.CategoryID = C.CategoryID
GROUP BY IR.SoldDate, IR.ItemID, SI.CategoryID, SII.Stocks, IR.SoldQuantity, 
CAST(SII.Description AS nvarchar(100)), SII.Discount, SII.UnitPrice, SI.ItemName, S.SupplierName, C.CategoryName, MONTH(IR.SoldDate)
GO
/****** Object:  View [dbo].[MonthlySales]    Script Date: 1/27/2023 6:16:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[MonthlySales] AS
SELECT TOP 9999999 DATENAME(mm,SoldDate) AS 'Date', 
SUM([Sold Total]) AS 'Monthly Sales' FROM TotalReport GROUP BY MONTH(SoldDate), DATENAME(MONTH,SoldDate) ORDER BY MONTH(SoldDate)
GO
/****** Object:  View [dbo].[SupplierTotalDiscounts]    Script Date: 1/27/2023 6:16:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[SupplierTotalDiscounts] AS
SELECT SII.SupplierID, S.SupplierName, (SUM(Discount)/100) AS 'Total Discounts' FROM SupplierItemDetails SII INNER JOIN Supplier S ON 
SII.SupplierID = S.SupplierID WHERE Discount > 0 GROUP BY S.SupplierName, SII.SupplierID
GO
/****** Object:  View [dbo].[APDPO]    Script Date: 1/27/2023 6:16:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[APDPO] AS
SELECT DPOD.DirectPODetailsID AS 'ID', DPO.CreatedDate, 
DATEADD(day, PT.Validity, DPO.CreatedDate) AS 'Due Date', 
SUM(AP.TotalAmount) AS 'Remaining AP Balance', SUM(JE.AmountPaid) AS 
'Total Paid', S.SupplierName, AP.isPaid, AP.SupplierID FROM DirectPurchaseOrderDetails DPOD
INNER JOIN Supplier S ON DPOD.SupplierID = S.SupplierID
INNER JOIN DirectPurchaseOrderItem DPOI ON
DPOD.DirectPODetailsID = DPOI.DirectPODetailsID
INNER JOIN DirectPurchaseOrder DPO
ON DPOD.DirectPOID = DPO.DirectPOID
INNER JOIN PaymentTerms PT ON
S.PaymentTermsID = PT.PaymentTermsID
INNER JOIN AccountsPayable AP ON
DPOD.AccountPayableID = AP.AccountPayableID
LEFT JOIN JournalEntry JE ON
AP.AccountPayableID = JE.AccountPayableID
GROUP BY DPOD.DirectPODetailsID, DPO.CreatedDate, DATEADD(day, PT.Validity, DPO.CreatedDate), S.SupplierName, AP.isPaid, AP.SupplierID
GO
/****** Object:  View [dbo].[QPONetDiscount]    Script Date: 1/27/2023 6:16:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[QPONetDiscount] AS
SELECT QPO.PurchaseOrderID, QI.ItemName, QI.Color, 
QI.Quantity,
FORMAT(CAST(SUM(QPOIS.Price * QI.Quantity) as decimal(7,2)), 'C', 'en-PH')
AS 'Grand Total', FORMAT(CAST((SUM(QPOIS.Price * QI.Quantity) - 
(SUM(QPOIS.Price * QI.Quantity) * (PT.Discount / 100))) as decimal(7,2)), 'C', 'en-PH') 
AS 'Grand Total after Discount',
FORMAT(CAST((QPOIS.Price - (QPOIS.Price * (PT.Discount / 100))) as decimal(7,2)), 'C', 'en-PH') 
AS 'Total Discount Unit Price',
CASE 
	WHEN NS.TotalSaving is null then FORMAT(0, 'C', 'en-PH')
	WHEN NS.TotalSaving is not null then FORMAT(CAST(NS.TotalSaving as decimal(7,2)), 'C', 'en-PH')
END AS 'Total Saving',
PT.PaymentName, CONCAT(PT.Discount,'%') AS 'Discount', S.SupplierName
FROM QPOItemSupplier QPOIS
INNER JOIN QuotationItems QI
ON QPOIS.QuotationItemID = QI.QuotationItemID
INNER JOIN RequestForQuotation RFQ
ON RFQ.QuotationID = QI.QuotationID
INNER JOIN QuotationPurchaseOrder QPO
ON RFQ.QuotationID = QPO.QuotationID
AND QPOIS.SupplierID = QPO.SupplierID
INNER JOIN Supplier S
ON QPO.SupplierID = S.SupplierID
INNER JOIN PaymentTerms PT
ON S.PaymentTermsID = PT.PaymentTermsID
INNER JOIN AccountsPayable AP
ON QPO.AccountPayableID = AP.AccountPayableID
LEFT JOIN NetSaving NS
ON AP.AccountPayableID = NS.AccountPayableID
GROUP BY QI.ItemName, QI.Color, PT.Discount, 
QPOIS.Price, QI.Quantity, PT.PaymentName, PT.Discount, 
QPO.PurchaseOrderID, S.SupplierName, NS.TotalSaving
GO
/****** Object:  View [dbo].[ReleaseItems]    Script Date: 1/27/2023 6:16:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[ReleaseItems] AS
SELECT SI.ItemName, SUM(SoldQuantity) AS 'Sold Quantity' FROM InventoryReport IR
INNER JOIN SupplierItem SI ON
IR.ItemID = SI.ItemID GROUP BY SI.ItemName
GO
/****** Object:  View [dbo].[FastMovingItemReport]    Script Date: 1/27/2023 6:16:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[FastMovingItemReport] AS
SELECT IR.ItemID, SI.ItemName, S.SupplierName, C.CategoryName, SII.Stocks AS 'Item On Hand', 
IR.SoldQuantity AS 'Quantity Sold', IR.SoldDate, 
SUM(SII.UnitPrice * IR.SoldQuantity) AS 'Sold Total',
CONCAT(SII.Discount,'%') AS 'Discount', FORMAT(SII.UnitPrice, 'c', 'en-PH') AS 'Purchase Price', 
FORMAT((SII.UnitPrice - SII.UnitPrice * (SII.Discount/100)), 'c', 'en-PH') AS 'Discounted Price',
FORMAT((SII.UnitPrice * (SII.Discount/100)), 'c', 'en-PH') AS 'Discount Per Unit Price',
CAST(SII.Description AS nvarchar(100)) AS 'Description'
FROM InventoryReport IR INNER JOIN SupplierItemDetails SII
ON IR.ItemID = SII.ItemID AND IR.SupplierID = SII.SupplierID
INNER JOIN SupplierItem SI ON IR.ItemID = SI.ItemID
LEFT JOIN QuotationItems QI ON QI.ItemName = SI.ItemName
INNER JOIN Supplier S ON SII.SupplierID = S.SupplierID
INNER JOIN Category C ON SI.CategoryID = C.CategoryID
WHERE SI.ItemTypeID=1004
GROUP BY IR.SoldDate, IR.ItemID, SI.CategoryID, SII.Stocks, IR.SoldQuantity, 
CAST(SII.Description AS nvarchar(100)), SII.Discount, SII.UnitPrice, SI.ItemName, S.SupplierName, C.CategoryName, MONTH(IR.SoldDate)
GO
/****** Object:  View [dbo].[APDPODetails]    Script Date: 1/27/2023 6:16:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE view [dbo].[APDPODetails] AS
SELECT DPOD.DirectPODetailsID, DPO.CreatedDate,
CONCAT(E.FirstName, ' ', E.MiddleName, ' ', E.LastName) AS 'Employee Name',
PT.PaymentName, PT.Discount, PT.DiscountValidity, PT.Validity, S.SupplierName
FROM DirectPurchaseOrderDetails DPOD
INNER JOIN DirectPurchaseOrder DPO
ON DPOD.DirectPOID = DPO.DirectPOID
INNER JOIN Employee E
ON DPO.EmployeeID = DPO.EmployeeID
INNER JOIN Supplier S
ON DPOD.SupplierID = S.SupplierID
INNER JOIN PaymentTerms PT ON
S.PaymentTermsID = PT.PaymentTermsID
GO
/****** Object:  View [dbo].[QPDPODetails]    Script Date: 1/27/2023 6:16:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[QPDPODetails] AS
SELECT QPO.PurchaseOrderID, QPO.CreatedDate, 
CONCAT(E.FirstName, ' ', E.MiddleName, ' ', E.LastName)
as 'Employee Name', PT.PaymentName, PT.Discount, PT.DiscountValidity, PT.Validity, S.SupplierName FROM QuotationPurchaseOrder QPO
INNER JOIN Employee E
ON QPO.EmployeeID = E.EmployeeID
INNER JOIN Supplier S
ON S.SupplierID = QPO.SupplierID
INNER JOIN PaymentTerms PT
ON S.PaymentTermsID = PT.PaymentTermsID
GO
/****** Object:  View [dbo].[TotalSavings]    Script Date: 1/27/2023 6:16:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[TotalSavings] AS
SELECT FORMAT(SUM((SII.UnitPrice * (SII.Discount/100) * SII.Stocks)), 'c', 'en-PH') 
AS 'Total Net Savings'
FROM SupplierItemDetails SII
INNER JOIN SupplierItem SI
ON SII.ItemID = SI.ItemID
INNER JOIN Supplier S
ON SII.SupplierID = S.SupplierID
GO
/****** Object:  Table [dbo].[AccountCredential]    Script Date: 1/27/2023 6:16:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AccountCredential](
	[UserID] [int] IDENTITY(1000,1) NOT NULL,
	[UserName] [varchar](50) NOT NULL,
	[Password] [varchar](50) NOT NULL,
	[EmpTypeID] [int] NOT NULL,
	[LoggedIn] [bit] NOT NULL,
	[Enabled] [bit] NOT NULL,
	[Archived] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BusinessWallet]    Script Date: 1/27/2023 6:16:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BusinessWallet](
	[BusinessWalletID] [int] IDENTITY(1000,1) NOT NULL,
	[WalletName] [varchar](50) NOT NULL,
	[TotalBalance] [float] NOT NULL,
	[Archived] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[BusinessWalletID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EmployeeType]    Script Date: 1/27/2023 6:16:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EmployeeType](
	[EmpTypeID] [int] IDENTITY(1000,1) NOT NULL,
	[AccountType] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[EmpTypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ItemType]    Script Date: 1/27/2023 6:16:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ItemType](
	[ItemTypeID] [int] IDENTITY(1000,1) NOT NULL,
	[TypeName] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ItemTypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QuotationPurchaseOrderItems]    Script Date: 1/27/2023 6:16:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QuotationPurchaseOrderItems](
	[PoItemsID] [int] IDENTITY(1000,1) NOT NULL,
	[QuotationItemID] [int] NULL,
	[price] [float] NULL,
	[Status] [varchar](50) NOT NULL,
	[SupplierID] [int] NOT NULL,
UNIQUE NONCLUSTERED 
(
	[QuotationItemID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[AccountCredential] ADD  DEFAULT ((0)) FOR [LoggedIn]
GO
ALTER TABLE [dbo].[AccountCredential] ADD  DEFAULT ((1)) FOR [Enabled]
GO
ALTER TABLE [dbo].[AccountCredential] ADD  DEFAULT ((0)) FOR [Archived]
GO
ALTER TABLE [dbo].[AccountsPayable] ADD  DEFAULT ((0)) FOR [isPaid]
GO
ALTER TABLE [dbo].[BusinessWallet] ADD  DEFAULT ((0.0)) FOR [TotalBalance]
GO
ALTER TABLE [dbo].[BusinessWallet] ADD  DEFAULT ((0)) FOR [Archived]
GO
ALTER TABLE [dbo].[DGRPO] ADD  DEFAULT ((0)) FOR [IsPartial]
GO
ALTER TABLE [dbo].[DGRPO] ADD  DEFAULT (getdate()) FOR [ReceivedDate]
GO
ALTER TABLE [dbo].[DirectGRPOItem] ADD  DEFAULT ('No Description Provided.') FOR [Comment]
GO
ALTER TABLE [dbo].[GRPO] ADD  DEFAULT ((0)) FOR [IsPartial]
GO
ALTER TABLE [dbo].[PaymentTerms] ADD  DEFAULT ((0)) FOR [Archived]
GO
ALTER TABLE [dbo].[QPOItemSupplier] ADD  DEFAULT ((0.0)) FOR [Price]
GO
ALTER TABLE [dbo].[QuotationItems] ADD  DEFAULT ('No color specified.') FOR [Color]
GO
ALTER TABLE [dbo].[QuotationPurchaseOrder] ADD  DEFAULT ('No description provided') FOR [Remarks]
GO
ALTER TABLE [dbo].[QuotationPurchaseOrder] ADD  DEFAULT ('Pending') FOR [PurchaseOrderStatus]
GO
ALTER TABLE [dbo].[QuotationPurchaseOrderItems] ADD  DEFAULT ('Processing') FOR [Status]
GO
ALTER TABLE [dbo].[RequestForQuotation] ADD  DEFAULT ('Pending') FOR [Status]
GO
ALTER TABLE [dbo].[RequestForQuotation] ADD  DEFAULT (getdate()) FOR [CreatedDate]
GO
ALTER TABLE [dbo].[RequestForQuotation] ADD  DEFAULT ('No Remarks Provided') FOR [Remarks]
GO
ALTER TABLE [dbo].[RFQSupplierDetails] ADD  DEFAULT ((0)) FOR [QuoteReceived]
GO
ALTER TABLE [dbo].[SupplierItemDetails] ADD  DEFAULT ('No Description provided.') FOR [Description]
GO
ALTER TABLE [dbo].[SupplierItemDetails] ADD  DEFAULT ((0)) FOR [Discount]
GO
ALTER TABLE [dbo].[AccountCredential]  WITH CHECK ADD FOREIGN KEY([EmpTypeID])
REFERENCES [dbo].[EmployeeType] ([EmpTypeID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AccountsPayable]  WITH CHECK ADD FOREIGN KEY([SupplierID])
REFERENCES [dbo].[Supplier] ([SupplierID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[DGRPO]  WITH CHECK ADD FOREIGN KEY([EmployeeID])
REFERENCES [dbo].[Employee] ([EmployeeID])
ON UPDATE SET NULL
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[DGRPO]  WITH CHECK ADD  CONSTRAINT [FK_DGRPO_DirectPurchaseOrderDetails] FOREIGN KEY([DirectPoID])
REFERENCES [dbo].[DirectPurchaseOrderDetails] ([DirectPODetailsID])
GO
ALTER TABLE [dbo].[DGRPO] CHECK CONSTRAINT [FK_DGRPO_DirectPurchaseOrderDetails]
GO
ALTER TABLE [dbo].[DirectGRPOItem]  WITH CHECK ADD FOREIGN KEY([GoodReceiptID])
REFERENCES [dbo].[DGRPO] ([GoodsReceiptID])
GO
ALTER TABLE [dbo].[DirectPurchaseOrder]  WITH CHECK ADD FOREIGN KEY([EmployeeID])
REFERENCES [dbo].[Employee] ([EmployeeID])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[DirectPurchaseOrderDetails]  WITH CHECK ADD FOREIGN KEY([AccountPayableID])
REFERENCES [dbo].[AccountsPayable] ([AccountPayableID])
GO
ALTER TABLE [dbo].[DirectPurchaseOrderDetails]  WITH CHECK ADD FOREIGN KEY([DirectPOID])
REFERENCES [dbo].[DirectPurchaseOrder] ([DirectPOID])
GO
ALTER TABLE [dbo].[DirectPurchaseOrderDetails]  WITH CHECK ADD FOREIGN KEY([SupplierID])
REFERENCES [dbo].[Supplier] ([SupplierID])
GO
ALTER TABLE [dbo].[DirectPurchaseOrderItem]  WITH CHECK ADD FOREIGN KEY([DirectPODetailsID])
REFERENCES [dbo].[DirectPurchaseOrderDetails] ([DirectPODetailsID])
GO
ALTER TABLE [dbo].[DirectPurchaseOrderItem]  WITH CHECK ADD FOREIGN KEY([ItemID])
REFERENCES [dbo].[SupplierItemDetails] ([ProductID])
GO
ALTER TABLE [dbo].[Employee]  WITH CHECK ADD FOREIGN KEY([UserID])
REFERENCES [dbo].[AccountCredential] ([UserID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[GRPO]  WITH CHECK ADD FOREIGN KEY([EmployeeID])
REFERENCES [dbo].[Employee] ([EmployeeID])
GO
ALTER TABLE [dbo].[GRPO]  WITH CHECK ADD FOREIGN KEY([PurchaseOrderID])
REFERENCES [dbo].[QuotationPurchaseOrder] ([PurchaseOrderID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[GRPOItem]  WITH CHECK ADD FOREIGN KEY([GoodReceiptID])
REFERENCES [dbo].[GRPO] ([GoodsReceiptID])
GO
ALTER TABLE [dbo].[InventoryReport]  WITH CHECK ADD FOREIGN KEY([EmployeeID])
REFERENCES [dbo].[Employee] ([EmployeeID])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[InventoryReport]  WITH CHECK ADD FOREIGN KEY([ItemID])
REFERENCES [dbo].[SupplierItem] ([ItemID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[InventoryReport]  WITH CHECK ADD FOREIGN KEY([SupplierID])
REFERENCES [dbo].[Supplier] ([SupplierID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[JournalEntry]  WITH CHECK ADD FOREIGN KEY([AccountPayableID])
REFERENCES [dbo].[AccountsPayable] ([AccountPayableID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[JournalEntry]  WITH CHECK ADD FOREIGN KEY([BusinessWalletID])
REFERENCES [dbo].[BusinessWallet] ([BusinessWalletID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[NetSaving]  WITH CHECK ADD FOREIGN KEY([AccountPayableID])
REFERENCES [dbo].[AccountsPayable] ([AccountPayableID])
ON UPDATE SET NULL
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[QPOItemSupplier]  WITH CHECK ADD FOREIGN KEY([QuotationItemID])
REFERENCES [dbo].[QuotationItems] ([QuotationItemID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[QPOItemSupplier]  WITH CHECK ADD FOREIGN KEY([SupplierID])
REFERENCES [dbo].[Supplier] ([SupplierID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[QuotationItems]  WITH CHECK ADD FOREIGN KEY([QuotationID])
REFERENCES [dbo].[RequestForQuotation] ([QuotationID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[QuotationPurchaseOrder]  WITH CHECK ADD FOREIGN KEY([AccountPayableID])
REFERENCES [dbo].[AccountsPayable] ([AccountPayableID])
GO
ALTER TABLE [dbo].[QuotationPurchaseOrder]  WITH CHECK ADD FOREIGN KEY([EmployeeID])
REFERENCES [dbo].[Employee] ([EmployeeID])
GO
ALTER TABLE [dbo].[QuotationPurchaseOrder]  WITH CHECK ADD FOREIGN KEY([QuotationID])
REFERENCES [dbo].[RequestForQuotation] ([QuotationID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[QuotationPurchaseOrder]  WITH CHECK ADD FOREIGN KEY([SupplierID])
REFERENCES [dbo].[Supplier] ([SupplierID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[QuotationPurchaseOrderItems]  WITH CHECK ADD FOREIGN KEY([QuotationItemID])
REFERENCES [dbo].[QuotationItems] ([QuotationItemID])
GO
ALTER TABLE [dbo].[QuotationPurchaseOrderItems]  WITH CHECK ADD FOREIGN KEY([SupplierID])
REFERENCES [dbo].[Supplier] ([SupplierID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[RequestForQuotation]  WITH CHECK ADD FOREIGN KEY([EmployeeID])
REFERENCES [dbo].[Employee] ([EmployeeID])
ON UPDATE CASCADE
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[RFQSupplierDetails]  WITH CHECK ADD FOREIGN KEY([QuotationID])
REFERENCES [dbo].[RequestForQuotation] ([QuotationID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[RFQSupplierDetails]  WITH CHECK ADD FOREIGN KEY([SupplierID])
REFERENCES [dbo].[Supplier] ([SupplierID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Supplier]  WITH CHECK ADD FOREIGN KEY([PaymentTermsID])
REFERENCES [dbo].[PaymentTerms] ([PaymentTermsID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[SupplierItem]  WITH CHECK ADD FOREIGN KEY([CategoryID])
REFERENCES [dbo].[Category] ([CategoryID])
GO
ALTER TABLE [dbo].[SupplierItem]  WITH CHECK ADD FOREIGN KEY([ItemTypeID])
REFERENCES [dbo].[ItemType] ([ItemTypeID])
GO
ALTER TABLE [dbo].[SupplierItemDetails]  WITH CHECK ADD FOREIGN KEY([ItemID])
REFERENCES [dbo].[SupplierItem] ([ItemID])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[SupplierItemDetails]  WITH CHECK ADD  CONSTRAINT [FK__SupplierI__Quota__37703C52] FOREIGN KEY([QuotationItemID])
REFERENCES [dbo].[QuotationItems] ([QuotationItemID])
ON UPDATE SET NULL
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[SupplierItemDetails] CHECK CONSTRAINT [FK__SupplierI__Quota__37703C52]
GO
ALTER TABLE [dbo].[SupplierItemDetails]  WITH CHECK ADD FOREIGN KEY([SupplierID])
REFERENCES [dbo].[Supplier] ([SupplierID])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[SupplierItemDetails]  WITH CHECK ADD FOREIGN KEY([SupplierID])
REFERENCES [dbo].[Supplier] ([SupplierID])
GO
USE [master]
GO
ALTER DATABASE [ProcurementSystem] SET  READ_WRITE 
GO
