	use SistemaNotas

create table estudiante_materia
(
id_estudiante_materia int identity (0,1) not null,
id_materia varchar (15) not null,
anio int,
nie varchar (7) not null,
)

alter table estudiante_materia add constraint pk_estudiante_materia primary key (id_estudiante_materia)
--NOTA, LLAVES PRIMARIA AGREGADA, NIE AGREGADO NOT NULL
