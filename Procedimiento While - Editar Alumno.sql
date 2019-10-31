use Colegio_DB
create procedure Actualum (
@Id int,
@NombreAlum varchar (50),
@ApellidoAlum varchar(50),
@SexoAlum char(50),
@NivelAlum varchar(20),
@GradoAlum int, 
@SeccionAlum char(1),
@DireccionAlum varchar(50),
@NombreApoderadoNew varchar(50)
) 
as
WHILE EXISTS (SELECT * FROM ALUMNO WHERE Idalumno = @Id)
begin
    update alumno 
	set NombreAlumno = @NombreAlum,
		ApellidosAlumno =@ApellidoAlum ,
		SexoAlumno = @SexoAlum,
		NivelAlumno = @NivelAlum,
		GradoAlumno = @GradoAlum, 
		SeccionAlumno = @SeccionAlum,
		DireccionAlumno =@DireccionAlum,
		NombreApoderado = @NombreApoderadoNew
	where Idalumno =@Id
	break
end

exec Actualum '3', 'Marko Alessandro', 'Arrunategui', 'M','Secundaria','6','C','Consuelo de Velasco', 'Terminator'

drop procedure Actualum

select*from alumno




