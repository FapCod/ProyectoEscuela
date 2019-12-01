use Colegio_DB -- Usamos la database creada
------Creacion de la tabla Trimestre-----------------
create table trimestre(
codigoTrimestre varchar(10) primary key not null,
descripcionTrimestre varchar (25) not null
)
------Fin de la creacion  de la tabla Trimestre-------
--insertamos los datos a la tabla trimestre
insert into trimestre values ('1Tri', 'Primer Trimestre') 
insert into trimestre values ('2Tri', 'Segundo Trimestre') 
insert into trimestre values ('3Tri', 'Tercer Trimestre') 
-- fin de la insercion a la tabla trimestre


