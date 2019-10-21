create database  -- creamos la base de datos con la que trabajaremos 
use Colegio_DB -- Usamos la database creada
create table Alumno (
Idalumno int IDENTITY (1,1) Primary Key not null, 
NombreAlumno varchar (50) not null, 
ApellidosAlumno varchar (50) not null,
SexoAlumno char (50) not null,
NivelAlumno varchar (20) not null,
GradoAlumno int not null,
SeccionAlumno char not null,
DireccionAlumno varchar(100) not null ,
NombreApoderado varchar (100) not null 
)

create table Profesor(
Idprofesor int IDENTITY (1,1) Primary Key not null, 
NombreProfesor varchar (50) not null,
ApellidosProfesor varchar (50) not null, 
CorreoProfesor varchar (100) not null,
SexoProfesor char not null,
TelefonoProfesor int , 
DireccionProfesor varchar (100) not null,
AsignaturasAsig varchar(100) not null, 
Grado_Secci_Asig varchar (30) not null, 
TipoProfesor varchar (30) not null 
)
drop table Profesor

create table Seccion (
Idseccion int  Primary Key not null,
nombreSeccion varchar (25) not null, 
GradoAula int not null,
NumAula int not null, 
AlumnosRegistrados int not null, 
)

select * from Alumno 
 select * from  Profesor 
 select * from  Seccion 


create table Users(
UserID int identity(1,1) primary key,
userName nvarchar (100) unique not null,
passUser nvarchar (100) not null,
FirstName nvarchar(100) not null
)
insert into Users values ('admin1','123456789','Jackson')
select * from Users
Select * from users
drop table Users

---------ELIMINAR TABLA USERS
drop table Users;


create table Users(
UserID int identity(1,1) primary key,
userName nvarchar (100) unique not null,
passUser nvarchar (100) not null,
FirstName nvarchar(100) not null,
Positions nvarchar(100) not null
)

insert into Users values ('admin1','123456789','Jackson','Director')
insert into Users values ('admin2','123456789','Marko','Profesor')
select * from Users

------Porcedimientos almacenados----

create procedure InsertarProf
(
 @nombre varchar(50),
 @apellido varchar(50),
 @correo varchar(100), 
 @sexo char,
 @telefono int,
 @direccion varchar(100), 
 @Asignaturas varchar(100),
 @grado_secc varchar(30),
 @tipo varchar(30)
)
as
begin
 insert into Profesor values ( @nombre, @apellido, @correo, @sexo, @telefono, @direccion, @Asignaturas, @grado_secc, @tipo)
end
GO

create procedure EliminarProf 
(
@idprof varchar(20)
)
as 
begin 
delete  from Profesor where Idprofesor=@idprof
end 
go

create procedure ActualizarProf(
@id varchar(30),
 @nombre varchar(50),
 @apellido varchar(50),
 @correo varchar(100), 
 @sexo char,
 @telefono int,
 @direccion varchar(100), 
 @Asignaturas varchar(100),
 @grado_secc varchar(30),
 @tipo varchar(30)
)
as 
begin 
update  Profesor set NombreProfesor=@nombre, ApellidosProfesor=@apellido, CorreoProfesor=@correo, SexoProfesor=@sexo,  TelefonoProfesor=@telefono, DireccionProfesor=@direccion, AsignaturasAsig=@Asignaturas, Grado_Secci_Asig=@grado_secc, TipoProfesor=@tipo
where Idprofesor = @id 
end 
go

create procedure BuscarProf(
@id varchar(30)
)
as
begin
select * from Profesor where Idprofesor = @id
end 
go


exec InsertarProf  'brayan', 'martinez', 'asdad@hotmail.com', 'HOMBRE', '98123456', 'Av Sullana', 'Matematica Comunicacion', '5 "A"', 'Contratado'
exec EliminarProf '1'
exec ActualizarProf '1', 'brayan', 'lopez', 'asdad@hotmail.com', 'M', '98123456', 'Av Sullana', 'Matematica Comunicacion', '5 "A"', 'Contratado'
exec BuscarProf '2'
select * from Profesor
drop procedure InsertarProf