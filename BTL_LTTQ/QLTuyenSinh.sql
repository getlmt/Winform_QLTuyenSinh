CREATE DATABASE QLTuyenSinh
USE QLTuyenSinh
CREATE TABLE HoSo (
    MaHoSo VARCHAR(10),
    HoTen NVARCHAR(100),
    GioiTinh NVARCHAR(10),
    NgaySinh DATE,
    SoDienThoai VARCHAR(15),
    DiaChi NVARCHAR(200),
    AnhHoSo NVARCHAR(255)
);
CREATE TABLE Diem (
    MaHoSo VARCHAR(10),
    DiemHocBaTrungBinh Float,
	DiemToan Float,
	DiemVan Float,
	DiemAnh Float,
	DiemLy Float,
	DiemHoa FLoat,
	DiemSinh FLoat,
	DiemSu Float,
	DiemDia Float,
	DiemGDCD FLOAT,
    HanhKiemCap3 NVARCHAR(50)
);
CREATE TABLE HoTro (
    MaHoSo VARCHAR(10),
    ThongTinYeuCau NVARCHAR(255),
    ThongTinHoTro NVARCHAR(255),
    HinhThucHoTro NVARCHAR(100)
);
CREATE TABLE ThanhToan (
    MaHoSo VARCHAR(10),
    SoTienThanhToan DECIMAL(10, 2),
    HinhThucThanhToan NVARCHAR(100),
    BienLai NVARCHAR(255)
);
CREATE TABLE XetTuyen (
    MaHoSo VARCHAR(10),
    MaNganh VARCHAR(10),
    DiemXetTuyen FLOAT,
	MaTruong NVARCHAR(255),
	TenTruong NVARCHAR(255),
	ToHopXetTuyen NVARCHAR(20),
	TTNV INT,
	TrungTuyen NVARCHAR(20)
);
CREATE TABLE Users (
    MaHoSo VARCHAR(10),
    Account NVARCHAR(50),
    Password NVARCHAR(255)
);
CREATE TABLE Nganh (
    MaNganh VARCHAR(10),
    MoTa NVARCHAR(255),
	TenNganh NVARCHAR(255)
);
CREATE TABLE DanhSachTrungTuyen (
    MaHoSo VARCHAR(10),
    MaNganh VARCHAR(10),
    DiemXetTuyen FLOAT,
    TTNV INT,
	ThanhToan NVARCHAR(255)
);
CREATE TABLE ChiTieuConLai (
    MaNganh VARCHAR(10),
    ChiTieuCon INT
);
