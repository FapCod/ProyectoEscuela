use Colegio_DB -- Usamos la database creada
------Creacion de la tabla alumno-----------------
create table alumno(
idAlumno  int identity(1,1) Primary Key not null,
dniAlumno char (8) unique not null,
nombreAlumno varchar (40) not null,
apellidoAlumno varchar (40) not null,
sexoAlumno char(1) not null,
nivelAlumno varchar (11) not null,
gradoSeccionAlumno varchar (3) not null,
direccionAlumno varchar (50) not null,
nombreDeApoderadoAlumno varchar (40) not null
)
------Fin de la creacion  de la tabla alumno-------


----Creacion de procedimiento de AgregarAlumno----
CREATE PROCEDURE agregaralumno(
@dni char(8),
@nombre varchar (50), 
@apellido varchar (50),
@sexo char (50),
@nivel varchar (20),
@gradoSeccion int,
@direccion varchar(100),
@nombreApoderado varchar (100)
)
as
begin
insert into Alumno values (@dni,@nombre,@apellido, @sexo, @nivel, @gradoSeccion, @direccion, @nombreApoderado)
end
----Finalizacion del procedimiento de AgregarAlumno----



----Creacion de procedimiento de EliminarAlumno----
create procedure eliminaralumno(
@dni char(8)
)
as 
begin 
delete  from Alumno where dniAlumno=@dni
end 
go
----Finalizacion del procedimiento de EliminarAlumno----



----Creacion de procedimiento de ActualizarAlumno----
create procedure actualizaralumno(
@dni char(8),
@nombre varchar (50), 
@apellido varchar (50),
@sexo char (50),
@nivel varchar (20),
@gradoSeccion int,
@direccion varchar(100),
@nombreApoderado varchar (100)
)
as 
begin 
update  Alumno set NombreAlumno=@nombre, ApellidoAlumno=@apellido, SexoAlumno=@sexo,  NivelAlumno=@nivel, gradoSeccionAlumno=@gradoseccion, DireccionAlumno=@direccion, nombreDeApoderadoAlumno=@nombreApoderado
where dniAlumno = @dni
end 
go
----Finalizacion del procedimiento de ActualizarAlumno----



----Creacion de procedimiento de BuscarAlumno----
create procedure buscaralumno(
@dni varchar(30)
)
as
begin
select * from Alumno where dniAlumno = @dni
end 
go
----Finalizacion del procedimiento de BuscarAlumno----