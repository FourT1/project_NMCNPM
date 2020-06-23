create proc ketthuchocphan
	@magiaovien varchar(30), --người kết thúc
	@malop bigint -- kết thúc lớp học phần nào
as
begin
	update tblLopHoc
	set
		nguoicapnhat = @magiaovien,
		ngaycapnhat = getdate(),
		daketthuc = 1
	where malophoc = @malop;
	if @@ROWCOUNT>0 return 1 -- cập nhật thành công
	else return 0; -- thất bại
end