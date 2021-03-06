USE [Clothes]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 11/1/2020 5:10:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](30) NOT NULL,
 CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Color]    Script Date: 11/1/2020 5:10:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Color](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](30) NOT NULL,
 CONSTRAINT [PK_Color] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 11/1/2020 5:10:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[ID] [varchar](6) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[PhoneNumber] [varchar](15) NOT NULL,
	[Address] [nvarchar](200) NOT NULL,
 CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 11/1/2020 5:10:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee](
	[ID] [varchar](6) NOT NULL,
	[Name] [nvarchar](120) NOT NULL,
	[Sex] [char](1) NOT NULL,
	[DateOfBirth] [date] NOT NULL,
	[PhoneNumber] [varchar](15) NOT NULL,
	[Address] [nvarchar](100) NOT NULL,
	[RoleID] [int] NOT NULL,
 CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EntryDetails]    Script Date: 11/1/2020 5:10:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EntryDetails](
	[EntryID] [varchar](7) NOT NULL,
	[ProductID] [varchar](6) NOT NULL,
	[Quantity] [int] NOT NULL,
	[UnitPrice] [money] NOT NULL,
	[Discount] [float] NOT NULL,
	[Total] [money] NOT NULL,
 CONSTRAINT [PK_EntryDetails] PRIMARY KEY CLUSTERED 
(
	[EntryID] ASC,
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EntryInvoice]    Script Date: 11/1/2020 5:10:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EntryInvoice](
	[ID] [varchar](7) NOT NULL,
	[EmployeeID] [varchar](6) NOT NULL,
	[SupplierID] [varchar](7) NOT NULL,
	[DayEntry] [datetime] NOT NULL,
	[Total] [money] NOT NULL,
 CONSTRAINT [PK_EntryInvoice] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Manufactured]    Script Date: 11/1/2020 5:10:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Manufactured](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](200) NOT NULL,
 CONSTRAINT [PK_Manufactured] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Object]    Script Date: 11/1/2020 5:10:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Object](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](30) NOT NULL,
 CONSTRAINT [PK_Object] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 11/1/2020 5:10:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[ID] [varchar](6) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[CategoryID] [int] NOT NULL,
	[SizeID] [int] NOT NULL,
	[RawMaterial_ID] [int] NOT NULL,
	[ColorID] [int] NOT NULL,
	[ObjectID] [int] NOT NULL,
	[SeasonID] [int] NOT NULL,
	[ManufacturedID] [int] NOT NULL,
	[Quantity] [int] NOT NULL,
	[Picture] [nvarchar](100) NULL,
	[PriceEntry] [money] NOT NULL,
	[PriceSell] [money] NOT NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RawMaterial]    Script Date: 11/1/2020 5:10:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RawMaterial](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_RawMaterial] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Role]    Script Date: 11/1/2020 5:10:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Role](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Role] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SaleDetails]    Script Date: 11/1/2020 5:10:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SaleDetails](
	[SaleID] [varchar](7) NOT NULL,
	[ProductID] [varchar](6) NOT NULL,
	[Quantity] [int] NOT NULL,
	[Discount] [float] NOT NULL,
	[Total] [money] NOT NULL,
 CONSTRAINT [PK_SaleDetails] PRIMARY KEY CLUSTERED 
(
	[SaleID] ASC,
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SaleInvoice]    Script Date: 11/1/2020 5:10:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SaleInvoice](
	[ID] [varchar](7) NOT NULL,
	[EmployeeID] [varchar](6) NOT NULL,
	[CustomerID] [varchar](6) NOT NULL,
	[Day] [datetime] NOT NULL,
	[Total] [money] NOT NULL,
 CONSTRAINT [PK_SaleInvoice] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Season]    Script Date: 11/1/2020 5:10:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Season](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](30) NOT NULL,
 CONSTRAINT [PK_Season] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Size]    Script Date: 11/1/2020 5:10:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Size](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Size] [nvarchar](30) NOT NULL,
 CONSTRAINT [PK_Size] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Supplier]    Script Date: 11/1/2020 5:10:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Supplier](
	[ID] [varchar](7) NOT NULL,
	[Name] [nvarchar](200) NOT NULL,
	[Address] [nvarchar](200) NOT NULL,
	[PhoneNumber] [varchar](15) NOT NULL,
 CONSTRAINT [PK_Supplier] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Category] ON 

INSERT [dbo].[Category] ([ID], [Name]) VALUES (2, N'áo')
INSERT [dbo].[Category] ([ID], [Name]) VALUES (3, N'áo dài')
INSERT [dbo].[Category] ([ID], [Name]) VALUES (4, N'Quần')
INSERT [dbo].[Category] ([ID], [Name]) VALUES (5, N'áo thun')
INSERT [dbo].[Category] ([ID], [Name]) VALUES (6, N'Quần rách')
SET IDENTITY_INSERT [dbo].[Category] OFF
GO
SET IDENTITY_INSERT [dbo].[Color] ON 

INSERT [dbo].[Color] ([ID], [Name]) VALUES (1, N'đỏ')
INSERT [dbo].[Color] ([ID], [Name]) VALUES (2, N'đen')
INSERT [dbo].[Color] ([ID], [Name]) VALUES (3, N'Tím')
SET IDENTITY_INSERT [dbo].[Color] OFF
GO
INSERT [dbo].[Customer] ([ID], [Name], [PhoneNumber], [Address]) VALUES (N'KH0001', N'Nguyễn Hữu Thảo hảo hảo', N'03345698711', N'ha noi nhe ban ..................................................................................................................................................................
')
INSERT [dbo].[Customer] ([ID], [Name], [PhoneNumber], [Address]) VALUES (N'KH0002', N'Thảo', N'0123456789', N'Hà nội')
INSERT [dbo].[Customer] ([ID], [Name], [PhoneNumber], [Address]) VALUES (N'KH0003', N'Mr tramkam lắm rồi', N'03266546966', N'Hanoi')
GO
INSERT [dbo].[Employee] ([ID], [Name], [Sex], [DateOfBirth], [PhoneNumber], [Address], [RoleID]) VALUES (N'NV0001', N'Nguyen Thao', N'M', CAST(N'2000-01-19' AS Date), N'0396524860', N'Ha noi', 1)
INSERT [dbo].[Employee] ([ID], [Name], [Sex], [DateOfBirth], [PhoneNumber], [Address], [RoleID]) VALUES (N'NV0002', N'Jane', N'M', CAST(N'2000-11-01' AS Date), N'03365211445', N'Hà nội', 4)
GO
INSERT [dbo].[EntryDetails] ([EntryID], [ProductID], [Quantity], [UnitPrice], [Discount], [Total]) VALUES (N'HDN0006', N'SP0001', 4, 4.0000, 0, 16.0000)
INSERT [dbo].[EntryDetails] ([EntryID], [ProductID], [Quantity], [UnitPrice], [Discount], [Total]) VALUES (N'HDN0007', N'SP0004', 2, 45000.0000, 0, 90000.0000)
INSERT [dbo].[EntryDetails] ([EntryID], [ProductID], [Quantity], [UnitPrice], [Discount], [Total]) VALUES (N'HDN0008', N'SP0002', 1, 213.0000, 0, 17989.0000)
INSERT [dbo].[EntryDetails] ([EntryID], [ProductID], [Quantity], [UnitPrice], [Discount], [Total]) VALUES (N'HDN0009', N'SP0002', 1, 1.0000, 0, 1.0000)
INSERT [dbo].[EntryDetails] ([EntryID], [ProductID], [Quantity], [UnitPrice], [Discount], [Total]) VALUES (N'HDN0010', N'SP0001', 1, 222.0000, 0, 222.0000)
INSERT [dbo].[EntryDetails] ([EntryID], [ProductID], [Quantity], [UnitPrice], [Discount], [Total]) VALUES (N'HDN0011', N'SP0002', 1, 111.0000, 0, 111.0000)
INSERT [dbo].[EntryDetails] ([EntryID], [ProductID], [Quantity], [UnitPrice], [Discount], [Total]) VALUES (N'HDN0011', N'SP0004', 5, 444444.0000, 0.05000000074505806, 2222220.0000)
INSERT [dbo].[EntryDetails] ([EntryID], [ProductID], [Quantity], [UnitPrice], [Discount], [Total]) VALUES (N'HDN0012', N'SP0002', 2, 5.0000, 0, 10.0000)
INSERT [dbo].[EntryDetails] ([EntryID], [ProductID], [Quantity], [UnitPrice], [Discount], [Total]) VALUES (N'HDN0013', N'SP0002', 2, 33333.0000, 0, 66666.0000)
INSERT [dbo].[EntryDetails] ([EntryID], [ProductID], [Quantity], [UnitPrice], [Discount], [Total]) VALUES (N'HDN0014', N'SP0001', 7, 55555.0000, 0, 388885.0000)
INSERT [dbo].[EntryDetails] ([EntryID], [ProductID], [Quantity], [UnitPrice], [Discount], [Total]) VALUES (N'HDN0014', N'SP0004', 6, 7555.0000, 0, 45330.0000)
INSERT [dbo].[EntryDetails] ([EntryID], [ProductID], [Quantity], [UnitPrice], [Discount], [Total]) VALUES (N'HDN0015', N'SP0005', 2, 150000.0000, 0, 300000.0000)
INSERT [dbo].[EntryDetails] ([EntryID], [ProductID], [Quantity], [UnitPrice], [Discount], [Total]) VALUES (N'HDN0016', N'SP0004', 5, 66666.0000, 0, 333330.0000)
INSERT [dbo].[EntryDetails] ([EntryID], [ProductID], [Quantity], [UnitPrice], [Discount], [Total]) VALUES (N'HDN0016', N'SP0005', 2, 22222.0000, 0, 44444.0000)
INSERT [dbo].[EntryDetails] ([EntryID], [ProductID], [Quantity], [UnitPrice], [Discount], [Total]) VALUES (N'HDN0016', N'SP0006', 2, 4.0000, 0, 8.0000)
INSERT [dbo].[EntryDetails] ([EntryID], [ProductID], [Quantity], [UnitPrice], [Discount], [Total]) VALUES (N'HDN0017', N'SP0002', 4, 555.0000, 0, 2220.0000)
INSERT [dbo].[EntryDetails] ([EntryID], [ProductID], [Quantity], [UnitPrice], [Discount], [Total]) VALUES (N'HDN0018', N'SP0002', 1, 111.0000, 0, 111.0000)
INSERT [dbo].[EntryDetails] ([EntryID], [ProductID], [Quantity], [UnitPrice], [Discount], [Total]) VALUES (N'HDN0019', N'SP0001', 7777, 888.0000, 0, 6905976.0000)
INSERT [dbo].[EntryDetails] ([EntryID], [ProductID], [Quantity], [UnitPrice], [Discount], [Total]) VALUES (N'HDN0019', N'SP0002', 3, 222.0000, 0, 666.0000)
INSERT [dbo].[EntryDetails] ([EntryID], [ProductID], [Quantity], [UnitPrice], [Discount], [Total]) VALUES (N'HDN0019', N'SP0003', 5555, 66.0000, 0, 366630.0000)
INSERT [dbo].[EntryDetails] ([EntryID], [ProductID], [Quantity], [UnitPrice], [Discount], [Total]) VALUES (N'HDN0019', N'SP0004', 9999, 555.0000, 0, 5549445.0000)
INSERT [dbo].[EntryDetails] ([EntryID], [ProductID], [Quantity], [UnitPrice], [Discount], [Total]) VALUES (N'HDN0019', N'SP0005', 8, 888888.0000, 0, 7111104.0000)
INSERT [dbo].[EntryDetails] ([EntryID], [ProductID], [Quantity], [UnitPrice], [Discount], [Total]) VALUES (N'HDN0019', N'SP0006', 888, 666.0000, 0, 591408.0000)
INSERT [dbo].[EntryDetails] ([EntryID], [ProductID], [Quantity], [UnitPrice], [Discount], [Total]) VALUES (N'HDN0020', N'SP0003', 8, 8.0000, 0, 64.0000)
INSERT [dbo].[EntryDetails] ([EntryID], [ProductID], [Quantity], [UnitPrice], [Discount], [Total]) VALUES (N'HDN0021', N'SP0001', 8, 5555.0000, 0, 44440.0000)
INSERT [dbo].[EntryDetails] ([EntryID], [ProductID], [Quantity], [UnitPrice], [Discount], [Total]) VALUES (N'HDN0022', N'SP0004', 2, 222.0000, 0, 444.0000)
INSERT [dbo].[EntryDetails] ([EntryID], [ProductID], [Quantity], [UnitPrice], [Discount], [Total]) VALUES (N'HDN0023', N'SP0002', 5, 666.0000, 0, 3330.0000)
GO
INSERT [dbo].[EntryInvoice] ([ID], [EmployeeID], [SupplierID], [DayEntry], [Total]) VALUES (N'HDN0001', N'NV0002', N'NCC0001', CAST(N'2020-10-22T00:00:00.000' AS DateTime), 122000.0000)
INSERT [dbo].[EntryInvoice] ([ID], [EmployeeID], [SupplierID], [DayEntry], [Total]) VALUES (N'HDN0002', N'NV0001', N'NCC0001', CAST(N'2020-10-22T00:00:00.000' AS DateTime), 12000.0000)
INSERT [dbo].[EntryInvoice] ([ID], [EmployeeID], [SupplierID], [DayEntry], [Total]) VALUES (N'HDN0003', N'NV0001', N'NCC0001', CAST(N'2020-10-22T00:00:00.000' AS DateTime), 12.0000)
INSERT [dbo].[EntryInvoice] ([ID], [EmployeeID], [SupplierID], [DayEntry], [Total]) VALUES (N'HDN0004', N'NV0002', N'NCC0001', CAST(N'2020-10-22T00:00:00.000' AS DateTime), 2.0000)
INSERT [dbo].[EntryInvoice] ([ID], [EmployeeID], [SupplierID], [DayEntry], [Total]) VALUES (N'HDN0005', N'NV0001', N'NCC0002', CAST(N'2020-10-22T00:00:00.000' AS DateTime), 666.0000)
INSERT [dbo].[EntryInvoice] ([ID], [EmployeeID], [SupplierID], [DayEntry], [Total]) VALUES (N'HDN0006', N'NV0001', N'NCC0001', CAST(N'2020-10-22T00:00:00.000' AS DateTime), 16.0000)
INSERT [dbo].[EntryInvoice] ([ID], [EmployeeID], [SupplierID], [DayEntry], [Total]) VALUES (N'HDN0007', N'NV0001', N'NCC0001', CAST(N'2020-10-22T00:00:00.000' AS DateTime), 90000.0000)
INSERT [dbo].[EntryInvoice] ([ID], [EmployeeID], [SupplierID], [DayEntry], [Total]) VALUES (N'HDN0008', N'NV0002', N'NCC0002', CAST(N'2020-10-22T00:00:00.000' AS DateTime), 17989.0000)
INSERT [dbo].[EntryInvoice] ([ID], [EmployeeID], [SupplierID], [DayEntry], [Total]) VALUES (N'HDN0009', N'NV0001', N'NCC0002', CAST(N'2020-10-22T00:00:00.000' AS DateTime), 1.0000)
INSERT [dbo].[EntryInvoice] ([ID], [EmployeeID], [SupplierID], [DayEntry], [Total]) VALUES (N'HDN0010', N'NV0001', N'NCC0002', CAST(N'2020-10-23T00:00:00.000' AS DateTime), 222.0000)
INSERT [dbo].[EntryInvoice] ([ID], [EmployeeID], [SupplierID], [DayEntry], [Total]) VALUES (N'HDN0011', N'NV0001', N'NCC0002', CAST(N'2020-10-23T00:00:00.000' AS DateTime), 2222331.0000)
INSERT [dbo].[EntryInvoice] ([ID], [EmployeeID], [SupplierID], [DayEntry], [Total]) VALUES (N'HDN0012', N'NV0001', N'NCC0002', CAST(N'2020-10-24T00:00:00.000' AS DateTime), 10.0000)
INSERT [dbo].[EntryInvoice] ([ID], [EmployeeID], [SupplierID], [DayEntry], [Total]) VALUES (N'HDN0013', N'NV0001', N'NCC0002', CAST(N'2020-10-24T04:05:00.000' AS DateTime), 66666.0000)
INSERT [dbo].[EntryInvoice] ([ID], [EmployeeID], [SupplierID], [DayEntry], [Total]) VALUES (N'HDN0014', N'NV0001', N'NCC0001', CAST(N'2020-10-24T00:00:00.000' AS DateTime), 434215.0000)
INSERT [dbo].[EntryInvoice] ([ID], [EmployeeID], [SupplierID], [DayEntry], [Total]) VALUES (N'HDN0015', N'NV0001', N'NCC0002', CAST(N'2020-10-24T00:00:00.000' AS DateTime), 300000.0000)
INSERT [dbo].[EntryInvoice] ([ID], [EmployeeID], [SupplierID], [DayEntry], [Total]) VALUES (N'HDN0016', N'NV0001', N'NCC0002', CAST(N'2020-10-27T00:00:00.000' AS DateTime), 377782.0000)
INSERT [dbo].[EntryInvoice] ([ID], [EmployeeID], [SupplierID], [DayEntry], [Total]) VALUES (N'HDN0017', N'NV0001', N'NCC0002', CAST(N'2020-10-27T00:00:00.000' AS DateTime), 2220.0000)
INSERT [dbo].[EntryInvoice] ([ID], [EmployeeID], [SupplierID], [DayEntry], [Total]) VALUES (N'HDN0018', N'NV0001', N'NCC0001', CAST(N'2020-10-27T00:00:00.000' AS DateTime), 111.0000)
INSERT [dbo].[EntryInvoice] ([ID], [EmployeeID], [SupplierID], [DayEntry], [Total]) VALUES (N'HDN0019', N'NV0001', N'NCC0003', CAST(N'2020-10-27T00:00:00.000' AS DateTime), 20525229.0000)
INSERT [dbo].[EntryInvoice] ([ID], [EmployeeID], [SupplierID], [DayEntry], [Total]) VALUES (N'HDN0020', N'NV0001', N'NCC0003', CAST(N'2020-10-27T00:00:00.000' AS DateTime), 64.0000)
INSERT [dbo].[EntryInvoice] ([ID], [EmployeeID], [SupplierID], [DayEntry], [Total]) VALUES (N'HDN0021', N'NV0001', N'NCC0001', CAST(N'2020-10-27T00:00:00.000' AS DateTime), 44440.0000)
INSERT [dbo].[EntryInvoice] ([ID], [EmployeeID], [SupplierID], [DayEntry], [Total]) VALUES (N'HDN0022', N'NV0001', N'NCC0003', CAST(N'2020-10-27T00:00:00.000' AS DateTime), 444.0000)
INSERT [dbo].[EntryInvoice] ([ID], [EmployeeID], [SupplierID], [DayEntry], [Total]) VALUES (N'HDN0023', N'NV0001', N'NCC0002', CAST(N'2020-10-27T00:00:00.000' AS DateTime), 3330.0000)
GO
SET IDENTITY_INSERT [dbo].[Manufactured] ON 

INSERT [dbo].[Manufactured] ([ID], [Name]) VALUES (2, N'Thảo production')
INSERT [dbo].[Manufactured] ([ID], [Name]) VALUES (1003, N'Nguyễn cơ sở 2')
INSERT [dbo].[Manufactured] ([ID], [Name]) VALUES (2003, N'Fashionista Thảo')
INSERT [dbo].[Manufactured] ([ID], [Name]) VALUES (2004, N'Thảo đẹp trai')
SET IDENTITY_INSERT [dbo].[Manufactured] OFF
GO
SET IDENTITY_INSERT [dbo].[Object] ON 

INSERT [dbo].[Object] ([ID], [Name]) VALUES (1, N'Nam')
INSERT [dbo].[Object] ([ID], [Name]) VALUES (2, N'Nữ')
INSERT [dbo].[Object] ([ID], [Name]) VALUES (1002, N'Người già')
INSERT [dbo].[Object] ([ID], [Name]) VALUES (1003, N'sugar daddy')
SET IDENTITY_INSERT [dbo].[Object] OFF
GO
INSERT [dbo].[Product] ([ID], [Name], [CategoryID], [SizeID], [RawMaterial_ID], [ColorID], [ObjectID], [SeasonID], [ManufacturedID], [Quantity], [Picture], [PriceEntry], [PriceSell]) VALUES (N'SP0001', N'Áo sơ mi', 2, 2, 1, 1, 1, 1, 2, 7798, N'Khong co anh', 5555.0000, 6110.5000)
INSERT [dbo].[Product] ([ID], [Name], [CategoryID], [SizeID], [RawMaterial_ID], [ColorID], [ObjectID], [SeasonID], [ManufacturedID], [Quantity], [Picture], [PriceEntry], [PriceSell]) VALUES (N'SP0002', N'Quần đùi 7 màu', 4, 2, 2, 2, 1, 2, 1003, 25, N'Khong co anh', 666.0000, 732.6000)
INSERT [dbo].[Product] ([ID], [Name], [CategoryID], [SizeID], [RawMaterial_ID], [ColorID], [ObjectID], [SeasonID], [ManufacturedID], [Quantity], [Picture], [PriceEntry], [PriceSell]) VALUES (N'SP0003', N'Quần 7 màu', 4, 2, 2, 2, 2, 2, 1003, 5568, N'Khong co anh', 8.0000, 8.8000)
INSERT [dbo].[Product] ([ID], [Name], [CategoryID], [SizeID], [RawMaterial_ID], [ColorID], [ObjectID], [SeasonID], [ManufacturedID], [Quantity], [Picture], [PriceEntry], [PriceSell]) VALUES (N'SP0004', N'Hoodie trùm đầu', 2, 1002, 3, 3, 1002, 1002, 2003, 10020, N'Khong co anh', 222.0000, 244.2000)
INSERT [dbo].[Product] ([ID], [Name], [CategoryID], [SizeID], [RawMaterial_ID], [ColorID], [ObjectID], [SeasonID], [ManufacturedID], [Quantity], [Picture], [PriceEntry], [PriceSell]) VALUES (N'SP0005', N'bsduahdas', 4, 2, 2, 1, 1003, 2, 2004, 56, N'Khong co anh', 888888.0000, 977776.8000)
INSERT [dbo].[Product] ([ID], [Name], [CategoryID], [SizeID], [RawMaterial_ID], [ColorID], [ObjectID], [SeasonID], [ManufacturedID], [Quantity], [Picture], [PriceEntry], [PriceSell]) VALUES (N'SP0006', N'kakaka', 3, 2, 2, 2, 1002, 2, 1003, 890, N'Khong co anh', 666.0000, 732.6000)
GO
SET IDENTITY_INSERT [dbo].[RawMaterial] ON 

INSERT [dbo].[RawMaterial] ([ID], [Name]) VALUES (1, N'Vải Thô')
INSERT [dbo].[RawMaterial] ([ID], [Name]) VALUES (2, N'Da cá sấu')
INSERT [dbo].[RawMaterial] ([ID], [Name]) VALUES (3, N'Lông đại bàng')
SET IDENTITY_INSERT [dbo].[RawMaterial] OFF
GO
SET IDENTITY_INSERT [dbo].[Role] ON 

INSERT [dbo].[Role] ([ID], [Name]) VALUES (1, N'Nông Dân v8')
INSERT [dbo].[Role] ([ID], [Name]) VALUES (4, N'I don''t wana live forever')
SET IDENTITY_INSERT [dbo].[Role] OFF
GO
SET IDENTITY_INSERT [dbo].[Season] ON 

INSERT [dbo].[Season] ([ID], [Name]) VALUES (1, N'Đông')
INSERT [dbo].[Season] ([ID], [Name]) VALUES (2, N'Hè')
INSERT [dbo].[Season] ([ID], [Name]) VALUES (1002, N'Thu')
SET IDENTITY_INSERT [dbo].[Season] OFF
GO
SET IDENTITY_INSERT [dbo].[Size] ON 

INSERT [dbo].[Size] ([ID], [Size]) VALUES (1, N'32')
INSERT [dbo].[Size] ([ID], [Size]) VALUES (2, N'M')
INSERT [dbo].[Size] ([ID], [Size]) VALUES (3, N'L')
INSERT [dbo].[Size] ([ID], [Size]) VALUES (1002, N'S')
INSERT [dbo].[Size] ([ID], [Size]) VALUES (2002, N'XL')
SET IDENTITY_INSERT [dbo].[Size] OFF
GO
INSERT [dbo].[Supplier] ([ID], [Name], [Address], [PhoneNumber]) VALUES (N'NCC0001', N'Thao Fashionista', N'Hanoi city', N'0321654987')
INSERT [dbo].[Supplier] ([ID], [Name], [Address], [PhoneNumber]) VALUES (N'NCC0002', N'hihihi', N'ahf nội', N'01234567899')
INSERT [dbo].[Supplier] ([ID], [Name], [Address], [PhoneNumber]) VALUES (N'NCC0003', N'Leu leu', N'Cau giay', N'0336552654')
GO
ALTER TABLE [dbo].[Employee] ADD  CONSTRAINT [DF_Employee_DateOfBirth]  DEFAULT (getdate()) FOR [DateOfBirth]
GO
ALTER TABLE [dbo].[Employee]  WITH CHECK ADD  CONSTRAINT [FK_Employee_Role] FOREIGN KEY([RoleID])
REFERENCES [dbo].[Role] ([ID])
GO
ALTER TABLE [dbo].[Employee] CHECK CONSTRAINT [FK_Employee_Role]
GO
ALTER TABLE [dbo].[EntryDetails]  WITH CHECK ADD  CONSTRAINT [FK_EntryDetails_EntryInvoice] FOREIGN KEY([EntryID])
REFERENCES [dbo].[EntryInvoice] ([ID])
GO
ALTER TABLE [dbo].[EntryDetails] CHECK CONSTRAINT [FK_EntryDetails_EntryInvoice]
GO
ALTER TABLE [dbo].[EntryDetails]  WITH CHECK ADD  CONSTRAINT [FK_EntryDetails_Product] FOREIGN KEY([ProductID])
REFERENCES [dbo].[Product] ([ID])
GO
ALTER TABLE [dbo].[EntryDetails] CHECK CONSTRAINT [FK_EntryDetails_Product]
GO
ALTER TABLE [dbo].[EntryInvoice]  WITH CHECK ADD  CONSTRAINT [FK_EntryInvoice_Employee] FOREIGN KEY([EmployeeID])
REFERENCES [dbo].[Employee] ([ID])
GO
ALTER TABLE [dbo].[EntryInvoice] CHECK CONSTRAINT [FK_EntryInvoice_Employee]
GO
ALTER TABLE [dbo].[EntryInvoice]  WITH CHECK ADD  CONSTRAINT [FK_EntryInvoice_Supplier] FOREIGN KEY([SupplierID])
REFERENCES [dbo].[Supplier] ([ID])
GO
ALTER TABLE [dbo].[EntryInvoice] CHECK CONSTRAINT [FK_EntryInvoice_Supplier]
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK_Product_Category] FOREIGN KEY([CategoryID])
REFERENCES [dbo].[Category] ([ID])
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK_Product_Category]
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK_Product_Color] FOREIGN KEY([ColorID])
REFERENCES [dbo].[Color] ([ID])
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK_Product_Color]
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK_Product_Manufactured] FOREIGN KEY([ManufacturedID])
REFERENCES [dbo].[Manufactured] ([ID])
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK_Product_Manufactured]
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK_Product_Object] FOREIGN KEY([ObjectID])
REFERENCES [dbo].[Object] ([ID])
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK_Product_Object]
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK_Product_RawMaterial] FOREIGN KEY([RawMaterial_ID])
REFERENCES [dbo].[RawMaterial] ([ID])
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK_Product_RawMaterial]
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK_Product_Season] FOREIGN KEY([SeasonID])
REFERENCES [dbo].[Season] ([ID])
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK_Product_Season]
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK_Product_Size] FOREIGN KEY([SizeID])
REFERENCES [dbo].[Size] ([ID])
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK_Product_Size]
GO
ALTER TABLE [dbo].[SaleDetails]  WITH CHECK ADD  CONSTRAINT [FK_SaleDetails_Product] FOREIGN KEY([ProductID])
REFERENCES [dbo].[Product] ([ID])
GO
ALTER TABLE [dbo].[SaleDetails] CHECK CONSTRAINT [FK_SaleDetails_Product]
GO
ALTER TABLE [dbo].[SaleDetails]  WITH CHECK ADD  CONSTRAINT [FK_SaleDetails_SaleInvoice] FOREIGN KEY([SaleID])
REFERENCES [dbo].[SaleInvoice] ([ID])
GO
ALTER TABLE [dbo].[SaleDetails] CHECK CONSTRAINT [FK_SaleDetails_SaleInvoice]
GO
ALTER TABLE [dbo].[SaleInvoice]  WITH CHECK ADD  CONSTRAINT [FK_SaleInvoice_Customer] FOREIGN KEY([CustomerID])
REFERENCES [dbo].[Customer] ([ID])
GO
ALTER TABLE [dbo].[SaleInvoice] CHECK CONSTRAINT [FK_SaleInvoice_Customer]
GO
ALTER TABLE [dbo].[SaleInvoice]  WITH CHECK ADD  CONSTRAINT [FK_SaleInvoice_Employee] FOREIGN KEY([EmployeeID])
REFERENCES [dbo].[Employee] ([ID])
GO
ALTER TABLE [dbo].[SaleInvoice] CHECK CONSTRAINT [FK_SaleInvoice_Employee]
GO
/****** Object:  StoredProcedure [dbo].[Delete_Customer]    Script Date: 11/1/2020 5:10:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[Delete_Customer]
	@CustomerID varchar(6)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	DELETE 
	FROM Customer 
	WHERE Customer.ID = @CustomerID
END
GO
/****** Object:  StoredProcedure [dbo].[Delete_Employee]    Script Date: 11/1/2020 5:10:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Delete_Employee]
	-- Add the parameters for the stored procedure here
	@EmployeeID varchar(6)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	DELETE 
	FROM Employee 
	WHERE Employee.ID = @EmployeeID
END
GO
/****** Object:  StoredProcedure [dbo].[Delete_Product]    Script Date: 11/1/2020 5:10:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Delete_Product]
	-- Add the parameters for the stored procedure here
	@ProductID varchar(6)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	BEGIN TRY
		DELETE 
		FROM Product 
		WHERE Product.ID = @ProductID
	END TRY
	BEGIN CATCH
		SELECT ERROR_MESSAGE() as error
	END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[Delete_Supplier]    Script Date: 11/1/2020 5:10:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Thao>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Delete_Supplier]
	-- Add the parameters for the stored procedure here
	@SupplierID varchar(7)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	DELETE FROM Supplier WHERE Supplier.ID = @SupplierID
END
GO
/****** Object:  StoredProcedure [dbo].[FindCustomerBy_ID]    Script Date: 11/1/2020 5:10:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Nguyen Thao>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[FindCustomerBy_ID]
	-- Add the parameters for the stored procedure here
	@CustomerID varchar(6)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	SELECT ID as N'Mã Khách Hàng',Name as N'Tên Khách Hàng',PhoneNumber as N'Số Điện Thoại',Address as N'Địa Chỉ' 
	FROM Customer
	WHERE Customer.ID LIKE '%' + @CustomerID +'%'
END
GO
/****** Object:  StoredProcedure [dbo].[FindCustomerBy_Name]    Script Date: 11/1/2020 5:10:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Nguyen Thao>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[FindCustomerBy_Name]
	-- Add the parameters for the stored procedure here
	@CustomerName nvarchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
SELECT ID as N'Mã Khách Hàng',Name as N'Tên Khách Hàng',PhoneNumber as N'Số Điện Thoại',Address as N'Địa Chỉ'
	FROM Customer
	WHERE Customer.Name LIKE '%' +  @CustomerName +'%'
END
GO
/****** Object:  StoredProcedure [dbo].[FindEmployeeBy_ID]    Script Date: 11/1/2020 5:10:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[FindEmployeeBy_ID]
	@ID varchar(6)
AS
BEGIN
		SELECT Employee.ID as N'Mã Nhân Viên' ,
	Employee.Name as  N'Tên Nhân Viên',
	IIF(SEX = 'M',N'Nam',N'Nữ') as  N'Giới Tính' ,
	DateOfBirth as N'Ngày Sinh',
	PhoneNumber as N'Số Điện Thoại',
	Role.Name as N'Tên Chức Vụ',
	Address as N'Địa Chỉ'
	FROM Employee,Role
	Where Role.Id = Employee.RoleID AND Employee.ID LIKE '%' + @ID + '%'
END
GO
/****** Object:  StoredProcedure [dbo].[FindEmployeeBy_Name]    Script Date: 11/1/2020 5:10:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[FindEmployeeBy_Name]
	@Name nvarchar(120)
AS
BEGIN
		SELECT Employee.ID as N'Mã Nhân Viên' ,
	Employee.Name as  N'Tên Nhân Viên',
	IIF(SEX = 'M',N'Nam',N'Nữ') as  N'Giới Tính' ,
	DateOfBirth as N'Ngày Sinh',
	PhoneNumber as N'Số Điện Thoại',
	Role.Name as N'Tên Chức Vụ',
	Address as N'Địa Chỉ'
	FROM Employee,Role
	Where Role.Id = Employee.RoleID AND Employee.Name LIKE '%' + @Name + '%'
END
GO
/****** Object:  StoredProcedure [dbo].[FindEntryInvoiceBy_EmployeeName]    Script Date: 11/1/2020 5:10:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[FindEntryInvoiceBy_EmployeeName]
@EmployeeName nvarchar(120)
AS
BEGIN
	SELECT EntryInvoice.ID as N'Mã Hóa Đơn',Employee.Name as N'Nhân Viên Nhập' , Supplier.Name as N'Nhà Cung Cấp',DayEntry as N'Ngày Nhập',Total as N'Tổng Tiền (VND)'
	FROM EntryInvoice,Employee,Supplier
	Where EmployeeID = Employee.ID and SupplierID = Supplier.ID and Employee.Name LIKE '%' + @EmployeeName + '%'
END
GO
/****** Object:  StoredProcedure [dbo].[FindEntryInvoiceBy_ID]    Script Date: 11/1/2020 5:10:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[FindEntryInvoiceBy_ID] 
@EntryID varchar(7)
AS
BEGIN
	SELECT EntryInvoice.ID as N'Mã Hóa Đơn',Employee.Name as N'Nhân Viên Nhập' , Supplier.Name as N'Nhà Cung Cấp',DayEntry as N'Ngày Nhập',Total as N'Tổng Tiền (VND)'
	FROM EntryInvoice,Employee,Supplier
	Where EmployeeID = Employee.ID and SupplierID = Supplier.ID and EntryInvoice.ID LIKE '%' + @EntryID + '%'
END
GO
/****** Object:  StoredProcedure [dbo].[FindEntryInvoiceBy_SupplierName]    Script Date: 11/1/2020 5:10:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[FindEntryInvoiceBy_SupplierName]
@SupplierName nvarchar(200)
AS
BEGIN
	SELECT EntryInvoice.ID as N'Mã Hóa Đơn',Employee.Name as N'Nhân Viên Nhập' , Supplier.Name as N'Nhà Cung Cấp',DayEntry as N'Ngày Nhập',Total as N'Tổng Tiền'
	FROM EntryInvoice,Employee,Supplier
	Where EmployeeID = Employee.ID and SupplierID = Supplier.ID and Supplier.Name LIKE '%' + @SupplierName + '%'
END
GO
/****** Object:  StoredProcedure [dbo].[FindProductByID]    Script Date: 11/1/2020 5:10:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[FindProductByID]
	-- Add the parameters for the stored procedure here
	@ProductID varchar(6)
AS
BEGIN
	SELECT	Product.ID as		N'Mã Sản Phẩm',
			Product.Name as		N'Tên Sản Phẩm',
			Category.Name as	N'Loại Sản Phẩm',
			Size.Size as		N'Kích Cỡ',
			RawMaterial.Name as N'Nguyên Liệu',
			Color.Name as		N'Màu Sắc',
			Object.Name as		N'Đối Tượng',
			Season.Name as		N'Mùa',
			Manufactured.Name as N'Nhà Sản Xuất',
			Quantity as			N'Số Lượng',
			PriceEntry as		N'Giá Nhập',
			PriceSell as		N'Giá Bán',
			Picture as			N'Hình Ảnh'
	FROM Product
	INNER JOIN  Category on CategoryID = Category.ID 
	INNER JOIN	Size on SizeID = Size.ID
	INNER JOIN	RawMaterial on RawMaterial_ID = RawMaterial.ID
	INNER JOIN	Color on ColorID = Color.ID
	INNER JOIN	Object on Object.ID = ObjectID
	INNER JOIN	Season on SeasonID = Season.ID
	INNER JOIN	Manufactured on Manufactured.ID = ManufacturedID
	WHERE  Product.ID = @ProductID
END
GO
/****** Object:  StoredProcedure [dbo].[FindProductByName]    Script Date: 11/1/2020 5:10:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Thao>
-- Create date: <Create Date,8/10/2020,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[FindProductByName]
	-- Add the parameters for the stored procedure here
	@ProductName nvarchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	SELECT	Product.ID as		N'Mã Sản Phẩm',
			Product.Name as		N'Tên Sản Phẩm',
			Category.Name as	N'Loại Sản Phẩm',
			Size.Size as		N'Kích Cỡ',
			RawMaterial.Name as N'Nguyên Liệu',
			Color.Name as		N'Màu Sắc',
			Object.Name as		N'Đối Tượng',
			Season.Name as		N'Mùa',
			Manufactured.Name as N'Nhà Sản Xuất',
			Quantity as			N'Số Lượng',
			PriceEntry as		N'Giá Nhập',
			PriceSell as		N'Giá Bán',
			Picture as			N'Hình Ảnh'
	FROM Product
	INNER JOIN  Category on CategoryID = Category.ID 
	INNER JOIN	Size on SizeID = Size.ID
	INNER JOIN	RawMaterial on RawMaterial_ID = RawMaterial.ID
	INNER JOIN	Color on ColorID = Color.ID
	INNER JOIN	Object on Object.ID = ObjectID
	INNER JOIN	Season on SeasonID = Season.ID
	INNER JOIN	Manufactured on Manufactured.ID = ManufacturedID
	WHERE  Product.Name LIKE '%' + @ProductName + '%'

END
GO
/****** Object:  StoredProcedure [dbo].[FindSupplierBy_ID]    Script Date: 11/1/2020 5:10:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[FindSupplierBy_ID]
	-- Add the parameters for the stored procedure here
@SupplierID varchar(7)
AS
BEGIN
	SELECT ID as N'Mã Nhà Cung Cấp' ,Name as N'Tên Nhà Cung Cấp',PhoneNumber as N'Số Điện Thoại' , Address as N'Địa Chỉ'
	FROM Supplier
	WHERE Supplier.ID LIKE '%' + @SupplierID +'%'
END
GO
/****** Object:  StoredProcedure [dbo].[FindSupplierBy_Name]    Script Date: 11/1/2020 5:10:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Thao>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[FindSupplierBy_Name]
	-- Add the parameters for the stored procedure here
	@SupplierName nvarchar(200)
AS
BEGIN

	SELECT ID as N'Mã Nhà Cung Cấp' ,Name as N'Tên Nhà Cung Cấp',PhoneNumber as N'Số Điện Thoại' , Address as N'Địa Chỉ'
	FROM Supplier
	WHERE Supplier.Name LIKE '%' + @SupplierName +'%'
END
GO
/****** Object:  StoredProcedure [dbo].[GetAllCategory]    Script Date: 11/1/2020 5:10:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetAllCategory]

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	Select * FROM Category
END
GO
/****** Object:  StoredProcedure [dbo].[GetAllColor]    Script Date: 11/1/2020 5:10:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetAllColor]
	-- Add the parameters for the stored procedure here

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * FROM Color
END
GO
/****** Object:  StoredProcedure [dbo].[GetAllCustomers]    Script Date: 11/1/2020 5:10:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetAllCustomers]
AS
BEGIN
		SELECT ID as N'Mã Khách Hàng',Name as N'Tên Khách Hàng',PhoneNumber as N'Số Điện Thoại',Address as N'Địa Chỉ' FROM Customer
END
GO
/****** Object:  StoredProcedure [dbo].[GetAllEmployee]    Script Date: 11/1/2020 5:10:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetAllEmployee]
AS
BEGIN
	SELECT Employee.ID as N'Mã Nhân Viên' ,
	Employee.Name as  N'Tên Nhân Viên',
	IIF(SEX = 'M',N'Nam',N'Nữ') as  N'Giới Tính' ,
	DateOfBirth as N'Ngày Sinh',
	PhoneNumber as N'Số Điện Thoại',
	Role.Name as N'Tên Chức Vụ',
	Address as N'Địa Chỉ'
	FROM Employee,Role
	Where Role.Id = Employee.RoleID
END
GO
/****** Object:  StoredProcedure [dbo].[GetAllEmployee_List]    Script Date: 11/1/2020 5:10:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- ================================================
CREATE PROCEDURE [dbo].[GetAllEmployee_List]

AS
BEGIN
	SELECT ID,ID + ' - ' + Name as 'Name',Address,PhoneNumber  FROM Employee
END
GO
/****** Object:  StoredProcedure [dbo].[GetAllEntryInvoices]    Script Date: 11/1/2020 5:10:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Thao>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetAllEntryInvoices]
@DateStart datetime,
@DateEnd datetime
AS
BEGIN

	SELECT EntryInvoice.ID as N'Mã Hóa Đơn',Employee.Name as N'Nhân Viên Nhập' , Supplier.Name as N'Nhà Cung Cấp',CONVERT(nvarchar,DayEntry,20) as N'Ngày Nhập', format(Total,'N','vi-VN') as N'Tổng Tiền (VND)'
	FROM EntryInvoice,Employee,Supplier
	Where EmployeeID = Employee.ID and SupplierID = Supplier.ID and DayEntry between @DateStart and @DateEnd
END
GO
/****** Object:  StoredProcedure [dbo].[GetAllManufactured]    Script Date: 11/1/2020 5:10:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetAllManufactured]
	-- Add the parameters for the stored procedure here

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * FROM Manufactured
END
GO
/****** Object:  StoredProcedure [dbo].[GetAllObject]    Script Date: 11/1/2020 5:10:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetAllObject]
	-- Add the parameters for the stored procedure here

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	SELECT * FROM Object
END
GO
/****** Object:  StoredProcedure [dbo].[GetAllProduct]    Script Date: 11/1/2020 5:10:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Nguyễn Thảo>
-- Create date: <Create Date,4/10/2020,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetAllProduct]
	-- Add the parameters for the stored procedure here

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	SELECT Product.ID as N'Mã Sản Phẩm',Product.Name as N'Tên Sản Phẩm',Category.Name as N'Loại Sản Phẩm',Size.Size as N'Kích Cỡ',RawMaterial.Name as N'Nguyên Liệu',Color.Name as N'Màu Sắc',Object.Name as N'Đối Tượng',Season.Name as N'Mùa',Manufactured.Name as N'Nhà Sản Xuất',Quantity as 'Số Lượng',PriceEntry as N'Giá Nhập',PriceSell as N'Giá Bán',Picture as 'Link ảnh'
	FROM Product,Category,Size,RawMaterial,Color,Object,Season,Manufactured
	WHERE CategoryID = Category.ID AND SizeID = Size.ID AND RawMaterial_ID = RawMaterial.ID
	AND ColorID = Color.ID AND Object.ID = ObjectID AND SeasonID = Season.ID AND Manufactured.ID = ManufacturedID
END
GO
/****** Object:  StoredProcedure [dbo].[getallproduct_banhang]    Script Date: 11/1/2020 5:10:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[getallproduct_banhang]
as
begin
	SELECT Product.ID as N'Mã Sản Phẩm',Product.Name as N'Tên Sản Phẩm',Category.Name as N'Loại Sản Phẩm',Size.Size as N'Kích Cỡ',RawMaterial.Name as N'Nguyên Liệu',Color.Name as N'Màu Sắc',Object.Name as N'Đối Tượng',Season.Name as N'Mùa',Manufactured.Name as N'Nhà Sản Xuất',Quantity as N'Số Lượng',PriceSell as N'Giá Bán'
	FROM Product,Category,Size,RawMaterial,Color,Object,Season,Manufactured
	WHERE CategoryID = Category.ID AND SizeID = Size.ID AND RawMaterial_ID = RawMaterial.ID
	AND ColorID = Color.ID AND Object.ID = ObjectID AND SeasonID = Season.ID AND Manufactured.ID = ManufacturedID
end
GO
/****** Object:  StoredProcedure [dbo].[GetAllProduct_In_EntryInvoice]    Script Date: 11/1/2020 5:10:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Author:		<Author,,Thảo>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetAllProduct_In_EntryInvoice]
	-- Add the parameters for the stored procedure here
	@EntryInvoiceID varchar(7),
	@Quantity int output,
	@Total money output,
	@Name nvarchar(50) output
AS
BEGIN
	SELECT	ProductID as N'Mã Sản Phẩm',Product.Name as N'Tên Sản Phẩm',EntryDetails.Quantity as N'Số Lượng',
			format(UnitPrice,'N','vi-VN') as N'Giá Nhập',format(EntryDetails.Quantity * UnitPrice,'N','vi-VN') as N'Tổng Tiền ' ,Discount as N'Giảm Giá'
	FROM EntryDetails
	INNER JOIN EntryInvoice on EntryDetails.EntryID = EntryInvoice.ID
	INNER JOIn Product on Product.ID =  EntryDetails.ProductID
	WHERE EntryDetails.EntryID = @EntryInvoiceID
	-- Lấy Ra Số lượng và Tổng tiền trả về
	SELECT @Quantity = COUNT(ProductID),@Total = SUM(EntryInvoice.Total)
	FROM EntryDetails
		LEFT JOIN EntryInvoice on EntryDetails.EntryID = EntryInvoice.ID
	WHERE EntryID = @EntryInvoiceID
	-- Lấy ra Tên nhà Sản Xuất và Trả về
	SELECT @Name = Supplier.Name
	FROM EntryInvoice,Supplier
	where SupplierID = Supplier.ID and EntryInvoice.ID = @EntryInvoiceID
END
GO
/****** Object:  StoredProcedure [dbo].[GetAllProduct_List]    Script Date: 11/1/2020 5:10:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetAllProduct_List]

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	SELECT Product.ID,Product.ID + '  -  ' +Product.Name as 'Name',Product.CategoryID,SizeID,RawMaterial_ID,ColorID,Product.ObjectID,
	SeasonID,ManufacturedID,Quantity,Picture,PriceEntry,PriceSell  FROM Product
END
GO
/****** Object:  StoredProcedure [dbo].[GetAllRawMaterial]    Script Date: 11/1/2020 5:10:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetAllRawMaterial]
	-- Add the parameters for the stored procedure here

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * FROM RawMaterial
END
GO
/****** Object:  StoredProcedure [dbo].[GetAllRole]    Script Date: 11/1/2020 5:10:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Thao>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetAllRole]

AS
BEGIN
		SELECT * FROM Role
END
GO
/****** Object:  StoredProcedure [dbo].[GetAllSeason]    Script Date: 11/1/2020 5:10:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetAllSeason]
	-- Add the parameters for the stored procedure here

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * FROM Season
END
GO
/****** Object:  StoredProcedure [dbo].[GetAllSize]    Script Date: 11/1/2020 5:10:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetAllSize]
	-- Add the parameters for the stored procedure here

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	SELECT * FROM Size
END
GO
/****** Object:  StoredProcedure [dbo].[GetAllSupplier_List]    Script Date: 11/1/2020 5:10:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- ================================================
CREATE PROCEDURE [dbo].[GetAllSupplier_List]

AS
BEGIN
	SELECT ID,ID + ' - ' +Supplier.Name as 'Name',Address,PhoneNumber  FROM Supplier
END
GO
/****** Object:  StoredProcedure [dbo].[GetAllSuppliers]    Script Date: 11/1/2020 5:10:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Thảo>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetAllSuppliers]

AS
BEGIN
	SELECT ID as N'Mã Nhà Cung Cấp' ,Name as N'Tên Nhà Cung Cấp',PhoneNumber as N'Số Điện Thoại' , Address as N'Địa Chỉ'
	FROM Supplier
END
GO
/****** Object:  StoredProcedure [dbo].[InsertNewCustomer]    Script Date: 11/1/2020 5:10:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Thao>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[InsertNewCustomer]
	-- Add the parameters for the stored procedure here
	@Name nvarchar(50),
	@Address nvarchar(200),
	@PhoneNumber varchar(15),
	@ID varchar(6) output
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	DECLARE @MA int
	DECLARE @s varchar(7)
	SELECT @MA  = MAX (CAST(SUBSTRING(ID,3,4) as INT))+1
	FROM Customer
	IF(@MA is null)
		SET @MA = 1
	SELECT @s = '000' + RTRIM(CAST(@MA as varchar(4)))
	SELECT @s = 'KH' + Right(@s,4)
	SELECT @ID = @s
	INSERT INTO Customer(ID,Name,Address,PhoneNumber) VALUES (@ID,@Name,@Address,@PhoneNumber)
END
GO
/****** Object:  StoredProcedure [dbo].[InsertNewEmployee]    Script Date: 11/1/2020 5:10:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Thao>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[InsertNewEmployee]
	@Name nvarchar(120),
	@Sex char(1),
	@DateOfBirth date,
	@PhoneNumber varchar(15),
	@Address nvarchar(100),
	@RoleID int,
	@ID varchar(6) output
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	--Tach lay ma
	DECLARE @MA int
	SELECT @MA = MAX(CAST(SUBSTRING(ID,3,4) AS int)) + 1 FROM Employee
	-- Neu trong bang k co ban ghi nao thi 
	IF (@MA is null)
		SET @MA =1
	DECLARE @Chuoi varchar(6)
	SET @Chuoi = '000' + RTRIM(CAST(@MA as varchar(4)))
	SET @Chuoi = 'NV' + RIGHT(@Chuoi,4)
	
	INSERT INTO Employee (ID,Name,Sex,DateOfBirth,PhoneNumber,Address,RoleID) 
	VALUES (@Chuoi,@Name,@Sex,@DateOfBirth,@PhoneNumber,@Address,@RoleID)

	SET @ID = @Chuoi
END
GO
/****** Object:  StoredProcedure [dbo].[InsertNewEntryDetails]    Script Date: 11/1/2020 5:10:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[InsertNewEntryDetails]
	-- Add the parameters for the stored procedure here
	@EntryID varchar(7),
	@ProductID varchar(6),
	@Discount float,	
	@UnitPrice money,
	@Quantity int,
	@Total money
AS
BEGIN
update Product
	set PriceEntry=@UnitPrice ,PriceSell=1.1*@UnitPrice,Quantity=Quantity+@Quantity	
	where ID=@ProductID
	
	insert into EntryDetails(EntryID,ProductID,Quantity,UnitPrice,Discount,Total)
	values(@EntryID,@ProductID,@Quantity,@UnitPrice, @Discount,@Total)
END
GO
/****** Object:  StoredProcedure [dbo].[InsertNewEntryInvoice]    Script Date: 11/1/2020 5:10:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[InsertNewEntryInvoice]
@EmployeeID varchar(6),
@SupplierID varchar(7),
@DayEntry nvarchar(100),
@Total money,
@EntryID varchar(7) output
AS
BEGIN
	DECLARE @MA int
	DECLARE @s varchar(7)
	SELECT @MA  = MAX (CAST(SUBSTRING(ID,4,4) as INT))+1
	FROM EntryInvoice
	IF(@MA is null)
		SET @MA = 1
	SELECT @s = '000' + RTRIM(CAST(@MA as varchar(4)))
	SELECT @s = 'HDN' + Right(@s,4)
	SELECT @Entryid = @s
	insert into EntryInvoice(id,EmployeeID,SupplierID,DayEntry,Total)
	values(@Entryid,@EmployeeID,@SupplierID,@DayEntry,@Total)
END
GO
/****** Object:  StoredProcedure [dbo].[InsertNewProduct]    Script Date: 11/1/2020 5:10:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[InsertNewProduct]
	-- Add the parameters for the stored procedure here
	@ProductName nvarchar(50),
	@CategoryID int,
	@SizeID int,
	@RawMaterial_ID int,
	@ColorID int,
	@ObjectID int,
	@SeasonID int,
	@ManufacturedID int,
	@Quantity int,
	@Picture nvarchar(100),
	@PriceEntry money,
	@PriceSell money,
	@ProductID nvarchar(6) output
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	-- Lay ra ma cua san pham tiep theo
	DECLARE @id int 
 	SELECT @id = MAX(Cast(SUBSTRING(ID,3,4) as INT)) +1 FROM PRODUCT
	IF (@id is null)
		SELECT @id = 1
	DECLARE @s varchar(6)
	SET @s ='000' + RTRIM(cast(@id as char(4)))
	SET @s = 'SP' + right(@s,4)

    -- Insert statements for procedure here
	INSERT INTO Product(ID,Name,CategoryID,SizeID,RawMaterial_ID,ColorID,ObjectID,SeasonID,ManufacturedID,Quantity,Picture,PriceEntry,PriceSell)
	VALUES (@s,@ProductName,@CategoryID,@SizeID,@RawMaterial_ID,@ColorID,@ObjectID,@SeasonID,@ManufacturedID,@Quantity,@Picture,@PriceEntry,@PriceSell);
	SELECT @ProductID = @s	
END
GO
/****** Object:  StoredProcedure [dbo].[InsertNewSupplier]    Script Date: 11/1/2020 5:10:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Thao>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[InsertNewSupplier]
	-- Add the parameters for the stored procedure here
	@Name nvarchar(200),
	@Address nvarchar(200),
	@PhoneNumber varchar(15),
	@ID varchar(7) output
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	DECLARE @MA int
	DECLARE @s varchar(7)
	SELECT @MA  = MAX (CAST(SUBSTRING(ID,4,4) as INT))+1
	FROM Supplier
	IF(@MA is null)
		SET @MA = 1
	SELECT @s = '000' + RTRIM(CAST(@MA as varchar(4)))
	SELECT @s = 'NCC' + right(@s,4)
	SELECT @ID = @s
	INSERT INTO Supplier(ID,Name,Address,PhoneNumber) VALUES (@ID,@Name,@Address,@PhoneNumber)
END
GO
/****** Object:  StoredProcedure [dbo].[NewCategory]    Script Date: 11/1/2020 5:10:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[NewCategory]
	-- Add the parameters for the stored procedure here
	@Name nvarchar(50),
	@ID int output
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO Category(Name) VALUES(@Name);
	SELECT @ID = SCOPE_IDENTITY();
END
GO
/****** Object:  StoredProcedure [dbo].[NewColor]    Script Date: 11/1/2020 5:10:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[NewColor]
	-- Add the parameters for the stored procedure here
@Name nvarchar(20),
@ID int output
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	INSERT INTO Color(Name) VALUES (@Name);
	SELECT @ID = SCOPE_IDENTITY();
END
GO
/****** Object:  StoredProcedure [dbo].[NewManufactured]    Script Date: 11/1/2020 5:10:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[NewManufactured]
	-- Add the parameters for the stored procedure here
	@Name nvarchar(200),
	@ID int output
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO Manufactured(Name) VALUES (@Name);
	SELECT @ID = SCOPE_IDENTITY();
END
GO
/****** Object:  StoredProcedure [dbo].[NewObject]    Script Date: 11/1/2020 5:10:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Thao>
-- Create date: <Create Date,3/10,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[NewObject]
	-- Add the parameters for the stored procedure here
	@Name nvarchar(20),
	@ID int output
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	INSERT INTO Object(Name) VALUES (@Name);
	SELECT @ID = SCOPE_IDENTITY();
END
GO
/****** Object:  StoredProcedure [dbo].[NewRawMaterial]    Script Date: 11/1/2020 5:10:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[NewRawMaterial]
	-- Add the parameters for the stored procedure here
	@Name nvarchar(100),
	@ID int output
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO RawMaterial(Name) VALUES (@Name);
	SELECT @ID = SCOPE_IDENTITY();
END
GO
/****** Object:  StoredProcedure [dbo].[NewRole]    Script Date: 11/1/2020 5:10:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Thao>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[NewRole]
	-- Add the parameters for the stored procedure here
	@Name nvarchar(50),
	@ID int output
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO Role(Name) VALUES (@Name);
	SELECT @ID = SCOPE_IDENTITY();
END
GO
/****** Object:  StoredProcedure [dbo].[NewSeason]    Script Date: 11/1/2020 5:10:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Thao>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[NewSeason]
	-- Add the parameters for the stored procedure here
@Name nvarchar(10),
@ID int output
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	INSERT INTO Season(Name) VALUES (@Name);
	SELECT @ID = SCOPE_IDENTITY();
END
GO
/****** Object:  StoredProcedure [dbo].[NewSize]    Script Date: 11/1/2020 5:10:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Thao>
-- Create date: <Create Date,3/10/2020,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[NewSize]
	-- Add the parameters for the stored procedure here
@Size nvarchar(30),
@ID int output
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	INSERT INTO Size(Size) VALUES (@Size);
	SELECT @ID = SCOPE_IDENTITY();
END
GO
/****** Object:  StoredProcedure [dbo].[UpdateCustomer]    Script Date: 11/1/2020 5:10:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[UpdateCustomer]
	@CustomerID varchar(6),
	@Name nvarchar(50),
	@PhoneNumber varchar(15),
	@Address nvarchar(200)
AS
BEGIN
	UPDATE Customer 
	SET Name = @Name, PhoneNumber = @PhoneNumber,Address = @Address
	WHERE @CustomerID = ID
END
GO
/****** Object:  StoredProcedure [dbo].[UpdateEmployee]    Script Date: 11/1/2020 5:10:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[UpdateEmployee]
	-- Add the parameters for the stored procedure here
@EmployeeID varchar(6),
@Name nvarchar(120),
@Sex char(1),
@DateOfBirth date,
@PhoneNumber varchar(15),
@Address nvarchar(100),
@RoleID int
AS
BEGIN
	UPDATE Employee SET Name = @Name ,Sex = @Sex ,DateOfBirth =@DateOfBirth,PhoneNumber = @PhoneNumber,Address = @Address,RoleID = @RoleID 
	where ID = @EmployeeID
END
GO
/****** Object:  StoredProcedure [dbo].[UpdateSupplier]    Script Date: 11/1/2020 5:10:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Thao>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[UpdateSupplier]
	-- Add the parameters for the stored procedure here
	@SupplierID varchar(7),
	@Name nvarchar(200),
	@Address nvarchar(200),
	@PhoneNumber varchar(15)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	UPDATE Supplier
	SET Name = @Name,Address = @Address,PhoneNumber = @PhoneNumber
	WHERE Supplier.ID = @SupplierID
END
GO
