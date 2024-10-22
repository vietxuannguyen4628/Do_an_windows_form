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
	[DaThanhtoan] [tinyint],
	[ThanhTien] [int],
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
	[SoLuong] [int],
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
	[MaPTP] [bigint] NOT NULL,
	[MaDV] [int] NOT NULL,
	[TuNgay] [datetime],
	[DenNgay] [datetime],
	[ThanhTien] [int],
	[DaThanhToan] [tinyint],
 CONSTRAINT [PK_PhieuThutien] PRIMARY KEY CLUSTERED 
(
	[MaPTP] ASC,
	[MaDV] ASC
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
(101, 1, 30.5, 500000),
(102, 0, 25.0, 400000),
(103, 1, 45.0, 800000),
(104, 1, 28.0, 5500000),
(105, 0, 32.5, 6500000),
(106, 1, 20.0, 4800000),
(107, 1, 25.0, 5200000),
(108, 0, 30.0, 6100000),
(109, 1, 22.5, 4900000),
(110, 1, 29.0, 5700000),
(111, 0, 24.0, 5400000),
(112, 1, 26.0, 6000000),
(113, 1, 21.5, 5000000);

-- Thêm dữ liệu cho bảng KhachHang
INSERT INTO [dbo].[KhachHang] (MaKH, HoTen, CMND_CanCuoc, SDT, QueQuan, GioiTinh, NgheNghiep) VALUES
(1, N'Nguyễn Văn A', '1234567890', '0912345678', N'Hà Nội', N'Nam', N'Kỹ sư'),
(2, N'Trần Thị B', '0987654321', '0987654321', N'Hồ Chí Minh', N'Nữ', N'Sinh viên'),
(3, N'Lê Văn C', '1122334455', '0909876543', N'Đà Nẵng', N'Nam', N'Technician');

-- Thêm dữ liệu cho bảng PhieuThuePhong
INSERT INTO [dbo].[PhieuThuePhong] (MaPTP, MaPhong, MaKH, TienDacCoc, NgayThue, DaThanhToan) VALUES
(1, 101, 1, 100000, '2024-10-01', 1),  -- Ngày thuê 01/10/2024
(2, 102, 2, 200000, '2024-10-15', 0),  -- Ngày thuê 15/10/2024
(3, 103, 3, 150000, '2024-10-20', 0);  -- Ngày thuê 20/10/2024

-- Thêm dữ liệu cho bảng PhieuTraPhong
INSERT INTO [dbo].[PhieuTraPhong] (MaPTrP, MaPTP, NgayTra, DaThanhtoan, ThanhTien) VALUES
(1, 1, '2024-10-05', 1, 500000),  -- Ngày trả 05/10/2024
(2, 2, '2024-10-20', 0, 400000),  -- Ngày trả 20/10/2024
(3, 3, '2024-10-25', 0, 600000);  -- Ngày trả 25/10/2024

-- Thêm dữ liệu cho bảng DichVu
INSERT INTO [dbo].[DichVu] (MaDV, TenDV, DonGia) VALUES
(1, N'Dọn phòng', 100000),
(2, N'Suối nước', 50000),
(3, N'Giặt ủi', 20000);

-- Thêm dữ liệu cho bảng CT_SuDungDV
INSERT INTO [dbo].[CT_SuDungDV] (MaPTP, MaDV, ChiSoCu, ChiSoMoi, SoLuong) VALUES
(1, 1, 0, 1, 1),  -- Sử dụng dịch vụ dọn phòng cho phiếu thuê phòng 1
(1, 2, 0, 2, 1),  -- Sử dụng dịch vụ suối nước cho phiếu thuê phòng 1
(2, 1, 0, 1, 1),  -- Sử dụng dịch vụ dọn phòng cho phiếu thuê phòng 2
(3, 3, 0, 1, 2);  -- Sử dụng dịch vụ giặt ủi cho phiếu thuê phòng 3

-- Thêm dữ liệu cho bảng PhieuThutien
INSERT INTO [dbo].[PhieuThutien] (MaPTP, MaDV, TuNgay, DenNgay, ThanhTien, DaThanhToan) VALUES
(1, 1, '2024-10-01', '2024-10-02', 100000, 1),  -- Từ ngày 01/10/2024 đến 02/10/2024
(1, 2, '2024-10-15', '2024-10-16', 150000, 0),  -- Từ ngày 15/10/2024 đến 16/10/2024
(3, 3, '2024-10-20', '2024-10-21', 200000, 0);  -- Từ ngày 20/10/2024 đến 21/10/2024


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







-- Insert data into Faculty table
--INSERT [dbo].[Faculty] ([FacultyID], [FacultyName], [TotalProfessor]) VALUES ('1258453483', N'Công nghệ thông tin',2)
--INSERT [dbo].[Faculty] ([FacultyID], [FacultyName], [TotalProfessor]) VALUES ('2438294564', N'Ngôn ngữ Anh',2)
--INSERT [dbo].[Faculty] ([FacultyID], [FacultyName], [TotalProfessor]) VALUES ('6122485930', N'Quản trị kinh doanh',2)
--INSERT [dbo].[Faculty] ([FacultyID], [FacultyName], [TotalProfessor]) VALUES ('7144839204', N'Công nghệ ô tô',1)
--INSERT [dbo].[Faculty] ([FacultyID], [FacultyName], [TotalProfessor]) VALUES ('9483502358', N'Kế Toán',1)
--INSERT [dbo].[Faculty] ([FacultyID], [FacultyName], [TotalProfessor]) VALUES ('3204224573', N'Khoa học môi trường', 3);
--INSERT [dbo].[Faculty] ([FacultyID], [FacultyName], [TotalProfessor]) VALUES ('4430459823', N'Kỹ thuật điện tử', 2);
--INSERT [dbo].[Faculty] ([FacultyID], [FacultyName], [TotalProfessor]) VALUES ('2390423325', N'Marketing', 1);
--INSERT [dbo].[Faculty] ([FacultyID], [FacultyName], [TotalProfessor]) VALUES ('0294234408', N'Tài chính - Ngân hàng', 2);
--INSERT [dbo].[Faculty] ([FacultyID], [FacultyName], [TotalProfessor]) VALUES ('1902348740', N'Du lịch', 1);

---- Insert data into Student table with Gender values and order before FacultyID
--INSERT [dbo].[Student] ([StudentID], [FullName], [AverageScore], [Gender], [FacultyID]) 
--VALUES (N'1611061916', N'Nguyễn Trần Hoàng Lan', 4.5, N'Female', '1258453483');
--INSERT [dbo].[Student] ([StudentID], [FullName], [AverageScore], [Gender], [FacultyID]) 
--VALUES (N'1711060596', N'Đảm Minh Đức', 10, N'Male', '6122485930');
--INSERT [dbo].[Student] ([StudentID], [FullName], [AverageScore], [Gender], [FacultyID]) 
--VALUES (N'1811061004', N'Nguyễn Quốc An', 8, N'Male', '1258453483');
--INSERT [dbo].[Student] ([StudentID], [FullName], [AverageScore], [Gender], [FacultyID]) 
--VALUES (N'2111062201', N'Dương Quốc Minh', 6.5, N'Male', '4430459823');
--INSERT [dbo].[Student] ([StudentID], [FullName], [AverageScore], [Gender], [FacultyID]) 
--VALUES (N'2111061113', N'Nguyễn Thị B', 5.5, N'Female', '6122485930');
--INSERT [dbo].[Student] ([StudentID], [FullName], [AverageScore], [Gender], [FacultyID]) 
--VALUES (N'1711061233', N'Trần Văn A', 7, N'Male', '2438294564');
--INSERT [dbo].[Student] ([StudentID], [FullName], [AverageScore], [Gender], [FacultyID]) 
--VALUES (N'1911060023', N'Lê Hoàng Phương', 7.8, N'Female', '1258453483');
--INSERT [dbo].[Student] ([StudentID], [FullName], [AverageScore], [Gender], [FacultyID]) 
--VALUES (N'2011061205', N'Phạm Văn Cường', 9.1, N'Male', '2438294564');
--INSERT [dbo].[Student] ([StudentID], [FullName], [AverageScore], [Gender], [FacultyID]) 
--VALUES (N'2111062234', N'Trần Thị Hoa', 6.9, N'Female', '9483502358');
--INSERT [dbo].[Student] ([StudentID], [FullName], [AverageScore], [Gender], [FacultyID]) 
--VALUES (N'2211063312', N'Nguyễn Minh Tú', 8.5, N'Male', '1902348740');
--INSERT [dbo].[Student] ([StudentID], [FullName], [AverageScore], [Gender], [FacultyID]) 
--VALUES (N'2211063419', N'Hoàng Thị Minh', 9.0, N'Female', '3204224573');
--GO
--ALTER TABLE [dbo].[Student]  WITH CHECK ADD  CONSTRAINT [FK_Student_Faculty] FOREIGN KEY([FacultyID])
--REFERENCES [dbo].[Faculty] ([FacultyID])
--GO
--ALTER TABLE [dbo].[Student] CHECK CONSTRAINT [FK_Student_Faculty]
--GO
--USE [master]
--GO
--ALTER DATABASE [QuanLyPhongTro] SET  READ_WRITE 
--GO
