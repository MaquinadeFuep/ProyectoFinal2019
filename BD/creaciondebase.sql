create database SistemaDeNotas

use SistemaDeNotas

create table usuarios
(
username varchar (30) not null,
contrasenia varchar (70) not null, 
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

alter table usuarios add constraint pk_username primary key (username)


-------------------Procedimientos ------------------------------------------------------------

create procedure spu_agregarusuarios
@nombreusuario varchar (30), 
@contrasenia varchar (70),
@rol varchar (25),
@nombre varchar (50),
@apellido varchar (50),
@fecha_nacimiento date,
@telefono varchar (10),
@dui varchar (15),
@direccion varchar (100),
@genero varchar (25),
@tipocontrato varchar (50)
as
insert into usuarios values (@nombreusuario, @contrasenia, @rol, @nombre, @apellido, @fecha_nacimiento, @telefono, @dui, @direccion, @genero, @tipocontrato)

exec spu_agregarusuarios 'Usuario003', '12345', 'Administrador', 'Nume', 'Minu', '12/06/1987', '7873-9839', '00456787-9', 'San Salvador', 'Masculino', 'Por Hora'



--Procedimiento para borrar

create procedure spu_borrar_usuario
(
@id varchar (30)
)
as
begin 
delete from usuarios where username=@id;
end

exec spu_borrar_usuario 'Usuario001'


--Procedimiento de actualizar (ejemplo: de nombre de direccion)
create procedure spu_modificar
(
@id varchar (15),
@direccion varchar (100)
)
as
update usuarios 
set		direccion=@direccion
where username=@id


exec spu_modificar 'Usuario003', 'Santa Tecla'

select * from usuarios
