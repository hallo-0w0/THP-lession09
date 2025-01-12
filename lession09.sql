USE [K22CNT3-TrinhHuuPhuc]
GO
/****** Object:  Table [dbo].[thpKhoa]    Script Date: 6/12/2024 10:01:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[thpKhoa](
	[ThpMaKH] [nchar](10) NOT NULL,
	[ThpTenKH] [nvarchar](50) NULL,
	[ThpTrangThai] [bit] NULL,
 CONSTRAINT [PK_thpKhoa] PRIMARY KEY CLUSTERED 
(
	[ThpMaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[thpSinhVien]    Script Date: 6/12/2024 10:01:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[thpSinhVien](
	[ThpMaSV] [nvarchar](50) NOT NULL,
	[ThpHoSV] [nvarchar](50) NULL,
	[ThpTenSV] [nvarchar](50) NULL,
	[ThpNgaySinh] [date] NULL,
	[ThpPhai] [bit] NULL,
	[ThpPhone] [nchar](10) NULL,
	[ThpEmail] [nvarchar](50) NULL,
	[ThpMaKH] [nchar](10) NULL,
 CONSTRAINT [PK_thpSinhVien] PRIMARY KEY CLUSTERED 
(
	[ThpMaSV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[thpKhoa] ([ThpMaKH], [ThpTenKH], [ThpTrangThai]) VALUES (N'001       ', N'Trinh Van Chung', 1)
INSERT [dbo].[thpKhoa] ([ThpMaKH], [ThpTenKH], [ThpTrangThai]) VALUES (N'002       ', N'Trinh Van Nam', 0)
GO
INSERT [dbo].[thpSinhVien] ([ThpMaSV], [ThpHoSV], [ThpTenSV], [ThpNgaySinh], [ThpPhai], [ThpPhone], [ThpEmail], [ThpMaKH]) VALUES (N'2210900012', N'Trinh Van', N'Chung', CAST(N'1990-09-09' AS Date), 1, N'9876543210', N'chungtrinhvan@gmail.com', N'001       ')
INSERT [dbo].[thpSinhVien] ([ThpMaSV], [ThpHoSV], [ThpTenSV], [ThpNgaySinh], [ThpPhai], [ThpPhone], [ThpEmail], [ThpMaKH]) VALUES (N'2210900054', N'Trinh Huu', N'Phuc', CAST(N'2004-03-26' AS Date), 1, N'0123456789', N'toiduaroima@gmail.com', N'002       ')
GO
ALTER TABLE [dbo].[thpSinhVien]  WITH CHECK ADD  CONSTRAINT [FK_thpSinhVien_thpKhoa] FOREIGN KEY([ThpMaKH])
REFERENCES [dbo].[thpKhoa] ([ThpMaKH])
GO
ALTER TABLE [dbo].[thpSinhVien] CHECK CONSTRAINT [FK_thpSinhVien_thpKhoa]
GO
