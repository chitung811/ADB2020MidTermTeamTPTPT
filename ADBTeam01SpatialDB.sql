use master
go

create database ADBTeamTPTPSpatialDB
go

use ADBTeamTPTPSpatialDB
go

create table quanlidat
(
	mau nvarchar(10),
	mamd varchar(10),
	mucdich nvarchar(100),
	matdott int,
	matdodt bigint,
	vitri geometry,
)
insert into quanlidat
values  ( N'Xám' , 'M7' , N'Trồng lúa' , 75000 , 250600000 , ('polygon((-2 -2,-2 2,-1 3,1 3,1 -1,-2 -2),(5 -2,3 0,6 1,5 3,7 3,7 -2,5 -2))')),
		( N'Nâu' , 'M8' , N'Trồng cây ăn quả' , 45000 , 350400000 , ('polygon((-2 -2,1 -1,1 0,3 0,3 -2,-2 -2))')),
		( N'Tím' , 'M9' , N'Trồng rau' , 35000 , 450500000 , ('polygon((1 0,1 3,3 4,5 3,5 1,3 0,1 0))'))

select vitri from quanlidat


