USE [master]
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
CREATE TABLE [dbo].[PhieuDenBu](
	[MaPDB] [bigint] NOT NULL,
	[MaPTP] [bigint] NOT NULL,
	[NoiDung] [nvarchar](200),
	[TienBoiThuong] [int],
	
 CONSTRAINT [PK_PhieuDenBu] PRIMARY KEY CLUSTERED 
(
	[MaPDB] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[PhieuDenBu]  WITH CHECK ADD  CONSTRAINT [FK_PhieuDenBu_PhieuThuePhong] FOREIGN KEY([MaPTP])
REFERENCES [dbo].[PhieuThuePhong] ([MaPTP])
GO
ALTER TABLE [dbo].[PhieuDenBu] CHECK CONSTRAINT [FK_PhieuDenBu_PhieuThuePhong]
GO



SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DichVu](
	[MaDV] [int] NOT NULL,
	[TenDV] [nvarchar](50),
	[Gia] [int],
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
CREATE TABLE [dbo].[PhieuSuDungDV](
	[MaPSDDV] [bigint] NOT NULL,
	[MaPTP] [bigint] NOT NULL,
	[TuNgay] [datetime],
	[DenNgay] [datetime],
	[DonGia] [int],
	[DaThanhToan] [tinyint],
 CONSTRAINT [PK_PhieuThuDienNuoc] PRIMARY KEY CLUSTERED 
(
	[MaPSDDV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[PhieuSuDungDV]  WITH CHECK ADD  CONSTRAINT [FK_PhieuSuDungDV_PhieuThuePhong] FOREIGN KEY([MaPTP])
REFERENCES [dbo].[PhieuThuePhong] ([MaPTP])
GO
ALTER TABLE [dbo].[PhieuSuDungDV] CHECK CONSTRAINT [FK_PhieuSuDungDV_PhieuThuePhong]
GO




SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CT_SuDungDV](
	[MaPSDDV] [bigint] NOT NULL,
	[MaDV] [int] NOT NULL,
	[ChiSoCu] [int],
	[ChiSoMoi] [int],
	[SoLuong] [int],
 CONSTRAINT [PK_CT_SuDungDV] PRIMARY KEY CLUSTERED 
(
	[MaPSDDV] ASC,
	[MaDV] ASC

)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


ALTER TABLE [dbo].[CT_SuDungDV]  WITH CHECK ADD  CONSTRAINT [FK_CT_SuDungDV_PhieuSuDungDV] FOREIGN KEY([MaPSDDV])
REFERENCES [dbo].[PhieuSuDungDV] ([MaPSDDV])
GO
ALTER TABLE [dbo].[CT_SuDungDV] CHECK CONSTRAINT [FK_CT_SuDungDV_PhieuSuDungDV]
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
CREATE TABLE [dbo].[CauHinh](
	[TenPhongTro] [nvarchar](50),
	[ChuPhongTro] [nvarchar](50),
	[DiaChi] [nvarchar](150),
	[SDT] [char](10),
)
GO

INSERT INTO [dbo].[Phong] (MaPhong, TrangThai, DienTich)
VALUES 
(1, 1, 20.5),  -- Phòng 1 đang có khách
(2, 0, 18.3),  -- Phòng 2 trống
(3, 1, 25.0);  -- Phòng 3 đang có khách
go


INSERT INTO [dbo].[KhachHang] (MaKH, HoTen, CMND_CanCuoc, SDT, QueQuan, GioiTinh, NgheNghiep)
VALUES 
(1, 'Nguyen Van A', '1234567890', '0901234567', 'Ha Noi', 'Nam', 'Nhan Vien'),
(2, 'Le Thi B', '0987654321', '0912345678', 'Da Nang', 'Nu', 'Giao Vien'),
(3, 'Tran Van C', '1122334455', '0923456789', 'Hai Phong', 'Nam', 'Ky Su');
go



INSERT INTO [dbo].[PhieuThuePhong] (MaPTP, MaPhong, MaKH, TienDacCoc, NgayThue, DaThanhToan)
VALUES 
(1001, 1, 1, 1000000, '2024-10-01', 0),  -- Khách hàng 1 thuê phòng 1
(1002, 3, 2, 1500000, '2024-09-25', 1);  -- Khách hàng 2 thuê phòng 3, đã thanh toán
go



INSERT INTO [dbo].[PhieuTraPhong] (MaPTrP, MaPTP, NgayTra, DaThanhtoan, ThanhTien)
VALUES 
(5001, 1001, '2024-10-10', 1, 2000000);  -- Khách hàng 1 trả phòng, đã thanh toán 2 triệu
go




INSERT INTO [dbo].[PhieuDenBu] (MaPDB, MaPTP, NoiDung, TienBoiThuong)
VALUES 
(3001, 1002, 'Hư hỏng bàn ghế', 500000);  -- Khách hàng 2 đền bù do hư hỏng đồ đạc
go


INSERT INTO [dbo].[DichVu] (MaDV, TenDV, Gia)
VALUES 
(1, 'Internet', 100000),
(2, 'Nuoc Uong', 20000),
(3, 'Dien', 3500);
go

INSERT INTO [dbo].[PhieuSuDungDV] (MaPSDDV, MaPTP, TuNgay, DenNgay, DonGia, DaThanhToan)
VALUES 
(4001, 1001, '2024-10-01', '2024-10-10', 120000, 1);  -- Khách hàng 1 sử dụng dịch vụ
go

INSERT INTO [dbo].[CT_SuDungDV] (MaPSDDV, MaDV, ChiSoCu, ChiSoMoi, SoLuong)
VALUES 
(4001, 1, NULL, NULL, 1),  -- Sử dụng 1 tháng Internet
(4001, 2, NULL, NULL, 10);  -- Sử dụng 10 chai nước
go

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
