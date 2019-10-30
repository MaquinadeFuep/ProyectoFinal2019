use SistemaNotas


create table materias
(
id_materia varchar (15) not null,
nombre varchar (50) not null, 
horas_semanales int not null,
tipo_materia varchar (25) not null,
estado int default (1) not null,
created datetime default (getdate()) ,
updated datetime,
deleted datetime
)
alter table materias add constraint pk_materias primary key (id_materia)


--Procedimiento de agregacion-----------------------------------
create procedure spu_agregarmateria
@codigo varchar (15), 
@nombre  varchar (50),
@horas int,
@tipomateria varchar (25)
as
insert into materias(id_materia,nombre,horas_semanales,tipo_materia)
values (@codigo,@nombre,@horas,@tipomateria)


exec spu_agregarmateria 'MATE001', 'Matematicas', '20', 'Tècnica'


---Procedimiento de borrado-----------------
create procedure spu_borrarmateria
@codigo varchar (15)
as
update materias
set estado = 0,
	deleted = getdate()
where id_materia = @codigo

exec spu_borrarmateria 'MATE001'



--Actualizar-----------------------
create procedure spu_modificarmateria
@codigo varchar (15), 
@nombre  varchar (50),
@horas int,
@tipomateria varchar (25)
as 
update materias set  nombre=@nombre, horas_semanales = @horas, tipo_materia = @tipomateria, updated = getdate() 
where id_materia = @codigo

exec spu_modificarmateria 'MATE001', 'Matematicas', 15, 'Técnica'




