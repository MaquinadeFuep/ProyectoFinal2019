use SistemaNotas


create table materia
(
id_materia int identity (0,1) not null,
nombre varchar (50) not null, 
horas_semanales int not null,
tipo_materia varchar (25) not null,
anio int not null,
estado int default (1) not null,
created datetime default (getdate()) ,
updated datetime,
deleted datetime
)

alter table materia add constraint pk_materia primary key (id_materia)


--Procedimiento de agregacion-----------------------------------

create procedure spu_agregarmateria
@nombre  varchar (50),
@horas int,
@tipomateria varchar (25)
as
insert into materia(nombre,horas_semanales,tipo_materia)
values (@nombre,@horas,@tipomateria)


exec spu_agregarmateria 


---Procedimiento de borrado-----------------

create procedure spu_borrarmateria
@codigo int 
as
update materia
set estado = 0,
	deleted = getdate()
where id_materia = @codigo

exec spu_borrarmateria 



--Actualizar-----------------------
create procedure spu_modificarmateria
@codigo int , 
@nombre  varchar (50),
@horas int,
@tipomateria varchar (25)
as 
update materia set  nombre=@nombre,
					horas_semanales = @horas,
					tipo_materia = @tipomateria, 
					updated = getdate() 
where id_materia = @codigo




