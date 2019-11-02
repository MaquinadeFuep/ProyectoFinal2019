use SistemaNotas

create table notas
(
id_nota varchar (15) not null, 
puntaje float, 
nota1 float not null,
nota2 float not null, 
nota3 float not null,
promedio_final float not null,
promedio_institucional float not null,
paes float,
estado int default (1) not null,
created datetime default (getdate()) ,
updated datetime,
deleted datetime,
)

alter table notas add id_materia varchar (15) not null
alter table notas add constraint pk_notas primary key (id_nota)
-- no se si asi va bien