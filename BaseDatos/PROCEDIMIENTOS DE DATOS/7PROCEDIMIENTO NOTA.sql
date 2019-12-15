-------------------------------------------------------------------------------------------
---->>>>>>>>>PROCEDIMIENTOS ALMACENADOS TABLA NOTA<<<<<<<-----------
-------------------------------------------------------------------------------------------

--Creamos procedimiento almacenado para registrar notas----
create procedure agregarnota(
@nota char(1),
@descripcion varchar(100) , 
@codigoCurso varchar(15), 
@dniAlumno char(8), 
@codigoTrimestre varchar(10),
@numeroAnno int,
@dniProfesor varchar(10),
@eliminacionLogica bit
)
as 
begin
insert into nota values ( @nota, @descripcion, @codigoCurso, @dniAlumno, @codigoTrimestre, @numeroAnno,@dniProfesor,@eliminacionLogica ) 
end 
--fin de la creacion del procedimiento almacenado 

--creamos procedimiento almacenado para editar nota
create procedure editarnota(
@codigoNota int,
@nota char(1),
@descripcion varchar(100) , 
@codigoCurso varchar(15), 
@dniAlumno char(8), 
@codigoTrimestre varchar(10),
@numeroAnno int,
@dniProfesor varchar(10),
@eliminacionLogica bit
)
as 
begin
UPDATE nota SET nota=@nota, descripcion=@descripcion, codigoCurso=@codigoCurso, dniAlumno= @dniAlumno,codigoTrimestre= @codigoTrimestre,numeroAnno= @numeroAnno,dniProfesor=@dniProfesor,eliminacionLogica=@eliminacionLogica 
where codigoNota=@codigoNota
end 
--fin de la creacion del procedimiento almacenado 

--creamos procedimiento para listar nota de alumnos por curso y trimestre
create procedure listarNotaAlumnoPorCursoTrimestre(
@dniAlumno char(8) ,
@codigoTrimestre varchar(10),
@codigoCurso varchar(15) 
)
as 
begin
SELECT dbo.nota.codigoNota, dbo.curso.nivel, dbo.alumno.dniAlumno,dbo.alumno.apellidoAlumno,dbo.alumno.nombreAlumno, dbo.trimestre.descripcionTrimestre, dbo.curso.nombreCurso, dbo.nota.descripcion, dbo.annoEscolar.numeroAnno, dbo.nota.nota
FROM     dbo.alumno INNER JOIN
                  dbo.nota ON dbo.alumno.dniAlumno = dbo.nota.dniAlumno INNER JOIN
                  dbo.annoEscolar ON dbo.nota.numeroAnno = dbo.annoEscolar.numeroAnno INNER JOIN
                  dbo.curso ON dbo.nota.codigoCurso = dbo.curso.codigoCurso INNER JOIN
                  dbo.trimestre ON dbo.nota.codigoTrimestre = dbo.trimestre.codigoTrimestre
				  where dbo.alumno.dniAlumno = @dniAlumno and dbo.trimestre.codigoTrimestre = @codigoTrimestre and dbo.curso.codigoCurso = @codigoCurso and dbo.nota.eliminacionLogica=0
end
--fin de la creacion del procedimiento almacenado


--creamos procedimiento almacenado para verificar si una nota de un alumno ya existe
create  procedure validarSiExisteNota (
@descripcion varchar(100), 
@codigoCurso varchar(15),
@dniAlumno char(8),
@codigoTrimestre varchar(10),
@numeroAnno	int
)
as 
begin 
select * from nota where  descripcion = @descripcion and codigoCurso = @codigoCurso and dniAlumno = @dniAlumno 
and codigoTrimestre = @codigoTrimestre and numeroAnno = @numeroAnno 
end 
-----fin de la creacion del procedimiento almacenado

--creamos procedimiento almacenado para listar notas de reporte
create procedure listarNotasReporte(
@dni char(8),
@anno int, 
@nivel varchar(10),
@grado int, 
@seccion int, 
@curso varchar(15)
)
as
begin
SELECT        dbo.annoEscolar.numeroAnno, dbo.alumno.dniAlumno, dbo.grado.nivelGrado, dbo.grado.numeroGrado, dbo.seccion.nombreSeccion, dbo.curso.nombreCurso, dbo.trimestre.descripcionTrimestre, dbo.nota.descripcion, 
                         dbo.nota.nota
FROM            dbo.alumno INNER JOIN
                         dbo.nota ON dbo.alumno.dniAlumno = dbo.nota.dniAlumno INNER JOIN
                         dbo.annoEscolar ON dbo.nota.numeroAnno = dbo.annoEscolar.numeroAnno INNER JOIN
                         dbo.curso ON dbo.nota.codigoCurso = dbo.curso.codigoCurso INNER JOIN
                         dbo.seccion ON dbo.annoEscolar.numeroAnno = dbo.seccion.numeroAnno INNER JOIN
                         dbo.grado ON dbo.seccion.codigoGrado = dbo.grado.codigoGrado INNER JOIN
                         dbo.trimestre ON dbo.nota.codigoTrimestre = dbo.trimestre.codigoTrimestre
						 where dbo.nota.dniAlumno = @dni and dbo.nota.numeroAnno = @anno
						 and dbo.grado.nivelGrado = @nivel and dbo.grado.codigoGrado = @grado
						 and dbo.seccion.codigoSeccion = @seccion and dbo.nota.codigoCurso = @curso	
end
--fin del procedimiento almacenado 