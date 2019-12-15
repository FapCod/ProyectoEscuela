-------------------------------------------------------------------------------------------
---->>>>>>>>>PROCEDIMIENTOS ALMACENADOS TABLA SECCION<<<<<<<-----------
-------------------------------------------------------------------------------------------

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

--creamos procedimientos almacenado para listar seccion de primaria
create procedure listarSeccionP(
@anno int ,
@grado int
) 
as 
begin
SELECT dbo.seccion.codigoSeccion, dbo.seccion.nombreSeccion
FROM     dbo.grado INNER JOIN
                  dbo.seccion ON dbo.grado.codigoGrado = dbo.seccion.codigoGrado 
				  WHERE  dbo.grado.numeroGrado=@grado and dbo.seccion.nivel='Primaria' and  dbo.grado.nivelGrado='Primaria' and dbo.seccion.numeroAnno=@anno
end
--fin de la creacion del procedimiento almacenado 

--creamos procedimientos almacenado para listar seccion de inicial
create procedure listarSeccionI(
@anno int ,
@grado int
) 
as 
begin
SELECT dbo.seccion.codigoSeccion, dbo.seccion.nombreSeccion
FROM     dbo.grado INNER JOIN
                  dbo.seccion ON dbo.grado.codigoGrado = dbo.seccion.codigoGrado 
				  WHERE  dbo.grado.numeroGrado=@grado  and dbo.seccion.nivel='Inicial' and dbo.grado.nivelGrado='Inicial' and dbo.seccion.numeroAnno=@anno

end
-- fin del procedimiento almacenado listar seccion

--creamos procedimiento almacenado para obtener datos de la tabla seccion
create procedure obtenerTablaSeccion
as
begin
 SELECT dbo.seccion.codigoSeccion, dbo.seccion.nombreSeccion, dbo.grado.numeroGrado, dbo.profesor.nombreProfesor, dbo.seccion.numeroAnno, dbo.seccion.numeroVacantes, dbo.seccion.nivel
FROM     dbo.grado INNER JOIN
                  dbo.seccion ON dbo.grado.codigoGrado = dbo.seccion.codigoGrado INNER JOIN
                  dbo.profesor ON dbo.seccion.dniProfesor = dbo.profesor.dniProfesor  
end
--fin de la creacion del procedimiento almacenado 


--creamos procedimiento almanceado para decrementar el numero de vacantes de una seccion
create procedure decrementarVacante(@codigoGrado int,@codigoSeccion int)
as begin
UPDATE seccion
SET    numeroVacantes = numeroVacantes - 1 where codigoGrado=@codigoGrado and codigoSeccion=@codigoSeccion 
end
--fin de la creacion del procedimiento almacenado 

--creamos procedimiento almanceado para aumentar el numero de vacantes de una seccion
create procedure aumentarVacante(@codigoGrado int,@codigoSeccion int)
as begin
UPDATE seccion
SET    numeroVacantes = numeroVacantes + 1 where codigoGrado=@codigoGrado and codigoSeccion=@codigoSeccion 
end
--fin de la creacion del procedimiento almacenado 





----creamos procedimiento almacenado para verificar si aun hay vacantes en una seccion
create procedure VerificarSiHayVacante(@codigoGrado int)
as begin
Select * from seccion 
WHERE numeroVacantes=0 and codigoGrado=@codigoGrado
end
----fin de la creacion del procedimietno almacenado



--creamos procedimiento almacenado para verificar si existe una seccion y grado en inicial
create procedure VerificarSiExisteSeccionYGradoI(
@anno int ,
@nombreSeccion varchar,
@codigoGrado int)
as begin 
SELECT * FROM seccion
          WHERE   nombreSeccion= @nombreSeccion and codigoGrado=@codigoGrado and nivel='Inicial' and numeroAnno=@anno 
END 
--fin de la creacion del procedimietno almacenado 

--creamos procedimiento almacenado para verificar si existe una seccion y grado en primaria
create procedure VerificarSiExisteSeccionYGradoP(
@anno int ,
@nombreSeccion varchar,
@codigoGrado int)
as begin 
SELECT * FROM seccion
          WHERE  nombreSeccion= @nombreSeccion and codigoGrado=@codigoGrado and nivel='Primaria' and numeroAnno=@anno
END  
--fin de la creacion del procedimietno almacenado


