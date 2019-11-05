use Colegio_DB -- Usamos la database creada
------Creacion de la tabla GradoSeccion-----------------
create table gradoseccion(
idGradoSeccion int identity(1,1) Primary Key not null,
gradoSeccion varchar (6)not null,
numeroAula varchar (6)not null,
nivel varchar (11)not null
)
------Fin de la creacion  de la tabla GradoSeccion------



----Crear procedimiento AgregarGradoSeccion-------------
create procedure agregargradoseccion (
@grado varchar(6),
@seccion varchar(25),
@numeroAula int ,
@nivel varchar (20)
)
as
begin
insert into gradoseccion (gradoSeccion, numeroAula,  Nivel) values ( @grado, @seccion, @numeroAula, @nivel)
end 
---Finalizacion de la creacion del procedimiento AgregarGradoSeccion-------