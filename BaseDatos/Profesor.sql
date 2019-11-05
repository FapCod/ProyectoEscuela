create database Colegio_DB -- creamos la base de datos con la que trabajaremos 
use Colegio_DB -- Usamos la database creada
-----Creacion de la Tabla Profesor-------------------
create table  profesor(
idProfesor int identity(1,1) Primary Key not null,
dniProfesor char (8) unique not null,
nombreProfesor varchar (40) not null,
apellidoProfesor varchar (40) not null,
correoProfesor varchar (30) not null,
sexoProfesor char(1) not null,
telefonoProfesor varchar (11) not null,
direccionProfesor varchar (50) not null,
tipoProfesor varchar (20) not null
)
-----Fin de la creacion de la tabla Profesor----------
---------Creacion de procedimientos ALMACENADOS-------
-------Creacion de procedimiento AgregarProfesor-----
create procedure agregarProfesor
(
 @dni char(8),
 @nombre varchar(50),
 @apellido varchar(50),
 @correo varchar(100), 
 @sexo char,
 @telefono int,
 @direccion varchar(100), 
 @tipo varchar(30)
)
as
begin
 insert into Profesor values ( @dni,@nombre, @apellido, @correo, @sexo, @telefono, @direccion,@tipo)
end
-------Finalizacion de procedimiento AgregarProfesor-----



-------Creacion de procedimiento EliminarProfesor-----
create procedure eliminarProfesor
(
@idprof varchar(20)
)
as 
begin 
delete  from Profesor where Idprofesor=@idprof
end 
go
-------Finalizacion de procedimiento EliminarProfesor-----


-------Creacion de procedimiento ActualizarProfesor-----
create procedure actualizarProfesor(
 @dni char(8),
 @nombre varchar(50),
 @apellido varchar(50),
 @correo varchar(100), 
 @sexo char,
 @telefono int,
 @direccion varchar(100), 
 @tipo varchar(30)
)
as 
begin 
update  Profesor set NombreProfesor=@nombre, ApellidoProfesor=@apellido, CorreoProfesor=@correo, SexoProfesor=@sexo,  TelefonoProfesor=@telefono, DireccionProfesor=@direccion,TipoProfesor=@tipo
where Idprofesor = @dni
end 
go
-------Finalizacion de procedimiento ActualizarProfesor-----



-------Creacion de procedimiento BuscarProfesor-----
create procedure buscarprofesor(
@dni char(8)
)
as
begin
select * from Profesor where Idprofesor = @dni
end 
go
-------Finalizacion de procedimiento BuscarProfesor-----
