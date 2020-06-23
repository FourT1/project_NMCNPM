create procedure updateMH
	@nguoicapnhat varchar(30),
	@mamonhoc bigint,
	@tenmonhoc nvarchar(150),
	@sotinchi int
as
begin
	update tblMonHoc
	set
		nguoicapnhat = @nguoicapnhat,
		ngaycapnhat = getdate(),
		tenmonhoc = @tenmonhoc,
		sotinchi = @sotinchi
	where mamonhoc = @mamonhoc;
	if @@ROWCOUNT > 0 return 1 else return 0;
	
end