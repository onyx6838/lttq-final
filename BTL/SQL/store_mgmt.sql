USE [store_mgmt]
GO
/****** Object:  UserDefinedFunction [dbo].[checkSHDN]    Script Date: 1/12/2020 3:16:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[checkSHDN] (@SHDN NVARCHAR(50))
RETURNS INT
AS
BEGIN
	DECLARE @rt INT
    SET @rt = 0
	IF EXISTS(SELECT 1 FROM dbo.tblHDNhap WHERE SoHDN = @SHDN)	SET @rt = 1
	RETURN @rt
end
GO
/****** Object:  UserDefinedFunction [dbo].[getKey]    Script Date: 1/12/2020 3:16:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE function [dbo].[getKey]() returns char(6) as
begin 
	declare @max int
	select 
		@max = MAX(cast(substring(MaHang, 3, 4) as int)) + 1
		from tblHangHoa
	declare @s char(8)
	set @s = '000' + rtrim(cast(@max as char(4)))
	set @s = 'BA' + right(@s, 4)
	return @s;
end
GO
/****** Object:  UserDefinedFunction [dbo].[loginWithRole]    Script Date: 1/12/2020 3:16:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[loginWithRole](@userName NVARCHAR(50),@passWord NVARCHAR(50))
RETURNS INT
AS
BEGIN
	IF EXISTS(SELECT userName FROM tblUser WHERE status = 1 AND userName = @userName)
	BEGIN
		IF EXISTS (SELECT userName FROM tblUser WHERE status  = 1 AND userName = @userName AND passWord = @passWord AND role = '1')
		RETURN 1
		IF EXISTS (SELECT userName FROM tblUser WHERE status  = 1 AND userName = @userName AND passWord = @passWord AND role = '2')
		RETURN 2
		ELSE
		RETURN -1
	END
	RETURN 0
END
GO
/****** Object:  Table [dbo].[tblCaLam]    Script Date: 1/12/2020 3:16:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblCaLam](
	[MaCa] [nvarchar](50) NOT NULL,
	[TenCa] [nvarchar](50) NULL,
 CONSTRAINT [PK_tblCaLam] PRIMARY KEY CLUSTERED 
(
	[MaCa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblChatLieu]    Script Date: 1/12/2020 3:16:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblChatLieu](
	[MaChatLieu] [nvarchar](50) NOT NULL,
	[TenChatLieu] [nvarchar](50) NULL,
 CONSTRAINT [PK_tblChatLieu] PRIMARY KEY CLUSTERED 
(
	[MaChatLieu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblChiTietHDBan]    Script Date: 1/12/2020 3:16:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblChiTietHDBan](
	[SoHDB] [nvarchar](50) NOT NULL,
	[MaHang] [nvarchar](50) NOT NULL,
	[SoLuong] [int] NULL,
	[GiamGia] [int] NULL,
	[ThanhTien] [int] NULL,
 CONSTRAINT [PK_tblChiTietHDBan] PRIMARY KEY CLUSTERED 
(
	[SoHDB] ASC,
	[MaHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblChiTietHDNhap]    Script Date: 1/12/2020 3:16:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblChiTietHDNhap](
	[SoHDN] [nvarchar](50) NOT NULL,
	[MaHang] [nvarchar](50) NOT NULL,
	[SoLuong] [int] NULL,
	[DonGia] [int] NULL,
	[GiamGia] [int] NULL,
	[ThanhTien] [int] NULL,
 CONSTRAINT [PK_tblChiTietHDNhap] PRIMARY KEY CLUSTERED 
(
	[SoHDN] ASC,
	[MaHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblCongDung]    Script Date: 1/12/2020 3:16:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblCongDung](
	[MaCongDung] [nvarchar](50) NOT NULL,
	[TenCongDung] [nvarchar](50) NULL,
 CONSTRAINT [PK_tblCongDung] PRIMARY KEY CLUSTERED 
(
	[MaCongDung] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblCongViec]    Script Date: 1/12/2020 3:16:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblCongViec](
	[MaCV] [nvarchar](50) NOT NULL,
	[TenCV] [nvarchar](50) NULL,
 CONSTRAINT [PK_tblCongViec] PRIMARY KEY CLUSTERED 
(
	[MaCV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblDonViTinh]    Script Date: 1/12/2020 3:16:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblDonViTinh](
	[MaDonVi] [nvarchar](50) NOT NULL,
	[TenDonVi] [nvarchar](50) NULL,
 CONSTRAINT [PK_tblDonViTinh] PRIMARY KEY CLUSTERED 
(
	[MaDonVi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblHangHoa]    Script Date: 1/12/2020 3:16:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblHangHoa](
	[MaHang] [nvarchar](50) NOT NULL,
	[TenHangHoa] [nvarchar](50) NULL,
	[MaNhom] [nvarchar](50) NULL,
	[SoLuong] [int] NULL,
	[DonGiaNhap] [int] NULL,
	[DonGiaBan] [int] NULL,
	[MaLoai] [nvarchar](50) NULL,
	[NhapKhau] [nvarchar](50) NULL,
	[MaDonVi] [nvarchar](50) NULL,
	[MaChatLieu] [nvarchar](50) NULL,
	[MaCongDung] [nvarchar](50) NULL,
	[MaNoiSX] [nvarchar](50) NULL,
	[Anh] [image] NULL,
	[GhiChu] [nvarchar](max) NULL,
 CONSTRAINT [PK_tblHangHoa] PRIMARY KEY CLUSTERED 
(
	[MaHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblHDBan]    Script Date: 1/12/2020 3:16:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblHDBan](
	[SoHDB] [nvarchar](50) NOT NULL,
	[MaNV] [nvarchar](50) NULL,
	[NgayBan] [datetime] NULL,
	[MaKhach] [nvarchar](50) NULL,
	[TongTien] [int] NULL,
 CONSTRAINT [PK_tblHDBan] PRIMARY KEY CLUSTERED 
(
	[SoHDB] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblHDNhap]    Script Date: 1/12/2020 3:16:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblHDNhap](
	[SoHDN] [nvarchar](50) NOT NULL,
	[MaNV] [nvarchar](50) NULL,
	[NgayNhap] [date] NULL,
	[MaNCC] [nvarchar](50) NULL,
	[TongTien] [int] NULL,
 CONSTRAINT [PK_tblHDNhap] PRIMARY KEY CLUSTERED 
(
	[SoHDN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblKhachHang]    Script Date: 1/12/2020 3:16:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblKhachHang](
	[MaKhach] [nvarchar](50) NOT NULL,
	[TenKhach] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](200) NULL,
	[DienThoai] [nvarchar](20) NULL,
 CONSTRAINT [PK_tblKhachHang] PRIMARY KEY CLUSTERED 
(
	[MaKhach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblNCC]    Script Date: 1/12/2020 3:16:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblNCC](
	[MaNCC] [nvarchar](50) NOT NULL,
	[TenNCC] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](200) NULL,
	[DienThoai] [nvarchar](20) NULL,
 CONSTRAINT [PK_tblNCC] PRIMARY KEY CLUSTERED 
(
	[MaNCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblNhanVien]    Script Date: 1/12/2020 3:16:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblNhanVien](
	[MaNV] [nvarchar](50) NOT NULL,
	[TenNV] [nvarchar](50) NULL,
	[GioiTinh] [nvarchar](10) NULL,
	[NgaySinh] [date] NULL,
	[DienThoai] [nvarchar](20) NULL,
	[DiaChi] [nvarchar](200) NULL,
	[MaNhom] [nvarchar](50) NULL,
	[MaCa] [nvarchar](50) NULL,
	[MaCV] [nvarchar](50) NULL,
 CONSTRAINT [PK_tblNhanVien] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblNhomHang]    Script Date: 1/12/2020 3:16:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblNhomHang](
	[MaNhom] [nvarchar](50) NOT NULL,
	[TenNhom] [nvarchar](50) NULL,
 CONSTRAINT [PK_tblNhomHang] PRIMARY KEY CLUSTERED 
(
	[MaNhom] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblNoiSX]    Script Date: 1/12/2020 3:16:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblNoiSX](
	[MaNoiSX] [nvarchar](50) NOT NULL,
	[TenNoiSX] [nvarchar](50) NULL,
 CONSTRAINT [PK_tblNoiSX] PRIMARY KEY CLUSTERED 
(
	[MaNoiSX] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblTheLoai]    Script Date: 1/12/2020 3:16:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblTheLoai](
	[MaLoai] [nvarchar](50) NOT NULL,
	[MaNhom] [nvarchar](50) NULL,
	[TenLoai] [nvarchar](50) NULL,
 CONSTRAINT [PK_tblTheLoai] PRIMARY KEY CLUSTERED 
(
	[MaLoai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblUser]    Script Date: 1/12/2020 3:16:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblUser](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[userName] [nvarchar](50) NOT NULL,
	[passWord] [nvarchar](50) NOT NULL,
	[status] [int] NULL,
	[role] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tChiTietKH]    Script Date: 1/12/2020 3:16:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tChiTietKH](
	[MaDK] [nvarchar](3) NULL,
	[LoaiKH] [nvarchar](1) NULL,
	[TenKH] [nvarchar](25) NULL,
	[NgaySinh] [datetime] NULL,
	[Phai] [bit] NOT NULL,
	[DiaChi] [nvarchar](50) NULL,
	[DienThoai] [nvarchar](7) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tDangKy]    Script Date: 1/12/2020 3:16:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tDangKy](
	[MaDK] [nvarchar](3) NOT NULL,
	[SoPhong] [nvarchar](50) NULL,
	[LoaiPhong] [nvarchar](2) NULL,
	[NgayVao] [datetime] NULL,
	[NgayRa] [datetime] NULL,
 CONSTRAINT [PK_tDangKy] PRIMARY KEY CLUSTERED 
(
	[MaDK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tKhachHang]    Script Date: 1/12/2020 3:16:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tKhachHang](
	[LoaiKH] [nvarchar](1) NULL,
	[DienGiai] [nvarchar](50) NULL
) ON [PRIMARY]
GO
INSERT [dbo].[tblCaLam] ([MaCa], [TenCa]) VALUES (N'CA1', N'Sáng')
INSERT [dbo].[tblCaLam] ([MaCa], [TenCa]) VALUES (N'CA2', N'Chiều')
INSERT [dbo].[tblCaLam] ([MaCa], [TenCa]) VALUES (N'CA3', N'Tối')
GO
INSERT [dbo].[tblChatLieu] ([MaChatLieu], [TenChatLieu]) VALUES (N'CL1', N'Tơ')
INSERT [dbo].[tblChatLieu] ([MaChatLieu], [TenChatLieu]) VALUES (N'CL2', N'Tằm')
INSERT [dbo].[tblChatLieu] ([MaChatLieu], [TenChatLieu]) VALUES (N'CL3', N'Nhựa')
GO
INSERT [dbo].[tblChiTietHDBan] ([SoHDB], [MaHang], [SoLuong], [GiamGia], [ThanhTien]) VALUES (N'HDB1', N'HH1', 7, 1, 0)
INSERT [dbo].[tblChiTietHDBan] ([SoHDB], [MaHang], [SoLuong], [GiamGia], [ThanhTien]) VALUES (N'HDB1122020_112335', N'HH1', 2, 2, 127204)
INSERT [dbo].[tblChiTietHDBan] ([SoHDB], [MaHang], [SoLuong], [GiamGia], [ThanhTien]) VALUES (N'HDB1122020_112335', N'HH4', 2, 2, 127204)
INSERT [dbo].[tblChiTietHDBan] ([SoHDB], [MaHang], [SoLuong], [GiamGia], [ThanhTien]) VALUES (N'HDB1122020_112335', N'HH6', 2, 2, 127204)
INSERT [dbo].[tblChiTietHDBan] ([SoHDB], [MaHang], [SoLuong], [GiamGia], [ThanhTien]) VALUES (N'HDB1122020_112613', N'HH10', 2, 2, 147040)
INSERT [dbo].[tblChiTietHDBan] ([SoHDB], [MaHang], [SoLuong], [GiamGia], [ThanhTien]) VALUES (N'HDB1122020_112613', N'HH5', 3, 3, 198462)
INSERT [dbo].[tblChiTietHDBan] ([SoHDB], [MaHang], [SoLuong], [GiamGia], [ThanhTien]) VALUES (N'HDB1122020_112613', N'HH6', 2, 2, 32340)
INSERT [dbo].[tblChiTietHDBan] ([SoHDB], [MaHang], [SoLuong], [GiamGia], [ThanhTien]) VALUES (N'HDB1122020_113333', N'HH3', 22, 2, 521752)
INSERT [dbo].[tblChiTietHDBan] ([SoHDB], [MaHang], [SoLuong], [GiamGia], [ThanhTien]) VALUES (N'HDB15102020_164254', N'HH6', 2, 2, 32340)
INSERT [dbo].[tblChiTietHDBan] ([SoHDB], [MaHang], [SoLuong], [GiamGia], [ThanhTien]) VALUES (N'HDB15102020_172918', N'HH1', 2, 2, 107800)
INSERT [dbo].[tblChiTietHDBan] ([SoHDB], [MaHang], [SoLuong], [GiamGia], [ThanhTien]) VALUES (N'HDB15102020_172918', N'HH3', 2, 2, 150920)
INSERT [dbo].[tblChiTietHDBan] ([SoHDB], [MaHang], [SoLuong], [GiamGia], [ThanhTien]) VALUES (N'HDB24102020_205916', N'HH3', 22, 2, 1660120)
INSERT [dbo].[tblChiTietHDBan] ([SoHDB], [MaHang], [SoLuong], [GiamGia], [ThanhTien]) VALUES (N'HDB24102020_205916', N'HH4', 2, 2, 32340)
INSERT [dbo].[tblChiTietHDBan] ([SoHDB], [MaHang], [SoLuong], [GiamGia], [ThanhTien]) VALUES (N'HDB24102020_205916', N'HH6', 2, 2, 32340)
INSERT [dbo].[tblChiTietHDBan] ([SoHDB], [MaHang], [SoLuong], [GiamGia], [ThanhTien]) VALUES (N'HDB24112020_220222', N'HH10', 3, 2, 220559)
INSERT [dbo].[tblChiTietHDBan] ([SoHDB], [MaHang], [SoLuong], [GiamGia], [ThanhTien]) VALUES (N'HDB2492020_214344', N'HH1', 1, 1, 49500)
INSERT [dbo].[tblChiTietHDBan] ([SoHDB], [MaHang], [SoLuong], [GiamGia], [ThanhTien]) VALUES (N'HDB2492020_220244', N'HH1', 1, 1, 49500)
INSERT [dbo].[tblChiTietHDBan] ([SoHDB], [MaHang], [SoLuong], [GiamGia], [ThanhTien]) VALUES (N'HDB25102020_220513', N'HH4', 3, 3, 192060)
INSERT [dbo].[tblChiTietHDBan] ([SoHDB], [MaHang], [SoLuong], [GiamGia], [ThanhTien]) VALUES (N'HDB25102020_220513', N'HH6', 1, 1, 16335)
INSERT [dbo].[tblChiTietHDBan] ([SoHDB], [MaHang], [SoLuong], [GiamGia], [ThanhTien]) VALUES (N'HDB26112020_084246', N'HH10', 2, 3, 145539)
INSERT [dbo].[tblChiTietHDBan] ([SoHDB], [MaHang], [SoLuong], [GiamGia], [ThanhTien]) VALUES (N'HDB29112020_110816', N'HH10', 2, 2, 147040)
INSERT [dbo].[tblChiTietHDBan] ([SoHDB], [MaHang], [SoLuong], [GiamGia], [ThanhTien]) VALUES (N'HDB29112020_110906', N'HH10', 2, 2, 147040)
GO
INSERT [dbo].[tblChiTietHDNhap] ([SoHDN], [MaHang], [SoLuong], [DonGia], [GiamGia], [ThanhTien]) VALUES (N'HDN10112020_193225', N'HH4', 2, 66000, 2, 129360)
INSERT [dbo].[tblChiTietHDNhap] ([SoHDN], [MaHang], [SoLuong], [DonGia], [GiamGia], [ThanhTien]) VALUES (N'HDN10112020_193342', N'HH9', 2, 62000, 2, 121520)
INSERT [dbo].[tblChiTietHDNhap] ([SoHDN], [MaHang], [SoLuong], [DonGia], [GiamGia], [ThanhTien]) VALUES (N'HDN1122020_113000', N'HH1', 2, 59000, 2, 115640)
INSERT [dbo].[tblChiTietHDNhap] ([SoHDN], [MaHang], [SoLuong], [DonGia], [GiamGia], [ThanhTien]) VALUES (N'HDN1122020_113000', N'HH3', 3, 22000, 3, 64020)
INSERT [dbo].[tblChiTietHDNhap] ([SoHDN], [MaHang], [SoLuong], [DonGia], [GiamGia], [ThanhTien]) VALUES (N'HDN1122020_113108', N'HH1', 3, 59000, 3, 171690)
INSERT [dbo].[tblChiTietHDNhap] ([SoHDN], [MaHang], [SoLuong], [DonGia], [GiamGia], [ThanhTien]) VALUES (N'HDN1122020_113108', N'HH11', 3, 90000, 3, 261900)
INSERT [dbo].[tblChiTietHDNhap] ([SoHDN], [MaHang], [SoLuong], [DonGia], [GiamGia], [ThanhTien]) VALUES (N'HDN1122020_113412', N'HH3', 22, 22000, 2, 474320)
INSERT [dbo].[tblChiTietHDNhap] ([SoHDN], [MaHang], [SoLuong], [DonGia], [GiamGia], [ThanhTien]) VALUES (N'HDN1122020_113501', N'HH9', 2, 45000, 2, 0)
INSERT [dbo].[tblChiTietHDNhap] ([SoHDN], [MaHang], [SoLuong], [DonGia], [GiamGia], [ThanhTien]) VALUES (N'HDN2112020_103121', N'HH4', 2, 60000, 2, 117600)
INSERT [dbo].[tblChiTietHDNhap] ([SoHDN], [MaHang], [SoLuong], [DonGia], [GiamGia], [ThanhTien]) VALUES (N'HDN2112020_103237', N'HH4', 2, 60000, 2, 117600)
INSERT [dbo].[tblChiTietHDNhap] ([SoHDN], [MaHang], [SoLuong], [DonGia], [GiamGia], [ThanhTien]) VALUES (N'HDN2112020_103237', N'HH9', 1, 60000, 1, 59400)
INSERT [dbo].[tblChiTietHDNhap] ([SoHDN], [MaHang], [SoLuong], [DonGia], [GiamGia], [ThanhTien]) VALUES (N'HDN29112020_110956', N'HH1', 2, 59000, 2, 98000)
INSERT [dbo].[tblChiTietHDNhap] ([SoHDN], [MaHang], [SoLuong], [DonGia], [GiamGia], [ThanhTien]) VALUES (N'HDN3', N'HH3', 14, 3000, 2, 6000)
INSERT [dbo].[tblChiTietHDNhap] ([SoHDN], [MaHang], [SoLuong], [DonGia], [GiamGia], [ThanhTien]) VALUES (N'HDN4', N'HH5', 12, 30000, 5, 40000)
GO
INSERT [dbo].[tblCongDung] ([MaCongDung], [TenCongDung]) VALUES (N'CD1', N'Bổ Gan')
INSERT [dbo].[tblCongDung] ([MaCongDung], [TenCongDung]) VALUES (N'CD2', N'Ngủ Ngon')
INSERT [dbo].[tblCongDung] ([MaCongDung], [TenCongDung]) VALUES (N'CD3', N'Dinh Dưỡng')
GO
INSERT [dbo].[tblCongViec] ([MaCV], [TenCV]) VALUES (N'CV1', N'Bán Hàng')
INSERT [dbo].[tblCongViec] ([MaCV], [TenCV]) VALUES (N'CV2', N'Kiểm kê')
INSERT [dbo].[tblCongViec] ([MaCV], [TenCV]) VALUES (N'CV3', N'Nhập Kho')
INSERT [dbo].[tblCongViec] ([MaCV], [TenCV]) VALUES (N'CV4', N'Không')
GO
INSERT [dbo].[tblDonViTinh] ([MaDonVi], [TenDonVi]) VALUES (N'DV1', N'Cân')
GO
INSERT [dbo].[tblHangHoa] ([MaHang], [TenHangHoa], [MaNhom], [SoLuong], [DonGiaNhap], [DonGiaBan], [MaLoai], [NhapKhau], [MaDonVi], [MaChatLieu], [MaCongDung], [MaNoiSX], [Anh], [GhiChu]) VALUES (N'HH1', N'Quần Jean', N'CL1', 153, 59000, 64900, N'ML1', N'Trung Quân', N'DV1', N'CL1', N'CD1', N'NSX1', NULL, N'')
INSERT [dbo].[tblHangHoa] ([MaHang], [TenHangHoa], [MaNhom], [SoLuong], [DonGiaNhap], [DonGiaBan], [MaLoai], [NhapKhau], [MaDonVi], [MaChatLieu], [MaCongDung], [MaNoiSX], [Anh], [GhiChu]) VALUES (N'HH10', N'Giấy Dán', N'CL1', 65, 68200, 75020, N'ML1', N'fff', N'DV1', N'CL2', N'CD2', N'NSX1', NULL, N'')
INSERT [dbo].[tblHangHoa] ([MaHang], [TenHangHoa], [MaNhom], [SoLuong], [DonGiaNhap], [DonGiaBan], [MaLoai], [NhapKhau], [MaDonVi], [MaChatLieu], [MaCongDung], [MaNoiSX], [Anh], [GhiChu]) VALUES (N'HH11', N'Ga Giường', N'CL1', 48, 90000, 99000, N'ML1', N'Trung Quốc', NULL, N'CL1', N'CD1', NULL, NULL, N'')
INSERT [dbo].[tblHangHoa] ([MaHang], [TenHangHoa], [MaNhom], [SoLuong], [DonGiaNhap], [DonGiaBan], [MaLoai], [NhapKhau], [MaDonVi], [MaChatLieu], [MaCongDung], [MaNoiSX], [Anh], [GhiChu]) VALUES (N'HH3', N'Áo Thun', N'CL2', 46, 22000, 24200, N'ML1', N'fff', NULL, N'CL1', N'CD2', NULL, NULL, N'')
INSERT [dbo].[tblHangHoa] ([MaHang], [TenHangHoa], [MaNhom], [SoLuong], [DonGiaNhap], [DonGiaBan], [MaLoai], [NhapKhau], [MaDonVi], [MaChatLieu], [MaCongDung], [MaNoiSX], [Anh], [GhiChu]) VALUES (N'HH4', N'Túi', N'CL1', 77, 66000, 72600, N'ML1', N'fff', NULL, N'CL2', N'CD2', NULL, NULL, N'')
INSERT [dbo].[tblHangHoa] ([MaHang], [TenHangHoa], [MaNhom], [SoLuong], [DonGiaNhap], [DonGiaBan], [MaLoai], [NhapKhau], [MaDonVi], [MaChatLieu], [MaCongDung], [MaNoiSX], [Anh], [GhiChu]) VALUES (N'HH5', N'C', N'CL1', 72, 62000, 68200, N'ML1', N'Fff', N'DV1', N'CL2', N'CD1', N'NSX2', NULL, N'')
INSERT [dbo].[tblHangHoa] ([MaHang], [TenHangHoa], [MaNhom], [SoLuong], [DonGiaNhap], [DonGiaBan], [MaLoai], [NhapKhau], [MaDonVi], [MaChatLieu], [MaCongDung], [MaNoiSX], [Anh], [GhiChu]) VALUES (N'HH6', N'Cúc Áo', N'CL1', 33, 15000, 16500, N'ML1', N'fff', NULL, N'CL1', N'CD1', NULL, NULL, N'')
INSERT [dbo].[tblHangHoa] ([MaHang], [TenHangHoa], [MaNhom], [SoLuong], [DonGiaNhap], [DonGiaBan], [MaLoai], [NhapKhau], [MaDonVi], [MaChatLieu], [MaCongDung], [MaNoiSX], [Anh], [GhiChu]) VALUES (N'HH7', N'Giày', N'CL1', 0, 30000, 33000, N'ML1', N'Trường An', NULL, N'CL1', N'CD2', NULL, NULL, N'')
INSERT [dbo].[tblHangHoa] ([MaHang], [TenHangHoa], [MaNhom], [SoLuong], [DonGiaNhap], [DonGiaBan], [MaLoai], [NhapKhau], [MaDonVi], [MaChatLieu], [MaCongDung], [MaNoiSX], [Anh], [GhiChu]) VALUES (N'HH8', N'Túi Xách', N'CL1', 0, 60000, 66000, N'ML1', N'fff', NULL, N'CL2', N'CD2', NULL, NULL, N'')
INSERT [dbo].[tblHangHoa] ([MaHang], [TenHangHoa], [MaNhom], [SoLuong], [DonGiaNhap], [DonGiaBan], [MaLoai], [NhapKhau], [MaDonVi], [MaChatLieu], [MaCongDung], [MaNoiSX], [Anh], [GhiChu]) VALUES (N'HH9', N'Giấy Dán', N'CL1', 2, 45000, 49500, N'ML1', N'Fff', N'DV1', N'CL2', N'CD2', N'NSX1', NULL, N'')
GO
INSERT [dbo].[tblHDBan] ([SoHDB], [MaNV], [NgayBan], [MaKhach], [TongTien]) VALUES (N'HDB1', N'NV1', CAST(N'2020-05-05T00:00:00.000' AS DateTime), N'KH1', 0)
INSERT [dbo].[tblHDBan] ([SoHDB], [MaNV], [NgayBan], [MaKhach], [TongTien]) VALUES (N'HDB1122020_112335', N'NV3', CAST(N'2020-12-01T00:00:00.000' AS DateTime), N'KH1', 381612)
INSERT [dbo].[tblHDBan] ([SoHDB], [MaNV], [NgayBan], [MaKhach], [TongTien]) VALUES (N'HDB1122020_112613', NULL, CAST(N'2020-12-01T00:00:00.000' AS DateTime), N'KH1', 377842)
INSERT [dbo].[tblHDBan] ([SoHDB], [MaNV], [NgayBan], [MaKhach], [TongTien]) VALUES (N'HDB1122020_113333', N'NV2', CAST(N'2020-12-01T00:00:00.000' AS DateTime), N'KH1', 521752)
INSERT [dbo].[tblHDBan] ([SoHDB], [MaNV], [NgayBan], [MaKhach], [TongTien]) VALUES (N'HDB1122020_145652', N'NV2', CAST(N'2020-12-01T00:00:00.000' AS DateTime), N'KH2', 0)
INSERT [dbo].[tblHDBan] ([SoHDB], [MaNV], [NgayBan], [MaKhach], [TongTien]) VALUES (N'HDB15102020_164254', N'NV2', CAST(N'2020-10-15T00:00:00.000' AS DateTime), N'KH1', 32340)
INSERT [dbo].[tblHDBan] ([SoHDB], [MaNV], [NgayBan], [MaKhach], [TongTien]) VALUES (N'HDB15102020_172918', N'NV1', CAST(N'2020-10-15T00:00:00.000' AS DateTime), N'KH1', 258720)
INSERT [dbo].[tblHDBan] ([SoHDB], [MaNV], [NgayBan], [MaKhach], [TongTien]) VALUES (N'HDB24102020_205916', N'NV1', CAST(N'2020-10-24T00:00:00.000' AS DateTime), N'KH1', 1724800)
INSERT [dbo].[tblHDBan] ([SoHDB], [MaNV], [NgayBan], [MaKhach], [TongTien]) VALUES (N'HDB24112020_220222', N'NV2', CAST(N'2020-11-24T00:00:00.000' AS DateTime), N'KH1', 220559)
INSERT [dbo].[tblHDBan] ([SoHDB], [MaNV], [NgayBan], [MaKhach], [TongTien]) VALUES (N'HDB2492020_214344', N'NV2', CAST(N'2020-09-24T00:00:00.000' AS DateTime), N'KH1', 0)
INSERT [dbo].[tblHDBan] ([SoHDB], [MaNV], [NgayBan], [MaKhach], [TongTien]) VALUES (N'HDB2492020_220244', NULL, CAST(N'2020-09-24T00:00:00.000' AS DateTime), N'KH2', 99000)
INSERT [dbo].[tblHDBan] ([SoHDB], [MaNV], [NgayBan], [MaKhach], [TongTien]) VALUES (N'HDB25102020_214524', N'NV1', CAST(N'2020-10-25T00:00:00.000' AS DateTime), N'KH2', 20000)
INSERT [dbo].[tblHDBan] ([SoHDB], [MaNV], [NgayBan], [MaKhach], [TongTien]) VALUES (N'HDB25102020_214646', N'NV3', CAST(N'2020-10-25T00:00:00.000' AS DateTime), N'KH2', 155815)
INSERT [dbo].[tblHDBan] ([SoHDB], [MaNV], [NgayBan], [MaKhach], [TongTien]) VALUES (N'HDB25102020_220513', N'NV1', CAST(N'2020-10-25T00:00:00.000' AS DateTime), N'KH1', 208395)
INSERT [dbo].[tblHDBan] ([SoHDB], [MaNV], [NgayBan], [MaKhach], [TongTien]) VALUES (N'HDB26112020_084246', N'NV2', CAST(N'2020-11-26T00:00:00.000' AS DateTime), N'KH1', 145539)
INSERT [dbo].[tblHDBan] ([SoHDB], [MaNV], [NgayBan], [MaKhach], [TongTien]) VALUES (N'HDB29112020_110816', N'NV1', CAST(N'2020-11-29T00:00:00.000' AS DateTime), N'KH1', 147040)
INSERT [dbo].[tblHDBan] ([SoHDB], [MaNV], [NgayBan], [MaKhach], [TongTien]) VALUES (N'HDB29112020_110906', N'NV1', CAST(N'2020-11-29T00:00:00.000' AS DateTime), N'KH2', 147040)
GO
INSERT [dbo].[tblHDNhap] ([SoHDN], [MaNV], [NgayNhap], [MaNCC], [TongTien]) VALUES (N'HDN1', N'NV2', CAST(N'2020-10-14' AS Date), N'NCC1', 20202)
INSERT [dbo].[tblHDNhap] ([SoHDN], [MaNV], [NgayNhap], [MaNCC], [TongTien]) VALUES (N'HDN10112020_193225', N'NV1', CAST(N'2020-11-10' AS Date), N'NCC1', 129360)
INSERT [dbo].[tblHDNhap] ([SoHDN], [MaNV], [NgayNhap], [MaNCC], [TongTien]) VALUES (N'HDN10112020_193342', N'NV3', CAST(N'2020-11-10' AS Date), N'NCC3', 121520)
INSERT [dbo].[tblHDNhap] ([SoHDN], [MaNV], [NgayNhap], [MaNCC], [TongTien]) VALUES (N'HDN1122020_113000', N'NV3', CAST(N'2020-12-01' AS Date), N'NCC2', 179660)
INSERT [dbo].[tblHDNhap] ([SoHDN], [MaNV], [NgayNhap], [MaNCC], [TongTien]) VALUES (N'HDN1122020_113108', N'NV1', CAST(N'2020-12-01' AS Date), N'NCC3', 433590)
INSERT [dbo].[tblHDNhap] ([SoHDN], [MaNV], [NgayNhap], [MaNCC], [TongTien]) VALUES (N'HDN1122020_113412', N'NV5', CAST(N'2020-12-01' AS Date), N'NCC2', 474320)
INSERT [dbo].[tblHDNhap] ([SoHDN], [MaNV], [NgayNhap], [MaNCC], [TongTien]) VALUES (N'HDN1122020_113501', N'NV2', CAST(N'2020-12-01' AS Date), N'NCC3', 0)
INSERT [dbo].[tblHDNhap] ([SoHDN], [MaNV], [NgayNhap], [MaNCC], [TongTien]) VALUES (N'HDN1122020_145553', N'NV2', CAST(N'2020-12-01' AS Date), N'NCC3', 0)
INSERT [dbo].[tblHDNhap] ([SoHDN], [MaNV], [NgayNhap], [MaNCC], [TongTien]) VALUES (N'HDN2112020_103121', N'NV2', CAST(N'2020-11-02' AS Date), N'NCC2', 175800)
INSERT [dbo].[tblHDNhap] ([SoHDN], [MaNV], [NgayNhap], [MaNCC], [TongTien]) VALUES (N'HDN2112020_103237', N'NV3', CAST(N'2020-11-02' AS Date), N'NCC2', 177000)
INSERT [dbo].[tblHDNhap] ([SoHDN], [MaNV], [NgayNhap], [MaNCC], [TongTien]) VALUES (N'HDN29112020_110956', N'NV3', CAST(N'2020-11-29' AS Date), N'NCC2', 98000)
INSERT [dbo].[tblHDNhap] ([SoHDN], [MaNV], [NgayNhap], [MaNCC], [TongTien]) VALUES (N'HDN3', N'NV5', CAST(N'2020-10-15' AS Date), N'NCC2', 20000)
INSERT [dbo].[tblHDNhap] ([SoHDN], [MaNV], [NgayNhap], [MaNCC], [TongTien]) VALUES (N'HDN4', N'NV1', CAST(N'2020-10-05' AS Date), N'NCC2', 2000)
GO
INSERT [dbo].[tblKhachHang] ([MaKhach], [TenKhach], [DiaChi], [DienThoai]) VALUES (N'KH1', N'Chung', N'Quảng Ninh', N'(015) 541-1111')
INSERT [dbo].[tblKhachHang] ([MaKhach], [TenKhach], [DiaChi], [DienThoai]) VALUES (N'KH2', N'Huong', N'Cửa Ông', N'(038) 829-9424')
GO
INSERT [dbo].[tblNCC] ([MaNCC], [TenNCC], [DiaChi], [DienThoai]) VALUES (N'NCC1', N'Co Phan', NULL, NULL)
INSERT [dbo].[tblNCC] ([MaNCC], [TenNCC], [DiaChi], [DienThoai]) VALUES (N'NCC2', N'Truong An', NULL, NULL)
INSERT [dbo].[tblNCC] ([MaNCC], [TenNCC], [DiaChi], [DienThoai]) VALUES (N'NCC3', N'Hoàng Ngọc', N'Trung Kính', N'(036) 566-5565')
INSERT [dbo].[tblNCC] ([MaNCC], [TenNCC], [DiaChi], [DienThoai]) VALUES (N'NCC4', N'Thiên Hương', N'Ngọc Hà', N'(036) 566-5565')
GO
INSERT [dbo].[tblNhanVien] ([MaNV], [TenNV], [GioiTinh], [NgaySinh], [DienThoai], [DiaChi], [MaNhom], [MaCa], [MaCV]) VALUES (N'NV1', N'Doan', NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[tblNhanVien] ([MaNV], [TenNV], [GioiTinh], [NgaySinh], [DienThoai], [DiaChi], [MaNhom], [MaCa], [MaCV]) VALUES (N'NV2', N'Giang', N'Nữ', CAST(N'2020-11-28' AS Date), N'(111) 111-1111', N'Cửa Ông', N'CL1', N'CA3', N'CV3')
INSERT [dbo].[tblNhanVien] ([MaNV], [TenNV], [GioiTinh], [NgaySinh], [DienThoai], [DiaChi], [MaNhom], [MaCa], [MaCV]) VALUES (N'NV3', N'Chung', N'Nữ', CAST(N'2020-06-21' AS Date), N'(038) 829-9444', N'Cửa Ông', N'CL1', N'CA3', N'CV1')
INSERT [dbo].[tblNhanVien] ([MaNV], [TenNV], [GioiTinh], [NgaySinh], [DienThoai], [DiaChi], [MaNhom], [MaCa], [MaCV]) VALUES (N'NV5', N'Thành', N'Nữ', CAST(N'2020-11-02' AS Date), N'(999) 999-9999', N'hà Nội', N'CL2', N'CA2', N'CV1')
GO
INSERT [dbo].[tblNhomHang] ([MaNhom], [TenNhom]) VALUES (N'CL1', N'Vai')
INSERT [dbo].[tblNhomHang] ([MaNhom], [TenNhom]) VALUES (N'CL2', N'Bông')
INSERT [dbo].[tblNhomHang] ([MaNhom], [TenNhom]) VALUES (N'CL3', N'Giấy')
GO
INSERT [dbo].[tblNoiSX] ([MaNoiSX], [TenNoiSX]) VALUES (N'NSX1', N'Trường An')
INSERT [dbo].[tblNoiSX] ([MaNoiSX], [TenNoiSX]) VALUES (N'NSX2', N'Kiên Thu')
GO
INSERT [dbo].[tblTheLoai] ([MaLoai], [MaNhom], [TenLoai]) VALUES (N'ML1', N'CL1', N'Chung')
INSERT [dbo].[tblTheLoai] ([MaLoai], [MaNhom], [TenLoai]) VALUES (N'ML2', N'CL1', N'Đồ Dùng Sinh Hoạt')
GO
SET IDENTITY_INSERT [dbo].[tblUser] ON 

INSERT [dbo].[tblUser] ([id], [userName], [passWord], [status], [role]) VALUES (1, N'zxc', N'123', 1, 1)
INSERT [dbo].[tblUser] ([id], [userName], [passWord], [status], [role]) VALUES (4, N'trangdt', N'123', 1, 2)
INSERT [dbo].[tblUser] ([id], [userName], [passWord], [status], [role]) VALUES (1004, N'onyx', N'123', 1, 1)
INSERT [dbo].[tblUser] ([id], [userName], [passWord], [status], [role]) VALUES (1005, N'asd', N'asd', 1, 1)
INSERT [dbo].[tblUser] ([id], [userName], [passWord], [status], [role]) VALUES (1006, N'onyxzt', N'123', 1, 2)
INSERT [dbo].[tblUser] ([id], [userName], [passWord], [status], [role]) VALUES (1007, N'xxx', N'111', 1, 2)
SET IDENTITY_INSERT [dbo].[tblUser] OFF
GO
INSERT [dbo].[tChiTietKH] ([MaDK], [LoaiKH], [TenKH], [NgaySinh], [Phai], [DiaChi], [DienThoai]) VALUES (N'001', N'1', N'Trần Hồng Hà', CAST(N'1980-12-12T00:00:00.000' AS DateTime), 0, N'34A Trần phú', NULL)
INSERT [dbo].[tChiTietKH] ([MaDK], [LoaiKH], [TenKH], [NgaySinh], [Phai], [DiaChi], [DienThoai]) VALUES (N'002', N'1', N'Nguyễn Thế Anh', CAST(N'1968-03-22T00:00:00.000' AS DateTime), 0, N'123 Trần Hưng Đạo', NULL)
INSERT [dbo].[tChiTietKH] ([MaDK], [LoaiKH], [TenKH], [NgaySinh], [Phai], [DiaChi], [DienThoai]) VALUES (N'003', N'1', N'Lê Gia Linh', CAST(N'1981-04-12T00:00:00.000' AS DateTime), 1, N'564 Nguyễn Trãi', N'8445563')
INSERT [dbo].[tChiTietKH] ([MaDK], [LoaiKH], [TenKH], [NgaySinh], [Phai], [DiaChi], [DienThoai]) VALUES (N'004', N'3', N'Nguyễn Thị Minh tâm', CAST(N'1975-05-23T00:00:00.000' AS DateTime), 1, N'56/12 Đặng văn Ngữ', NULL)
INSERT [dbo].[tChiTietKH] ([MaDK], [LoaiKH], [TenKH], [NgaySinh], [Phai], [DiaChi], [DienThoai]) VALUES (N'005', N'1', N'Nguyễn Kim Sơn', CAST(N'1969-09-12T00:00:00.000' AS DateTime), 0, N'78/9 Nguyễn Thị Minh Khai', N'8355647')
INSERT [dbo].[tChiTietKH] ([MaDK], [LoaiKH], [TenKH], [NgaySinh], [Phai], [DiaChi], [DienThoai]) VALUES (N'006', N'1', N'Trần Hạnh Dung', CAST(N'1952-12-15T00:00:00.000' AS DateTime), 1, N'34 Lê Duẩn', NULL)
INSERT [dbo].[tChiTietKH] ([MaDK], [LoaiKH], [TenKH], [NgaySinh], [Phai], [DiaChi], [DienThoai]) VALUES (N'007', N'2', N'Lý Mỹ Lệ', CAST(N'1980-01-16T00:00:00.000' AS DateTime), 1, N'14/2 Vũ Trọng Phụng', N'8679456')
INSERT [dbo].[tChiTietKH] ([MaDK], [LoaiKH], [TenKH], [NgaySinh], [Phai], [DiaChi], [DienThoai]) VALUES (N'008', N'2', N'Nguyễn Kim An', CAST(N'1963-03-12T00:00:00.000' AS DateTime), 0, N'23 Trần Bình Trọng', NULL)
INSERT [dbo].[tChiTietKH] ([MaDK], [LoaiKH], [TenKH], [NgaySinh], [Phai], [DiaChi], [DienThoai]) VALUES (N'009', N'1', N'Nguyễn Phương Dung', CAST(N'1982-06-10T00:00:00.000' AS DateTime), 1, N'67 Hoàng Hoa Thám', N'8767752')
INSERT [dbo].[tChiTietKH] ([MaDK], [LoaiKH], [TenKH], [NgaySinh], [Phai], [DiaChi], [DienThoai]) VALUES (N'010', N'1', N'Lê Thị Kim thảo', CAST(N'1969-09-03T00:00:00.000' AS DateTime), 1, N'56 Nguyễn Tuân', NULL)
GO
INSERT [dbo].[tDangKy] ([MaDK], [SoPhong], [LoaiPhong], [NgayVao], [NgayRa]) VALUES (N'001', N'201', N'A', CAST(N'1998-04-26T00:00:00.000' AS DateTime), CAST(N'1998-04-28T00:00:00.000' AS DateTime))
INSERT [dbo].[tDangKy] ([MaDK], [SoPhong], [LoaiPhong], [NgayVao], [NgayRa]) VALUES (N'002', N'202', N'B', CAST(N'1998-04-30T00:00:00.000' AS DateTime), CAST(N'1998-05-03T00:00:00.000' AS DateTime))
INSERT [dbo].[tDangKy] ([MaDK], [SoPhong], [LoaiPhong], [NgayVao], [NgayRa]) VALUES (N'003', N'101', N'A', CAST(N'1998-05-01T00:00:00.000' AS DateTime), CAST(N'1998-06-01T00:00:00.000' AS DateTime))
INSERT [dbo].[tDangKy] ([MaDK], [SoPhong], [LoaiPhong], [NgayVao], [NgayRa]) VALUES (N'004', N'102', N'A', CAST(N'1998-05-02T00:00:00.000' AS DateTime), CAST(N'1998-05-15T00:00:00.000' AS DateTime))
INSERT [dbo].[tDangKy] ([MaDK], [SoPhong], [LoaiPhong], [NgayVao], [NgayRa]) VALUES (N'005', N'405', N'B', CAST(N'1998-05-03T00:00:00.000' AS DateTime), CAST(N'1998-05-05T00:00:00.000' AS DateTime))
INSERT [dbo].[tDangKy] ([MaDK], [SoPhong], [LoaiPhong], [NgayVao], [NgayRa]) VALUES (N'006', N'608', N'C', CAST(N'1998-06-01T00:00:00.000' AS DateTime), CAST(N'1998-07-05T00:00:00.000' AS DateTime))
INSERT [dbo].[tDangKy] ([MaDK], [SoPhong], [LoaiPhong], [NgayVao], [NgayRa]) VALUES (N'007', N'304', N'C', CAST(N'1998-06-05T00:00:00.000' AS DateTime), CAST(N'1998-06-08T00:00:00.000' AS DateTime))
INSERT [dbo].[tDangKy] ([MaDK], [SoPhong], [LoaiPhong], [NgayVao], [NgayRa]) VALUES (N'008', N'201', N'B', CAST(N'1998-06-30T00:00:00.000' AS DateTime), CAST(N'1998-07-15T00:00:00.000' AS DateTime))
INSERT [dbo].[tDangKy] ([MaDK], [SoPhong], [LoaiPhong], [NgayVao], [NgayRa]) VALUES (N'009', N'205', N'A', CAST(N'1999-07-01T00:00:00.000' AS DateTime), CAST(N'1999-07-30T00:00:00.000' AS DateTime))
INSERT [dbo].[tDangKy] ([MaDK], [SoPhong], [LoaiPhong], [NgayVao], [NgayRa]) VALUES (N'010', N'601', N'B', CAST(N'1999-01-01T00:00:00.000' AS DateTime), CAST(N'1999-01-12T00:00:00.000' AS DateTime))
INSERT [dbo].[tDangKy] ([MaDK], [SoPhong], [LoaiPhong], [NgayVao], [NgayRa]) VALUES (N'011', N'202', N'B', CAST(N'2019-01-01T00:00:00.000' AS DateTime), CAST(N'2019-01-05T00:00:00.000' AS DateTime))
INSERT [dbo].[tDangKy] ([MaDK], [SoPhong], [LoaiPhong], [NgayVao], [NgayRa]) VALUES (N'012', N'601', N'A', CAST(N'2019-04-03T00:00:00.000' AS DateTime), CAST(N'2019-04-05T00:00:00.000' AS DateTime))
INSERT [dbo].[tDangKy] ([MaDK], [SoPhong], [LoaiPhong], [NgayVao], [NgayRa]) VALUES (N'013', N'601', N'A', CAST(N'2019-04-03T00:00:00.000' AS DateTime), CAST(N'2019-04-05T00:00:00.000' AS DateTime))
INSERT [dbo].[tDangKy] ([MaDK], [SoPhong], [LoaiPhong], [NgayVao], [NgayRa]) VALUES (N'014', N'601', N'A', CAST(N'2019-04-03T00:00:00.000' AS DateTime), CAST(N'2019-04-03T00:01:00.000' AS DateTime))
INSERT [dbo].[tDangKy] ([MaDK], [SoPhong], [LoaiPhong], [NgayVao], [NgayRa]) VALUES (N'015', N'601', N'A', CAST(N'2019-04-03T00:00:00.000' AS DateTime), CAST(N'2019-04-04T00:00:00.000' AS DateTime))
GO
ALTER TABLE [dbo].[tblChiTietHDBan]  WITH CHECK ADD  CONSTRAINT [FK_tblChiTietHDBan_tblHangHoa] FOREIGN KEY([MaHang])
REFERENCES [dbo].[tblHangHoa] ([MaHang])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tblChiTietHDBan] CHECK CONSTRAINT [FK_tblChiTietHDBan_tblHangHoa]
GO
ALTER TABLE [dbo].[tblChiTietHDBan]  WITH CHECK ADD  CONSTRAINT [FK_tblChiTietHDBan_tblHDBan] FOREIGN KEY([SoHDB])
REFERENCES [dbo].[tblHDBan] ([SoHDB])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tblChiTietHDBan] CHECK CONSTRAINT [FK_tblChiTietHDBan_tblHDBan]
GO
ALTER TABLE [dbo].[tblChiTietHDNhap]  WITH CHECK ADD  CONSTRAINT [FK_tblChiTietHDNhap_tblHangHoa1] FOREIGN KEY([MaHang])
REFERENCES [dbo].[tblHangHoa] ([MaHang])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tblChiTietHDNhap] CHECK CONSTRAINT [FK_tblChiTietHDNhap_tblHangHoa1]
GO
ALTER TABLE [dbo].[tblChiTietHDNhap]  WITH CHECK ADD  CONSTRAINT [FK_tblChiTietHDNhap_tblHDNhap1] FOREIGN KEY([SoHDN])
REFERENCES [dbo].[tblHDNhap] ([SoHDN])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tblChiTietHDNhap] CHECK CONSTRAINT [FK_tblChiTietHDNhap_tblHDNhap1]
GO
ALTER TABLE [dbo].[tblHangHoa]  WITH CHECK ADD  CONSTRAINT [FK_tblHangHoa_tblChatLieu] FOREIGN KEY([MaChatLieu])
REFERENCES [dbo].[tblChatLieu] ([MaChatLieu])
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[tblHangHoa] CHECK CONSTRAINT [FK_tblHangHoa_tblChatLieu]
GO
ALTER TABLE [dbo].[tblHangHoa]  WITH CHECK ADD  CONSTRAINT [FK_tblHangHoa_tblCongDung] FOREIGN KEY([MaCongDung])
REFERENCES [dbo].[tblCongDung] ([MaCongDung])
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[tblHangHoa] CHECK CONSTRAINT [FK_tblHangHoa_tblCongDung]
GO
ALTER TABLE [dbo].[tblHangHoa]  WITH CHECK ADD  CONSTRAINT [FK_tblHangHoa_tblDonViTinh] FOREIGN KEY([MaDonVi])
REFERENCES [dbo].[tblDonViTinh] ([MaDonVi])
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[tblHangHoa] CHECK CONSTRAINT [FK_tblHangHoa_tblDonViTinh]
GO
ALTER TABLE [dbo].[tblHangHoa]  WITH CHECK ADD  CONSTRAINT [FK_tblHangHoa_tblNhomHang] FOREIGN KEY([MaNhom])
REFERENCES [dbo].[tblNhomHang] ([MaNhom])
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[tblHangHoa] CHECK CONSTRAINT [FK_tblHangHoa_tblNhomHang]
GO
ALTER TABLE [dbo].[tblHangHoa]  WITH CHECK ADD  CONSTRAINT [FK_tblHangHoa_tblNoiSX] FOREIGN KEY([MaNoiSX])
REFERENCES [dbo].[tblNoiSX] ([MaNoiSX])
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[tblHangHoa] CHECK CONSTRAINT [FK_tblHangHoa_tblNoiSX]
GO
ALTER TABLE [dbo].[tblHangHoa]  WITH CHECK ADD  CONSTRAINT [FK_tblHangHoa_tblTheLoai] FOREIGN KEY([MaLoai])
REFERENCES [dbo].[tblTheLoai] ([MaLoai])
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[tblHangHoa] CHECK CONSTRAINT [FK_tblHangHoa_tblTheLoai]
GO
ALTER TABLE [dbo].[tblHDBan]  WITH CHECK ADD  CONSTRAINT [FK_tblHDBan_tblKhachHang] FOREIGN KEY([MaKhach])
REFERENCES [dbo].[tblKhachHang] ([MaKhach])
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[tblHDBan] CHECK CONSTRAINT [FK_tblHDBan_tblKhachHang]
GO
ALTER TABLE [dbo].[tblHDBan]  WITH CHECK ADD  CONSTRAINT [FK_tblHDBan_tblNhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[tblNhanVien] ([MaNV])
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[tblHDBan] CHECK CONSTRAINT [FK_tblHDBan_tblNhanVien]
GO
ALTER TABLE [dbo].[tblHDNhap]  WITH CHECK ADD  CONSTRAINT [FK_tblHDNhap_tblNCC] FOREIGN KEY([MaNCC])
REFERENCES [dbo].[tblNCC] ([MaNCC])
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[tblHDNhap] CHECK CONSTRAINT [FK_tblHDNhap_tblNCC]
GO
ALTER TABLE [dbo].[tblHDNhap]  WITH CHECK ADD  CONSTRAINT [FK_tblHDNhap_tblNhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[tblNhanVien] ([MaNV])
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[tblHDNhap] CHECK CONSTRAINT [FK_tblHDNhap_tblNhanVien]
GO
ALTER TABLE [dbo].[tblNhanVien]  WITH CHECK ADD  CONSTRAINT [FK_tblNhanVien_tblCaLam] FOREIGN KEY([MaCa])
REFERENCES [dbo].[tblCaLam] ([MaCa])
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[tblNhanVien] CHECK CONSTRAINT [FK_tblNhanVien_tblCaLam]
GO
ALTER TABLE [dbo].[tblNhanVien]  WITH CHECK ADD  CONSTRAINT [FK_tblNhanVien_tblCongViec] FOREIGN KEY([MaCV])
REFERENCES [dbo].[tblCongViec] ([MaCV])
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[tblNhanVien] CHECK CONSTRAINT [FK_tblNhanVien_tblCongViec]
GO
ALTER TABLE [dbo].[tblNhanVien]  WITH CHECK ADD  CONSTRAINT [FK_tblNhanVien_tblNhomHang] FOREIGN KEY([MaNhom])
REFERENCES [dbo].[tblNhomHang] ([MaNhom])
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[tblNhanVien] CHECK CONSTRAINT [FK_tblNhanVien_tblNhomHang]
GO
ALTER TABLE [dbo].[tblTheLoai]  WITH CHECK ADD  CONSTRAINT [FK_tblTheLoai_tblNhomHang] FOREIGN KEY([MaNhom])
REFERENCES [dbo].[tblNhomHang] ([MaNhom])
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[tblTheLoai] CHECK CONSTRAINT [FK_tblTheLoai_tblNhomHang]
GO
/****** Object:  StoredProcedure [dbo].[sp_DeleteCaLam]    Script Date: 1/12/2020 3:16:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_DeleteCaLam]
@MaCa nvarchar(50)
as
delete from tblCaLam where MaCa = @MaCa
GO
/****** Object:  StoredProcedure [dbo].[sp_DeleteChatLieu]    Script Date: 1/12/2020 3:16:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_DeleteChatLieu]
@MaChatLieu nvarchar(50)
as
delete from tblChatLieu where MaChatLieu = @MaChatLieu
GO
/****** Object:  StoredProcedure [dbo].[sp_DeleteCongDung]    Script Date: 1/12/2020 3:16:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_DeleteCongDung]
@MaCongDung nvarchar(50)
as
delete from tblCongDung where MaCongDung = @MaCongDung
GO
/****** Object:  StoredProcedure [dbo].[sp_DeleteCongViec]    Script Date: 1/12/2020 3:16:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_DeleteCongViec]
@MaCV nvarchar(50)
as
delete from tblCongViec where MaCV = @MaCV
GO
/****** Object:  StoredProcedure [dbo].[sp_DeleteDonViTinh]    Script Date: 1/12/2020 3:16:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_DeleteDonViTinh]
@MaDonVi nvarchar(50)
as
delete from tblDonViTinh where MaDonVi = @MaDonVi
GO
/****** Object:  StoredProcedure [dbo].[sp_DeleteHangHoa]    Script Date: 1/12/2020 3:16:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_DeleteHangHoa]
@MaHang NVARCHAR(50)
AS
DELETE FROM dbo.tblHangHoa WHERE MaHang = @MaHang
GO
/****** Object:  StoredProcedure [dbo].[sp_DeleteHDBan]    Script Date: 1/12/2020 3:16:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_DeleteHDBan]
	@SoHDB NVARCHAR(50)
AS
DELETE FROM dbo.tblHDBan WHERE SoHDB = @SoHDB
GO
/****** Object:  StoredProcedure [dbo].[sp_DeleteHDNhap]    Script Date: 1/12/2020 3:16:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_DeleteHDNhap]
@SoHDN NVARCHAR(50)
AS
DELETE FROM dbo.tblHDNhap WHERE SoHDN = @SoHDN
GO
/****** Object:  StoredProcedure [dbo].[sp_DeleteKhachHang]    Script Date: 1/12/2020 3:16:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_DeleteKhachHang]
@MaKhach NVARCHAR(50)
AS
DELETE FROM dbo.tblKhachHang WHERE MaKhach = @MaKhach
GO
/****** Object:  StoredProcedure [dbo].[sp_DeleteNCC]    Script Date: 1/12/2020 3:16:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_DeleteNCC]
@MaNCC NVARCHAR(50)
AS
DELETE FROM dbo.tblNCC WHERE MaNCC = @MaNCC
GO
/****** Object:  StoredProcedure [dbo].[sp_DeleteNhanVien]    Script Date: 1/12/2020 3:16:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_DeleteNhanVien]
@MaNV NVARCHAR(50)
AS
DELETE FROM dbo.tblNhanVien WHERE MaNV = @MaNV
GO
/****** Object:  StoredProcedure [dbo].[sp_DeleteNhomHang]    Script Date: 1/12/2020 3:16:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_DeleteNhomHang]
@MaNhom NVARCHAR(50)
AS 
DELETE FROM dbo.tblNhomHang WHERE MaNhom = @MaNhom
GO
/****** Object:  StoredProcedure [dbo].[sp_DeleteNoiSX]    Script Date: 1/12/2020 3:16:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_DeleteNoiSX]
@MaNoiSX nvarchar(50)
as
delete from tblNoiSX where MaNoiSX = @MaNoiSX
GO
/****** Object:  StoredProcedure [dbo].[sp_DeleteTheLoai]    Script Date: 1/12/2020 3:16:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_DeleteTheLoai]
@MaLoai nvarchar(50)
as
delete from tblTheLoai where MaLoai = @MaLoai
GO
/****** Object:  StoredProcedure [dbo].[sp_DeleteUser]    Script Date: 1/12/2020 3:16:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_DeleteUser]
@uid INT
AS
DELETE FROM dbo.tblUser WHERE id = @uid
GO
/****** Object:  StoredProcedure [dbo].[sp_FindOneByMaHangHoa]    Script Date: 1/12/2020 3:16:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_FindOneByMaHangHoa]
@SoHDN nvarchar(50),
@MaHang nvarchar(50)
as
select MaHang from tblChiTietHDNhap where MaHang = @MaHang AND SoHDN = @SoHDN
GO
/****** Object:  StoredProcedure [dbo].[sp_FindOneByMaHangHoaHDB]    Script Date: 1/12/2020 3:16:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_FindOneByMaHangHoaHDB]
@SoHDB nvarchar(50),
@MaHang nvarchar(50)
as
select MaHang from tblChiTietHDBan where MaHang = @MaHang AND SoHDB = @SoHDB
GO
/****** Object:  StoredProcedure [dbo].[sp_FindOneBySoHDB]    Script Date: 1/12/2020 3:16:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_FindOneBySoHDB]
@SoHDB nvarchar(50)
as
select SoHDB from tblHDBan where SoHDB = @SoHDB
GO
/****** Object:  StoredProcedure [dbo].[sp_FindOneBySoHDN]    Script Date: 1/12/2020 3:16:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_FindOneBySoHDN]
@SoHDN nvarchar(50)
as
select SoHDN from tblHDNhap where SoHDN = @SoHDN
GO
/****** Object:  StoredProcedure [dbo].[sp_GetAllCaLam]    Script Date: 1/12/2020 3:16:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_GetAllCaLam]
AS
SELECT * FROM dbo.tblCaLam
GO
/****** Object:  StoredProcedure [dbo].[sp_GetAllChatLieu]    Script Date: 1/12/2020 3:16:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_GetAllChatLieu]
as
select * from tblChatLieu
GO
/****** Object:  StoredProcedure [dbo].[sp_GetAllCongDung]    Script Date: 1/12/2020 3:16:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_GetAllCongDung]
as
select * from tblCongDung
GO
/****** Object:  StoredProcedure [dbo].[sp_GetAllCongViec]    Script Date: 1/12/2020 3:16:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_GetAllCongViec]
as
select * from tblCongViec
GO
/****** Object:  StoredProcedure [dbo].[sp_GetAllCTHDB]    Script Date: 1/12/2020 3:16:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_GetAllCTHDB]
as
select * from tblChiTietHDBan
GO
/****** Object:  StoredProcedure [dbo].[sp_GetAllCTHDN]    Script Date: 1/12/2020 3:16:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_GetAllCTHDN]
as
select * from tblChiTietHDNhap
GO
/****** Object:  StoredProcedure [dbo].[sp_GetAllDonViTinh]    Script Date: 1/12/2020 3:16:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_GetAllDonViTinh]
as
select * from tblDonViTinh
GO
/****** Object:  StoredProcedure [dbo].[sp_GetAllHangHoa]    Script Date: 1/12/2020 3:16:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_GetAllHangHoa]
as
select * from tblHangHoa
GO
/****** Object:  StoredProcedure [dbo].[sp_GetAllHangHoa_With_Search]    Script Date: 1/12/2020 3:16:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_GetAllHangHoa_With_Search]
AS
SELECT MaHang,
       TenHangHoa,
       hh.MaNhom,
	   nh.TenNhom,
       SoLuong,
       DonGiaNhap,
       MaLoai,
       NhapKhau,
       MaDonVi,
       hh.MaChatLieu,
	   cl.TenChatLieu,
       hh.MaCongDung,
	   cd.TenCongDung,
       MaNoiSX,
       Anh,
       GhiChu
FROM dbo.tblHangHoa hh,
     dbo.tblCongDung cd,
     dbo.tblChatLieu cl,
     dbo.tblNhomHang nh
WHERE hh.MaCongDung = cd.MaCongDung
      AND hh.MaChatLieu = cl.MaChatLieu
      AND nh.MaNhom = hh.MaNhom;
GO
/****** Object:  StoredProcedure [dbo].[sp_GetAllHDBan]    Script Date: 1/12/2020 3:16:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_GetAllHDBan]
AS
SELECT * FROM dbo.tblHDBan
GO
/****** Object:  StoredProcedure [dbo].[sp_GetAllHDNhap]    Script Date: 1/12/2020 3:16:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_GetAllHDNhap]
as
select * from tblHDNhap
GO
/****** Object:  StoredProcedure [dbo].[sp_GetAllHDNhap_WithSearch]    Script Date: 1/12/2020 3:16:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_GetAllHDNhap_WithSearch]
AS
SELECT hdn.SoHDN,
       cthdn.MaHang,
       hdn.MaNV,
       hdn.NgayNhap,
       ncc.MaNCC,
       ncc.TenNCC,
       hdn.TongTien
FROM dbo.tblHDNhap hdn,
     dbo.tblChiTietHDNhap cthdn,
     dbo.tblNCC ncc
WHERE hdn.SoHDN = cthdn.SoHDN
      AND hdn.MaNCC = ncc.MaNCC;
GO
/****** Object:  StoredProcedure [dbo].[sp_GetAllKhachHang]    Script Date: 1/12/2020 3:16:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_GetAllKhachHang]
	as
	select * from tblKhachHang
GO
/****** Object:  StoredProcedure [dbo].[sp_GetAllNCC]    Script Date: 1/12/2020 3:16:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_GetAllNCC]
	as
	select * from tblNCC
GO
/****** Object:  StoredProcedure [dbo].[sp_GetAllNhanVien]    Script Date: 1/12/2020 3:16:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_GetAllNhanVien]
	as
	select * from tblNhanVien
GO
/****** Object:  StoredProcedure [dbo].[sp_GetAllNhomHang]    Script Date: 1/12/2020 3:16:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_GetAllNhomHang]
	as
	select * from tblNhomHang
GO
/****** Object:  StoredProcedure [dbo].[sp_GetAllNoiSX]    Script Date: 1/12/2020 3:16:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_GetAllNoiSX]
as
select * from tblNoiSX
GO
/****** Object:  StoredProcedure [dbo].[sp_GetAllTheLoai]    Script Date: 1/12/2020 3:16:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_GetAllTheLoai]
as
select * from tblTheLoai
GO
/****** Object:  StoredProcedure [dbo].[sp_GetAllUser]    Script Date: 1/12/2020 3:16:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_GetAllUser]
AS
SELECT * FROM dbo.tblUser
GO
/****** Object:  StoredProcedure [dbo].[sp_GetInfoAccount]    Script Date: 1/12/2020 3:16:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_GetInfoAccount]
@userName NVARCHAR(50)
AS
SELECT * FROM dbo.tblUser WHERE userName = @userName
GO
/****** Object:  StoredProcedure [dbo].[sp_GetInfoHangHoa]    Script Date: 1/12/2020 3:16:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_GetInfoHangHoa]
@SoHDN nvarchar(50)
as
	select cthdn.MaHang , hh.TenHangHoa, cthdn.SoLuong, 
	hh.DonGiaNhap , cthdn.GiamGia, cthdn.ThanhTien from tblChiTietHDNhap cthdn, tblHangHoa hh
	where cthdn.SoHDN = @SoHDN AND cthdn.MaHang = hh.MaHang
GO
/****** Object:  StoredProcedure [dbo].[sp_GetInfoHangHoaHDB]    Script Date: 1/12/2020 3:16:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_GetInfoHangHoaHDB]
@SoHDB nvarchar(50)
as
	select cthdb.MaHang , hh.TenHangHoa, cthdb.SoLuong, 
	hh.DonGiaBan , cthdb.GiamGia, cthdb.ThanhTien from tblChiTietHDBan cthdb, tblHangHoa hh
	where cthdb.SoHDB = @SoHDB AND cthdb.MaHang = hh.MaHang
GO
/****** Object:  StoredProcedure [dbo].[sp_GetSoLuongHang]    Script Date: 1/12/2020 3:16:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_GetSoLuongHang]
AS
begin

	select hh.MaHang, hh.SoLuong , h.SoLuong From tblHangHoa hh,dbo.tblChiTietHDNhap h 
	where hh.MaHang = h.MaHang

	declare @MaHang nvarchar(50),@SoLuong int,@SL int,@Tong int
	begin
		set @Tong = @SoLuong + @SL	
		update tblHangHoa set SoLuong = @Tong where MaHang = @MaHang
	end
	
end
GO
/****** Object:  StoredProcedure [dbo].[sp_getYearHDB]    Script Date: 1/12/2020 3:16:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_getYearHDB]
as
SELECT DISTINCT(YEAR(NgayBan)) AS NamHienCo
FROM dbo.tblHDBan 
GO
/****** Object:  StoredProcedure [dbo].[sp_getYearHDN]    Script Date: 1/12/2020 3:16:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_getYearHDN]
as
SELECT DISTINCT(YEAR(NgayNhap)) AS NamHienCo
FROM dbo.tblHDNhap 
GO
/****** Object:  StoredProcedure [dbo].[sp_InsertCaLam]    Script Date: 1/12/2020 3:16:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_InsertCaLam]
@MaCa nvarchar(50),
@TenCa nvarchar(50)
as
insert into tblCaLam(MaCa,TenCa)
values (@MaCa,@TenCa)
GO
/****** Object:  StoredProcedure [dbo].[sp_InsertChatLieu]    Script Date: 1/12/2020 3:16:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_InsertChatLieu]
@MaChatLieu nvarchar(50),
@TenChatLieu nvarchar(50)
as
insert into tblChatLieu(MaChatLieu,TenChatLieu)
values (@MaChatLieu,@TenChatLieu)
GO
/****** Object:  StoredProcedure [dbo].[sp_InsertCongDung]    Script Date: 1/12/2020 3:16:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_InsertCongDung]
@MaCongDung nvarchar(50),
@TenCongDung nvarchar(50)
as
insert into tblCongDung(MaCongDung,TenCongDung)
values (@MaCongDung,@TenCongDung)
GO
/****** Object:  StoredProcedure [dbo].[sp_InsertCongViec]    Script Date: 1/12/2020 3:16:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_InsertCongViec]
@MaCV nvarchar(50),
@TenCV nvarchar(50)
as
insert into tblCongViec(MaCV,TenCV)
values (@MaCV,@TenCV)
GO
/****** Object:  StoredProcedure [dbo].[sp_InsertCTHDB]    Script Date: 1/12/2020 3:16:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_InsertCTHDB]
@SoHDB nvarchar(50),
@MaHang nvarchar(50),
@SoLuong int,
@GiamGia int,
@ThanhTien int
as
insert into tblChiTietHDBan(SoHDB, MaHang,SoLuong, GiamGia,ThanhTien)
VALUES (@SoHDB, @MaHang, @SoLuong, @GiamGia, @ThanhTien)
GO
/****** Object:  StoredProcedure [dbo].[sp_InsertCTHDN]    Script Date: 1/12/2020 3:16:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_InsertCTHDN]
@SoHDN nvarchar(50),
@MaHang nvarchar(50),
@SoLuong int,
@DonGia int,
@GiamGia int,
@ThanhTien int
as
insert into tblChiTietHDNhap(SoHDN, MaHang,SoLuong, DonGia, GiamGia,ThanhTien)
VALUES (@SoHDN, @MaHang, @SoLuong, @DonGia, @GiamGia, @ThanhTien)
GO
/****** Object:  StoredProcedure [dbo].[sp_InsertDonViTinh]    Script Date: 1/12/2020 3:16:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_InsertDonViTinh]
@MaDonVi nvarchar(50),
@TenDonVi nvarchar(50)
as
insert into tblDonViTinh(MaDonVi,TenDonVi)
values (@MaDonVi,@TenDonVi)
GO
/****** Object:  StoredProcedure [dbo].[sp_InsertHangHoa]    Script Date: 1/12/2020 3:16:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_InsertHangHoa]
@MaHang NVarChar(50),
@TenHangHoa NVarChar(50),
@MaNhom NVarChar(50),
@SoLuong Int,
@DonGiaNhap Int,
@MaLoai NVARCHAR(50),
@NhapKhau NVARCHAR(50),
@MaDonVi NVARCHAR(50),
@MaChatLieu NVARCHAR(50),
@MaCongDung NVARCHAR(50),
@MaNoiSX NVARCHAR(50),
@Anh IMAGE,
@GhiChu NVARCHAR(MAX)
as
	insert into 
	dbo.tblHangHoa(MaHang,TenHangHoa,MaNhom,SoLuong,DonGiaNhap,
					MaLoai,NhapKhau,MaDonVi,MaChatLieu,MaCongDung,MaNoiSX,Anh,GhiChu)
	VALUES (@MaHang, @TenHangHoa,@MaNhom,@SoLuong,@DonGiaNhap
	,@MaLoai,@NhapKhau,@MaDonVi,@MaChatLieu,@MaCongDung,@MaNoiSX,@Anh,@GhiChu)
GO
/****** Object:  StoredProcedure [dbo].[sp_InsertHDBan]    Script Date: 1/12/2020 3:16:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_InsertHDBan]
@SoHDB NVarChar(50),
            @MaNV NVarChar(50),
           @NgayBan Date,
          @MaKhach NVarChar(50),
            @TongTien int
			as
			insert into tblHDBan(SoHDB,MaNV, NgayBan, MaKhach, TongTien)
			VALUES (@SoHDB,@MaNV,@NgayBan,@MaKhach,@TongTien)
GO
/****** Object:  StoredProcedure [dbo].[sp_InsertHDNhap]    Script Date: 1/12/2020 3:16:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_InsertHDNhap]
@SoHDN NVarChar(50),
            @MaNV NVarChar(50),
           @NgayNhap Date,
          @MaNCC NVarChar(50),
            @TongTien int
			as
			insert into tblHDNhap (SoHDN,MaNV, NgayNhap, MaNCC, TongTien)
			VALUES (@SoHDN,@MaNV,@NgayNhap,@MaNCC,@TongTien)
GO
/****** Object:  StoredProcedure [dbo].[sp_InsertKhachHang]    Script Date: 1/12/2020 3:16:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_InsertKhachHang]
@MaKhach nvarchar(50),
@TenKhach nvarchar(50),
@DiaChi NVARCHAR(200),
@DienThoai NVARCHAR(20)
as
	insert into dbo.tblKhachHang(MaKhach,TenKhach,DiaChi,DienThoai)
	VALUES (@MaKhach, @TenKhach,@DiaChi,@DienThoai)
GO
/****** Object:  StoredProcedure [dbo].[sp_InsertNCC]    Script Date: 1/12/2020 3:16:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_InsertNCC]
@MaNCC nvarchar(50),
@TenNCC nvarchar(50),
@DiaChi NVARCHAR(200),
@DienThoai NVARCHAR(20)
as
	insert into dbo.tblNCC(MaNCC,TenNCC,DiaChi,DienThoai)
	VALUES (@MaNCC, @TenNCC,@DiaChi,@DienThoai)
GO
/****** Object:  StoredProcedure [dbo].[sp_InsertNhanVien]    Script Date: 1/12/2020 3:16:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_InsertNhanVien]
@MaNV nvarchar(50),
@TenNV nvarchar(50),
@GioiTinh NVARCHAR(10),
@NgaySinh DATE,
@DienThoai NVARCHAR(20),
@DiaChi NVARCHAR(200),
@MaNhom NVARCHAR(50),
@MaCa NVARCHAR(50),
@MaCV NVARCHAR(50)
as
	insert into dbo.tblNhanVien (MaNV,TenNV,GioiTinh,NgaySinh,DienThoai,DiaChi,MaNhom,MaCa,MaCV)
	VALUES (@MaNV, @TenNV,@GioiTinh,@NgaySinh,@DienThoai,@DiaChi,@MaNhom,@MaCa,@MaCV)
GO
/****** Object:  StoredProcedure [dbo].[sp_InsertNhomHang]    Script Date: 1/12/2020 3:16:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_InsertNhomHang]
@MaNhom nvarchar(50),
@TenNhom nvarchar(50)
as
	insert into dbo.tblNhomHang(MaNhom,TenNhom)
	VALUES (@MaNhom, @TenNhom)
GO
/****** Object:  StoredProcedure [dbo].[sp_InsertNoiSX]    Script Date: 1/12/2020 3:16:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_InsertNoiSX]
@MaNoiSX nvarchar(50),
@TenNoiSX nvarchar(50)
as
insert into tblNoiSX(MaNoiSX,TenNoiSX)
values (@MaNoiSX,@TenNoiSX)
GO
/****** Object:  StoredProcedure [dbo].[sp_InsertTheLoai]    Script Date: 1/12/2020 3:16:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_InsertTheLoai]
@MaLoai nvarchar(50), @MaNhom nvarchar(50), @TenLoai nvarchar(50)
as
insert into tblTheLoai (MaLoai,MaNhom,TenLoai)
values (@MaLoai,@MaNhom,@TenLoai)
GO
/****** Object:  StoredProcedure [dbo].[sp_InsertUser]    Script Date: 1/12/2020 3:16:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_InsertUser]
@userName NVARCHAR(50),
@passWord NVARCHAR(50),
@status INT,
@role INT
AS
	INSERT INTO dbo.tblUser
	(
	    userName,
	    passWord,
	    status,
	    role
	)
	VALUES
	(   @userName, -- userName - nvarchar(50)
	    @passWord, -- passWord - nvarchar(50)
	    @status,   -- status - int
	    @role    -- role - int
	    )
GO
/****** Object:  StoredProcedure [dbo].[sp_KhachHang_MuaItHangNhat]    Script Date: 1/12/2020 3:16:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_KhachHang_MuaItHangNhat]
    @ThangTruoc INT,
    @ThangSau INT,
    @Nam INT
AS
BEGIN
    SELECT TOP 3 WITH TIES
           hdb.MaKhach,
           kh.TenKhach,
           kh.DiaChi,
           kh.DienThoai,
           SUM(cthdb.SoLuong) SoLuong
    FROM dbo.tblChiTietHDBan cthdb,
         dbo.tblHDBan hdb,
         dbo.tblKhachHang kh
    WHERE cthdb.SoHDB = hdb.SoHDB
          AND kh.MaKhach = hdb.MaKhach
          AND YEAR(hdb.NgayBan) = @Nam
          AND MONTH(hdb.NgayBan) BETWEEN @ThangTruoc AND @ThangSau
    GROUP BY hdb.MaKhach,
             kh.TenKhach,
             kh.DiaChi,
             kh.DienThoai
    ORDER BY SUM(cthdb.SoLuong) ASC;
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_MaxBill]    Script Date: 1/12/2020 3:16:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_MaxBill]
@Year INT
AS
BEGIN
    SELECT TOP 3 WITH TIES SoHDN, SUM(TongTien) FROM dbo.tblHDNhap
	WHERE YEAR(NgayNhap) = @Year
	GROUP BY SoHDN
	ORDER BY SUM(TongTien) DESC
END
GO
/****** Object:  StoredProcedure [dbo].[sp_MaxBillHDB]    Script Date: 1/12/2020 3:16:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_MaxBillHDB]
@Year INT
AS
BEGIN
    SELECT TOP 3 WITH TIES SoHDB, SUM(TongTien) FROM dbo.tblHDBan
	WHERE YEAR(NgayBan) = @Year
	GROUP BY SoHDB
	ORDER BY SUM(TongTien) DESC
END
GO
/****** Object:  StoredProcedure [dbo].[sp_rpBillHDB]    Script Date: 1/12/2020 3:16:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_rpBillHDB]
@MaNV NVARCHAR(50)
AS
BEGIN
    SELECT ISNULL(hdb.SoHDB,'Tong') AS SoHDB, hdb.MaNV,hdb.NgayBan,hdb.MaKhach,SUM(hdb.TongTien) Tien FROM dbo.tblHDBan hdb
	WHERE MaNV = @MaNV
	GROUP BY GROUPING SETS ((hdb.SoHDB,hdb.MaNV,hdb.NgayBan,hdb.MaKhach),())
END
GO
/****** Object:  StoredProcedure [dbo].[sp_SoLuongHangHoa]    Script Date: 1/12/2020 3:16:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_SoLuongHangHoa]
@MaHang nvarchar(50),
@SoLuong int output
as
select @SoLuong = hh.SoLuong + h.SoLuong From tblHangHoa hh,dbo.tblChiTietHDNhap h 
where @MaHang = hh.MaHang AND hh.MaHang = h.MaHang

return @SoLuong
GO
/****** Object:  StoredProcedure [dbo].[sp_SPBanChayNhat]    Script Date: 1/12/2020 3:16:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_SPBanChayNhat]
@Truoc INT,
@Sau INT
AS
BEGIN
	SELECT cth.MaHang,SUM(cth.SoLuong) FROM dbo.tblChiTietHDBan cth,dbo.tblHDBan hd,dbo.tblHangHoa hh
	WHERE (MONTH(hd.NgayBan) BETWEEN @Truoc AND @Sau) AND cth.SoHDB = hd.SoHDB AND cth.MaHang = hh.MaHang
	GROUP BY cth.MaHang
	HAVING SUM(cth.SoLuong) =
	(
		SELECT TOP 1 SUM(cth.SoLuong) FROM dbo.tblChiTietHDBan cth,dbo.tblHDBan hd 
		WHERE cth.SoHDB = hd.SoHDB
		GROUP BY cth.MaHang
		ORDER BY SUM(cth.SoLuong) DESC
	)
END
GO
/****** Object:  StoredProcedure [dbo].[sp_SPBanChayNhatTheoThang]    Script Date: 1/12/2020 3:16:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_SPBanChayNhatTheoThang]
    @Thang INT,
    @Year INT
AS
BEGIN
    SELECT cth.MaHang,hh.TenHangHoa,hh.DonGiaNhap,hh.DonGiaBan,SUM(cth.SoLuong)
    FROM dbo.tblChiTietHDBan cth,
         dbo.tblHDBan hd,
         dbo.tblHangHoa hh
    WHERE
          cth.SoHDB = hd.SoHDB
          AND cth.MaHang = hh.MaHang AND MONTH(hd.NgayBan) = @Thang AND YEAR(hd.NgayBan) = @Year
    GROUP BY cth.MaHang,hh.TenHangHoa,hh.DonGiaNhap,hh.DonGiaBan
             
    HAVING SUM(cth.SoLuong) =
    (
        SELECT TOP 1 SUM(cth.SoLuong)
        FROM dbo.tblChiTietHDBan cth,
             dbo.tblHDBan hd
        WHERE cth.SoHDB = hd.SoHDB AND MONTH(hd.NgayBan) = @Thang AND YEAR(hd.NgayBan) = @Year
        GROUP BY cth.MaHang
        ORDER BY SUM(cth.SoLuong) DESC
    );
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateCaLam]    Script Date: 1/12/2020 3:16:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_UpdateCaLam]
@MaCa nvarchar(50),
@TenCa nvarchar(50)
as
update tblCaLam
set TenCa = @TenCa WHERE MaCa = @MaCa
GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateChatLieu]    Script Date: 1/12/2020 3:16:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_UpdateChatLieu]
@MaChatLieu nvarchar(50),
@TenChatLieu nvarchar(50)
as
update tblChatLieu
set TenChatLieu = @TenChatLieu WHERE MaChatLieu = @MaChatLieu
GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateCongDung]    Script Date: 1/12/2020 3:16:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_UpdateCongDung]
@MaCongDung nvarchar(50),
@TenCongDung nvarchar(50)
as
update tblCongDung
SET TenCongDung = @TenCongDung WHERE MaCongDung = @MaCongDung
GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateCongViec]    Script Date: 1/12/2020 3:16:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_UpdateCongViec]
@MaCV nvarchar(50),
@TenCV nvarchar(50)
as
update tblCongViec
SET TenCV = @TenCV WHERE MaCV = @MaCV
GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateDonViTinh]    Script Date: 1/12/2020 3:16:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_UpdateDonViTinh]
@MaDonVi nvarchar(50),
@TenDonVi nvarchar(50)
as
update tblDonViTinh
set  TenDonVi = @TenDonVi WHERE MaDonVi = @MaDonVi
GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateHangHoa]    Script Date: 1/12/2020 3:16:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_UpdateHangHoa]
    @MaHang NVARCHAR(50),
    @TenHangHoa NVARCHAR(50),
    @MaNhom NVARCHAR(50),
    @SoLuong INT,
    @DonGiaNhap INT,
    @MaLoai NVARCHAR(50),
    @NhapKhau NVARCHAR(50),
    @MaDonVi NVARCHAR(50),
    @MaChatLieu NVARCHAR(50),
    @MaCongDung NVARCHAR(50),
    @MaNoiSX NVARCHAR(50),
    @Anh IMAGE,
    @GhiChu NVARCHAR(MAX)
AS
UPDATE dbo.tblHangHoa
SET TenHangHoa = @TenHangHoa,
    MaNhom = @MaNhom,
    SoLuong = @SoLuong,
    DonGiaNhap = @DonGiaNhap,
    MaLoai = @MaLoai,
    NhapKhau = @NhapKhau,
    MaDonVi = @MaDonVi,
    MaChatLieu = @MaChatLieu,
    MaCongDung = @MaCongDung,
    MaNoiSX = @MaNoiSX,
    Anh = @Anh,
    GhiChu = @GhiChu
WHERE MaHang = @MaHang;
GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateHDBan]    Script Date: 1/12/2020 3:16:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_UpdateHDBan]
	@SoHDB NVARCHAR(50),
	@MaNV NVARCHAR(50),
    @NgayBan DATE,
    @MaKhach NVARCHAR(50),
    @TongTien int
AS
UPDATE dbo.tblHDBan SET
MaNV = @MaNV,NgayBan = @NgayBan,MaKhach = @MaKhach,TongTien = @TongTien WHERE SoHDB = @SoHDB
GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateHDNhap]    Script Date: 1/12/2020 3:16:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_UpdateHDNhap]
	@SoHDN NVARCHAR(50),
	@MaNV NVARCHAR(50),
    @NgayNhap DATE,
    @MaNCC NVARCHAR(50),
    @TongTien int
AS
UPDATE dbo.tblHDNhap SET
MaNV = @MaNV,NgayNhap = @NgayNhap,MaNCC = @MaNCC,TongTien = @TongTien WHERE SoHDN = @SoHDN
GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateKhachHang]    Script Date: 1/12/2020 3:16:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_UpdateKhachHang]
@MaKhach nvarchar(50),
@TenKhach nvarchar(50),
@DiaChi NVARCHAR(200),
@DienThoai NVARCHAR(20)
AS
UPDATE dbo.tblKhachHang
SET 
	TenKhach = @TenKhach,
	DiaChi = @DiaChi,
	DienThoai = @DienThoai
	WHERE MaKhach = @MaKhach
GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateNCC]    Script Date: 1/12/2020 3:16:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_UpdateNCC]
@MaNCC nvarchar(50),
@TenNCC nvarchar(50),
@DiaChi NVARCHAR(200),
@DienThoai NVARCHAR(20)
AS
UPDATE dbo.tblNCC
SET 
	TenNCC = @TenNCC,
	DiaChi = @DiaChi,
	DienThoai  = @DienThoai
	WHERE MaNCC = @MaNCC
GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateNhanVien]    Script Date: 1/12/2020 3:16:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_UpdateNhanVien]
    @MaNV NVARCHAR(50),
    @TenNV NVARCHAR(50),
    @GioiTinh NVARCHAR(10),
    @NgaySinh DATE,
    @DienThoai NVARCHAR(20),
    @DiaChi NVARCHAR(200),
    @MaNhom NVARCHAR(50),
    @MaCa NVARCHAR(50),
    @MaCV NVARCHAR(50)
AS
UPDATE dbo.tblNhanVien
SET TenNV = @TenNV,
    GioiTinh = @GioiTinh,
    NgaySinh = @NgaySinh,
    DienThoai = @DienThoai,
    DiaChi = @DiaChi,
    MaNhom = @MaNhom,
    MaCa = @MaCa,
    MaCV = @MaCV
WHERE MaNV = @MaNV;
GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateNhomHang]    Script Date: 1/12/2020 3:16:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_UpdateNhomHang]
    @MaNhom NVARCHAR(50),
    @TenNhom NVARCHAR(50)
AS
UPDATE dbo.tblNhomHang
SET TenNhom = @TenNhom
WHERE MaNhom = @MaNhom;
GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateNoiSX]    Script Date: 1/12/2020 3:16:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_UpdateNoiSX]
@MaNoiSX nvarchar(50),
@TenNoiSX nvarchar(50)
as
update tblNoiSX
set  TenNoiSX = @TenNoiSX WHERE MaNoiSX = @MaNoiSX
GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateTheLoai]    Script Date: 1/12/2020 3:16:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_UpdateTheLoai]
@MaLoai nvarchar(50), @MaNhom nvarchar(50), @TenLoai nvarchar(50)
as
update tblTheLoai
set  MaNhom = @MaNhom, TenLoai = @TenLoai WHERE MaLoai = @MaLoai
GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateTongTienHDB]    Script Date: 1/12/2020 3:16:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_UpdateTongTienHDB]
@SoHDB nvarchar(50),
@TongTien int
as
update tblHDBan
set TongTien = @TongTien where SoHDB = @SoHDB
GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateTongTienHDN]    Script Date: 1/12/2020 3:16:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_UpdateTongTienHDN]
@SoHDN nvarchar(50),
@TongTien int
as
update tblHDNhap
set TongTien = @TongTien where SoHDN = @SoHDN
GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateUser]    Script Date: 1/12/2020 3:16:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_UpdateUser]
@id INT,
@userName NVARCHAR(50),
@passWord NVARCHAR(50),
@status INT,
@role INT
AS
	UPDATE dbo.tblUser	SET
    userName = @userName, passWord = @passWord, status = @status, role = @role
	WHERE id = @id
GO
/****** Object:  StoredProcedure [dbo].[sp_UpSLHang]    Script Date: 1/12/2020 3:16:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_UpSLHang]
@MaHang nvarchar(50),
@SoLuong int
as
	update tblHangHoa
	set SoLuong = @SoLuong where MaHang = @MaHang
GO
/****** Object:  StoredProcedure [dbo].[sp_XuatHoaDonBan]    Script Date: 1/12/2020 3:16:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_XuatHoaDonBan]
@SoHDB NVARCHAR(50)
AS
BEGIN
	SELECT a.SoHDB, a.NgayBan, a.TongTien, b.TenKhach, b.DiaChi, b.DienThoai, c.TenNV 
	FROM dbo.tblHDBan AS a, dbo.tblKhachHang AS b, tblNhanVien AS c
	WHERE a.SoHDB = @SoHDB AND a.MaKhach = b.MaKhach AND a.MaNV = c.MaNV
END
GO
/****** Object:  StoredProcedure [dbo].[sp_XuatHoaDonNhap]    Script Date: 1/12/2020 3:16:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_XuatHoaDonNhap]
@SoHDN NVARCHAR(50)
AS
BEGIN
	SELECT a.SoHDN, a.NgayNhap, a.TongTien, b.TenNCC, b.DiaChi, b.DienThoai, c.TenNV 
	FROM dbo.tblHDNhap AS a, dbo.tblNCC AS b, tblNhanVien AS c 
	WHERE a.SoHDN = @SoHDN AND a.MaNCC = b.MaNCC AND a.MaNV = c.MaNV
END
GO
/****** Object:  StoredProcedure [dbo].[sp_XuatMatHangHDB]    Script Date: 1/12/2020 3:16:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_XuatMatHangHDB]
@SoHDB NVARCHAR(50)
AS
BEGIN
	SELECT b.TenHangHoa, a.SoLuong, b.DonGiaBan, a.GiamGia, a.ThanhTien
    FROM dbo.tblChiTietHDBan AS a , dbo.tblHangHoa AS b WHERE a.SoHDB = @SoHDB
    AND a.MaHang = b.MaHang
END
GO
/****** Object:  StoredProcedure [dbo].[sp_XuatMatHangHDN]    Script Date: 1/12/2020 3:16:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_XuatMatHangHDN]
@SoHDN NVARCHAR(50)
AS
BEGIN
	SELECT b.TenHangHoa, a.SoLuong, b.DonGiaBan, a.GiamGia, a.ThanhTien
    FROM dbo.tblChiTietHDNhap AS a , dbo.tblHangHoa AS b WHERE a.SoHDN = @SoHDN
    AND a.MaHang = b.MaHang
END
GO
/****** Object:  Trigger [dbo].[trg_NhapHangBan]    Script Date: 1/12/2020 3:16:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[trg_NhapHangBan] ON [dbo].[tblChiTietHDBan]
AFTER INSERT AS
BEGIN
	DECLARE @mh NVARCHAR(15),@SoLuong INT	select @mh=MaHang,@SoLuong=SoLuong from inserted	update dbo.tblHangHoa set SoLuong=SoLuong-@SoLuong where MaHang=@mh
END
GO
ALTER TABLE [dbo].[tblChiTietHDBan] ENABLE TRIGGER [trg_NhapHangBan]
GO
/****** Object:  Trigger [dbo].[trg_CapNhatHang]    Script Date: 1/12/2020 3:16:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[trg_CapNhatHang] ON [dbo].[tblChiTietHDNhap]
AFTER UPDATE AS
BEGIN
	DECLARE @mahang NVARCHAR(50), @soluongmoi INT,@soluongcu INT
	SELECT @mahang = MaHang, @soluongmoi = SoLuong
	FROM Inserted
	SELECT @soluongcu = SoLuong
	FROM Deleted
	UPDATE dbo.tblHangHoa SET SoLuong = SoLuong - @soluongcu + @soluongmoi WHERE MaHang = @mahang
END
GO
ALTER TABLE [dbo].[tblChiTietHDNhap] ENABLE TRIGGER [trg_CapNhatHang]
GO
/****** Object:  Trigger [dbo].[trg_DonGiaNhap_CTHDN]    Script Date: 1/12/2020 3:16:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[trg_DonGiaNhap_CTHDN]
ON [dbo].[tblChiTietHDNhap] FOR INSERT
AS
	DECLARE @MaHang NVARCHAR(50),@DonGiaNhap int
	SELECT @MaHang = Inserted.MaHang,@DonGiaNhap = Inserted.DonGia FROM Inserted
	UPDATE dbo.tblHangHoa SET
    DonGiaNhap = @DonGiaNhap WHERE MaHang = @MaHang
GO
ALTER TABLE [dbo].[tblChiTietHDNhap] ENABLE TRIGGER [trg_DonGiaNhap_CTHDN]
GO
/****** Object:  Trigger [dbo].[trg_HuyHang]    Script Date: 1/12/2020 3:16:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[trg_HuyHang] ON [dbo].[tblChiTietHDNhap]
AFTER DELETE AS
BEGIN
	DECLARE @mh NVARCHAR(50),@sl INT
	SELECT @mh = MaHang, @sl = SoLuong
	FROM Deleted

	UPDATE dbo.tblHangHoa SET SoLuong = SoLuong + @sl WHERE MaHang = @mh
END
GO
ALTER TABLE [dbo].[tblChiTietHDNhap] ENABLE TRIGGER [trg_HuyHang]
GO
/****** Object:  Trigger [dbo].[trg_NhapHang]    Script Date: 1/12/2020 3:16:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[trg_NhapHang] ON [dbo].[tblChiTietHDNhap]
AFTER INSERT AS
BEGIN
	DECLARE @mh NVARCHAR(50),@SoLuong INT
	select @mh=MaHang,@SoLuong=SoLuong from inserted
	update dbo.tblHangHoa set SoLuong=SoLuong+@SoLuong where MaHang=@mh
END
GO
ALTER TABLE [dbo].[tblChiTietHDNhap] ENABLE TRIGGER [trg_NhapHang]
GO
/****** Object:  Trigger [dbo].[trg_UpdateDonGiaBan]    Script Date: 1/12/2020 3:16:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[trg_UpdateDonGiaBan] ON [dbo].[tblHangHoa]
FOR INSERT,UPDATE
AS
BEGIN
	DECLARE @dgb INT,@mahang NVARCHAR(50)
	SELECT @mahang =  MaHang,@dgb = DonGiaNhap FROM Inserted
	UPDATE dbo.tblHangHoa SET
    DonGiaBan = @dgb * 1.1
	WHERE MaHang = @mahang
END
GO
ALTER TABLE [dbo].[tblHangHoa] ENABLE TRIGGER [trg_UpdateDonGiaBan]
GO
