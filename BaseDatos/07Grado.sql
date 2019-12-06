use Colegio_DB -- usamos la base de datos colegio_DB
--creamos la tabla grado
create table grado(
codigoGrado int identity(1,1) Primary key not null,
numeroGrado int,
nivelGrado char(9),
)
-- fin de la tabla grado

--insertamos los grados a la tabla correspondiente
insert into grado values ( 3, 'Inicial') 
insert into grado values ( 4, 'Inicial') 
insert into grado values ( 5, 'Inicial') 
insert into grado values  ( 1, 'Primaria') 
insert into grado values  ( 2, 'Primaria') 
insert into grado values  ( 3, 'Primaria') 
insert into grado values  ( 4, 'Primaria') 
insert into grado values  (5, 'Primaria') 
insert into grado values  ( 6, 'Primaria') 


create procedure listarGradoI
as 
begin
SELECT codigoGrado,numeroGrado FROM grado where nivelGrado = 'Inicial'
end

create procedure listarGradoP
as 
begin
SELECT codigoGrado,numeroGrado FROM grado where nivelGrado = 'Primaria'
end
