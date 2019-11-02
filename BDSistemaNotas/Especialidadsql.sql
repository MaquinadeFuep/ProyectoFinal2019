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

<<<<<<< HEAD
alter table especialidad add constraint pk_especialidad primary key (id_especialidad)
=======
alter table especialidad add constraint pk_especialidad primary key (id_especialidad)


>>>>>>> e87ad8723e6015a87cf4ea7e6f0959ed0f0f3806
