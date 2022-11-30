-- Bùi Duy Thanh_20211TT0660 --
create database QuanLyBanThuoc

--drop table ThuocTay

create table HoaDon
(
MaHD nvarchar (10) primary key,
Ngayban datetime,
TenHieuThuoc nvarchar (30),
DiaChi nvarchar (30)
)

create table ChiTiet
(
MaHD nvarchar (10),
MaThuoc nvarchar (10),
SoLuong int 
primary key (MaHD,MaThuoc)
)

create table ThuocTay
(
MaThuoc nvarchar (10) primary key,
TenThuoc nvarchar (30),
DonViTinh nvarchar (10),
DonGia int
)

-- KHOA NGOAI -- 

alter table ChiTiet
add constraint FK_ChiTiet_HoaDon
foreign key (MaHD) 
references HoaDon (MaHD)

alter table ChiTiet
add constraint FK_ChiTiet_ThuocTay
foreign key (MaThuoc) 
references ThuocTay (MaThuoc)
-- HIEN THI HOA DON
create Proc hienThiHoaDon
as Begin
	select * from HoaDon
end
go
-- LUU HOA DON
CREATE PROC LuuHoaDon(@MaHD nvarchar(10), @Ngayban datetime, @TenHieuThuoc nvarchar (30), @DiaChi nvarchar (30))
AS
INSERT INTO HoaDon(MaHD, Ngayban, TenHieuThuoc, DiaChi)
VALUES(@MaHD, @Ngayban, @TenHieuThuoc, @DiaChi)
GO
-- SUA HOA DON
CREATE PROC SuaHoaDon(@MaHD nvarchar(10), @Ngayban datetime, @TenHieuThuoc nvarchar (30), @DiaChi nvarchar (30))
AS
update HoaDon
SET  Ngayban= @Ngayban, TenHieuThuoc = @TenHieuThuoc, DiaChi = @DiaChi
WHERE MaHD= @MaHD
GO
-- XOA HOA DON
CREATE PROC XoaHoaDon(@MaHD nvarchar(10))
AS
DELETE 
FROM HoaDon
Where MaHD= @MaHD
GO
-- CHECK TON TAI
CREATE PROC checkTonTaiHoaDon(@MaHD nvarchar(10))
AS
SELECT *
FROM HoaDon
Where MaHD = @MaHD
GO
-- TIM KIEM
CREATE PROC TimMaHoaDon(@MaHD nvarchar(10))
AS
SELECT *
FROM HoaDon
Where  LOWER(MaHD) LIKE '%' + LOWER(TRIM(@MaHD)) + '%'
GO

-- DU LIEU THUOC TAY

INSERT INTO ThuocTay (MaThuoc, TenThuoc, DonViTinh, DonGia)
VALUES( N'MT01', N'?au b?ng', N'Viên', 3000),
( N'MT02', N'Nh?c ??u', N'V?', 5000),
( N'MT03', N'Nh?c ??u', N'H?p', 10000)

CREATE PROC TimMaThuoc(@MaThuoc nvarchar(10))
AS
SELECT *
FROM ThuocTay
Where  LOWER(MaThuoc) LIKE '%' + LOWER(TRIM(@MaThuoc)) + '%'
GO

-- DU LIEU CHI TI?T
INSERT INTO ChiTiet (MaHD, MaThuoc, SoLuong)
VALUES( N'HD01', N'MT01', 5000),
( N'HD02', N'MT02', 6000),
( N'HD03', N'MT03', 7000)
