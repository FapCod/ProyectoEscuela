create login Admin with password = '123456'
--creacion de login por autenticacion sql server
select * from Users;
create user admin for login Admin
grant select, update   , delete, insert on Alumno To Admin with grant option
grant select, update   , delete, insert on Profesor To Admin with grant option


select * from Alumno
-----Procedimiento para crear Login
create procedure crearUsuario(
@user varchar(12),
@pass varchar(20)
)
as 

 
declare @i int 
set @i = 1
while (@i=1)
 begin
 create login @user with password = @pass
 create user @user for login @user;
 grant select, update   , delete, insert on Alumno To @user with grant option;
 grant select, update   , delete, insert on Profesor To @user with grant option
end 
go



