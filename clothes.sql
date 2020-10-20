USE [master]
GO
/****** Object:  Database [Clothes]    Script Date: 10/20/2020 12:15:57 PM ******/
CREATE DATABASE [Clothes]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Clothes', FILENAME = N'D:\SQL\MSSQL15.SQLEXPRESS\MSSQL\DATA\Clothes.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Clothes_log', FILENAME = N'D:\SQL\MSSQL15.SQLEXPRESS\MSSQL\DATA\Clothes_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Clothes] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Clothes].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Clothes] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Clothes] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Clothes] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Clothes] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Clothes] SET ARITHABORT OFF 
GO
ALTER DATABASE [Clothes] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Clothes] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Clothes] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Clothes] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Clothes] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Clothes] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Clothes] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Clothes] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Clothes] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Clothes] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Clothes] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Clothes] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Clothes] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Clothes] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Clothes] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Clothes] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Clothes] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Clothes] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Clothes] SET  MULTI_USER 
GO
ALTER DATABASE [Clothes] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Clothes] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Clothes] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Clothes] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Clothes] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Clothes] SET QUERY_STORE = OFF
GO
USE [Clothes]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 10/20/2020 12:15:57 PM ******/
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
/****** Object:  Table [dbo].[Color]    Script Date: 10/20/2020 12:15:57 PM ******/
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
/****** Object:  Table [dbo].[Customer]    Script Date: 10/20/2020 12:15:57 PM ******/
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
/****** Object:  Table [dbo].[Employee]    Script Date: 10/20/2020 12:15:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee](
	[ID] [varchar](6) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
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
/****** Object:  Table [dbo].[EntryDetails]    Script Date: 10/20/2020 12:15:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EntryDetails](
	[EntryID] [varchar](6) NOT NULL,
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
/****** Object:  Table [dbo].[EntryInvoice]    Script Date: 10/20/2020 12:15:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EntryInvoice](
	[ID] [varchar](6) NOT NULL,
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
/****** Object:  Table [dbo].[Manufactured]    Script Date: 10/20/2020 12:15:57 PM ******/
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
/****** Object:  Table [dbo].[Object]    Script Date: 10/20/2020 12:15:57 PM ******/
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
/****** Object:  Table [dbo].[Product]    Script Date: 10/20/2020 12:15:57 PM ******/
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
/****** Object:  Table [dbo].[RawMaterial]    Script Date: 10/20/2020 12:15:57 PM ******/
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
/****** Object:  Table [dbo].[Role]    Script Date: 10/20/2020 12:15:57 PM ******/
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
/****** Object:  Table [dbo].[SaleDetails]    Script Date: 10/20/2020 12:15:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SaleDetails](
	[SaleID] [varchar](6) NOT NULL,
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
/****** Object:  Table [dbo].[SaleInvoice]    Script Date: 10/20/2020 12:15:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SaleInvoice](
	[ID] [varchar](6) NOT NULL,
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
/****** Object:  Table [dbo].[Season]    Script Date: 10/20/2020 12:15:57 PM ******/
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
/****** Object:  Table [dbo].[Size]    Script Date: 10/20/2020 12:15:57 PM ******/
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
/****** Object:  Table [dbo].[Supplier]    Script Date: 10/20/2020 12:15:57 PM ******/
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
/****** Object:  StoredProcedure [dbo].[Delete_Customer]    Script Date: 10/20/2020 12:15:57 PM ******/
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
/****** Object:  StoredProcedure [dbo].[Delete_Employee]    Script Date: 10/20/2020 12:15:57 PM ******/
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
/****** Object:  StoredProcedure [dbo].[Delete_Product]    Script Date: 10/20/2020 12:15:57 PM ******/
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
/****** Object:  StoredProcedure [dbo].[Delete_Supplier]    Script Date: 10/20/2020 12:15:57 PM ******/
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
/****** Object:  StoredProcedure [dbo].[FindCustomerBy_ID]    Script Date: 10/20/2020 12:15:57 PM ******/
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
	SELECT ID as N'Mã KH',Name as N'Tên KH',PhoneNumber as N'Số Điện Thoại',Address as N'Địa Chỉ'
	FROM Customer
	WHERE Customer.ID LIKE '%' + @CustomerID +'%'
END
GO
/****** Object:  StoredProcedure [dbo].[FindCustomerBy_Name]    Script Date: 10/20/2020 12:15:57 PM ******/
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
	SELECT ID as N'Mã KH',Name as N'Tên KH',PhoneNumber as N'Số Điện Thoại',Address as N'Địa Chỉ'
	FROM Customer
	WHERE Customer.Name LIKE '%' +  @CustomerName +'%'
END
GO
/****** Object:  StoredProcedure [dbo].[FindProductByID]    Script Date: 10/20/2020 12:15:57 PM ******/
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
/****** Object:  StoredProcedure [dbo].[FindProductByName]    Script Date: 10/20/2020 12:15:57 PM ******/
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
/****** Object:  StoredProcedure [dbo].[FindSupplierBy_ID]    Script Date: 10/20/2020 12:15:57 PM ******/
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
	WHERE Supplier.ID LIKE @SupplierID
END
GO
/****** Object:  StoredProcedure [dbo].[FindSupplierBy_Name]    Script Date: 10/20/2020 12:15:57 PM ******/
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
/****** Object:  StoredProcedure [dbo].[GetAllCategory]    Script Date: 10/20/2020 12:15:57 PM ******/
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
/****** Object:  StoredProcedure [dbo].[GetAllColor]    Script Date: 10/20/2020 12:15:57 PM ******/
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
/****** Object:  StoredProcedure [dbo].[GetAllCustomers]    Script Date: 10/20/2020 12:15:57 PM ******/
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
		SELECT ID as N'Mã KH',Name as N'Tên KH',PhoneNumber as N'Số Điện Thoại',Address as N'Địa Chỉ' FROM Customer
END
GO
/****** Object:  StoredProcedure [dbo].[GetAllManufactured]    Script Date: 10/20/2020 12:15:57 PM ******/
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
/****** Object:  StoredProcedure [dbo].[GetAllObject]    Script Date: 10/20/2020 12:15:57 PM ******/
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
/****** Object:  StoredProcedure [dbo].[GetAllProduct]    Script Date: 10/20/2020 12:15:57 PM ******/
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
/****** Object:  StoredProcedure [dbo].[GetAllRawMaterial]    Script Date: 10/20/2020 12:15:57 PM ******/
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
/****** Object:  StoredProcedure [dbo].[GetAllRole]    Script Date: 10/20/2020 12:15:57 PM ******/
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
/****** Object:  StoredProcedure [dbo].[GetAllSeason]    Script Date: 10/20/2020 12:15:57 PM ******/
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
/****** Object:  StoredProcedure [dbo].[GetAllSize]    Script Date: 10/20/2020 12:15:57 PM ******/
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
/****** Object:  StoredProcedure [dbo].[GetAllSuppliers]    Script Date: 10/20/2020 12:15:57 PM ******/
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
/****** Object:  StoredProcedure [dbo].[InsertNewCustomer]    Script Date: 10/20/2020 12:15:57 PM ******/
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
	SELECT @s = 'KH' + @s
	SELECT @ID = @s
	INSERT INTO Customer(ID,Name,Address,PhoneNumber) VALUES (@ID,@Name,@Address,@PhoneNumber)
END
GO
/****** Object:  StoredProcedure [dbo].[InsertNewEmployee]    Script Date: 10/20/2020 12:15:57 PM ******/
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
	@FirstName nvarchar(50),
	@LastName nvarchar(50),
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
	SET @Chuoi = 'NV' + @Chuoi
	
	INSERT INTO Employee (ID,FirstName,LastName,Sex,DateOfBirth,PhoneNumber,Address,RoleID) 
	VALUES (@Chuoi,@FirstName,@LastName,@Sex,@DateOfBirth,@PhoneNumber,@Address,@RoleID)

	SET @ID = @Chuoi
END
GO
/****** Object:  StoredProcedure [dbo].[InsertNewProduct]    Script Date: 10/20/2020 12:15:57 PM ******/
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
	SET @s = 'SP' + @s

    -- Insert statements for procedure here
	INSERT INTO Product(ID,Name,CategoryID,SizeID,RawMaterial_ID,ColorID,ObjectID,SeasonID,ManufacturedID,Quantity,Picture,PriceEntry,PriceSell)
	VALUES (@s,@ProductName,@CategoryID,@SizeID,@RawMaterial_ID,@ColorID,@ObjectID,@SeasonID,@ManufacturedID,@Quantity,@Picture,@PriceEntry,@PriceSell);
	SELECT @ProductID = @s	
END
GO
/****** Object:  StoredProcedure [dbo].[InsertNewSupplier]    Script Date: 10/20/2020 12:15:57 PM ******/
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
	SELECT @s = 'NCC' + @s
	SELECT @ID = @s
	INSERT INTO Supplier(ID,Name,Address,PhoneNumber) VALUES (@ID,@Name,@Address,@PhoneNumber)
END
GO
/****** Object:  StoredProcedure [dbo].[NewCategory]    Script Date: 10/20/2020 12:15:57 PM ******/
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
/****** Object:  StoredProcedure [dbo].[NewColor]    Script Date: 10/20/2020 12:15:57 PM ******/
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
/****** Object:  StoredProcedure [dbo].[NewManufactured]    Script Date: 10/20/2020 12:15:57 PM ******/
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
/****** Object:  StoredProcedure [dbo].[NewObject]    Script Date: 10/20/2020 12:15:57 PM ******/
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
/****** Object:  StoredProcedure [dbo].[NewRawMaterial]    Script Date: 10/20/2020 12:15:57 PM ******/
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
/****** Object:  StoredProcedure [dbo].[NewRole]    Script Date: 10/20/2020 12:15:57 PM ******/
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
/****** Object:  StoredProcedure [dbo].[NewSeason]    Script Date: 10/20/2020 12:15:57 PM ******/
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
/****** Object:  StoredProcedure [dbo].[NewSize]    Script Date: 10/20/2020 12:15:57 PM ******/
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
/****** Object:  StoredProcedure [dbo].[UpdateCustomer]    Script Date: 10/20/2020 12:15:57 PM ******/
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
/****** Object:  StoredProcedure [dbo].[UpdateSupplier]    Script Date: 10/20/2020 12:15:57 PM ******/
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
USE [master]
GO
ALTER DATABASE [Clothes] SET  READ_WRITE 
GO
