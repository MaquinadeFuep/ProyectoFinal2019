use sistemaNotas


create procedure spu_agregarestudiante_usuario
@id varchar (7),
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
values (@id,@dui, @nombre, @apellido, @fecha_nacimiento, @telefono, @genero, @direccion,@idgrado)
insert into usuario (idUsuario,username, contrasenia, rol) 
values (@id,@id , @contrasenia, @rol )


exec spu_agregarestudiante_usuario '0287376','09876543-1','Rafael','Martinez','02/02/2000','7090-2332','Masculino','Su casa','contraseña','rol','grado1'
select * from alumnos
select * from usuario


delete 
from usuario
where idUsuario = '0287376'
insert into grado (id_grado,grado,seccion,id_especialidad) values ('grado1','Primero','A','Espe1')
insert into especialidad (id_especialidad,nombre) values ('Espe1','General')