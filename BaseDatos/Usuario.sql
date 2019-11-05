use Colegio_DB -- Usamos la database creada
------Creacion de la tabla Usuario-----------------
create table usuario(
nombreUsuario varchar (11) Primary key not null,
contraseUsuario varchar (12) unique not null,
nombresUsuario varchar (40) not null,
apellidoUsuario varchar (40) not null,
correoUsuario varchar (40) not null,
cargoUsuario varchar (11) not null
)
------Fin de la creacion  de la tabla Usuario-------

-----Ingresamos usuarios desde sqlServer-----------
insert into usuario values('director','director','Frank Antonio','Piñin Ato','frankantonio881@gmail.com','director')
select * from usuario
-----Fin de ingresos de  usuarios desde sqlServer-----------