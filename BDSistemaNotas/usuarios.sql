create database SistemaNotas
use SistemaNotas

create table usuarios 
(
username varchar (30) not null,
contrasenia varchar (70) not null, 
rol varchar (25) not null,
nombre varchar (50) not null,
apellido varchar (50) not null,
fecha_nacimiento date not null,
telefono varchar (9) not null,
dui varchar (10) ,
direccion varchar (100)  not null,
genero varchar (1) not null,
tipo_contrato varchar (50) not null,
estado int default (1) not null,
created datetime default (getdate()) ,
updated datetime,
deleted datetime
)

alter table usuarios add constraint pk_username primary key (username)

create procedure spu_agregarusuarios
@nombreusuario varchar (30), 
@contrasenia varchar (70),
@rol varchar (25),
@nombre varchar (50),
@apellido varchar (50),
@fecha_nacimiento date,
@telefono varchar (9),
@dui varchar (10),
@direccion varchar (100),
@genero varchar (1),
@tipocontrato varchar (50)
as
insert into usuarios (username,contrasenia,rol,nombre,apellido,fecha_nacimiento,telefono,dui,direccion,genero,tipo_contrato)
values (@nombreusuario, @contrasenia, @rol, @nombre, @apellido, @fecha_nacimiento, @telefono, @dui, @direccion, @genero, @tipocontrato)

exec spu_agregarusuarios 'OSO232','Perreando','Admin','vlady','social','02/12/2000','7090-2332','09876543-1','Quezaltepeque','M','Mined'
select * from usuarios