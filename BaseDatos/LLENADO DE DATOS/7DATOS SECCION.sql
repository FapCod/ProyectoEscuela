--llenado a la base de datos seccion 
exec registrarSeccion 'A', 1, '72457239', 2019, 25, 'Inicial' 
exec registrarSeccion 'A', 2, '64582356', 2019, 25, 'Inicial' 
exec registrarSeccion 'A', 3, '45678958', 2019, 25, 'Inicial' 
exec registrarSeccion 'A', 4, '02568954', 2019, 25, 'Primaria' 
exec registrarSeccion 'A', 5, '01589523', 2019, 25, 'Primaria' 
exec registrarSeccion 'A', 6, '02587458', 2019, 25, 'Primaria' 
exec registrarSeccion 'A', 7, '03698521', 2019, 25, 'Primaria' 
exec registrarSeccion 'A', 8, '01258974', 2019, 25, 'Primaria' 
exec registrarSeccion 'A', 9, '01256983', 2019, 25, 'Primaria' 

--reinicia el contador a cero 
--DBCC CHECKIDENT (seccion, RESEED, 0)

Select * from seccion