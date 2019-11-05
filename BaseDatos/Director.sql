use Colegio_DB -- Usamos la database creada
-----Creacion de la Tabla Director-------------------
create table director(
idDirector int identity(1,1) Primary Key not null,
dniDirector char (8) unique not null,
nombreDirector varchar (40) not null,
apellidoDirector varchar (40) not null,
correoDirector varchar (40) not null,
sexoDirector char(1) not null,
telefonoDirector varchar (11) not null,
direccionDirector varchar (50) not null
)
-----Fin de la creacion de la tabla Director----------