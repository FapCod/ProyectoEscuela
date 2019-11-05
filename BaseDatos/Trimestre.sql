use Colegio_DB -- Usamos la database creada
------Creacion de la tabla Trimestre-----------------
create table trimestre(
codigoTrimestre int Identity(1,1) primary key not null,
descripcionTrimestre varchar (25) not null
)
------Fin de la creacion  de la tabla Trimestre-------