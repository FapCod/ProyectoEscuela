use Colegio_DB -- Usamos la base de datos colegio_DB
--Creamos la tabla seccion
create table seccion(
codigoSeccion int IDENTITY(1,1) primary key not null,
nombreSeccion varchar(30)  not null,
codigoGrado int, --fk
dniProfesor char(8), --fk 
numeroAnno int, --fk
numeroVacantes int,
 nivel varchar(20)
CONSTRAINT fk_gradoo FOREIGN KEY (codigoGrado) REFERENCES grado (codigoGrado),
CONSTRAINT fk_annoEscolar FOREIGN KEY (numeroanno) REFERENCES annoEscolar (numeroanno)
)
--fin de la creacion de la tabla seccion 

--creamos procedimientos almacenado para registrar seccion
create procedure registrarSeccion (
@nombreSeccion varchar(30) ,
@codigoGrado int,
@dniProfesor char(8), 
@numeroAnno int, 
@numeroVacantes int,
@nivel varchar(20)
) 
as 
begin 
insert into seccion values (@nombreSeccion, @codigoGrado, @dniProfesor, @numeroAnno, @numeroVacantes, @nivel)
end 
--fin del procedimientos almacenado registrar seccion

--creamos procedimientos almacenado para listarseccion 
create procedure listarSeccion(
@grado int
) 
as 
begin
select nombreSeccion from seccion where codigoGrado = @grado
end
-- fin del procedimiento almacenado listar seccion