create database Colegio_DB -- creamos la base de datos con la que trabajaremos 
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