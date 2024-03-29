USE [Project1DB]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 11/3/2019 10:48:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Category](
	[Code] [varchar](255) NOT NULL,
	[Name] [varchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Code] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 11/3/2019 10:48:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Customer](
	[Code] [varchar](255) NOT NULL,
	[Name] [varchar](255) NOT NULL,
	[Address] [varchar](255) NULL,
	[Email] [varchar](255) NOT NULL,
	[Contact] [varchar](255) NOT NULL,
	[LoyalityPoint] [numeric](18, 2) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Code] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Product]    Script Date: 11/3/2019 10:48:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Product](
	[Code] [varchar](255) NOT NULL,
	[Name] [varchar](255) NOT NULL,
	[Category] [varchar](255) NOT NULL,
	[ReorderLevel] [int] NOT NULL,
	[Description] [text] NULL,
PRIMARY KEY CLUSTERED 
(
	[Code] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Purchase]    Script Date: 11/3/2019 10:48:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Purchase](
	[PurchaseCode] [int] IDENTITY(20190001,1) NOT NULL,
	[InvoiceNo] [varchar](255) NOT NULL,
	[Date] [date] NOT NULL,
	[Supplier] [varchar](255) NOT NULL,
	[Category] [varchar](255) NOT NULL,
	[Product] [varchar](255) NOT NULL,
	[ManufactureDate] [date] NULL,
	[ExpireDate] [date] NULL,
	[Quantity] [numeric](18, 2) NOT NULL,
	[UnitPrice] [numeric](18, 2) NOT NULL,
	[MRP] [numeric](18, 2) NOT NULL,
	[Remarks] [text] NULL,
 CONSTRAINT [PK_Purchase] PRIMARY KEY CLUSTERED 
(
	[PurchaseCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Sales]    Script Date: 11/3/2019 10:48:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Sales](
	[SalesCode] [int] IDENTITY(20190001,1) NOT NULL,
	[Date] [date] NOT NULL,
	[Customer] [varchar](255) NOT NULL,
	[Category] [varchar](255) NOT NULL,
	[Product] [varchar](255) NOT NULL,
	[Quantity] [numeric](18, 2) NOT NULL,
	[MRP] [numeric](18, 2) NOT NULL,
 CONSTRAINT [PK_Sales] PRIMARY KEY CLUSTERED 
(
	[SalesCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Supplier]    Script Date: 11/3/2019 10:48:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Supplier](
	[Code] [varchar](255) NOT NULL,
	[Name] [varchar](255) NOT NULL,
	[Address] [varchar](255) NULL,
	[Email] [varchar](255) NOT NULL,
	[Contact] [varchar](255) NOT NULL,
	[ContactPerson] [varchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[Code] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  View [dbo].[StockIn]    Script Date: 11/3/2019 10:48:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW Available AS
 SELECT Pro.PC AS Category, Pro.PP AS Product, 
 CASE 
	WHEN SQ IS NULL THEN PQ
	ELSE PQ-SQ
 END AS Quantity FROM
	(SELECT P.Category AS PC, P.Product AS PP, SUM(P.Quantity) AS PQ FROM Purchase AS P GROUP BY P.Category, P.Product) AS Pro
		LEFT JOIN
		(SELECT S.Category AS SC, S.Product AS SP, SUM(S.Quantity) AS SQ FROM Sales AS S GROUP BY S.Category, S.Product) AS Sal 
		ON Pro.PC=Sal.SC AND Pro.PP=Sal.SP;

CREATE VIEW [dbo].[StockIn]
AS

SELECT  Purchase.Date AS 'In Date', Purchase.Product  AS 'Code', Product.Name AS 'Name',Category.Name As 'Category' ,Product.ReorderLevel AS 'Reoreder Level',
Purchase.ExpireDate AS 'Expired Date', Purchase.Quantity AS 'In'
FROM Purchase
INNER JOIN Product ON Product.Code = Purchase.Product
INNER JOIn Category ON Category.Code = Purchase.Category
GO
/****** Object:  View [dbo].[StockOut]    Script Date: 11/3/2019 10:48:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[StockOut]
AS

SELECT Sales.Date AS 'Out Date', Product.Name AS 'Name',Category.Name As 'Category' , Sales.Quantity AS 'Out'
FROM Sales
INNER JOIN Product ON Product.Code = Sales.Product
INNER JOIn Category ON Category.Code = Sales.Category

GO
/****** Object:  View [dbo].[StockPeriodical]    Script Date: 11/3/2019 10:48:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[StockPeriodical]
AS
SELECT StockIn.Code AS 'Code', StockIn.Name AS 'Name',StockIn.Category AS 'Category', StockIn.[Reoreder Level] AS 'ReorederLevel',StockIn.[Expired Date] AS 'Expired Date',StockIn.[In Date] AS 'StartDate',
(Available.[Quantity]) As 'Openning Balance',StockIn.[In] As 'In',StockOut.[Out] AS 'Out', ((Available.[Quantity] + StockIn.[In]) -StockOut.[Out]) AS 'Closing Balance', StockOut.[Out Date] AS 'EndDate'
FROM StockIn
INNER JOIN StockOut ON StockIn.Name =StockOut.Name
INNER JOIN Available ON Available.Product = StockIn.Code 

SELECT * FROM StockIn;
SELECT * FROM StockOut;
SELECT * FROM StockPeriodical
SELECT * FROM Available;

DROP VIEW StockPeriodical
GO
/****** Object:  View [dbo].[PurchaseReport]    Script Date: 11/3/2019 10:48:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[PurchaseReport]
As

SELECT MIN(Purchase.InvoiceNo) As 'Code',MIN(Purchase.Date) AS 'Date', Product.Name As 'ProductName', Category.Name As 'CategoryName',SUM( (MRP*Quantity)) As 'TotalMRP',
SUM( (UnitPrice*Quantity)) As 'TotalPrice',SUM( Quantity) As 'Quantity', SUM((MRP*Quantity)-(UnitPrice*Quantity)) AS 'Profit'
FROM Purchase 
LEFT JOIN Product ON Purchase.Product=Product.Code
LEFT JOIN Category ON Purchase.Category=Category.Code

GROUP BY Product.Name, Category.Name;
GO
INSERT [dbo].[Category] ([Code], [Name]) VALUES (N'1001', N'Desktop')
INSERT [dbo].[Category] ([Code], [Name]) VALUES (N'1007', N'Headphone')
INSERT [dbo].[Category] ([Code], [Name]) VALUES (N'1004', N'Keyboard')
INSERT [dbo].[Category] ([Code], [Name]) VALUES (N'1002', N'Laptop')
INSERT [dbo].[Category] ([Code], [Name]) VALUES (N'1000', N'Mobile')
INSERT [dbo].[Category] ([Code], [Name]) VALUES (N'1006', N'Monitor')
INSERT [dbo].[Category] ([Code], [Name]) VALUES (N'1003', N'Motherboard')
INSERT [dbo].[Category] ([Code], [Name]) VALUES (N'1005', N'Soundbox')
INSERT [dbo].[Customer] ([Code], [Name], [Address], [Email], [Contact], [LoyalityPoint]) VALUES (N'1000', N'Kodu Mia', N'Mirpur 12', N'kuddu@yahoo.com', N'01527558885', CAST(22.00 AS Numeric(18, 2)))
INSERT [dbo].[Customer] ([Code], [Name], [Address], [Email], [Contact], [LoyalityPoint]) VALUES (N'1001', N'Kuddus Mia', N'Mirpur 10', N'kuddusmia22@yahoo.com', N'01527555555', CAST(25.00 AS Numeric(18, 2)))
INSERT [dbo].[Customer] ([Code], [Name], [Address], [Email], [Contact], [LoyalityPoint]) VALUES (N'1002', N'Sukkur Mia', N'Azimpur', N'sukkurMiaisBeauty@yahoo.com', N'01527588555', CAST(15.00 AS Numeric(18, 2)))
INSERT [dbo].[Customer] ([Code], [Name], [Address], [Email], [Contact], [LoyalityPoint]) VALUES (N'1003', N'Ful Banu', N'Mirpur 11.5', N'flowerBanu@gmail.com', N'01927555555', CAST(29.00 AS Numeric(18, 2)))
INSERT [dbo].[Customer] ([Code], [Name], [Address], [Email], [Contact], [LoyalityPoint]) VALUES (N'1004', N'Bilkiss', N'Azimpur', N'killbill@yahoo.com', N'01520555555', CAST(120.00 AS Numeric(18, 2)))
INSERT [dbo].[Customer] ([Code], [Name], [Address], [Email], [Contact], [LoyalityPoint]) VALUES (N'1005', N'Jordan', N'Uttara', N'imjordan@gmail.com', N'01527555999', CAST(254.00 AS Numeric(18, 2)))
INSERT [dbo].[Product] ([Code], [Name], [Category], [ReorderLevel], [Description]) VALUES (N'1000', N'Samsung Galaxy Y', N'1000', 100, N'Old is gold')
INSERT [dbo].[Product] ([Code], [Name], [Category], [ReorderLevel], [Description]) VALUES (N'1001', N'Samsung Galaxy S', N'1000', 50, N'New is smart')
INSERT [dbo].[Product] ([Code], [Name], [Category], [ReorderLevel], [Description]) VALUES (N'1002', N'iPhone 8', N'1000', 80, N'Elegant')
INSERT [dbo].[Product] ([Code], [Name], [Category], [ReorderLevel], [Description]) VALUES (N'1003', N'Nokia 800 Tough', N'1000', 200, N'Daddy is back.')
INSERT [dbo].[Product] ([Code], [Name], [Category], [ReorderLevel], [Description]) VALUES (N'1004', N'JBL Everest Elite 750NC', N'1007', 100, N'Take a sound adventure with us')
INSERT [dbo].[Product] ([Code], [Name], [Category], [ReorderLevel], [Description]) VALUES (N'1005', N'Apple iMac 21.5" MMQA2', N'1001', 150, N'It''s Apple!')
SET IDENTITY_INSERT [dbo].[Purchase] ON 

INSERT [dbo].[Purchase] ([PurchaseCode], [InvoiceNo], [Date], [Supplier], [Category], [Product], [ManufactureDate], [ExpireDate], [Quantity], [UnitPrice], [MRP], [Remarks]) VALUES (20190001, N'2929cc', CAST(0xEE3F0B00 AS Date), N'1002', N'1001', N'1005', CAST(0x532B0B00 AS Date), CAST(0x08310B00 AS Date), CAST(250.00 AS Numeric(18, 2)), CAST(70000.00 AS Numeric(18, 2)), CAST(90000.00 AS Numeric(18, 2)), N'Sell kom lav besi.')
INSERT [dbo].[Purchase] ([PurchaseCode], [InvoiceNo], [Date], [Supplier], [Category], [Product], [ManufactureDate], [ExpireDate], [Quantity], [UnitPrice], [MRP], [Remarks]) VALUES (20190002, N'29287pc', CAST(0x0D400B00 AS Date), N'1003', N'1000', N'1000', CAST(0x30240B00 AS Date), CAST(0x042E0B00 AS Date), CAST(500.00 AS Numeric(18, 2)), CAST(7000.00 AS Numeric(18, 2)), CAST(9500.00 AS Numeric(18, 2)), N'Sell besi lav kom.')
INSERT [dbo].[Purchase] ([PurchaseCode], [InvoiceNo], [Date], [Supplier], [Category], [Product], [ManufactureDate], [ExpireDate], [Quantity], [UnitPrice], [MRP], [Remarks]) VALUES (20190003, N'aa29cc', CAST(0x253F0B00 AS Date), N'1001', N'1000', N'1002', CAST(0xE5290B00 AS Date), CAST(0x6B320B00 AS Date), CAST(1050.00 AS Numeric(18, 2)), CAST(25000.00 AS Numeric(18, 2)), CAST(45000.00 AS Numeric(18, 2)), N'Sell kom lav valoi.')
INSERT [dbo].[Purchase] ([PurchaseCode], [InvoiceNo], [Date], [Supplier], [Category], [Product], [ManufactureDate], [ExpireDate], [Quantity], [UnitPrice], [MRP], [Remarks]) VALUES (20190004, N'888829cc', CAST(0xEE3F0B00 AS Date), N'1002', N'1001', N'1005', CAST(0x9E250B00 AS Date), CAST(0x08310B00 AS Date), CAST(250.00 AS Numeric(18, 2)), CAST(70000.00 AS Numeric(18, 2)), CAST(90000.00 AS Numeric(18, 2)), N'Sell kom lav besi.')
INSERT [dbo].[Purchase] ([PurchaseCode], [InvoiceNo], [Date], [Supplier], [Category], [Product], [ManufactureDate], [ExpireDate], [Quantity], [UnitPrice], [MRP], [Remarks]) VALUES (20190005, N'u9l29cc', CAST(0xB13F0B00 AS Date), N'1002', N'1000', N'1003', CAST(0x2D2E0B00 AS Date), CAST(0x08310B00 AS Date), CAST(1.00 AS Numeric(18, 2)), CAST(70000.00 AS Numeric(18, 2)), CAST(90000.00 AS Numeric(18, 2)), N'Sell kom lav besi.')
SET IDENTITY_INSERT [dbo].[Purchase] OFF
SET IDENTITY_INSERT [dbo].[Sales] ON 

INSERT [dbo].[Sales] ([SalesCode], [Date], [Customer], [Category], [Product], [Quantity], [MRP]) VALUES (20190001, CAST(0xAD230B00 AS Date), N'1000', N'1001', N'1000', CAST(15.00 AS Numeric(18, 2)), CAST(200.00 AS Numeric(18, 2)))
INSERT [dbo].[Sales] ([SalesCode], [Date], [Customer], [Category], [Product], [Quantity], [MRP]) VALUES (20190002, CAST(0x79400B00 AS Date), N'1000', N'1003', N'1004', CAST(2.00 AS Numeric(18, 2)), CAST(200.00 AS Numeric(18, 2)))
INSERT [dbo].[Sales] ([SalesCode], [Date], [Customer], [Category], [Product], [Quantity], [MRP]) VALUES (20190003, CAST(0xF93F0B00 AS Date), N'1003', N'1000', N'1002', CAST(3.00 AS Numeric(18, 2)), CAST(200.00 AS Numeric(18, 2)))
INSERT [dbo].[Sales] ([SalesCode], [Date], [Customer], [Category], [Product], [Quantity], [MRP]) VALUES (20190004, CAST(0xE43F0B00 AS Date), N'1004', N'1000', N'1003', CAST(1.00 AS Numeric(18, 2)), CAST(300.00 AS Numeric(18, 2)))
INSERT [dbo].[Sales] ([SalesCode], [Date], [Customer], [Category], [Product], [Quantity], [MRP]) VALUES (20190005, CAST(0xEE3F0B00 AS Date), N'1001', N'1003', N'1004', CAST(1.00 AS Numeric(18, 2)), CAST(100.00 AS Numeric(18, 2)))
INSERT [dbo].[Sales] ([SalesCode], [Date], [Customer], [Category], [Product], [Quantity], [MRP]) VALUES (20190006, CAST(0xEE3F0B00 AS Date), N'1001', N'1001', N'1003', CAST(18.00 AS Numeric(18, 2)), CAST(20.00 AS Numeric(18, 2)))
SET IDENTITY_INSERT [dbo].[Sales] OFF
INSERT [dbo].[Supplier] ([Code], [Name], [Address], [Email], [Contact], [ContactPerson]) VALUES (N'1001', N'OK Mobile Bangladesh Limited', N'Mirpur 10', N'kuddusmia22@yahoo.com', N'01527555555', N'01527578555')
INSERT [dbo].[Supplier] ([Code], [Name], [Address], [Email], [Contact], [ContactPerson]) VALUES (N'1002', N'Famous BD', N'Bonani', N'korim@yahoo.com', N'01527478555', N'01527008555')
INSERT [dbo].[Supplier] ([Code], [Name], [Address], [Email], [Contact], [ContactPerson]) VALUES (N'1003', N'Nasrin TElecom', N'Dhanmondi 27', N'nasrimabcd@gmail.com', N'01527478885', N'01830422618')
INSERT [dbo].[Supplier] ([Code], [Name], [Address], [Email], [Contact], [ContactPerson]) VALUES (N'1004', N'Best Electronics', N'Mirpur 10', N'be@yahoo.com', N'01527555874', N'01527578545')
INSERT [dbo].[Supplier] ([Code], [Name], [Address], [Email], [Contact], [ContactPerson]) VALUES (N'1005', N'Samsung BD', N'Mirpur 10', N'samsam@gamil.com', N'01527559999', N'01527578999')
INSERT [dbo].[Supplier] ([Code], [Name], [Address], [Email], [Contact], [ContactPerson]) VALUES (N'1007', N'Ok Mobile Banglagesh', N'fvbadf', N'fvfadafh', N'7654145', N'weeew')
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ__Category__737584F693638789]    Script Date: 11/3/2019 10:48:11 AM ******/
ALTER TABLE [dbo].[Category] ADD UNIQUE NONCLUSTERED 
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ__Customer__A9D105345672C9D0]    Script Date: 11/3/2019 10:48:11 AM ******/
ALTER TABLE [dbo].[Customer] ADD UNIQUE NONCLUSTERED 
(
	[Email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ__Customer__F7C04665151D8BF5]    Script Date: 11/3/2019 10:48:11 AM ******/
ALTER TABLE [dbo].[Customer] ADD UNIQUE NONCLUSTERED 
(
	[Contact] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ__Product__737584F64F74303F]    Script Date: 11/3/2019 10:48:11 AM ******/
ALTER TABLE [dbo].[Product] ADD UNIQUE NONCLUSTERED 
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ__Purchase__D796B2270501E5D3]    Script Date: 11/3/2019 10:48:11 AM ******/
ALTER TABLE [dbo].[Purchase] ADD UNIQUE NONCLUSTERED 
(
	[InvoiceNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ__Supplier__737584F6A0FD67CC]    Script Date: 11/3/2019 10:48:11 AM ******/
ALTER TABLE [dbo].[Supplier] ADD UNIQUE NONCLUSTERED 
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ__Supplier__A9D10534F6C24B84]    Script Date: 11/3/2019 10:48:11 AM ******/
ALTER TABLE [dbo].[Supplier] ADD UNIQUE NONCLUSTERED 
(
	[Email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ__Supplier__F7C04665A2D3A885]    Script Date: 11/3/2019 10:48:11 AM ******/
ALTER TABLE [dbo].[Supplier] ADD UNIQUE NONCLUSTERED 
(
	[Contact] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK_Category] FOREIGN KEY([Category])
REFERENCES [dbo].[Category] ([Code])
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK_Category]
GO
ALTER TABLE [dbo].[Purchase]  WITH CHECK ADD  CONSTRAINT [FK_CategoryP] FOREIGN KEY([Category])
REFERENCES [dbo].[Category] ([Code])
GO
ALTER TABLE [dbo].[Purchase] CHECK CONSTRAINT [FK_CategoryP]
GO
ALTER TABLE [dbo].[Purchase]  WITH CHECK ADD  CONSTRAINT [FK_ProductP] FOREIGN KEY([Product])
REFERENCES [dbo].[Product] ([Code])
GO
ALTER TABLE [dbo].[Purchase] CHECK CONSTRAINT [FK_ProductP]
GO
ALTER TABLE [dbo].[Purchase]  WITH CHECK ADD  CONSTRAINT [FK_SupplierP] FOREIGN KEY([Supplier])
REFERENCES [dbo].[Supplier] ([Code])
GO
ALTER TABLE [dbo].[Purchase] CHECK CONSTRAINT [FK_SupplierP]
GO
ALTER TABLE [dbo].[Sales]  WITH CHECK ADD  CONSTRAINT [FK_CategoryS] FOREIGN KEY([Category])
REFERENCES [dbo].[Category] ([Code])
GO
ALTER TABLE [dbo].[Sales] CHECK CONSTRAINT [FK_CategoryS]
GO
ALTER TABLE [dbo].[Sales]  WITH CHECK ADD  CONSTRAINT [FK_CustomerS] FOREIGN KEY([Customer])
REFERENCES [dbo].[Customer] ([Code])
GO
ALTER TABLE [dbo].[Sales] CHECK CONSTRAINT [FK_CustomerS]
GO
ALTER TABLE [dbo].[Sales]  WITH CHECK ADD  CONSTRAINT [FK_ProductS] FOREIGN KEY([Product])
REFERENCES [dbo].[Product] ([Code])
GO
ALTER TABLE [dbo].[Sales] CHECK CONSTRAINT [FK_ProductS]
GO
