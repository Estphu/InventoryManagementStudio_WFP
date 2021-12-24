create table tblRole (
RoleID int identity(1,1) Primary Key,
RoleName nvarChar(50),
RoleDescription nvarChar(50),
)

create table tblUser (
UserName nvarChar(50) Primary Key,
FullName nvarChar(50),
Pass nvarChar(50),
Mobile nvarChar(11),
City nvarChar(50),
Country nvarChar(50),
RoleID int
)

insert into tblUSer(UserName,FullName,Pass,Mobile,City,Country,RoleID) values (@UserName,@FullName,@Pass,@Mobile,@City,@Country,@RoleID)

select * from tblRole
select * from tblUser

set nocount on;
select t1.UserName,t1.FullName,t1.Pass,t1.Mobile,t1.City,t1.Country,t2.RoleName from tblUser as t1 with(nolock)
inner join tblRole as t2 with(nolock) on t2.RoleID=t1.RoleID