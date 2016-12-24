Create database QuanLiThietBi
use QuanLiThietBi
GO
use master
CREATE TABLE LOAITHIETBI
(
	ID int primary key identity NOT NULL,
	Ten nvarchar(50) NULL
 )
 CREATE TABLE TINHTRANG(
	ID int primary key identity NOT NULL,
	Ten nvarchar(100) NULL,
 )
CREATE TABLE NHACUNGCAP(
	ID int primary key identity NOT NULL,
	Ten nvarchar(50) NULL,
	DiaChi nvarchar(50) NULL,
	 SDT nvarchar(11) NULL
)
CREATE TABLE THIETBI(
	ID int primary key identity NOT NULL,
	TEN nvarchar(100) NULL,
	DonGia int NULL,
	ThongSo nvarchar(500) NULL,
	NgaySanXuat datetime NULL,
	NgaySD datetime NULL,
	NgayCapNhat datetime null,
	SoLuong int NULL,
	DonViTinh nvarchar(20) NULL,
	ID_Loai int references LOAITHIETBI(ID) not null,
	ID_TinhTrang int references TinhTrang(ID) not null
 )

CREATE TABLE DONVI
(
	ID int primary key identity NOT NULL,
	Ten nvarchar(50) NULL,
	GhiChu nvarchar(200) NULL
	)
CREATE TABLE PHONGQUANTRI(
	ID int primary key identity NOT NULL,
	Ten nvarchar(max) NULL
	)
CREATE TABLE PHIEUGIAO(
	ID int primary key identity NOT NULL,
	NgayGiao datetime NULL,
	TinhTrang nvarchar(50) NULL,
	ID_QuanTri int references PHONGQUANTRI(ID) not  NULL
	)
CREATE TABLE PHIEUNHAP(
	ID int primary key identity NOT NULL,
	NgayNhap datetime NULL,
	ID_NhaCC int references NHACUNGCAP(ID) null, 
	ID_DonVi int REFERENCES DONVI(ID) NULL
	)

CREATE TABLE CHITIETPHIEUGIAO(
	ID int primary key identity NOT NULL,
	ID_ThietBi int references THIETBI(ID) NOT NULL,
	ID_PHieuGiao int references PHIEUGIAO(ID) NOT NULL,
	SoLuong int NULL
	)
create table CHITIETPHIEUNHAP
(
	ID int primary key identity not null,
	ID_ThietBi int references THIETBI(ID) NOT NULL,
	ID_PHIEUNHAN int references PHIEUNHAP(ID) NOT NULL,
	soluong int NULL
)
-- insert dữ liệu bảng đơn vị

insert into DONVI VALUES (N'Khoa CNTT', N'Công Nghệ Thông Tin')
insert into DONVI VALUES (N'Khoa Điện Tử', N'Điện Tử Viễn Thông')
insert into DONVI VALUES (N'Khoa Quan hệ Quốc Tế', N'Du lịch ')
insert into DONVI VALUES (N'Khoa Kinh Tế', N'Kinh Tế ')
insert into DONVI VALUES (N'Khoa Mỹ Thuật', N'Mỹ Thuật')
insert into DONVI VALUES (N'Khoa Nội Trợ', N'Nội Trợ Đảm Đang')
insert into DONVI VALUES (N'Khoa Bình Tĩnh',N'Bình Tĩnh')
insert into DONVI VALUES (N'Khoa Dưỡng Lão', N'Dưỡng Lão')
insert into DONVI VALUES (N'Khoa Hồi Sức', N'Hồi Sức')
insert into DONVI VALUES ( N'Khoa Thể Thao', N'Thể Thao')
insert into DONVI VALUES ( N'Khoa Mầm Già', N'Mầm Già')

-- insert dữ liệu bảng loại thiết bị

INSERT into LOAITHIETBI VALUES (N'IT')
INSERT into LOAITHIETBI VALUES (N'Âm thanh')
INSERT into LOAITHIETBI VALUES (N'Hình ảnh')

-- insert dữ liệu bảng nhà cung cấp
insert into NhaCungCap VALUES (N'Tân Hiệp Phát', N'Quảng Ngãi', N'01662637397')
insert into NhaCungCap VALUES (N'Hiệp Thành', N'Sài Gòn', N'01662637397')
insert into NhaCungCap VALUES (N'Trà Vinh', N'Tây Ninh', N'01662637397')
insert into NhaCungCap VALUES (N'Siêu Thị BigC', N'Sài Gòn', N'01662637397')
insert into NhaCungCap VALUES (N'Lạc Hồng', N'Âu Cơ', N'01662637397')
insert into NhaCungCap VALUES (N'Mắt Nai', N'Bình Tĩnh', N'01662638484')
insert into NhaCungCap VALUES (N'Trại Giam', N'Đồng Nai', N'01726266634')
insert into NhaCungCap VALUES (N'Sting Dâu', N'Cần Thơ', N'01237444833')
insert into NhaCungCap VALUES (N'Bí Đỏ', N'Sài Gòn', N'01123444553')
insert into NhaCungCap VALUES ( N'Dâu Tây', N'Bình Hưng Hòa', N'01444433337')
insert into NhaCungCap VALUES ( N'Điện máy Xanh', N'Sài Gòn', N'01223456677')
-- insert dữ liệu bảng phòng quản trị

insert into PHONGQUANTRI VALUES (N'Phòng Vi Tính')
insert into PHONGQUANTRI VALUES (N'Phòng Âm Thanh')
insert into PHONGQUANTRI VALUES (N'Phòng Ánh Sáng')

-- insert dữ liệu bảng tình trạng

insert into TINHTRANG VALUES (N'Mới')
insert into TINHTRANG VALUES (N'Đã Qua Sử Dụng (99%)')
insert into TINHTRANG VALUES (N'Đã Qua Sử Dụng (50%)')
insert into TINHTRANG VALUES (N'Hư')
insert into TINHTRANG VALUES (N'Đã thanh lý')
-- insert dữ liệu bảng thiết bị
insert into THIETBI VALUES (N'Màn hình LCD', 2000000, N'Màn Hình', CAST(0x0000957C00000000 AS DateTime), CAST(0x0000A3C100000000 AS DateTime), CAST(0x0000A6DB00000000 AS DateTime), 28, N'cái', 1, 1)
insert into THIETBI VALUES (N'Bàn Phím', 500000, N'Bàn Phím', CAST(0x0000873700000000 AS DateTime), CAST(0x0000A52D00000000 AS DateTime), CAST(0x0000A6DB01535C28 AS DateTime), 23, N'cái',2,1)
insert into THIETBI VALUES (N'Chuột', 100000, N'Chuột', CAST(0x0000A62400000000 AS DateTime), CAST(0x0000A6DB00000000 AS DateTime), CAST(0x0000A6DD00000000 AS DateTime), 1,N'cái',3,1)
insert into THIETBI VALUES (N'Máy Chiếu', 3000000, N'Máy Chiếu', CAST(0x00009D9800000000 AS DateTime), CAST(0x0000A6DB00000000 AS DateTime), CAST(0x0000A6DB0157A65F AS DateTime), 125,N'cái',1,1)
insert into THIETBI VALUES (N'Thùng Máy', 5000000, N'Thùng Máy Tính', CAST(0x00009D3500000000 AS DateTime), CAST(0x0000A6D500000000 AS DateTime), CAST(0x0000A6DB0157CC25 AS DateTime), 121,N'cái',2,1)
insert into THIETBI VALUES (N'Máy Lạnh', 5500000, N'Máy Lạnh', CAST(0x00009D9600000000 AS DateTime), CAST(0x0000A6DB00000000 AS DateTime), CAST(0x0000A6DD00000000 AS DateTime),11,N'cái',1,1)
insert into THIETBI VALUES (N'Tivi', 7000000, N'Tivi', CAST(0x00009D9600000000 AS DateTime), CAST(0x0000A6DB00000000 AS DateTime), CAST(0x0000A6DB0157F31B AS DateTime), 11,N'cái',2,1)
insert into THIETBI VALUES (N'Màn Chiếu', 1200000, N'Màn Máy Chiếu', CAST(0x0000A33F00000000 AS DateTime), CAST(0x0000A6DB00000000 AS DateTime), CAST(0x0000A6DB0159FB8B AS DateTime), 11,N'cái',3,1)
insert into THIETBI VALUES ( N'Máy Casset', 500000, N'Máy Nghe Tiếng Anh', CAST(0x0000A33F00000000 AS DateTime), CAST(0x0000A6DB00000000 AS DateTime), CAST(0x0000A6DB0159FB8B AS DateTime),11,N'cái',1,1)

-- insert dữ liệu bảng phiếu giao
insert into PHIEUGIAO VALUES (CAST(0x0000A6E400000000 AS DateTime),N'',1)
 insert into PHIEUGIAO VALUES (CAST(0x0000A6E400000000 AS DateTime),N'',1)
 insert into PHIEUGIAO VALUES (CAST(0x0000A6E400000000 AS DateTime),N'',2)
 insert into PHIEUGIAO VALUES (CAST(0x0000A6E500000000 AS DateTime),N'',3)

 -- insert dữ liệu bảng phiếu nhập
 
insert into PhieuNhap VALUES (CAST(0x0000A6D000000000 AS DateTime),1,null)
insert into PhieuNhap VALUES (CAST(0x0000A6D600000000 AS DateTime),null,1)
insert into PhieuNhap VALUES (CAST(0x0000A6DE00000000 AS DateTime),2,null)
insert into PhieuNhap VALUES (CAST(0x0000A6E800000000 AS DateTime),null,2)
-- insert dữ liệu bảng phiếu  giao
INSERT into CHITIETPHIEUGIAO VALUES (2, 1, 3)
INSERT into CHITIETPHIEUGIAO VALUES (1, 2,2)
INSERT into CHITIETPHIEUGIAO VALUES (3, 3, 3)
INSERT into CHITIETPHIEUGIAO VALUES (4,4,5)
--- insert dữ liệu bảng chi tiết phiếu nhập
insert into ChiTietPhieuNhap values(1,1,1)
insert into ChiTietPhieuNhap values(2,2,2)
insert into ChiTietPhieuNhap values(3,3,3)
insert into ChiTietPhieuNhap values(4,4,4)










