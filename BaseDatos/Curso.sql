use Colegio_DB -- Usamos la database creada
------Creacion de la tabla Curso-----------------
create table curso(
codigoCurso varchar(15) Primary Key not null,
nombreCurso varchar (50)not null,
competencia1 varchar (80) not null,
competencia2 varchar (80) not null,
competencia3 varchar (80) not null,
)
------Fin de la creacion  de la tabla Curso------
insert into curso values ( 'COM01', 'Comunicacion', 'Exposicion' , 'Trabajo', 'Examen')
insert into curso values ('PSC01'	, 'Personal Social' ,'Exposicion'	,'Trabajo' ,	'Examen')
insert into curso values ('EFS01'	,'Educacion Fisica'	,'Exposicion' ,	'Trabajo',	'Examen')
insert into curso values ('ACL01'	,'Arte y Cultura'	,'Exposicion',	'Trabajo',	'Examen')
insert into curso values ('MAT01'	,'Matematica',	'Exposicion' ,	'Trabajo',	'Examen')
insert into curso values ('CTA01',	'Ciencia Tecnologia y Ambiente',	'Exposicion' ,	'Trabajo',	'Examen')
insert into curso values ('REL01', 'RELIGION', 'Exposicion', 'Trabajo' , 'Examen')
