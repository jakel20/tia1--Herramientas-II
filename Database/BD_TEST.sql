IF DB_ID(N'BD_TEST') IS NULL
BEGIN
    CREATE DATABASE BD_TEST;
END
GO

USE BD_TEST;
GO

IF OBJECT_ID(N'dbo.USUARIO', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.USUARIO (
        id int IDENTITY(1,1) PRIMARY KEY NOT NULL,
        usuario varchar(50) NOT NULL,
        contrasena varchar(250) NOT NULL,
        intentos int NOT NULL,
        nivelSeg decimal(18,0) NOT NULL,
        fechaReg date NOT NULL
    );
END
GO

CREATE OR ALTER PROCEDURE dbo.SP_INSERTAR_USUARIO
    @usuario varchar(50),
    @contrasena varchar(250),
    @intentos int,
    @nivelSeg decimal(18,0),
    @fechaReg date
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO dbo.USUARIO (usuario, contrasena, intentos, nivelSeg, fechaReg)
    VALUES (@usuario, @contrasena, @intentos, @nivelSeg, @fechaReg);
END
GO

CREATE OR ALTER PROCEDURE dbo.SP_SELECCIONAR_USUARIO
    @id int
AS
BEGIN
    SET NOCOUNT ON;

    SELECT id, usuario, contrasena, intentos, nivelSeg, fechaReg
    FROM dbo.USUARIO
    WHERE id = @id;
END
GO

CREATE OR ALTER PROCEDURE dbo.SP_ACTUALIZAR_USUARIO
    @id int,
    @usuario varchar(50),
    @contrasena varchar(250),
    @intentos int,
    @nivelSeg decimal(18,0),
    @fechaReg date
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE dbo.USUARIO
    SET usuario = @usuario,
        contrasena = @contrasena,
        intentos = @intentos,
        nivelSeg = @nivelSeg,
        fechaReg = @fechaReg
    WHERE id = @id;
END
GO

CREATE OR ALTER PROCEDURE dbo.SP_ELIMINAR_USUARIO
    @id int
AS
BEGIN
    SET NOCOUNT ON;

    DELETE FROM dbo.USUARIO
    WHERE id = @id;
END
GO

CREATE OR ALTER PROCEDURE dbo.SP_SELECCIONAR_ALL_USUARIO
AS
BEGIN
    SET NOCOUNT ON;

    SELECT id, usuario, contrasena, intentos, nivelSeg, fechaReg
    FROM dbo.USUARIO
    ORDER BY id;
END
GO

CREATE OR ALTER PROCEDURE dbo.SP_VALIDAR_USUARIO
    @usuario varchar(50),
    @contrasena varchar(250)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT COUNT(1)
    FROM dbo.USUARIO
    WHERE usuario = @usuario
      AND contrasena = @contrasena;
END
GO

IF NOT EXISTS (SELECT 1 FROM dbo.USUARIO WHERE usuario = 'admin')
BEGIN
    INSERT INTO dbo.USUARIO (usuario, contrasena, intentos, nivelSeg, fechaReg)
    VALUES ('admin', '1234', 0, 1, CONVERT(date, GETDATE()));
END
GO

IF OBJECT_ID(N'dbo.CATEGORIA', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.CATEGORIA (
        id int IDENTITY(1,1) PRIMARY KEY NOT NULL,
        nombre varchar(100) NOT NULL,
        descripcion varchar(250) NOT NULL
    );
END
GO

CREATE OR ALTER PROCEDURE dbo.SP_INSERTAR_CATEGORIA
    @nombre varchar(100),
    @descripcion varchar(250)
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO dbo.CATEGORIA (nombre, descripcion)
    VALUES (@nombre, @descripcion);
END
GO

CREATE OR ALTER PROCEDURE dbo.SP_SELECCIONAR_CATEGORIA
    @id int
AS
BEGIN
    SET NOCOUNT ON;

    SELECT id, nombre, descripcion
    FROM dbo.CATEGORIA
    WHERE id = @id;
END
GO

CREATE OR ALTER PROCEDURE dbo.SP_ACTUALIZAR_CATEGORIA
    @id int,
    @nombre varchar(100),
    @descripcion varchar(250)
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE dbo.CATEGORIA
    SET nombre = @nombre,
        descripcion = @descripcion
    WHERE id = @id;
END
GO

CREATE OR ALTER PROCEDURE dbo.SP_ELIMINAR_CATEGORIA
    @id int
AS
BEGIN
    SET NOCOUNT ON;

    DELETE FROM dbo.CATEGORIA
    WHERE id = @id;
END
GO

CREATE OR ALTER PROCEDURE dbo.SP_SELECCIONAR_ALL_CATEGORIA
AS
BEGIN
    SET NOCOUNT ON;

    SELECT id, nombre, descripcion
    FROM dbo.CATEGORIA
    ORDER BY id;
END
GO

IF NOT EXISTS (SELECT 1 FROM dbo.CATEGORIA WHERE nombre = 'General')
BEGIN
    INSERT INTO dbo.CATEGORIA (nombre, descripcion)
    VALUES ('General', 'Categoría inicial de prueba');
END
GO

IF OBJECT_ID(N'dbo.PRODUCTO', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.PRODUCTO (
        id int IDENTITY(1,1) PRIMARY KEY NOT NULL,
        nombre varchar(100) NOT NULL,
        cantidad int NOT NULL,
        precio decimal(18,2) NOT NULL
    );
END
GO

CREATE OR ALTER PROCEDURE dbo.SP_INSERTAR_PRODUCTO
    @nombre varchar(100),
    @cantidad int,
    @precio decimal(18,2)
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO dbo.PRODUCTO (nombre, cantidad, precio)
    VALUES (@nombre, @cantidad, @precio);
END
GO

CREATE OR ALTER PROCEDURE dbo.SP_SELECCIONAR_PRODUCTO
    @id int
AS
BEGIN
    SET NOCOUNT ON;

    SELECT id, nombre, cantidad, precio
    FROM dbo.PRODUCTO
    WHERE id = @id;
END
GO

CREATE OR ALTER PROCEDURE dbo.SP_ACTUALIZAR_PRODUCTO
    @id int,
    @nombre varchar(100),
    @cantidad int,
    @precio decimal(18,2)
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE dbo.PRODUCTO
    SET nombre = @nombre,
        cantidad = @cantidad,
        precio = @precio
    WHERE id = @id;
END
GO

CREATE OR ALTER PROCEDURE dbo.SP_ELIMINAR_PRODUCTO
    @id int
AS
BEGIN
    SET NOCOUNT ON;

    DELETE FROM dbo.PRODUCTO
    WHERE id = @id;
END
GO

CREATE OR ALTER PROCEDURE dbo.SP_SELECCIONAR_ALL_PRODUCTO
AS
BEGIN
    SET NOCOUNT ON;

    SELECT id, nombre, cantidad, precio
    FROM dbo.PRODUCTO
    ORDER BY id;
END
GO

IF NOT EXISTS (SELECT 1 FROM dbo.PRODUCTO WHERE nombre = 'Producto de prueba')
BEGIN
    INSERT INTO dbo.PRODUCTO (nombre, cantidad, precio)
    VALUES ('Producto de prueba', 10, 100.00);
END
GO
