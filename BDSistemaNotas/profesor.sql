use SistemaNotas

create table profesores
(
id_profesor int identity (0,1) not null,
escalafon varchar (15) not null,
dui varchar (10) not null,
nombre varchar (50) not null,
apellido varchar (50) not null, 
fecha_nacimiento date not null,
estado_civil varchar (15) not null,
telefono varchar (10) not null,
direccion varchar (70) not null,
genero varchar (10) not null,
salario money not null,
estado int default (1) not null,
created datetime default (getdate()) ,
updated datetime,
deleted datetime
)

alter table profesores add constraint pk_profesor primary key (id_profesor)


--Procedimiento para agregar profesor

create procedure spu_agregar_profesor
@idprofesor varchar (15),
@dui varchar (10),
@nombre varchar (50),
@apellido varchar (50),
@fecha_nacimiento date,
@estado varchar (15),
@telefono varchar (10),
@direccion varchar (70),
@genero varchar (10),
@salario money,
@contrasenia varchar (50),
@rol varchar (20)
as
insert into profesores (escalafon,dui, nombre, apellido, fecha_nacimiento, estado_civil, telefono, direccion, genero, salario)
values (@idprofesor,@dui, @nombre, @apellido, @fecha_nacimiento, @estado, @telefono, @direccion, @genero, @salario)

insert into usuario (idUsuario, username, contrasenia, rol)
values (@idprofesor, @idprofesor, @contrasenia, @rol)

exec spu_agregar_profesor '0049043943', '09876543-2', 'Alfredo', 'Pacheco', '12/02/1986', 'Casado', '7382-0937', 'Enrique Segoviano', 'Masculino', 400, 'Profe1', 'Profesor'



--Procedimiento para eliminación logica de profesor

create procedure spu_borradoLogico_profesor
@id varchar (15)
as
update profesores
set estado=0 ,
	deleted=getdate()
where escalafon=@id

exec spu_borradoLogico_profesor ''
 
 --Procedimiento para modificación de profesor
 
create procedure spu_modificacion_profesor
@id varchar (15),
@nombre varchar (50),
@apellido varchar (50),
@fecha_nacimiento date,
@estado varchar (15),
@telefono varchar (10),
@direccion varchar (70),
@genero varchar (10),
@salario money,
@contraseña varchar (50)
as
update profesores
set nombre = @nombre,
	apellido = @apellido,
	fecha_nacimiento = @fecha_nacimiento,
	estado_civil = @estado,
	telefono = @telefono,
	direccion = @direccion,
	genero = @genero,
	salario = @salario,
	updated=getdate()
where escalafon = @id
update usuarios
set nombre = @nombre,
	contrasenia = @contraseña
	where username=@id


