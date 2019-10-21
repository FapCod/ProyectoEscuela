create database  -- creamos la base de datos con la que trabajaremos 
use Colegio_DB -- Usamos la database creada
create table Alumno (
Idalumno int Primary Key not null, 
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
Idprofesor int Primary Key not null, 
NombreProfesor varchar (50) not null,
ApellidosProfesor varchar (50) not null, 
CorreoProfesor varchar (100) not null,
SexoProfesor char not null,
TelefonoProfesor int , 
DireccionProfesor varchar (100) not null,
AsignaturasAsig varchar(100) not null, 
Grados_Secci_Asig varchar (30) not null, 
TipoProfesor varchar (30) not null 
)

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