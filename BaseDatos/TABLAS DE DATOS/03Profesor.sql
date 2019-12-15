ALTER AUTHORIZATION ON DATABASE :: Colegio_DB  TO SA; -- AUTORIZACION PARA CREAR DIAGRAMA DE BASE DE DATOS
use Colegio_DB -- Usamos la database creada
-----Creacion de la Tabla Profesor-------------------
create table  profesor(
dniProfesor char(8) Primary Key not null,
nombreProfesor varchar (40) not null,
apellidoProfesor varchar (40) not null,
edadProfesor int not null,
sexoProfesor char(1) not null,
direccionProfesor varchar (50) not null,
correoProfesor varchar (30) not null,
telefonoProfesor varchar (11) not null
)

-----Fin de la creacion de la tabla Profesor----------
