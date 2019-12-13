use Colegio_DB -- Usamos la database creada
------Creacion de la tabla Nota----------------
create table nota(
codigoNota int Identity(1,1) primary key not null, 
nota char(1) not null, 
descripcion varchar(100) not null, 
codigoCurso varchar(15), --fk
dniAlumno char(8), --fk 
codigoTrimestre varchar(10), --fk
numeroAnno int, --fk
eliminacionLogica bit
CONSTRAINT fk_curso FOREIGN KEY (codigoCurso) REFERENCES Curso (codigoCurso),
CONSTRAINT fk_Trimestre FOREIGN KEY (codigoTrimestre) REFERENCES Trimestre (codigoTrimestre),
CONSTRAINT fk_anoEscolar  FOREIGN KEY (numeroAnno) REFERENCES annoEscolar (numeroAnno),
CONSTRAINT fk_alumnno  FOREIGN KEY (dniAlumno) REFERENCES alumno (dniAlumno)
)

------Fin de la tabla Nota---------------

--Creamos procedimiento almacenado para registrar notas----
create procedure agregarnota(
@nota char(1),
@descripcion varchar(100) , 
@codigoCurso varchar(15), 
@dniAlumno char(8), 
@codigoTrimestre varchar(10),
@numeroAnno int,
@eliminacionLogica bit
)
as 
begin
insert into nota values ( @nota, @descripcion, @codigoCurso, @dniAlumno, @codigoTrimestre, @numeroAnno,@eliminacionLogica ) 
end 

create procedure editarnota(
@codigoNota int,
@nota char(1),
@descripcion varchar(100) , 
@codigoCurso varchar(15), 
@dniAlumno char(8), 
@codigoTrimestre varchar(10),
@numeroAnno int,
@eliminacionLogica bit
)
as 
begin
UPDATE nota SET nota=@nota, descripcion=@descripcion, codigoCurso=@codigoCurso, dniAlumno= @dniAlumno,codigoTrimestre= @codigoTrimestre,numeroAnno= @numeroAnno,eliminacionLogica=@eliminacionLogica 
where codigoNota=@codigoNota
end 

--creamos procedimiento para listar alumnos por curso y trimestre

create procedure listarNotaAlumnoPorCursoTrimestre(
@dniAlumno char(8) ,
@codigoTrimestre varchar(10),
@codigoCurso varchar(15) 
)
as 
begin
SELECT dbo.nota.codigoNota, dbo.curso.nivel, dbo.alumno.dniAlumno, dbo.trimestre.descripcionTrimestre, dbo.curso.nombreCurso, dbo.nota.descripcion, dbo.annoEscolar.numeroAnno, dbo.nota.nota
FROM     dbo.alumno INNER JOIN
                  dbo.nota ON dbo.alumno.dniAlumno = dbo.nota.dniAlumno INNER JOIN
                  dbo.annoEscolar ON dbo.nota.numeroAnno = dbo.annoEscolar.numeroAnno INNER JOIN
                  dbo.curso ON dbo.nota.codigoCurso = dbo.curso.codigoCurso INNER JOIN
                  dbo.trimestre ON dbo.nota.codigoTrimestre = dbo.trimestre.codigoTrimestre
				  where dbo.alumno.dniAlumno = @dniAlumno and dbo.trimestre.codigoTrimestre = @codigoTrimestre and dbo.curso.codigoCurso = @codigoCurso and dbo.nota.eliminacionLogica=0
end




--VALIDAR SI LA NOTA YA EXISTE
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
---

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

