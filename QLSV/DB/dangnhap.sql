 create proc dangnhap
	@loaitaikhoan nvarchar(10),
	@taikhoan varchar(50),
	@matkhau varchar(50)
as
begin
	if @loaitaikhoan = 'admin' 
		select * from taikhoan where tentaikhoan = @taikhoan and matkhau = @matkhau
		else if @loaitaikhoan = 'gv' 
			select * from tblGiaoVien where cast(magiaovien as varchar(50)) = @taikhoan and matkhau = @matkhau
		else select * from tblSinhVien where masinhvien = @taikhoan and matkhau = @matkhau ;
end


dangnhap 'gv','1','12345';