-- chúng ta tiến hành load dữ liệu và thông tin cột điểm ( cột lần 1 và lần 2 lên form)


select 
* 
from tblDiem

-- trong bảng này chỉ lưu mã sinh viên
-- chúng ta cần load thông tin tường minh họ và tên
-- như thiết kế csdl, ta có tblDiem kết nối khóa ngoại masinhvien trỏ tới tblSinhVien
--> để lấy thông tin họ và tên sinh viên ta cần join 2 bảng lại

-- chỉnh sửa khai báo lại thành procedure 

-- test proce nhé
dssv 5 --> OK
-- load dữ liệu lên form
-- chúng ta cần truyền thêm 1 tham số là từ khóa để tìm kiếm sinh viên nữa
--drop proc dssv
create proc dssv
	@malophoc bigint,
	@tukhoa nvarchar(50)
as
begin
	set @tukhoa = lower(@tukhoa); -- set lowercase <-> chữ thường hết
	select 
		d.masinhvien,
		case when len(s.tendem)>0 -- kiểm tra độ dài của tên đệm, nếu > 0 có nghĩa là có tên đệm
			then concat(s.ho,' ',s.tendem,' ',s.ten) -- nối họ + tên đệm + tên
			else concat(s.ho,' ',s.ten) -- nếu k có tên đệm thì nối họ + tên
		end as hoten,
		d.lanhoc,
		d.diemthilan1,
		d.diemthilan2
	from tblDiem d
	inner join tblSinhVien s on d.masinhvien = s.masinhvien
	where d.malophoc = @malophoc -- chỉ lấy danh sách lớp tương ứng với 1 mã lớp được truyền vào
	and (
			lower(concat(s.ho,' ',s.tendem,' ',s.ten)) like '%'+@tukhoa+'%'
			or lower(concat(s.ho,' ',s.ten)) like '%'+@tukhoa+'%'
		);
end

--update lại điểm 0 mặc định hết nhé
update tblDiem set diemthilan1 = 0, diemthilan2 = 0;