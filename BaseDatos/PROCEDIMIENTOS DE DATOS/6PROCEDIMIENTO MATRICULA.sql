-------------------------------------------------------------------------------------------
---->>>>>>>>>PROCEDIMIENTOS ALMACENADOS TABLA MATRICULA <<<<<<<-----------
-------------------------------------------------------------------------------------------

----Procedimiento para registrar una matricula-------
create procedure registrarMatricula(
@fechaMatricula date,
@codigoGrado int,
@dniAlumno char(8), 
@numeroAnno int ,
@codigoSeccion int,
@nivelAlumno  varchar(20),
@eliminacionLogica bit
)
as
begin
insert into matricula values (@fechaMatricula, @codigoGrado, @dniAlumno, @numeroAnno, @codigoSeccion, @nivelAlumno,@eliminacionLogica ) 
end 
------fin del procedimiento almacenado Registrar matricula--------------

-------Procedimiento para actualizar una matricula---------------
 create procedure actualizarMatricula(
@idMatricula int ,
@fechaMatricula date ,
@codigoGrado int, 
@dniAlumno char(8), 
@numeroAnno int, 
@codigoSeccion varchar(30),
@nivelAlumno  varchar(20),
@eliminacionLogica bit
)
as 
begin 
update Matricula set fechaMatricula = @FechaMatricula, codigoGrado = @codigoGrado, dniAlumno = @dniAlumno, numeroAnno = @numeroAnno, codigoSeccion = @codigoSeccion, nivelAlumno = @nivelAlumno,eliminacionLogica=@eliminacionLogica
where @idMatricula = idMatricula
end 
------Fin del procedimiento almacenado Actualizar Matricula-----------

------Procedimiento almacenado para eliminar una matricula----------
create procedure eliminarMatricula(
@idMatricula int )
as
begin 
update Matricula set eliminacionLogica=1  where idMatricula = @idMatricula 
end
------Fin del procedimiento almacenado eliminar-----

--Creamos procedimiento almacenado para obtener los datos de la tabla matricula
create procedure obtenerTablaMatricula
as 
begin
SELECT dbo.matricula.idMatricula, dbo.matricula.fechaMatricula, dbo.grado.numeroGrado, dbo.alumno.dniAlumno, dbo.matricula.numeroAnno, dbo.seccion.nombreSeccion, dbo.matricula.nivelAlumno
FROM     dbo.alumno INNER JOIN
                  dbo.matricula ON dbo.alumno.dniAlumno = dbo.matricula.dniAlumno INNER JOIN
                  dbo.grado ON dbo.matricula.codigoGrado = dbo.grado.codigoGrado INNER JOIN
                  dbo.seccion ON dbo.matricula.codigoSeccion = dbo.seccion.codigoSeccion AND dbo.grado.codigoGrado = dbo.seccion.codigoGrado where dbo.matricula.eliminacionLogica = 0
end
--fin de la creacion del procedimiento almacenado

--creamos procedimiento almacenado para verificar si alumno es de inicial o primaria 
Create procedure VerificarSiEsDeInicialoPrimaria(
@apellido varchar(20),
@nivel varchar(10)
)
as begin
SELECT dbo.alumno.dniAlumno, dbo.alumno.apellidoAlumno, dbo.alumno.nombreAlumno, dbo.matricula.numeroAnno
FROM     dbo.alumno INNER JOIN
                  dbo.matricula ON dbo.alumno.dniAlumno = dbo.matricula.dniAlumno 
WHERE dbo.alumno.apellidoAlumno  like '%'+@apellido+'%' and eliminacionLogica=0 and nivelAlumno=@nivel
end
--fin de la creacion del procedimiento almacenado 

--creamos procedimiento almacenado para verificar si existe una matricula
Create procedure VerificarSiExisteMatricula(
@dni varchar(10)
)
as begin
SELECT dniAlumno, nivelAlumno
FROM     dbo.matricula 
WHERE eliminacionLogica =0 and dniAlumno=@dni
end
--fin de la creacion del procedimiento almacenado 

------Procedimiento almacenado para buscar una matricula a traves del dni del alumno----
create procedure buscarMatricula(
@dni int )
as
begin 
SELECT dbo.matricula.idMatricula, dbo.matricula.fechaMatricula, dbo.grado.numeroGrado, dbo.alumno.dniAlumno, dbo.matricula.numeroAnno, dbo.seccion.nombreSeccion, dbo.matricula.nivelAlumno
FROM     dbo.alumno INNER JOIN
                  dbo.matricula ON dbo.alumno.dniAlumno = dbo.matricula.dniAlumno INNER JOIN
                  dbo.grado ON dbo.matricula.codigoGrado = dbo.grado.codigoGrado INNER JOIN
                  dbo.seccion ON dbo.matricula.codigoSeccion = dbo.seccion.codigoSeccion AND dbo.grado.codigoGrado = dbo.seccion.codigoGrado  where dbo.matricula.dniAlumno= @dni and dbo.matricula.eliminacionLogica=0
end
----fin de la creacion del procedimiento almacenado 


