use QLHP;


create proc dsMonHocMo
	@HocKy tinyint,
	@NamHoc nvarchar(4),
	@masv nvarchar(8)
as 
begin
select 
	l.MaMH,
	g.TenMH, 
	g.SoTC
from DS_MHM l
inner join MONHOC g on l.MaMH = g.MaMH
inner join MonHocMo a on l.MaMHM = a.MaMHM
inner join CTHOC b on a.MaCTH = b.MaCTH
where a.HocKy = @HocKy and a.NamHoc = @NamHoc and b.MaNganh IN (SELECT MaNganh FROM SINHVIEN WHERE SINHVIEN.MaSV = @masv);
end


create proc create_DKHP
	@sophieu varchar(4),
	@masv varchar(8),
	@ngaylap smalldatetime,
	@hocky tinyint,
	@namhoc varchar(4)
as
begin
	insert into DKHP values(@sophieu, @masv, @ngaylap, @hocky, @namhoc)
end
	

create proc access_DKHP
	@sophieu varchar(4),
	@masv varchar(8)
as
begin
	select a.MaMH, b.TenMH, b.LoaiMon, b.SoTC
	from CT_DKHP a inner join MONHOC b on a.MaMH = b.MaMH
	inner join DKHP on a.MaDKHP = DKHP.MaDKHP
	where @sophieu = DKHP.MaDKHP and @masv = DKHP.MaSV
end



create proc dangky_MH
	@mamh nvarchar(10),
	@sophieu nvarchar(10)
as
begin
	insert into CT_DKHP values (@sophieu, @mamh)
end



create proc delete_MH
	@mamh nvarchar(10)
as
begin
	DELETE CT_DKHP WHERE MaMH = @mamh
end