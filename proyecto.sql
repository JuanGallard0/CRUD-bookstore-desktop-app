--		TABLAS

--Tabla rol
create table rol (
	idrol integer primary key identity,
	nombre varchar(30) not null,
	descripcion varchar(255) null,
	estado bit default(1)
);
go
--Tabla usuario
create table usuario (
	idusuario integer primary key identity,
	idrol integer not null,
	nombre varchar(100) not null,
	tipo_documento varchar(20) null,
	num_documento varchar(20) null,
	direccion varchar(70) null,
	telefono varchar(20) null,
	email varchar(50) not null,
	clave varbinary(MAX) not null,
	estado bit default(1),
	FOREIGN KEY (idrol) REFERENCES rol(idrol)
);
go
--Tabla libro
create table libro (
	idlibro integer primary key identity,
	cant_ejemplares integer default(1),
	isbn varchar(50) not null unique,
	titulo varchar(100) not null,
	autor varchar(100) not null,
	editorial varchar(100) not null,
	year_edicion integer null,
	num_edicion integer null,
	pais varchar(50) null,
	idioma varchar(50) null,
	materia varchar(50) null,
	num_paginas integer null,
	ubicacion integer null,
	descripcion varchar(255) null,
	estado bit default(1)
);
go
--Tabla prestamo
create table prestamo (
	idprestamo integer primary key identity,
	idusuario integer not null,
	idlibro integer not null,
	fecha_prestamo datetime not null,
	fecha_devolucion datetime not null,
	FOREIGN KEY (idusuario) REFERENCES usuario(idusuario) ON DELETE CASCADE,
	FOREIGN KEY (idlibro) REFERENCES libro(idlibro) ON DELETE CASCADE
);
go

--		PROCEDIMIENTOS

--procedimiento listar rol
create proc rol_listar
as
select idrol, nombre from rol
where estado=1
go
--Procedimiento Listar usuario
create proc usuario_listar
as
	select u.idusuario as ID,u.idrol, r.nombre as Rol,u.nombre as Nombre,
	u.tipo_documento as Tipo_Documento,u.num_documento as Num_Documento,
	u.direccion as Direccion,u.telefono as Telefono,u.email as Email,
	u.estado as Estado
	from usuario u inner join rol r on u.idrol=r.idrol
	order by u.idusuario desc
go
--Procedimiento Listar usuario profesor
create proc usuario_listar_profesores
as
	select u.idusuario as ID,u.idrol, r.nombre as Rol,u.nombre as Nombre,
	u.tipo_documento as Tipo_Documento,u.num_documento as Num_Documento,
	u.direccion as Direccion,u.telefono as Telefono,u.email as Email,
	u.estado as Estado
	from usuario u inner join rol r on u.idrol=r.idrol
	where u.idrol=2
	order by u.idusuario desc
go
--Procedimiento Buscar usuario
create proc usuario_buscar
@valor varchar(50)
as
	select u.idusuario as ID,u.idrol, r.nombre as Rol,u.nombre as Nombre,
	u.tipo_documento as Tipo_Documento,u.num_documento as Num_Documento,
	u.direccion as Direccion,u.telefono as Telefono,u.email as Email,
	u.estado as Estado
	from usuario u inner join rol r on u.idrol=r.idrol
	where u.nombre like '%' +@valor + '%' Or u.email like '%' +@valor + '%'
	order by u.nombre asc
go
--Procedimiento Insertar usuario
create proc usuario_insertar
@idrol integer,
@nombre varchar(100),
@tipo_documento varchar(20),
@num_documento varchar(20),
@direccion varchar(70),
@telefono varchar(20),
@email varchar(50),
@clave varchar(50)
as
	insert into usuario (idrol,nombre,tipo_documento,num_documento,direccion,telefono,email,clave)
	values (@idrol,@nombre,@tipo_documento,@num_documento,@direccion,@telefono,@email,HASHBYTES('SHA2_256',@clave))
go
--Procedimiento Actualizar usuario
create proc usuario_actualizar
@idusuario integer,
@idrol integer,
@nombre varchar(100),
@tipo_documento varchar(20),
@num_documento varchar(20),
@direccion varchar(70),
@telefono varchar(20),
@email varchar(50),
@clave varchar(50)
as
if @clave<>''
	update usuario set idrol=@idrol,nombre=@nombre,tipo_documento=@tipo_documento,
	num_documento=@num_documento,direccion=@direccion,telefono=@telefono,
	email=@email,clave=HASHBYTES('SHA2_256', @clave)
	where idusuario=@idusuario;
else
	update usuario set idrol=@idrol,nombre=@nombre,tipo_documento=@tipo_documento,
	num_documento=@num_documento,direccion=@direccion,telefono=@telefono,
	email=@email
	where idusuario=@idusuario;
go
--Procedimiento Eliminar usuario
create proc usuario_eliminar
@idusuario integer
as
	delete from usuario
	where idusuario=@idusuario
go
--Procedimiento Desactivar usuario
create proc usuario_desactivar
@idusuario integer
as
	update usuario set estado=0
	where idusuario=@idusuario
go
--Procedimiento Activar usuario
create proc usuario_activar
@idusuario integer
as
	update usuario set estado=1
	where idusuario=@idusuario
go
-- Procedimiento existe usuario
create proc usuario_existe
@valor varchar(100),
@existe bit output
as
	if exists (select email from usuario where email = ltrim(rtrim(@valor)))
		begin
		 set @existe=1
		end
	else
		begin
		 set @existe=0
		end
go
--Procedimiento para login de usuario
create proc usuario_login
@email varchar(50),
@clave varchar(50)
as
select u.idusuario, u.idrol, r.nombre as rol, u.nombre, u.estado
from usuario u inner join rol r on u.idrol=r.idrol
where u.email=@email and u.clave=HASHBYTES('SHA2_256',@clave)
go
--Procedimiento Listar libro
create proc libro_listar
as
select l.idlibro as Codigo, l.cant_ejemplares as Cantidad_Ejemplares, l.isbn as ISBN,
l.titulo as Titulo, l.autor as Autor, l.editorial as Editorial,
l.year_edicion as Year_Edicion,l.num_edicion as Numero_Edicion,l.pais as Pais,
l.idioma as Idioma, l.materia as Materia, l.num_paginas as Numero_Paginas,
l.ubicacion as Ubicacion, l.descripcion as Descripcion, l.estado as Estado
from libro l 
order by l.idlibro desc
go
--Procedimiento Listar libro disponible
create proc libro_listar_disponible
as
select l.idlibro as Codigo, l.cant_ejemplares as Cantidad_Ejemplares, l.isbn as ISBN,
l.titulo as Titulo, l.autor as Autor, l.editorial as Editorial,
l.year_edicion as Year_Edicion,l.num_edicion as Numero_Edicion,l.pais as Pais,
l.idioma as Idioma, l.materia as Materia, l.num_paginas as Numero_Paginas,
l.ubicacion as Ubicacion, l.descripcion as Descripcion, l.estado as Estado
from libro l 
where l.cant_ejemplares=1
order by l.idlibro desc
go
--Procedimiento Listar libro prestado
create proc libro_listar_prestado
as
select l.idlibro as Codigo, l.cant_ejemplares as Cantidad_Ejemplares, l.isbn as ISBN,
l.titulo as Titulo, l.autor as Autor, l.editorial as Editorial,
l.year_edicion as Year_Edicion,l.num_edicion as Numero_Edicion,l.pais as Pais,
l.idioma as Idioma, l.materia as Materia, l.num_paginas as Numero_Paginas,
l.ubicacion as Ubicacion, l.descripcion as Descripcion, l.estado as Estado
from libro l 
where l.cant_ejemplares=0
order by l.idlibro desc
go
--Procedimiento Buscar libro por titulo
create proc libro_buscar_titulo
@valor varchar(50)
as
select l.idlibro as Codigo, l.cant_ejemplares as Cantidad_Ejemplares, l.isbn as ISBN,
l.titulo as Titulo, l.autor as Autor, l.editorial as Editorial,
l.year_edicion as Year_Edicion,l.num_edicion as Numero_Edicion,l.pais as Pais,
l.idioma as Idioma, l.materia as Materia, l.num_paginas as Numero_Paginas,
l.ubicacion as Ubicacion, l.descripcion as Descripcion, l.estado as Estado
from libro l 
where l.titulo like '%' +@valor + '%' 
order by l.idlibro asc
go
--Procedimiento Buscar libro por autor
create proc libro_buscar_autor
@valor varchar(50)
as
select l.idlibro as Codigo, l.cant_ejemplares as Cantidad_Ejemplares, l.isbn as ISBN,
l.titulo as Titulo, l.autor as Autor, l.editorial as Editorial,
l.year_edicion as Year_Edicion,l.num_edicion as Numero_Edicion,l.pais as Pais,
l.idioma as Idioma, l.materia as Materia, l.num_paginas as Numero_Paginas,
l.ubicacion as Ubicacion, l.descripcion as Descripcion, l.estado as Estado
from libro l 
where l.autor like '%' +@valor + '%' 
order by l.idlibro asc
go
--Procedimiento Buscar libro por editorial
create proc libro_buscar_editorial
@valor varchar(50)
as
select l.idlibro as Codigo, l.cant_ejemplares as Cantidad_Ejemplares, l.isbn as ISBN,
l.titulo as Titulo, l.autor as Autor, l.editorial as Editorial,
l.year_edicion as Year_Edicion,l.num_edicion as Numero_Edicion,l.pais as Pais,
l.idioma as Idioma, l.materia as Materia, l.num_paginas as Numero_Paginas,
l.ubicacion as Ubicacion, l.descripcion as Descripcion, l.estado as Estado
from libro l 
where l.editorial like '%' +@valor + '%' 
order by l.idlibro asc
go
--Procedimiento Insertar libro
create proc libro_insertar
@cant_ejemplares integer,
@isbn varchar(50),
@titulo varchar(100),
@autor varchar(100),
@editorial varchar(100),
@year_edicion integer,
@num_edicion integer,
@pais varchar(50),
@idioma varchar(50),
@materia varchar(50),
@num_paginas integer,
@ubicacion integer,
@descripcion varchar(255)
as
insert into libro (cant_ejemplares,isbn,titulo,autor,editorial,year_edicion,num_edicion,pais,idioma,materia,num_paginas,ubicacion,descripcion)
values (@cant_ejemplares,@isbn,@titulo,@autor,@editorial,@year_edicion,@num_edicion,@pais,@idioma,@materia,@num_paginas,@ubicacion,@descripcion)
go
--Procedimiento Actualizar libro
create proc libro_actualizar
@idlibro integer,
@cant_ejemplares integer,
@isbn varchar(50),
@titulo varchar(100),
@autor varchar(100),
@editorial varchar(100),
@year_edicion integer,
@num_edicion integer,
@pais varchar(50),
@idioma varchar(50),
@materia varchar(50),
@num_paginas integer,
@ubicacion integer,
@descripcion varchar(255)
as
update libro set cant_ejemplares=@cant_ejemplares,isbn=@isbn,
titulo=@titulo,autor=@autor,editorial=@editorial,
year_edicion=@year_edicion,num_edicion=@num_edicion,
pais=@pais,idioma=@idioma,materia=@materia,num_paginas=@num_paginas,ubicacion=@ubicacion,descripcion=@descripcion
where idlibro=@idlibro
go
--Procedimiento Eliminar libro
create proc libro_eliminar
@idlibro integer
as
delete from libro
where idlibro=@idlibro
go
--Procedimiento Desactivar libro
create proc libro_desactivar
@idlibro integer
as
update libro set estado=0
where idlibro=@idlibro
go
--Procedimiento Activar libro
create proc libro_activar
@idlibro integer
as
update libro set estado=1
where idlibro=@idlibro
go
--Procedimiento existe libro
create proc libro_existe
@valor varchar(50),
@existe bit output
as
if exists (select isbn from libro where isbn = ltrim(rtrim(@valor)))
	begin
		set @existe=1
	end
else
	begin
		set @existe=0
	end
go
--Procedimiento listar prestamo
create proc prestamo_listar
as
select p.idprestamo as ID, u.nombre as Profesor, l.titulo as Libro, 
p.fecha_prestamo as Fecha_Prestamo, p.fecha_devolucion as Fecha_Devolucion
from prestamo p 
inner join usuario u on p.idusuario=u.idusuario
inner join libro l on p.idlibro=l.idlibro
Order by p.idprestamo desc
go
--Procedimiento buscar prestamo
create proc prestamo_buscar
@valor varchar(50)
as
select p.idprestamo as ID, u.nombre as Profesor, l.titulo as Libro, 
p.fecha_prestamo as Fecha_Prestamo, p.fecha_devolucion as Fecha_Devolucion
from prestamo p 
inner join usuario u on p.idusuario=u.idusuario
inner join libro l on p.idlibro=l.idlibro
where u.idusuario like '%' + @valor + '%' 
Order by p.idprestamo asc
go
--Procedimiento Insertar prestamo
create proc prestamo_insertar
@idusuario integer,
@idlibro integer,
@fecha_prestamo datetime,
@fecha_devolucion datetime
as
insert into prestamo (idusuario,idlibro,fecha_prestamo,fecha_devolucion)
values (@idusuario,@idlibro,@fecha_prestamo,@fecha_devolucion)
go
--Procedimiento Eliminar prestamo
create proc prestamo_eliminar
@idprestamo integer
as
delete from prestamo
where idprestamo=@idprestamo
go
--Disparador para actualizar libreria
CREATE TRIGGER Venta_ActualizarLibreria
   ON prestamo
   FOR INSERT
   AS
   UPDATE l SET l.cant_ejemplares=0
   FROM libro AS l INNER JOIN
   INSERTED AS p ON p.idlibro=l.idlibro
go
--Disparador para actualizar libreria
CREATE TRIGGER Venta_ActualizarLibreria2
   ON prestamo
   FOR DELETE
   AS
   UPDATE l SET l.cant_ejemplares=1
   FROM libro AS l INNER JOIN
   DELETED AS p ON p.idlibro=l.idlibro
go

--		DATOS

--insertar roles
insert into rol (nombre, descripcion) values ('administrador', 'Administra la libreria.');
insert into rol (nombre, descripcion) values ('profesor', 'Encargado de la enseñanza de la institución.');
go
--inserar usuarios
insert into usuario (idrol, nombre, email, clave) values (1, 'Juan', 'juan@email.com', HASHBYTES('SHA2_256','uca'));
insert into usuario (idrol, nombre, email, clave) values (1, 'Marco', 'marco@email.com', HASHBYTES('SHA2_256','uca'));
insert into usuario (idrol, nombre, email, clave) values (2, 'Mario', 'mario@email.com', HASHBYTES('SHA2_256','uca'));
insert into usuario (idrol, nombre, email, clave) values (2, 'Cristina', 'cristina@email.com', HASHBYTES('SHA2_256','uca'));
insert into usuario (idrol, nombre, email, clave) values (2, 'Maria', 'maria@email.com', HASHBYTES('SHA2_256','uca'));
--insertar libros
insert into libro (isbn, titulo, autor, editorial) values (121212, 'Programacion N-Capas', 'Carlos Loarca', 'UCA Editores');
insert into libro (isbn, titulo, autor, editorial) values (232323, 'Analisis de Sistemas', 'Silvia Ortiz', 'UCA El Salvador');
insert into libro (isbn, titulo, autor, editorial) values (151858, 'Programación Web', 'Nestor Aldana', 'Informatica');
insert into libro (isbn, titulo, autor, editorial) values (845454, 'Sistemas operativos', 'Kendall', 'Pearson');
insert into libro (isbn, titulo, autor, editorial) values (785185, 'Arquitectura de compu', 'Javier Hernandez', 'Microprocesadores');
insert into libro (isbn, titulo, autor, editorial) values (236547, 'Aritmética básica', 'Eduardo Escapini', 'UCA El Salvador');
