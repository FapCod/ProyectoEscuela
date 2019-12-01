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

exec registrarAnnoEscolar 2019,'2019/03/2','2019/12/20'
select * from annoEscolar
