USE [master]
GO
/****** Object:  Database [PRN211]    Script Date: 3/22/2023 10:03:40 AM ******/
CREATE DATABASE [PRN211]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'PRN211', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLSERVER\MSSQL\DATA\PRN211.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'PRN211_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLSERVER\MSSQL\DATA\PRN211_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [PRN211] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [PRN211].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [PRN211] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [PRN211] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [PRN211] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [PRN211] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [PRN211] SET ARITHABORT OFF 
GO
ALTER DATABASE [PRN211] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [PRN211] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [PRN211] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [PRN211] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [PRN211] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [PRN211] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [PRN211] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [PRN211] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [PRN211] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [PRN211] SET  ENABLE_BROKER 
GO
ALTER DATABASE [PRN211] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [PRN211] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [PRN211] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [PRN211] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [PRN211] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [PRN211] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [PRN211] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [PRN211] SET RECOVERY FULL 
GO
ALTER DATABASE [PRN211] SET  MULTI_USER 
GO
ALTER DATABASE [PRN211] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [PRN211] SET DB_CHAINING OFF 
GO
ALTER DATABASE [PRN211] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [PRN211] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [PRN211] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'PRN211', N'ON'
GO
ALTER DATABASE [PRN211] SET QUERY_STORE = OFF
GO
USE [PRN211]
GO
/****** Object:  Table [dbo].[Bill]    Script Date: 3/22/2023 10:03:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bill](
	[BillID] [int] IDENTITY(1,1) NOT NULL,
	[TableID] [int] NULL,
	[CheckOut] [smalldatetime] NULL,
	[TotalPrice] [nvarchar](50) NULL,
	[Status] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[BillID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BillDetail]    Script Date: 3/22/2023 10:03:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BillDetail](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[BillID] [int] NOT NULL,
	[FoodID] [int] NULL,
	[Size] [char](1) NULL,
	[Amount] [tinyint] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 3/22/2023 10:03:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[CategoryID] [int] IDENTITY(1,1) NOT NULL,
	[CategoryName] [nvarchar](40) NULL,
PRIMARY KEY CLUSTERED 
(
	[CategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Food]    Script Date: 3/22/2023 10:03:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Food](
	[FoodID] [int] IDENTITY(1,1) NOT NULL,
	[FoodName] [nvarchar](100) NULL,
	[CategoryID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[FoodID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Option]    Script Date: 3/22/2023 10:03:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Option](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[FoodID] [int] NOT NULL,
	[Size] [char](1) NULL,
	[Price] [int] NULL,
	[Status] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Table]    Script Date: 3/22/2023 10:03:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Table](
	[TableId] [int] IDENTITY(1,1) NOT NULL,
	[TableName] [nvarchar](10) NULL,
	[Status] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[TableId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 3/22/2023 10:03:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[UserId] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nvarchar](30) NULL,
	[Password] [nvarchar](30) NULL,
	[FullName] [nvarchar](30) NULL,
	[Gender] [bit] NULL,
	[DOB] [smalldatetime] NULL,
	[Address] [nvarchar](100) NULL,
	[Mobile] [nvarchar](10) NULL,
	[Avatar] [nvarchar](max) NULL,
	[RoleID] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Bill] ON 

INSERT [dbo].[Bill] ([BillID], [TableID], [CheckOut], [TotalPrice], [Status]) VALUES (1, 8, CAST(N'2023-03-22T08:31:00' AS SmallDateTime), N'378000', 1)
INSERT [dbo].[Bill] ([BillID], [TableID], [CheckOut], [TotalPrice], [Status]) VALUES (2, 29, CAST(N'2023-03-22T08:32:00' AS SmallDateTime), N'100000', 1)
INSERT [dbo].[Bill] ([BillID], [TableID], [CheckOut], [TotalPrice], [Status]) VALUES (3, 20, CAST(N'2023-03-22T08:33:00' AS SmallDateTime), N'100000', 1)
INSERT [dbo].[Bill] ([BillID], [TableID], [CheckOut], [TotalPrice], [Status]) VALUES (4, 3, NULL, NULL, 0)
INSERT [dbo].[Bill] ([BillID], [TableID], [CheckOut], [TotalPrice], [Status]) VALUES (5, 4, NULL, NULL, 0)
INSERT [dbo].[Bill] ([BillID], [TableID], [CheckOut], [TotalPrice], [Status]) VALUES (6, 10, NULL, NULL, 0)
SET IDENTITY_INSERT [dbo].[Bill] OFF
GO
SET IDENTITY_INSERT [dbo].[BillDetail] ON 

INSERT [dbo].[BillDetail] ([ID], [BillID], [FoodID], [Size], [Amount]) VALUES (1, 1, 1, N'M', 2)
INSERT [dbo].[BillDetail] ([ID], [BillID], [FoodID], [Size], [Amount]) VALUES (2, 2, 23, N'S', 1)
INSERT [dbo].[BillDetail] ([ID], [BillID], [FoodID], [Size], [Amount]) VALUES (3, 3, 20, N'S', 1)
SET IDENTITY_INSERT [dbo].[BillDetail] OFF
GO
SET IDENTITY_INSERT [dbo].[Category] ON 

INSERT [dbo].[Category] ([CategoryID], [CategoryName]) VALUES (1, N'Burgers')
INSERT [dbo].[Category] ([CategoryID], [CategoryName]) VALUES (2, N'Pizza')
INSERT [dbo].[Category] ([CategoryID], [CategoryName]) VALUES (3, N'Sallad')
INSERT [dbo].[Category] ([CategoryID], [CategoryName]) VALUES (4, N'Bánh Mì')
INSERT [dbo].[Category] ([CategoryID], [CategoryName]) VALUES (5, N'Chicken')
INSERT [dbo].[Category] ([CategoryID], [CategoryName]) VALUES (6, N'Đồ Ăn Vặt')
INSERT [dbo].[Category] ([CategoryID], [CategoryName]) VALUES (7, N'Nước Ép Trái Cây')
INSERT [dbo].[Category] ([CategoryID], [CategoryName]) VALUES (8, N'Cà Phê')
INSERT [dbo].[Category] ([CategoryID], [CategoryName]) VALUES (9, N'Trà Sữa')
INSERT [dbo].[Category] ([CategoryID], [CategoryName]) VALUES (10, N'Kem')
SET IDENTITY_INSERT [dbo].[Category] OFF
GO
SET IDENTITY_INSERT [dbo].[Food] ON 

INSERT [dbo].[Food] ([FoodID], [FoodName], [CategoryID]) VALUES (1, N'PIZZA LẠP XƯỞNG XỐT TRỨNG MUỐI MAYONNAISE - SAIGON MANIA PIZZA', 2)
INSERT [dbo].[Food] ([FoodID], [FoodName], [CategoryID]) VALUES (2, N'PIZZA BÒ & TÔM NƯỚNG KIỂU MỸ - SURF & TURF', 2)
INSERT [dbo].[Food] ([FoodID], [FoodName], [CategoryID]) VALUES (3, N'PIZZA BÁNH XÈO NHẬT - OKONOMIYAKI', 2)
INSERT [dbo].[Food] ([FoodID], [FoodName], [CategoryID]) VALUES (4, N'PIZZA THẬP CẨM THƯỢNG HẠNG - EXTRAVAGANZA', 2)
INSERT [dbo].[Food] ([FoodID], [FoodName], [CategoryID]) VALUES (5, N'PIZZA HẢI SẢN XỐT MAYONNAISE - OCEAN MANIA', 2)
INSERT [dbo].[Food] ([FoodID], [FoodName], [CategoryID]) VALUES (6, N'BÁNH MÌ1', 4)
INSERT [dbo].[Food] ([FoodID], [FoodName], [CategoryID]) VALUES (7, N'BÁNH MÌ2', 4)
INSERT [dbo].[Food] ([FoodID], [FoodName], [CategoryID]) VALUES (8, N'BÁNH MÌ3', 4)
INSERT [dbo].[Food] ([FoodID], [FoodName], [CategoryID]) VALUES (9, N'CHICKEN1', 5)
INSERT [dbo].[Food] ([FoodID], [FoodName], [CategoryID]) VALUES (10, N'CHICKEN2', 5)
INSERT [dbo].[Food] ([FoodID], [FoodName], [CategoryID]) VALUES (11, N'CHICKEN3', 5)
INSERT [dbo].[Food] ([FoodID], [FoodName], [CategoryID]) VALUES (12, N'ĐỒ ĂN VẶT 1', 6)
INSERT [dbo].[Food] ([FoodID], [FoodName], [CategoryID]) VALUES (13, N'ĐỒ ĂN VẶT 2', 6)
INSERT [dbo].[Food] ([FoodID], [FoodName], [CategoryID]) VALUES (14, N'ĐỒ ĂN VẶT 3', 6)
INSERT [dbo].[Food] ([FoodID], [FoodName], [CategoryID]) VALUES (15, N'NƯỚC ÉP TRÁI CÂY 1', 7)
INSERT [dbo].[Food] ([FoodID], [FoodName], [CategoryID]) VALUES (16, N'NƯỚC ÉP TRÁI CÂY 2', 7)
INSERT [dbo].[Food] ([FoodID], [FoodName], [CategoryID]) VALUES (17, N'NƯỚC ÉP TRÁI CÂY 3', 7)
INSERT [dbo].[Food] ([FoodID], [FoodName], [CategoryID]) VALUES (18, N'CÀ PHÊ 1', 8)
INSERT [dbo].[Food] ([FoodID], [FoodName], [CategoryID]) VALUES (19, N'CÀ PHÊ 2', 8)
INSERT [dbo].[Food] ([FoodID], [FoodName], [CategoryID]) VALUES (20, N'SALLAD123', 3)
INSERT [dbo].[Food] ([FoodID], [FoodName], [CategoryID]) VALUES (21, N'Burgers1', 1)
INSERT [dbo].[Food] ([FoodID], [FoodName], [CategoryID]) VALUES (22, N'Burgers2', 1)
INSERT [dbo].[Food] ([FoodID], [FoodName], [CategoryID]) VALUES (23, N'Burgers3', 1)
INSERT [dbo].[Food] ([FoodID], [FoodName], [CategoryID]) VALUES (24, N'CÀ PHÊ 3', 8)
INSERT [dbo].[Food] ([FoodID], [FoodName], [CategoryID]) VALUES (25, N'TRÀ SỮA 1', 9)
INSERT [dbo].[Food] ([FoodID], [FoodName], [CategoryID]) VALUES (26, N'TRÀ SỮA 2', 9)
INSERT [dbo].[Food] ([FoodID], [FoodName], [CategoryID]) VALUES (27, N'TRÀ SỮA 3', 9)
INSERT [dbo].[Food] ([FoodID], [FoodName], [CategoryID]) VALUES (28, N'KEM 1', 10)
INSERT [dbo].[Food] ([FoodID], [FoodName], [CategoryID]) VALUES (29, N'KEM 2', 10)
INSERT [dbo].[Food] ([FoodID], [FoodName], [CategoryID]) VALUES (30, N'KEM 3', 10)
SET IDENTITY_INSERT [dbo].[Food] OFF
GO
SET IDENTITY_INSERT [dbo].[Option] ON 

INSERT [dbo].[Option] ([ID], [FoodID], [Size], [Price], [Status]) VALUES (1, 1, N'S', 100000, 1)
INSERT [dbo].[Option] ([ID], [FoodID], [Size], [Price], [Status]) VALUES (2, 1, N'M', 200000, 1)
INSERT [dbo].[Option] ([ID], [FoodID], [Size], [Price], [Status]) VALUES (3, 1, N'L', 300000, 1)
INSERT [dbo].[Option] ([ID], [FoodID], [Size], [Price], [Status]) VALUES (4, 2, N'S', 100000, 1)
INSERT [dbo].[Option] ([ID], [FoodID], [Size], [Price], [Status]) VALUES (5, 2, N'M', 200000, 1)
INSERT [dbo].[Option] ([ID], [FoodID], [Size], [Price], [Status]) VALUES (6, 2, N'L', 300000, 1)
INSERT [dbo].[Option] ([ID], [FoodID], [Size], [Price], [Status]) VALUES (7, 3, N'S', 100000, 1)
INSERT [dbo].[Option] ([ID], [FoodID], [Size], [Price], [Status]) VALUES (8, 3, N'M', 200000, 1)
INSERT [dbo].[Option] ([ID], [FoodID], [Size], [Price], [Status]) VALUES (9, 3, N'L', 300000, 1)
INSERT [dbo].[Option] ([ID], [FoodID], [Size], [Price], [Status]) VALUES (10, 4, N'S', 100000, 1)
INSERT [dbo].[Option] ([ID], [FoodID], [Size], [Price], [Status]) VALUES (11, 4, N'M', 200000, 1)
INSERT [dbo].[Option] ([ID], [FoodID], [Size], [Price], [Status]) VALUES (12, 4, N'L', 300000, 1)
INSERT [dbo].[Option] ([ID], [FoodID], [Size], [Price], [Status]) VALUES (13, 5, N'S', 100000, 1)
INSERT [dbo].[Option] ([ID], [FoodID], [Size], [Price], [Status]) VALUES (14, 5, N'M', 200000, 1)
INSERT [dbo].[Option] ([ID], [FoodID], [Size], [Price], [Status]) VALUES (15, 5, N'L', 300000, 1)
INSERT [dbo].[Option] ([ID], [FoodID], [Size], [Price], [Status]) VALUES (16, 7, N'M', 100000, 1)
INSERT [dbo].[Option] ([ID], [FoodID], [Size], [Price], [Status]) VALUES (17, 13, N'S', 200000, 1)
INSERT [dbo].[Option] ([ID], [FoodID], [Size], [Price], [Status]) VALUES (18, 13, N'M', 300000, 1)
INSERT [dbo].[Option] ([ID], [FoodID], [Size], [Price], [Status]) VALUES (19, 6, N'S', 100000, 1)
INSERT [dbo].[Option] ([ID], [FoodID], [Size], [Price], [Status]) VALUES (20, 6, N'M', 200000, 1)
INSERT [dbo].[Option] ([ID], [FoodID], [Size], [Price], [Status]) VALUES (21, 6, N'L', 300000, 1)
INSERT [dbo].[Option] ([ID], [FoodID], [Size], [Price], [Status]) VALUES (22, 7, N'S', 100000, 1)
INSERT [dbo].[Option] ([ID], [FoodID], [Size], [Price], [Status]) VALUES (23, 7, N'L', 200000, 1)
INSERT [dbo].[Option] ([ID], [FoodID], [Size], [Price], [Status]) VALUES (24, 8, N'S', 100000, 1)
INSERT [dbo].[Option] ([ID], [FoodID], [Size], [Price], [Status]) VALUES (25, 8, N'M', 200000, 1)
INSERT [dbo].[Option] ([ID], [FoodID], [Size], [Price], [Status]) VALUES (26, 8, N'L', 300000, 1)
INSERT [dbo].[Option] ([ID], [FoodID], [Size], [Price], [Status]) VALUES (27, 9, N'S', 100000, 1)
INSERT [dbo].[Option] ([ID], [FoodID], [Size], [Price], [Status]) VALUES (28, 9, N'M', 100000, 1)
INSERT [dbo].[Option] ([ID], [FoodID], [Size], [Price], [Status]) VALUES (29, 9, N'L', 100000, 1)
INSERT [dbo].[Option] ([ID], [FoodID], [Size], [Price], [Status]) VALUES (30, 10, N'S', 100000, 1)
INSERT [dbo].[Option] ([ID], [FoodID], [Size], [Price], [Status]) VALUES (31, 10, N'M', 100000, 1)
INSERT [dbo].[Option] ([ID], [FoodID], [Size], [Price], [Status]) VALUES (32, 10, N'L', 100000, 1)
INSERT [dbo].[Option] ([ID], [FoodID], [Size], [Price], [Status]) VALUES (33, 11, N'S', 100000, 1)
INSERT [dbo].[Option] ([ID], [FoodID], [Size], [Price], [Status]) VALUES (34, 11, N'M', 100000, 1)
INSERT [dbo].[Option] ([ID], [FoodID], [Size], [Price], [Status]) VALUES (35, 11, N'L', 100000, 1)
INSERT [dbo].[Option] ([ID], [FoodID], [Size], [Price], [Status]) VALUES (36, 12, N'S', 100000, 1)
INSERT [dbo].[Option] ([ID], [FoodID], [Size], [Price], [Status]) VALUES (37, 12, N'M', 100000, 1)
INSERT [dbo].[Option] ([ID], [FoodID], [Size], [Price], [Status]) VALUES (38, 13, N'L', 100000, 1)
INSERT [dbo].[Option] ([ID], [FoodID], [Size], [Price], [Status]) VALUES (39, 12, N'M', 100000, 1)
INSERT [dbo].[Option] ([ID], [FoodID], [Size], [Price], [Status]) VALUES (40, 14, N'S', 100000, 1)
INSERT [dbo].[Option] ([ID], [FoodID], [Size], [Price], [Status]) VALUES (41, 14, N'M', 100000, 1)
INSERT [dbo].[Option] ([ID], [FoodID], [Size], [Price], [Status]) VALUES (42, 14, N'L', 100000, 1)
INSERT [dbo].[Option] ([ID], [FoodID], [Size], [Price], [Status]) VALUES (43, 15, N'S', 100000, 1)
INSERT [dbo].[Option] ([ID], [FoodID], [Size], [Price], [Status]) VALUES (44, 15, N'M', 100000, 1)
INSERT [dbo].[Option] ([ID], [FoodID], [Size], [Price], [Status]) VALUES (45, 15, N'L', 100000, 1)
INSERT [dbo].[Option] ([ID], [FoodID], [Size], [Price], [Status]) VALUES (46, 16, N'S', 100000, 1)
INSERT [dbo].[Option] ([ID], [FoodID], [Size], [Price], [Status]) VALUES (47, 16, N'M', 100000, 1)
INSERT [dbo].[Option] ([ID], [FoodID], [Size], [Price], [Status]) VALUES (48, 16, N'L', 100000, 1)
INSERT [dbo].[Option] ([ID], [FoodID], [Size], [Price], [Status]) VALUES (49, 17, N'S', 100000, 1)
INSERT [dbo].[Option] ([ID], [FoodID], [Size], [Price], [Status]) VALUES (50, 17, N'M', 100000, 1)
INSERT [dbo].[Option] ([ID], [FoodID], [Size], [Price], [Status]) VALUES (51, 17, N'L', 100000, 1)
INSERT [dbo].[Option] ([ID], [FoodID], [Size], [Price], [Status]) VALUES (52, 18, N'S', 100000, 1)
INSERT [dbo].[Option] ([ID], [FoodID], [Size], [Price], [Status]) VALUES (53, 18, N'M', 100000, 1)
INSERT [dbo].[Option] ([ID], [FoodID], [Size], [Price], [Status]) VALUES (54, 18, N'L', 100000, 1)
INSERT [dbo].[Option] ([ID], [FoodID], [Size], [Price], [Status]) VALUES (55, 19, N'S', 100000, 1)
INSERT [dbo].[Option] ([ID], [FoodID], [Size], [Price], [Status]) VALUES (56, 19, N'M', 100000, 1)
INSERT [dbo].[Option] ([ID], [FoodID], [Size], [Price], [Status]) VALUES (57, 19, N'L', 100000, 1)
INSERT [dbo].[Option] ([ID], [FoodID], [Size], [Price], [Status]) VALUES (58, 20, N'S', 100000, 1)
INSERT [dbo].[Option] ([ID], [FoodID], [Size], [Price], [Status]) VALUES (59, 20, N'M', 100000, 1)
INSERT [dbo].[Option] ([ID], [FoodID], [Size], [Price], [Status]) VALUES (60, 20, N'L', 100000, 1)
INSERT [dbo].[Option] ([ID], [FoodID], [Size], [Price], [Status]) VALUES (61, 21, N'S', 100000, 1)
INSERT [dbo].[Option] ([ID], [FoodID], [Size], [Price], [Status]) VALUES (62, 21, N'M', 100000, 1)
INSERT [dbo].[Option] ([ID], [FoodID], [Size], [Price], [Status]) VALUES (63, 21, N'L', 100000, 1)
INSERT [dbo].[Option] ([ID], [FoodID], [Size], [Price], [Status]) VALUES (64, 22, N'S', 100000, 1)
INSERT [dbo].[Option] ([ID], [FoodID], [Size], [Price], [Status]) VALUES (65, 22, N'M', 100000, 1)
INSERT [dbo].[Option] ([ID], [FoodID], [Size], [Price], [Status]) VALUES (66, 22, N'L', 100000, 1)
INSERT [dbo].[Option] ([ID], [FoodID], [Size], [Price], [Status]) VALUES (67, 23, N'S', 100000, 1)
INSERT [dbo].[Option] ([ID], [FoodID], [Size], [Price], [Status]) VALUES (68, 23, N'M', 100000, 1)
INSERT [dbo].[Option] ([ID], [FoodID], [Size], [Price], [Status]) VALUES (69, 23, N'L', 100000, 1)
INSERT [dbo].[Option] ([ID], [FoodID], [Size], [Price], [Status]) VALUES (70, 24, N'S', 100000, 1)
INSERT [dbo].[Option] ([ID], [FoodID], [Size], [Price], [Status]) VALUES (71, 24, N'M', 100000, 1)
INSERT [dbo].[Option] ([ID], [FoodID], [Size], [Price], [Status]) VALUES (72, 24, N'L', 100000, 1)
INSERT [dbo].[Option] ([ID], [FoodID], [Size], [Price], [Status]) VALUES (73, 25, N'S', 100000, 1)
INSERT [dbo].[Option] ([ID], [FoodID], [Size], [Price], [Status]) VALUES (74, 25, N'M', 100000, 1)
INSERT [dbo].[Option] ([ID], [FoodID], [Size], [Price], [Status]) VALUES (75, 25, N'L', 100000, 1)
INSERT [dbo].[Option] ([ID], [FoodID], [Size], [Price], [Status]) VALUES (76, 26, N'S', 100000, 1)
INSERT [dbo].[Option] ([ID], [FoodID], [Size], [Price], [Status]) VALUES (77, 26, N'M', 100000, 1)
INSERT [dbo].[Option] ([ID], [FoodID], [Size], [Price], [Status]) VALUES (78, 26, N'L', 100000, 1)
INSERT [dbo].[Option] ([ID], [FoodID], [Size], [Price], [Status]) VALUES (79, 27, N'S', 100000, 1)
INSERT [dbo].[Option] ([ID], [FoodID], [Size], [Price], [Status]) VALUES (80, 27, N'M', 100000, 1)
INSERT [dbo].[Option] ([ID], [FoodID], [Size], [Price], [Status]) VALUES (81, 27, N'L', 100000, 1)
INSERT [dbo].[Option] ([ID], [FoodID], [Size], [Price], [Status]) VALUES (82, 28, N'S', 100000, 1)
INSERT [dbo].[Option] ([ID], [FoodID], [Size], [Price], [Status]) VALUES (83, 28, N'M', 100000, 1)
INSERT [dbo].[Option] ([ID], [FoodID], [Size], [Price], [Status]) VALUES (84, 28, N'L', 100000, 1)
INSERT [dbo].[Option] ([ID], [FoodID], [Size], [Price], [Status]) VALUES (85, 29, N'S', 100000, 1)
INSERT [dbo].[Option] ([ID], [FoodID], [Size], [Price], [Status]) VALUES (86, 29, N'M', 100000, 1)
INSERT [dbo].[Option] ([ID], [FoodID], [Size], [Price], [Status]) VALUES (87, 29, N'L', 100000, 1)
INSERT [dbo].[Option] ([ID], [FoodID], [Size], [Price], [Status]) VALUES (88, 30, N'S', 100000, 1)
INSERT [dbo].[Option] ([ID], [FoodID], [Size], [Price], [Status]) VALUES (89, 30, N'M', 100000, 1)
INSERT [dbo].[Option] ([ID], [FoodID], [Size], [Price], [Status]) VALUES (90, 30, N'L', 100000, 1)
SET IDENTITY_INSERT [dbo].[Option] OFF
GO
SET IDENTITY_INSERT [dbo].[Table] ON 

INSERT [dbo].[Table] ([TableId], [TableName], [Status]) VALUES (1, N'1', 0)
INSERT [dbo].[Table] ([TableId], [TableName], [Status]) VALUES (2, N'2', 0)
INSERT [dbo].[Table] ([TableId], [TableName], [Status]) VALUES (3, N'3', 0)
INSERT [dbo].[Table] ([TableId], [TableName], [Status]) VALUES (4, N'4', 0)
INSERT [dbo].[Table] ([TableId], [TableName], [Status]) VALUES (5, N'5', 0)
INSERT [dbo].[Table] ([TableId], [TableName], [Status]) VALUES (6, N'6', 0)
INSERT [dbo].[Table] ([TableId], [TableName], [Status]) VALUES (7, N'7', 0)
INSERT [dbo].[Table] ([TableId], [TableName], [Status]) VALUES (8, N'8', 0)
INSERT [dbo].[Table] ([TableId], [TableName], [Status]) VALUES (9, N'9', 0)
INSERT [dbo].[Table] ([TableId], [TableName], [Status]) VALUES (10, N'10', 0)
INSERT [dbo].[Table] ([TableId], [TableName], [Status]) VALUES (11, N'11', 0)
INSERT [dbo].[Table] ([TableId], [TableName], [Status]) VALUES (12, N'12', 0)
INSERT [dbo].[Table] ([TableId], [TableName], [Status]) VALUES (13, N'13', 0)
INSERT [dbo].[Table] ([TableId], [TableName], [Status]) VALUES (14, N'14', 0)
INSERT [dbo].[Table] ([TableId], [TableName], [Status]) VALUES (15, N'15', 0)
INSERT [dbo].[Table] ([TableId], [TableName], [Status]) VALUES (16, N'16', 0)
INSERT [dbo].[Table] ([TableId], [TableName], [Status]) VALUES (17, N'17', 0)
INSERT [dbo].[Table] ([TableId], [TableName], [Status]) VALUES (18, N'18', 0)
INSERT [dbo].[Table] ([TableId], [TableName], [Status]) VALUES (19, N'19', 0)
INSERT [dbo].[Table] ([TableId], [TableName], [Status]) VALUES (20, N'20', 0)
INSERT [dbo].[Table] ([TableId], [TableName], [Status]) VALUES (21, N'21', 0)
INSERT [dbo].[Table] ([TableId], [TableName], [Status]) VALUES (22, N'22', 0)
INSERT [dbo].[Table] ([TableId], [TableName], [Status]) VALUES (23, N'23', 0)
INSERT [dbo].[Table] ([TableId], [TableName], [Status]) VALUES (24, N'24', 0)
INSERT [dbo].[Table] ([TableId], [TableName], [Status]) VALUES (25, N'25', 0)
INSERT [dbo].[Table] ([TableId], [TableName], [Status]) VALUES (26, N'26', 0)
INSERT [dbo].[Table] ([TableId], [TableName], [Status]) VALUES (27, N'27', 0)
INSERT [dbo].[Table] ([TableId], [TableName], [Status]) VALUES (28, N'28', 0)
INSERT [dbo].[Table] ([TableId], [TableName], [Status]) VALUES (29, N'29', 0)
INSERT [dbo].[Table] ([TableId], [TableName], [Status]) VALUES (30, N'30', 0)
SET IDENTITY_INSERT [dbo].[Table] OFF
GO
SET IDENTITY_INSERT [dbo].[User] ON 

INSERT [dbo].[User] ([UserId], [UserName], [Password], [FullName], [Gender], [DOB], [Address], [Mobile], [Avatar], [RoleID]) VALUES (2, N'admin', N'admin', N'Phúc', 1, CAST(N'2001-07-22T00:00:00' AS SmallDateTime), N'BAC NINH', N'012314224', NULL, 1)
INSERT [dbo].[User] ([UserId], [UserName], [Password], [FullName], [Gender], [DOB], [Address], [Mobile], [Avatar], [RoleID]) VALUES (3, N'sa', N'sa', N'sa', 0, CAST(N'2001-07-22T00:00:00' AS SmallDateTime), N'HA NOI', N'012321331', NULL, 0)
INSERT [dbo].[User] ([UserId], [UserName], [Password], [FullName], [Gender], [DOB], [Address], [Mobile], [Avatar], [RoleID]) VALUES (4, N'user1', N'123', N'asadada', 1, CAST(N'2001-07-22T00:00:00' AS SmallDateTime), N'HA NOI', N'01313572', NULL, 0)
SET IDENTITY_INSERT [dbo].[User] OFF
GO
ALTER TABLE [dbo].[Bill]  WITH CHECK ADD  CONSTRAINT [FK_TABLE] FOREIGN KEY([TableID])
REFERENCES [dbo].[Table] ([TableId])
GO
ALTER TABLE [dbo].[Bill] CHECK CONSTRAINT [FK_TABLE]
GO
ALTER TABLE [dbo].[BillDetail]  WITH CHECK ADD  CONSTRAINT [FK_BILL] FOREIGN KEY([BillID])
REFERENCES [dbo].[Bill] ([BillID])
GO
ALTER TABLE [dbo].[BillDetail] CHECK CONSTRAINT [FK_BILL]
GO
ALTER TABLE [dbo].[BillDetail]  WITH CHECK ADD  CONSTRAINT [FK_FOOD_2] FOREIGN KEY([FoodID])
REFERENCES [dbo].[Food] ([FoodID])
GO
ALTER TABLE [dbo].[BillDetail] CHECK CONSTRAINT [FK_FOOD_2]
GO
ALTER TABLE [dbo].[Food]  WITH CHECK ADD  CONSTRAINT [FK_CATEGORY] FOREIGN KEY([CategoryID])
REFERENCES [dbo].[Category] ([CategoryID])
GO
ALTER TABLE [dbo].[Food] CHECK CONSTRAINT [FK_CATEGORY]
GO
ALTER TABLE [dbo].[Option]  WITH CHECK ADD  CONSTRAINT [FK_FOOD_1] FOREIGN KEY([FoodID])
REFERENCES [dbo].[Food] ([FoodID])
GO
ALTER TABLE [dbo].[Option] CHECK CONSTRAINT [FK_FOOD_1]
GO
USE [master]
GO
ALTER DATABASE [PRN211] SET  READ_WRITE 
GO
