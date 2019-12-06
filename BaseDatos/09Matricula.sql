use Colegio_DB -- Colegio_DB la database creada
------Creacion de la tabla Matricula-----------------
drop table matricula
create table matricula(
idMatricula int Identity(1,1) primary key not null, 
fechaMatricula date not null,
codigoGrado int, --fk
dniAlumno char(8), --fk 
numeroAnno int,  --fk
codigoSeccion int, --fk
nivelAlumno  varchar(20),
eliminacionLogica bit ,
CONSTRAINT fk_graddo FOREIGN KEY (codigoGrado) REFERENCES grado (codigoGrado),
CONSTRAINT fk_alumno FOREIGN KEY (dniAlumno) REFERENCES alumno (dniAlumno),
CONSTRAINT fk_annoEscolaar FOREIGN KEY (numeroAnno) REFERENCES annoEscolar (numeroAnno),
CONSTRAINT fk_seccionn FOREIGN KEY (codigoSeccion) REFERENCES seccion (codigoSeccion)
)
------Fin de la creacion  de la tabla Matricula------

--------------------------------------------------------
-----Procedimientos almacenados--------------------
--------------------------------------------------------

----Procedimiento para registrar una matricula-------
exec registrarMatricula '2019-11-20', 1, 23456234, 2019, 2, 'Primaria', 0
select * from seccion
select * from matricula
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
drop procedure registrarMatricula

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

------Procedimiento almacenado para buscar una matricula----
create procedure buscarMatricula(
@idMatricula int )
as
begin 
select * from Matricula where idMatricula = @idMatricula and eliminacionLogica=0
end
-------Fin del procedimiento almacenado para buscar una matricula------
create procedure obtenerTablaMatricula
as 
begin
SELECT dbo.matricula.idMatricula, dbo.matricula.fechaMatricula, dbo.grado.numeroGrado, dbo.alumno.nombreAlumno, dbo.annoEscolar.numeroAnno, dbo.seccion.nombreSeccion, dbo.matricula.nivelAlumno
FROM     dbo.alumno INNER JOIN
                  dbo.matricula ON dbo.alumno.dniAlumno = dbo.matricula.dniAlumno INNER JOIN
                  dbo.annoEscolar ON dbo.matricula.numeroAnno = dbo.annoEscolar.numeroAnno INNER JOIN
                  dbo.grado ON dbo.matricula.codigoGrado = dbo.grado.codigoGrado INNER JOIN
                  dbo.seccion ON dbo.matricula.codigoSeccion = dbo.seccion.codigoSeccion AND dbo.annoEscolar.numeroAnno = dbo.seccion.numeroAnno AND dbo.grado.codigoGrado = dbo.seccion.codigoGrado where dbo.matricula.eliminacionLogica = 0
end

EXEC obtenerTablaMatricula
delete from matricula where idMatricula = 14
