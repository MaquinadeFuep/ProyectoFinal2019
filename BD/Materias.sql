use SistemaDeNotas
create table materias
(
id_materia varchar(15) not null,
nombre varchar (30) not null,
horas_semanales int not null,
tipo_tecnico_general varchar (20) not null
)
alter table materias add constraint pk_materia primary key (id_materia)