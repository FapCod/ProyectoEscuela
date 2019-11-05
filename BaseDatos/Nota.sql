use Colegio_DB -- Usamos la database creada
------Creacion de la tabla Nota----------------
create table nota(
codigoNota int Identity(1,1) primary key not null, 
nota char(1) not null, 
descripcion varchar(100) not null, 
codigoCurso varchar(15), 
dniAlumno char(8), 
codigoTrimestre varchar(10),
CONSTRAINT fk_curso FOREIGN KEY (codigoCurso) REFERENCES Curso (codigoCurso),
CONSTRAINT fk_Trimestre FOREIGN KEY (codigoTrimestre) REFERENCES Trimestre (codigoTrimestre),
CONSTRAINT fk_alumnoo FOREIGN KEY (dniAlumno) REFERENCES Alumno (dniAlumno)
)
------Fin de la tabla Nota---------------
insert into nota values ( 'A' , 'Exposicion', 'COM01' , '72457239', '1Tri') 
insert into nota values ( 'B' , 'Trabajos', 'COM01' , '72457239', '1Tri') 
insert into nota values ( 'A' , 'Examen', 'COM01' , '72457239', '1Tri') 
insert into nota values ( 'A' , 'Exposicion', 'COM01' , '72457239', '2Tri') 
insert into nota values ( 'B' , 'Trabajos', 'COM01' , '72457239', '2Tri') 
insert into nota values ( 'A' , 'Examen', 'COM01' , '72457239',  '2Tri') 

--Creamos procedimiento almacenado para registrar notas----
create procedure agregarnota(
@nota char(1) ,
@descripcion varchar(100) , 
@codigoCurso varchar(15), 
@dniAlumno char(8), 
@codigoTrimestre varchar(10)
)
as 
begin
insert into nota values ( @nota, @descripcion, @codigoCurso, @dniAlumno, @codigoTrimestre) 
end 

------Verificamos---
create procedure listarNotaAlumnoPorCursoTrimestre(
@dniAlumno char(8) ,
@codigoTrimestre varchar(10),
@codigoCurso varchar(15) 
)
as 
begin
SELECT dbo.curso.nombreCurso, dbo.nota.descripcion, dbo.nota.nota, dbo.trimestre.descripcionTrimestre, dbo.alumno.nombreAlumno, dbo.alumno.apellidoAlumno
FROM     dbo.alumno INNER JOIN
                  dbo.nota ON dbo.alumno.dniAlumno = dbo.nota.dniAlumno INNER JOIN
                  dbo.curso ON dbo.nota.codigoCurso = dbo.curso.codigoCurso INNER JOIN
                  dbo.trimestre ON dbo.nota.codigoTrimestre = dbo.trimestre.codigoTrimestre
				  where dbo.alumno.dniAlumno = @dniAlumno and dbo.trimestre.codigoTrimestre = @codigoTrimestre and dbo.curso.codigoCurso = @codigoCurso 
end 