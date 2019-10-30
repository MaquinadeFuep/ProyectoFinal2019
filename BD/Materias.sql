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

--Creaciones de procedimiento para modificar nombre- 
create procedure spu_modificar_nombre
(
@id varchar (15),
@nombremate varchar (30)
)
as
update materias
set		nombre=@nombremate
where id_materia=@id

exec spu_modificar_nombre /* id */ 'Mate1', /* nombre que desea que desea que tenga */'Matelinguistica'

--Creaciones de procedimiento para modificar cantidad de horas semanales-- 

create procedure spu_modificar_canthorassemanales
(
@id varchar (15),
@horas_semanales int
)
as
update materias
set		horas_semanales=@horas_semanales
where id_materia=@id

exec spu_modificar_canthorassemanales/* id */ 'Mate1', /* nombre que desea que desea que tenga */'100'
select * from materias


--Creaciones de procedimiento para modificar cantidad de tipo tecnico o general-- 
create procedure spu_modificar_tipoTecGene
(
@id varchar (15),
@tipo_tecnico_general varchar (20)
)
as
update materias
set		tipo_tecnico_general=@tipo_tecnico_general 
where id_materia=@id

exec spu_modificar_tipoTecGene /* id */ 'Mate1', /* nombre que desea que desea que tenga */'Lass'
select * from materias

