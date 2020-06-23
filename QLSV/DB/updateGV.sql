create procedure updateGV
	@magiaovien int,
	@nguoicapnhat varchar(30),
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
	update tblGiaoVien
	set nguoicapnhat = @nguoicapnhat,
		ngaycapnhat = getdate(),
		ho = @ho,tendem = @tendem, ten = @ten,
		gioitinh = @gioitinh, ngaysinh = @ngaysinh, email = @email, dienthoai = @dienthoai, diachi = @diachi
	where magiaovien = @magiaovien;
	if @@ROWCOUNT > 0 return 1 else return 0;
end;