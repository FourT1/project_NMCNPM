create proc selectmh
	@mamh int
as
begin
	select 
		tenmonhoc,
		sotinchi
	from tblMonHoc
	where mamonhoc = @mamh;
end