create procedure updateSV
	@masinhvien varchar(50),
	@ho	nvarchar(10),
	@tendem nvarchar(20),
	@ten nvarchar(10),
	@ngaysinh date,
	@gioitinh tinyint,
	@quequan nvarchar(150),
	@diachi nvarchar(150),
	@dienthoai varchar(30),
	@email varchar(150)
as
begin
	update tblSinhVien
	set 
		ho = @ho,tendem = @tendem,ten=@ten,
		ngaysinh = @ngaysinh,gioitinh = @gioitinh,
		quequan = @quequan, diachi = @diachi,
		dienthoai = @dienthoai, email = @email
	where masinhvien = @masinhvien;
	if @@ROWCOUNT > 0 begin return 1 end 
	else begin return 0 end;
end;
