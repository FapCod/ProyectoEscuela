create database Colegio_DB -- creamos la base de datos con la que trabajaremos 
use Colegio_DB -- Usamos la database creada
-----Creacion de la Tabla Profesor-------------------
create table  profesor(
dniProfesor char(8) Primary Key not null,
nombreProfesor varchar (40) not null,
apellidoProfesor varchar (40) not null,
edadProfesor int not null,
sexoProfesor char(1) not null,
direccionProfesor varchar (50) not null,
correoProfesor varchar (30) not null,
telefonoProfesor varchar (11) not null,
codigoAula varchar(15) --FK
CONSTRAINT fk_aula FOREIGN KEY (codigoAula) REFERENCES aula (codigoAula)
)
-----Fin de la creacion de la tabla Profesor----------
---------Creacion de procedimientos ALMACENADOS-------
-------Creacion de procedimiento AgregarProfesor-----
create procedure agregarProfesor
(
 @dniProfesor char(8),
 @nombreProfesor varchar(50),
 @apellidoProfesor varchar(50),
 @edadProfesor int ,
 @sexoProfesor char,
 @direccionProfesor varchar(100),
 @correoProfesor varchar(100), 
 @telefonoProfesor int,
 @codigoAula varchar(30)
)
as
begin
 insert into Profesor values ( @dniProfesor,@nombreProfesor, @apellidoProfesor,@edadProfesor, @sexoProfesor,@direccionProfesor, @correoProfesor, @telefonoProfesor, @codigoAula)
end
-------Finalizacion de procedimiento AgregarProfesor-----
--probramos el procedimiento agregarProfesor
exec agregarProfesor '72457239', 'Brayan','martinez' , 25, 'H', 'Av Sullana', 'Brayan@gmail.com' , '988182681',  'P1'
------
------ Consultamos que se haya registrado correctamente. 
SELECT dbo.profesor.dniProfesor, dbo.profesor.nombreProfesor, dbo.profesor.apellidoProfesor, dbo.profesor.edadProfesor, dbo.profesor.sexoProfesor, dbo.profesor.direccionProfesor, dbo.profesor.correoProfesor, 
                  dbo.profesor.telefonoProfesor, dbo.aula.nombreAula
FROM     dbo.aula INNER JOIN
                  dbo.profesor ON dbo.aula.codigoAula = dbo.profesor.codigoAula

-------Creacion de procedimiento EliminarProfesor-----
create procedure eliminarProfesor
(
@dniProfesor char(8)
)
as 
begin 
delete  from Profesor where dniProfesor=@dniProfesor
end 
go
-------Finalizacion de procedimiento EliminarProfesor-----


-------Creacion de procedimiento ActualizarProfesor-----
create procedure actualizarProfesor(
 @dniProfesor char(8),
 @nombreProfesor varchar(50),
 @apellidoProfesor varchar(50),
 @edadProfesor int ,
 @sexoProfesor char,
 @direccionProfesor varchar(100),
 @correoProfesor varchar(100), 
 @telefonoProfesor int,
 @codigoAula varchar(30)
)
as 
begin 
update  Profesor set NombreProfesor=@nombreProfesor, ApellidoProfesor=@apellidoProfesor, edadProfesor=@edadProfesor, SexoProfesor=@sexoProfesor, DireccionProfesor=@direccionProfesor, CorreoProfesor=@correoProfesor, TelefonoProfesor=@telefonoProfesor, codigoAula=@codigoAula
where dniProfesor = @dniProfesor
end 
go
-------Finalizacion de procedimiento ActualizarProfesor-----



-------Creacion de procedimiento BuscarProfesor-----
create procedure buscarprofesor(
@dniProfesor char(8)
)
as
begin
select * from Profesor where dniProfesor = @dniProfesor
end 
go
-------Finalizacion de procedimiento BuscarProfesor-----

