CREATE DATABASE QUANLYSANPHAM
GO
USE QUANLYSANPHAM
GO
CREATE TABLE tbl_NCC
(
msNCC nvarchar(50) primary key,
tenNCC nvarchar(100),
diachiNCC nvarchar(100),
soDTNCC nvarchar(50)
)

GO
CREATE TABLE tbl_sanpham
(
maSP nvarchar(50) primary key,
tenSP nvarchar(100),
msNCC nvarchar(50),
dacTa nvarchar(50),
giaDC float
)

GO
ALTER TABLE tbl_sanpham
ADD CONSTRAINT FK_sanpham_NCC
FOREIGN KEY (msNCC) references Tbl_NCC(msNCC)


CREATE PROC sp_ThemNCC(@MsNCC varchar(50), @TenNCC nvarchar(100), @DiaChi varchar(50), @SDTNCC varchar(100))
AS
INSERT INTO tbl_NCC(msNCC, tenNCC, diachiNCC, soDTNCC)
VALUES(@MsNCC, @TenNCC, @DiaChi, @SDTNCC)

CREATE PROC sp_SuaNCC(@MsNCC varchar(50), @TenNCC nvarchar(100), @DiaChi varchar(50), @SDTNCC varchar(100))
AS
UPDATE tbl_NCC
SET msNCC=@MsNCC,tenNCC=@TenNCC,diachiNCC=@DiaChi,soDTNCC=@SDTNCC
WHERE msNCC=@MsNCC

CREATE PROC sp_XoaNCC(@MsNCC varchar(50))
AS
DELETE 
FROM tbl_NCC
Where msNCC = @MsNCC

CREATE PROC sp_TimSanPham (@maSP nvarchar(50) ,@tenSP nvarchar(100),@msNCC nvarchar(50),@dacTa nvarchar(50),@giaDC float)
AS
INSERT INTO tbl_sanpham(maSP, tenSP, msNCC, dacTa,giaDC)
VALUES(@maSP, @tenSP, @msNCC, @dacTa,@giaDC)

CREATE PROC sp_LaySanPham
AS
SELECT * FROM tbl_sanpham

CREATE PROC sp_TimSanPham(@msNCC nvarchar(50))
AS
SELECT * 
FROM tbl_sanpham 
WHERE msNCC=@msNCC

CREATE PROC sp_ThemSanPham(@maSP nvarchar(50) ,@tenSP nvarchar(100),@msNCC nvarchar(50),@dacTa nvarchar(50),@giaDC float)
AS
INSERT INTO tbl_sanpham(maSP, tenSP, msNCC, dacTa,giaDC)
VALUES(@maSP, @tenSP, @msNCC, @dacTa,@giaDC)

CREATE PROC sp_SuaSanPham(@maSP nvarchar(50) ,@tenSP nvarchar(100),@msNCC nvarchar(50),@dacTa nvarchar(50),@giaDC float)
AS
UPDATE tbl_sanpham
SET tenSP=@tenSP,msNCC=@msNCC,dacTa=@dacTa,giaDC=@giaDC
WHERE maSP=@maSP

CREATE PROC sp_XoaSanPham(@maSP varchar(50))
AS
DELETE 
FROM tbl_sanpham
Where maSP = @maSP

go
insert into tbl_NCC( MsNCC, TenNCC , diachiNCC , soDTNCC)
values ('ms01',N'Đồng Nai',N'Biên Hoà','0123456789')
go
insert into tbl_NCC( MsNCC, TenNCC , diachiNCC , soDTNCC)
values ('ms02',N'TPHCM',N'Thủ Đức','0987654321')
go
insert into tbl_sanpham( maSP,tenSP,msNCC,dacTa,giaDC)
values ('SP1',N'Nhựa',N'ms01',N'Siêu bền','35000')
go
insert into tbl_sanpham( maSP,tenSP,msNCC,dacTa,giaDC)
values ('SP2',N'Gỗ',N'ms02',N'Không mục','750000')

