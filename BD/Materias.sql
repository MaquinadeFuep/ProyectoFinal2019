use SistemaDeNotas
create table materias
(
id_materia varchar(15) not null,
nombre varchar (30) not null,
horas_semanales int not null,
tipo_tecnico_general varchar (20) not null
)
alter table materias add constraint pk_materia primary key (id_materia)

--Creaciones de procedimiento para agregar
create procedure spu_agregar_materia
@id varchar(15),
@nombremate varchar (30),
@horas_semanales int,
@tipo_tecnico_general varchar (20)
as 
insert into materias values (@id,@nombremate, @horas_semanales,@tipo_tecnico_general)

exec spu_agregar_materia 'Mate1','Sociales','16','General'

--Creaciones de procedimiento para borrar
create procedure spu_borrar_materia
(
@id varchar (15)
)
as
begin 
delete from materias where id_materia=@id;
end

exec spu_borrar_materia 'Mate1'

--Creaciones de procedimiento para modificar- 
create procedure spu_modificar_nombre
(
@id varchar (15),
@nombremate varchar (30)
)
as
update materias
set		nombre=@nombremate
where id_materia=@id


exec spu_modificar_nombre 'Mate1', 'Matelinguistica'


