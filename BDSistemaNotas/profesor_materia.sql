use SistemaNotas

create table profesor_materia
(
id_profesor_materia int identity (0,1) not null,
id_profesor varchar (15) not null,
id_materia varchar (15) not null,
);
<<<<<<< HEAD

alter table profesor_materia add constraint pk_profesor_materia primary key (id_profesor_materia)
=======
alter table profesor_materia add constraint pk_profesor_materia primary key (id_profesor_materia)
-- PRIMARY KEY AGREGADO
>>>>>>> 099dd2fb1e6e9deef073562a4ac497e72e3c65fb
