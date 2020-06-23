create proc updatelophoc
	@nguoicapnhat varchar(30),
	@malophoc bigint,
	@magiaovien int,
	@mamonhoc int
as
begin
	update tblLopHoc
	set
		ngaycapnhat = getdate(),
		nguoicapnhat = @nguoicapnhat,		
		magiaovien = @magiaovien
	where malophoc = @malophoc;
	if @@ROWCOUNT > 0 return 1 else return 0;
end
--select * from tblLopHoc
-- drop proc updatelophoc