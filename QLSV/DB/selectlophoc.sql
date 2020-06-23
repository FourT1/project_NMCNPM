create proc selectLopHoc
	@malophoc bigint
as
begin
	select
		m.tenmonhoc,
		g.magiaovien,
		l.mamonhoc
	from tblLopHoc l
	inner join tblGiaoVien g on l.magiaovien = g.magiaovien
	inner join tblMonHoc m on l.mamonhoc = m.mamonhoc
	where malophoc = @malophoc;
end
--drop proc selectlophoc