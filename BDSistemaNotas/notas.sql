use SistemaNotas

create table notas
(
id_nota int identity (0,1) not null, 
puntaje float, 
es_paes int default (0),
periodo int,
estado int default (1) not null,
created datetime default (getdate()) ,
updated datetime,
deleted datetime,
id_materia int not null
)


alter table notas add constraint pk_notas primary key (id_nota)

