use master
go
drop Database QuanLyThuVien
go
use master
go
create DAtabase QuanLyThuVien
go
use  QuanLyThuVien
go
create Table PhanQuyen(
	MaPhanQuyen bit primary key,
	TenPhanQuyen varchar(20)  not null,
)
go

insert into PhanQuyen values
	(1,'admin'),
	(0,'user');

-----------------------------------------------------
go
create Table TaiKhoan(
	TenDangNhap varchar(10) primary key,
	MatKhau varchar(50)  not null,
	MaPhanQuyen bit not null
	Constraint fk_maPhanQuyen Foreign key(MaPhanQuyen) references PhanQuyen(MaPhanQuyen)
)

go
insert into TaiKhoan values
('2018602043', '1111', 1),
('2018373123', 'alo123', 0),
('2018222345', '1234554321', 0),
('2018345666','1818181818', 1),
('2018600534', '123', 0),
('2017376251','pass11', 1),
('2018726152','123len', 0),
('2018282739', '0175',0);
go
-----------------------------------------------------

create table DocGia(
	TenDangNhap varchar(10) not null primary key,
	MaDocGia varchar(10) not null unique,
	TenDocGia nvarchar(20) not null,
	NgaySinh date not null,
	DiaChi nvarchar(50) not null,
	SDT varchar(25) not null,
	CCCD varchar(25) not null,
	NgayDangKy date not null,
)

go
insert into DocGia values
('2018373123', 'DG01', N'Vũ Xuân Long', '09/02/2000', N'Ninh Bình', '0332323121','827849381', '09/04/2020'),
('2018222345', 'DG02', N'Lê Văn A', '02/02/2000', N'Nam Định', '0954563870',' 819201271', '02/01/2021'),
('2018600534', 'DG03', N'Nguyễn Thế Chiến', '01/09/2000', N'Hà Nội', '094329276', '182902818','03/03/2021'),
('2018726152', 'DG04', N'Trần Trung Kiên', '01/01/2000', N'Nam Định', '079921297','174302837','02/02/2020'),
('2018282739', 'DG05', N'Cáp Trọng Hiệp', '09/04/2000', N'Cà Mau', '0983719342', '0192837281', '09/07/2019');

-----------------------------------------------------

go
create table ThuThu(
	TenDangNhap varchar(10) not null primary key,
	MaThuThu varchar(10) not null unique,
	TenThuThu nvarchar(20) not null,
	NgaySinh date not null,
	DiaChi nvarchar(50) not null,
	SDT varchar(30) not null,
	CCCD varchar(30) not null,
	NgayVaoLam date not null,
)
go

insert into ThuThu values
('2018602043','TT01',N'Lê Đức Anh','12/20/2000',N'Nam Định','023221211','164692817','01/02/2018'),
('2018345666','TT02',N'Hoàng Quang Ánh','12/12/2000',N'Hà Nội','0342339121','164673626','01/01/2018'),
('2017376251','TT03',N'Nguyễn Duy Nghĩa','02/20/1999',N'Ninh Bình','082717278','164672610','09/03/2017');

-------------------------------------------------------
go
create table TheLoai(
	MaTheLoai varchar(10) primary key,
	TenTheLoai nvarchar(50) not null,
)
go
insert into TheLoai values
('L01', N'Giáo Dục'),
('L02', N'Kinh tế'),
('L03', N'Văn Hóa'),
('L04', N'Tín ngưỡng'),
('L05', N'Trẻ em'),
('L06', N'Trò chơi'),
('L07', N'Doanh Nhân'),
('L08', N'Giải trí'),
('L09', N'Ngụ ngôn'),
('L10', N'Truyện tranh'),
('L11', N'Cao dao'),
('L12', N'Tục ngữ'),
('L13', N'Lịch sử'),
('L14', N'Khoa học'),
('L15', N'Sinh học');
go
-----------------------------
create table Sach(
	MaSach varchar(10) primary key,
	TenSach nvarchar(50) not null,
	SoLuong int not null,
	NgayNhap date not null,
	TinhTrang nvarchar(20),
	MaTheLoai varchar(10) not null,
	constraint fk_maTheLoai foreign key(MaTheLoai) references TheLoai(MaTheLoai),
)


go
insert into Sach values
('S01',N'Kỹ thuật lập trình',300,'10/10/2016',N'Tốt','L01'),
('S02',N'Doreamon',100,'1/10/2012',N'Tốt','L10'),
('S03',N'Chiến thắng Điện Biên Phủ',522,'12/12/2020',N'Cũ','L13'),
('S04',N'Doanh nhân thành đạt',340,'12/10/2016',N'Tốt','L02'),
('S05',N'Những phát minh vĩ đại',150,'09/02/2011',N'Tốt','L14'),
('S06',N'Những chú chó thông minh',220,'10/28/2020',N'Cũ','L09'),
('S07',N'Shin',120,'02/09/2010',N'Tốt','L10'),
('S08',N'Trò chơi xưa và nay',500,'10/10/2016',N'Tốt','L06'),
('S09',N'Văn hóa xưa và nay',300,'10/10/2016',N'Tốt','L03'),
('S10',N'Chiến tranh Việt Nam',100,'10/01/2006',N'cũ','L01'),
('S11',N'Chiến binh bất diệt',300,'06/10/2011',N'Tốt','L13');

go


create table NhaCungCap(
	MaNCC varchar(10) primary key,
	TenNCC nvarchar(50) not null,
	SDT varchar(25) not null,
	DiaChi nvarchar(100) not null,
)


go
insert into NhaCungCap values
('NCC01',N'Công ty TNHH Long Vũ','0355121123',N'Hà Nội'),
('NCC02',N'Công ty TNHH XKLĐ','035533553',N'Ninh Bình'),
('NCC03',N'Công ty TNHH Ba ĐÌnh','035568753',N'Cà Mau'),
('NCC04',N'Công ty 1TV','0350991722',N'Hà Nội'),
('NCC05',N'Công ty TNHH vũ Xuân','0987125262',N'Lai Châu'),
('NCC06',N'Công ty TNHH Hải Long','035533553',N'Hà Nội');

go
-------------------------------------------------------
---------------------------------------------------------------------------------------------------
--Table changing----
go
create table NhapSach(

	MaPhieu varchar(20) primary key,

	MaNCC varchar(10) not null,
	TenNCC nvarchar(50) not null,

	MaThuThu varchar(10) not null,
	TenThuThu nvarchar(20) not null,

	NgayNhap date not null,

	constraint fk_maNCC foreign key (MaNCC) references NhaCungCap(MaNCC),
	constraint fk_maTT foreign key (MaThuThu) references ThuThu(MaThuThu),
)
go

insert into NhapSach values
('001','NCC01',N'Công ty TNHH Long Vũ','TT01',N'Nguyễn Tiến Anh','01/01/2021'),
('002','NCC02',N'Công ty TNHH XKLĐ','TT02',N'Hoàng Quang Ánh','05/10/2021');
go
create table ListBooks(
	MaPhieu varchar(20) not null,

	MaSach varchar(10) not null,
	TenSach nvarchar(50) not null,
	TheLoai nvarchar(50) not null,
	SoLuong int  not null,
)
go
insert into ListBooks values('001','S01',N'Kỹ thuật lập trình',N'tl 1',2),
('001','S03',N'Chiến thắng Điện Biên Phủ',N'tl2',3),
('001','S05',N'Những phát minh vĩ đại',N'tl 3',4),
('002','S08',N'Trò chơi xưa và nay',N'tl 4',5);

go
create table PhieuMuon(
	MaPhieuMuon varchar(10) primary key,--001

	MaDocGia varchar(10) not null,
	constraint fk_maDocGia foreign key (MaDocGia) references DocGia(MaDocGia),

	TenDocGia nvarchar(20) not null,
	SDTDocGia varchar (25) not null,

	MaThuThu varchar(10) not null,
	TenThuThu nvarchar(20) not null,
	SDTThuThu varchar (25)not null,

	NgayMuon date not null,
	SoNgayMuon int not null,
)
go

create table ListBooksPhieuMuon(
	
	MaPhieuMuon varchar(10) not null,
	constraint fk_maPhieuMuon foreign key(MaPhieuMuon) references PhieuMuon(MaPhieuMuon),

	MaSach varchar(10) not null,
	 foreign key (MaSach) references Sach(MaSach),

	TenSach nvarchar(50) not null,
	TenTheLoai nvarchar(50) not null,
	SoLuong int not null,
)
go
select * from PhieuMuon, ListBooksPhieuMuon where PhieuMuon.MaPhieuMuon=ListBooksPhieuMuon.MaPhieuMuon
go
insert into PhieuMuon values('001','DG01',N'Vũ Xuân Long','0332323121','TT01',N'Lê Đức Anh','023221211','01/01/2021',10);
go

insert into PhieuMuon values('002','DG02',N'Lê Văn A','0954563870','',N'','',GETDATE(),0);
go


insert into ListBooksPhieuMuon values
('001','S01',N'Kỹ thuật lập trình',N'Giáo Dục',10),
('001','S02',N'Doreamon',N'Truyện tranh',10),
('001','S03',N'Chiến thắng Điện Biên Phủ',N'Lịch sử',10),
('002','S04',N'Doanh nhân thành đạt',N'Kinh Tế',10);

go

--table tmp----
create table tmp_Login(
	username varchar(10) primary key,
	pass varchar(50) not null,
	MaPhanQuyen bit ,
	constraint fk_maPK foreign key(MaPhanQuyen) references PhanQuyen(MaPhanQuyen),
)
go
create table tmp_SachMuon (
	MaSach1 varchar(20) not null primary key,
	TenSach1 nvarchar(50) not null,
	NgayNhap1 date not null,
	TinhTrang1 nvarchar(10) not null,
	MaTheLoai1 varchar(10) not null,
)

create table tmp_SachNhap (
	
	MaPhieu varchar(20) not null, 

	MaSach varchar(10) not null primary key,
	TenSach nvarchar(50) not null,
	TheLoai nvarchar(50) not null,
	SoLuong int  not null,
)
--select * from tmp_Login
--delete from ListBooks
--select *  from ListBooks
--select *  from tmp_SachNhap 
--select *  from NhapSach
--delete  from NhapSach where MaPhieu = '1'
--INSERT INTO  ListBooks SELECT * FROM  tmp_SachNhap delete from tmp_SachNhap insert into NhapSach values ();

--update NhapSach set MaNCC = '"++"', TenNCC = '"++"', NgayNhap = '"++"' where MaPhieu = '"++"' update ListBooks set TenSach = '"++"', TheLoai = '"++"',SoLuong = '"++"' where MaPhieu = '"++"' and MaSach = '"++"' 
--delete from ListBooks where MaPhieu = '"++"' and MaSach = '"++"'