create proc insertlophoc
	@nguoitao varchar(30),
	@magiaovien int,
	@mamonhoc int
as
begin
	insert into tblLopHoc(nguoitao,mamonhoc,magiaovien)
	values(@nguoitao,@mamonhoc,@magiaovien);
	if @@ROWCOUNT > 0 return 1 else return 0;
end
