create procedure selectAllMonHoc
	@tukhoa nvarchar(50)
as
begin
	set @tukhoa = lower(ltrim(rtrim(@tukhoa)));
	select 
		mamonhoc,
		tenmonhoc,
		sotinchi
	from tblMonHoc
	where mamonhoc like '%'+@tukhoa+'%'
	or lower(tenmonhoc) like '%'+@tukhoa+'%'
	order by tenmonhoc;	
end;
selectAllMonHoc ''