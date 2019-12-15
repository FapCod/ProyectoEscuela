
create database Colegio_DB -- creamos la base de datos
use Colegio_DB -- Usamos la database creada
------Creacion de la tabla alumno-----------------
create table alumno(
dniAlumno char (8) Primary Key not null,
nombreAlumno varchar (40) not null,
apellidoAlumno varchar (40) not null,
edadAlumno int not null,
sexoAlumno char(1) not null,
direccionAlumno varchar (50) not null,
nombreApoderadoAlumno varchar(50) not null, 
numeroTelefonoApoderado varchar(11)
)
------Fin de la creacion  de la tabla alumno-------



