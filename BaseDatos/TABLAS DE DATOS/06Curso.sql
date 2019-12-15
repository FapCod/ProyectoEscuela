use Colegio_DB -- Usamos la database creada
------Creacion de la tabla Curso-----------------
create table curso(
codigoCurso varchar(15) Primary Key not null,
nombreCurso varchar (50)not null,
nivel varchar(20),
competencia1 varchar (80) not null,
competencia2 varchar (80) not null,
competencia3 varchar (80) not null,
)

------Fin de la creacion  de la tabla Curso------


