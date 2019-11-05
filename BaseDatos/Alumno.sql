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


----Creacion de procedimiento de AgregarAlumno----
CREATE PROCEDURE agregaralumno(
@dniAlumno char(8),
@nombreAlumno varchar (50), 
@apellidoAlumno varchar (50),
@edadAlumno int,
@sexoAlumno char (1),
@direccionAlumno varchar(100),
@nombreApoderadoAlumno varchar (100),
@numeroTelefonoApoderado varchar(11) 
)
as
begin
insert into alumno values (@dniAlumno,@nombreAlumno,@apellidoAlumno,@edadAlumno, @sexoAlumno,@direccionAlumno, @nombreApoderadoAlumno,@numeroTelefonoApoderado)
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
@dniAlumno char(8),
@nombreAlumno varchar (50), 
@apellidoAlumno varchar (50),
@edadAlumno int,
@sexoAlumno char (1),
@direccionAlumno varchar(100),
@nombreApoderadoAlumno varchar (100),
@numeroTelefonoApoderado varchar(11) 
)
as 
begin 
update  Alumno set NombreAlumno=@nombreAlumno, ApellidoAlumno=@apellidoAlumno,edadAlumno=@edadAlumno ,SexoAlumno=@sexoAlumno, DireccionAlumno=@direccionAlumno, nombreApoderadoAlumno=@nombreApoderadoAlumno,numeroTelefonoApoderado=@numeroTelefonoApoderado
where dniAlumno = @dniAlumno
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