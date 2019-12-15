USE Colegio_DB
--llenamos datos a la tabla matricula a traves del procedimiento almacenado 
exec registrarMatricula '2019-03-05' , 2, '22059147', 2019, 1, 'Inicial' , 'false'
exec registrarMatricula '2019-03-06' , 5, '25696971', 2019, 5, 'Primaria' , 'false'
exec registrarMatricula '2019-03-08' , 4, '72589658', 2019, 7, 'Primaria' , 'false'
exec registrarMatricula '2019-03-15' , 8, '47431609', 2019, 4, 'Primaria' , 'false'
exec registrarMatricula '2019-03-13' , 9, '12658685', 2019, 9, 'Primaria' , 'false'
