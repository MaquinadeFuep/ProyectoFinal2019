use SistemaNotas

create table estudiantes 
(
nie varchar (20) not null,
estado int default (1) not null,
created datetime default (getdate()) ,
updated datetime,
deleted datetime
)

alter table estudiantes add constraint pk_estudiantes primary key (nie)

create procedure spu_agregarestudiante
@id varchar (20)
as
insert into estudiantes (nie) values (@id)

exec spu_agregarestudiante '0097676578'



create procedure spu_borrarestudiante 
@id varchar (20)
as
update estudiantes
set estado = 0,
	deleted = getdate()
where nie = @id

exec spu_borrarmateria ''
