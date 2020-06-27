
--cac PROCEDURE cua form QuanLySV:
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



CREATE PROCEDURE	SelectDiaPhuongUT
AS Begin
	select 
		MaDiaPhuong 
	from DiaPhuong
	where VungXauVungXa = 1
END

exec SelectDiaPhuongUT
DROP PROCEDURE SelectDiaPhuongUT


--form DKHP

--cac PROCEDURE cua form NhapCTHoc:
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



--form DSMonHocMo
CREATE PROCEDURE	SelectTenHKNH
AS
	select 
		TenHKNH
	from HocKyNH
GO;

exec SelectTenHKNH
DROP PROCEDURE SelectTenHKNH



CREATE PROCEDURE	SelectMonHocMo
AS
	TenHKNH
	select 
		MaHKNH
	from HocKyNH where SelectTenHKNH.TenHKNH = TenHKNH
	select 
		*
	from CT_CTHoc
GO;

exec SelectTenHKNH
DROP PROCEDURE SelectTenHKNH

