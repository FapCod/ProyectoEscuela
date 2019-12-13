ALTER AUTHORIZATION ON DATABASE :: Colegio_DB  TO SA; -- AUTORIZACION PARA CREAR DIAGRAMA DE BASE DE DATOS
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
estadoProfesor bit
)

-----Fin de la creacion de la tabla Profesor----------
---------Creacion de procedimientos ALMACENADOS-------
-------Creacion de procedimiento AgregarProfesor-----
create procedure agregarProfesor
(
@dniProfesor char(8) ,
@nombreProfesor varchar (40) ,
@apellidoProfesor varchar (40) ,
@edadProfesor int ,
@sexoProfesor char(1) ,
@direccionProfesor varchar (50) ,
@correoProfesor varchar (30) ,
@telefonoProfesor varchar (11) ,
@estadoProfesor bit
)
as
begin
 insert into Profesor values ( @dniProfesor,@nombreProfesor, @apellidoProfesor,@edadProfesor, @sexoProfesor,@direccionProfesor, @correoProfesor, @telefonoProfesor, @estadoProfesor)
end

-------Finalizacion de procedimiento AgregarProfesor-----
--probramos el procedimiento agregarProfesor
exec agregarProfesor '72457239', 'Brayan','martinez' , 25, 'H', 'Av Sullana', 'Brayan@gmail.com' , '988182681',  'P1'
------
------ Consultamos que se haya registrado correctamente. 

-------Creacion de procedimiento EliminarProfesor-----
create procedure eliminarProfesor
(
@dniProfesor char(8)
)
as 
begin 
delete from  Profesor where dniProfesor=@dniProfesor
end 
go
-------Finalizacion de procedimiento EliminarProfesor-----


-------Creacion de procedimiento ActualizarProfesor-----
create procedure actualizarProfesor(
@dniProfesor char(8) ,
@nombreProfesor varchar (40) ,
@apellidoProfesor varchar (40) ,
@edadProfesor int ,
@sexoProfesor char(1) ,
@direccionProfesor varchar (50) ,
@correoProfesor varchar (30) ,
@telefonoProfesor varchar (11),
@estadoProfesor bit 
)
as 
begin 
update  Profesor set NombreProfesor=@nombreProfesor, ApellidoProfesor=@apellidoProfesor, edadProfesor=@edadProfesor, SexoProfesor=@sexoProfesor, DireccionProfesor=@direccionProfesor, CorreoProfesor=@correoProfesor, TelefonoProfesor=@telefonoProfesor, estadoProfesor = @estadoProfesor  
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

------Creacion de procedimiento para actualizar el estado de profesor cuando se le asigne una aula-----
create procedure actualizarEstado(
@dniProfesor char(8)
)
as
begin
update profesor set estadoProfesor = 1
where dniProfesor = @dniProfesor
end 

--creacion de procedimientos para listar los profesores libres 
create procedure listarprofesor
as
begin 
select dniProfesor,nombreProfesor from profesor where estadoProfesor = 1 
end


create procedure obtenerTablaProfesor
as 
begin
select 
dniProfesor ,
nombreProfesor, 
apellidoProfesor ,
edadProfesor ,
sexoProfesor ,
direccionProfesor, 
correoProfesor ,
telefonoProfesor  from profesor 
end

--creamos un procedimiento almacenado para listar profesores por grado y seccion 
create procedure listarProfesorPorGradoSeccion(
@anno int, 
@nivel varchar(10),
@grado int, 
@seccion int
)
as 
begin
SELECT dbo.profesor.dniProfesor, dbo.profesor.nombreProfesor, dbo.profesor.apellidoProfesor, dbo.seccion.nombreSeccion, dbo.grado.numeroGrado, dbo.seccion.nivel
FROM     dbo.grado INNER JOIN
                  dbo.seccion ON dbo.grado.codigoGrado = dbo.seccion.codigoGrado INNER JOIN
                  dbo.profesor ON dbo.seccion.dniProfesor = dbo.profesor.dniProfesor
				  where dbo.seccion.numeroAnno = @anno and dbo.seccion.nivel = @nivel and dbo.seccion.codigoGrado = @grado and dbo.seccion.codigoSeccion = @seccion
end 
