use Colegio_DB --Usamos la base de datos.

------Creacion de la tabla Año Escolar-----------------
create table annoEscolar(
numeroAnno int primary key not null, 
fechaInicio date not null, 
fechaTermino date not null
)
------Fin de la creacion  de la tabla Año Escolar-------
----------------------------------------------------------
-----Procedimientos almacenados--------------------
----------------------------------------------------------

-----Procedimiento almacenado para registrar el Año Escolar-----
create procedure registrarAnnoEscolar(
@numeroAnno int ,
@fechaInicio date, 
@fechaTermino date
)
as 
begin 
insert into annoEscolar values ( @numeroAnno, @fechaInicio, @fechaTermino) 
end 