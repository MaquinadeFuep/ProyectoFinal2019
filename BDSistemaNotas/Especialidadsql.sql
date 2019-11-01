use SistemaNotas

create table especialidad
(
id_especialidad varchar (15) not null,
nombre varchar (35)
);

alter table especialidad add constraint pk_especialidad primary key (id_especialidad)



