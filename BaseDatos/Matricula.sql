use Colegio_DB -- Usamos la database creada
------Creacion de la tabla Matricula-----------------
create table matricula(
idMatricula int Identity(1,1) primary key not null, 
fechaMatricula date not null,
codigoAula varchar(15), 
dniAlumno char(8), 
numeroAnno int, 
CONSTRAINT fk_Aulaa FOREIGN KEY (codigoAula) REFERENCES aula (codigoAula),
CONSTRAINT fk_alumno FOREIGN KEY (dniAlumno) REFERENCES alumno (dniAlumno),
CONSTRAINT fk_annoEscolar FOREIGN KEY (numeroAnno) REFERENCES annoEscolar (numeroAnno)
)

------Fin de la creacion  de la tabla Matricula------
--------------------------------------------------------
-----Procedimientos almacenados--------------------
--------------------------------------------------------
----Procedimiento para registrar una matricula-------
create procedure registrarMatricula(
@fechaMatricula date,
@codigoAula varchar(15), 
@dniAlumno char(8), 
@numeroAnno int )
as
begin
insert into Matricula values (@fechaMatricula, @codigoAula, @dniAlumno, @numeroAnno) 
end 
------fin del procedimiento almacenado Registrar matricula--------------

-------Procedimiento para actualizar una matricula---------------
 create procedure actualizarMatricula(
 @idMatricula int ,
 @fechaMatricula date,
@codigoAula varchar(15), 
@dniAlumno char(8), 
@numeroAnno int )
as 
begin 
update Matricula set fechaMatricula = @FechaMatricula, codigoAula = @codigoAula, dniAlumno = @dniAlumno, numeroAnno = @numeroAnno
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

----Creamos el procedimiento almacenado para Listar Matricula

create procedure listarmatricula
as
begin
SELECT dbo.alumno.dniAlumno "DNI", dbo.alumno.nombreAlumno "Nombre", dbo.alumno.apellidoAlumno "Apellido", dbo.aula.nombreAula "Nivel y Grado", dbo.matricula.fechaMatricula "Fecha Matricula"
FROM     dbo.alumno INNER JOIN
                  dbo.matricula ON dbo.alumno.dniAlumno = dbo.matricula.dniAlumno INNER JOIN
                  dbo.aula ON dbo.matricula.codigoAula = dbo.aula.codigoAula
end
