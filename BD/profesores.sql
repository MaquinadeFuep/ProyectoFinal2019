use SistemaDeNotas

create table profesores 
(
id_profesor varchar (15) not null,
)

alter table profesores add constraint pk_profesores primary key (id_profesor)