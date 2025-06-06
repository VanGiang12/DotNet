USE [master]
GO
/****** Object:  Database [tbqltv]    Script Date: 5/22/2024 11:00:55 PM ******/
CREATE DATABASE [tbqltv]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'tbqltv', FILENAME = N'D:\SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\tbqltv.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'tbqltv_log', FILENAME = N'D:\SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\tbqltv_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [tbqltv] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [tbqltv].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [tbqltv] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [tbqltv] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [tbqltv] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [tbqltv] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [tbqltv] SET ARITHABORT OFF 
GO
ALTER DATABASE [tbqltv] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [tbqltv] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [tbqltv] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [tbqltv] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [tbqltv] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [tbqltv] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [tbqltv] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [tbqltv] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [tbqltv] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [tbqltv] SET  DISABLE_BROKER 
GO
ALTER DATABASE [tbqltv] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [tbqltv] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [tbqltv] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [tbqltv] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [tbqltv] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [tbqltv] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [tbqltv] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [tbqltv] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [tbqltv] SET  MULTI_USER 
GO
ALTER DATABASE [tbqltv] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [tbqltv] SET DB_CHAINING OFF 
GO
ALTER DATABASE [tbqltv] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [tbqltv] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [tbqltv] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [tbqltv] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [tbqltv] SET QUERY_STORE = ON
GO
ALTER DATABASE [tbqltv] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [tbqltv]
GO
/****** Object:  Table [dbo].[Admin]    Script Date: 5/22/2024 11:00:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Admin](
	[ID] [nchar](10) NOT NULL,
	[username] [nchar](20) NOT NULL,
	[pass] [nchar](20) NOT NULL,
 CONSTRAINT [PK_Admin] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[datsach]    Script Date: 5/22/2024 11:00:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[datsach](
	[madat] [nchar](10) NOT NULL,
	[masach] [nvarchar](10) NULL,
	[maphieumua] [nvarchar](10) NULL,
	[tensach] [nvarchar](50) NULL,
	[soluong] [int] NULL,
 CONSTRAINT [PK_datsach] PRIMARY KEY CLUSTERED 
(
	[madat] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[docgia]    Script Date: 5/22/2024 11:00:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[docgia](
	[madocgia] [nvarchar](10) NOT NULL,
	[password] [nchar](20) NULL,
	[ten] [nvarchar](50) NULL,
	[ngaysinh] [datetime] NULL,
	[gioitinh] [nvarchar](50) NULL,
	[loaidocgia] [nvarchar](50) NULL,
	[khoa] [nvarchar](50) NULL,
	[diachi] [nvarchar](50) NULL,
	[sothe] [nvarchar](50) NULL,
 CONSTRAINT [PK_docgia] PRIMARY KEY CLUSTERED 
(
	[madocgia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[muasach]    Script Date: 5/22/2024 11:00:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[muasach](
	[maphieumua] [nvarchar](10) NOT NULL,
	[donvimua] [nvarchar](50) NULL,
	[manhaxuatban] [nvarchar](10) NULL,
	[ngaymua] [datetime] NULL,
 CONSTRAINT [PK_muasach_1] PRIMARY KEY CLUSTERED 
(
	[maphieumua] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[muontra]    Script Date: 5/22/2024 11:00:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[muontra](
	[maphieumuon] [nvarchar](10) NOT NULL,
	[madocgia] [nvarchar](10) NULL,
	[masach] [nvarchar](10) NULL,
	[soluongmuon] [int] NULL,
	[ngaymuon] [datetime] NULL,
	[ngayhentra] [datetime] NULL,
	[ngaytra] [datetime] NULL,
 CONSTRAINT [PK_muontra] PRIMARY KEY CLUSTERED 
(
	[maphieumuon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[nhaxuatban]    Script Date: 5/22/2024 11:00:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[nhaxuatban](
	[manhaxuatban] [nvarchar](10) NOT NULL,
	[tennhaxuatban] [nvarchar](50) NULL,
	[lienhe] [nvarchar](50) NULL,
 CONSTRAINT [PK_nhaxuatban] PRIMARY KEY CLUSTERED 
(
	[manhaxuatban] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[sach]    Script Date: 5/22/2024 11:00:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sach](
	[masach] [nvarchar](10) NOT NULL,
	[tensach] [nvarchar](50) NULL,
	[hinhanh] [nvarchar](max) NULL,
	[khoa] [nvarchar](50) NULL,
	[matacgia] [nvarchar](10) NULL,
	[matheloai] [nvarchar](10) NULL,
	[manhaxuatban] [nvarchar](10) NULL,
	[soluong] [int] NULL,
	[namxuatban] [nvarchar](10) NULL,
 CONSTRAINT [PK_sach] PRIMARY KEY CLUSTERED 
(
	[masach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tacgia]    Script Date: 5/22/2024 11:00:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tacgia](
	[matacgia] [nvarchar](10) NOT NULL,
	[tentacgia] [nvarchar](50) NULL,
	[lienhe] [nvarchar](50) NULL,
 CONSTRAINT [PK_tacgia] PRIMARY KEY CLUSTERED 
(
	[matacgia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[theloai]    Script Date: 5/22/2024 11:00:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[theloai](
	[matheloai] [nvarchar](10) NOT NULL,
	[tentheloai] [nvarchar](50) NULL,
 CONSTRAINT [PK_theloai] PRIMARY KEY CLUSTERED 
(
	[matheloai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Admin] ([ID], [username], [pass]) VALUES (N'1         ', N'admin               ', N'123                 ')
GO
INSERT [dbo].[datsach] ([madat], [masach], [maphieumua], [tensach], [soluong]) VALUES (N'MD01      ', N'001', N'MP01', N'conan', 3)
INSERT [dbo].[datsach] ([madat], [masach], [maphieumua], [tensach], [soluong]) VALUES (N'MD02      ', N'002', N'MP02', N'doraemon', 3)
INSERT [dbo].[datsach] ([madat], [masach], [maphieumua], [tensach], [soluong]) VALUES (N'MD03      ', N'003', N'MP03', N'shin', 3)
INSERT [dbo].[datsach] ([madat], [masach], [maphieumua], [tensach], [soluong]) VALUES (N'MD04      ', N'004', N'MP04', N'conan', 9)
INSERT [dbo].[datsach] ([madat], [masach], [maphieumua], [tensach], [soluong]) VALUES (N'MD05      ', N'005', N'MP05', N'olala', 3)
INSERT [dbo].[datsach] ([madat], [masach], [maphieumua], [tensach], [soluong]) VALUES (N'MD14      ', N'003', N'MP05', N'conan', 2)
INSERT [dbo].[datsach] ([madat], [masach], [maphieumua], [tensach], [soluong]) VALUES (N'MD34      ', N'002', N'MP09', N'conan', 5)
INSERT [dbo].[datsach] ([madat], [masach], [maphieumua], [tensach], [soluong]) VALUES (N'MD44      ', N'004', N'MP03', N'conan', 2)
GO
INSERT [dbo].[docgia] ([madocgia], [password], [ten], [ngaysinh], [gioitinh], [loaidocgia], [khoa], [diachi], [sothe]) VALUES (N'001', N'123                 ', N'edogawa', CAST(N'2024-05-05T00:00:00.000' AS DateTime), N'nữ', N'Sinh Viên', N'cntt', N'tb', N'2542')
INSERT [dbo].[docgia] ([madocgia], [password], [ten], [ngaysinh], [gioitinh], [loaidocgia], [khoa], [diachi], [sothe]) VALUES (N'002', N'123                 ', N'nosuke', CAST(N'2024-06-06T00:00:00.000' AS DateTime), N'nữ', N'Sinh Viên', N'cntt', N'tb', N'5864')
INSERT [dbo].[docgia] ([madocgia], [password], [ten], [ngaysinh], [gioitinh], [loaidocgia], [khoa], [diachi], [sothe]) VALUES (N'003', N'123                 ', N'tý', CAST(N'2024-06-07T00:00:00.000' AS DateTime), N'nam', N'Sinh Viên', N'cntt', N'tb', N'9869')
INSERT [dbo].[docgia] ([madocgia], [password], [ten], [ngaysinh], [gioitinh], [loaidocgia], [khoa], [diachi], [sothe]) VALUES (N'004', N'123                 ', N'tèo', CAST(N'2024-08-09T00:00:00.000' AS DateTime), N'nam', N'Giảng Viên', N'cntt', N'tb', N'8724')
INSERT [dbo].[docgia] ([madocgia], [password], [ten], [ngaysinh], [gioitinh], [loaidocgia], [khoa], [diachi], [sothe]) VALUES (N'005', N'123                 ', N'anh', CAST(N'2024-08-09T00:00:00.000' AS DateTime), N'nam', N'Sinh Viên', N'cntt', N'tb', N'0398')
GO
INSERT [dbo].[muasach] ([maphieumua], [donvimua], [manhaxuatban], [ngaymua]) VALUES (N'MP01', N'uneti', N'001', CAST(N'2024-02-04T00:00:00.000' AS DateTime))
INSERT [dbo].[muasach] ([maphieumua], [donvimua], [manhaxuatban], [ngaymua]) VALUES (N'MP02', N'uneti', N'002', CAST(N'2024-03-03T00:00:00.000' AS DateTime))
INSERT [dbo].[muasach] ([maphieumua], [donvimua], [manhaxuatban], [ngaymua]) VALUES (N'MP03', N'uneti', N'003', CAST(N'2024-05-03T00:00:00.000' AS DateTime))
INSERT [dbo].[muasach] ([maphieumua], [donvimua], [manhaxuatban], [ngaymua]) VALUES (N'MP04', N'uneti', N'004', CAST(N'2024-03-12T00:00:00.000' AS DateTime))
INSERT [dbo].[muasach] ([maphieumua], [donvimua], [manhaxuatban], [ngaymua]) VALUES (N'MP05', N'uneti', N'005', CAST(N'2024-03-01T00:00:00.000' AS DateTime))
INSERT [dbo].[muasach] ([maphieumua], [donvimua], [manhaxuatban], [ngaymua]) VALUES (N'MP09', N'uneti', N'006', CAST(N'2024-05-14T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[muontra] ([maphieumuon], [madocgia], [masach], [soluongmuon], [ngaymuon], [ngayhentra], [ngaytra]) VALUES (N'001', N'002', N'003', 1, CAST(N'2024-05-08T00:00:00.000' AS DateTime), CAST(N'2024-05-22T00:00:00.000' AS DateTime), CAST(N'2024-05-22T00:00:00.000' AS DateTime))
INSERT [dbo].[muontra] ([maphieumuon], [madocgia], [masach], [soluongmuon], [ngaymuon], [ngayhentra], [ngaytra]) VALUES (N'002', N'002', N'004', 10, CAST(N'2024-04-30T00:00:00.000' AS DateTime), CAST(N'2024-05-02T00:00:00.000' AS DateTime), CAST(N'2024-05-02T00:00:00.000' AS DateTime))
INSERT [dbo].[muontra] ([maphieumuon], [madocgia], [masach], [soluongmuon], [ngaymuon], [ngayhentra], [ngaytra]) VALUES (N'003', N'003', N'001', 8, CAST(N'2024-04-29T00:00:00.000' AS DateTime), CAST(N'2024-05-08T00:00:00.000' AS DateTime), CAST(N'2024-05-08T00:00:00.000' AS DateTime))
INSERT [dbo].[muontra] ([maphieumuon], [madocgia], [masach], [soluongmuon], [ngaymuon], [ngayhentra], [ngaytra]) VALUES (N'004', N'004', N'003', 3, CAST(N'2024-05-01T00:00:00.000' AS DateTime), CAST(N'2024-05-15T00:00:00.000' AS DateTime), CAST(N'2024-05-15T00:00:00.000' AS DateTime))
INSERT [dbo].[muontra] ([maphieumuon], [madocgia], [masach], [soluongmuon], [ngaymuon], [ngayhentra], [ngaytra]) VALUES (N'005', N'004', N'001', 8, CAST(N'2024-05-10T00:00:00.000' AS DateTime), CAST(N'2024-05-15T00:00:00.000' AS DateTime), CAST(N'2024-05-17T00:00:00.000' AS DateTime))
INSERT [dbo].[muontra] ([maphieumuon], [madocgia], [masach], [soluongmuon], [ngaymuon], [ngayhentra], [ngaytra]) VALUES (N'006', N'003', N'001', 8, CAST(N'2024-04-29T00:00:00.000' AS DateTime), CAST(N'2024-05-08T00:00:00.000' AS DateTime), NULL)
GO
INSERT [dbo].[nhaxuatban] ([manhaxuatban], [tennhaxuatban], [lienhe]) VALUES (N'001', N'Hồng Hà', N'0989874637')
INSERT [dbo].[nhaxuatban] ([manhaxuatban], [tennhaxuatban], [lienhe]) VALUES (N'002', N'Hoàng Hà', N'HH@ gmail.com')
INSERT [dbo].[nhaxuatban] ([manhaxuatban], [tennhaxuatban], [lienhe]) VALUES (N'003', N'Nam Định', N'0392847367')
INSERT [dbo].[nhaxuatban] ([manhaxuatban], [tennhaxuatban], [lienhe]) VALUES (N'004', N'Hải Nam', N'HN@ gmail.com')
INSERT [dbo].[nhaxuatban] ([manhaxuatban], [tennhaxuatban], [lienhe]) VALUES (N'005', N'Quang Nam', N'0989878963')
INSERT [dbo].[nhaxuatban] ([manhaxuatban], [tennhaxuatban], [lienhe]) VALUES (N'006', N'Kim Đồng', N'KD@gmail.com')
GO
INSERT [dbo].[sach] ([masach], [tensach], [hinhanh], [khoa], [matacgia], [matheloai], [manhaxuatban], [soluong], [namxuatban]) VALUES (N'001', N'conan', N'C:\Users\HP\OneDrive\Hình ảnh\CaRo - Copy.png', N'trinh thám', N'001', N'001', N'001', 88, N'2009')
INSERT [dbo].[sach] ([masach], [tensach], [hinhanh], [khoa], [matacgia], [matheloai], [manhaxuatban], [soluong], [namxuatban]) VALUES (N'002', N'doraemon', N'C:\Users\HP\OneDrive\Hình ảnh\CaRo - Copy.png', N'hài hước', N'002', N'002', N'004', 722, N'2099')
INSERT [dbo].[sach] ([masach], [tensach], [hinhanh], [khoa], [matacgia], [matheloai], [manhaxuatban], [soluong], [namxuatban]) VALUES (N'003', N'shin', N'C:\Users\HP\OneDrive\Hình ảnh\CaRo - Copy.png', N'unknow', N'003', N'005', N'003', 9, N'2099')
INSERT [dbo].[sach] ([masach], [tensach], [hinhanh], [khoa], [matacgia], [matheloai], [manhaxuatban], [soluong], [namxuatban]) VALUES (N'004', N'tý quậy', N'C:\Users\HP\OneDrive\Hình ảnh\CaRo - Copy.png', N'cntt', N'002', N'004', N'004', 88, N'2009')
INSERT [dbo].[sach] ([masach], [tensach], [hinhanh], [khoa], [matacgia], [matheloai], [manhaxuatban], [soluong], [namxuatban]) VALUES (N'005', N'Ô long viện', N'C:\Users\HP\OneDrive\Hình ảnh\CaRo - Copy.png', N'unknow', N'001', N'005', N'005', 99, N'2099')
GO
INSERT [dbo].[tacgia] ([matacgia], [tentacgia], [lienhe]) VALUES (N'001', N'edogawa', N'123456789')
INSERT [dbo].[tacgia] ([matacgia], [tentacgia], [lienhe]) VALUES (N'002', N'shin', N'123456789')
INSERT [dbo].[tacgia] ([matacgia], [tentacgia], [lienhe]) VALUES (N'003', N'a', N'123456789')
INSERT [dbo].[tacgia] ([matacgia], [tentacgia], [lienhe]) VALUES (N'004', N'b', N'123456789')
INSERT [dbo].[tacgia] ([matacgia], [tentacgia], [lienhe]) VALUES (N'005', N'l', N'Số 203, HVT, Nam Định')
INSERT [dbo].[tacgia] ([matacgia], [tentacgia], [lienhe]) VALUES (N'006', N'o', N'789876897')
INSERT [dbo].[tacgia] ([matacgia], [tentacgia], [lienhe]) VALUES (N'007', N'm', N'm@gmail.com')
INSERT [dbo].[tacgia] ([matacgia], [tentacgia], [lienhe]) VALUES (N'008', N'amk', N'8493849302')
GO
INSERT [dbo].[theloai] ([matheloai], [tentheloai]) VALUES (N'001', N'trinh thám')
INSERT [dbo].[theloai] ([matheloai], [tentheloai]) VALUES (N'002', N'hài hước')
INSERT [dbo].[theloai] ([matheloai], [tentheloai]) VALUES (N'003', N'không buồn')
INSERT [dbo].[theloai] ([matheloai], [tentheloai]) VALUES (N'004', N'vui vẻ')
INSERT [dbo].[theloai] ([matheloai], [tentheloai]) VALUES (N'005', N'vui tươi')
INSERT [dbo].[theloai] ([matheloai], [tentheloai]) VALUES (N'006', N'okok')
GO
ALTER TABLE [dbo].[datsach]  WITH CHECK ADD  CONSTRAINT [FK_datsach_muasach1] FOREIGN KEY([maphieumua])
REFERENCES [dbo].[muasach] ([maphieumua])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[datsach] CHECK CONSTRAINT [FK_datsach_muasach1]
GO
ALTER TABLE [dbo].[muasach]  WITH CHECK ADD  CONSTRAINT [FK_muasach_nhaxuatban] FOREIGN KEY([manhaxuatban])
REFERENCES [dbo].[nhaxuatban] ([manhaxuatban])
ON UPDATE SET NULL
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[muasach] CHECK CONSTRAINT [FK_muasach_nhaxuatban]
GO
ALTER TABLE [dbo].[muontra]  WITH CHECK ADD  CONSTRAINT [FK_muontra_docgia] FOREIGN KEY([madocgia])
REFERENCES [dbo].[docgia] ([madocgia])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[muontra] CHECK CONSTRAINT [FK_muontra_docgia]
GO
ALTER TABLE [dbo].[muontra]  WITH CHECK ADD  CONSTRAINT [FK_muontra_sach] FOREIGN KEY([masach])
REFERENCES [dbo].[sach] ([masach])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[muontra] CHECK CONSTRAINT [FK_muontra_sach]
GO
ALTER TABLE [dbo].[sach]  WITH CHECK ADD  CONSTRAINT [FK_sach_nhaxuatban] FOREIGN KEY([manhaxuatban])
REFERENCES [dbo].[nhaxuatban] ([manhaxuatban])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[sach] CHECK CONSTRAINT [FK_sach_nhaxuatban]
GO
ALTER TABLE [dbo].[sach]  WITH CHECK ADD  CONSTRAINT [FK_sach_tacgia] FOREIGN KEY([matacgia])
REFERENCES [dbo].[tacgia] ([matacgia])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[sach] CHECK CONSTRAINT [FK_sach_tacgia]
GO
ALTER TABLE [dbo].[sach]  WITH CHECK ADD  CONSTRAINT [FK_sach_theloai] FOREIGN KEY([matheloai])
REFERENCES [dbo].[theloai] ([matheloai])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[sach] CHECK CONSTRAINT [FK_sach_theloai]
GO
USE [master]
GO
ALTER DATABASE [tbqltv] SET  READ_WRITE 
GO
