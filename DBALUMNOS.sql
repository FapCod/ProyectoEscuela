--Creacion de la tabla alumnos
create table Alumno (
Idalumno int identity(1,1) Primary Key not null, 
NombreAlumno varchar (50) not null, 
ApellidosAlumno varchar (50) not null,
SexoAlumno char (50) not null,
NivelAlumno varchar (20) not null,
GradoAlumno int not null,
SeccionAlumno char not null,
DireccionAlumno varchar(100) not null ,
NombreApoderado varchar (100) not null 
)
--Eliminar tabla alumnos
drop table Alumno
--Mostrar la tabla alumnos
select * from Alumno 
----------------------------------------------------------------------
---------------Creacion de procedimientos para los alumnos------------
----------------------------------------------------------------------
CREATE PROCEDURE RegistrarAlum(
@NombreAlumno varchar (50), 
@ApellidosAlumno varchar (50),
@SexoAlumno char (50),
@NivelAlumno varchar (20),
@GradoAlumno int,
@SeccionAlumno char,
@DireccionAlumno varchar(100),
@NombreApoderado varchar (100)
)
as
begin
insert into Alumno values (@NombreAlumno,@ApellidosAlumno, @SexoAlumno, @NivelAlumno, @GradoAlumno, @SeccionAlumno,@DireccionAlumno, @NombreApoderado)
end
go
DROP PROCEDURE RegistrarAlum
-- INGRESAMOS UN ALUMNO DESDE UN PROCEDIMIENTO
exec RegistrarAlum 'Marko', 'Urbina', 'M', 'Primaria', '4', 'A', 'Av. Peru','Francisco'
SELECT * FROM ALUMNO

create procedure EliminarAlum(
@idalumn varchar(20)
)
as 
begin 
delete  from Alumno where Idalumno=@idalumn
end 
go

create procedure ActualizarAlum(
@id varchar(30),
 @nombre varchar(50),
 @apellido varchar(50),
 @sexo char,
 @nivel varchar(20),
 @grado int, 
 @seccion char,
 @direccion varchar(100),
 @nombreApoderado varchar(100)
)
as 
begin 
update  Alumno set NombreAlumno=@nombre, ApellidosAlumno=@apellido, SexoAlumno=@sexo,  NivelAlumno=@nivel, GradoAlumno=@grado, SeccionAlumno=@seccion, DireccionAlumno=@direccion, NombreApoderado=@nombreApoderado
where Idalumno = @id 
end 
go

create procedure BuscarAlum(
@id varchar(30)
)
as
begin
select * from Alumno where Idalumno = @id
end 
go
exec BuscarAlum '1'
--------------------------------------------------------------------------
-----------------FIN DE LOS PROCEDIMIENTOS DE ALUMNOS---------------------
--------------------------------------------------------------------------