use SistemaNotas

create table alumnos 
(
nie varchar (7) not null,
dui varchar (10) null, --asi va? porque no todos los vatos son mayores de edad siono raza, exec con Sichar referencia de may esecuéle
nombre varchar (50) not null,
apellido varchar (50) not null,
fecha_nacimiento date not null,
telefono varchar (9) not null,
genero varchar (10)not null,
direccion varchar (70)not null,
estado int default (1) not null,
created datetime default (getdate()) ,
updated datetime,
deleted datetime
)

alter table alumnos add constraint pk_alumnos primary key (nie)
alter table alumnos add id_grado varchar (15) not null


create procedure spu_agregarestudiante
@id varchar (7),
@nombre varchar (50),
@apellido varchar (50),
@fecha_nacimiento date,
@telefono varchar (9),
@genero varchar (10),
@direccion varchar (70)
as
insert into alumnos  (nie, nombre, apellido, fecha_nacimiento, telefono, genero, direccion) 
values (@id, @nombre, @apellido, @fecha_nacimiento, @telefono, @genero, @direccion)

exec spu_agregarestudiante 


--Procedimiento de borrado logico
create procedure spu_borrarestudiante 
@id varchar (7)
as
update alumnos 
set estado = 0,
	deleted = getdate()
where nie = @id

exec spu_borrarestudiante
