create database QuanLyHocPhan

create table HocPhan
(
MaHP varchar (20) primary key,
TenHP nvarchar (100),
SoTC int,
SoTietLT int,
SoTietTH int,
)
GO
CREATE PROC LayHocPhan
AS
SELECT * FROM HocPhan

GO
CREATE PROC ThemHocPhan(@MaHP nvarchar(20) ,@TenHP nvarchar(100),@SoTC int,@SoTietLT int,@SoTietTH int)
AS
INSERT INTO HocPhan(MaHP, TenHP, SoTC, SoTietLT,SoTietTH)
VALUES(@MaHP, @TenHP, @SoTC, @SoTietLT,@SoTietTH)

GO
CREATE PROC SuaHocPhan(@MaHP nvarchar(20) ,@TenHP nvarchar(100),@SoTC int,@SoTietLT int,@SoTietTH int)
AS
UPDATE HocPhan
SET TenHP=@TenHP,SoTC=@SoTC,SoTietLT=@SoTietLT,SoTietTH=@SoTietTH
WHERE MaHP=@MaHP

GO
CREATE PROC XoaHocPhan(@MaHP nvarchar(20))
AS
DELETE 
FROM HocPhan
Where MaHP=@MaHP

GO
CREATE PROC TimHocPhan(@MaHP nvarchar(20))
AS 
SELECT * FROM 
Where MaHP=@MaHP
