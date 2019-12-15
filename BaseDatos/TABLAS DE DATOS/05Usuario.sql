use Colegio_DB -- Usamos la database creada
------Creacion de la tabla Usuario-----------------

create table usuario(
username varchar (11) Primary key not null,
contrasenna varchar (12) unique not null,
dniUsuario char(8) unique not null,
nombreUsuario varchar(40) not null, 
apellidoUsuario varchar (40) not null,
correoUsuario varchar (40) not null,
cargoUsuario varchar (11) not null,
)
------Fin de la creacion  de la tabla Usuario-------
