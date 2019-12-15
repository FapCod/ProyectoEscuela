use Colegio_DB -- Usamos la base de datos colegio_DB
--Creamos la tabla seccion
create table seccion(
codigoSeccion int IDENTITY(1,1) primary key not null,
nombreSeccion varchar(30)  not null,
codigoGrado int, --fk
dniProfesor char(8), --fk 
numeroAnno int, --fk
numeroVacantes int,
nivel varchar(20),
CONSTRAINT fk_gradoo FOREIGN KEY (codigoGrado) REFERENCES grado (codigoGrado),
CONSTRAINT fk_annoEscolar FOREIGN KEY (numeroanno) REFERENCES annoEscolar (numeroanno),
CONSTRAINT fk_profesoor FOREIGN KEY (dniProfesor) REFERENCES Profesor (dniProfesor)
)
--fin de la creacion de la tabla seccion

