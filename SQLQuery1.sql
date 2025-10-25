CREATE DATABASE PruebaTecnica;
GO

USE PruebaTecnica;
GO

CREATE TABLE Empleados (
    usuID numeric(18,0) PRIMARY KEY,
    nombre NVARCHAR(100) NOT NULL,
    apellido NVARCHAR(100) NOT NULL
    );
GO

INSERT INTO Empleados (usuID, Nombre, apellido)
VALUES 
(1,'Andrea', 'Pirlo'),
(2,'Steven', 'Gerrard'),
(3,'Frank', 'Lampard'),
(4,'Luka', 'Modric'),
(5,'Xabi', 'Alonso');
GO

SELECT * FROM Empleados;
GO

