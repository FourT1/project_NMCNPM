-- chúng ta sẽ viết procedure chấm điểm sinh viên
-- với 5 tham số truyền vào là: mã lớp,mã sinh viên, điểm lần 1 và điểm lần 2
-- trả lời cho câu hỏi: ai chấm, chấm điểm cho ai, lớp nào, điểm lần 1, lần 2 là bao nhiêu???
-- select * from tblDiem
-- vì khi sinh viên đăng ký môn học -> dữ liệu đã được insert trước đó ( các part trước đã hướng dẫn: part 15 và part 18)
-- nên thao tác chấm điểm của giáo viên chỉ là update lại 2 cột điểm lần 1 và điểm lần 2

create proc chamdiem
	@magiaovien varchar(10), -- ai chấm <-> nguoif cập nhật trong bảng
	@malop bigint, -- lớp nào
	@masinhvien varchar(30),-- chấm cho ai
	@diemlan1 float,--điểm lần 1 là bnhiu
	@diemlan2 float--điểm lần 2 là bao nhiu
as
begin
	update tblDiem
	set
		ngaycapnhat = getdate(),--getdate() là hàm lấy giờ hiện tại của hệ thống
		nguoicapnhat = @magiaovien,
		masinhvien = @masinhvien,
		diemthilan1 = @diemlan1,
		diemthilan2 = @diemlan2
	where malophoc = @malop;
end

