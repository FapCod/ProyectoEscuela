use Colegio_DB -- Usamos la database creada
------Creacion de la tabla BoletaNotas-----------------
create table boletanotas(
idBoletanotas int identity(1,1) Primary Key not null,
notaUno int not null,
notaDos int not null,
notaTres int not null,
notaETC int not null,
periodo varchar (11)not null
)