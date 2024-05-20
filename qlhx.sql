create database QLhopxuong
go

use QLhopxuong

create table tblbophan(
	mabophan char(4) primary key,
	tenbophan nvarchar(50) not null) 

create table tblnhanvien(
	manhanvien char(10) primary key,
	tennhanvien nvarchar(50) not null,
	gioitinh bit,
	sodienthoai char(10) not null,
	ngaysinh date not null,
	email nvarchar(50) not null,
	diachi nvarchar(100),
	mabophan char(4) foreign key references tblbophan(mabophan))

create table tbllophoc(
	malophoc char(4) primary key,
	tenlophoc nvarchar(20) not null,
	capdo int not null,
	loaigiong nvarchar(10) not null,
	phonghoc char(3) not null,
	ngaybatdau date,
	check(ngaybatdau<ngayketthuc),
	ngayketthuc date)

create table tblhocvien(
	mahocvien char(10) primary key,
	tenhocvien nvarchar(50) not null,
	loaigiong nvarchar(15) not null,
	capdo int not null,
	gioitinh bit,
	sodienthoai char(10) not null,
	email char(50) not null,
	ngaysinh date not null,
	diachi nvarchar(100),
	malophoc char(4) foreign key references tbllophoc(malophoc))

create table tblphieughidanh(
	maphieu char(10) primary key,
	ngaytiepnhan date not null,
	manhanvien char(10) foreign key references tblnhanvien(manhanvien),
	mahocvien char(10) foreign key references tblhocvien(mahocvien))

create table tblngaydanhgia(
	madanhgia char(10) primary key,
	ngaythi date not null,
	tenkythi nvarchar(20),
	soluongmax int check (soluongmax>0) not null)

create table tbldondangkydanhgia(
	mahocvien char(10),
	madanhgia char(10),
	primary key (mahocvien, madanhgia),
	ngaydangky date not null,
	ketquadanhgia nvarchar(50))

create table tblhoadonmuatailieu(
	mahoadon char(4),
	mahocvien char(10),
	primary key (mahocvien,mahoadon),
	tongtien float not null check (tongtien>0),
	ngaydangky date not null,
	trangthai nvarchar(20),
	ngaynop date,
	minhchung nvarchar(200))

create table tblchitiethoadon(
	mahoadon char(4),
	matailieu char(10),
	primary key (matailieu,mahoadon),
	soluong int check(soluong>0),
	thanhtien float check(thanhtien>0))

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
	ngaygui date not null,
	manhanvien char(10) foreign key references tblnhanvien(manhanvien))

create table tblsukien(
	masukien char(6) primary key,
	tensukien nvarchar(100) not null,
	ngaybatdau date not null,
	ngayketthuc date not null,
	check(ngaybatdau<ngayketthuc),
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
trangthai nvarchar(50) not null)

create table tblnhantaitro(
	mantt char(5),
	masukien char(6),
	primary key(mantt,masukien),
	ngaynhan date not null,
	trangthainhantaitro nvarchar(20))

create table tblphieuchi(
	maphieuchi char(5) primary key,
	masukien char(6) foreign key references tblsukien(masukien),
	manhanvien char(10) foreign key references tblnhanvien(manhanvien),
	sotien float not null check(sotien>0),
	trangthai nvarchar(50))

create table tblhopdongthue(
	mahopdong char(5) primary key,
	mancc char(6) foreign key references tblnhacungcap(mancc),
	masukien char(6) foreign key references tblsukien(masukien),
	manhanvien char(10) foreign key references tblnhanvien(manhanvien),
	ngaylap date not null,
	trangthaixetduyet nvarchar(50))
	

create table tblchitiethopdong(
	mahopdong char(5) primary key,
	matrangthietbi char(4) foreign key references tbltrangthietbi(matrangthietbi),
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

insert into tbllophoc(malophoc, tenlophoc, capdo, loaigiong, phonghoc, ngaybatdau, ngayketthuc) values ('LH01',N'Lớp Alto 1',1,'Alto','A01','01-15-2024','05-15-2024')
insert into tbllophoc(malophoc, tenlophoc, capdo, loaigiong, phonghoc, ngaybatdau, ngayketthuc) values ('LH02',N'Lớp Soprano 2',2,'Soprano','A02','01-16-2024','05-16-2024')
insert into tbllophoc(malophoc, tenlophoc, capdo, loaigiong, phonghoc, ngaybatdau, ngayketthuc) values ('LH03',N'Lớp Tenor 3',3,'Tenor','A03','01-17-2024','05-17-2024')
insert into tbllophoc(malophoc, tenlophoc, capdo, loaigiong, phonghoc, ngaybatdau, ngayketthuc) values ('LH04',N'Lớp Baritone 1',1,'Baritone','A04','01-07-2024','05-07-2024')
insert into tbllophoc(malophoc, tenlophoc, capdo, loaigiong, phonghoc, ngaybatdau, ngayketthuc) values ('LH05',N'Lớp Bass 2',2,'Bass','A05','01-08-2024','05-08-2024')
insert into tbllophoc(malophoc, tenlophoc, capdo, loaigiong, phonghoc, ngaybatdau, ngayketthuc) values ('LH06',N'Lớp Alto 3',3,'Alto','A01','01-09-2024','05-09-2024')
insert into tbllophoc(malophoc, tenlophoc, capdo, loaigiong, phonghoc, ngaybatdau, ngayketthuc) values ('LH07',N'Lớp Soprano 1',1,'Soprano','A02','01-10-2024','05-10-2024')
insert into tbllophoc(malophoc, tenlophoc, capdo, loaigiong, phonghoc, ngaybatdau, ngayketthuc) values ('LH08',N'Lớp Tenor 2',2,'Tenor','A03','01-11-2024','05-11-2024')
insert into tbllophoc(malophoc, tenlophoc, capdo, loaigiong, phonghoc, ngaybatdau, ngayketthuc) values ('LH09',N'Lớp Baritone 3',3,'Baritone','A04','01-12-2024','05-12-2024')
insert into tbllophoc(malophoc, tenlophoc, capdo, loaigiong, phonghoc, ngaybatdau, ngayketthuc) values ('LH10',N'Lớp Bass 1',1,'Bass','A05','01-13-2024','05-13-2024')
insert into tbllophoc(malophoc, tenlophoc, capdo, loaigiong, phonghoc, ngaybatdau, ngayketthuc) values ('LH11',N'Lớp Alto 2',2,'Alto','A01','01-14-2024','05-14-2024')
insert into tbllophoc(malophoc, tenlophoc, capdo, loaigiong, phonghoc, ngaybatdau, ngayketthuc) values ('LH12',N'Lớp Soprano 3',3,'Soprano','A02','01-06-2024','05-06-2024')
insert into tbllophoc(malophoc, tenlophoc, capdo, loaigiong, phonghoc, ngaybatdau, ngayketthuc) values ('LH13',N'Lớp Tenor 1',1,'Tenor','A03','01-05-2024','05-05-2024')
insert into tbllophoc(malophoc, tenlophoc, capdo, loaigiong, phonghoc, ngaybatdau, ngayketthuc) values ('LH14',N'Lớp Baritone 2',2,'Baritone','A04','01-04-2024','05-04-2024')
insert into tbllophoc(malophoc, tenlophoc, capdo, loaigiong, phonghoc, ngaybatdau, ngayketthuc) values ('LH15',N'Lớp Bass 3',3,'Bass','A05','01-03-2024','05-03-2024')
insert into tbllophoc(malophoc, tenlophoc) values ('LH16',N'Lớp học viên mới')

insert into tblhocvien(mahocvien, tenhocvien, gioitinh, loaigiong, capdo, sodienthoai, email, ngaysinh, diachi, malophoc) values ('HV10122001', N'Nguyễn Thị Hồng', 1, 'Alto', 1, '0987654321', 'nguyenthihong@gmail.com', '01-01-1988', N'123 Đường Láng, Quận Đống Đa, Hà Nội','LH01')
insert into tblhocvien(mahocvien, tenhocvien, gioitinh, loaigiong, capdo, sodienthoai, email, ngaysinh, diachi, malophoc) values ('HV10123002', N'Đỗ Văn Oanh', 1,'Soprano',2, '0987654334', 'dovanoanh@gmail.com', '02-14-1987', N'123 Đường Trần Phú, Quận Ba Đình, Hà Nội','LH02')
insert into tblhocvien(mahocvien, tenhocvien, gioitinh, loaigiong, capdo, sodienthoai, email, ngaysinh, diachi, malophoc) values ('HV10124003', N'Hoàng Thị Phương', 1, 'Tenor',3,'0987654335', 'hoangthiphuong@gmail.com', '03-15-1986', N'456 Đường Kim Mã, Quận Ba Đình, Hà Nội','LH03')
insert into tblhocvien(mahocvien, tenhocvien, gioitinh, loaigiong, capdo, sodienthoai, email, ngaysinh, diachi, malophoc) values ('HV00123004', N'Trần Văn Quân', 0,'Baritone',1, '0987654336', 'tranvanquan@gmail.com', '04-12-1985', N'789 Đường Đội Cấn, Quận Ba Đình, Hà Nội','LH04')
insert into tblhocvien(mahocvien, tenhocvien, gioitinh, loaigiong, capdo, sodienthoai, email, ngaysinh, diachi, malophoc) values ('HV10124005', N'Nguyễn Thị Ngọc', 1, 'Bass',2, '0987654337', 'nguyenthingoc@gmail.com', '07-05-1984', N'101 Đường Nguyễn Chí Thanh, Quận Đống Đa, Hà Nội','LH05')
insert into tblhocvien(mahocvien, tenhocvien, gioitinh, loaigiong, capdo, sodienthoai, email, ngaysinh, diachi, malophoc) values ('HV00224006', N'Trần Thị Sáng', 0,'Alto',3, '0987654343', 'tranthisang@gmail.com', '03-11-1978', N'666 Đường Hồ Tùng Mậu, Quận Cầu Giấy, Hà Nội','LH06')
insert into tblhocvien(mahocvien, tenhocvien, gioitinh, loaigiong, capdo, sodienthoai, email, ngaysinh, diachi, malophoc) values ('HV00223007', N'Nguyễn Văn Tâm', 0,'Soprano',1, '0987654344', 'nguyenvantam@gmail.com', '04-12-1977', N'777 Đường Lê Đức Thọ, Quận Nam Từ Liêm, Hà Nội','LH07')
insert into tblhocvien(mahocvien, tenhocvien, gioitinh, loaigiong, capdo, sodienthoai, email, ngaysinh, diachi, malophoc) values ('HV10222008', N'Hoàng Thị Út', 1, 'Tenor',2, '0987654345', 'hoangthiut@gmail.com', '05-01-1976', N'888 Đường Nguyễn Xiển, Quận Thanh Xuân, Hà Nội','LH08')
insert into tblhocvien(mahocvien, tenhocvien, gioitinh, loaigiong, capdo, sodienthoai, email, ngaysinh, diachi, malophoc) values ('HV00224009', N'Vũ Văn Vượng', 0, 'Baritone',3,'0987654346', 'vuvanvuong@gmail.com', '06-02-1975', N'999 Đường Nguyễn Trãi, Quận Thanh Xuân, Hà Nội','LH09')
insert into tblhocvien(mahocvien, tenhocvien, gioitinh, loaigiong, capdo, sodienthoai, email, ngaysinh, diachi, malophoc) values ('HV10222010', N'Lê Thị sinh', 1, 'Bass',1,'0987654347', 'lethisinh@gmail.com', '07-03-1974', N'101 Đường Lê Thanh Nghị, Quận Hai Bà Trưng, Hà Nội','LH10')
insert into tblhocvien(mahocvien, tenhocvien, gioitinh, loaigiong, capdo, sodienthoai, email, ngaysinh, diachi, malophoc) values ('HV00322011', N'Hồ Văn Nam', 0,'Alto',2, '0987654375', 'hovannam@gmail.com', '11-05-2000', N'18 Hoàng Cầu, Đống Đa, Hà Nội','LH11')
insert into tblhocvien(mahocvien, tenhocvien, gioitinh, loaigiong, capdo, sodienthoai, email, ngaysinh, diachi, malophoc) values ('HV10323012', N'Trần Thị Oanh', 1,'Soprano',3, '0987654376', 'tranthioanh@gmail.com', '12-06-2001', N'63 Đội Cấn, Ba Đình, Hà Nội','LH12')
insert into tblhocvien(mahocvien, tenhocvien, gioitinh, loaigiong, capdo, sodienthoai, email, ngaysinh, diachi, malophoc) values ('HV00323013', N'Mai Văn Phong', 0,'Tenor',1, '0987654377', 'maivanphong@gmail.com', '07-07-2002', N'88 Quán Thánh, Ba Đình, Hà Nội','LH13')
insert into tblhocvien(mahocvien, tenhocvien, gioitinh, loaigiong, capdo, sodienthoai, email, ngaysinh, diachi, malophoc) values ('HV10322014', N'Đinh Thị Quyên', 1,'Baritone',2, '0987654378', 'dinhthiquyen@gmail.com', '08-12-2003', N'17 Tràng Thi, Hoàn Kiếm, Hà Nội','LH14')
insert into tblhocvien(mahocvien, tenhocvien, gioitinh, loaigiong, capdo, sodienthoai, email, ngaysinh, diachi, malophoc) values ('HV00323015', N'Lương Văn Long', 0, 'Bass',3,'0987654379', 'luongvanlong@gmail.com', '12-09-2004', N'45 Tây Sơn, Đống Đa, Hà Nội','LH15')
insert into tblhocvien(mahocvien, tenhocvien, gioitinh, loaigiong, capdo, sodienthoai, email, ngaysinh, diachi, malophoc) values ('HV00424016', N'Phạm Văn Đức', 0, 'Alto', 1,'0987654325', 'phamvanduc@gmail.com', '05-05-1999', N'234 Lê Lợi, Hà Nội','LH16')
insert into tblhocvien(mahocvien, tenhocvien, gioitinh, loaigiong, capdo, sodienthoai, email, ngaysinh, diachi, malophoc) values ('HV10424017', N'Đỗ Thị Hà', 1,'Soprano',2, '0987654326', 'dothiha@gmail.com', '06-06-1994', N'567 Hồ Gươm, Hà Nội','LH16')
insert into tblhocvien(mahocvien, tenhocvien, gioitinh, loaigiong, capdo, sodienthoai, email, ngaysinh, diachi, malophoc) values ('HV00422018', N'Lương Văn Hải', 0,'Tenor',3, '0987654327', 'luongvanhai@gmail.com', '07-07-1992', N'789 Hai Bà Trưng, Hà Nội','LH01')
insert into tblhocvien(mahocvien, tenhocvien, gioitinh, loaigiong, capdo, sodienthoai, email, ngaysinh, diachi, malophoc) values ('HV10423019', N'Mai Thị Hoa', 1,'Baritone',1, '0987654328', 'maithihoa@gmail.com', '08-08-1991', N'1010 Cầu Giấy, Hà Nội','LH02')
insert into tblhocvien(mahocvien, tenhocvien, gioitinh, loaigiong, capdo, sodienthoai, email, ngaysinh, diachi, malophoc) values ('HV00422020', N'Vũ Văn Hùng', 0,'Bass',2, '0987654329', 'vuvanhung@gmail.com', '09-09-1990', N'1212 Trần Hưng Đạo, Hà Nội','LH03')
insert into tblhocvien(mahocvien, tenhocvien, gioitinh, loaigiong, capdo, sodienthoai, email, ngaysinh, diachi, malophoc) values ('HV00524021', N'Trần Văn Sơn', 0, 'Alto',3,'0987654335', 'tranvanson@gmail.com', '03-03-1994', N'2323 Nguyễn Văn Linh, Hà Nội','LH04')
insert into tblhocvien(mahocvien, tenhocvien, gioitinh, loaigiong, capdo, sodienthoai, email, ngaysinh, diachi, malophoc) values ('HV10523022', N'Lê Thị Tâm', 1, 'Soprano',1,'0987654336', 'lethitam@gmail.com', '04-04-1993', N'2525 Trần Phú, Hà Nội','LH05')
insert into tblhocvien(mahocvien, tenhocvien, gioitinh, loaigiong, capdo, sodienthoai, email, ngaysinh, diachi, malophoc) values ('HV00522023', N'Hoàng Văn Tân', 0,'Tenor',2, '0987654337', 'hoangvantan@gmail.com', '05-05-1992', N'2727 Lê Trọng Tấn, Hà Nội','LH06')
insert into tblhocvien(mahocvien, tenhocvien, gioitinh, loaigiong, capdo, sodienthoai, email, ngaysinh, diachi, malophoc) values ('HV10523024', N'Trần Thị Uyên', 1, 'Baritone',3, '0987654338', 'tranthiuyen@gmail.com', '06-06-1991', N'2929 Lý Thường Kiệt, Hà Nội','LH07')
insert into tblhocvien(mahocvien, tenhocvien, gioitinh, loaigiong, capdo, sodienthoai, email, ngaysinh, diachi, malophoc) values ('HV00522025', N'Lê Văn Vũ', 0, 'Bass',1,'0987654339', 'levanvu@gmail.com', '07-07-1990', N'3131 Nguyễn Tri Phương, Hà Nội','LH08')

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
insert into tblnhanvien(manhanvien, tennhanvien, gioitinh, sodienthoai, ngaysinh, email, diachi, mabophan) values ('NV00183015', N'Đỗ Văn Hùng', 0, '0923456789','09-25-1983','dovanhung@gmail.com',N'55 Cầu Giấy, Cầu Giấy, Hà Nội','BP04')

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

insert into tblngaydanhgia(madanhgia, ngaythi, tenkythi, soluongmax) values ('N150622','06-15-2022',N'Đánh giá kỳ 1/2022',50)
insert into tblngaydanhgia(madanhgia, ngaythi, tenkythi, soluongmax) values ('N160622','06-16-2022',N'Đánh giá kỳ 1/2022',50)
insert into tblngaydanhgia(madanhgia, ngaythi, tenkythi, soluongmax) values ('N170622','06-17-2022',N'Đánh giá kỳ 1/2022',50)
insert into tblngaydanhgia(madanhgia, ngaythi, tenkythi, soluongmax) values ('N151222','12-15-2022',N'Đánh giá kỳ 2/2022',50)
insert into tblngaydanhgia(madanhgia, ngaythi, tenkythi, soluongmax) values ('N161222','12-16-2022',N'Đánh giá kỳ 2/2022',50)
insert into tblngaydanhgia(madanhgia, ngaythi, tenkythi, soluongmax) values ('N171222','12-17-2022',N'Đánh giá kỳ 2/2022',50)
insert into tblngaydanhgia(madanhgia, ngaythi, tenkythi, soluongmax) values ('N150623','06-15-2023',N'Đánh giá kỳ 1/2023',50)
insert into tblngaydanhgia(madanhgia, ngaythi, tenkythi, soluongmax) values ('N160623','06-16-2023',N'Đánh giá kỳ 1/2023',50)
insert into tblngaydanhgia(madanhgia, ngaythi, tenkythi, soluongmax) values ('N170623','06-17-2023',N'Đánh giá kỳ 1/2023',50)
insert into tblngaydanhgia(madanhgia, ngaythi, tenkythi, soluongmax) values ('N151223','12-15-2023',N'Đánh giá kỳ 2/2023',50)
insert into tblngaydanhgia(madanhgia, ngaythi, tenkythi, soluongmax) values ('N161223','12-16-2023',N'Đánh giá kỳ 2/2023',50)
insert into tblngaydanhgia(madanhgia, ngaythi, tenkythi, soluongmax) values ('N171223','12-17-2023',N'Đánh giá kỳ 2/2023',50)

insert into tbldondangkydanhgia(mahocvien, madanhgia, ngaydangky, ketquadanhgia) values ('HV10122001','N150622','06-08-2022',N'Tốt')
insert into tbldondangkydanhgia(mahocvien, madanhgia, ngaydangky, ketquadanhgia)values ('HV10123002','N160623','06-08-2023',N'Trung bình')
insert into tbldondangkydanhgia(mahocvien, madanhgia, ngaydangky, ketquadanhgia)values ('HV00123004','N151223','12-08-2023',N'Không đạt')
insert into tbldondangkydanhgia(mahocvien, madanhgia, ngaydangky, ketquadanhgia)values ('HV00223007','N160623','06-08-2023',N'Tốt')
insert into tbldondangkydanhgia(mahocvien, madanhgia, ngaydangky, ketquadanhgia)values ('HV10222008','N171222','12-08-2022',N'Trung bình')
insert into tbldondangkydanhgia(mahocvien, madanhgia, ngaydangky, ketquadanhgia)values ('HV10222010','N170622','06-08-2022',N'Tốt')

insert into tblhoadonmuatailieu(mahoadon,mahocvien,tongtien,trangthai,ngaydangky,ngaynop) values ('B001','HV10122001',50000,N'Đã thanh toán','12-20-2021','12-20-2021')
insert into tblhoadonmuatailieu(mahoadon,mahocvien,tongtien,trangthai,ngaydangky,ngaynop) values ('B002','HV10123002',60000,N'Đã thanh toán','12-25-2022','12-25-2022')
insert into tblhoadonmuatailieu(mahoadon,mahocvien,tongtien,trangthai,ngaydangky) values ('B003','HV00123004',60000,N'Đã thanh toán','12-22-2024')
insert into tblhoadonmuatailieu(mahoadon,mahocvien,tongtien,trangthai,ngaydangky,ngaynop) values ('B004','HV00223007',70000,N'Đã thanh toán','12-23-2022','12-23-2022')
insert into tblhoadonmuatailieu(mahoadon,mahocvien,tongtien,trangthai,ngaydangky) values ('B005','HV10222008',60000,N'Đã thanh toán','12-24-2023')

insert into tblchitiethoadon(mahoadon,matailieu,soluong,thanhtien) values ('B001','TL0101',1,50000)
insert into tblchitiethoadon(mahoadon,matailieu,soluong,thanhtien) values ('B002','TL0202',1,60000)
insert into tblchitiethoadon(mahoadon,matailieu,soluong,thanhtien) values ('B003','TL0202',1,60000)
insert into tblchitiethoadon(mahoadon,matailieu,soluong,thanhtien) values ('B004','TL0303',1,70000)
insert into tblchitiethoadon(mahoadon,matailieu,soluong,thanhtien) values ('B005','TL0202',1,60000)

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

insert into tblthongbao(mathongbao,tieude,noidung,ngaygui,manhanvien) values('TB050623',N'Thông báo đăng ký ngày đánh giá kỳ 1/2023',N'Học viên đăng ký ngày đánh giá kỳ 1/2023','06-05-2023', 'NV10185002')
insert into tblthongbao(mathongbao,tieude,noidung,ngaygui,manhanvien)  values('TB051223',N'Thông báo đăng ký ngày đánh giá kỳ 2/2023',N'Học viên đăng ký ngày đánh giá kỳ 2/2023', '12-05-2023','NV10185002')
insert into tblthongbao(mathongbao,tieude,noidung,ngaygui,manhanvien)  values('TB100124',N'Thông báo đăng ký mua tài liệu kỳ 1/2024',N'Học viên đăng ký ngày đánh giá kỳ 1/2024', '01-10-2024','NV00192013')

insert into tblsukien(masukien, tensukien,ngaybatdau,ngayketthuc,diadiemtochuc) values('SK001',N'Vòng tròn màu Xanh – The Circle of Green 2023','10-28-2023','10-29-2023',N'Học Viện Âm Nhạc Quốc Gia Việt Nam')
insert into tblsukien(masukien, tensukien,ngaybatdau,ngayketthuc,diadiemtochuc) values('SK002',N'Việt Nam thương mến – Loving Vietnam 2024','04-19-2024','04-20-2024',N'Học Viện Âm Nhạc Quốc Gia Việt Nam')

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
insert into tblnhataitro(mantt,tenntt,diachi,masothue,sodienthoai,email,trangthai) values('TT004','Techcombank',N'123 Hoàn Kiếm, Hà Nội','0102756656','057575757469','dichvu_khachhang@tech.com.vn',N'Tiềm năng')	 

insert into tblnhantaitro(mantt,masukien,ngaynhan,trangthainhantaitro) values('TT001','SK001','09-20-2023',N'Đã nhận')
insert into tblnhantaitro(mantt,masukien,ngaynhan,trangthainhantaitro) values('TT002','SK002','09-25-2023',N'Đã nhận')
insert into tblnhantaitro(mantt,masukien,ngaynhan,trangthainhantaitro) values('TT003','SK001','03-20-2024',N'Đã nhận')
insert into tblnhantaitro(mantt,masukien,ngaynhan,trangthainhantaitro) values('TT001','SK002','03-25-2024',N'Đã nhận')

insert into tblhopdongthue(mahopdong,mancc,manhanvien,masukien,ngaylap,trangthaixetduyet)values('HD001','NCC001','NV10180006','SK001','10-20-2023',N'Đã duyệt')
insert into tblhopdongthue(mahopdong,mancc,manhanvien,masukien,ngaylap,trangthaixetduyet)values('HD002', 'NCC002','NV10180006','SK001','10-20-2023',N'Đã duyệt')
insert into tblhopdongthue(mahopdong,mancc,manhanvien,masukien,ngaylap,trangthaixetduyet)values('HD003','NCC001','NV10180006','SK002','04-10-2024',N'Đã duyệt')
insert into tblhopdongthue(mahopdong,mancc,manhanvien,masukien,ngaylap,trangthaixetduyet)values('HD004','NCC003','NV10180006','SK002','04-10-2024',N'Đã duyệt')

insert into tblchitiethopdong(mahopdong,matrangthietbi,soluong,dongia,ngaythue,ngaytra) values('HD001','E001',1,2000000,'09-20-2023','09-30-2023')
insert into tblchitiethopdong(mahopdong,matrangthietbi,soluong,dongia,ngaythue,ngaytra)  values('HD002','E002',5,2500000,'09-20-2023','09-30-2023')
insert into tblchitiethopdong(mahopdong,matrangthietbi,soluong,dongia,ngaythue,ngaytra)  values('HD003','E003',3,2400000,'03-25-2024','04-21-2024')
insert into tblchitiethopdong(mahopdong,matrangthietbi,soluong,dongia,ngaythue,ngaytra)  values('HD004','E004',2,2000000,'03-25-2024','04-21-2024')

insert into tblphieuchi(maphieuchi,masukien,manhanvien,sotien,trangthai) values('PC001','SK001','NV10182004',2000000,N'Đã duyệt')
insert into tblphieuchi(maphieuchi,masukien,manhanvien,sotien,trangthai) values('PC002','SK001','NV10182004',2500000,N'Đã duyệt')
insert into tblphieuchi(maphieuchi,masukien,manhanvien,sotien,trangthai) values('PC003','SK002','NV10182004',2000000,N'Đã duyệt')

insert into tblbaocaonghiemthu(mabaocao,masukien,mantt,manhanvien,noidung) values('BC001','SK001','TT001','NV00187005',N'Báo cáo nghiệm thu sự kiện Vòng tròn màu Xanh từ Vietcombank')
insert into tblbaocaonghiemthu(mabaocao,masukien,mantt,manhanvien,noidung) values('BC002','SK001','TT002','NV00187005',N'Báo cáo nghiệm thu sự kiện Vòng tròn màu Xanh từ VietinBank')
insert into tblbaocaonghiemthu(mabaocao,masukien,mantt,manhanvien,noidung) values('BC003','SK002','TT003','NV00187005',N'Báo cáo nghiệm thu sự kiện Việt Nam thương mến từ TPBank')

insert into tblcungcaptrangthietbi(mancc,matrangthietbi) values ('NCC001','E001')
insert into tblcungcaptrangthietbi(mancc,matrangthietbi) values ('NCC001','E002')
insert into tblcungcaptrangthietbi(mancc,matrangthietbi) values ('NCC002','E003')
insert into tblcungcaptrangthietbi(mancc,matrangthietbi) values ('NCC002','E004')
insert into tblcungcaptrangthietbi(mancc,matrangthietbi) values ('NCC003','E005')
