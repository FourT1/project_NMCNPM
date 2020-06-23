create proc monDaDKy
	@masinhvien varchar(50)
as
begin
	select 
		l.malophoc,
		m.tenmonhoc,
		case when(len(g.tendem) > 0 ) then concat(g.ho,' ',g.tendem,' ',g.ten)
		else concat(g.ho,' ',g.ten) end as gvien,
		m.sotinchi,
		d.diemthilan1,
		d.diemthilan2
	from tblDiem d
	inner join tblLopHoc l on d.malophoc = l.malophoc
	inner join tblMonHoc m on l.mamonhoc = m.mamonhoc
	inner join tblGiaoVien g on l.magiaovien = g.magiaovien
	where l.daketthuc = 0 -- môn đã đăng ký <-> lớp đang/chưa mở  => trạng thái kết thúc là 0; nếu trạng thái đã kết thúc = 1 => học phần đã học xong, điểm chác đã xong @@
	and d.masinhvien = @masinhvien;
end