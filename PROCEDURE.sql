
--cac PROCEDURE cua yc1:
CREATE PROCEDURE	SelectTenKhoa
AS
	select 
		TenKhoa
	from Khoa
GO;

exec SelectTenKhoa
DROP PROCEDURE SelectTenKhoa


CREATE PROCEDURE	SelectTenNganh
AS
	select 
		TenNganh
	from Nganh
GO;

exec SelectTenNganh
DROP PROCEDURE SelectTenNganh



CREATE PROCEDURE	SelectTenDoiTuong
AS
	select 
		TenDoiTuong
	from DoiTuong
GO;

exec SelectTenDoiTuong
DROP PROCEDURE SelectTenDoiTuong



CREATE PROCEDURE	SelectDiaPhuong
AS
	select 
		MaDiaPhuong
	where VungXauVungXa = 1
	from DiaPhuong
GO;

exec SelectDiaPhuong
DROP PROCEDURE SelectTenDiaPhuong


--cac PROCEDURE cua yc3:
CREATE PROCEDURE	SelectTenKhoa
AS
	select 
		TenKhoa
	from Khoa
GO;

exec SelectTenKhoa
DROP PROCEDURE SelectTenKhoa


CREATE PROCEDURE	SelectTenNganh
AS
	select 
		TenNganh
	from Nganh
GO;

exec SelectTenNganh
DROP PROCEDURE SelectTenNganh


