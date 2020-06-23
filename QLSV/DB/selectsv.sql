create procedure selectsv
	@msv varchar(50)
as
begin
	select
		ho,tendem,ten,
		convert(varchar(10),ngaysinh,103) as ngsinh,
		gioitinh,
		quequan,diachi,dienthoai,email
	from tblSinhVien
	where masinhvien = @msv;
end


