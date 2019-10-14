USE [master]
GO
/****** Object:  Database [Project2Database]    Script Date: 8/18/2019 8:34:27 PM ******/
CREATE DATABASE [Project2Database]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Project2Database', FILENAME = N'E:\Schooling\2018-2019\Term6\Windows\1753081_Project2\Project2Database.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Project2Database_log', FILENAME = N'E:\Schooling\2018-2019\Term6\Windows\1753081_Project2\Project2Database_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [Project2Database] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Project2Database].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Project2Database] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Project2Database] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Project2Database] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Project2Database] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Project2Database] SET ARITHABORT OFF 
GO
ALTER DATABASE [Project2Database] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [Project2Database] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Project2Database] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Project2Database] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Project2Database] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Project2Database] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Project2Database] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Project2Database] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Project2Database] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Project2Database] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Project2Database] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Project2Database] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Project2Database] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Project2Database] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Project2Database] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Project2Database] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Project2Database] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Project2Database] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Project2Database] SET  MULTI_USER 
GO
ALTER DATABASE [Project2Database] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Project2Database] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Project2Database] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Project2Database] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Project2Database] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Project2Database] SET QUERY_STORE = OFF
GO
USE [Project2Database]
GO
/****** Object:  Table [dbo].[BANGDIEM]    Script Date: 8/18/2019 8:34:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BANGDIEM](
	[MSSV] [char](10) NOT NULL,
	[MALOP] [char](7) NOT NULL,
	[MAMON] [char](10) NOT NULL,
	[DIEMGK] [float] NULL,
	[DIEMCK] [float] NULL,
	[DIEMKHAC] [float] NULL,
	[DIEMTONG] [float] NULL,
 CONSTRAINT [PK__BANGDIEM__EF6B1A31DF8F19C7] PRIMARY KEY CLUSTERED 
(
	[MSSV] ASC,
	[MALOP] ASC,
	[MAMON] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LOPHOC]    Script Date: 8/18/2019 8:34:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOPHOC](
	[MALOP] [char](7) NOT NULL,
 CONSTRAINT [PK__LOPHOC__7A3DE211DE01C15E] PRIMARY KEY CLUSTERED 
(
	[MALOP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MONHOC]    Script Date: 8/18/2019 8:34:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MONHOC](
	[MAMON] [char](10) NOT NULL,
	[MALOP] [char](7) NOT NULL,
	[TENMON] [nvarchar](50) NULL,
	[PHONGHOC] [varchar](5) NULL,
 CONSTRAINT [PK__MONHOC__7CD037A4FC028251] PRIMARY KEY CLUSTERED 
(
	[MAMON] ASC,
	[MALOP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SINHVIEN]    Script Date: 8/18/2019 8:34:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SINHVIEN](
	[MSSV] [char](10) NOT NULL,
	[MATKHAU] [varchar](16) NULL,
	[HOTEN] [nvarchar](30) NULL,
	[MALOP] [char](7) NULL,
	[NGAYSINH] [date] NULL,
	[GIOITINH] [nvarchar](3) NULL,
	[CMND] [varchar](9) NULL,
 CONSTRAINT [PK__SINHVIEN__6CB3B7F9986C5510] PRIMARY KEY CLUSTERED 
(
	[MSSV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[BANGDIEM] ([MSSV], [MALOP], [MAMON], [DIEMGK], [DIEMCK], [DIEMKHAC], [DIEMTONG]) VALUES (N'1742001   ', N'17HCB  ', N'CTT011    ', 0, 0, 0, 0)
INSERT [dbo].[BANGDIEM] ([MSSV], [MALOP], [MAMON], [DIEMGK], [DIEMCK], [DIEMKHAC], [DIEMTONG]) VALUES (N'1742001   ', N'17HCB  ', N'CTT012    ', 0, 0, 0, 0)
INSERT [dbo].[BANGDIEM] ([MSSV], [MALOP], [MAMON], [DIEMGK], [DIEMCK], [DIEMKHAC], [DIEMTONG]) VALUES (N'1742002   ', N'17HCB  ', N'CTT011    ', 0, 0, 0, 0)
INSERT [dbo].[BANGDIEM] ([MSSV], [MALOP], [MAMON], [DIEMGK], [DIEMCK], [DIEMKHAC], [DIEMTONG]) VALUES (N'1742002   ', N'17HCB  ', N'CTT012    ', 0, 0, 0, 0)
INSERT [dbo].[BANGDIEM] ([MSSV], [MALOP], [MAMON], [DIEMGK], [DIEMCK], [DIEMKHAC], [DIEMTONG]) VALUES (N'1742003   ', N'17HCB  ', N'CTT011    ', 0, 0, 0, 0)
INSERT [dbo].[BANGDIEM] ([MSSV], [MALOP], [MAMON], [DIEMGK], [DIEMCK], [DIEMKHAC], [DIEMTONG]) VALUES (N'1742003   ', N'17HCB  ', N'CTT012    ', 0, 0, 0, 0)
INSERT [dbo].[BANGDIEM] ([MSSV], [MALOP], [MAMON], [DIEMGK], [DIEMCK], [DIEMKHAC], [DIEMTONG]) VALUES (N'1742004   ', N'17HCB  ', N'CTT011    ', 0, 0, 0, 0)
INSERT [dbo].[BANGDIEM] ([MSSV], [MALOP], [MAMON], [DIEMGK], [DIEMCK], [DIEMKHAC], [DIEMTONG]) VALUES (N'1742004   ', N'17HCB  ', N'CTT012    ', 0, 0, 0, 0)
INSERT [dbo].[BANGDIEM] ([MSSV], [MALOP], [MAMON], [DIEMGK], [DIEMCK], [DIEMKHAC], [DIEMTONG]) VALUES (N'1742005   ', N'17HCB  ', N'CTT011    ', 0, 0, 0, 0)
INSERT [dbo].[BANGDIEM] ([MSSV], [MALOP], [MAMON], [DIEMGK], [DIEMCK], [DIEMKHAC], [DIEMTONG]) VALUES (N'1742005   ', N'17HCB  ', N'CTT012    ', 0, 0, 0, 0)
INSERT [dbo].[BANGDIEM] ([MSSV], [MALOP], [MAMON], [DIEMGK], [DIEMCK], [DIEMKHAC], [DIEMTONG]) VALUES (N'1742005   ', N'18HCB  ', N'CTT001    ', 1, 2, 3, 2)
INSERT [dbo].[BANGDIEM] ([MSSV], [MALOP], [MAMON], [DIEMGK], [DIEMCK], [DIEMKHAC], [DIEMTONG]) VALUES (N'1842001   ', N'18HCB  ', N'CTT002    ', 0, 0, 0, 0)
INSERT [dbo].[BANGDIEM] ([MSSV], [MALOP], [MAMON], [DIEMGK], [DIEMCK], [DIEMKHAC], [DIEMTONG]) VALUES (N'1842002   ', N'18HCB  ', N'CTT001    ', 4, 5, 6, 5)
INSERT [dbo].[BANGDIEM] ([MSSV], [MALOP], [MAMON], [DIEMGK], [DIEMCK], [DIEMKHAC], [DIEMTONG]) VALUES (N'1842002   ', N'18HCB  ', N'CTT002    ', 0, 0, 0, 0)
INSERT [dbo].[BANGDIEM] ([MSSV], [MALOP], [MAMON], [DIEMGK], [DIEMCK], [DIEMKHAC], [DIEMTONG]) VALUES (N'1842003   ', N'18HCB  ', N'CTT001    ', 7, 8, 9, 8.5)
INSERT [dbo].[BANGDIEM] ([MSSV], [MALOP], [MAMON], [DIEMGK], [DIEMCK], [DIEMKHAC], [DIEMTONG]) VALUES (N'1842003   ', N'18HCB  ', N'CTT002    ', 0, 0, 0, 0)
INSERT [dbo].[BANGDIEM] ([MSSV], [MALOP], [MAMON], [DIEMGK], [DIEMCK], [DIEMKHAC], [DIEMTONG]) VALUES (N'1842004   ', N'18HCB  ', N'CTT001    ', 2, 4, 6, 4.5)
INSERT [dbo].[BANGDIEM] ([MSSV], [MALOP], [MAMON], [DIEMGK], [DIEMCK], [DIEMKHAC], [DIEMTONG]) VALUES (N'1842004   ', N'18HCB  ', N'CTT002    ', 0, 0, 0, 0)
INSERT [dbo].[BANGDIEM] ([MSSV], [MALOP], [MAMON], [DIEMGK], [DIEMCK], [DIEMKHAC], [DIEMTONG]) VALUES (N'1842005   ', N'18HCB  ', N'CTT001    ', 8, 10, 2, 9.5)
INSERT [dbo].[BANGDIEM] ([MSSV], [MALOP], [MAMON], [DIEMGK], [DIEMCK], [DIEMKHAC], [DIEMTONG]) VALUES (N'1842005   ', N'18HCB  ', N'CTT002    ', 0, 0, 0, 0)
INSERT [dbo].[LOPHOC] ([MALOP]) VALUES (N'17HCB  ')
INSERT [dbo].[LOPHOC] ([MALOP]) VALUES (N'18HCB  ')
INSERT [dbo].[MONHOC] ([MAMON], [MALOP], [TENMON], [PHONGHOC]) VALUES (N'CTT001    ', N'18HCB  ', N'Lập trình ứng dụng Java', N'C31')
INSERT [dbo].[MONHOC] ([MAMON], [MALOP], [TENMON], [PHONGHOC]) VALUES (N'CTT002    ', N'18HCB  ', N'Mạng máy tính', N'C31')
INSERT [dbo].[MONHOC] ([MAMON], [MALOP], [TENMON], [PHONGHOC]) VALUES (N'CTT011    ', N'17HCB  ', N'Thiết kế giao diện', N'C32')
INSERT [dbo].[MONHOC] ([MAMON], [MALOP], [TENMON], [PHONGHOC]) VALUES (N'CTT012    ', N'17HCB  ', N'Kiểm chứng phần mềm', N'C32')
INSERT [dbo].[SINHVIEN] ([MSSV], [MATKHAU], [HOTEN], [MALOP], [NGAYSINH], [GIOITINH], [CMND]) VALUES (N'1742001   ', N'01011999        ', N'Nguyễn Văn A', N'17HCB  ', CAST(N'1999-01-01' AS Date), N'Nam', N'123456789')
INSERT [dbo].[SINHVIEN] ([MSSV], [MATKHAU], [HOTEN], [MALOP], [NGAYSINH], [GIOITINH], [CMND]) VALUES (N'1742002   ', N'03021999        ', N'Trần Văn B', N'17HCB  ', CAST(N'1999-02-03' AS Date), N'Nam', N'234567891')
INSERT [dbo].[SINHVIEN] ([MSSV], [MATKHAU], [HOTEN], [MALOP], [NGAYSINH], [GIOITINH], [CMND]) VALUES (N'1742003   ', N'05031999        ', N'Huỳnh Thị C', N'17HCB  ', CAST(N'1999-03-05' AS Date), N'Nữ', N'345678912')
INSERT [dbo].[SINHVIEN] ([MSSV], [MATKHAU], [HOTEN], [MALOP], [NGAYSINH], [GIOITINH], [CMND]) VALUES (N'1742004   ', N'07041999        ', N'Mai Văn C', N'17HCB  ', CAST(N'1999-04-07' AS Date), N'Nam', N'456789123')
INSERT [dbo].[SINHVIEN] ([MSSV], [MATKHAU], [HOTEN], [MALOP], [NGAYSINH], [GIOITINH], [CMND]) VALUES (N'1742005   ', N'09051999        ', N'Hồ Thị E', N'17HCB  ', CAST(N'1999-05-09' AS Date), N'Nữ', N'567891234')
INSERT [dbo].[SINHVIEN] ([MSSV], [MATKHAU], [HOTEN], [MALOP], [NGAYSINH], [GIOITINH], [CMND]) VALUES (N'1842001   ', N'11062000        ', N'Lý Văn F', N'18HCB  ', CAST(N'2000-06-11' AS Date), N'Nam', N'678912345')
INSERT [dbo].[SINHVIEN] ([MSSV], [MATKHAU], [HOTEN], [MALOP], [NGAYSINH], [GIOITINH], [CMND]) VALUES (N'1842002   ', N'13072000        ', N'Chiêu Văn G', N'18HCB  ', CAST(N'2000-07-13' AS Date), N'Nam', N'789123456')
INSERT [dbo].[SINHVIEN] ([MSSV], [MATKHAU], [HOTEN], [MALOP], [NGAYSINH], [GIOITINH], [CMND]) VALUES (N'1842003   ', N'15082000        ', N'Trần Thị H', N'18HCB  ', CAST(N'2000-08-15' AS Date), N'Nữ', N'891234567')
INSERT [dbo].[SINHVIEN] ([MSSV], [MATKHAU], [HOTEN], [MALOP], [NGAYSINH], [GIOITINH], [CMND]) VALUES (N'1842004   ', N'17092000        ', N'Mạc Văn I', N'18HCB  ', CAST(N'2000-09-17' AS Date), N'Nam', N'912345678')
INSERT [dbo].[SINHVIEN] ([MSSV], [MATKHAU], [HOTEN], [MALOP], [NGAYSINH], [GIOITINH], [CMND]) VALUES (N'1842005   ', N'19102000        ', N'Văn Thị J', N'18HCB  ', CAST(N'2000-10-19' AS Date), N'Nữ', N'987654321')
INSERT [dbo].[SINHVIEN] ([MSSV], [MATKHAU], [HOTEN], [MALOP], [NGAYSINH], [GIOITINH], [CMND]) VALUES (N'giaovu    ', N'giaovu          ', N'Giáo vụ', NULL, NULL, NULL, NULL)
ALTER TABLE [dbo].[BANGDIEM]  WITH CHECK ADD  CONSTRAINT [FK_BANGDIEM_MONHOC] FOREIGN KEY([MAMON], [MALOP])
REFERENCES [dbo].[MONHOC] ([MAMON], [MALOP])
GO
ALTER TABLE [dbo].[BANGDIEM] CHECK CONSTRAINT [FK_BANGDIEM_MONHOC]
GO
ALTER TABLE [dbo].[BANGDIEM]  WITH CHECK ADD  CONSTRAINT [FK_BANGDIEM_SINHVIEN] FOREIGN KEY([MSSV])
REFERENCES [dbo].[SINHVIEN] ([MSSV])
GO
ALTER TABLE [dbo].[BANGDIEM] CHECK CONSTRAINT [FK_BANGDIEM_SINHVIEN]
GO
ALTER TABLE [dbo].[MONHOC]  WITH CHECK ADD  CONSTRAINT [FK_MONHOC_LOPHOC] FOREIGN KEY([MALOP])
REFERENCES [dbo].[LOPHOC] ([MALOP])
GO
ALTER TABLE [dbo].[MONHOC] CHECK CONSTRAINT [FK_MONHOC_LOPHOC]
GO
ALTER TABLE [dbo].[SINHVIEN]  WITH CHECK ADD  CONSTRAINT [FK_SINHVIEN_LOPHOC] FOREIGN KEY([MALOP])
REFERENCES [dbo].[LOPHOC] ([MALOP])
GO
ALTER TABLE [dbo].[SINHVIEN] CHECK CONSTRAINT [FK_SINHVIEN_LOPHOC]
GO
ALTER TABLE [dbo].[BANGDIEM]  WITH CHECK ADD  CONSTRAINT [CK_BANGDIEM_DIEMCK] CHECK  (([DIEMCK]>=(0) AND [DIEMCK]<=(10)))
GO
ALTER TABLE [dbo].[BANGDIEM] CHECK CONSTRAINT [CK_BANGDIEM_DIEMCK]
GO
ALTER TABLE [dbo].[BANGDIEM]  WITH CHECK ADD  CONSTRAINT [CK_BANGDIEM_DIEMGK] CHECK  (([DIEMGK]>=(0) AND [DIEMGK]<=(10)))
GO
ALTER TABLE [dbo].[BANGDIEM] CHECK CONSTRAINT [CK_BANGDIEM_DIEMGK]
GO
ALTER TABLE [dbo].[BANGDIEM]  WITH CHECK ADD  CONSTRAINT [CK_BANGDIEM_DIEMKHAC] CHECK  (([DIEMKHAC]>=(0) AND [DIEMKHAC]<=(10)))
GO
ALTER TABLE [dbo].[BANGDIEM] CHECK CONSTRAINT [CK_BANGDIEM_DIEMKHAC]
GO
USE [master]
GO
ALTER DATABASE [Project2Database] SET  READ_WRITE 
GO
