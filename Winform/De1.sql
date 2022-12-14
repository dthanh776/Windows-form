--tạo cơ sở dữ liệu
create Database QLHoadon
go
use QLHoadon
-- tao bang 
go
create table HoaDon (MaHD char(10) primary key not null,
					TenKH nvarchar(20) not null,
					SoDienthoaiKH nvarchar(15),
					TenHang nvarchar(20),
					Ngaymua date,
					SoLuong int ,
					DonGia int, 
					Thanhtien float)
					
-- thuc hien cac chuc nang them, xoa, sua, tim kiem va  truy van du lieu
GO
CREATE PROC LayHoaDon
AS
SELECT * FROM HoaDon

GO
CREATE PROC ThemHoaDon(@MaHD char(10), @TenKH nvarchar(20), @SoDienthoaiKH nvarchar(15), @TenHang nvarchar(20), @Ngaymua date, @SoLuong int, @DonGia int, @Thanhtien float)
AS
INSERT INTO HoaDon(MaHD, TenKH, SoDienthoaiKH, TenHang, Ngaymua, SoLuong, DonGia, Thanhtien)
VALUES(@MaHD, @TenKH, @SoDienthoaiKH, @TenHang, @Ngaymua, @SoLuong, @DonGia, @Thanhtien)

GO
CREATE PROC SuaHoaDon(@MaHD char(10), @TenKH nvarchar(20), @SoDienthoaiKH nvarchar(15), @TenHang nvarchar(20), @Ngaymua date, @SoLuong int, @DonGia int, @Thanhtien float)
AS
UPDATE HoaDon
SET TenKH=@TenKH, SoDienthoaiKH=@SoDienthoaiKH, TenHang=@TenHang, Ngaymua=@Ngaymua, SoLuong = @SoLuong, DonGia = @DonGia,Thanhtien = @Thanhtien
WHERE MaHD=@MaHD

GO
CREATE PROC XoaHoaDon(@MaHD char(10))
AS
DELETE 
FROM HoaDon
Where MaHD=@MaHD

GO
CREATE PROC TimHoaDon(@MaHD char(10))
AS 
SELECT * FROM HoaDon
Where MaHD=@MaHD

insert into HoaDon(MaHD, TenKH, SoDienthoaiKH, TenHang, Ngaymua, SoLuong, DonGia, Thanhtien)
values ('a' , N'as',N'021', N'sdq', '12/12/2021',2,3,4.02)
