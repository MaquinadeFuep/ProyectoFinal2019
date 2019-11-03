create database SistemaNotas
use SistemaNotas

create table alumnos 
(
id_alumnos int identity (0,1) not null,
nie varchar (7) not null,
dui varchar (10) null, --asi va? porque no todos los vatos son mayores de edad siono raza, exec con Sichar referencia de may esecuéle
nombre varchar (50) not null,
apellido varchar (50) not null,
fecha_nacimiento date not null,
telefono varchar (9) not null,
genero varchar (10)not null,
direccion varchar (70)not null,
id_grado int not null,
estado int default (1) not null,
created datetime default (getdate()) ,
updated datetime,
deleted datetime
)

alter table alumnos add constraint pk_alumnos primary key (id_alumnos)

create procedure spu_agregarestudiante_usuario
@nie varchar (7),
@dui varchar (10),
@nombre varchar (50),
@apellido varchar (50),
@fecha_nacimiento date,
@telefono varchar (9),
@genero varchar (10),
@direccion varchar (70),
@contrasenia varchar (50),
@rol varchar (20),
@idgrado varchar (15)
as
insert into alumnos  (nie,dui, nombre, apellido, fecha_nacimiento, telefono, genero, direccion,id_grado) 
values (@nie,@nie, @nombre, @apellido, @fecha_nacimiento, @telefono, @genero, @direccion,@idgrado)
insert into usuario (idUsuario,username, contrasenia, rol) 
values (@nie,@nie , @contrasenia, @rol )


--Procedimiento de borrado logico
create procedure spu_borrarestudiante 
@id varchar (7)
as
update alumnos 
set estado = 0,
	deleted = getdate()
where nie = @id

exec spu_borrarestudiante
