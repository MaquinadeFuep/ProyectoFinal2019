use SistemaNotas
create table anioEscolar 
(
id_anio varchar (15) not null,
anio int,
estado int default (1) not null,
created datetime default (getdate()) ,
updated datetime,
deleted datetime
);
alter table anioEscolar add constraint pk_anio primary key (id_anio)
