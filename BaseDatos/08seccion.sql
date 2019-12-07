use Colegio_DB -- Usamos la base de datos colegio_DB
--Creamos la tabla seccion
create table seccion(
codigoSeccion int IDENTITY(1,1) primary key not null,
nombreSeccion varchar(30)  not null,
codigoGrado int, --fk
dniProfesor char(8), --fk 
numeroAnno int, --fk
numeroVacantes int,
nivel varchar(20),
eliminacionLogica bit
CONSTRAINT fk_gradoo FOREIGN KEY (codigoGrado) REFERENCES grado (codigoGrado),
CONSTRAINT fk_annoEscolar FOREIGN KEY (numeroanno) REFERENCES annoEscolar (numeroanno),
CONSTRAINT fk_profesoor FOREIGN KEY (dniProfesor) REFERENCES Profesor (dniProfesor)
)
--fin de la creacion de la tabla seccion


--creamos procedimientos almacenado para registrar seccion
create procedure registrarSeccion (
@nombreSeccion varchar(30) ,
@codigoGrado int,
@dniProfesor char(8), 
@numeroAnno int, 
@numeroVacantes int,
@nivel varchar(20),
@eliminacionLogica bit 
) 
as 
begin 
insert into seccion values (@nombreSeccion, @codigoGrado, @dniProfesor, @numeroAnno, @numeroVacantes, @nivel,@eliminacionLogica)
end 
--fin del procedimientos almacenado registrar seccion

--creamos procedimientos almacenado para listarseccion 
create procedure listarSeccionP(
@grado int
) 
as 
begin
SELECT dbo.seccion.codigoSeccion, dbo.seccion.nombreSeccion
FROM     dbo.grado INNER JOIN
                  dbo.seccion ON dbo.grado.codigoGrado = dbo.seccion.codigoGrado 
				  WHERE  dbo.grado.numeroGrado=@grado and dbo.seccion.eliminacionLogica=0 and dbo.seccion.nivel='Primaria' and  dbo.grado.nivelGrado='Primaria'
end

create procedure listarSeccionI(
@grado int
) 
as 
begin
SELECT dbo.seccion.codigoSeccion, dbo.seccion.nombreSeccion
FROM     dbo.grado INNER JOIN
                  dbo.seccion ON dbo.grado.codigoGrado = dbo.seccion.codigoGrado 
				  WHERE  dbo.grado.numeroGrado=@grado and dbo.seccion.eliminacionLogica=0 and dbo.seccion.nivel='Inicial' and dbo.grado.nivelGrado='Inicial'

end
exec listarSeccionP 4
drop procedure listarSeccionI
drop procedure listarSeccionP
-- fin del procedimiento almacenado listar seccion


create procedure obtenerTablaSeccion
as
begin
 SELECT dbo.seccion.codigoSeccion, dbo.seccion.nombreSeccion, dbo.grado.numeroGrado, dbo.profesor.nombreProfesor, dbo.seccion.numeroAnno, dbo.seccion.numeroVacantes, dbo.seccion.nivel
FROM     dbo.grado INNER JOIN
                  dbo.seccion ON dbo.grado.codigoGrado = dbo.seccion.codigoGrado INNER JOIN
                  dbo.profesor ON dbo.seccion.dniProfesor = dbo.profesor.dniProfesor  where dbo.seccion.eliminacionLogica=0
end




create procedure decrementarVacante(@codigoGrado int,@codigoSeccion int)
as begin
UPDATE seccion
SET    numeroVacantes = numeroVacantes - 1 where codigoGrado=@codigoGrado and codigoSeccion=@codigoSeccion
end
exec decrementarVacante @codigoGrado=3, @codigoSeccion=9
drop procedure decrementarVacante

select * from seccion


create procedure VerificarSiExisteSeccionYGradoI(
@nombreSeccion varchar,
@codigoGrado int)
as begin 
SELECT * FROM seccion
          WHERE eliminacionLogica =0 and nombreSeccion= @nombreSeccion and codigoGrado=@codigoGrado and nivel='Inicial' 
END  
create procedure VerificarSiExisteSeccionYGradoP(
@nombreSeccion varchar,
@codigoGrado int)
as begin 
SELECT * FROM seccion
          WHERE eliminacionLogica =0 and nombreSeccion= @nombreSeccion and codigoGrado=@codigoGrado and nivel='Primaria' 
END  

