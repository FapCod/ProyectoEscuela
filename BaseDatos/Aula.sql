use Colegio_DB --Usamos la base de datos.

------Creacion de la tabla Aula-----------------
create table aula(
codigoAula varchar(15) primary key not null,
nombreAula varchar(20) not null,
capacidadAula int not null,
vacantesLibresAula int not null
)
------Fin de la creacion  de la tabla Aula-------
--insertamos las aulas a la tabla creada.
insert into aula values ('I3', 'Inicial 3', 25, 25)
insert into aula values ('I4', 'Inicial 4', 25, 25)
insert into aula values ('I5', 'Inicial 5', 25, 25)
insert into aula values ('P1', 'Primaria 1',30, 30)
insert into aula values ('P2', 'Primaria 2', 30, 30)
insert into aula values ('P3', 'Primaria 3',30, 30)
insert into aula values ('P4', 'Primaria 4',30, 30)
insert into aula values ('P5', 'Primaria 5',30, 30)
insert into aula values ('P6', 'Primaria 6',30, 30)
--fin de la agregacion.

