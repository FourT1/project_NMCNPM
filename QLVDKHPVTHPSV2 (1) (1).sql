CREATE DATABASE QLVDKMHVTHPSV
USE QLVDKMHVTHPSV

CREATE TABLE Khoa
(
	MaKhoa varchar(100) PRIMARY KEY,
	TenKhoa varchar(100),
)

CREATE TABLE Nganh
(
	MaNganh varchar(100) PRIMARY KEY,
	TenNganh varchar(100),
	MaKhoa varchar(100) REFERENCES Khoa(MaKhoa),
)
CREATE TABLE DoiTuong
(
	MaDoiTuong varchar(100) PRIMARY KEY,
	TenDoiTuong varchar(100),
	TyLeGiam int,
)
CREATE TABLE Huyen
(
	MaHuyen varchar(100) PRIMARY KEY,
	TenHuyen varchar(100),
)
CREATE TABLE Tinh
(
	MaTinh varchar(100) PRIMARY KEY,
	TenTinh varchar(100),
)
CREATE TABLE DiaPhuong
(
	MaDiaPhuong varchar(100) PRIMARY KEY,
	VungXauVungXa bit, 
	MaTinh varchar(100) REFERENCES Tinh(MaTinh),
	MaHuyen varchar(100) REFERENCES Huyen(MaHuyen),
)
CREATE TABLE SinhVien
(
	MaSV varchar(100) PRIMARY KEY,
	HoTen varchar(100),
	NgaySinh smalldatetime,
	GioiTinh varchar(100),
	MaDiaPhuong varchar(100) REFERENCES DiaPhuong(MaDiaPhuong),
	MaNganh varchar(100) REFERENCES Nganh(MaNganh),
	MaKhoa varchar(100) REFERENCES Khoa(MaKhoa),
	MaDoiTuong varchar(100) REFERENCES DoiTuong(MaDoiTuong),
)
CREATE TABLE LoaiMon
(
	MaLoaiMon varchar(100) PRIMARY KEY,
	TenLoaiMon varchar(100),
	HocPhiMon money,
)
CREATE TABLE MonHoc
(
	MaMonHoc varchar(100) PRIMARY KEY,
	TenMonHoc varchar(100),
	SoTiet int,
	SoTinChi int,
	MaLoaiMon varchar(100)  REFERENCES LoaiMon(MaLoaiMon),
)
CREATE TABLE CTHoc
(
	MaCTH varchar(100) PRIMARY KEY,
	MaNganh varchar(100) REFERENCES Nganh(MaNganh),
	MaKhoa varchar(100) REFERENCES Khoa(MaKhoa),
)
CREATE TABLE CT_CTHoc
(
	MaCT_CTHoc varchar(100) PRIMARY KEY,
	HocKy int,
	MaMonHoc varchar(100) REFERENCES MonHoc(MaMonHoc),
	MaCTH varchar(100) REFERENCES CTHoc(MaCTH),
)
CREATE TABLE HocKyNH
(
	MaHKNH varchar(100) PRIMARY KEY,
	TenHKNH varchar(100),
)
CREATE TABLE MonHocMo
(
	MaDSMonHocMo varchar(100) PRIMARY KEY,
	MaHKNH varchar(100) REFERENCES HocKyNH(MaHKNH),
	MaMonHoc varchar(100) REFERENCES MonHoc(MaMonHoc),
	MaCT_CTHoc varchar(100)	REFERENCES CT_CTHoc(MaCT_CTHoc),
)
CREATE TABLE PhieuThu
(
	MaPhieuThu varchar(100) PRIMARY KEY,
	MaSV varchar(100) REFERENCES SinhVien(MaSV),
	TienThu money,
	NgayLapPhieuThu smalldatetime,
)
CREATE TABLE DKHP
(
	MaDKHP varchar(100) PRIMARY KEY,
	MaSV varchar(100) REFERENCES SinhVien(MaSV),
	NgayLap smalldatetime,
	HocKyDKHP int,
	MaHKNH varchar(100) REFERENCES HocKyNH(MaHKNH),
	HocPhiDKHP money,
)
CREATE TABLE CTDKHP
(	
	MaCTDKHP varchar(100) PRIMARY KEY,
	HocPhiMonHoc money,
	MaDKHP varchar(100) REFERENCES DKHP(MaDKHP),
)	
CREATE TABLE LichSuDongHP
(
	MaLSDongHP varchar(100) PRIMARY KEY,
	MaPhieuThu varchar(100) REFERENCES PhieuThu(MaPhieuThu),
	MaSV varchar(100) REFERENCES SinhVien(MaSV),
	SoTienDaDong money,
)
CREATE TABLE DSChuaDongHP
(
	MaDSChuaDongHP varchar(100) PRIMARY KEY,
	SoTienPhaiDong money,
	MaDKHP varchar(100) REFERENCES DKHP(MaDKHP),
	MaLSDongHP varchar(100) REFERENCES LichSuDongHP(MaLSDongHP),
	SoTienConLai money,
	MaSV varchar(100) REFERENCES SinhVien(MaSV),
)

