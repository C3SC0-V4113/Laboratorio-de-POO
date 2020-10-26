USE master
create database SegundoParcialPracticoPOO1
go
use SegundoParcialPracticoPOO1
go

--Creando Tablas
--Tabla Usuario
create table USUARIOS
(
CodigoUsuario varchar(25) not null,
Contraseña varchar (max)not null,
)
--Tabla Producto
create table PRODUCTOS
(
CodigoProducto int not null,
NombreProducto varchar (25)not null,
stock int not null,
PrecioUnitario money,
)

--Tabla Factura
create table FACTURAS
(
CodigoFactura int identity(1,1) not null,
CodigoUsuario varchar(25) not null,
)

--Tabla Comprados
create table COMPRADOS
(
CodigoCompra int identity(1,1) not null,
CodigoFactura int not null,
CodigoProducto int not null,
cantidad int not null,
)

--Llaves primarias
 Alter table USUARIOS
 add constraint PK_CodigoUsuario
 primary key(CodigoUsuario)
 go
  Alter table PRODUCTOS
 add constraint PK_CodigoProducto
 primary key(CodigoProducto)
 go
 Alter table FACTURAS
 add constraint PK_CodigoFactura
 primary key(CodigoFactura)
 go
 Alter table COMPRADOS
 add constraint PK_CodigoCompra
 primary key(CodigoCompra)
 go

--Llaves foraneas

 alter table FACTURAS
 add constraint FK_CodigoUsuario
 foreign key (CodigoUsuario)
 references USUARIOS(CodigoUsuario)
 on delete cascade
 ON UPDATE CASCADE
 go

  alter table COMPRADOS
 add constraint FK_CodigoFactura
 foreign key (CodigoFactura)
 references FACTURAS(CodigoFactura)
 on delete cascade
 ON UPDATE CASCADE
 go

   alter table COMPRADOS
 add constraint FK_CodigoProducto1
 foreign key (CodigoProducto)
 references PRODUCTOS(CodigoProducto)
 on delete cascade
 ON UPDATE CASCADE
 go

 INSERT INTO USUARIOS VALUES
 ('admin','YQBkAG0AaQBuADEAMgAzAA=='),
 ('vendedor','dgBlAG4AZABlAGQAbwByADEAMgAzAA=='),
 ('invitado','aQBuAHYAaQB0AGEAZABvAGkAbgB2AGkAdABhAGQAbwAxADIAMwA=')
 
 select*from USUARIOS

 INSERT INTO PRODUCTOS VALUES
 (1,'huevos',30,0.10),
 (2,'pollo',10,5.00),
 (3,'aceite',50,3.00),
 (4,'fósforos',200,0.50),
 (5,'dulces',500,0.80),
 (6,'margarina',30,0.30),
 (7,'jabón',25,2.25),
 (8,'carne',35,2.75),
 (9,'gaseosa',200,1.80),
 (10,'desechables',800,3.25);
 select*from PRODUCTOS
  select*from FACTURAS
  select*from COMPRADOS
  insert into FACTURAS VALUES
  ('admin')
  insert into COMPRADOS VALUES
  (1,2,3),
  (1,4,6),
  (1,3,2)

 SELECT P.NombreProducto,C.Cantidad,P.PrecioUnitario,(C.Cantidad*P.PrecioUnitario)total FROM FACTURAS F
 INNER JOIN USUARIOS U
 ON F.CodigoUsuario=U.CodigoUsuario
 INNER JOIN COMPRADOS C
 ON F.CodigoFactura=C.CodigoFactura
 INNER JOIN PRODUCTOS P
 ON C.CodigoProducto=P.CodigoProducto
 WHERE F.CodigoFactura=1

 select*from COMPRADOS
 create proc BuscarUsuario
@usuario varchar(25),
@contraseña varchar(25)
 as
 select*from USUARIOS
 where CodigoUsuario = @usuario AND Contraseña= @contraseña
 go


 create proc MostrarTODOSProductos
 as
 select*from Productos
 go

 exec MostrarTODOSProductos

 create proc MostrarProductosCodi
 @Codigo int
 as
 Select*from PRODUCTOS
 where CodigoProducto=@Codigo
 go

 exec MostrarProductosCodi 3

  create proc MostrarProductosNombre
 @Nombre varchar (25)
 as
 Select*from PRODUCTOS
 where NombreProducto=@Nombre
 go

exec MostrarProductosNombre 'ACEITE'

create proc CrearFactura
@CodUsuario varchar(25)
as
INSERT INTO FACTURAS VALUES (@CodUsuario)
go

create proc InsertarCompras
@CodFactura int,
@CodProducto int,
@Cantidad int
as
INSERT INTO COMPRADOS VALUES (@CodFactura,@CodProducto,@Cantidad)
go

create proc ImprimirFactura
@idFactura int
as
 SELECT P.NombreProducto,C.Cantidad,P.PrecioUnitario,(C.Cantidad*P.PrecioUnitario)total FROM FACTURAS F
 INNER JOIN USUARIOS U
 ON F.CodigoUsuario=U.CodigoUsuario
 INNER JOIN COMPRADOS C
 ON F.CodigoFactura=C.CodigoFactura
 INNER JOIN PRODUCTOS P
 ON C.CodigoProducto=P.CodigoProducto
 WHERE F.CodigoFactura=@idFactura

 create proc UltimaFactura
as
select * from FACTURAS
WHERE CodigoFactura=(SELECT MAX(CodigoFactura) FROM FACTURAS)


exec CrearFactura 'admin'
exec InsertarCompras 20,5,3
exec InsertarCompras 20,1,4
exec ImprimirFactura 20
exec UltimaFactura