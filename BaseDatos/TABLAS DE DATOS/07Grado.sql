use Colegio_DB -- usamos la base de datos colegio_DB
--creamos la tabla grado
create table grado(
codigoGrado int identity(1,1) Primary key not null,
numeroGrado int,
nivelGrado char(9)
)
-- fin de la tabla grado


