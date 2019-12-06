DROP DATABASE Colegio_DB
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
numeroTelefonoApoderado varchar(11),
eliminacionLogica bit  
)
------Fin de la creacion  de la tabla alumno-------

select * from alumno
----Creacion de procedimiento de AgregarAlumno----
CREATE PROCEDURE agregaralumno(
@dniAlumno char(8),
@nombreAlumno varchar (50), 
@apellidoAlumno varchar (50),
@edadAlumno int,
@sexoAlumno char (1),
@direccionAlumno varchar(100),
@nombreApoderadoAlumno varchar (100),
@numeroTelefonoApoderado varchar(11),
@eliminacionLogica bit 
)
as
begin
insert into alumno values (@dniAlumno,@nombreAlumno,@apellidoAlumno,@edadAlumno, @sexoAlumno,@direccionAlumno, @nombreApoderadoAlumno,@numeroTelefonoApoderado,@eliminacionLogica)
end
----Finalizacion del procedimiento de AgregarAlumno----



----Creacion de procedimiento de EliminarAlumno----
create procedure eliminaralumno(
@dni char(8)
)
as 
begin 
update  Alumno set eliminacionLogica=1 where dniAlumno = @dni
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
@numeroTelefonoApoderado varchar(11), 
@eliminacionLogica bit 
)
as 
begin 
update  Alumno set NombreAlumno=@nombreAlumno, ApellidoAlumno=@apellidoAlumno,edadAlumno=@edadAlumno ,SexoAlumno=@sexoAlumno, DireccionAlumno=@direccionAlumno, nombreApoderadoAlumno=@nombreApoderadoAlumno,numeroTelefonoApoderado=@numeroTelefonoApoderado,eliminacionLogica=@eliminacionLogica 
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
select * from Alumno where dniAlumno = @dni and eliminacionLogica=0
end 
go
----Finalizacion del procedimiento de BuscarAlumno----

create procedure obtenerTablaAlumno
as
begin
SELECT 
dniAlumno ,
nombreAlumno ,
apellidoAlumno ,
edadAlumno ,
sexoAlumno ,
direccionAlumno ,
nombreApoderadoAlumno ,
numeroTelefonoApoderado 
FROM alumno where eliminacionLogica=0
end


create procedure VerificarSiExisteAlumno(
@dni char(8))
as begin 
SELECT dniAlumno FROM alumno 
          WHERE eliminacionLogica =0 and dniAlumno=1
END  



select * from alumno



