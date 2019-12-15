-------------------------------------------------------------------------------------------
---->>>>>>>>>PROCEDIMIENTOS ALMACENADOS TABLA ALUMNO<<<<<<<-----------
-------------------------------------------------------------------------------------------

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
delete from  Alumno where dniAlumno = @dni
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

--creamos procedimiento almacenado para obtener la tabla alumno
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
FROM alumno 
end
--fin de la creacion del procedimiento almacenado

--creamos procedimiento almacenado para verificar si ya existe un alumno
create procedure VerificarSiExisteAlumno(
@dni char(8))
as begin 
SELECT dniAlumno FROM alumno 
          WHERE  dniAlumno=@dni

END  
--fin de la creacion del procedimiento almacenado 

--creamos procedimiento almacenado para buscar alumno con la funcion LIKE 
create procedure buscarAlumnoLike(
@dni char(8))
as begin 
SELECT dniAlumno,nombreAlumno,apellidoAlumno FROM alumno 
          WHERE  dniAlumno like '%'+@dni+'%'
END  
--fin de la creacion del procedimiento almacenado

--creamos un procedimiento almacenado para listar alumnos por grado y seccion 
create procedure listarAlumnosPorGradoSeccion(
@anno int,
@nivel varchar(10) ,
@grado int ,
@seccion int
)
as
begin
SELECT dbo.matricula.fechaMatricula, dbo.alumno.dniAlumno, dbo.alumno.nombreAlumno, dbo.alumno.apellidoAlumno, dbo.grado.numeroGrado, dbo.seccion.nombreSeccion, dbo.matricula.nivelAlumno
FROM     dbo.alumno INNER JOIN
                  dbo.matricula ON dbo.alumno.dniAlumno = dbo.matricula.dniAlumno INNER JOIN
                  dbo.grado ON dbo.matricula.codigoGrado = dbo.grado.codigoGrado INNER JOIN
                  dbo.seccion ON dbo.matricula.codigoSeccion = dbo.seccion.codigoSeccion AND dbo.grado.codigoGrado = dbo.seccion.codigoGrado
				  where dbo.matricula.codigoGrado = @grado and dbo.matricula.codigoSeccion = @seccion and dbo.matricula.eliminacionLogica = 0 and dbo.matricula.nivelAlumno = @nivel and dbo.matricula.numeroAnno = @anno
end 
--fin de la creacion del procedimiento almacenado 






