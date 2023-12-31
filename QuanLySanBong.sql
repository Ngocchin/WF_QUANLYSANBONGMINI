USE [QuanLySanBong]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 11/26/2023 10:28:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Account](
	[UserName] [varchar](100) NOT NULL,
	[DisplayName] [nvarchar](100) NOT NULL,
	[PassWord] [varchar](1000) NOT NULL,
	[Quyen] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[UserName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 11/26/2023 10:28:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HoaDon](
	[Ma_HD] [int] IDENTITY(1,1) NOT NULL,
	[Ma_KhachHang] [varchar](100) NULL,
	[Ma_San] [varchar](100) NOT NULL,
	[NgayLap_HD] [date] NOT NULL,
	[TongPhut_Da] [int] NOT NULL,
	[DonGia] [float] NULL,
	[TongTien_HD] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[Ma_HD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 11/26/2023 10:28:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KhachHang](
	[Ma_KhachHang] [varchar](100) NOT NULL,
	[Ten_KhachHang] [nvarchar](100) NOT NULL DEFAULT (N'Chưa nhập!'),
	[DiaChi_KhachHang] [nvarchar](150) NOT NULL DEFAULT (N'Chưa nhập!'),
	[Sdt_KhachHang] [varchar](100) NOT NULL DEFAULT ((123456789)),
PRIMARY KEY CLUSTERED 
(
	[Ma_KhachHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LoaiSan]    Script Date: 11/26/2023 10:28:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LoaiSan](
	[Loai_San] [varchar](100) NOT NULL,
	[Ten_Loai] [nvarchar](100) NOT NULL,
	[GiaLoai_San] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[Loai_San] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[San]    Script Date: 11/26/2023 10:28:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[San](
	[Ma_San] [varchar](100) NOT NULL,
	[Loai_San] [varchar](100) NOT NULL,
	[Ten_San] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Ma_San] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ThueSan]    Script Date: 11/26/2023 10:28:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ThueSan](
	[Ma_ThueSan] [int] IDENTITY(1,1) NOT NULL,
	[Ma_San] [varchar](100) NULL,
	[Ma_KhachHang] [varchar](100) NULL,
	[ThoiGianBatDau] [datetime] NULL,
	[ThoiGianKetThuc] [datetime] NULL,
	[LoaiThue] [nvarchar](50) NULL,
	[DonGia] [float] NULL,
	[ThanhTien] [nchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[Ma_ThueSan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Account] ([UserName], [DisplayName], [PassWord], [Quyen]) VALUES (N'nguyentrinh', N'Nguyễn Thị Ngọc Trinh', N'123', N'Admin')
INSERT [dbo].[Account] ([UserName], [DisplayName], [PassWord], [Quyen]) VALUES (N'quangphuc', N'Nguyễn Quang Phúc', N'123', N'User')
SET IDENTITY_INSERT [dbo].[HoaDon] ON 

INSERT [dbo].[HoaDon] ([Ma_HD], [Ma_KhachHang], [Ma_San], [NgayLap_HD], [TongPhut_Da], [DonGia], [TongTien_HD]) VALUES (1, N'KH1', N'SAN1', CAST(N'2023-11-23' AS Date), 60, 20000, 120000)
INSERT [dbo].[HoaDon] ([Ma_HD], [Ma_KhachHang], [Ma_San], [NgayLap_HD], [TongPhut_Da], [DonGia], [TongTien_HD]) VALUES (2, N'KH3', N'SAN2', CAST(N'2023-11-24' AS Date), 60, 40000, 240000)
INSERT [dbo].[HoaDon] ([Ma_HD], [Ma_KhachHang], [Ma_San], [NgayLap_HD], [TongPhut_Da], [DonGia], [TongTien_HD]) VALUES (3, N'KH4', N'SAN3', CAST(N'2023-11-25' AS Date), 60, 80000, 480000)
INSERT [dbo].[HoaDon] ([Ma_HD], [Ma_KhachHang], [Ma_San], [NgayLap_HD], [TongPhut_Da], [DonGia], [TongTien_HD]) VALUES (4, N'KH2', N'SAN4', CAST(N'2023-11-26' AS Date), 60, 20000, 120000)
INSERT [dbo].[HoaDon] ([Ma_HD], [Ma_KhachHang], [Ma_San], [NgayLap_HD], [TongPhut_Da], [DonGia], [TongTien_HD]) VALUES (5, N'KH5', N'SAN5', CAST(N'2023-11-27' AS Date), 60, 40000, 240000)
INSERT [dbo].[HoaDon] ([Ma_HD], [Ma_KhachHang], [Ma_San], [NgayLap_HD], [TongPhut_Da], [DonGia], [TongTien_HD]) VALUES (6, N'KH6', N'SAN6', CAST(N'2023-11-28' AS Date), 60, 80000, 480000)
INSERT [dbo].[HoaDon] ([Ma_HD], [Ma_KhachHang], [Ma_San], [NgayLap_HD], [TongPhut_Da], [DonGia], [TongTien_HD]) VALUES (7, N'KH5', N'SAN6', CAST(N'2023-11-29' AS Date), 60, 2000, 120000)
SET IDENTITY_INSERT [dbo].[HoaDon] OFF
INSERT [dbo].[KhachHang] ([Ma_KhachHang], [Ten_KhachHang], [DiaChi_KhachHang], [Sdt_KhachHang]) VALUES (N'KH1', N'Lê Văn A', N'Hà Tĩnh', N'0689712942')
INSERT [dbo].[KhachHang] ([Ma_KhachHang], [Ten_KhachHang], [DiaChi_KhachHang], [Sdt_KhachHang]) VALUES (N'KH2', N'Nguyễn Văn B', N'Bình Dương', N'0623452314')
INSERT [dbo].[KhachHang] ([Ma_KhachHang], [Ten_KhachHang], [DiaChi_KhachHang], [Sdt_KhachHang]) VALUES (N'KH3', N'Nguyễn Văn C', N'Thanh Hóa', N'0786583521')
INSERT [dbo].[KhachHang] ([Ma_KhachHang], [Ten_KhachHang], [DiaChi_KhachHang], [Sdt_KhachHang]) VALUES (N'KH4', N'Nguyễn Văn D', N'Đồng Nai', N'0987234224')
INSERT [dbo].[KhachHang] ([Ma_KhachHang], [Ten_KhachHang], [DiaChi_KhachHang], [Sdt_KhachHang]) VALUES (N'KH5', N'Nguyễn Văn E', N'Tp.HCM', N'0978943634')
INSERT [dbo].[KhachHang] ([Ma_KhachHang], [Ten_KhachHang], [DiaChi_KhachHang], [Sdt_KhachHang]) VALUES (N'KH6', N'Trần Văn A', N'Đà Nẵng', N'0272352342')
INSERT [dbo].[KhachHang] ([Ma_KhachHang], [Ten_KhachHang], [DiaChi_KhachHang], [Sdt_KhachHang]) VALUES (N'KH7', N'Trần Văn Khánh', N'LTT', N'0837464373')
INSERT [dbo].[LoaiSan] ([Loai_San], [Ten_Loai], [GiaLoai_San]) VALUES (N'Loai1', N'Sân 6 người', 20000)
INSERT [dbo].[LoaiSan] ([Loai_San], [Ten_Loai], [GiaLoai_San]) VALUES (N'Loai2', N'Sân 10 người', 40000)
INSERT [dbo].[LoaiSan] ([Loai_San], [Ten_Loai], [GiaLoai_San]) VALUES (N'Loai3', N'Sân 14 người', 80000)
INSERT [dbo].[San] ([Ma_San], [Loai_San], [Ten_San]) VALUES (N'SAN1', N'Loai1', N'Sân 1')
INSERT [dbo].[San] ([Ma_San], [Loai_San], [Ten_San]) VALUES (N'SAN2', N'Loai2', N'Sân 2')
INSERT [dbo].[San] ([Ma_San], [Loai_San], [Ten_San]) VALUES (N'SAN3', N'Loai3', N'Sân 3')
INSERT [dbo].[San] ([Ma_San], [Loai_San], [Ten_San]) VALUES (N'SAN4', N'Loai1', N'Sân 4')
INSERT [dbo].[San] ([Ma_San], [Loai_San], [Ten_San]) VALUES (N'SAN5', N'Loai2', N'Sân 5')
INSERT [dbo].[San] ([Ma_San], [Loai_San], [Ten_San]) VALUES (N'SAN6', N'Loai3', N'Sân 6')
SET IDENTITY_INSERT [dbo].[ThueSan] ON 

INSERT [dbo].[ThueSan] ([Ma_ThueSan], [Ma_San], [Ma_KhachHang], [ThoiGianBatDau], [ThoiGianKetThuc], [LoaiThue], [DonGia], [ThanhTien]) VALUES (1, N'SAN1', N'KH1', CAST(N'2023-11-23 17:00:00.000' AS DateTime), CAST(N'2023-11-23 18:00:00.000' AS DateTime), N'Trực tiếp', 20000, N'120000    ')
INSERT [dbo].[ThueSan] ([Ma_ThueSan], [Ma_San], [Ma_KhachHang], [ThoiGianBatDau], [ThoiGianKetThuc], [LoaiThue], [DonGia], [ThanhTien]) VALUES (2, N'SAN2', N'KH3', CAST(N'2023-11-24 18:00:00.000' AS DateTime), CAST(N'2023-11-24 19:00:00.000' AS DateTime), N'Đặt trước', 40000, N'240000    ')
INSERT [dbo].[ThueSan] ([Ma_ThueSan], [Ma_San], [Ma_KhachHang], [ThoiGianBatDau], [ThoiGianKetThuc], [LoaiThue], [DonGia], [ThanhTien]) VALUES (3, N'SAN3', N'KH4', CAST(N'2023-11-25 19:00:00.000' AS DateTime), CAST(N'2023-11-25 20:00:00.000' AS DateTime), N'Đặt trước', 80000, N'480000    ')
INSERT [dbo].[ThueSan] ([Ma_ThueSan], [Ma_San], [Ma_KhachHang], [ThoiGianBatDau], [ThoiGianKetThuc], [LoaiThue], [DonGia], [ThanhTien]) VALUES (4, N'SAN4', N'KH2', CAST(N'2023-11-26 18:00:00.000' AS DateTime), CAST(N'2023-11-26 19:00:00.000' AS DateTime), N'Trực tiếp', 20000, N'120000    ')
INSERT [dbo].[ThueSan] ([Ma_ThueSan], [Ma_San], [Ma_KhachHang], [ThoiGianBatDau], [ThoiGianKetThuc], [LoaiThue], [DonGia], [ThanhTien]) VALUES (5, N'SAN5', N'KH5', CAST(N'2023-11-27 17:00:00.000' AS DateTime), CAST(N'2023-11-27 18:00:00.000' AS DateTime), N'Đặt trước', 40000, N'240000    ')
INSERT [dbo].[ThueSan] ([Ma_ThueSan], [Ma_San], [Ma_KhachHang], [ThoiGianBatDau], [ThoiGianKetThuc], [LoaiThue], [DonGia], [ThanhTien]) VALUES (6, N'SAN6', N'KH6', CAST(N'2023-11-28 19:00:00.000' AS DateTime), CAST(N'2023-11-28 20:00:00.000' AS DateTime), N'Trực tiếp', 80000, N'480000    ')
INSERT [dbo].[ThueSan] ([Ma_ThueSan], [Ma_San], [Ma_KhachHang], [ThoiGianBatDau], [ThoiGianKetThuc], [LoaiThue], [DonGia], [ThanhTien]) VALUES (7, N'SAN6', N'KH7', CAST(N'2023-11-26 22:20:23.493' AS DateTime), CAST(N'2023-11-26 23:20:24.000' AS DateTime), N'Trực tiếp', 80000, N'80000     ')
SET IDENTITY_INSERT [dbo].[ThueSan] OFF
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD FOREIGN KEY([Ma_KhachHang])
REFERENCES [dbo].[KhachHang] ([Ma_KhachHang])
GO
ALTER TABLE [dbo].[San]  WITH CHECK ADD FOREIGN KEY([Loai_San])
REFERENCES [dbo].[LoaiSan] ([Loai_San])
GO
ALTER TABLE [dbo].[ThueSan]  WITH CHECK ADD FOREIGN KEY([Ma_KhachHang])
REFERENCES [dbo].[KhachHang] ([Ma_KhachHang])
GO
ALTER TABLE [dbo].[ThueSan]  WITH CHECK ADD FOREIGN KEY([Ma_San])
REFERENCES [dbo].[San] ([Ma_San])
GO
/****** Object:  StoredProcedure [dbo].[spDSHD]    Script Date: 11/26/2023 10:28:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spDSHD]
(
@Ma_HD INT
)
AS 
BEGIN
SELECT HoaDon.*
FROM HoaDon 
WHERE HoaDon.Ma_HD=@Ma_HD
END

GO
/****** Object:  StoredProcedure [dbo].[spDSKH]    Script Date: 11/26/2023 10:28:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spDSKH]
(
@Ma_KhachHang VARCHAR(100)
)
AS 
BEGIN
SELECT KhachHang.*,HoaDon.NgayLap_HD,HoaDon.TongTien_HD
FROM KhachHang INNER JOIN HoaDon ON KhachHang.Ma_KhachHang=HoaDon.Ma_KhachHang
WHERE KhachHang.Ma_KhachHang=@Ma_KhachHang
END
GO
