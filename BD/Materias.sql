use SistemaDeNotas

create table materias
(
id_materia varchar(15) not null,
nombre varchar (30) not null,
horas_semanales int not null,
tipo_tecnico_general varchar (20) not null,
estado int default (1) not null
)

alter table materias add constraint pk_materia primary key (id_materia)

--Creaciones de procedimiento para agregar
create procedure spu_agregar_materia
@id varchar(15),
@nombremate varchar (30),
@horas_semanales int,
@tipo_tecnico_general varchar (20),
@estado int
as 
insert into materias values (@id,@nombremate, @horas_semanales,@tipo_tecnico_general,@estado)

exec spu_agregar_materia 'Mate1','Sociales','16','General','1'

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

--Creaciones de procedimiento para modificar materias- 

create procedure spu_modificar_materia
(
@id varchar (15),
@nombremate varchar (30),
@horas_semanales int,
@tipo_tecnico_general varchar (20)
)
as
update materias
set		nombre=@nombremate,
		horas_semanales=@horas_semanales,
		tipo_tecnico_general=@tipo_tecnico_general
where id_materia=@id

exec spu_modificar_materia /* id */ 'Mate1', 'Matelinguistica','69','Tecnico'

alter table materias add estado int 

--Procedimiento para borrado logico de materias

create procedure spu_borradologicomaterias
@id varchar (15)
as
update materias
set		estado=0		
where id_materia=@id

exec spu_borradologicomaterias 'Mate1'

--Procedimiento para mostrar datos ocultos logico de materias
create procedure spu_mostradologicomaterias
@id varchar (15)
as
update materias
set		estado=1		
where id_materia=@id

exec spu_mostradologicomaterias 'Mate1'
