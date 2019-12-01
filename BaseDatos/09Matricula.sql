use Colegio_DB -- Colegio_DB la database creada
------Creacion de la tabla Matricula-----------------
create table matricula(
idMatricula int Identity(1,1) primary key not null, 
fechaMatricula date not null,
codigoGrado int, --fk
dniAlumno char(8), --fk 
numeroAnno int,  --fk
codigoSeccion int, --fk
nivelAlumno  varchar(20)
CONSTRAINT fk_graddo FOREIGN KEY (codigoGrado) REFERENCES grado (codigoGrado),
CONSTRAINT fk_alumno FOREIGN KEY (dniAlumno) REFERENCES alumno (dniAlumno),
CONSTRAINT fk_annoEscolaar FOREIGN KEY (numeroAnno) REFERENCES annoEscolar (numeroAnno),
CONSTRAINT fk_seccionn FOREIGN KEY (codigoSeccion) REFERENCES seccion (CodigoSeccion)
)
------Fin de la creacion  de la tabla Matricula------

--------------------------------------------------------
-----Procedimientos almacenados--------------------
--------------------------------------------------------

----Procedimiento para registrar una matricula-------
create procedure registrarMatricula(
@fechaMatricula date,
@codigoGrado int,
@dniAlumno char(8), 
@numeroAnno int ,
@nombreSeccion varchar(30),
@nivelAlumno  varchar(20)
)
as
begin
insert into matricula values (@fechaMatricula, @codigoGrado, @dniAlumno, @numeroAnno, @nombreSeccion, @nivelAlumno ) 
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
@nivelAlumno  varchar(20)
)
as 
begin 
update Matricula set fechaMatricula = @FechaMatricula, codigoGrado = @codigoGrado, dniAlumno = @dniAlumno, numeroAnno = @numeroAnno, codigoSeccion = @codigoSeccion, nivelAlumno = @nivelAlumno
where @idMatricula = idMatricula
end 
------Fin del procedimiento almacenado Actualizar Matricula-----------

------Procedimiento almacenado para eliminar una matricula----------
create procedure eliminarMatricula(
@idMatricula int )
as
begin 
delete from Matricula where idMatricula = @idMatricula 
end
------Fin del procedimiento almacenado eliminar-----

------Procedimiento almacenado para buscar una matricula----
create procedure buscarMatricula(
@idMatricula int )
as
begin 
select * from Matricula where idMatricula = @idMatricula 
end
-------Fin del procedimiento almacenado para buscar una matricula------
