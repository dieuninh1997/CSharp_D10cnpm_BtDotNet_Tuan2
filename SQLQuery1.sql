---create tables---
/*
Do btvn chủ yếu về báo cáo thống kê
nên chỉ cần tạo vài bảng cơ bản của quản lý bán hàng
KhachHang
LoaiHang
NhaCungCap
SanPham
NhapHang
HoaDon
ChiTietNhapHang
ChiTietHoaDon

*/


create table tb_SanPham
(
	IDSanPham NVARCHAR(50) PRIMARY KEY,
	TenSanPham NVARCHAR(50) NULL,
	GiaVon FLOAT NULL DEFAULT 0,
	GiaBan FLOAT NULL DEFAULT 0,
	SoLuong INT NULL DEFAULT 0,
	Hinh IMAGE NULL DEFAULT NULL,
	MoTa NVARCHAR(50) NULL DEFAULT NULL,
	IDNhaCungCap NVARCHAR(50)  NULL,
	IDLoaiHang INT NOT NULL,
	IDDonViTinh INT NOT NULL,
	IDNhanVien VARCHAR(50) NOT NULL,
	FOREIGN KEY (IDNhaCungCap) REFERENCES tb_NhaCungCap(IDNhaCungCap),
	FOREIGN KEY (IDLoaiHang) REFERENCES tb_LoaiHang(IDLoaiHang),
)

go
create table tb_HoaDon
(
	IDHoaDon NVARCHAR(50) NOT NULL PRIMARY KEY,
	NgayLap DATETIME NULL DEFAULT GETDATE(),
	IDKhachHang NVARCHAR(50) NOT NULL,
	GhiChu NVARCHAR(50),
	TongTien FLOAT,
	FOREIGN KEY (IDKhachHang) REFERENCES tb_KhachHang(IDKhachHang)
)

go
create table tb_ChiTietHoaDon
(
	IDHoaDon NVARCHAR(50) NOT NULL,
	IDSanPham NVARCHAR(50) NOT NULL,
	SoLuong INT NOT NULL,
	DonGia FLOAT NOT NULL,
	PRIMARY KEY(IDHoaDon, IDSanPham),
	FOREIGN KEY (IDHoaDon) REFERENCES tb_HoaDon(IDHoaDon),
	FOREIGN KEY (IDSanPham) REFERENCES tb_SanPham(IDSanPham),
)

go
create table tb_NhapHang
(
	IDNhapHang NVARCHAR(50) PRIMARY KEY,
	NgayNhap DATE  NULL DEFAULT GETDATE(),
	IDNhaCungCap NVARCHAR(50) NULL,
	GhiChu NVARCHAR(50) NULL DEFAULT NULL,
	SoLuong INT,
	TongTien FLOAT,
	FOREIGN KEY (IDNhaCungCap) REFERENCES tb_NhaCungCap(IDNhaCungCap)
)


go
create table tb_ChiTietNhapHang
(
	IDNhapHang NVARCHAR(50) NOT NULL,
	IDSanPham NVARCHAR(50) NOT NULL,
	SoLuong INT NULL DEFAULT 0,
	DonGia FLOAT  NULL DEFAULT 0,
	PRIMARY KEY(IDNhapHang, IDSanPham),
	FOREIGN KEY (IDNhapHang) REFERENCES tb_NhapHang(IDNhapHang),
	FOREIGN KEY (IDSanPham) REFERENCES tb_SanPham(IDSanPham)
)


go
create table tb_KhachHang
(
	IDKhachHang NVARCHAR(50) PRIMARY KEY,
	HoTen NVARCHAR(50) NULL,
	DienThoai NVARCHAR(50) NULL,
	DiaChi NVARCHAR(50) NULL DEFAULT NULL,
	GhiChu NVARCHAR(50) NULL DEFAULT NULL
)

go
create table tb_LoaiHang
(
	IDLoaiHang INT IDENTITY PRIMARY KEY,
	TenLoaiHang NVARCHAR(50) NULL,
	MoTa NVARCHAR(50) NULL DEFAULT NULL,
)

go 
create table tb_NhaCungCap
(
	IDNhaCungCap NVARCHAR(50) PRIMARY KEY,
	TenNhaCungCap NVARCHAR(255) NULL,
	DienThoai NVARCHAR(50)  NULL,
	DiaChi NVARCHAR(50) NULL DEFAULT NULL,
	GhiChu NVARCHAR(50) NULL DEFAULT NULL
)


---PRoc ---

CREATE PROC sp_NhapHang_Select_All
AS
BEGIN
	SELECT IDNhapHang, NgayNhap, TenNhaCungCap, tb_NhapHang.GhiChu, SoLuong, TongTien
	FROM tb_NhapHang, tb_NhaCungCap
	WHERE tb_NhapHang.IDNhaCungCap = tb_NhaCungCap.IDNhaCungCap
	
END
GO


CREATE PROC sp_HoaDon_Select_All
AS
BEGIN
	SELECT IDHoaDon, tb_KhachHang.HoTen AS TenKhachHang,
	 tb_KhachHang.DienThoai AS DienThoaiKhachHang,
	  SoLuong, TongTien, tb_HoaDon.GhiChu AS GhiChuHD
	FROM tb_HoaDon, tb_KhachHang
	WHERE 
	 tb_HoaDon.IDKhachHang = tb_KhachHang.IDKhachHang
END
GO

GO
create PROC sp_ChiTietHoaDon_Select_ByID
@IDHoaDon VARCHAR(50)
AS
BEGIN
	SELECT tb_ChiTietHoaDon.IDSanPham, TenSanPham, tb_ChiTietHoaDon.SoLuong,
	 DonGia, (tb_ChiTietHoaDon.SoLuong * DonGia) AS TongTien
	FROM tb_ChiTietHoaDon, tb_SanPham
	 WHERE IDHoaDon = @IDHoaDon 
	 AND tb_ChiTietHoaDon.IDSanPham = tb_SanPham.IDSanPham 
END

go
create PROC sp_ChiTietNhapHang_Select_ByID
@IDNhapHang VARCHAR(50)
AS
BEGIN
	SELECT tb_ChiTietNhapHang.IDSanPham, TenSanPham, tb_ChiTietNhapHang.SoLuong, DonGia,
	 (tb_ChiTietNhapHang.SoLuong * DonGia) AS TongTienh 
	 FROM tb_ChiTietNhapHang, tb_SanPham
	  WHERE IDNhapHang = @IDNhapHang AND tb_ChiTietNhapHang.IDSanPham = tb_SanPham.IDSanPham 
END


---View hien thị hóa đơn----
create view view_HienThiTatCa
as
SELECT dbo.tb_HoaDon.IDHoaDon, dbo.tb_KhachHang.IDKhachHang, 
dbo.tb_KhachHang.HoTen AS TenKhachHang, dbo.tb_KhachHang.DienThoai AS DienThoaiKhachHang,
dbo.tb_HoaDon.TongTien, dbo.tb_HoaDon.GhiChu AS GhiChuHD
FROM dbo.tb_HoaDon INNER JOIN dbo.tb_KhachHang ON dbo.tb_HoaDon.IDKhachHang = dbo.tb_KhachHang.IDKhachHang

---View hien thi tat ca san pham---

create view view_HienThiTatCaSanPham
as
SELECT        dbo.tb_SanPham.IDSanPham, dbo.tb_SanPham.TenSanPham, dbo.tb_SanPham.GiaVon, dbo.tb_SanPham.GiaBan, dbo.tb_SanPham.SoLuong, dbo.tb_LoaiHang.IDLoaiHang, dbo.tb_SanPham.Hinh, 
                         dbo.tb_SanPham.MoTa, dbo.tb_LoaiHang.TenLoaiHang, dbo.tb_NhaCungCap.TenNhaCungCap
FROM            dbo.tb_SanPham INNER JOIN
                         dbo.tb_LoaiHang ON dbo.tb_SanPham.IDLoaiHang = dbo.tb_LoaiHang.IDLoaiHang INNER JOIN
                         dbo.tb_NhaCungCap ON dbo.tb_SanPham.IDNhaCungCap = dbo.tb_NhaCungCap.IDNhaCungCap