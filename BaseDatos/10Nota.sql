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

drop procedure listarNotaAlumnoPorCursoTrimestre
delete from nota
select * from nota