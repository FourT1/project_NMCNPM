 create procedure insertMH
	@nguoitao varchar(30),
	@tenmonhoc nvarchar(150),
	@sotinchi int
as
begin
	insert into tblMonHoc(nguoitao,tenmonhoc,sotinchi)
	values(@nguoitao,@tenmonhoc,@sotinchi);
	if @@ROWCOUNT > 0 return 1 else return 0;
end