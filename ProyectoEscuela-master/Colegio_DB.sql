create database Colegio_DB -- creamos la base de datos con la que trabajaremos 
use Colegio_DB -- Usamos la database creada


create table Seccion (
Idseccion int  Primary Key not null,
nombreSeccion varchar (25) not null, 
GradoAula int not null,
NumAula int not null, 
AlumnosRegistrados int not null, 
)


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


