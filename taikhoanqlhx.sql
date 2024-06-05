create database taikhoanqlhx
go

create table taikhoan(
	taikhoan char(20) not null,
	matkhau char(20) not null,
	quyen char(20) not null)

insert into taikhoan(taikhoan,matkhau,quyen) values ('giamdoc','gd123','All')
insert into taikhoan(taikhoan,matkhau,quyen) values ('nhansu','ns123','NS')
insert into taikhoan(taikhoan,matkhau,quyen) values ('truyenthong','tt123','TT')
insert into taikhoan(taikhoan,matkhau,quyen) values ('taichinh','tc123','TC')
insert into taikhoan(taikhoan,matkhau,quyen) values ('dieuphoitc','dp123','DP')
insert into taikhoan(taikhoan,matkhau,quyen) values ('doingoai','dn123','DN')
insert into taikhoan(taikhoan,matkhau,quyen) values ('giaovien','gv123','GV')