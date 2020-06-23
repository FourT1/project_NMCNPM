select * from tblLopHoc;

create proc dsLopChuaDKy
	@masinhvien varchar(50)
as
begin
	select
		l.malophoc,
		l.mamonhoc,
		m.tenmonhoc,
		m.sotinchi,
		case when len(g.tendem)>0 then concat(g.ho,' ',g.tendem,' ',g.ten)
		else concat(g.ho,' ',g.ten) end as gvien
	from tblLopHoc l
	inner join tblGiaoVien g on l.magiaovien = g.magiaovien
	inner join tblMonHoc m on l.mamonhoc = m.mamonhoc
	where l.daketthuc = 0 -- lấy các lớp đang mở
	and l.malophoc not in ( select malophoc from tblDiem where masinhvien = @masinhvien);
end


dsLopChuaDKy 'SV1100'