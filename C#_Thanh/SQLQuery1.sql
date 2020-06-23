create proc sp_login
@id nvarchar(50),
@pass nvarchar(50)
as begin
select * from tbl_nhanvien where @id=sUserName and @pass=sPassword
end

alter proc sp_resetmk
@id nvarchar(50),
@pass nvarchar(50),
@sdt nvarchar(10),
@cmt nvarchar(20)
as begin
update tbl_nhanvien set sPassword=@pass where sUserName = @id and sSDT = @sdt and sCMT = @cmt
end

create proc sp_changemk
@id nvarchar(50),
@pass nvarchar(50),
@newpass nvarchar(50)
as begin
update tbl_nhanvien set sPassword=@newpass where sUserName = @id and sPassword=@pass
end

alter proc sp_selectsv
as begin
select * from tbl_sinhvien order by sMaSV
end

create proc sp_fixsv
@id nvarchar(20),
@ten nvarchar(50),
@lop nvarchar(10),
@he nvarchar(20),
@tt nvarchar(20),
@khoa nvarchar(50)
as begin
update tbl_sinhvien set sTenSV=@ten , sLop = @lop ,sHe = @he , sKhoa=@khoa,sTinhTrang = @tt where sMaSV=@id
end

create proc sp_insertsv
@id nvarchar(20),
@ten nvarchar(50),
@lop nvarchar(10),
@he nvarchar(20),
@tt nvarchar(20),
@khoa nvarchar(50)
as begin
insert into tbl_sinhvien values (@id,@ten,@lop,@he,@tt,@khoa)
end

alter proc timkiem
@id nvarchar(20)
as begin
select * from tbl_sinhvien where sMaSV = @id
end

create proc sp_delete
@id nvarchar(20)
as begin
delete from tbl_sinhvien where sMaSV = @id
end

create proc sp_selectlop
AS begin
select * from tbl_sinhvien order by sLop
end

create proc sp_selecttt
as begin
select * from tbl_sinhvien order by sTinhTrang
end

create proc sp_selecthe
as begin
select * from tbl_sinhvien order by sHe
end

alter proc sp_selectmon
as begin
select sIDmon as N'Mã môn' ,sTenMon as N'Tên Môn',sTenGV AS N'Giáo viên',iTinchi as N'Số tín chỉ',mGia as N'Giá tín chỉ' from tbl_monhoc order by sIDmon
end

create proc sp_addmon
@masv nvarchar(20),
@mamon nvarchar(50)
as begin
insert into tbl_dangki values (@masv,@mamon)
end

create proc sp_SelectSvID
@id nvarchar(20)
as begin
select * from tbl_sinhvien where sMaSV=@id
end

alter proc sp_LayMonHoc
@id nvarchar(20)
as begin
select tbl_monhoc.sIDmon as N'Mã Lớp' , tbl_monhoc.sTenMon as N'Tên Môn' , tbl_monhoc.sTenGV as N'Giáo viên',tbl_monhoc.iTinchi as N'Số tín chỉ', tbl_monhoc.mGia as N'Giá tín chỉ(VNĐ)' from tbl_monhoc,tbl_dangki where tbl_dangki.sMaSv=@id and tbl_dangki.sIDmon=tbl_monhoc.sIDmon
end

alter proc sp_TongTien
@id nvarchar(20)
as begin
select sum(tbl_monhoc.mGia*tbl_monhoc.iTinchi) as TT from tbl_monhoc,tbl_dangki where tbl_dangki.sMaSv=@id and tbl_dangki.sIDmon=tbl_monhoc.sIDmon
end

alter proc sp_insertHD
@masv nvarchar(20),
@tongtien real,
@thanhtoan real,
@ngaylap datetime,
@nguoilap nvarchar(50)
as begin
insert into tbl_hoadon values (@masv,@tongtien,@thanhtoan,@ngaylap,@nguoilap)
end
select * from tbl_hoadon

alter proc sp_selectHD
@id nvarchar(20)
as begin
select * from tbl_hoadon WHERE sMaSV = @id
end

create proc sp_ThanhToan
@id nvarchar(20)
as begin
update tbl_sinhvien set sTinhTrang = N'Đã nộp' where tbl_sinhvien.sMaSV = @id 
end

alter proc sp_NguoiLap
@manv nvarchar(50)
as begin
select sTenNV from tbl_nhanvien where sUserName = @manv
end

create proc sp_HDsv
@id nvarchar(20)
as begin
select * from tbl_sinhvien where tbl_sinhvien.sMaSV = @id
end

alter proc sp_HDmonhoc
@id nvarchar(20)
as begin 
select tbl_monhoc.sIDmon,tbl_monhoc.iTinchi,tbl_monhoc.mGia,tbl_monhoc.sTenGV,tbl_monhoc.sTenMon from tbl_dangki,tbl_monhoc where tbl_dangki.sMaSv = @id and tbl_dangki.sIDmon = tbl_monhoc.sIDmon
end

create proc sp_HDhd
@id nvarchar(20)
as begin 
select * FROM tbl_hoadon where @id = sMaSV
end

create proc sp_selectNV
@id nvarchar(50)
as begin
select sTenNV,sSDT,sCMT from tbl_nhanvien where @id = tbl_nhanvien.sUserName 
end

alter proc sp_countNV
@nvName nvarchar(50)
as begin
select COUNT(sNguoiLap) as nv from tbl_hoadon where tbl_hoadon.sNguoiLap = @nvName
end

create proc sp_deletedk
@id nvarchar(20)
as begin
delete  from tbl_dangki where @id = tbl_dangki.sMaSv
end

create proc sp_deletehd
@id nvarchar(20)
as begin 
delete from tbl_hoadon where @id = tbl_hoadon.sMaSV
end

create proc sp_addnv
@username nvarchar(50),
@password nvarchar(50),
@tennv nvarchar(50),
@sdt nvarchar(10),
@cmt nvarchar(20)
as begin 
insert into tbl_nhanvien values (@username,@password,@tennv,@sdt,@cmt)
end

alter proc sp_addmonhoc
@idmon nvarchar(50),
@tenmon nvarchar(50),
@tinchi int,
@gia float,
@tengv nvarchar(50)
as begin
insert into tbl_monhoc values (@idmon,@tenmon,@tinchi,@gia,@tengv)
end

create proc sp_updatemon
@idmon nvarchar(50),
@tenmon nvarchar(50),
@tinchi int,
@gia float,
@tengv nvarchar(50)
as begin
update tbl_monhoc set sTenMon=@tenmon,iTinchi=@tinchi,mGia=@gia,sTenGV =@tengv where sIDmon =@idmon
end
