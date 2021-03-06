USE [master]
GO
/****** Object:  Database [Inventory_Code]    Script Date: 09/11/2009 13:23:43 ******/
CREATE DATABASE [Inventory_Code] ON  PRIMARY 
( NAME = N'Inventory_Code', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\Inventory_Code.mdf' , SIZE = 2304KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Inventory_Code_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\Inventory_Code_log.LDF' , SIZE = 576KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Inventory_Code] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Inventory_Code].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Inventory_Code] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [Inventory_Code] SET ANSI_NULLS OFF
GO
ALTER DATABASE [Inventory_Code] SET ANSI_PADDING OFF
GO
ALTER DATABASE [Inventory_Code] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [Inventory_Code] SET ARITHABORT OFF
GO
ALTER DATABASE [Inventory_Code] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [Inventory_Code] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [Inventory_Code] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [Inventory_Code] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [Inventory_Code] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [Inventory_Code] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [Inventory_Code] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [Inventory_Code] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [Inventory_Code] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [Inventory_Code] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [Inventory_Code] SET  ENABLE_BROKER
GO
ALTER DATABASE [Inventory_Code] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [Inventory_Code] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [Inventory_Code] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [Inventory_Code] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [Inventory_Code] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [Inventory_Code] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [Inventory_Code] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [Inventory_Code] SET  READ_WRITE
GO
ALTER DATABASE [Inventory_Code] SET RECOVERY FULL
GO
ALTER DATABASE [Inventory_Code] SET  MULTI_USER
GO
ALTER DATABASE [Inventory_Code] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [Inventory_Code] SET DB_CHAINING OFF
GO
EXEC sys.sp_db_vardecimal_storage_format N'Inventory_Code', N'ON'
GO
USE [Inventory_Code]
GO
/****** Object:  Table [dbo].[tbl_ProductRecords]    Script Date: 09/11/2009 13:23:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_ProductRecords](
	[Product_Id] [bigint] NOT NULL,
	[Product_Name] [nvarchar](30) NOT NULL,
	[Price] [money] NOT NULL,
	[Quantity] [numeric](4, 0) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Product_Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[tbl_ProductRecords] ([Product_Id], [Product_Name], [Price], [Quantity]) VALUES (1, N'Nokia', 200.0000, CAST(12 AS Numeric(4, 0)))
INSERT [dbo].[tbl_ProductRecords] ([Product_Id], [Product_Name], [Price], [Quantity]) VALUES (2, N'aa', 300.4500, CAST(1 AS Numeric(4, 0)))
INSERT [dbo].[tbl_ProductRecords] ([Product_Id], [Product_Name], [Price], [Quantity]) VALUES (3, N'Phone', 4000.0000, CAST(7 AS Numeric(4, 0)))
INSERT [dbo].[tbl_ProductRecords] ([Product_Id], [Product_Name], [Price], [Quantity]) VALUES (4, N'Laptop', 35000.0000, CAST(18 AS Numeric(4, 0)))
INSERT [dbo].[tbl_ProductRecords] ([Product_Id], [Product_Name], [Price], [Quantity]) VALUES (5, N'Tablet', 15000.0000, CAST(9 AS Numeric(4, 0)))
/****** Object:  Table [dbo].[tbl_AdminLogin]    Script Date: 09/11/2009 13:23:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_AdminLogin](
	[AdminId] [nvarchar](30) NOT NULL,
	[Password] [nvarchar](30) NOT NULL
) ON [PRIMARY]
GO
INSERT [dbo].[tbl_AdminLogin] ([AdminId], [Password]) VALUES (N'Admin01', N'pwd01')
INSERT [dbo].[tbl_AdminLogin] ([AdminId], [Password]) VALUES (N'Admin02', N'pwd02')
INSERT [dbo].[tbl_AdminLogin] ([AdminId], [Password]) VALUES (N'a', N'a')
/****** Object:  StoredProcedure [dbo].[sp_ProductShow]    Script Date: 09/11/2009 13:23:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_ProductShow]
as
begin
select * from tbl_ProductRecords order by Product_Id
end
GO
/****** Object:  StoredProcedure [dbo].[sp_InsertProduct]    Script Date: 09/11/2009 13:23:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_InsertProduct]
@Product_Id bigint,
@Product_Name nvarchar(30),
@Price money,
@Quantity numeric(4)
as
begin
insert into tbl_ProductRecords(Product_Name,Price,Quantity)
values(@Product_Name,@Price,@Quantity)
end
GO
/****** Object:  StoredProcedure [dbo].[sp_AdminLogin]    Script Date: 09/11/2009 13:23:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_AdminLogin]
@AdminId nvarchar(30),
@Password nvarchar(30)
as
begin
select * from tbl_AdminLogin where
AdminId=@AdminId and Password=@Password
end
GO
