
create login Director with password = '1234567'
create login Profesor with password = '12345678'
--creacion de login por autenticacion sql server
--------Permisos y creacion de usuario para Director
create user Director for login Director
grant select, update   , delete, insert on Alumno To Director with grant option
grant select, update   , delete, insert on profesor To Director with grant option
grant select, update   , delete, insert on users To Director with grant option
--------Permisos y creacion de usuario para Profesor
create user Profesor for login Profesor
grant select, update   , delete, insert on Alumno To Profesor with grant option
grant select, update   , delete, insert on profesor To Profesor with grant option
grant select, insert on users To Profesor with grant option
GRANT EXECUTE ON OBJECT::MostarAlum TO Profesor 
GRANT EXECUTE ON OBJECT::GradoAlum TO Profesor 



