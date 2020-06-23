create procedure ThemMoiSV
	@ho nvarchar(10),@tendem nvarchar(20), @ten nvarchar(10),
	@ngaysinh date, @gioitinh tinyint, @quequan nvarchar(150),
	@diachi nvarchar(150), @dienthoai varchar(30), @email varchar(150)
as
begin
	insert into tblSinhVien(masinhvien,ho,tendem,ten,ngaysinh,gioitinh,quequan,diachi,dienthoai,email)
	values( 'SV'+cast(next value for sinhvienSeq as varchar(30)),@ho,@tendem,@ten,@ngaysinh,@gioitinh,@quequan,@diachi,@dienthoai,@email);
	if @@ROWCOUNT > 0 begin return 1 end
	else begin return 0 end;
end;