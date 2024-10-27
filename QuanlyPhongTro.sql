IF EXISTS (SELECT name FROM sys.databases WHERE name = 'QuanLyPhongTro')
    DROP DATABASE QuanLyPhongTro;
GO
--Drop table Faculty
--Drop table Student
CREATE DATABASE [QuanLyPhongTro]
GO
USE [QuanLyPhongTro]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Phong](
	[MaPhong] [int] NOT NULL,
	[TrangThai] [tinyint],
	[DienTich] [float],
	[GiaTien] [int]
 CONSTRAINT [PK_Phong] PRIMARY KEY CLUSTERED 
(
	[MaPhong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO



SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKH] [int] NOT NULL,
	[HoTen] [nvarchar](70),
	[CMND_CanCuoc] [varchar](20),
	[SDT] [varchar](20),
	[QueQuan] [nvarchar](150),
	[GioiTinh] [nvarchar](20),
	[NgheNghiep] [nvarchar](30),
 CONSTRAINT [PK_KhachHang] PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

--drop table PhieuThuePhong
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuThuePhong](
	[MaPTP] [int] NOT NULL,
	[MaPhong] [int] NOT NULL,
	[MaKH] [int]NOT NULL,
	[TienDacCoc] [int],
	[NgayThue] [datetime],
 CONSTRAINT [PK_PhieuThuePhong] PRIMARY KEY CLUSTERED 
(
	[MaPTP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[PhieuThuePhong]  WITH CHECK ADD  CONSTRAINT [FK_PhieuThuePhong_Phong] FOREIGN KEY([MaPhong])
REFERENCES [dbo].[Phong] ([MaPhong])
GO
ALTER TABLE [dbo].[PhieuThuePhong] CHECK CONSTRAINT [FK_PhieuThuePhong_Phong]
GO

ALTER TABLE [dbo].[PhieuThuePhong]  WITH CHECK ADD  CONSTRAINT [FK_PhieuThuePhong_KhachHang] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KhachHang] ([MaKH])
GO

ALTER TABLE [dbo].[PhieuThuePhong] CHECK CONSTRAINT [FK_PhieuThuePhong_KhachHang]
GO

ALTER TABLE [dbo].[PhieuThuePhong]  WITH CHECK ADD  CONSTRAINT [UQ_PhieuThuePhong] UNIQUE ([MaKH])
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuTraPhong](
	[MaPTrP] [int] NOT NULL,
	[MaPTP] [int] NOT NULL,
	[NgayTra] [datetime],
 CONSTRAINT [PK_PhieuTraPhong] PRIMARY KEY CLUSTERED 
(
	[MaPTrP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[PhieuTraPhong]  WITH CHECK ADD CONSTRAINT [FK_PhieuTraPhong_PhieuThuePhong] FOREIGN KEY([MaPTP])
REFERENCES [dbo].[PhieuThuePhong] ([MaPTP])
GO
ALTER TABLE [dbo].[PhieuTraPhong] CHECK CONSTRAINT [FK_PhieuTraPhong_PhieuThuePhong]
GO




SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DichVu](
	[MaDV] [int] NOT NULL,
	[TenDV] [nvarchar](50),
	[DonGia] [int],
 CONSTRAINT [PK_DichVu] PRIMARY KEY CLUSTERED 
(
	[MaDV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CT_SuDungDV](
	[MaPTP] [int] NOT NULL,
	[MaDV] [int] NOT NULL,
	[ChiSoCu] [int],
	[ChiSoMoi] [int],
 CONSTRAINT [PK_CT_SuDungDV] PRIMARY KEY CLUSTERED 
(
	[MaPTP] ASC,
	[MaDV] ASC

)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


ALTER TABLE [dbo].[CT_SuDungDV]  WITH CHECK ADD  CONSTRAINT [FK_CT_SuDungDV_PhieuThuePhong] FOREIGN KEY([MaPTP])
REFERENCES [dbo].[PhieuThuePhong] ([MaPTP])
GO
ALTER TABLE [dbo].[CT_SuDungDV] CHECK CONSTRAINT [FK_CT_SuDungDV_PhieuThuePhong]
GO
ALTER TABLE [dbo].[CT_SuDungDV]  WITH CHECK ADD  CONSTRAINT [FK_CT_SuDungDV_DichVu] FOREIGN KEY([MaDV])
REFERENCES [dbo].[DichVu] ([MaDV])
GO
ALTER TABLE [dbo].[CT_SuDungDV] CHECK CONSTRAINT [FK_CT_SuDungDV_DichVu]
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuThutien](
	[MaPTT] [int] NOT NULL,
	[MaPTP] [int] NOT NULL,
	[MaDV] [int] NOT NULL,
	[NgayThanhToan] [datetime],
	[ThanhTien] [int],
 CONSTRAINT [PK_PhieuThutien] PRIMARY KEY CLUSTERED 
(
	[MaPTT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[PhieuThutien]  WITH CHECK ADD  CONSTRAINT [FK_PhieuThuTien_CT_SuDungDV] FOREIGN KEY([MaPTP],[MaDV])
REFERENCES [dbo].[CT_SuDungDV] ([MaPTP],[MaDV])
GO
ALTER TABLE [dbo].[PhieuThutien] CHECK CONSTRAINT [FK_PhieuThuTien_CT_SuDungDV]
GO

-- Thêm dữ liệu cho bảng Phong
INSERT INTO [dbo].[Phong] (MaPhong, TrangThai, DienTich, GiaTien) VALUES
(101, 0, 30.5, 500000),
(102, 0, 25.0, 400000),
(103, 0, 45.0, 800000),
(104, 0, 28.0, 5500000),
(105, 0, 32.5, 6500000),
(106, 0, 20.0, 4800000),
(107, 0, 25.0, 5200000),
(108, 0, 30.0, 6100000),
(109, 0, 22.5, 4900000),
(110, 0, 29.0, 5700000),
(111, 0, 24.0, 5400000),
(112, 0, 26.0, 6000000),
(113, 0, 21.5, 5000000),
(114, 0, 22.5, 4900000),
(115, 0, 29.0, 5700000);
--phòng đã cho thuê 101, 103, 104, 106, 107, 109, 110, 112, 113

-- Thêm dữ liệu cho bảng DichVu
INSERT INTO [dbo].[DichVu] (MaDV, TenDV, DonGia) VALUES
(1, N'Internet', 100000),
(2, N'Rác', 50000),
(3, N'Giữ Xe', 20000),
(4, N'Nước', 10000),
(5, N'Điện', 3300);


--INSERT INTO [dbo].[Phong] (MaPhong, TrangThai, DienTich)
--VALUES 
--(1, 1, 20.5),  -- Phòng 1 đang có khách
--(2, 0, 18.3),  -- Phòng 2 trống
--(3, 1, 25.0);  -- Phòng 3 đang có khách
--go


--INSERT INTO [dbo].[KhachHang] (MaKH, HoTen, CMND_CanCuoc, SDT, QueQuan, GioiTinh, NgheNghiep)
--VALUES 
--(1, 'Nguyen Van A', '1234567890', '0901234567', 'Ha Noi', 'Nam', 'Nhan Vien'),
--(2, 'Le Thi B', '0987654321', '0912345678', 'Da Nang', 'Nu', 'Giao Vien'),
--(3, 'Tran Van C', '1122334455', '0923456789', 'Hai Phong', 'Nam', 'Ky Su');
--go



--INSERT INTO [dbo].[PhieuThuePhong] (MaPTP, MaPhong, MaKH, TienDacCoc, NgayThue, DaThanhToan)
--VALUES 
--(1001, 1, 1, 1000000, '2024-10-01', 0),  -- Khách hàng 1 thuê phòng 1
--(1002, 3, 2, 1500000, '2024-09-25', 1);  -- Khách hàng 2 thuê phòng 3, đã thanh toán
--go



--INSERT INTO [dbo].[PhieuTraPhong] (MaPTrP, MaPTP, NgayTra, DaThanhtoan, ThanhTien)
--VALUES 
--(5001, 1001, '2024-10-10', 1, 2000000);  -- Khách hàng 1 trả phòng, đã thanh toán 2 triệu
--go




--INSERT INTO [dbo].[PhieuDenBu] (MaPDB, MaPTP, NoiDung, TienBoiThuong)
--VALUES 
--(3001, 1002, 'Hư hỏng bàn ghế', 500000);  -- Khách hàng 2 đền bù do hư hỏng đồ đạc
--go


--INSERT INTO [dbo].[DichVu] (MaDV, TenDV, Gia)
--VALUES 
--(1, 'Internet', 100000),
--(2, 'Nuoc Uong', 20000),
--(3, 'Dien', 3500);
--go

--INSERT INTO [dbo].[PhieuSuDungDV] (MaPSDDV, MaPTP, TuNgay, DenNgay, DonGia, DaThanhToan)
--VALUES 
--(4001, 1001, '2024-10-01', '2024-10-10', 120000, 1);  -- Khách hàng 1 sử dụng dịch vụ
--go

--INSERT INTO [dbo].[CT_SuDungDV] (MaPSDDV, MaDV, ChiSoCu, ChiSoMoi, SoLuong)
--VALUES 
--(4001, 1, NULL, NULL, 1),  -- Sử dụng 1 tháng Internet
--(4001, 2, NULL, NULL, 10);  -- Sử dụng 10 chai nước
--go

USE [master]
GO
ALTER DATABASE [QuanLyPhongTro] SET  READ_WRITE 
GO
