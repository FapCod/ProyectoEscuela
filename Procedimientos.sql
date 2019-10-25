---------------------------------------------------------------------------
----------------------PRIMER PROCEDIMIENTOS-----------------
---------------------------------------------------------------------------
--mostrar alumnos unicamente de la seccion de 4 A 
create procedure MostarAlum(
@seccion varchar (50),
@grado int
)
as
	 
	if	@seccion = 'A' and @grado = '4'
	begin
		select a.NombreAlumno, a.ApellidosAlumno 
		from Alumno a
		where a.SeccionAlumno = 'A' and a.GradoAlumno = '4'
		end
	else 
	begin
	print 'No hay Alumnos' 
end 
	exec RegistrarAlum 'Marko', 'Urbina', 'M', 'Primaria', '4', 'A', 'Av. Peru','Francisco'
	exec RegistrarAlum 'Frank', 'piñin', 'M', 'Primaria', '5', 'A', 'Av. Peru','Francisco'
	select * from alumno
	exec MostarAlum 'A' , '4'
	drop procedure MostarAlum
	
---------------------------------------------------------------------------
----------------------SEGUNDO PROCEDIMIENTOS-----------------
---------------------------------------------------------------------------

CREATE PROCEDURE GradoAlum(
@grado int
)
as
	if @grado = '1'
	begin
	select a.NombreAlumno, a.ApellidosAlumno, a.GradoAlumno
	from Alumno a
	where GradoAlumno = '1'
	end 
	else if @grado =  '2'
	begin
	select a.NombreAlumno, a.ApellidosAlumno, a.GradoAlumno
	from Alumno a
	where GradoAlumno= '2'
	end
	else if @grado =  '3'
	begin
	select a.NombreAlumno, a.ApellidosAlumno, a.GradoAlumno
	from Alumno a
	where GradoAlumno = '3'
	end
	else if @grado =  '4'
	begin
	select a.NombreAlumno, a.ApellidosAlumno, a.GradoAlumno
	from Alumno a
	where GradoAlumno= '4'
	end
	else if @grado =  '5'
	begin
	select a.NombreAlumno, a.ApellidosAlumno, a.GradoAlumno
	from Alumno a
	where GradoAlumno = '5'
	end
	else if @grado =  '6'
	begin
	select a.NombreAlumno, a.ApellidosAlumno, a.GradoAlumno
	from Alumno a
	where GradoAlumno = '6'
     end 

exec GradoAlum 2
select * from Alumno