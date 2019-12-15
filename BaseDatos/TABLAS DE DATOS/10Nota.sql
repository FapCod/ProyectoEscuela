use Colegio_DB -- Usamos la database creada
------Creacion de la tabla Nota----------------
create table nota(
codigoNota int Identity(1,1) primary key not null, 
nota char(1) not null, 
descripcion varchar(100) not null, 
codigoCurso varchar(15), --fk
dniAlumno char(8), --fk 
codigoTrimestre varchar(10), --fk
numeroAnno int, --fk
dniProfesor varchar(10),
eliminacionLogica bit
CONSTRAINT fk_curso FOREIGN KEY (codigoCurso) REFERENCES Curso (codigoCurso),
CONSTRAINT fk_Trimestre FOREIGN KEY (codigoTrimestre) REFERENCES Trimestre (codigoTrimestre),
CONSTRAINT fk_anoEscolar  FOREIGN KEY (numeroAnno) REFERENCES annoEscolar (numeroAnno),
CONSTRAINT fk_alumnno  FOREIGN KEY (dniAlumno) REFERENCES alumno (dniAlumno)
)

------Fin de la tabla Nota---------------

