use Colegio_DB -- Colegio_DB la database creada
------Creacion de la tabla Matricula-----------------
create table matricula(
idMatricula int Identity(1,1) primary key not null, 
fechaMatricula date not null,
codigoGrado int, --fk
dniAlumno char(8), --fk 
numeroAnno int,  --fk
codigoSeccion int, --fk
nivelAlumno  varchar(20),
eliminacionLogica bit ,
CONSTRAINT fk_graddo FOREIGN KEY (codigoGrado) REFERENCES grado (codigoGrado),
CONSTRAINT fk_alumno FOREIGN KEY (dniAlumno) REFERENCES alumno (dniAlumno),
CONSTRAINT fk_annoEscolaar FOREIGN KEY (numeroAnno) REFERENCES annoEscolar (numeroAnno),
CONSTRAINT fk_seccionn FOREIGN KEY (codigoSeccion) REFERENCES seccion (codigoSeccion)
)
------Fin de la creacion  de la tabla Matricula------
