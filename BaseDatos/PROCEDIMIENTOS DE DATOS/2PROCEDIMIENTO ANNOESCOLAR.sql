-------------------------------------------------------------------------------------------
---->>>>>>>>>PROCEDIMIENTOS ALMACENADOS TABLA ANNO ESCOLAR <<<<<<<-----------
-------------------------------------------------------------------------------------------

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
--fin del procedimiento alamcenado