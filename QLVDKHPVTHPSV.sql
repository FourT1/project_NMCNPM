CREATE DATABASE DEMO1
USE DEMO1

CREATE TABLE Khoa
(
	MaKhoa varchar(100) PRIMARY KEY,
	TenKhoa varchar(100),
)

CREATE TABLE Nganh
(
	MaNganh varchar(100) PRIMARY KEY,
	TenNganh varchar(100),
	MaKhoa varchar(100),
	CONSTRAINT FK_Khoa_Nganh FOREIGN KEY (MaKhoa) REFERENCES Khoa(MaKhoa),
)
CREATE TABLE DoiTuong
(
	MaDoiTuong varchar(100) PRIMARY KEY,
	TenDoiTuong varchar(100),
	TyLeGiam int,
)

CREATE TABLE Tinh
(
	MaTinh varchar(100) PRIMARY KEY,
	TenTinh varchar(100),
)

CREATE TABLE Huyen
(
	MaHuyen varchar(100) PRIMARY KEY,
	TenHuyen varchar(100),
	MaTinh varchar(100) 
	CONSTRAINT FK_Tinh_Huyen FOREIGN KEY (MaTinh) REFERENCES Tinh(MaTinh), 
)

CREATE TABLE DiaPhuong
(
	MaDiaPhuong varchar(100) PRIMARY KEY,
	VungXauVungXa bit, 
	MaTinh varchar(100) 
	CONSTRAINT FK_Tinh_DiaPhuong FOREIGN KEY (MaTinh) REFERENCES Tinh(MaTinh),
	MaHuyen varchar(100),
	CONSTRAINT FK_Huyen_DiaPhuong FOREIGN KEY (MaHuyen) REFERENCES Huyen(MaHuyen),
)
CREATE TABLE SinhVien
(
	MaSV varchar(100) PRIMARY KEY,
	HoTen varchar(100),
	NgaySinh smalldatetime,
	GioiTinh varchar(100),
	MaDiaPhuong varchar(100),
	CONSTRAINT FK_DiaPhuong_SV FOREIGN KEY (MaDiaPhuong) REFERENCES DiaPhuong(MaDiaPhuong),
	MaNganh varchar(100),
	CONSTRAINT FK_Nganh_SV FOREIGN KEY (MaNganh) REFERENCES Nganh(MaNganh),
	MaKhoa varchar(100),
	CONSTRAINT FK_Khoa_SV FOREIGN KEY (MaKhoa) REFERENCES Khoa(MaKhoa),
	MaDoiTuong varchar(100),
	CONSTRAINT FK_DoiTuong_SV FOREIGN KEY (MaDoiTuong) REFERENCES DoiTuong(MaDoiTuong)
)
CREATE TABLE LoaiMon
(
	MaLoaiMon varchar(100) PRIMARY KEY,
	TenLoaiMon varchar(100),
)
CREATE TABLE MonHoc
(
	MaMonHoc varchar(100) PRIMARY KEY,
	TenMonHoc varchar(100),
	SoTiet int,
	SoTinChi int,
	MaLoaiMon varchar(100),
	CONSTRAINT FK_LoaiMon_MH FOREIGN KEY (MaLoaiMon) REFERENCES LoaiMon(MaLoaiMon),
	HocPhiMon money,
)
CREATE TABLE CTHoc
(
	MaCTH varchar(100) PRIMARY KEY,
	MaNganh varchar(100),
	CONSTRAINT FK_Nganh_CTHoc FOREIGN KEY (MaNganh) REFERENCES Nganh(MaNganh),
	MaKhoa varchar(100),
	CONSTRAINT FK_Khoa_CTHoc FOREIGN KEY (MaKhoa) REFERENCES Khoa(MaKhoa),
)
CREATE TABLE CT_CTHoc
(
	MaCT_CTHoc varchar(100) PRIMARY KEY,
	HocKy int,
	MaMonHoc varchar(100),
	CONSTRAINT FK_MonHoc_CTCTHoc FOREIGN KEY (MaMonHoc) REFERENCES MonHoc(MaMonHoc),
	MaCTH varchar(100),
	CONSTRAINT FK_CTH_CTCTHoc FOREIGN KEY (MaCTH) REFERENCES CTHoc(MaCTH),
)
CREATE TABLE HocKyNH
(
	MaHKNH varchar(100) PRIMARY KEY,
	TenHKNH varchar(100),
)
CREATE TABLE MonHocMo
(
	MaDSMonHocMo varchar(100) PRIMARY KEY,
	MaHKNH varchar(100)
	CONSTRAINT FK_HKNH_MonHocMo FOREIGN KEY (MaHKNH) REFERENCES HocKyNH(MaHKNH),
	NamHoc varchar(100),
	MaMonHoc varchar(100) REFERENCES MonHoc(MaMonHoc),
	CONSTRAINT FK_MonHoc_MonHocMo FOREIGN KEY (MaMonHoc) REFERENCES MonHoc(MaMonHoc),
	MaCT_CTHoc varchar(100),
	CONSTRAINT FK_CTCTHoc_MonHocMo FOREIGN KEY (MaCT_CTHoc) REFERENCES CT_CTHoc(MaCT_CTHoc)
)

CREATE TABLE DKHP
(
	MaDKHP varchar(100) PRIMARY KEY,
	MaSV varchar(100),
	CONSTRAINT FK_SinhVien_DKHP FOREIGN KEY (MaSV) REFERENCES SinhVien(MaSV),
	NgayLap smalldatetime,
	HocKyDKHP int,
	NamHoc varchar(100),
	MaHKNH varchar(100),
	CONSTRAINT FK_HKNH_DKHP FOREIGN KEY (MaHKNH) REFERENCES HocKyNH(MaHKNH),
	HocPhiDKHP money,
)
CREATE TABLE CTDKHP
(	
	MaCTDKHP varchar(100) PRIMARY KEY,
	MaDKHP varchar(100),
	CONSTRAINT FK_DKHP_CTDKHP FOREIGN KEY (MaDKHP) REFERENCES DKHP(MaDKHP),
	MaMH varchar(100),
	CONSTRAINT FK_MonHoc_CTDKHP FOREIGN KEY (MaMH) REFERENCES MonHoc(MaMonHoc),
	HocPhiMonHoc money,
)	
CREATE TABLE PhieuThu
(
	MaPhieuThu varchar(100) PRIMARY KEY,
	MaSV varchar(100),
	CONSTRAINT FK_SinhVien_PhieuThu FOREIGN KEY (MaSV) REFERENCES SinhVien(MaSV),
	TienThu money,
	NgayLapPhieuThu smalldatetime,
	MaDKHP varchar(100),
	CONSTRAINT FK_DKHP_PhieuThu FOREIGN KEY (MaDKHP) REFERENCES DKHP(MaDKHP)
)
CREATE TABLE LichSuDongHP
(
	MaLSDongHP varchar(100) PRIMARY KEY,
	MaPhieuThu varchar(100),
	CONSTRAINT FK_PhieuThu_LSDongHP FOREIGN KEY (MaPhieuThu) REFERENCES PhieuThu(MaPhieuThu),
	MaSV varchar(100),
	CONSTRAINT FK_SinhVien_LSDongHP FOREIGN KEY (MaSV) REFERENCES SinhVien(MaSV),
	SoTienDaDong money,
)

CREATE TABLE DSChuaDongHP
(
	MaDSChuaDongHP varchar(100) PRIMARY KEY,
	MaHKNH varchar(100),
	CONSTRAINT FK_HocKyNH_DSChuaDongHP FOREIGN KEY (MaHKNH) REFERENCES HocKyNH(MaHKNH),
	NamHoc varchar(4)
)


CREATE TABLE CT_DSChuaDongHP
(
	MaCTDSChuaDongHP varchar(100) PRIMARY KEY,
	MaDSChuaDongHP varchar(100),
	CONSTRAINT FK_DSChuaDongHP_CTDSChuaDongHP FOREIGN KEY (MaDSChuaDongHP) REFERENCES DSChuaDongHP(MaDSChuaDongHP),
	SoTienPhaiDong money,
	MaDKHP varchar(100),
	CONSTRAINT FK_DKHP_CTDSChuaDongHP FOREIGN KEY (MaDKHP) REFERENCES DKHP(MaDKHP),
	MaLSDongHP varchar(100),
	CONSTRAINT FK_LSDongHp_CTDSChuaDongHP FOREIGN KEY (MaLSDongHP) REFERENCES LichSuDongHP(MaLSDongHP),
	SoTienConLai money,
	MaSV varchar(100),
	CONSTRAINT FK_SinhVien_CTDSChuaDongHP FOREIGN KEY (MaSV) REFERENCES SinhVien(MaSV),
)

