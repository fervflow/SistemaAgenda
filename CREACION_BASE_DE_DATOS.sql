-- Script de creacion de base de datos y login correspondiente.
-- Se puede ejecutar todo el script sin intervencion.
-- BORRARA LA BASE DE DATOS LLAMADA 'agenda'
USE master;

IF EXISTS (SELECT name FROM sys.databases WHERE name = 'agenda')
BEGIN
    USE master;
    ALTER DATABASE agenda SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE agenda;
END
GO

CREATE DATABASE agenda;
GO

USE agenda;

create table usuario(
	id_usuario  int primary key identity (1,1) not null,
	nombre      varchar(25) not null,
	apellido    varchar(25) not null,
	fecha_nacimiento date not null,
	usuario     varchar(10) not null unique,
	pin         int not null
);
create table genero(
	id_genero       TINYINT primary key not null,
	nombre_genero   varchar(6) not null
);
GO

INSERT INTO genero(nombre_genero) VALUES(1, 'VARON');
INSERT INTO genero(nombre_genero) VALUES(2, 'MUJER');
GO

create table contacto(
	id_contacto     int primary key identity (1,1) not null,
	nombre_completo varchar(50) not null,
	genero_contacto TINYINT not null, 
	telefono        varchar(15) not null,
	detalle         varchar(150) not null,
	usuario_contacto int not null,
	CONSTRAINT fk_ContactoGenero FOREIGN KEY (genero_contacto) REFERENCES genero(id_genero),
	CONSTRAINT fk_ContactoUsuario FOREIGN KEY (usuario_contacto) REFERENCES usuario(id_usuario)
);
GO

create table cita(
	id_cita     int primary key identity (1,1) not null,
	fecha_hora  datetime not null,
	motivo      varchar(150) not null,
	usuario_cita    int not null,
	contacto_cita   int not null,
	CONSTRAINT fk_CitaUsuario FOREIGN KEY (usuario_cita) REFERENCES usuario(id_usuario),
	CONSTRAINT fk_CitaContacto FOREIGN KEY (contacto_cita) REFERENCES contacto(id_contacto)
);
GO

USE master;
IF EXISTS (SELECT * FROM sys.server_principals WHERE name = 'agenda_admin')
BEGIN
    DROP LOGIN agenda_admin;
END
GO
CREATE LOGIN agenda_admin WITH PASSWORD = 'admin123', CHECK_POLICY = OFF;
GO
USE agenda;
DROP USER IF EXISTS agenda_admin;
GO
CREATE USER agenda_admin FOR LOGIN agenda_admin;
GO
ALTER USER agenda_admin WITH DEFAULT_SCHEMA = [dbo];
ALTER ROLE [db_owner] ADD MEMBER agenda_admin;
GO