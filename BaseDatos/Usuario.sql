use Colegio_DB -- Usamos la database creada
------Creacion de la tabla Usuario-----------------
create table usuario(
idUsuario  int identity(1,1) Primary Key not null,
nombreUsuario varchar (11) unique not null,
contraseUsuario varchar (12) unique not null,
nombresUsuario varchar (40) not null,
apellidosUsuario varchar (40) not null,
cargoUsuario varchar (11) not null
)
------Fin de la creacion  de la tabla Usuario-------