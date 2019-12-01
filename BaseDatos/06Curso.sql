use Colegio_DB -- Usamos la database creada
------Creacion de la tabla Curso-----------------
create table curso(
codigoCurso varchar(15) Primary Key not null,
nombreCurso varchar (50)not null,
nivel varchar(20),
competencia1 varchar (80) not null,
competencia2 varchar (80) not null,
competencia3 varchar (80) not null,
)

------Fin de la creacion  de la tabla Curso------

--Insertamos los cursos de primaria e inicial a la tabla curso
insert into curso values ( 'COM01', 'Comunicacion','Primaria', 'Exposicion' , 'Trabajo', 'Examen')
insert into curso values ('PSC01'	, 'Personal Social','Primaria' ,'Exposicion'	,'Trabajo' ,	'Examen')
insert into curso values ('EFS01'	,'Educacion Fisica','Primaria'	,'Exposicion' ,	'Trabajo',	'Examen')
insert into curso values ('ACL01'	,'Arte y Cultura','Primaria'	,'Exposicion',	'Trabajo',	'Examen')
insert into curso values ('MAT01'	,'Matematica','Primaria',	'Exposicion' ,	'Trabajo',	'Examen')
insert into curso values ('CTA01',	'Ciencia Tecnologia y Ambiente','Primaria',	'Exposicion' ,	'Trabajo',	'Examen')
insert into curso values ('REL01', 'Religion','Primaria', 'Exposicion', 'Trabajo' , 'Examen')
insert into curso values ( 'ICOM01', 'Comunicacion','Inicial', 'Exposicion' , 'Trabajo', 'Examen')
insert into curso values ('IMAT01'	,'Matematica','Inicial',	'Exposicion' ,	'Trabajo',	'Examen')
insert into curso values ('IPSC01'	, 'Personal Social','Inicial' ,'Exposicion'	,'Trabajo' ,	'Examen')
insert into curso values ('ICTA01',	'Ciencia Tecnologia y Ambiente','Inicial',	'Exposicion' ,	'Trabajo',	'Examen')


