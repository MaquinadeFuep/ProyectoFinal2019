use SistemaNotas

create table grado
(
id_grado varchar (15) not null,
grado varchar (70) not null, --por si se llegase a poner "bachillerato tecnico en bla bla bla" lo deje de 70
seccion varchar (1),
estado int default (1) not null,
created datetime default (getdate()) ,
updated datetime,
deleted datetime,
)

alter table grado add id_especialidad varchar (15) not null

<<<<<<< HEAD
=======

>>>>>>> e87ad8723e6015a87cf4ea7e6f0959ed0f0f3806

alter table grado add constraint pk_grado primary key (id_grado)

--proceso de agregar
create procedure spu_agregar_grado
@id varchar (15),
@nombre varchar (70),
@seccion varchar (1)
as
insert into grado (id_grado, grado, seccion) values (@id, @nombre, @seccion)

exec spu_agregar_grado


--proceso de modificar----
create procedure spu_modificar_grado
@id varchar (15),
@nombre varchar (70),
@seccion varchar (1)
as
update grado set id_grado = @id,
				  grado = @nombre,
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