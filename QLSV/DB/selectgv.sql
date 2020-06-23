create proc selectgv
	@mgv int
as
begin
	select
		ho,tendem,ten,
		gioitinh,convert(varchar(10),ngaysinh,103) as ngsinh,
		dienthoai,email,diachi
	from tblGiaoVien
	where magiaovien = @mgv;
end