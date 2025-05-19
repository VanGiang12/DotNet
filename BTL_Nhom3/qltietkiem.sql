USE [master]
GO
/****** Object:  Database [QUANLYTIETKIEM]    Script Date: 11/21/2024 4:18:11 PM ******/
CREATE DATABASE [QUANLYTIETKIEM]

GO
ALTER DATABASE [QUANLYTIETKIEM] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QUANLYTIETKIEM].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QUANLYTIETKIEM] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QUANLYTIETKIEM] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QUANLYTIETKIEM] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QUANLYTIETKIEM] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QUANLYTIETKIEM] SET ARITHABORT OFF 
GO
ALTER DATABASE [QUANLYTIETKIEM] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QUANLYTIETKIEM] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QUANLYTIETKIEM] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QUANLYTIETKIEM] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QUANLYTIETKIEM] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QUANLYTIETKIEM] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QUANLYTIETKIEM] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QUANLYTIETKIEM] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QUANLYTIETKIEM] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QUANLYTIETKIEM] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QUANLYTIETKIEM] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QUANLYTIETKIEM] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QUANLYTIETKIEM] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QUANLYTIETKIEM] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QUANLYTIETKIEM] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QUANLYTIETKIEM] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QUANLYTIETKIEM] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QUANLYTIETKIEM] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QUANLYTIETKIEM] SET  MULTI_USER 
GO
ALTER DATABASE [QUANLYTIETKIEM] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QUANLYTIETKIEM] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QUANLYTIETKIEM] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QUANLYTIETKIEM] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QUANLYTIETKIEM] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QUANLYTIETKIEM] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [QUANLYTIETKIEM] SET QUERY_STORE = ON
GO
ALTER DATABASE [QUANLYTIETKIEM] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [QUANLYTIETKIEM]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 11/21/2024 4:18:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKH] [nvarchar](15) NOT NULL,
	[HoTenKH] [nvarchar](50) NULL,
	[CMND] [nchar](15) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[SDT] [nchar](15) NULL,
 CONSTRAINT [PK_KhachHang] PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiSoTietKiem]    Script Date: 11/21/2024 4:18:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiSoTietKiem](
	[MaLoaiSo] [nvarchar](15) NOT NULL,
	[TenLoaiSo] [nvarchar](50) NULL,
	[LaiSuatThang] [decimal](5, 3) NULL,
	[SoThang] [int] NULL,
 CONSTRAINT [PK_LoaiSoTietKiem] PRIMARY KEY CLUSTERED 
(
	[MaLoaiSo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 11/21/2024 4:18:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNV] [nvarchar](15) NOT NULL,
	[HoTenNV] [nvarchar](50) NULL,
	[NgaySinh] [date] NULL,
	[SDT] [nchar](15) NULL,
	[MatKhau] [nvarchar](30) NULL,
	[LoaiNguoiDung] [int] NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhanLoaiNguoiDung]    Script Date: 11/21/2024 4:18:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhanLoaiNguoiDung](
	[MaND] [int] NOT NULL,
	[TenLoaiNguoiDung] [nvarchar](50) NULL,
 CONSTRAINT [PK_PhanLoaiNguoiDung] PRIMARY KEY CLUSTERED 
(
	[MaND] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SoTietKiem]    Script Date: 11/21/2024 4:18:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SoTietKiem](
	[MaSTK] [nvarchar](15) NOT NULL,
	[MaNV] [nvarchar](15) NULL,
	[MaKH] [nvarchar](15) NULL,
	[MaLoaiSo] [nvarchar](15) NULL,
	[NgayMoSo] [date] NULL,
	[NgayDenHan] [date] NULL,
	[SoTienGui] [int] NULL,
	[NgayRut] [date] NULL,
	[SoTienRut] [decimal](18, 2) NULL,
	[TrangThaiSo] [bit] NULL,
 CONSTRAINT [PK_SoTietKiem] PRIMARY KEY CLUSTERED 
(
	[MaSTK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[KhachHang] ([MaKH], [HoTenKH], [CMND], [DiaChi], [SDT]) VALUES (N'KH001', N'Tạ Vân', N'034303006497   ', N'Hà Nội', N'0987654321     ')
INSERT [dbo].[KhachHang] ([MaKH], [HoTenKH], [CMND], [DiaChi], [SDT]) VALUES (N'KH002', N'Trần Văn Bình', N'034303009874   ', N'Hải Phòng', N'0988765432     ')
INSERT [dbo].[KhachHang] ([MaKH], [HoTenKH], [CMND], [DiaChi], [SDT]) VALUES (N'KH003', N'Lê Văn Dự', N'034303006491   ', N'Hà Nội', N'0934567890     ')
INSERT [dbo].[KhachHang] ([MaKH], [HoTenKH], [CMND], [DiaChi], [SDT]) VALUES (N'KH004', N'Phạm Thị Quỳnh', N'034303006492   ', N'Hồ Chí Minh', N'0912345679     ')
INSERT [dbo].[KhachHang] ([MaKH], [HoTenKH], [CMND], [DiaChi], [SDT]) VALUES (N'KH005', N'Trương Văn Phương', N'345678901234   ', N'Đà Nẵng', N'0909876543     ')
INSERT [dbo].[KhachHang] ([MaKH], [HoTenKH], [CMND], [DiaChi], [SDT]) VALUES (N'KH006', N'Nguyễn Thị G', N'456789012345   ', N'Hải Dương', N'0931122334     ')
INSERT [dbo].[KhachHang] ([MaKH], [HoTenKH], [CMND], [DiaChi], [SDT]) VALUES (N'KH007', N'Lý Văn H', N'567890123456   ', N'Huế', N'0942233445     ')
INSERT [dbo].[KhachHang] ([MaKH], [HoTenKH], [CMND], [DiaChi], [SDT]) VALUES (N'KH008', N'Hoàng Anh Lương', N'678901234567   ', N'Hà Nam', N'0953344556     ')
INSERT [dbo].[KhachHang] ([MaKH], [HoTenKH], [CMND], [DiaChi], [SDT]) VALUES (N'KH009', N'Lê Văn Linh', N'123456789012   ', N'Hà Nội', N'0934567890     ')
INSERT [dbo].[KhachHang] ([MaKH], [HoTenKH], [CMND], [DiaChi], [SDT]) VALUES (N'KH010', N'Phạm Thị M', N'234567890123   ', N'Hồ Chí Minh', N'0912345679     ')
INSERT [dbo].[KhachHang] ([MaKH], [HoTenKH], [CMND], [DiaChi], [SDT]) VALUES (N'KH011', N'Tạ Vân', N'034303006498   ', N'Thái Bình', N'0336908843     ')
INSERT [dbo].[KhachHang] ([MaKH], [HoTenKH], [CMND], [DiaChi], [SDT]) VALUES (N'KH012', N'Nguyễn Văn Giang', N'012345678902   ', N'Hưng Yên', N'0807900812     ')
INSERT [dbo].[KhachHang] ([MaKH], [HoTenKH], [CMND], [DiaChi], [SDT]) VALUES (N'KH013', N'Hoàng Mạnh Linh', N'034303006401   ', N'Hải Dương', N'0336907769     ')
INSERT [dbo].[KhachHang] ([MaKH], [HoTenKH], [CMND], [DiaChi], [SDT]) VALUES (N'KH014', N'Nguyễn Tiến Mạnh', N'034303006499   ', N'Hải Phòng', N'0563547908     ')
INSERT [dbo].[KhachHang] ([MaKH], [HoTenKH], [CMND], [DiaChi], [SDT]) VALUES (N'KH015', N'Trần Mạnh Nam', N'034303006391   ', N'Hà Nội', N'0336907784     ')
INSERT [dbo].[KhachHang] ([MaKH], [HoTenKH], [CMND], [DiaChi], [SDT]) VALUES (N'KH016', N'Nguyễn Văn Hưng', N'034303006290   ', N'Thái Bình', N'0336512346     ')
INSERT [dbo].[KhachHang] ([MaKH], [HoTenKH], [CMND], [DiaChi], [SDT]) VALUES (N'KH017', N'Hồ Văn Minh', N'034303006392   ', N'Hà Nội', N'0112314567     ')
GO
INSERT [dbo].[LoaiSoTietKiem] ([MaLoaiSo], [TenLoaiSo], [LaiSuatThang], [SoThang]) VALUES (N'LS001', N'Không kì hạn', CAST(0.001 AS Decimal(5, 3)), 0)
INSERT [dbo].[LoaiSoTietKiem] ([MaLoaiSo], [TenLoaiSo], [LaiSuatThang], [SoThang]) VALUES (N'LS002', N'3 tháng', CAST(0.002 AS Decimal(5, 3)), 3)
INSERT [dbo].[LoaiSoTietKiem] ([MaLoaiSo], [TenLoaiSo], [LaiSuatThang], [SoThang]) VALUES (N'LS003', N'6 tháng', CAST(0.003 AS Decimal(5, 3)), 6)
INSERT [dbo].[LoaiSoTietKiem] ([MaLoaiSo], [TenLoaiSo], [LaiSuatThang], [SoThang]) VALUES (N'LS004', N'9 tháng', CAST(0.004 AS Decimal(5, 3)), 9)
GO
INSERT [dbo].[NhanVien] ([MaNV], [HoTenNV], [NgaySinh], [SDT], [MatKhau], [LoaiNguoiDung]) VALUES (N'NV001', N'admin', CAST(N'1990-05-01' AS Date), N'0912345678     ', N'admin', 1)
INSERT [dbo].[NhanVien] ([MaNV], [HoTenNV], [NgaySinh], [SDT], [MatKhau], [LoaiNguoiDung]) VALUES (N'NV002', N'Lê Thị C', CAST(N'1985-09-15' AS Date), N'0923456789     ', N'C123', 2)
INSERT [dbo].[NhanVien] ([MaNV], [HoTenNV], [NgaySinh], [SDT], [MatKhau], [LoaiNguoiDung]) VALUES (N'NV003', N'Trần Văn J', CAST(N'1988-04-25' AS Date), N'0934455667     ', N'123', 2)
INSERT [dbo].[NhanVien] ([MaNV], [HoTenNV], [NgaySinh], [SDT], [MatKhau], [LoaiNguoiDung]) VALUES (N'NV004', N'Phạm Minh K', CAST(N'1992-07-17' AS Date), N'0945566778     ', N'123', 2)
INSERT [dbo].[NhanVien] ([MaNV], [HoTenNV], [NgaySinh], [SDT], [MatKhau], [LoaiNguoiDung]) VALUES (N'NV005', N'Lê Hoài L', CAST(N'1995-02-20' AS Date), N'0956677889     ', N'123', 2)
INSERT [dbo].[NhanVien] ([MaNV], [HoTenNV], [NgaySinh], [SDT], [MatKhau], [LoaiNguoiDung]) VALUES (N'NV006', N'Nguyễn Xuân M', CAST(N'1980-08-12' AS Date), N'0906788990     ', N'123', 2)
INSERT [dbo].[NhanVien] ([MaNV], [HoTenNV], [NgaySinh], [SDT], [MatKhau], [LoaiNguoiDung]) VALUES (N'NV007', N'Trịnh Thành N', CAST(N'1975-11-03' AS Date), N'0912345566     ', N'123', 2)
INSERT [dbo].[NhanVien] ([MaNV], [HoTenNV], [NgaySinh], [SDT], [MatKhau], [LoaiNguoiDung]) VALUES (N'NV008', N'Đỗ Thị O', CAST(N'1987-03-14' AS Date), N'0923456677     ', N'admin', 1)
INSERT [dbo].[NhanVien] ([MaNV], [HoTenNV], [NgaySinh], [SDT], [MatKhau], [LoaiNguoiDung]) VALUES (N'NV009', N'Nguyễn Xuân L', CAST(N'1980-08-12' AS Date), N'0906788990     ', N'123', 2)
INSERT [dbo].[NhanVien] ([MaNV], [HoTenNV], [NgaySinh], [SDT], [MatKhau], [LoaiNguoiDung]) VALUES (N'NV010', N'Trịnh Thành D', CAST(N'1975-11-03' AS Date), N'0912345566     ', N'123', 2)
INSERT [dbo].[NhanVien] ([MaNV], [HoTenNV], [NgaySinh], [SDT], [MatKhau], [LoaiNguoiDung]) VALUES (N'NV011', N'Tạ Vân', CAST(N'1980-08-12' AS Date), N'0906788991     ', N'123', 2)
GO
INSERT [dbo].[PhanLoaiNguoiDung] ([MaND], [TenLoaiNguoiDung]) VALUES (1, N'Admin')
INSERT [dbo].[PhanLoaiNguoiDung] ([MaND], [TenLoaiNguoiDung]) VALUES (2, N'Nhân viên')
GO
INSERT [dbo].[SoTietKiem] ([MaSTK], [MaNV], [MaKH], [MaLoaiSo], [NgayMoSo], [NgayDenHan], [SoTienGui], [NgayRut], [SoTienRut], [TrangThaiSo]) VALUES (N'STK001', N'NV001', N'KH001', N'LS002', CAST(N'2024-10-01' AS Date), CAST(N'2025-10-01' AS Date), 10000000, NULL, NULL, 1)
INSERT [dbo].[SoTietKiem] ([MaSTK], [MaNV], [MaKH], [MaLoaiSo], [NgayMoSo], [NgayDenHan], [SoTienGui], [NgayRut], [SoTienRut], [TrangThaiSo]) VALUES (N'STK002', N'NV002', N'KH002', N'LS003', CAST(N'2023-01-13' AS Date), CAST(N'2024-12-30' AS Date), 50000000, CAST(N'2024-10-10' AS Date), CAST(5000000.00 AS Decimal(18, 2)), 0)
INSERT [dbo].[SoTietKiem] ([MaSTK], [MaNV], [MaKH], [MaLoaiSo], [NgayMoSo], [NgayDenHan], [SoTienGui], [NgayRut], [SoTienRut], [TrangThaiSo]) VALUES (N'STK003', N'NV003', N'KH003', N'LS001', CAST(N'2023-05-01' AS Date), NULL, 30000000, CAST(N'2024-11-20' AS Date), CAST(30550645.16 AS Decimal(18, 2)), 0)
INSERT [dbo].[SoTietKiem] ([MaSTK], [MaNV], [MaKH], [MaLoaiSo], [NgayMoSo], [NgayDenHan], [SoTienGui], [NgayRut], [SoTienRut], [TrangThaiSo]) VALUES (N'STK004', N'NV004', N'KH004', N'LS002', CAST(N'2024-06-15' AS Date), CAST(N'2026-09-15' AS Date), 5000000, CAST(N'2024-11-20' AS Date), CAST(5026333.33 AS Decimal(18, 2)), 0)
INSERT [dbo].[SoTietKiem] ([MaSTK], [MaNV], [MaKH], [MaLoaiSo], [NgayMoSo], [NgayDenHan], [SoTienGui], [NgayRut], [SoTienRut], [TrangThaiSo]) VALUES (N'STK005', N'NV005', N'KH005', N'LS003', CAST(N'2023-07-12' AS Date), CAST(N'2026-07-12' AS Date), 20000000, CAST(N'2024-10-20' AS Date), CAST(5000000.00 AS Decimal(18, 2)), 0)
INSERT [dbo].[SoTietKiem] ([MaSTK], [MaNV], [MaKH], [MaLoaiSo], [NgayMoSo], [NgayDenHan], [SoTienGui], [NgayRut], [SoTienRut], [TrangThaiSo]) VALUES (N'STK006', N'NV006', N'KH006', N'LS001', CAST(N'2023-08-22' AS Date), NULL, 10000000, NULL, NULL, 1)
INSERT [dbo].[SoTietKiem] ([MaSTK], [MaNV], [MaKH], [MaLoaiSo], [NgayMoSo], [NgayDenHan], [SoTienGui], [NgayRut], [SoTienRut], [TrangThaiSo]) VALUES (N'STK007', N'NV007', N'KH007', N'LS002', CAST(N'2022-09-10' AS Date), CAST(N'2027-09-10' AS Date), 15000000, NULL, NULL, 1)
INSERT [dbo].[SoTietKiem] ([MaSTK], [MaNV], [MaKH], [MaLoaiSo], [NgayMoSo], [NgayDenHan], [SoTienGui], [NgayRut], [SoTienRut], [TrangThaiSo]) VALUES (N'STK008', N'NV008', N'KH008', N'LS003', CAST(N'2023-10-10' AS Date), CAST(N'2024-12-30' AS Date), 5000000, CAST(N'2024-10-10' AS Date), CAST(5000000.00 AS Decimal(18, 2)), 0)
INSERT [dbo].[SoTietKiem] ([MaSTK], [MaNV], [MaKH], [MaLoaiSo], [NgayMoSo], [NgayDenHan], [SoTienGui], [NgayRut], [SoTienRut], [TrangThaiSo]) VALUES (N'STK009', N'NV009', N'KH009', N'LS001', CAST(N'2022-09-10' AS Date), NULL, 15000000, CAST(N'2024-11-20' AS Date), CAST(401000.00 AS Decimal(18, 2)), 0)
INSERT [dbo].[SoTietKiem] ([MaSTK], [MaNV], [MaKH], [MaLoaiSo], [NgayMoSo], [NgayDenHan], [SoTienGui], [NgayRut], [SoTienRut], [TrangThaiSo]) VALUES (N'STK010', N'NV008', N'KH010', N'LS003', CAST(N'2023-10-10' AS Date), CAST(N'2024-04-10' AS Date), 5000000, CAST(N'2024-10-10' AS Date), CAST(5000000.00 AS Decimal(18, 2)), 0)
INSERT [dbo].[SoTietKiem] ([MaSTK], [MaNV], [MaKH], [MaLoaiSo], [NgayMoSo], [NgayDenHan], [SoTienGui], [NgayRut], [SoTienRut], [TrangThaiSo]) VALUES (N'STK017', N'NV003', N'KH016', N'LS001', CAST(N'2023-11-20' AS Date), NULL, 50000000, NULL, NULL, 1)
INSERT [dbo].[SoTietKiem] ([MaSTK], [MaNV], [MaKH], [MaLoaiSo], [NgayMoSo], [NgayDenHan], [SoTienGui], [NgayRut], [SoTienRut], [TrangThaiSo]) VALUES (N'STK018', N'NV003', N'KH016', N'LS002', CAST(N'2023-11-20' AS Date), CAST(N'2024-02-20' AS Date), 500000000, CAST(N'2024-11-20' AS Date), CAST(507527000.00 AS Decimal(18, 2)), 0)
INSERT [dbo].[SoTietKiem] ([MaSTK], [MaNV], [MaKH], [MaLoaiSo], [NgayMoSo], [NgayDenHan], [SoTienGui], [NgayRut], [SoTienRut], [TrangThaiSo]) VALUES (N'STK019', N'NV001', N'KH010', N'LS004', CAST(N'2023-11-20' AS Date), CAST(N'2024-08-20' AS Date), 50000000, CAST(N'2024-11-21' AS Date), CAST(51955400.00 AS Decimal(18, 2)), 0)
INSERT [dbo].[SoTietKiem] ([MaSTK], [MaNV], [MaKH], [MaLoaiSo], [NgayMoSo], [NgayDenHan], [SoTienGui], [NgayRut], [SoTienRut], [TrangThaiSo]) VALUES (N'STK020', N'NV001', N'KH001', N'LS001', CAST(N'2023-06-21' AS Date), NULL, 10000000, NULL, NULL, 1)
INSERT [dbo].[SoTietKiem] ([MaSTK], [MaNV], [MaKH], [MaLoaiSo], [NgayMoSo], [NgayDenHan], [SoTienGui], [NgayRut], [SoTienRut], [TrangThaiSo]) VALUES (N'STK021', N'NV001', N'KH017', N'LS001', CAST(N'2024-11-21' AS Date), NULL, 300000000, NULL, NULL, 1)
INSERT [dbo].[SoTietKiem] ([MaSTK], [MaNV], [MaKH], [MaLoaiSo], [NgayMoSo], [NgayDenHan], [SoTienGui], [NgayRut], [SoTienRut], [TrangThaiSo]) VALUES (N'STK022', N'NV001', N'KH001', N'LS002', CAST(N'2024-11-21' AS Date), CAST(N'2025-02-21' AS Date), 30000000, NULL, NULL, 1)
INSERT [dbo].[SoTietKiem] ([MaSTK], [MaNV], [MaKH], [MaLoaiSo], [NgayMoSo], [NgayDenHan], [SoTienGui], [NgayRut], [SoTienRut], [TrangThaiSo]) VALUES (N'STK023', N'NV001', N'KH001', N'LS003', CAST(N'2024-11-21' AS Date), CAST(N'2025-05-21' AS Date), 30000000, NULL, NULL, 1)
INSERT [dbo].[SoTietKiem] ([MaSTK], [MaNV], [MaKH], [MaLoaiSo], [NgayMoSo], [NgayDenHan], [SoTienGui], [NgayRut], [SoTienRut], [TrangThaiSo]) VALUES (N'STK024', N'NV001', N'KH001', N'LS004', CAST(N'2023-11-21' AS Date), CAST(N'2024-08-21' AS Date), 30000000, CAST(N'2024-11-21' AS Date), CAST(31173240.00 AS Decimal(18, 2)), 0)
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_PhanLoaiNguoiDung] FOREIGN KEY([LoaiNguoiDung])
REFERENCES [dbo].[PhanLoaiNguoiDung] ([MaND])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_NhanVien_PhanLoaiNguoiDung]
GO
ALTER TABLE [dbo].[SoTietKiem]  WITH CHECK ADD  CONSTRAINT [FK_SoTietKiem_KhachHang] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KhachHang] ([MaKH])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[SoTietKiem] CHECK CONSTRAINT [FK_SoTietKiem_KhachHang]
GO
ALTER TABLE [dbo].[SoTietKiem]  WITH CHECK ADD  CONSTRAINT [FK_SoTietKiem_LoaiSoTietKiem] FOREIGN KEY([MaLoaiSo])
REFERENCES [dbo].[LoaiSoTietKiem] ([MaLoaiSo])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[SoTietKiem] CHECK CONSTRAINT [FK_SoTietKiem_LoaiSoTietKiem]
GO
ALTER TABLE [dbo].[SoTietKiem]  WITH CHECK ADD  CONSTRAINT [FK_SoTietKiem_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[SoTietKiem] CHECK CONSTRAINT [FK_SoTietKiem_NhanVien]
GO
USE [master]
GO
ALTER DATABASE [QUANLYTIETKIEM] SET  READ_WRITE 
GO
