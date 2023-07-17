CREATE DATABASE [ProductOrder]
GO

USE [ProductOrder]
GO
/****** Object: Table [dbo].[Invoice] Script Date: 07/04/2020 23:13:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Invoice](
[InvoiceNo] [nvarchar](20) NOT NULL,
[OrderDate] [datetime] NOT NULL,
[DeliveryDate] [datetime] NOT NULL,
[Note] [nvarchar](255) NULL,
CONSTRAINT [PK_Invoice] PRIMARY KEY CLUSTERED
(
[InvoiceNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF,
ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object: Table [dbo].[Product] Script Date: 07/04/2020 23:13:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
[ProductID] [nvarchar](20) NOT NULL,
[ProductName] [nvarchar](100) NOT NULL,
[Unit] [nvarchar](20) NOT NULL,
[BuyPrice] [decimal](18, 0) NULL,
[SellPrice] [decimal](18, 0) NULL,
CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED
(
[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF,
ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object: Table [dbo].[Order] Script Date: 07/04/2020 23:13:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Order](
[InvoiceNo] [nvarchar](20) NOT NULL,
[No] [int] NOT NULL,
[ProductID] [nvarchar](20) NOT NULL,
[ProductName] [nvarchar](100) NULL,
[Unit] [nvarchar](20) NULL,
[Price] [decimal](18, 0) NOT NULL,
[Quantity] [int] NOT NULL,
CONSTRAINT [PK_Order] PRIMARY KEY CLUSTERED
(
[InvoiceNo] ASC,
[No] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF,
ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object: ForeignKey [FK_Order_Invoice] Script Date: 07/04/2020 23:13:15
******/
ALTER TABLE [dbo].[Order] WITH CHECK ADD CONSTRAINT [FK_Order_Invoice] FOREIGN
KEY([InvoiceNo])
REFERENCES [dbo].[Invoice] ([InvoiceNo])
GO
ALTER TABLE [dbo].[Order] CHECK CONSTRAINT [FK_Order_Invoice]
GO
/****** Object: ForeignKey [FK_Order_Product] Script Date: 07/04/2020 23:13:15
******/
ALTER TABLE [dbo].[Order] WITH CHECK ADD CONSTRAINT [FK_Order_Product] FOREIGN
KEY([ProductID])
REFERENCES [dbo].[Product] ([ProductID])
GO
ALTER TABLE [dbo].[Order] CHECK CONSTRAINT [FK_Order_Product]
GO
USE [ProductOrder]
GO
/****** Object: Table [dbo].[Invoice] Script Date: 07/04/2020 23:14:16 ******/
INSERT [dbo].[Invoice] ([InvoiceNo], [OrderDate], [DeliveryDate], [Note]) VALUES
(N'HDX001', CAST(0x0000AAD900000000 AS DateTime), CAST(0x0000AADA00000000 AS
DateTime),N'GIAO HÀNG TRƯỚC 9H' )
INSERT [dbo].[Invoice] ([InvoiceNo], [OrderDate], [DeliveryDate], [Note]) VALUES
(N'HDX002', CAST(0x0000AADA00000000 AS DateTime), CAST(0x0000AADA00000000 AS
DateTime),N'GỌI ĐIỆN TRƯỚC KHI GIAO' )

INSERT [dbo].[Invoice] ([InvoiceNo], [OrderDate], [DeliveryDate], [Note]) VALUES
(N'HDX003', CAST(0x0000AADA00000000 AS DateTime), CAST(0x0000AADC00000000 AS
DateTime), N'giao tu 1-3h')

/****** Object: Table [dbo].[Product] Script Date: 07/04/2020 23:14:16 ******/
INSERT [dbo].[Product] ([ProductID], [ProductName], [Unit], [BuyPrice],
[SellPrice]) VALUES (N'Product1',N'SẢN PHẨM 1' , N'Cái', CAST(100000 AS Decimal(18,
0)), CAST(120000 AS Decimal(18, 0)))
INSERT [dbo].[Product] ([ProductID], [ProductName], [Unit], [BuyPrice],
[SellPrice]) VALUES (N'Product2', N'SẢN PHẨM 2', N'Cái', CAST(90000 AS Decimal(18,
0)), CAST(120000 AS Decimal(18, 0)))
INSERT [dbo].[Product] ([ProductID], [ProductName], [Unit], [BuyPrice],
[SellPrice]) VALUES (N'Product3',N'SẢN PHẨM 3' , N'Cái', CAST(40000 AS Decimal(18,
0)), CAST(70000 AS Decimal(18, 0)))
INSERT [dbo].[Product] ([ProductID], [ProductName], [Unit], [BuyPrice],
[SellPrice]) VALUES (N'Product4',N'SẢN PHẨM 4' ,N'Hộp' , CAST(200000 AS Decimal(18,
0)), CAST(300000 AS Decimal(18, 0)))
/****** Object: Table [dbo].[Order] Script Date: 07/04/2020 23:14:16 ******/
INSERT [dbo].[Order] ([InvoiceNo], [No], [ProductID], [ProductName], [Unit],
[Price], [Quantity]) VALUES (N'HDX001', 1, N'Product1',N'Sản phẩm 1' , N'Cái',
CAST(120000 AS Decimal(18, 0)), 20)
INSERT [dbo].[Order] ([InvoiceNo], [No], [ProductID], [ProductName], [Unit],
[Price], [Quantity]) VALUES (N'HDX001', 2, N'Product2',N'Sản phẩm 2' , N'Cái',
CAST(120000 AS Decimal(18, 0)), 4)
INSERT [dbo].[Order] ([InvoiceNo], [No], [ProductID], [ProductName], [Unit],
[Price], [Quantity]) VALUES (N'HDX001', 3, N'Product4',N'Sản phẩm 4' , N'Hộp',
CAST(300000 AS Decimal(18, 0)), 10)
INSERT [dbo].[Order] ([InvoiceNo], [No], [ProductID], [ProductName], [Unit],
[Price], [Quantity]) VALUES (N'HDX002', 1, N'Product4',N'Sản phẩm 1' ,N'Hộp' ,
CAST(300000 AS Decimal(18, 0)), 10)
INSERT [dbo].[Order] ([InvoiceNo], [No], [ProductID], [ProductName], [Unit],
[Price], [Quantity]) VALUES (N'HDX002', 2, N'Product2',N'Sản phẩm 3' , N'Cái',
CAST(300000 AS Decimal(18, 0)), 12)
INSERT [dbo].[Order] ([InvoiceNo], [No], [ProductID], [ProductName], [Unit],
[Price], [Quantity]) VALUES (N'HDX003', 1, N'Product1',N'Sản phẩm 1' , N'Cái',
CAST(120000 AS Decimal(18, 0)), 40)
INSERT [dbo].[Order] ([InvoiceNo], [No], [ProductID], [ProductName], [Unit],
[Price], [Quantity]) VALUES (N'HDX003', 4, N'Product2',N'Sản phẩm 2' , N'Cái',
CAST(120000 AS Decimal(18, 0)), 60)


alter PROC GetOrderData (@NgayDat DATE, @NgayGiao DATE)
AS
	BEGIN
		SELECT I.InvoiceNo AS[SOHD] , OrderDate AS [NGAYDAT]  , DeliveryDate AS [NGAYGIAO] , SUM(Price*Quantity) AS [THANHTIEN]
		FROM Invoice I , [Order] O
		WHERE OrderDate >= @NgayDat AND DeliveryDate <= @NgayGiao AND I.InvoiceNo = O.InvoiceNo
		GROUP BY I.InvoiceNo,OrderDate,DeliveryDate
	END
GO


EXEC GetOrderData '2019-10-01' , '2019-10-02'


CREATE PROC GETALLDATA
AS
	BEGIN
		SELECT I.InvoiceNo AS[SOHD] , OrderDate AS [NGAYDAT]  , DeliveryDate AS [NGAYGIAO] , SUM(Price*Quantity) AS [THANHTIEN]
		FROM Invoice I , [Order] O
		WHERE  I.InvoiceNo = O.InvoiceNo
		GROUP BY I.InvoiceNo,OrderDate,DeliveryDate
	END

EXEC GETALLDATA


		SELECT I.InvoiceNo AS[SOHD] , OrderDate AS [NGAYDAT]  , DeliveryDate AS [NGAYGIAO] , SUM(Price*Quantity) AS [THANHTIEN]
		FROM Invoice I , [Order] O
		WHERE OrderDate >= '2019-10-01' AND DeliveryDate <= '2019-10-02' AND I.InvoiceNo = O.InvoiceNo
		GROUP BY I.InvoiceNo,OrderDate,DeliveryDate




















