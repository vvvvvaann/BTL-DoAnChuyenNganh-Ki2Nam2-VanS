USE master
GO
CREATE DATABASE BTL_Nhom4_QuanLyBanQuanAo
GO
USE BTL_Nhom4_QuanLyBanQuanAo
GO
CREATE TABLE NhanVien
(
	MaNhanVien CHAR(10) PRIMARY KEY,
	TenNhanVien VARCHAR(20),
	SoDienThoai CHAR(10) UNIQUE,
	NamSinh INT,
	GioiTinh CHAR(10),
	DiaChi VARCHAR(20),
	MaChucVu CHAR(10),
	MatKhau VARCHAR(20) DEFAULT '123'
)

CREATE TABLE ChucVu
(
	MaChucVu CHAR(10) PRIMARY KEY,
	TenChucVu VARCHAR(20)
)

CREATE TABLE KhachHang
(
	MaKhachHang INT IDENTITY(1, 1) PRIMARY KEY,
	TenKhachHang VARCHAR(20),
	SoDienThoai CHAR(10) UNIQUE
)

CREATE TABLE GioiTinh
(
	GioiTinh CHAR(10) PRIMARY KEY
)

CREATE TABLE HangHoa
(
	MaHangHoa CHAR(10),
	KichThuoc INT,
	GiaNhap FLOAT,
	TenHangHoa VARCHAR(20),
	MaLoaiHangHoa CHAR(10),
	GiaBan FLOAT,
	SoLuong INT,
	GhiChu VARCHAR(50),
	PRIMARY KEY (MaHangHoa, KichThuoc, GiaNhap)
)

CREATE TABLE LoaiHangHoa
(
	MaLoaiHangHoa CHAR(10) PRIMARY KEY,
	TenLoaiHangHoa VARCHAR(20)
)

CREATE TABLE KichThuoc
(
	KichThuoc INT PRIMARY KEY
)

CREATE TABLE GiaoDich
(
	MaGiaoDich INT IDENTITY(1, 1) PRIMARY KEY,
	SoTien FLOAT,
	NoiDung VARCHAR(50)
)

CREATE TABLE HoaDon
(
	MaHoaDon INT IDENTITY(1, 1) PRIMARY KEY,
	MaGiaoDich INT,
	MaKhachHang INT,
	MaNhanVien CHAR(10),
	ThoiGian DATE
)

CREATE TABLE ChiTietHoaDon
(
	MaChiTietHoaDon INT,
	MaHoaDon INT,
	MaHangHoa CHAR(10),
	KichThuoc INT,
	GiaBan FLOAT,
	SoLuong INT,
	ThanhTien FLOAT,
	PRIMARY KEY (MaChiTietHoaDon, MaHoaDon)
)

CREATE TABLE DoanhSo
(
	MaGiaoDich INT PRIMARY KEY,
	VonBanDau FLOAT,
	VonHienTai FLOAT,
	DoanhSo FLOAT
)

CREATE TABLE LuongNhanVien
(
	MaNhanVien CHAR(10),
	ThoiGian DATE,
	MaGiaoDich INT,
	LuongCoBan FLOAT,
	DoanhSo FLOAT,
	TongLuong FLOAT,
	PRIMARY KEY (MaNhanVien, ThoiGian)
)

ALTER TABLE NhanVien ADD FOREIGN KEY (MaChucVu) REFERENCES ChucVu(MaChucVu)
GO
ALTER TABLE NhanVien ADD FOREIGN KEY (GioiTinh) REFERENCES GioiTinh(GioiTinh)
GO
ALTER TABLE HangHoa ADD FOREIGN KEY (MaLoaiHangHoa) REFERENCES LoaiHangHoa(MaLoaiHangHoa)
GO
ALTER TABLE HangHoa ADD FOREIGN KEY (KichThuoc) REFERENCES KichThuoc(KichThuoc)
GO 
ALTER TABLE HoaDon ADD FOREIGN KEY (MaGiaoDich) REFERENCES GiaoDich(MaGiaoDich)
GO      
ALTER TABLE HoaDon ADD FOREIGN KEY (MaKhachHang) REFERENCES KhachHang(MaKhachHang)
GO
ALTER TABLE HoaDon ADD FOREIGN KEY (MaNhanVien) REFERENCES NhanVien(MaNhanVien)
GO
ALTER TABLE ChiTietHoaDon ADD FOREIGN KEY (MaHoaDon) REFERENCES HoaDon(MaHoaDon)
GO
ALTER TABLE LuongNhanVien ADD FOREIGN KEY (MaGiaoDich) REFERENCES GiaoDich(MaGiaoDich)
GO
ALTER TABLE DoanhSo ADD FOREIGN KEY (MaGiaoDich) REFERENCES GiaoDich(MaGiaoDich)

GO
INSERT INTO GioiTinh
VALUES
	('Nam'),
	('Nu');
GO
INSERT INTO ChucVu
VALUES
	('ADMIN', 'Admin'),
	('NV', 'Nhan vien');
GO
INSERT INTO KichThuoc
VALUES
	('36'),
	('37'),
	('38'),
	('39'),
	('40'),
	('41'),
	('42');
GO
INSERT INTO LoaiHangHoa
VALUES
	('Q', 'Quan'),
	('A', 'Ao');
GO
INSERT INTO NhanVien (MaNhanVien, TenNhanVien, SoDienThoai, NamSinh, GioiTinh, DiaChi, MaChucVu)
VALUES
	('admin', 'admin', '0123456789', '2001', 'Nam', 'Thanh Hoa', 'ADMIN'),
	('NV001', 'Van', '0123456788', '2001', 'Nam', 'Thanh Hoa', 'NV'),
	('NV002', 'Thuong', '0123456787', '2002', 'Nam', 'Hoa Binh', 'NV');
GO
INSERT INTO GiaoDich (SoTien, NoiDung) 
VALUES
	('100000000', 'them von ban dau');
GO
INSERT INTO DoanhSo(MaGiaoDich, VonBanDau, VonHienTai, DoanhSo) 
VALUES
	('1', '100000000', '100000000', '0');
GO
INSERT INTO HangHoa
VALUES
	('A001', '40', '150000', 'Ao polo nam', 'A', '450000', '15', 'Ao polo nam size 40'),
	('A001', '41', '150000', 'Ao polo nam', 'A', '450000', '20', 'Ao polo nam size 41'),
	('A001', '42', '150000', 'Ao polo nam', 'A', '450000', '10', 'Ao polo nam size 42'),
	('A002', '40', '200000', 'Ao somi nam', 'A', '600000', '20', 'Ao somi nam size 40'),
	('A002', '41', '200000', 'Ao somi nam', 'A', '600000', '5', 'Ao somi nam size 41'),
	('A002', '42', '200000', 'Ao somi nam', 'A', '600000', '20', 'Ao somi nam size 42'),
	('Q001', '40', '200000', 'Quan au nam', 'Q', '600000', '15', 'Quan au nam size 40'),
	('Q001', '41', '200000', 'Quan au nam', 'Q', '600000', '20', 'Quan au nam size 41'),
	('Q001', '42', '200000', 'Quan au nam', 'Q', '600000', '10', 'Quan au nam size 42'),
	('Q002', '40', '100000', 'Quan short nam', 'Q', '300000', '20', 'Quan short nam size 40'),
	('Q002', '41', '100000', 'Quan short nam', 'Q', '300000', '5', 'Quan short nam size 41'),
	('Q002', '42', '100000', 'Quan short nam', 'Q', '300000', '20', 'Quan short nam size 42');
GO
INSERT GiaoDich
VALUES
	('3000000', 'Nhap hang'),
	('3000000', 'Nhap hang'),
	('3000000', 'Nhap hang'),
	('4000000', 'Nhap hang'),
	('4000000', 'Nhap hang'),
	('4000000', 'Nhap hang'),
	('4000000', 'Nhap hang'),
	('4000000', 'Nhap hang'),
	('4000000', 'Nhap hang'),
	('2000000', 'Nhap hang'),
	('2000000', 'Nhap hang'),
	('2000000', 'Nhap hang'),
	('5250000', 'Ban hang'),
	('3600000', 'Ban hang'),
	('5250000', 'Ban hang'),
	('5400000', 'Ban hang'),
	('5250000', 'Ban hang'),
	('4500000', 'Ban hang'),
	('885000', 'Thanh toan luong nhan vien'),
	('7065000', 'Thanh toan luong nhan vien'),
	('6975000', 'Thanh toan luong nhan vien');
GO
INSERT KhachHang
VALUES
	('Nguyen Van A', '0123456001'),
	('Nguyen Van B', '0123456002'),
	('Nguyen Van C', '0123456003'),
	('Nguyen Van D', '0123456004'),
	('Nguyen Van E', '0123456005'),
	('Nguyen Van F', '0123456006');
GO
INSERT HoaDon
VALUES
	('14', '1', 'ADMIN', '06/29/2022'),
	('15', '2', 'ADMIN', '06/29/2022'),
	('16', '3', 'NV001', '06/29/2022'),
	('17', '4', 'NV001', '06/29/2022'),
	('18', '5', 'NV002', '06/29/2022'),
	('19', '6', 'NV002', '06/29/2022');
GO
INSERT ChiTietHoaDon
VALUES
	('1', '1', 'A001', '40', '450000', '5', '2250000'),
	('1', '2', 'A002', '41', '600000', '4', '2400000'),
	('1', '3', 'A001', '42', '450000', '5', '2250000'),
	('1', '4', 'A002', '41', '600000', '6', '3600000'),
	('1', '5', 'A001', '42', '450000', '5', '2250000'),
	('1', '6', 'A002', '41', '600000', '5', '3000000'),
	('2', '1', 'Q001', '40', '600000', '5', '3000000'),
	('2', '2', 'Q002', '41', '300000', '4', '1200000'),
	('2', '3', 'Q001', '42', '600000', '5', '3000000'),
	('2', '4', 'Q002', '41', '300000', '6', '1800000'),
	('2', '5', 'Q001', '42', '600000', '5', '3000000'),
	('2', '6', 'Q002', '41', '300000', '5', '1500000');
GO
INSERT LuongNhanVien
VALUES
	('admin', '06/29/2022', '20', '0', '8850000', '885000'),
	('NV001', '06/29/2022', '21', '6000000', '10650000', '7065000'),
	('NV002', '06/29/2022', '22', '6000000', '9750000', '6975000');
GO
INSERT DoanhSo
VALUES
	('2', '100000000', '97000000', '-3000000'),
	('3', '100000000', '94000000', '-6000000'),
	('4', '100000000', '91000000', '-9000000'),
	('5', '100000000', '87000000', '-13000000'),
	('6', '100000000', '83000000', '-17000000'),
	('7', '100000000', '79000000', '-21000000'),
	('8', '100000000', '75000000', '-25000000'),
	('9', '100000000', '71000000', '-29000000'),
	('10', '100000000', '67000000', '-33000000'),
	('11', '100000000', '65000000', '-35000000'),
	('12', '100000000', '63000000', '-37000000'),
	('13', '100000000', '61000000', '-39000000'),
	('14', '100000000', '66250000', '-33750000'),
	('15', '100000000', '69850000', '-30150000'),
	('16', '100000000', '75100000', '-24900000'),
	('17', '100000000', '80500000', '-19500000'),
	('18', '100000000', '85750000', '-14250000'),
	('19', '100000000', '90250000', '-9750000'),
	('20', '100000000', '89365000', '-10635000'),
	('21', '100000000', '82300000', '-17700000'),
	('22', '100000000', '75325000', '-24675000');

--select * from NhanVien
--select * from KhachHang
--select * from GiaoDich
--select * from DoanhSo
--select * from HoaDon
--select * from ChiTietHoaDon
--select * from HangHoa
--select * from LuongNhanVien
--Thu tu INSERT : nhanvien hanghoa giaodich khachhang hoadon chitiethoadon luongnhanvien doanhso;

