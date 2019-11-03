create database SistemaNotas

use SistemaNotas

create table usuario 
(
idUsuario int identity not null,
username varchar (50) not null,
contrasenia varchar (50) not null,
rol varchar (20) not null,
estado int default (1) not null,
created datetime default (getdate()),
updated datetime,
deleted datetime
)
alter table usuario add constraint pk_id_usuario primary key (idUsuario)