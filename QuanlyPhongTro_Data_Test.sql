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
(102, 1, 25.0, 400000),
(103, 1, 45.0, 800000),
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


-- Thêm dữ liệu cho bảng DichVu
INSERT INTO [dbo].[DichVu] (MaDV, TenDV, DonGia) VALUES
(1, N'Internet', 100000),
(2, N'Rác', 50000),
(3, N'Giữ Xe', 20000),
(4, N'Nước', 10000),
(5, N'Điện', 3300);



INSERT INTO [dbo].[KhachHang] (MaKH, HoTen, CMND_CanCuoc, SDT, QueQuan, GioiTinh, NgheNghiep)
VALUES 
(1, N'Nguyễn Kim Quang', '0755973554', '0901234567', N'Phú Yên', N'Nam', N'Nhân Viên'),
(2, N'Huỳnh Thiên Ân', '0952046054', '0912345678', N'Đà Nẵng', N'Nữ', N'Giáo Viên'),
(3, N'Tran Van C', '0358879536', '0923456789', N'Hải Phòng', N'Nam', N'Kỹ Sư');




INSERT INTO [dbo].[PhieuThuePhong] (MaPTP, MaPhong, MaKH, TienDacCoc, NgayThue)
VALUES 
(1, 101, 1, 1000000, '2024-01-01'),  -- Khách hàng 1 thuê phòng 1
(2, 102, 2, 1000000, '2024-03-01'), 
(3, 103, 3, 1500000, '2024-07-25');  -- Khách hàng 2 thuê phòng 3, đã thanh toán


INSERT INTO [dbo].[CT_SuDungDV] (MaPTP, MaDV, ChiSoCu, ChiSoMoi)
VALUES 
--cho phiếu thuê 1
(1, 1, 0, 1),
(1, 2, 0, 1),
(1, 3, 0, 1),
(1, 4, 25, 27),
(1, 5, 310, 390),

--cho phiếu thuê 2
(2, 1, 0, 1),
(2, 2, 0, 1),
(2, 3, 0, 1),
(2, 4, 21, 26),
(2, 5, 148, 188),

--cho phiếu thuê 3
(3, 1, 0, 1),
(3, 2, 0, 1),
(3, 3, 0, 1),
(3, 4, 23, 35),
(3, 5, 201, 301);


INSERT INTO [dbo].[PhieuThutien] (MaPTT, MaPTP, MaDV, NgayThanhToan, ThanhTien)
VALUES
--cho phiếu thuê 1, dịch vụ internet
(1, 1, 1, '2024-02-01', 100000),
(2, 1, 1, '2024-03-01', 100000),
(3, 1, 1, '2024-04-01', 100000),
(4, 1, 1, '2024-05-01', 100000),
(5, 1, 1, '2024-06-01', 100000),
(6, 1, 1, '2024-07-01', 100000),



--cho phiếu thuê 1, dịch vụ rác
(12, 1, 2, '2024-02-01', 50000),
(13, 1, 2, '2024-03-01', 50000),
(14, 1, 2, '2024-04-01', 50000),
(15, 1, 2, '2024-05-01', 50000),
(16, 1, 2, '2024-06-01', 50000),
(17, 1, 2, '2024-07-01', 50000),


--cho phiếu thuê 1, dịch vụ gửi xe
(23, 1, 3, '2024-02-01', 20000),
(24, 1, 3, '2024-03-01', 20000),
(25, 1, 3, '2024-04-01', 20000),
(26, 1, 3, '2024-05-01', 20000),
(27, 1, 3, '2024-06-01', 20000),
(28, 1, 3, '2024-07-01', 20000),


--cho phiếu thuê 1, dịch vụ nước
(34, 1, 3, '2024-02-01', 50000), -- 5 m³ x 10000
(35, 1, 3, '2024-03-01', 30000), -- 3 m³ x 10000
(36, 1, 3, '2024-04-01', 70000), -- 7 m³ x 10000
(37, 1, 3, '2024-05-01', 40000), -- 4 m³ x 10000
(38, 1, 3, '2024-06-01', 60000), -- 6 m³ x 10000
(39, 1, 3, '2024-07-01', 20000), -- 2 m³ x 10000



--cho phiếu thuê 1, dịch vụ điện
(45, 1, 5, '2024-02-01', 132000), -- 40 kWh x 3300
(46, 1, 5, '2024-03-01', 231000), -- 70 kWh x 3300
(47, 1, 5, '2024-04-01', 165000), -- 50 kWh x 3300
(48, 1, 5, '2024-05-01', 297000), -- 90 kWh x 3300
(49, 1, 5, '2024-06-01', 198000), -- 60 kWh x 3300
(50, 1, 5, '2024-07-01', 264000), -- 80 kWh x 3300



--cho phiếu thuê 2, dịch vụ rác
(58, 2, 2, '2024-04-01', 20000),
(59, 2, 2, '2024-05-01', 20000),
(60, 2, 2, '2024-06-01', 20000),
(61, 2, 2, '2024-07-01', 20000),
(62, 2, 2, '2024-08-01', 20000),
(63, 2, 2, '2024-09-01', 20000),
(64, 2, 2, '2024-10-01', 20000),


--cho phiếu thuê 2, dịch vụ nước
(67, 2, 4, '2024-04-01', 40000),  -- 4 m³
(68, 2, 4, '2024-05-01', 50000),  -- 5 m³
(69, 2, 4, '2024-06-01', 20000),  -- 2 m³
(70, 2, 4, '2024-07-01', 30000),  -- 3 m³
(71, 2, 4, '2024-08-01', 40000),  -- 4 m³
(72, 2, 4, '2024-09-01', 30000),  -- 3 m³
(73, 2, 4, '2024-10-01', 50000),  -- 5 m³

--cho phiếu thuê 2, dịch vụ điện
(76, 2, 5, '2024-04-01', 33000),  -- 10 kWh
(77, 2, 5, '2024-05-01', 132000), -- 40 kWh
(78, 2, 5, '2024-06-01', 66000),  -- 20 kWh
(79, 2, 5, '2024-07-01', 99000),  -- 30 kWh
(80, 2, 5, '2024-08-01', 49500),  -- 15 kWh
(81, 2, 5, '2024-09-01', 110000), -- 33 kWh
(82, 2, 5, '2024-10-01', 132000), -- 40 kWh


-- cho phiếu thuê 3, dịch vụ rác
(85, 3, 2, '2024-08-25', 50000),
(86, 3, 2, '2024-09-25', 50000),
(87, 3, 2, '2024-10-25', 50000),


-- cho phiếu thuê 3, dịch vụ gửi xe
(90, 3, 3, '2024-08-25', 20000),
(91, 3, 3, '2024-09-25', 20000),
(92, 3, 3, '2024-10-25', 20000),


-- cho phiếu thuê 3, dịch vụ nước
(95, 3, 4, '2024-08-25', 100000),  -- 10 m³
(96, 3, 4, '2024-09-25', 130000),  -- 13 m³
(97, 3, 4, '2024-10-25', 120000),  -- 12 m³

-- cho phiếu thuê 3, dịch vụ điện
(100, 3, 5, '2024-08-25', 264000),   -- 80 kWh
(101, 3, 5, '2024-09-25', 399000),   -- 121 kWh (chỉ tính 100 kWh)
(102, 3, 5, '2024-10-25', 330000);   -- 100 kWh





INSERT INTO [dbo].[PhieuTraPhong] (MaPTrP, MaPTP, NgayTra)
VALUES 
(1, 1, '2024-07-10');
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


-- DANH SACH PHIEU KHACH THUE PHONG
CREATE VIEW TKDANGKY AS
	SELECT PTP.MaPTP, PTP.MaPhong, KH.MaKH, KH.HoTen, KH.SDT ,PTP.NgayThue, PTP.TienDacCoc
	FROM PhieuThuePhong PTP JOIN KhachHang KH ON PTP.MaKH = KH.MaKH

SELECT * FROM [dbo].[TKDANGKY]
--- TINH TONG DOANH THU THEO CAC PHONG
CREATE VIEW DOANHTHUTHEOPHONG AS
SELECT PTP.MaPhong, SUM(P.GiaTien) AS TONG_TIEN_PHONG, SUM(PTT.ThanhTien) AS DTDICHVU, (SUM(P.GiaTien) + SUM(PTT.ThanhTien)) AS DTPHONG
FROM PhieuThuePhong PTP JOIN CT_SuDungDV CT ON PTP.MaPTP = CT.MaPTP
						JOIN DichVu DV ON CT.MaDV = DV.MaDV
						JOIN PhieuThutien PTT ON CT.MaPTP = PTT.MaPTP
						JOIN Phong P ON P.MaPhong = PTP.MaPhong
GROUP BY PTP.MaPhong, P.GiaTien

CREATE PROC PHIEUTHUTIENKH
	@PHIEUTHUE INT , @THANG INT ,@NAM INT
	AS
		SELECT PTP.MaPTP,P.MaPhong,DV.TenDV, K.HoTen, PTT.NgayThanhToan,  PTT.ThanhTien
		FROM PhieuThuePhong PTP JOIN CT_SuDungDV CT ON PTP.MaPTP = CT.MaPTP
								JOIN DichVu DV ON CT.MaDV = DV.MaDV
								JOIN PhieuThutien PTT ON CT.MaPTP = PTT.MaPTP AND CT.MaDV = PTT.MaDV
								JOIN Phong P ON P.MaPhong = PTP.MaPhong
								JOIN KhachHang K ON PTP.MaKH = K.MaKH
		WHERE PTP.MaPTP = @PHIEUTHUE AND MONTH(PTT.NgayThanhToan) = @THANG AND YEAR(PTT.NgayThanhToan) = @NAM
		GROUP BY PTP.MaPTP,P.MaPhong,DV.TenDV,K.HoTen, PTT.NgayThanhToan, PTT.ThanhTien
GO
EXEC PHIEUTHUTIENKH 2,4,2024
GO
