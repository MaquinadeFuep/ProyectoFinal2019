use SistemaNotas

create table especialidad
(
id_especialidad varchar (15) not null,
nombre varchar (35),
estado int default (1) not null,
created datetime default (getdate()) ,
updated datetime,
deleted datetime,
);

alter table especialidad add constraint pk_especialidad primary key (id_especialidad)


