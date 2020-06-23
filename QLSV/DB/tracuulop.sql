-- cần load danh sách các lớp mà giáo viên đang giảng dạy
--giáo viên đang giảng dạy được tính theo tài khoản đăng nhập
--Ví dụ: giáo viên đăng nhập với tài khoản là 1 thì chỉ load các lớp do giáo viên có mã 1 thôi
--Chỉ load những lớp có trạng thái daketthuc = 0 <-> các lớp đang giảng dạy
-- dữ liệu được load trong tblLopHoc
select * from tblLopHoc;
-- như chúng ta thấy, thông tin được lưu dưới dạng mã giáo viên, mã lớp học, mã môn học, ...
--=> muốn lấy dữ liệu tường minh: tên môn học, số tín chỉ, sĩ số thì cần join các bảng khác
-- như csdl của chúng ta, tblLopHoc có liên kết khóa ngoại với các bảng tblDiem,tblMonHoc, tblGiaoVien

--ví dụ: lấy các lớp đang giảng dạy của giáo viên có mã giáo viên là 1
--update lại chút nhé: update tbllophoc set daketthuc = 0
-- => có 2 lớp của giáo viên có mã 2 nhé
select 
	l.malophoc,
	l.mamonhoc,
	m.tenmonhoc,
	m.sotinchi
from tblLopHoc l
inner join tblMonHoc m on l.mamonhoc = m.mamonhoc
where daketthuc = 0
and magiaovien = 1
-- ngang đây chúng ta đã lấy được các thông tin như mã lớp học, mã môn học, tên môn học, số tín chỉ
-- muốn lấy sĩ số thì hơi phức tạp chút.
-- các bạn chịu khó theo dõi nhé
-- đây gọi là phương pháp lồng select hay bảng tạm 
select * from
(
	select 
		l.malophoc,
		l.mamonhoc,
		m.tenmonhoc,
		m.sotinchi
	from tblLopHoc l
	inner join tblMonHoc m on l.mamonhoc = m.mamonhoc
	where daketthuc = 0
	and magiaovien = 1
) as tb inner join tblDiem d on d.malophoc = tb.malophoc

-- để tính được sĩ số, ta dùng hàm count
-- khi dùng hàm count chúng ta phải thêm từ khóa group by các dữ liệu lấy

create proc tracuulop
	@magiaovien int,
	@tukhoa nvarchar(50)
as
begin
	set @tukhoa = lower(@tukhoa);--cho toàn bộ kí tự trở thành lowercase/viết thường
	select 
		tb.malophoc,
		tb.mamonhoc,
		tb.tenmonhoc,
		tb.sotinchi,
		count(d.masinhvien) as siso
	from
	(
		select 
			l.malophoc,
			l.mamonhoc,
			m.tenmonhoc,
			m.sotinchi
		from tblLopHoc l
		inner join tblMonHoc m on l.mamonhoc = m.mamonhoc
		where daketthuc = 0
		and magiaovien = @magiaovien
		and lower(m.tenmonhoc) like '%'+@tukhoa+'%' -- tìm kiếm tương đối <--> có chứa từ khóa 
	) as tb inner join tblDiem d on d.malophoc = tb.malophoc
	group by tb.malophoc,tb.mamonhoc,tb.tenmonhoc,
		tb.sotinchi;
end


--test procedure nhé
exec tracuulop '4',''
	-- kiểm tra xem câu sql chuẩn chưa nhé
	-- như kết quả ở trên, ta có giáo viên mã 1 hiện đang giảng dạy 2 lớp có mã là 1(3 sinh viên) và 4(1 sinh viên).
	--
	select * from tblDiem where malophoc = 1;
	select * from tblDiem where malophoc = 4;
	-- chuẩn rồi nhé
	-- giờ chúng ta cần thêm bớt 1 chút để thành procedure
	--tham số truyền vào là mã giáo viên
	-- và 1 từ khóa để lọc dữ liệu khi tìm kiếm theo tên môn học là được roài
	--đã xong phần stored procedure 
	-- giờ việc còn lại là đổ dữ liệu lên form