create procedure InsertGV
	@nguoitao varchar(30),
	@ho nvarchar(10),
	@tendem nvarchar(20), 
	@ten nvarchar(10),
	@gioitinh tinyint,
	@ngaysinh date,
	@email varchar(150),
	@dienthoai varchar(30),
	@diachi nvarchar(150)
as
begin
	insert into tblGiaoVien(nguoitao,ho,tendem,ten,gioitinh,ngaysinh,email,dienthoai,diachi)
	values(@nguoitao,@ho,@tendem,@ten,@gioitinh,@ngaysinh,@email,@dienthoai,@diachi);
	if @@ROWCOUNT > 0 return 1 else return 0 ;
end;