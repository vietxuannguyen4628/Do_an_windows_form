﻿USE [master]
GO
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
	[CMND_CanCuoc] [char](10),
	[SDT] [char](10),
	[QueQuan] [nvarchar](150),
	[GioiTinh] [nvarchar](5),
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
	[MaPTP] [bigint] NOT NULL,
	[MaPhong] [int] NOT NULL,
	[MaKH] [int]NOT NULL,
	[TienDacCoc] [int],
	[NgayThue] [datetime],
	[DaThanhToan] [tinyint],
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
	[MaPTrP] [bigint] NOT NULL,
	[MaPTP] [bigint] NOT NULL,
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
	[MaPTP] [bigint] NOT NULL,
	[MaDV] [int] NOT NULL,
	[ChiSoCu] [int],
	[ChiSoMoi] [int],
	--[SoLuong] [int],
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
	[MaPTP] [bigint] NOT NULL,
	[MaDV] [int] NOT NULL,
	[TuNgay] [datetime],
	[DenNgay] [datetime],
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
(106, 1, 20.0, 4800000),
(107, 1, 25.0, 5200000),
(108, 0, 30.0, 6100000),
(109, 1, 22.5, 4900000),
(110, 1, 29.0, 5700000),
(111, 0, 24.0, 5400000),
(112, 1, 26.0, 6000000),
(113, 1, 21.5, 5000000),
(114, 0, 22.5, 4900000),
(115, 0, 29.0, 5700000);
--phòng đã cho thuê 101, 103, 104, 106, 107, 109, 110, 112, 113

-- Thêm dữ liệu cho bảng KhachHang
INSERT INTO [dbo].[KhachHang] (MaKH, HoTen, CMND_CanCuoc, SDT, QueQuan, GioiTinh, NgheNghiep) VALUES
(1, N'Nguyễn Văn A', '1234567890', '0912345678', N'Hà Nội', N'Nam', N'Kỹ sư'),
(2, N'Trần Thị B', '0453983444', '0987654321', N'Hồ Chí Minh', N'Nữ', N'Sinh viên'),
(3, N'Lê Văn C', '1122334455', '0909876543', N'Đà Nẵng', N'Nam', N'Technician'),
(4, N'Phạm Văn D', '2233445566', '0901234567', N'Hải Phòng', N'Nam', N'Giáo viên'),
(5, N'Hoàng Thị E', '3344556677', '0913456789', N'Cần Thơ', N'Nữ', N'Nhân viên văn phòng'),
(6, N'Bùi Văn F', '5566778899', '0939876543', N'Nha Trang', N'Nam', N'Kinh doanh'),
(7, N'Ngô Thị G', '6677889900', '0945678912', N'Quảng Ninh', N'Nữ', N'Công nhân'),
(8, N'Lý Văn H', '7788990011', '0956789123', N'Vũng Tàu', N'Nam', N'Tài xế'),
(9, N'Tô Thị I', '8899001122', '0967891234', N'Phú Thọ', N'Nữ', N'Bán hàng');

-- Thêm dữ liệu cho bảng PhieuThuePhong
INSERT INTO [dbo].[PhieuThuePhong] (MaPTP, MaPhong, MaKH, TienDacCoc, NgayThue, DaThanhToan) VALUES
(1, 101, 1, 100000, '2024-10-01', 1),  -- Ngày thuê 01/10/2024
(2, 103, 2, 200000, '2024-10-15', 0),  -- Ngày thuê 15/10/2024
(3, 104, 3, 150000, '2024-10-20', 0),  -- Ngày thuê 20/10/2024
(4, 106, 4, 300000, '2024-10-23', 1),  -- Ngày thuê 23/10/2024
(5, 107, 5, 250000, '2024-10-22', 0),  -- Ngày thuê 22/10/2024
(6, 109, 6, 270000, '2024-10-20', 0),  -- Ngày thuê 20/10/2024
(7, 110, 7, 200000, '2024-10-21', 1),  -- Ngày thuê 21/10/2024
(8, 112, 8, 220000, '2024-10-19', 0),  -- Ngày thuê 19/10/2024
(9, 113, 9, 280000, '2024-10-18', 0);  -- Ngày thuê 18/10/2024
--101, 103, 104, 106, 107, 109, 110, 112, 113



-- Thêm dữ liệu cho bảng PhieuTraPhong
INSERT INTO [dbo].[PhieuTraPhong] (MaPTrP, MaPTP, NgayTra) VALUES
(1, 1, '2024-10-05'),  -- Ngày trả 05/10/2024
(2, 2, '2024-10-20'),  -- Ngày trả 20/10/2024
(3, 3, '2024-10-25');  -- Ngày trả 25/10/2024

-- Thêm dữ liệu cho bảng DichVu
INSERT INTO [dbo].[DichVu] (MaDV, TenDV, DonGia) VALUES
(1, N'Internet', 100000),
(2, N'Rác', 50000),
(3, N'Giữ Xe', 20000),
(4, N'Nước', 10000),
(5, N'Điện', 3300);


-- Thêm dữ liệu cho bảng CT_SuDungDV
INSERT INTO [dbo].[CT_SuDungDV] (MaPTP, MaDV, ChiSoCu, ChiSoMoi) VALUES
-- Dịch vụ điện (DonGia = 3300)
(1, 5, 10, 50),   -- MaPTP = 1
(2, 5, 20, 60),   -- MaPTP = 2
(3, 5, 15, 55),   -- MaPTP = 3
(4, 5, 25, 65),   -- MaPTP = 4
(5, 5, 18, 58),   -- MaPTP = 5
(6, 5, 22, 62),   -- MaPTP = 6
(7, 5, 30, 70),   -- MaPTP = 7
(8, 5, 20, 60),   -- MaPTP = 8
(9, 5, 24, 64),   -- MaPTP = 9

-- Dịch vụ nước (DonGia = 10000)
(1, 4, 5, 10),    -- MaPTP = 1
(2, 4, 8, 15),    -- MaPTP = 2
(3, 4, 10, 18),   -- MaPTP = 3
(4, 4, 12, 20),   -- MaPTP = 4
(5, 4, 9, 16),    -- MaPTP = 5
(6, 4, 7, 13),    -- MaPTP = 6
(7, 4, 6, 12),    -- MaPTP = 7
(8, 4, 8, 14),    -- MaPTP = 8
(9, 4, 10, 18),   -- MaPTP = 9

-- Các dịch vụ khác (ChiSoCu = 0, ChiSoMoi = 1)
(1, 1, 0, 1),    -- Internet cho MaPTP = 1
(1, 2, 0, 1),    -- Rác cho MaPTP = 1
(2, 1, 0, 1),    -- Internet cho MaPTP = 2
(2, 2, 0, 1),    -- Rác cho MaPTP = 2
(3, 1, 0, 1),    -- Internet cho MaPTP = 3
(3, 2, 0, 1),    -- Rác cho MaPTP = 3
(4, 1, 0, 1),    -- Internet cho MaPTP = 4
(4, 3, 0, 1),    -- Giữ Xe cho MaPTP = 4
(5, 1, 0, 1),    -- Internet cho MaPTP = 5
(5, 2, 0, 1),    -- Rác cho MaPTP = 5
(6, 1, 0, 1),    -- Internet cho MaPTP = 6
(6, 3, 0, 1),    -- Giữ Xe cho MaPTP = 6
(7, 1, 0, 1),    -- Internet cho MaPTP = 7
(7, 2, 0, 1),    -- Rác cho MaPTP = 7
(8, 1, 0, 1),    -- Internet cho MaPTP = 8
(8, 3, 0, 1),    -- Giữ Xe cho MaPTP = 8
(9, 1, 0, 1),    -- Internet cho MaPTP = 9
(9, 2, 0, 1);    -- Rác cho MaPTP = 9

-- Thêm dữ liệu cho bảng PhieuThutien
INSERT INTO [dbo].[PhieuThutien] (MaPTT, MaPTP, MaDV, TuNgay, DenNgay, ThanhTien) VALUES
-- Dịch vụ điện (ThanhTien = (ChiSoMoi - ChiSoCu) * DonGia)
(1, 1, 5, '2024-10-01', '2024-10-05', (50 - 10) * 3300),
(2, 2, 5, '2024-10-15', '2024-10-20', (60 - 20) * 3300),
(3, 3, 5, '2024-10-20', '2024-10-25', (55 - 15) * 3300),
(4, 4, 5, '2024-10-23', '2024-10-30', (65 - 25) * 3300),
(5, 5, 5, '2024-10-22', '2024-10-29', (58 - 18) * 3300),
(6, 6, 5, '2024-10-20', '2024-10-27', (62 - 22) * 3300),
(7, 7, 5, '2024-10-21', '2024-10-28', (70 - 30) * 3300),
(8, 8, 5, '2024-10-19', '2024-10-26', (60 - 20) * 3300),
(9, 9, 5, '2024-10-18', '2024-10-25', (64 - 24) * 3300),

-- Dịch vụ nước (ThanhTien = (ChiSoMoi - ChiSoCu) * DonGia)
(10, 1, 4, '2024-10-01', '2024-10-05', (10 - 5) * 10000),
(11, 2, 4, '2024-10-15', '2024-10-20', (15 - 8) * 10000),
(12, 3, 4, '2024-10-20', '2024-10-25', (18 - 10) * 10000),
(13, 4, 4, '2024-10-23', '2024-10-30', (20 - 12) * 10000),
(14, 5, 4, '2024-10-22', '2024-10-29', (16 - 9) * 10000),
(15, 6, 4, '2024-10-20', '2024-10-27', (13 - 7) * 10000),
(16, 7, 4, '2024-10-21', '2024-10-28', (12 - 6) * 10000),
(17, 8, 4, '2024-10-19', '2024-10-26', (14 - 8) * 10000),
(18, 9, 4, '2024-10-18', '2024-10-25', (18 - 10) * 10000),

-- Các dịch vụ khác (ChiSoMoi - ChiSoCu = 1)
(19, 1, 1, '2024-10-01', '2024-10-05', (1 - 0) * 100000), -- Internet
(20, 1, 2, '2024-10-01', '2024-10-05', (1 - 0) * 50000),  -- Rác
(21, 2, 1, '2024-10-15', '2024-10-20', (1 - 0) * 100000), -- Internet
(22, 2, 2, '2024-10-15', '2024-10-20', (1 - 0) * 50000),  -- Rác
(23, 3, 1, '2024-10-20', '2024-10-25', (1 - 0) * 100000), -- Internet
(24, 3, 2, '2024-10-20', '2024-10-25', (1 - 0) * 50000),  -- Rác
(25, 4, 1, '2024-10-23', '2024-10-30', (1 - 0) * 100000), -- Internet
(26, 4, 3, '2024-10-23', '2024-10-30', (1 - 0) * 200000), -- Giữ Xe
(27, 5, 1, '2024-10-22', '2024-10-29', (1 - 0) * 100000), -- Internet
(28, 5, 2, '2024-10-22', '2024-10-29', (1 - 0) * 50000),  -- Rác
(29, 6, 1, '2024-10-20', '2024-10-27', (1 - 0) * 100000), -- Internet
(30, 6, 3, '2024-10-20', '2024-10-27', (1 - 0) * 200000), -- Giữ Xe
(31, 7, 1, '2024-10-21', '2024-10-28', (1 - 0) * 100000), -- Internet
(32, 7, 2, '2024-10-21', '2024-10-28', (1 - 0) * 50000),  -- Rác
(33, 8, 1, '2024-10-19', '2024-10-26', (1 - 0) * 100000), -- Internet
(34, 8, 3, '2024-10-19', '2024-10-26', (1 - 0) * 200000), -- Giữ Xe
(35, 9, 1, '2024-10-18', '2024-10-25', (1 - 0) * 100000), -- Internet
(36, 9, 2, '2024-10-18', '2024-10-25', (1 - 0) * 50000);  -- Rác



SELECT * FROM [dbo].[CT_SuDungDV];


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