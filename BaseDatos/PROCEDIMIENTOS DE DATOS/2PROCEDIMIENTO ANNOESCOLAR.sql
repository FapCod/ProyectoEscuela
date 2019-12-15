-------------------------------------------------------------------------------------------
---->>>>>>>>>PROCEDIMIENTOS ALMACENADOS TABLA ANNO ESCOLAR <<<<<<<-----------
-------------------------------------------------------------------------------------------

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
--fin del procedimiento alamcenado