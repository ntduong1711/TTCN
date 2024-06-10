create database QLhopxuong
go

use QLhopxuong

create table tblbophan(
	mabophan char(4) primary key,
	tenbophan nvarchar(50) not null) 

create table tblnhanvien(
	manhanvien char(10) primary key,
	tennhanvien nvarchar(50) not null,
	gioitinh bit not null,
	sodienthoai char(10) not null,
	ngaysinh date not null,
	email nvarchar(50) not null,
	diachi nvarchar(100),
	mabophan char(4) foreign key references tblbophan(mabophan))

create table tblmonhoc(
	mamon char(4) primary key,
	tenmon nvarchar(50) not null,
	capdo int not null,
	loaigiong nvarchar(10) not null)

create table tbllophoc(
	malophoc char(4) primary key,
	tenlophoc nvarchar(50) not null,
	sisomax int check(sisomax>0) not null,
	phonghoc char(3) not null,
	ngaybatdau date not null,
	check(ngaybatdau<ngayketthuc),
	ngayketthuc date not null,
	mamon char(4) foreign key references tblmonhoc(mamon))

create table tblhocvien(
	mahocvien char(10) primary key,
	tenhocvien nvarchar(50) not null,
	loaigiong nvarchar(15) not null,
	capdo int not null,
	gioitinh bit not null,
	sodienthoai char(10) not null,
	email char(50) not null,
	ngaysinh date not null,
	diachi nvarchar(100))


create table tblthamgia(
	mahocvien char(10),
	malophoc char(4),
	primary key (mahocvien,malophoc))

create table tblphieughidanh(
	maphieu char(10) primary key,
	ngaytiepnhan date not null,
	manhanvien char(10) foreign key references tblnhanvien(manhanvien),
	mahocvien char(10) foreign key references tblhocvien(mahocvien))

create table tblngaydanhgia(
	madanhgia char(10) primary key,
	ngaydanhgia date not null,
	tenkydanhgia nvarchar(20) not null,
	soluongmax int check (soluongmax>0) not null)

create table tbldondangkydanhgia(
	mahocvien char(10),
	malophoc char(10),
	madanhgia char(10),
	primary key (mahocvien, madanhgia,malophoc),
	ngaydangky date not null check(ngaydangky<=getdate()),
	ketquadanhgia nvarchar(50))

create table tblhoadonmuatailieu(
	mahoadon char(4),
	mahocvien char(10),
	primary key (mahocvien,mahoadon),
	tongtien float not null check (tongtien>0),
	ngaydangky date not null,
	hinhthucnop nvarchar(20) not null,
	trangthainop nvarchar(20) not null,
	ngaynop date,
	check(ngaydangky<=ngaynop),
	minhchung nvarchar(200))

create table tblchitiethoadon(
	mahoadon char(4),
	matailieu char(10),
	primary key (matailieu,mahoadon),
	soluong int check(soluong>0),
	dongia float check(dongia>0))

create table tbltailieu(
	matailieu char(10) primary key,
	tentailieu nvarchar(100) not null,
	mota nvarchar(100),
	dongia float not null check(dongia>0),
	hinhanh nvarchar(100))

create table tbllichgiangday(
	manhanvien char(10),
	malophoc char(4),
	primary key (manhanvien, malophoc),
	lichday nvarchar(8) not null)

create table tblthongbao(
	mathongbao char(8) primary key,
	tieude nvarchar(50) not null,
	noidung nvarchar(100) not null,
	ngaydang date not null,
	manhanvien char(10) foreign key references tblnhanvien(manhanvien))

create table tblsukien(
	masukien char(6) primary key,
	tensukien nvarchar(100) not null,
	ngaybatdau date not null,
	ngayketthuc date not null,
	check(ngaybatdau<=ngayketthuc),
	diadiemtochuc nvarchar(100) not null)

create table tbltrangthietbi(
	matrangthietbi char(4) primary key,
	tentrangthietbi nvarchar(50) not null)

create table tblnhacungcap(
	mancc char(6) primary key,
	tenncc nvarchar(50) not null,
	diachi nvarchar(100) not null,
	masothue char(10) not null,
	sodienthoai char(10) not null,
	email char(50) not null)

create table tblcungcaptrangthietbi(
	mancc char(6),
	matrangthietbi char(4),
	primary key(mancc,matrangthietbi))

create table tblnhataitro(
	mantt char(5) primary key,
	tenntt nvarchar(100) not null,
	diachi nvarchar(100) not null,
	masothue char(10) not null,
	sodienthoai char(10) not null,
	email char(50) not null,
	trangthai nvarchar(20) not null)

create table tblnhantaitro(
	mantt char(5),
	masukien char(6),
	primary key(mantt,masukien),
	ngaynhan date,
	trangthainhantaitro nvarchar(20))

create table tblphieuchi(
	maphieuchi char(5) primary key,
	masukien char(6) foreign key references tblsukien(masukien),
	manhanvien char(10) foreign key references tblnhanvien(manhanvien),
	sotien float check(sotien>0),
	trangthai nvarchar(50))

create table tblhopdongthue(
	mahopdong char(5) primary key,
	mancc char(6) foreign key references tblnhacungcap(mancc),
	masukien char(6) foreign key references tblsukien(masukien),
	manhanvien char(10) foreign key references tblnhanvien(manhanvien),
	ngaylap date not null,
	tongtien int check(tongtien>0),
	trangthai nvarchar(50) not null)
	

create table tblchitiethopdong(
	mahopdong char(5),
	matrangthietbi char(4),
	primary key (mahopdong,matrangthietbi),
	soluong int not null check(soluong>0),
	dongia float not null check(dongia>0),
	ngaythue date not null,
	ngaytra date not null,
	check(ngaytra>ngaythue))


create table tblbaocaonghiemthu(
	mabaocao char(5) primary key,
	masukien char(6) foreign key references tblsukien(masukien),
	mantt char(5) foreign key references tblnhataitro(mantt),
	manhanvien char(10) foreign key references tblnhanvien(manhanvien),
	noidung nvarchar(100) not null,
	minhchung nvarchar(100))


insert into tblmonhoc(mamon,tenmon,capdo,loaigiong) values ('MH01','Alto 1',1,'Alto')
insert into tblmonhoc(mamon,tenmon,capdo,loaigiong) values ('MH02','Alto 2',2,'Alto')
insert into tblmonhoc(mamon,tenmon,capdo,loaigiong) values ('MH03','Alto 3',3,'Alto')
insert into tblmonhoc(mamon,tenmon,capdo,loaigiong) values ('MH04','Soprano 1',1,'Soprano')
insert into tblmonhoc(mamon,tenmon,capdo,loaigiong) values ('MH05','Soprano 2',2,'Soprano')
insert into tblmonhoc(mamon,tenmon,capdo,loaigiong) values ('MH06','Soprano 3',3,'Soprano')
insert into tblmonhoc(mamon,tenmon,capdo,loaigiong) values ('MH07','Tenor 1',1,'Tenor')
insert into tblmonhoc(mamon,tenmon,capdo,loaigiong) values ('MH08','Tenor 2',2,'Tenor')
insert into tblmonhoc(mamon,tenmon,capdo,loaigiong) values ('MH09','Tenor 3',3,'Tenor')
insert into tblmonhoc(mamon,tenmon,capdo,loaigiong) values ('MH10','Baritone 1',1,'Baritone')
insert into tblmonhoc(mamon,tenmon,capdo,loaigiong) values ('MH11','Baritone 2',2,'Baritone')
insert into tblmonhoc(mamon,tenmon,capdo,loaigiong) values ('MH12','Baritone 3',3,'Baritone')
insert into tblmonhoc(mamon,tenmon,capdo,loaigiong) values ('MH13','Bass 1',1,'Bass')
insert into tblmonhoc(mamon,tenmon,capdo,loaigiong) values ('MH14','Bass 2',2,'Bass')
insert into tblmonhoc(mamon,tenmon,capdo,loaigiong) values ('MH15','Bass 3',3,'Bass')

insert into tbllophoc(malophoc, tenlophoc, sisomax, phonghoc, ngaybatdau, ngayketthuc, mamon) values ('LH01',N'Lớp Alto 1 kỳ 1/2023',25,'A01','01-15-2023','05-15-2023','MH01')
insert into tbllophoc(malophoc, tenlophoc, sisomax, phonghoc, ngaybatdau, ngayketthuc, mamon) values ('LH02',N'Lớp Soprano 2 kỳ 1/2023',22,'A02','01-16-2023','05-16-2023','MH05')
insert into tbllophoc(malophoc, tenlophoc, sisomax, phonghoc, ngaybatdau, ngayketthuc, mamon) values ('LH03',N'Lớp Tenor 3 kỳ 1/2023',23,'A03','01-17-2023','05-17-2023','MH09')
insert into tbllophoc(malophoc, tenlophoc, sisomax, phonghoc, ngaybatdau, ngayketthuc, mamon) values ('LH04',N'Lớp Baritone 1 kỳ 1/2023',21,'A04','01-07-2023','05-07-2023','MH10')
insert into tbllophoc(malophoc, tenlophoc, sisomax, phonghoc, ngaybatdau, ngayketthuc, mamon) values ('LH05',N'Lớp Bass 2 kỳ 1/2023',26,'A05','01-08-2023','05-08-2023','MH14')
insert into tbllophoc(malophoc, tenlophoc, sisomax, phonghoc, ngaybatdau, ngayketthuc, mamon) values ('LH06',N'Lớp Alto 3 kỳ 2/2023',24,'A01','07-09-2023','12-09-2023','MH03')
insert into tbllophoc(malophoc, tenlophoc, sisomax, phonghoc, ngaybatdau, ngayketthuc, mamon) values ('LH07',N'Lớp Soprano 1 kỳ 2/2023',23,'A02','07-10-2023','12-10-2023','MH04')
insert into tbllophoc(malophoc, tenlophoc, sisomax, phonghoc, ngaybatdau, ngayketthuc, mamon) values ('LH08',N'Lớp Tenor 2 kỳ 2/2023',22,'A03','07-11-2023','12-11-2023','MH08')
insert into tbllophoc(malophoc, tenlophoc, sisomax, phonghoc, ngaybatdau, ngayketthuc, mamon) values ('LH09',N'Lớp Baritone 3 kỳ 2/2023',25,'A04','07-12-2023','12-12-2023','MH12')
insert into tbllophoc(malophoc, tenlophoc, sisomax, phonghoc, ngaybatdau, ngayketthuc, mamon) values ('LH10',N'Lớp Bass 1 kỳ 2/2023',21,'A05','07-13-2023','12-13-2023','MH13')
insert into tbllophoc(malophoc, tenlophoc, sisomax, phonghoc, ngaybatdau, ngayketthuc, mamon) values ('LH11',N'Lớp Alto 2 kỳ 1/2024',22,'A01','01-14-2024','05-14-2024','MH02')
insert into tbllophoc(malophoc, tenlophoc, sisomax, phonghoc, ngaybatdau, ngayketthuc, mamon) values ('LH12',N'Lớp Soprano 3 kỳ 1/2024',23,'A02','01-06-2024','05-06-2024','MH06')
insert into tbllophoc(malophoc, tenlophoc, sisomax, phonghoc, ngaybatdau, ngayketthuc, mamon) values ('LH13',N'Lớp Tenor 1 kỳ 1/2024',26,'A03','01-05-2024','05-05-2024','MH07')
insert into tbllophoc(malophoc, tenlophoc, sisomax, phonghoc, ngaybatdau, ngayketthuc, mamon) values ('LH14',N'Lớp Baritone 2 kỳ 1/2024',24,'A04','01-04-2024','05-04-2024','MH11')
insert into tbllophoc(malophoc, tenlophoc, sisomax, phonghoc, ngaybatdau, ngayketthuc, mamon) values ('LH15',N'Lớp Bass 3 kỳ 1/2024',23,'A05','01-03-2024','05-03-2024','MH15')

insert into tblhocvien(mahocvien, tenhocvien, gioitinh, loaigiong, capdo, sodienthoai, email, ngaysinh, diachi) values ('HV10122001', N'Nguyễn Thị Hồng', 1, 'Alto', 1, '0987654321', 'nguyenthihong@gmail.com', '01-01-1988', N'123 Đường Láng, Quận Đống Đa, Hà Nội')
insert into tblhocvien(mahocvien, tenhocvien, gioitinh, loaigiong, capdo, sodienthoai, email, ngaysinh, diachi) values ('HV10123002', N'Đỗ Văn Oanh', 1,'Soprano',2, '0987654334', 'dovanoanh@gmail.com', '02-14-1987', N'123 Đường Trần Phú, Quận Ba Đình, Hà Nội')
insert into tblhocvien(mahocvien, tenhocvien, gioitinh, loaigiong, capdo, sodienthoai, email, ngaysinh, diachi) values ('HV10124003', N'Hoàng Thị Phương', 1, 'Tenor',3,'0987654335', 'hoangthiphuong@gmail.com', '03-15-1986', N'456 Đường Kim Mã, Quận Ba Đình, Hà Nội')
insert into tblhocvien(mahocvien, tenhocvien, gioitinh, loaigiong, capdo, sodienthoai, email, ngaysinh, diachi) values ('HV00123004', N'Trần Văn Quân', 0,'Baritone',1, '0987654336', 'tranvanquan@gmail.com', '04-12-1985', N'789 Đường Đội Cấn, Quận Ba Đình, Hà Nội')
insert into tblhocvien(mahocvien, tenhocvien, gioitinh, loaigiong, capdo, sodienthoai, email, ngaysinh, diachi) values ('HV10124005', N'Nguyễn Thị Ngọc', 1, 'Bass',2, '0987654337', 'nguyenthingoc@gmail.com', '07-05-1984', N'101 Đường Nguyễn Chí Thanh, Quận Đống Đa, Hà Nội')
insert into tblhocvien(mahocvien, tenhocvien, gioitinh, loaigiong, capdo, sodienthoai, email, ngaysinh, diachi) values ('HV00224006', N'Trần Thị Sáng', 0,'Alto',3, '0987654343', 'tranthisang@gmail.com', '03-11-1978', N'666 Đường Hồ Tùng Mậu, Quận Cầu Giấy, Hà Nội')
insert into tblhocvien(mahocvien, tenhocvien, gioitinh, loaigiong, capdo, sodienthoai, email, ngaysinh, diachi) values ('HV00223007', N'Nguyễn Văn Tâm', 0,'Soprano',1, '0987654344', 'nguyenvantam@gmail.com', '04-12-1977', N'777 Đường Lê Đức Thọ, Quận Nam Từ Liêm, Hà Nội')
insert into tblhocvien(mahocvien, tenhocvien, gioitinh, loaigiong, capdo, sodienthoai, email, ngaysinh, diachi) values ('HV10222008', N'Hoàng Thị Út', 1, 'Tenor',2, '0987654345', 'hoangthiut@gmail.com', '05-01-1976', N'888 Đường Nguyễn Xiển, Quận Thanh Xuân, Hà Nội')
insert into tblhocvien(mahocvien, tenhocvien, gioitinh, loaigiong, capdo, sodienthoai, email, ngaysinh, diachi) values ('HV00224009', N'Vũ Văn Vượng', 0, 'Baritone',3,'0987654346', 'vuvanvuong@gmail.com', '06-02-1975', N'999 Đường Nguyễn Trãi, Quận Thanh Xuân, Hà Nội')
insert into tblhocvien(mahocvien, tenhocvien, gioitinh, loaigiong, capdo, sodienthoai, email, ngaysinh, diachi) values ('HV10222010', N'Lê Thị sinh', 1, 'Bass',1,'0987654347', 'lethisinh@gmail.com', '07-03-1974', N'101 Đường Lê Thanh Nghị, Quận Hai Bà Trưng, Hà Nội')
insert into tblhocvien(mahocvien, tenhocvien, gioitinh, loaigiong, capdo, sodienthoai, email, ngaysinh, diachi) values ('HV00322011', N'Hồ Văn Nam', 0,'Alto',2, '0987654375', 'hovannam@gmail.com', '11-05-2000', N'18 Hoàng Cầu, Đống Đa, Hà Nội')
insert into tblhocvien(mahocvien, tenhocvien, gioitinh, loaigiong, capdo, sodienthoai, email, ngaysinh, diachi) values ('HV10323012', N'Trần Thị Oanh', 1,'Soprano',3, '0987654376', 'tranthioanh@gmail.com', '12-06-2001', N'63 Đội Cấn, Ba Đình, Hà Nội')
insert into tblhocvien(mahocvien, tenhocvien, gioitinh, loaigiong, capdo, sodienthoai, email, ngaysinh, diachi) values ('HV00323013', N'Mai Văn Phong', 0,'Tenor',1, '0987654377', 'maivanphong@gmail.com', '07-07-2002', N'88 Quán Thánh, Ba Đình, Hà Nội')
insert into tblhocvien(mahocvien, tenhocvien, gioitinh, loaigiong, capdo, sodienthoai, email, ngaysinh, diachi) values ('HV10322014', N'Đinh Thị Quyên', 1,'Baritone',2, '0987654378', 'dinhthiquyen@gmail.com', '08-12-2003', N'17 Tràng Thi, Hoàn Kiếm, Hà Nội')
insert into tblhocvien(mahocvien, tenhocvien, gioitinh, loaigiong, capdo, sodienthoai, email, ngaysinh, diachi) values ('HV00323015', N'Lương Văn Long', 0, 'Bass',3,'0987654379', 'luongvanlong@gmail.com', '12-09-2004', N'45 Tây Sơn, Đống Đa, Hà Nội')
insert into tblhocvien(mahocvien, tenhocvien, gioitinh, loaigiong, capdo, sodienthoai, email, ngaysinh, diachi) values ('HV00424016', N'Phạm Văn Đức', 0, 'Alto', 1,'0987654325', 'phamvanduc@gmail.com', '05-05-1999', N'234 Lê Lợi, Hà Nội')
insert into tblhocvien(mahocvien, tenhocvien, gioitinh, loaigiong, capdo, sodienthoai, email, ngaysinh, diachi) values ('HV10424017', N'Đỗ Thị Hà', 1,'Soprano',2, '0987654326', 'dothiha@gmail.com', '06-06-1994', N'567 Hồ Gươm, Hà Nội')
insert into tblhocvien(mahocvien, tenhocvien, gioitinh, loaigiong, capdo, sodienthoai, email, ngaysinh, diachi) values ('HV00422018', N'Lương Văn Hải', 0,'Tenor',3, '0987654327', 'luongvanhai@gmail.com', '07-07-1992', N'789 Hai Bà Trưng, Hà Nội')
insert into tblhocvien(mahocvien, tenhocvien, gioitinh, loaigiong, capdo, sodienthoai, email, ngaysinh, diachi) values ('HV10423019', N'Mai Thị Hoa', 1,'Baritone',1, '0987654328', 'maithihoa@gmail.com', '08-08-1991', N'1010 Cầu Giấy, Hà Nội')
insert into tblhocvien(mahocvien, tenhocvien, gioitinh, loaigiong, capdo, sodienthoai, email, ngaysinh, diachi) values ('HV00422020', N'Vũ Văn Hùng', 0,'Bass',2, '0987654329', 'vuvanhung@gmail.com', '09-09-1990', N'1212 Trần Hưng Đạo, Hà Nội')
insert into tblhocvien(mahocvien, tenhocvien, gioitinh, loaigiong, capdo, sodienthoai, email, ngaysinh, diachi) values ('HV00524021', N'Trần Văn Sơn', 0, 'Alto',3,'0987654335', 'tranvanson@gmail.com', '03-03-1994', N'2323 Nguyễn Văn Linh, Hà Nội')
insert into tblhocvien(mahocvien, tenhocvien, gioitinh, loaigiong, capdo, sodienthoai, email, ngaysinh, diachi) values ('HV10523022', N'Lê Thị Tâm', 1, 'Soprano',1,'0987654336', 'lethitam@gmail.com', '04-04-1993', N'2525 Trần Phú, Hà Nội')
insert into tblhocvien(mahocvien, tenhocvien, gioitinh, loaigiong, capdo, sodienthoai, email, ngaysinh, diachi) values ('HV00522023', N'Hoàng Văn Tân', 0,'Tenor',2, '0987654337', 'hoangvantan@gmail.com', '05-05-1992', N'2727 Lê Trọng Tấn, Hà Nội')
insert into tblhocvien(mahocvien, tenhocvien, gioitinh, loaigiong, capdo, sodienthoai, email, ngaysinh, diachi) values ('HV10523024', N'Trần Thị Uyên', 1, 'Baritone',3, '0987654338', 'tranthiuyen@gmail.com', '06-06-1991', N'2929 Lý Thường Kiệt, Hà Nội')
insert into tblhocvien(mahocvien, tenhocvien, gioitinh, loaigiong, capdo, sodienthoai, email, ngaysinh, diachi) values ('HV00522025', N'Lê Văn Vũ', 0, 'Bass',1,'0987654339', 'levanvu@gmail.com', '07-07-1990', N'3131 Nguyễn Tri Phương, Hà Nội')

insert into tblbophan(mabophan, tenbophan) values ('BP01', N'Ban lãnh đạo')
insert into tblbophan(mabophan, tenbophan) values ('BP02', N'Bộ phận nhân sự')
insert into tblbophan(mabophan, tenbophan) values ('BP03', N'Bộ phận truyền thông')
insert into tblbophan(mabophan, tenbophan) values ('BP04', N'Bộ phận tài chính')
insert into tblbophan(mabophan, tenbophan) values ('BP05', N'Bộ phận điều phối tổ chức')
insert into tblbophan(mabophan, tenbophan) values ('BP06', N'Bộ phận đối ngoại')
insert into tblbophan(mabophan, tenbophan) values ('BP07', N'Bộ phận giáo viên chuyên môn')
insert into tblbophan(mabophan, tenbophan) values ('BP08', N'Bộ phận kỹ thuật âm thanh')

insert into tblnhanvien(manhanvien, tennhanvien, gioitinh, sodienthoai, ngaysinh, email, diachi, mabophan) values ('NV00178001', N'Nguyễn Tiến Quang', 0, '0956981966','04-15-1978','nguyentienquang@gmail.com',N'100 Láng Hạ, Đống Đa, Hà Nội','BP01')
insert into tblnhanvien(manhanvien, tennhanvien, gioitinh, sodienthoai, ngaysinh, email, diachi, mabophan) values ('NV10185002', N'Nguyễn Thị Mai', 1, '0987654321','03-20-1985','nguyenthimai@gmail.com',N'50 Lê Lợi, Hoàn Kiếm, Hà Nội','BP02')
insert into tblnhanvien(manhanvien, tennhanvien, gioitinh, sodienthoai, ngaysinh, email, diachi, mabophan) values ('NV00190003', N'Trần Văn An', 0, '0978123456','06-10-1990','tranvanan@gmail.com',N'200 Lê Thanh Nghị, Hai Bà Trưng, Hà Nội','BP03')
insert into tblnhanvien(manhanvien, tennhanvien, gioitinh, sodienthoai, ngaysinh, email, diachi, mabophan) values ('NV10182004', N'Lê Thị Hương', 1, '0912345678','01-05-1982','lethihuong@gmail.com',N'300 Hoàng Quốc Việt, Cầu Giấy, Hà Nội','BP04')
insert into tblnhanvien(manhanvien, tennhanvien, gioitinh, sodienthoai, ngaysinh, email, diachi, mabophan) values ('NV00187005', N'Phạm Văn Nam', 0, '0965432198','09-12-1987','phamvannam@gmail.com',N'150 Cầu Giấy, Cầu Giấy, Hà Nội','BP05')
insert into tblnhanvien(manhanvien, tennhanvien, gioitinh, sodienthoai, ngaysinh, email, diachi, mabophan) values ('NV10180006', N'Hoàng Thị Hà', 1, '0932109876','12-30-1980','hoangthiha@gmail.com',N'70 Láng Hạ, Đống Đa, Hà Nội','BP06')
insert into tblnhanvien(manhanvien, tennhanvien, gioitinh, sodienthoai, ngaysinh, email, diachi, mabophan) values ('NV00175007', N'Vũ Đức Tuấn', 0, '0946781234','07-25-1975','vuductuan@gmail.com',N'25 Hoàng Diệu, Ba Đình, Hà Nội','BP07')
insert into tblnhanvien(manhanvien, tennhanvien, gioitinh, sodienthoai, ngaysinh, email, diachi, mabophan) values ('NV10184008', N'Nguyễn Thanh Hương', 1, '0923456789','02-28-1984','nguyenthanhhuong@gmail.com',N'80 Lý Thường Kiệt, Hoàn Kiếm, Hà Nội','BP08')
insert into tblnhanvien(manhanvien, tennhanvien, gioitinh, sodienthoai, ngaysinh, email, diachi, mabophan) values ('NV00195009', N'Trần Đình Long', 0, '0987654321','05-18-1995','trandinhlong@gmail.com',N'90 Hai Bà Trưng, Hoàn Kiếm, Hà Nội','BP07')
insert into tblnhanvien(manhanvien, tennhanvien, gioitinh, sodienthoai, ngaysinh, email, diachi, mabophan) values ('NV10189010', N'Hoàng Thị Lan', 1, '0976543210','08-09-1989','hoangthilan@gmail.com',N'10 Cửa Nam, Hoàn Kiếm, Hà Nội','BP07')
insert into tblnhanvien(manhanvien, tennhanvien, gioitinh, sodienthoai, ngaysinh, email, diachi, mabophan) values ('NV00177011', N'Lê Văn Dũng', 0, '0912876543','11-01-1977','levandung@gmail.com',N'15 Láng Hạ, Đống Đa, Hà Nội','BP07')
insert into tblnhanvien(manhanvien, tennhanvien, gioitinh, sodienthoai, ngaysinh, email, diachi, mabophan) values ('NV10181012', N'Phạm Thị Thanh', 1, '0934567890','10-05-1981','phamthithanh@gmail.com',N'20 Hoàng Diệu, Ba Đình, Hà Nội','BP07')
insert into tblnhanvien(manhanvien, tennhanvien, gioitinh, sodienthoai, ngaysinh, email, diachi, mabophan) values ('NV00192013', N'Nguyễn Văn Tài', 0, '0956781234','03-15-1992','nguyenvantai@gmail.com',N'35 Hoàng Quốc Việt, Cầu Giấy, Hà Nội','BP02')
insert into tblnhanvien(manhanvien, tennhanvien, gioitinh, sodienthoai, ngaysinh, email, diachi, mabophan) values ('NV10186014', N'Trần Thị Thu', 1, '0945678901','06-20-1986','tranthithu@gmail.com',N'45 Lê Thanh Nghị, Hai Bà Trưng, Hà Nội','BP03')
insert into tblnhanvien(manhanvien, tennhanvien, gioitinh, sodienthoai, ngaysinh, email, diachi, mabophan) values ('NV00183015', N'Đỗ Văn Hùng', 0, '0923456789','09-25-1983','dovanhung@gmail.com',N'55 Cầu Giấy, Cầu Giấy, Hà Nội','BP06')

insert into tblphieughidanh(maphieu, ngaytiepnhan, manhanvien, mahocvien) values ('P001','12-20-2021','NV10185002','HV10122001')
insert into tblphieughidanh(maphieu, ngaytiepnhan, manhanvien, mahocvien) values ('P002','12-25-2022','NV10185002','HV10123002')
insert into tblphieughidanh(maphieu, ngaytiepnhan, manhanvien, mahocvien) values ('P003','12-22-2023','NV10185002','HV10124003')
insert into tblphieughidanh(maphieu, ngaytiepnhan, manhanvien, mahocvien) values ('P004','12-23-2022','NV10185002','HV00123004')
insert into tblphieughidanh(maphieu, ngaytiepnhan, manhanvien, mahocvien) values ('P005','12-24-2023','NV10185002','HV10124005')
insert into tblphieughidanh(maphieu, ngaytiepnhan, manhanvien, mahocvien) values ('P006','12-20-2023','NV00192013','HV00224006')
insert into tblphieughidanh(maphieu, ngaytiepnhan, manhanvien, mahocvien) values ('P007','12-21-2022','NV00192013','HV00223007')
insert into tblphieughidanh(maphieu, ngaytiepnhan, manhanvien, mahocvien) values ('P008','12-20-2021','NV00192013','HV10222008')
insert into tblphieughidanh(maphieu, ngaytiepnhan, manhanvien, mahocvien) values ('P009','12-27-2023','NV00192013','HV00224009')
insert into tblphieughidanh(maphieu, ngaytiepnhan, manhanvien, mahocvien) values ('P010','12-20-2021','NV00192013','HV10222010')

insert into tblngaydanhgia(madanhgia, ngaydanhgia, tenkydanhgia, soluongmax) values ('N150622','06-15-2022',N'Đánh giá kỳ 1/2022',125)
insert into tblngaydanhgia(madanhgia, ngaydanhgia, tenkydanhgia, soluongmax) values ('N160622','06-16-2022',N'Đánh giá kỳ 1/2022',125)
insert into tblngaydanhgia(madanhgia, ngaydanhgia, tenkydanhgia, soluongmax) values ('N170622','06-17-2022',N'Đánh giá kỳ 1/2022',125)
insert into tblngaydanhgia(madanhgia, ngaydanhgia, tenkydanhgia, soluongmax) values ('N151222','12-15-2022',N'Đánh giá kỳ 2/2022',125)
insert into tblngaydanhgia(madanhgia, ngaydanhgia, tenkydanhgia, soluongmax) values ('N161222','12-16-2022',N'Đánh giá kỳ 2/2022',125)
insert into tblngaydanhgia(madanhgia, ngaydanhgia, tenkydanhgia, soluongmax) values ('N171222','12-17-2022',N'Đánh giá kỳ 2/2022',125)
insert into tblngaydanhgia(madanhgia, ngaydanhgia, tenkydanhgia, soluongmax) values ('N150623','06-15-2023',N'Đánh giá kỳ 1/2023',125)
insert into tblngaydanhgia(madanhgia, ngaydanhgia, tenkydanhgia, soluongmax) values ('N160623','06-16-2023',N'Đánh giá kỳ 1/2023',125)
insert into tblngaydanhgia(madanhgia, ngaydanhgia, tenkydanhgia, soluongmax) values ('N170623','06-17-2023',N'Đánh giá kỳ 1/2023',125)
insert into tblngaydanhgia(madanhgia, ngaydanhgia, tenkydanhgia, soluongmax) values ('N151223','12-15-2023',N'Đánh giá kỳ 2/2023',125)
insert into tblngaydanhgia(madanhgia, ngaydanhgia, tenkydanhgia, soluongmax) values ('N161223','12-16-2023',N'Đánh giá kỳ 2/2023',125)
insert into tblngaydanhgia(madanhgia, ngaydanhgia, tenkydanhgia, soluongmax) values ('N171223','12-17-2023',N'Đánh giá kỳ 2/2023',125)

insert into tbldondangkydanhgia(mahocvien, malophoc, madanhgia, ngaydangky, ketquadanhgia) values ('HV10122001','LH01','N150622','06-08-2022',N'Tốt')
insert into tbldondangkydanhgia(mahocvien, malophoc, madanhgia, ngaydangky, ketquadanhgia) values ('HV10122001','LH11','N151223','12-08-2023',N'Tốt')
insert into tbldondangkydanhgia(mahocvien, malophoc, madanhgia, ngaydangky, ketquadanhgia) values ('HV10123002','LH02','N160623','06-08-2023',N'Trung bình')
insert into tbldondangkydanhgia(mahocvien, malophoc, madanhgia, ngaydangky, ketquadanhgia) values ('HV00123004','LH04','N151222','12-08-2022',N'Không đạt')
insert into tbldondangkydanhgia(mahocvien, malophoc, madanhgia, ngaydangky, ketquadanhgia) values ('HV00123004','LH14','N150623','06-08-2023',N'Trung bình')
insert into tbldondangkydanhgia(mahocvien, malophoc, madanhgia, ngaydangky, ketquadanhgia) values ('HV00223007','LH04','N160623','06-08-2023',N'Tốt')
insert into tbldondangkydanhgia(mahocvien, malophoc, madanhgia, ngaydangky, ketquadanhgia) values ('HV10222008','LH08','N171222','12-08-2022',N'Trung bình')
insert into tbldondangkydanhgia(mahocvien, malophoc, madanhgia, ngaydangky, ketquadanhgia) values ('HV10222008','LH03','N151223','12-08-2023',N'Tốt')
insert into tbldondangkydanhgia(mahocvien, malophoc, madanhgia, ngaydangky, ketquadanhgia) values ('HV10222010','LH10','N170622','06-08-2022',N'Tốt')

insert into tblthamgia(mahocvien,malophoc) values ('HV10122001','LH01')
insert into tblthamgia(mahocvien,malophoc) values ('HV10122001','LH11')
insert into tblthamgia(mahocvien,malophoc) values ('HV10123002','LH02')
insert into tblthamgia(mahocvien,malophoc) values ('HV00123004','LH04')
insert into tblthamgia(mahocvien,malophoc) values ('HV00123004','LH14')
insert into tblthamgia(mahocvien,malophoc) values ('HV00223007','LH04')
insert into tblthamgia(mahocvien,malophoc) values ('HV10222008','LH08')
insert into tblthamgia(mahocvien,malophoc) values ('HV10222008','LH03')
insert into tblthamgia(mahocvien,malophoc) values ('HV10222010','LH10')

insert into tblhoadonmuatailieu(mahoadon,mahocvien,tongtien,ngaydangky,hinhthucnop,trangthainop,ngaynop) values ('B001','HV10122001',50000,'12-20-2021',N'Chuyển khoản',N'Đã nộp','12-20-2021')
insert into tblhoadonmuatailieu(mahoadon,mahocvien,tongtien,ngaydangky,hinhthucnop,trangthainop,ngaynop) values ('B002','HV10123002',60000,'12-25-2022',N'Nộp trực tiếp',N'Đã nộp','12-25-2022')
insert into tblhoadonmuatailieu(mahoadon,mahocvien,tongtien,ngaydangky,hinhthucnop,trangthainop,ngaynop) values ('B003','HV00123004',60000,'12-22-2023',N'Chuyển khoản',N'Đã nộp','12-22-2023')
insert into tblhoadonmuatailieu(mahoadon,mahocvien,tongtien,ngaydangky,hinhthucnop,trangthainop) values ('B004','HV00223007',70000,'05-15-2024',N'Nộp trực tiếp',N'Chưa nộp')
insert into tblhoadonmuatailieu(mahoadon,mahocvien,tongtien,ngaydangky,hinhthucnop,trangthainop) values ('B005','HV10222008',60000,'05-15-2024',N'Nộp trực tiếp',N'Chưa nộp')


insert into tblchitiethoadon(mahoadon,matailieu,soluong,dongia) values ('B001','TL0101',1,50000)
insert into tblchitiethoadon(mahoadon,matailieu,soluong,dongia) values ('B002','TL0202',1,60000)
insert into tblchitiethoadon(mahoadon,matailieu,soluong,dongia) values ('B003','TL0202',1,60000)
insert into tblchitiethoadon(mahoadon,matailieu,soluong,dongia) values ('B004','TL0303',1,70000)
insert into tblchitiethoadon(mahoadon,matailieu,soluong,dongia) values ('B005','TL0202',1,60000)

insert into tbltailieu(matailieu, tentailieu, mota, dongia) values ('TL0101',N'Giáo trình sơ cấp',N'Tài liệu dành cho học viên cấp độ 1',50000)
insert into tbltailieu(matailieu, tentailieu, mota, dongia) values ('TL0202',N'Giáo trình trung cấp',N'Tài liệu dành cho học viên cấp độ 2',60000)
insert into tbltailieu(matailieu, tentailieu, mota, dongia) values ('TL0303',N'Giáo trình chất lượng cao',N'Tài liệu dành cho học viên cấp độ 3',70000)

insert into tbllichgiangday(manhanvien, malophoc, lichday) values ('NV00175007','LH01',N'Thứ 2')
insert into tbllichgiangday(manhanvien, malophoc, lichday) values ('NV00195009','LH02',N'Thứ 3')
insert into tbllichgiangday(manhanvien, malophoc, lichday) values ('NV10189010','LH03',N'Thứ 4')
insert into tbllichgiangday(manhanvien, malophoc, lichday) values ('NV00177011','LH04',N'Thứ 5')
insert into tbllichgiangday(manhanvien, malophoc, lichday) values ('NV10181012','LH05',N'Thứ 6')
insert into tbllichgiangday(manhanvien, malophoc, lichday) values ('NV00175007','LH06',N'Thứ 2')
insert into tbllichgiangday(manhanvien, malophoc, lichday) values ('NV00195009','LH07',N'Thứ 3')
insert into tbllichgiangday(manhanvien, malophoc, lichday) values ('NV10189010','LH08',N'Thứ 4')
insert into tbllichgiangday(manhanvien, malophoc, lichday) values ('NV00177011','LH09',N'Thứ 5')
insert into tbllichgiangday(manhanvien, malophoc, lichday) values ('NV10181012','LH10',N'Thứ 6')
insert into tbllichgiangday(manhanvien, malophoc, lichday) values ('NV00175007','LH11',N'Thứ 2')
insert into tbllichgiangday(manhanvien, malophoc, lichday) values ('NV00195009','LH12',N'Thứ 3')
insert into tbllichgiangday(manhanvien, malophoc, lichday) values ('NV10189010','LH13',N'Thứ 4')
insert into tbllichgiangday(manhanvien, malophoc, lichday) values ('NV00177011','LH14',N'Thứ 5')
insert into tbllichgiangday(manhanvien, malophoc, lichday) values ('NV10181012','LH15',N'Thứ 6')

insert into tblthongbao(mathongbao,tieude,noidung,ngaydang,manhanvien) values('TB050623',N'Thông báo đăng ký ngày đánh giá kỳ 1/2023',N'Học viên đăng ký ngày đánh giá kỳ 1/2023','06-05-2023', 'NV10185002')
insert into tblthongbao(mathongbao,tieude,noidung,ngaydang,manhanvien)  values('TB051223',N'Thông báo đăng ký ngày đánh giá kỳ 2/2023',N'Học viên đăng ký ngày đánh giá kỳ 2/2023', '12-05-2023','NV10185002')
insert into tblthongbao(mathongbao,tieude,noidung,ngaydang,manhanvien)  values('TB100124',N'Thông báo đăng ký mua tài liệu kỳ 1/2024',N'Học viên đăng ký ngày đánh giá kỳ 1/2024', '01-10-2024','NV00192013')

insert into tblsukien(masukien, tensukien,ngaybatdau,ngayketthuc,diadiemtochuc) values('SK001',N'Vòng tròn màu Xanh – The Circle of Green 2023','10-28-2023','10-29-2023',N'Học Viện Âm Nhạc Quốc Gia Việt Nam')
insert into tblsukien(masukien, tensukien,ngaybatdau,ngayketthuc,diadiemtochuc) values('SK002',N'Việt Nam thương mến – Loving Vietnam 2024','04-19-2024','04-20-2024',N'Học Viện Âm Nhạc Quốc Gia Việt Nam')
insert into tblsukien(masukien, tensukien,ngaybatdau,ngayketthuc,diadiemtochuc) values('SK003',N'Những thành phố mơ màng','05-19-2024','05-19-2024',N'Cung Điền Kinh Mỹ Đình')

insert into tbltrangthietbi(matrangthietbi,tentrangthietbi) values('E001',N'Màn hình LED p3.91')
insert into tbltrangthietbi(matrangthietbi,tentrangthietbi) values('E002',N'Đèn Par LED ')
insert into tbltrangthietbi(matrangthietbi,tentrangthietbi) values('E003',N'Kinos LED')
insert into tbltrangthietbi(matrangthietbi,tentrangthietbi) values('E004',N'Loa JBL full')
insert into tbltrangthietbi(matrangthietbi,tentrangthietbi) values('E005',N'Loa JBL sub')

insert into tblnhacungcap(mancc,tenncc,diachi,masothue,sodienthoai,email) values('NCC001',N'Sen Xanh Event',N'R201 , Tầng 2 ,Tòa nhà Hancic 46, số 230 Lạc Trung, Hai Bà Trưng, Hà Nội','8328228320','0974468391','senxanhevent@gmail.com')
insert into tblnhacungcap(mancc,tenncc,diachi,masothue,sodienthoai,email) values('NCC002',N'Hòa Bình Event',N'27-29 Đoàn Thị Điểm, Quốc Tử Giám, Đống Đa, Hà Nội','8328228347','0939311911','info@hoabinhevents.com')
insert into tblnhacungcap(mancc,tenncc,diachi,masothue,sodienthoai,email) values('NCC003',N'Sao Việt Event',N'Liền kề 26 ô số 36, Khu Đô Thị Văn Phú – P.Phú La – Q.Hà Đông – TP. Hà Nội','8328856498','0969701986','saovietevent2022@gmail.com')

insert into tblnhataitro(mantt,tenntt,diachi,masothue,sodienthoai,email,trangthai) values('TT001','Vietcombank',N'198 Trần Quang Khải, Hoàn Kiếm, Hà Nội','0100112437','0243824352','contact@vcb.vn',N'Chính thức')
insert into tblnhataitro(mantt,tenntt,diachi,masothue,sodienthoai,email,trangthai) values('TT002','VietinBank',N'108 Trần Hưng Đạo, quận Hoàn Kiếm, TP. Hà Nội, Việt Nam','0100111948','1900558868','contact@vietinbank.vn',N'Chính thức')
insert into tblnhataitro(mantt,tenntt,diachi,masothue,sodienthoai,email,trangthai) values('TT003','TPBank',N'Tòa nhà TPBank, 57 Lý Thường Kiệt, Quận Hoàn Kiếm, Hà Nội','0102744865','0243768368','dichvu_khachhang@tpb.com.vn',N'Chính thức')
insert into tblnhataitro(mantt,tenntt,diachi,masothue,sodienthoai,email,trangthai) values('TT004','Techcombank',N'123 Hoàn Kiếm, Hà Nội','0102756656','0575757574','dichvu_khachhang@tech.com.vn',N'Tiềm năng')

insert into tblnhantaitro(mantt,masukien,ngaynhan,trangthainhantaitro) values('TT001','SK001','09-20-2023',N'Đã nhận')
insert into tblnhantaitro(mantt,masukien,ngaynhan,trangthainhantaitro) values('TT002','SK002','09-25-2023',N'Đã nhận')
insert into tblnhantaitro(mantt,masukien,ngaynhan,trangthainhantaitro) values('TT003','SK001','03-20-2024',N'Đã nhận')
insert into tblnhantaitro(mantt,masukien,ngaynhan,trangthainhantaitro) values('TT001','SK002','03-25-2024',N'Đã nhận')
insert into tblnhantaitro(mantt,masukien,trangthainhantaitro) values('TT002','SK003',N'Chưa nhận')
insert into tblnhantaitro(mantt,masukien,trangthainhantaitro) values('TT004','SK003',N'Chưa nhận')

insert into tblhopdongthue(mahopdong,mancc,manhanvien,masukien,ngaylap,trangthai)values('HD001','NCC001','NV10180006','SK001','10-20-2023',N'Đã duyệt')
insert into tblhopdongthue(mahopdong,mancc,manhanvien,masukien,ngaylap,trangthai)values('HD002','NCC002','NV10180006','SK001','10-20-2023',N'Đã duyệt')
insert into tblhopdongthue(mahopdong,mancc,manhanvien,masukien,ngaylap,trangthai)values('HD003','NCC001','NV00183015','SK002','04-10-2024',N'Đã duyệt')
insert into tblhopdongthue(mahopdong,mancc,manhanvien,masukien,ngaylap,trangthai)values('HD004','NCC002','NV00183015','SK003','04-10-2024',N'Đã duyệt')
insert into tblhopdongthue(mahopdong,mancc,manhanvien,masukien,ngaylap,trangthai)values('HD005','NCC003','NV00183015','SK003','04-20-2024',N'Chưa duyệt')

insert into tblchitiethopdong(mahopdong,matrangthietbi,soluong,dongia,ngaythue,ngaytra) values('HD001','E001',1,2000000,'09-20-2023','09-30-2023')
insert into tblchitiethopdong(mahopdong,matrangthietbi,soluong,dongia,ngaythue,ngaytra)  values('HD001','E002',5,2500000,'09-20-2023','09-30-2023')
insert into tblchitiethopdong(mahopdong,matrangthietbi,soluong,dongia,ngaythue,ngaytra)  values('HD002','E003',3,2400000,'10-25-2023','11-21-2023')
insert into tblchitiethopdong(mahopdong,matrangthietbi,soluong,dongia,ngaythue,ngaytra)  values('HD003','E002',3,2500000,'04-25-2024','05-01-2024')
insert into tblchitiethopdong(mahopdong,matrangthietbi,soluong,dongia,ngaythue,ngaytra)  values('HD004','E004',2,2000000,'04-25-2024','05-01-2024')
insert into tblchitiethopdong(mahopdong,matrangthietbi,soluong,dongia,ngaythue,ngaytra)  values('HD005','E005',2,2000000,'04-25-2024','05-10-2024')

insert into tblphieuchi(maphieuchi,masukien,manhanvien,trangthai) values('PC001','SK001','NV10182004',N'Đã duyệt')
insert into tblphieuchi(maphieuchi,masukien,manhanvien,trangthai) values('PC002','SK002','NV10182004',N'Đã duyệt')
insert into tblphieuchi(maphieuchi,masukien,manhanvien,trangthai) values('PC003','SK003','NV10182004',N'Chưa duyệt')

insert into tblbaocaonghiemthu(mabaocao,masukien,mantt,manhanvien,noidung) values('BC001','SK001','TT001','NV00187005',N'Báo cáo nghiệm thu sự kiện Vòng tròn màu Xanh từ Vietcombank')
insert into tblbaocaonghiemthu(mabaocao,masukien,mantt,manhanvien,noidung) values('BC002','SK001','TT002','NV00187005',N'Báo cáo nghiệm thu sự kiện Vòng tròn màu Xanh từ VietinBank')
insert into tblbaocaonghiemthu(mabaocao,masukien,mantt,manhanvien,noidung) values('BC003','SK002','TT003','NV00187005',N'Báo cáo nghiệm thu sự kiện Việt Nam thương mến từ TPBank')
insert into tblbaocaonghiemthu(mabaocao,masukien,mantt,manhanvien,noidung) values('BC004','SK003','TT004','NV00187005',N'Báo cáo nghiệm thu sự kiện Những thành phố mơ màng từ Techcombank')

insert into tblcungcaptrangthietbi(mancc,matrangthietbi) values ('NCC001','E001')
insert into tblcungcaptrangthietbi(mancc,matrangthietbi) values ('NCC001','E002')
insert into tblcungcaptrangthietbi(mancc,matrangthietbi) values ('NCC002','E003')
insert into tblcungcaptrangthietbi(mancc,matrangthietbi) values ('NCC002','E004')
insert into tblcungcaptrangthietbi(mancc,matrangthietbi) values ('NCC003','E005')


