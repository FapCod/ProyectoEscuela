-------------------------------------------------------------------------------------------
---->>>>>>>>>PROCEDIMIENTOS ALMACENADOS TABLA GRADO<<<<<<<-----------
-------------------------------------------------------------------------------------------

--creamos procedimiento para listar los grados de inicial 
create procedure listarGradoI
as 
begin
SELECT codigoGrado,numeroGrado
FROM     dbo.grado 
			where nivelGrado = 'Inicial'
end
--fin de la creacion del procedimiento almacenado 


--creamos procedimiento para listar los grados de primaria 
create procedure listarGradoP
as 
begin
SELECT codigoGrado,numeroGrado
FROM     dbo.grado
		 where nivelGrado = 'Primaria' 
end
--fin de la creacion del procedimiento almacenado 