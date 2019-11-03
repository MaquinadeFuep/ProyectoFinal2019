use SistemaNotas

create table profesor_materia
(
id_profesor_materia int identity (0,1) not null,
id_profesor int  not null,
id_materia int not null,
)


alter table profesor_materia add constraint pk_profesor_materia primary key (id_profesor_materia)
