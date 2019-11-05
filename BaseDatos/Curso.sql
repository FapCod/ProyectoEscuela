use Colegio_DB -- Usamos la database creada
------Creacion de la tabla Curso-----------------
create table curso(
idCurso int identity(1,1) Primary Key not null,
nombreCurso varchar (11)not null
)
------Fin de la creacion  de la tabla Curso------