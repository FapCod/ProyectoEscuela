create database Colegio_DB -- creamos la base de datos con la que trabajaremos 
use Colegio_DB -- Usamos la database creada


create table Grado_Seccion (
Idgra_seccion int  IDENTITY(1,1) Primary Key not null,
GradoAula varchar(20) not null,
nombreSeccion varchar (25) not null, 
NumAula int,
Nivel varchar(20) not null, 
Idprofesor int	
)
insert into Grado_Seccion values ('5', 'A', '305', '35', 'Primaria','')
insert into Grado_Seccion values ('6', 'A', '305', '35', 'Primaria','')
select * from Grado_Seccion
delete from Grado_Seccion where Idgra_seccion = 1
DBCC CHECKIDENT (profesor, RESEED, 0)
drop table Grado_Seccion
select GradoAula, NombreSeccion from Grado_Seccion Where Nivel = 'Primaria'
create procedure AgregarSeccion (
@Grado int,
@Seccion varchar(25),
@NAula int ,
@nivel varchar (20)
)
as
begin
insert into Grado_Seccion (GradoAula, nombreSeccion, NumAula,  Nivel) values ( @Grado, @Seccion, @NAula, @nivel)
end 
drop procedure AgregarSeccion
---------------------------------------------------------------------------------------
--Procedimiento almacenado que mostrar los datos del grado y seccion ingresado--
---------------------------------------------------------------------------------------
CREATE PROCEDURE datSecc (
@grado int,
@seccion varchar(25) 
)
as 
begin
SELECT dbo.Grado_Seccion.GradoAula, dbo.Grado_Seccion.nombreSeccion, dbo.Grado_Seccion.NumAula, dbo.Grado_Seccion.Nivel, dbo.Profesor.NombreProfesor
FROM     dbo.Grado_Seccion INNER JOIN
                  dbo.Profesor ON dbo.Grado_Seccion.Idgra_seccion = dbo.Profesor.Idgra_seccion
where dbo.Grado_Seccion.GradoAula = @grado and dbo.Grado_Seccion.nombreSeccion = @seccion 
end
exec datSecc '1', 'B' 
drop procedure datSecc
-------------------------------------------------------------------------------------
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

--Creamos tabla de asignaturas--
create table asignaturas (
idAsignaturas int Identity (1,1) primary key not null,
NomAsignatura varchar(50) not null, 
)
--Ingresamos datos a la tabla asignaturas
insert into asignaturas values ('Matematicas') 
insert into asignaturas values ('Lengua Castellana') 
insert into asignaturas values ('Religion')
insert into asignaturas values ('Ciencias de la Naturaleza')
insert into asignaturas values ('Ciencias Sociales')
insert into asignaturas values ('Lengua Extranjera')
insert into asignaturas values ('Educacion Fisica')    
-------------------------------------------------------------------------------------------------------------------------
--procedimientos almacenados con INNER JOIN con las tablas Asignaturas, Profesor y Grado_Seccion--
------------------------------------------------------------------------------------------------------------------------- 
create procedure datProf(
@nombreprof varchar (50)
)
as 
begin
SELECT dbo.Profesor.NombreProfesor, dbo.Profesor.ApellidosProfesor, dbo.Profesor.CorreoProfesor, dbo.Profesor.SexoProfesor, dbo.Profesor.TelefonoProfesor, 
				dbo.Profesor.DireccionProfesor, dbo.asignaturas.NomAsignatura "Asignatura", dbo.Profesor.nivel_Asig "Nivel", dbo.Grado_Seccion.GradoAula "Grado", 
				dbo.Grado_Seccion.nombreSeccion "Seccion", dbo.Profesor.TipoProfesor
FROM     dbo.Grado_Seccion INNER JOIN
                  dbo.Profesor ON dbo.Grado_Seccion.Idgra_seccion = dbo.Profesor.Idgra_seccion INNER JOIN
                  dbo.asignaturas ON dbo.Profesor.idAsignaturas = dbo.asignaturas.idAsignaturas 
where dbo.Profesor.NombreProfesor = @nombreprof
end 
exec datProf 'brayan'
drop procedure datProf
------------------------------------------------------------------------------------------------------
--Procedimiento Almacenado para saber de que aula es tutor el profesor ingresado ------
------------------------------------------------------------------------------------------------------
create procedure Tutor(
@nombre varchar(50))
as 
begin
SELECT dbo.Grado_Seccion.GradoAula "Grado Asignado", dbo.Grado_Seccion.nombreSeccion "Seccion Asignada", dbo.Grado_Seccion.NumAula "N° Aula", 
			 dbo.Profesor.NombreProfesor, dbo.Profesor.ApellidosProfesor
FROM     dbo.Grado_Seccion INNER JOIN
                  dbo.Profesor ON dbo.Grado_Seccion.Idgra_seccion = dbo.Profesor.Idgra_seccion
where dbo.Profesor.NombreProfesor = @nombre
 end 

 exec tutor 'null'
 drop procedure Tutor
 ----------------------------------------------------------------------------------------------------------------
 --Procedimiento almacenado que permite buscar que profesor(es) dicta la asignatura ingresada--
 ----------------------------------------------------------------------------------------------------------------
 create procedure Prof_Asignatu(
 @nomAsignatura varchar (50)
 )
 as 
 begin 
 SELECT dbo.Profesor.NombreProfesor, dbo.Profesor.ApellidosProfesor, dbo.asignaturas.NomAsignatura "Asignatura", dbo.Profesor.nivel_Asig "Nivel"
FROM     dbo.asignaturas INNER JOIN
                  dbo.Profesor ON dbo.asignaturas.idAsignaturas = dbo.Profesor.idAsignaturas
WHERE dbo.asignaturas.NomAsignatura = @nomAsignatura
end
exec Prof_Asignatu 'Matematicas'
drop procedure Prof_Asignatu
------------------------------------------------------------------------------
------------------Cambios de la base de datos---------------------------
------------------------------------------------------------------------------
/* 1.- La tabla seccion ahora se llamara Grado_Seccion , para poder guardar ahi todos los grados y secciones registrados y poder  
crear procedimientos almacenados para poder seleccionar que profesor esta de tutor en tal aula. 
2.- Se Asginara como llave foranea el Idgra_Seccion en la tabla profesor para que se pueda mostrar el aula en la que es tutor.
3.- Creamos una consulta con inner join donde utilizaremos las tablas asignaturas, profesor y grado_seccion, donde mostraremos un profesor y seleccionaremos
	el grado y la seccion a traves del id, al igual que el nombre de la asignatura.
4..- Creamos una consulta con inner join para seleccionar las secciones y sus respectivos profesores a cargo, para eso utilizamos como llave foranea el idProfesor
		para poder seleccionar a la hora de mostrar su nombre. 
