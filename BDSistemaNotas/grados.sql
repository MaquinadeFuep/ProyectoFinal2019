use SistemaNotas

create table grado
(
id_grado int identity (0,1) not null,
grado varchar (20) not null, 
seccion varchar (1),
estado int default (1) not null,
created datetime default (getdate()) ,
updated datetime,
deleted datetime,
)

alter table grado add constraint pk_grado primary key (id_grado)

--proceso de agregar

create procedure spu_agregar_grado
@nombre varchar (20),
@seccion varchar (1)
as
insert into grado (grado, seccion) values (@nombre, @seccion)

exec spu_agregar_grado


--proceso de modificar----

create procedure spu_modificar_grado
@id int,
@nombre varchar (20),
@seccion varchar (1)
as
update grado set  grado = @nombre,
				  seccion = @seccion,
				  updated = getdate ()
where id_grado = @id 

exec spu_modificar_grado

--proceso de eliminar---
create procedure spu_eliminar_grado
@id varchar (15),
@nombre varchar (70),
@seccion varchar (1)
as
update grado 
			set estado = 0, 
				deleted = getdate()
where id_grado = @id

exec spu_eliminar_grado