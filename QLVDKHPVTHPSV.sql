CREATE DATABASE QLVDKHPVTHPSV
USE QLVDKHPVTHPSV
CREATE TABLE DIAPHUONG
(
	MaHuyen varchar(2),
	MaTinh varchar(2),
	TenHuyen varchar(50),
	TenTinh varchar(50),
	VungSau bit,
	PRIMARY KEY (MaHuyen, MaTinh)	
);

CREATE TABLE KHOA
(
	MaKhoa varchar(8) PRIMARY KEY,
	TenKhoa varchar(50),
)

CREATE TABLE NGANH
(
	MaNganh varchar(8) PRIMARY KEY,
	TenNganh varchar(50),
	MaKhoa varchar(8)
	CONSTRAINT FK_Khoa_Nganh FOREIGN KEY (MaKhoa) REFERENCES Khoa(MaKhoa),
)



CREATE TABLE DOITUONG
(
	MaDoiTuong varchar(2) PRIMARY KEY,
	TenDoiTuong varchar(50),
	TyLeGiam decimal(3, 2),
)

CREATE TABLE SinhVien
(
	MaSV varchar(8) PRIMARY KEY,
	HoTen varchar(50),
	NgaySinh smalldatetime,
	GioiTinh bit,
	MaHuyen varchar(2),
	MaTinh varchar(2),
	CONSTRAINT FK_DiaPhuong_SV FOREIGN KEY (MaHuyen,MaTinh) REFERENCES DiaPhuong(MaHuyen,MaTinh),
	MaNganh varchar(8),
	CONSTRAINT FK_Nganh_SV FOREIGN KEY (MaNganh) REFERENCES Nganh(MaNganh),
	MaDoiTuong varchar(2),
	CONSTRAINT FK_DoiTuong_SV FOREIGN KEY (MaDoiTuong) REFERENCES DoiTuong(MaDoiTuong)
)

CREATE TABLE MONHOC
(
	MaMH varchar(5) PRIMARY KEY,
	TenMH varchar(50),
	LoaiMon varchar(2), --LT hoặc TH
	SoTiet tinyint,
	SoTC tinyint
)

CREATE TABLE CTHOC
(
	MaCTH varchar(4) PRIMARY KEY,
	MaNganh varchar(8),
	MaKhoa varchar(8),
	CONSTRAINT FK_Nganh_CTHoc FOREIGN KEY (MaNganh) REFERENCES Nganh(MaNganh),
	CONSTRAINT FK_Khoa_CTHoc FOREIGN KEY (MaKhoa) REFERENCES Khoa(MaKhoa),
)

CREATE TABLE CT_CTHOC
(
	MaCTH varchar(4),
	MaMH varchar(5),
	HocKy tinyint,
	GhiChu varchar(50),
	PRIMARY KEY (MaCTH, MaMH),
	CONSTRAINT FK_MaCTH FOREIGN KEY (MaCTH) REFERENCES CTHOC(MaCTH),
	CONSTRAINT FK_MaMH FOREIGN KEY (MaMH) REFERENCES MONHOC(MaMH),
)

CREATE TABLE DS_MONHOCMO
(
	MaDSMHM varchar(4) PRIMARY KEY,
	HocKy tinyint,
	NamHoc varchar(4),
)

CREATE TABLE CT_MONHOCMO
(
	MaCTH varchar(4),
	MaDSMHM varchar(4),
	PRIMARY KEY (MaCTH, MaDSMHM),
	CONSTRAINT FK_MaCTH_MHM FOREIGN KEY (MaCTH) REFERENCES CTHOC(MaCTH),
	CONSTRAINT FK_MaDSMHM FOREIGN KEY (MaDSMHM) REFERENCES DS_MONHOCMO(MaDSMHM),
)

CREATE TABLE DKHP
(
	MaDKHP varchar(4) PRIMARY KEY,
	MaSV varchar(8),
	NgayLap smalldatetime,
	HocKy tinyint,
	NamHoc varchar(4),
	CONSTRAINT FK_MaSV FOREIGN KEY (MaSV) REFERENCES SINHVIEN(MaSV),
)

CREATE TABLE CT_DKHP
(
	MaCT_DKHP varchar(4) PRIMARY KEY,
	MaDKHP varchar(4),
	MaMH varchar(5),
	CONSTRAINT FK_DKHP_MaMH FOREIGN KEY (MaMH) REFERENCES MONHOC(MaMH),
)

CREATE TABLE PHIEUTHU_HP
(
	MaPhieu varchar(4) PRIMARY KEY,
	MaDKHP varchar(4),
	MaSV varchar(8),
	NgayLap smalldatetime,
	SoTienThu money,
	CONSTRAINT FK_PhieuThu_DKHP FOREIGN KEY (MaDKHP) REFERENCES DKHP(MaDKHP),
	CONSTRAINT FK_PhieuThu_SV FOREIGN KEY (MaSV) REFERENCES SINHVIEN(MaSV),
)

CREATE TABLE DS_CHUADONGHP
(
	MaDS varchar(4) PRIMARY KEY,
	HocKy tinyint,
	NamHoc varchar(4),
)

CREATE TABLE CT_DS_CHUADONGHP
(
	MaCT varchar(4) PRIMARY KEY,
	MaDS varchar(4),
	MaSV varchar(8),
	SoTienDK money,
	SoTienDaDong money,
	SoTienConLai money,
	CONSTRAINT FK_DS FOREIGN KEY (MaDS) REFERENCES DS_CHUADONGHP(MaDS),
	CONSTRAINT FK_MaSV_DS FOREIGN KEY (MaSV) REFERENCES SINHVIEN(MaSV),
)
