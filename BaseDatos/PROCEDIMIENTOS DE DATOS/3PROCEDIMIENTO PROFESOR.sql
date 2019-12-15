-------------------------------------------------------------------------------------------
---->>>>>>>>>PROCEDIMIENTOS ALMACENADOS TABLA PROFESOR<<<<<<<-----------
-------------------------------------------------------------------------------------------

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
@telefonoProfesor varchar (11) 
)
as
begin
 insert into Profesor values ( @dniProfesor,@nombreProfesor, @apellidoProfesor,@edadProfesor, @sexoProfesor,@direccionProfesor, @correoProfesor, @telefonoProfesor)
end
-------Finalizacion de procedimiento AgregarProfesor-----

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
@telefonoProfesor varchar (11)
)
as 
begin 
update  Profesor set NombreProfesor=@nombreProfesor, ApellidoProfesor=@apellidoProfesor, edadProfesor=@edadProfesor, SexoProfesor=@sexoProfesor, DireccionProfesor=@direccionProfesor, CorreoProfesor=@correoProfesor, TelefonoProfesor=@telefonoProfesor  
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




--creacion de procedimientos para listar los profesores libres 
create procedure listarprofesor
as
begin 
select dniProfesor,nombreProfesor from profesor 
end
--fin de la creacion del procedimiento almacenado 

--creamos procedimiento almacenado para obtener datos de la tabla profesor
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
--fin de la creacion del procedimiento almacenado 

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
----fin de la creacion del procedimiento almacenado 

--creamos procedimiento almacenado para editar los datos de un profesor desde el formulario usuario 
create procedure editarProfesor(
@dni char(8),
@nombre varchar(40) ,
@apellido varchar(40) ,
@correo varchar(40)
)
as 
begin 
update profesor set nombreProfesor = @nombre, apellidoProfesor = @apellido, correoProfesor =  @correo
where dniProfesor = @dni
end
--fin de la creacion del procedimiento almacenado 