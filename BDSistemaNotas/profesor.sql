use SistemaNotas

create table profesor
(
id_profesor varchar (15) not null,
estado int default (1) not null,
created datetime default (getdate()) ,
updated datetime,
deleted datetime
)

alter table profesor add constraint pk_profesor primary key (id_profesor)

alter table profesor add  salario float not null
alter table profesor add  tipo_contrato varchar (50) not null

--Procedimiento para agregar profesor

create procedure spu_agregar_profesor
@id varchar (15)
as
insert into profesor (id_profesor) values (@id)

exec spu_agregar_profesor ''

--Procedimiento para eliminación logica de profesor
create procedure spu_borradoLogico_profesor
@id varchar (15)
as
update profesor
set estado=0 ,
	deleted=getdate()
where id_profesor=@id

exec spu_borradoLogico_profesor ''
 
 --cwhaghdgadjkhkjwhdkjwehdkwjedhwkjdhwk