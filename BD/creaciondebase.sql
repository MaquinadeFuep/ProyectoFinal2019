create database SistemaDeNotas

use SistemaDeNotas

create table usuarios
(
username varchar (30) not null,
contrasenia varchar (30) not null,
rol varchar (25) not null,
nombre varchar (50) not null,
apellido varchar (50) not null,
fecha_nacimiento date not null,
telefono varchar (10) not null,
dui varchar (15) not null,
direccion varchar (100)  not null,
genero varchar (25) not null,
tipo_contrato varchar (50) not null,
)

alter table usuarios alter column contrasenia varchar (70) not null