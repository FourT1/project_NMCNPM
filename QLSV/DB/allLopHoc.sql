create proc allLopHoc
	@tukhoa nvarchar(50)
as
begin
	set @tukhoa = lower(@tukhoa); -- lowercase <-> viết thường
	select 
		l.malophoc,
		l.mamonhoc,
		m.tenmonhoc,
		m.sotinchi,
		case 
			when len(g.tendem) > 0 then concat(g.ho,' ',g.tendem,' ',g.ten)
			else concat(g.ho,' ',g.ten) end as gvien ,
		case when l.daketthuc = 1 then N'Đã kết thúc'
				else N'Đang mở' end trangthai
	from tblLopHoc l
	inner join tblMonHoc m on l.mamonhoc = m.mamonhoc
	inner join tblGiaoVien g on l.magiaovien = g.magiaovien
	where  m.tenmonhoc like '%'+@tukhoa+'%' -- tìm kiếm tương đối có chứa từ khóa
	or lower(concat(g.ho,' ',g.tendem,' ',g.ten)) like '%'+@tukhoa+'%' -- tìm kiếm tương đối có chứa từ khóa
	or lower(concat(g.ho,' ',g.tendem,' ',g.ten)) like '%'+@tukhoa+'%'; -- tìm kiếm tương đối có chứa từ khóa
end