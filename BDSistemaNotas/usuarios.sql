create database SistemaNotas

use SistemaNotas

create table usuario 
(
idUsuario varchar (15) not null,
username varchar (50) not null,
contrasenia varchar (50) not null,
rol varchar (20) not null,
relacion varchar (50) not null,
estado int default (1) not null,
created datetime default (getdate()),
updated datetime,
deleted datetime
)
alter table usuario add constraint pk_id_usuario primary key (idUsuario)

--Procedimiento para agregar usuarios

create procedure spu_agregarusuarios
@id_usuario varchar (15),
@username varchar (50),
@contrasenia varchar (50),
@rol varchar (20), 
@relacion varchar (50)
as
insert into usuario (idUsuario, username, contrasenia, rol, relacion)
values (@id_usuario, @username, @contrasenia, @rol, @relacion)

exec spu_agregarusuarios '','','','','','','','','',''

--Procedimiento para modificar usuario

create procedure spu_modificarusuario
@id_usuario varchar (15),
@username varchar (50),
@contrasenia  varchar (50),
@relacion varchar (50)
as
update usuario
set		username = @username,
		contrasenia = @contrasenia,
		updated = getdate()
where idUsuario = @id_usuario

exec spu_modificarusuario '','','', '','','','',''

--Procedimiento para borrado logico

create procedure spu_borrado_logico_usuario
@id varchar (30)
as
update usuario
set estado=0,
	deleted=getdate()	
where idUsuario=@id

exec spu_borrado_logico_usuario ''

<<<<<<< HEAD

=======
>>>>>>> 099dd2fb1e6e9deef073562a4ac497e72e3c65fb


