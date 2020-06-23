--1:  tra cứu kết quả học tập = các học phần (lớp học) có trạng thái kết thúc (daketthuc) = 1
select * from tblLopHoc;
--2: dữ liệu điểm lại được lưu ở bảng tblDiem
--=> để lấy được kết quả học tập cần join 2 bảng tblDiem và tblLopHoc
--với dữ liệu truyền vào là mã sinh viên ( tài khoản đăng nhập. Sinh viên đăng nhập vào chỉ xem được điểm của mình, k xem được điểm của sv khác )
--cần load thêm lần học và mã môn học tên giáo viên(tblGiaoVien) nữa cho đẹp
--tblLopHoc có liên kết khóa ngoại với bảng giáo viên => join để lấy dữ liệu
drop proc tracuudiem;
create procedure tracuudiem
	@masinhvien varchar(50),
	@tukhoa nvarchar(50) -- cái này dùng để lọc dữ liệu tìm kiếm
as
begin
	set @tukhoa = lower(@tukhoa); -- lower là cho toàn bộ kí tự in thường
	select 
		m.mamonhoc,
		m.tenmonhoc,
		d.lanhoc,
		case when len(g.magiaovien)>0 then concat(g.ho,' ',g.tendem,' ',g.ten)
		else concat(g.ho,' ',g.ten) end as gvien,--kiểm tra nếu có tên đệm thì nối họ + tên đệm + tên ngược lại thì nối họ + tên
		d.diemthilan1,
		d.diemthilan2
	from tblDiem d
	inner join tblLopHoc l on d.malophoc = l.malophoc
	inner join tblMonHoc m on l.mamonhoc = m.mamonhoc
	inner join tblGiaoVien g on l.magiaovien = g.magiaovien
	where l.daketthuc = 1
	and d.masinhvien = @masinhvien
	and lower(m.tenmonhoc) like '%'+@tukhoa+'%'; -- lọc theo từ khóa tìm kiếm truyền vào
end

--toàn mã mã loằng ngoằng
--chúng ta cần hiển thị tên môn học ( nằm trong bảng tblMonHoc)
--mà tblLop liên kết khóa ngoại với bảng tblMonHoc qua khoa mamonhoc => inner join phát nữa
--và chỉ số điểm
--đã load được toàn bộ điểm của lớp có trạng thái kết thúc
--tuy nhiên chúng ta chỉ cần load điểm của sinh viên đang đăng nhập (msv) truyền vào

select * from tblLopHoc where daketthuc = 1; -- lấy danh sách lớp học đã kết thúc
--Hiện tại chưa có lớp nào đã kết thúc cả
--khi hoàn thiện thì giáo viên là người kết thúc lớp học
--tuy nhiên chúng ta chưa code tới đoạn đó
-- nên mình sẽ kết thúc 1 lớp bằng cơm (^_^) để chúng ta test nhé
update tblLopHoc set daketthuc = 1 where malophoc = 4; 

--sorry lớp này ( mã bằng 2) chưa có a nào đăng ký học cả @@)

--load danh sách sinh viên từ bảng điểm đã học lớp có mã lớp là 1 nhé
select * from tblDiem where malophoc = 4;
update tblDiem set diemthilan1 = 8.5 where masinhvien = 'SV1100' and malophoc = 4;--lớp học đã kết thúc nên sinh viên cũng phải có điểm
--chúng ta có toàn sinh viên giỏi cả nên chỉ thi 1 phát là qua luôn
update tblDiem set diemthilan1 = 9 where masinhvien = 'SV1101' and malophoc = 4;
update tblDiem set diemthilan1 = 7.8 where masinhvien = 'SV1102' and malophoc = 4;

--update kết thúc vài lớp nữa để test tìm kiếm nhé




