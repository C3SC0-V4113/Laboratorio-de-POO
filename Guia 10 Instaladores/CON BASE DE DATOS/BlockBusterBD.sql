USE master
GO
CREATE DATABASE Instalador
GO
USE Instalador
GO
CREATE TABLE GENEROS
(
IDGenero varchar(4) not null primary key,
NombreGenero varchar(25),
)

CREATE TABLE PELICULAS
(
IDPelicula int identity(1,1) not null primary key,
NombrePelicula varchar(25),
Director varchar(25),
Año int,
IDGenero varchar(4)
CONSTRAINT FK_IDGenero FOREIGN KEY (IDGenero) REFERENCES GENEROS(IDGenero)  ON DELETE CASCADE ON UPDATE CASCADE
)

CREATE TABLE INTERPRETES
(
IDInterprete int identity(1,1) not null primary key,
Nombre varchar(25),
Apellido varchar(25),
Nacionalidad varchar(25)
)

CREATE TABLE PROTAGONISTAS
(
IDPelicula int, 
IDInterprete int CONSTRAINT FK_IDInterprete FOREIGN KEY (IDInterprete) REFERENCES INTERPRETES(IDInterprete) ON DELETE CASCADE ON UPDATE CASCADE
)
ALTER TABLE PROTAGONISTAS
ADD CONSTRAINT FK_IDPelicula 
FOREIGN KEY (IDPelicula) 
REFERENCES PELICULAS(IDPelicula)
ON DELETE CASCADE ON UPDATE CASCADE

 alter table PELICULAS
 add constraint CK_Año
 check (Año>=1800)
 go

 alter table GENEROS
 add constraint CK_IDGeneros
 Check(IDGenero like '[G][E][0-9][0-9]')
 go

 INSERT INTO GENEROS VALUES
 ('GE00','Terror'),
 ('GE01','Comedia'),
 ('GE02','Accion')

 INSERT INTO PELICULAS VALUES
 ('La cosa','John Carpenter',1982,'GE00'),
 ('La masacre de Texas','Tobe Hooper',1976,'GE00'),
 ('Psicosis',' Alfred Hitchcock',1960,'GE00')

 INSERT INTO INTERPRETES VALUES
 ('Kurt','Russell','Estadounidense'),
 ('Gunnar','Hansen','Islandes'),
 ('Anthony','Perkins','Estadounidense')

 INSERT INTO PROTAGONISTAS VALUES
 (1,1),
 (2,2),
 (3,3)

SELECT*FROM PELICULAS
WHERE (IDGenero='GE00') AND (Año BETWEEN 1970 AND 1990)

SELECT*FROM INTERPRETES
WHERE (Nacionalidad not like 'Estadounidense')


SELECT*FROM PELICULAS
GO

create proc EditarPeliculas
@Nombre varchar(25),
@Director varchar(25),
@año int,
@genero varchar(25),
@id int
As
UPDATE PELICULAS SET NombrePelicula=@Nombre,Director=@Director,Año=@año,IDGenero=@genero
where IDPelicula=@id
go

create proc EliminarPelicula
@idpeli int
as
DELETE FROM PELICULAS WHERE IDPelicula=@idpeli
go
