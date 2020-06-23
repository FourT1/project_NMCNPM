select * from tblGiaoVien

insert into tblGiaoVien(ho,tendem,ten,gioitinh,ngaysinh,dienthoai,email,diachi) values(N'Trần',N'Như',N'Cát',1,'1987-01-01','01245555125255','nhucat@gmail.com',N'Địa chỉ của thầy như cát');
insert into tblGiaoVien(ho,tendem,ten,gioitinh,ngaysinh,dienthoai,email,diachi) values(N'Bùi',N'Văn',N'Hiếu',1,'1984-01-01','0955448888','buivanhieu@gmail.com',N'Địa chỉ của thầy bùi văn hiếu');
insert into tblGiaoVien(ho,tendem,ten,gioitinh,ngaysinh,dienthoai,email,diachi) values(N'Nguyễn',N'Thị Hải',N'Yến',0,'1977-12-11','09845545888','nguyenthihaiyen@gmail.com',N'Địa chỉ của cô hải yến');
insert into tblGiaoVien(ho,tendem,ten,gioitinh,ngaysinh,dienthoai,email,diachi) values(N'Đoàn',N'Thị',N'Nhi',0,'1987-10-20','09113388777','quynhnhi@gmail.com',N'Địa chỉ của cô Nhi');
insert into tblGiaoVien(ho,tendem,ten,gioitinh,ngaysinh,dienthoai,email,diachi) values(N'Trương',N'Bá',N'Quan',1,'1968-11-25','098155','baquantruong@gmail.com',N'Địa chỉ của thầy bá quan');

select * from tblMonHoc;

insert into tblMonHoc(tenmonhoc,sotinchi) values(N'Tin học đại cương',2);
insert into tblMonHoc(tenmonhoc,sotinchi) values(N'Toán cao cấp I',2);
insert into tblMonHoc(tenmonhoc,sotinchi) values(N'Phân tích thiết kế CSDL',2);
insert into tblMonHoc(tenmonhoc,sotinchi) values(N'Mã nguồn mở',2);
insert into tblMonHoc(tenmonhoc,sotinchi) values(N'Thiết kế web bằng ASP.NET',4);
insert into tblMonHoc(tenmonhoc,sotinchi) values(N'An toàn thông tin',3);
insert into tblMonHoc(tenmonhoc,sotinchi) values(N'Lập trình WPF',4);
insert into tblMonHoc(tenmonhoc,sotinchi) values(N'Lập trình website bằng mô hình MVC',3);

create sequence sinhvienSeq start with 1100 increment by 1;

select * from tblSinhVien;
insert into tblSinhVien(masinhvien,ho,tendem,ten,ngaysinh,gioitinh,diachi,dienthoai,email)
values(
	'SV'+cast(next value for sinhvienSeq as varchar(30)),
	N'Dương',N'',N'Quá',
	'2001-01-01',1,
	N'Cổ mộ cùng Cô cô',
	'0988554887','quaquecungchymcut@gmail.com'	
	);


	insert into tblSinhVien(masinhvien,ho,tendem,ten,ngaysinh,gioitinh,diachi,dienthoai,email)
values(
	'SV'+cast(next value for sinhvienSeq as varchar(30)),
	N'Tiểu',N'Long',N'Nữ',
	'1999-12-31',0,
	N'Đi phượt cùng Triệu Chí Kính',
	'09888848484','cococungchikinh@gmail.com'	
	);


insert into tblSinhVien(masinhvien,ho,tendem,ten,ngaysinh,gioitinh,diachi,dienthoai,email)
values(
	'SV'+cast(next value for sinhvienSeq as varchar(30)),
	N'Triệu',N'Chí',N'Kính',
	'1995-10-10',1,
	N'Đạo trưởng đẹp troai',
	'0888458487778','chikinhdeptroai@gmail.com'	
	);


insert into tblSinhVien(masinhvien,ho,tendem,ten,ngaysinh,gioitinh,diachi,dienthoai,email)
values(
	'SV'+cast(next value for sinhvienSeq as varchar(30)),
	N'Chu',N'Bá',N'Thông',
	'1000-01-01',1,
	N'Ngây thơ vô số tội',
	'01215454888','chubathong@gmail.com'	
	);


insert into tblSinhVien(masinhvien,ho,tendem,ten,ngaysinh,gioitinh,diachi,dienthoai,email)
values(
	'SV'+cast(next value for sinhvienSeq as varchar(30)),
	N'Quách',N'',N'Tĩnh',
	'1990-01-31',1,
	N'anh tĩnh bắn chym',
	'245848221555','thosantrym@gmail.com'	
	);


insert into tblSinhVien(masinhvien,ho,tendem,ten,ngaysinh,gioitinh,diachi,dienthoai,email)
values(
	'SV'+cast(next value for sinhvienSeq as varchar(30)),
	N'Hoàng',N'',N'Dung',
	'1999-05-25',0,
	N'Bang chủ Cái bang',
	'0554878788','bangchucaibang@gmail.com'	
	);


insert into tblSinhVien(masinhvien,ho,tendem,ten,ngaysinh,gioitinh,diachi,dienthoai,email)
values(
	'SV'+cast(next value for sinhvienSeq as varchar(30)),
	N'Quách',N'',N'Tương',
	'2002-01-18',0,
	N'Tiểu Đông tà - tổ lập Nga my',
	'8788441122','tieudongta@ngamy.com'	
	);



	select * from taikhoan;
	insert into taikhoan values('admin','admin');