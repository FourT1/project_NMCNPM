--tạo hàm đăng ký môn học
--ý tưởng:
	-- dữ liệu trong bảng tblLopHoc được tạo bởi admin
	-- khi sinh viên đăng ký môn học <-> insert dữ liệu vào bảng điểm với 2 khóa ngoại:
		--> mã sinh viên
		--> mã lớp học
		--> điểm thi lần 1 và lần 2 sẽ tự động sinh là 0 điểm
	-- lần học sẽ tự động được tính: nếu sinh viên chưa đăng ký môn học A lần nào thì tương ứng sẽ là 1
	-- nếu sinh viên đã đăng ký môn học A và lớp có trạng thái daketthuc là 0 thì sẽ không được đăng ký môn A nữa
	-- ngược lại ( đã học <-> trạng thái daketthuc = 1 ) thì số lần học sẽ bằng số lần học trước đó + 1
	create proc dkyhoc
		@masinhvien varchar(50),
		@malophoc bigint
	as
	begin
		--vì bảng điểm(tblDiem) chỉ có cột mã lớp học (khóa ngoại) liên kết tới bảng  lớp học(tblLopHoc) <-> không có thông tin môn học
		--> từ mã lớp cần tìm ra được mã môn học ( nằm trong tblLopHoc) dựa vào inner join --> khai báo 1 biến để lấy thông tin môn học, cụ thể là mã môn học
		--vì số lần học được tính tự động -> cần khai báo 1 biến để đếm số lần học trước đó
		declare @v_lanhoc int,
				@v_mamonhoc int,
				@v_dadangky int;
		-- lấy mã môn học dựa vào mã lớp
		select @v_mamonhoc = mamonhoc
		from tblLopHoc
		where malophoc = @malophoc;

		-- từ mã môn học + mã sinh viên => tính được số lần học trước đó
		select @v_lanhoc = count(*)
		from tblDiem d
		inner join tblLopHoc l on d.malophoc = l.malophoc
		where l.daketthuc = 1 --> chỉ tính số lần học từ các lớp có trạng thái đã kết thúc
		and d.masinhvien = @masinhvien
		and l.mamonhoc = @v_mamonhoc;

		-- kiểm tra xem sinh viên này hiện có đăng ký lớp khác học cùng 1 môn hay không
		select @v_dadangky = count(*)
		from tblDiem d
		inner join tblLopHoc l on d.malophoc = l.malophoc
		where l.daketthuc = 0 --> lớp đang mở
		and l.mamonhoc = @v_mamonhoc --> môn học này đã đăng ký
		and d.masinhvien = @masinhvien; --> sinh viên xác định

		--> nếu kết quả trả về v_dadangky > 0 --> có nghĩa hiện tại sinh viên này đã đăng ký 1 lớp học cùng môn học này rồi
		if @v_dadangky>0 return -1;

		--lần học mới sẽ bằng số lần học trước đó + 1
		set @v_lanhoc = @v_lanhoc + 1;

		--> hơi rối chút, các bạn chịu khó đọc kỹ nhé. Đoạn nào chưa hiểu cứ dừng(hoặc tua) video lại mà ngâm

		--> insert dữ liệu vào bảng điểm <-> đăng ký môn học
		insert into tblDiem(nguoitao,masinhvien,malophoc,lanhoc)
		values(@masinhvien,@masinhvien,@malophoc,@v_lanhoc);--sinh viên đăng ký -> người tạo = mã sinh viên

		--kiểm tra thực thi câu lệnh sql
		if @@ROWCOUNT > 0 return 1 else return 0;
	end

	--> test dữ liệu nhé
	select * from tblLopHoc;

	-- vì database mình mới tạo lại ( bị thất lạc ) nên dữ liệu có đôi chút khác hôm trước
	select * from tblMonHoc;
	-- các trường ngaytao,nguoitao,ngaycapnhat,nguoicapnhat,malophoc, daketthuc đã thiết lập mặc định rồi
	--> nên mình sẽ không chèn vào các câu lệnh phía dưới

	insert into tblLopHoc(mamonhoc,magiaovien) values(1,1);
	insert into tblLopHoc(mamonhoc,magiaovien) values(1,2);
	insert into tblLopHoc(mamonhoc,magiaovien) values(1,3);
	insert into tblLopHoc(mamonhoc,magiaovien) values(2,1);
	insert into tblLopHoc(mamonhoc,magiaovien) values(2,2);
	insert into tblLopHoc(mamonhoc,magiaovien) values(2,3);

	--giờ test procedure dkyhoc đã viết ở trên nhé
	select * from tblSinhVien;
	exec dkyhoc 'SV1100',2; -->kiểm tra thử đăng ký trùng xem nhé
	exec dkyhoc 'SV1101',1;
	exec dkyhoc 'SV1102',1;

	select * from tblDiem
	-- mình quên chưa thiết lập mặc định lần học
	drop proc dkyhoc

	delete from tblDiem;

	--> ok rồi nhé ^_^
	--phần xử lý code C# sẽ được trình bày clip sau
	--nội dung phần này hơi rối, mong các bạn đọc kỹ