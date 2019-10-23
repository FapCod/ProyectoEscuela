create table Profesor(
Idprofesor int identity(1,1) Primary Key not null, 
NombreProfesor varchar (50) not null,
ApellidosProfesor varchar (50) not null, 
CorreoProfesor varchar (100) not null,
SexoProfesor char not null,
TelefonoProfesor int , 
DireccionProfesor varchar (100) not null,
AsignaturasAsig varchar(100) not null, 
nivel_Asig varchar (20) not null,
Grados_Secci_Asig varchar (30) not null, 
TipoProfesor varchar (30) not null 
)
drop table Profesor
----------------------------------------------------------------------
-------------Creacion de procedimientos para los Profesores-----------
----------------------------------------------------------------------
drop procedure InsertarProf
create procedure InsertarProf
(
 @nombre varchar(50),
 @apellido varchar(50),
 @correo varchar(100), 
 @sexo char,
 @telefono int,
 @direccion varchar(100), 
 @Asignaturas varchar(100),
 @nivel varchar (20) ,
 @grado_secc varchar(30),
 @tipo varchar(30)
)
as
begin
 insert into Profesor values ( @nombre, @apellido, @correo, @sexo, @telefono, @direccion, @Asignaturas, @nivel , @grado_secc, @tipo)
end

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
 @nivel varchar(20),
 @grado_secc varchar(30),
 @tipo varchar(30)
)
as 
begin 
update  Profesor set NombreProfesor=@nombre, ApellidosProfesor=@apellido, CorreoProfesor=@correo, SexoProfesor=@sexo,  TelefonoProfesor=@telefono, DireccionProfesor=@direccion, AsignaturasAsig=@Asignaturas, nivel_Asig = @nivel,  Grados_Secci_Asig=@grado_secc, TipoProfesor=@tipo
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
--------------------------------------------------------------------------
---------------FIN DE LOS PROCEDIMIENTOS DE PROFESORES--------------------
--------------------------------------------------------------------------