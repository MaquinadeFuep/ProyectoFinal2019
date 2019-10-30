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

alter table usuarios add estado int 

alter table usuarios add constraint pk_username primary key (username)

/* Algunos cambios que crei necesarios xD, el dui que no sea obligatorio porque eso significaria
que si no tiene dui no se podría meter sus notas, igual el telefono, y el genero que solo ponga M o F */
alter table usuarios alter column dui varchar (10)
alter table usuarios alter column telefono varchar (9)
alter table usuarios alter column genero varchar (1)

-------------------Procedimientos ------------------------------------------------------------

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
@tipocontrato varchar (50),
@estado int
as
insert into usuarios values (@nombreusuario, @contrasenia, @rol, @nombre, @apellido, @fecha_nacimiento, @telefono, @dui, @direccion, @genero, @tipocontrato,@estado)

exec spu_agregarusuarios 'Usuario001', '12345', 'Administrador', 'Nume', 'Minu', '12/06/1987', '', '', 'San Salvador', 'F', 'Por Hora','1'
select * from usuarios
--Procedimiento para borrar

create procedure spu_borrar_usuario
(
@id varchar (30)
)
as
begin 
delete from usuarios where username=@id;
end

exec spu_borrar_usuario 'Usuario004'

--Procedimiento de actualizar 

create procedure spu_modificar_usuario
(
@id varchar (15),
@contrasenia varchar (70),
@rol varchar (25),
@nombre varchar (50),
@apellido varchar (50),
@fechaNacimiento date,
@telefono varchar (9),
@dui varchar (10),
@direccion varchar (100),
@genero varchar (1),
@tipo_contrato varchar (50)
)
as
update usuarios 
set		
contrasenia=@contrasenia,
rol=@rol,
nombre=@nombre,
apellido=@apellido,
fecha_nacimiento=@fechaNacimiento,
telefono=@telefono,
dui=@dui,
direccion=@direccion,
genero=@genero,
tipo_contrato=@tipo_contrato
where username=@id

exec spu_modificar_usuario 'Usuario001', '123pandahermoso','Estudiante','Vlady','Martinez','12/02/2000','2310-3962','09876543-1','San Juan Opico','M','Mined'



select * from usuarios

