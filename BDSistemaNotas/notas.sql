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

-- no se si asi va bien