use Colegio_DB --Usamos la base de datos.

------Creacion de la tabla A�o Escolar-----------------
create table annoEscolar(
numeroAnno int primary key not null, 
fechaInicio date not null, 
fechaTermino date not null
)
------Fin de la creacion  de la tabla A�o Escolar-------
----------------------------------------------------------
-----Procedimientos almacenados--------------------
----------------------------------------------------------

-----Procedimiento almacenado para registrar el A�o Escolar-----
create procedure registrarAnnoEscolar(
@numeroAnno int ,
@fechaInicio date, 
@fechaTermino date
)
as 
begin 
insert into annoEscolar values ( @numeroAnno, @fechaInicio, @fechaTermino) 
end 

exec registrarAnnoEscolar 2015,'01/03/2015','01/12/2015'

