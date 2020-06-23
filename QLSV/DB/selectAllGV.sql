create procedure selectAllGV
	@tukhoa nvarchar(50)
as
begin
	set @tukhoa = lower(ltrim(rtrim(@tukhoa)));
	select 
		magiaovien,
		case when len(ltrim(rtrim(tendem))) > 0 then concat(ltrim(rtrim(ho)),' ',ltrim(rtrim(tendem)), ' ', ltrim(rtrim(ten)))
		else  concat(ltrim(rtrim(ho)),' ', ltrim(rtrim(ten))) end as hoten,
		convert(varchar(10),ngaysinh,103) as ngaysinh,
		case when gioitinh = 1 then 'Nam' else N'Nữ' end as gt,
		dienthoai,
		email,
		diachi
	from tblGiaoVien
	where lower(ho) like '%'+@tukhoa+'%'
	or lower(tendem) like '%'+@tukhoa+'%'
	or lower(ten) like '%'+@tukhoa+'%'
	or lower(ho) like '%'+@tukhoa+'%'
	or lower(email) like '%'+@tukhoa+'%'
	or lower(dienthoai) like '%'+@tukhoa+'%'
	or lower(magiaovien) like '%'+@tukhoa+'%'
	order by ten;
end

select * from tblGiaoVien

selectAllGV '1';