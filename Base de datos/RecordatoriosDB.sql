CREATE DATABASE Recordatorios;
GO

USE Recordatorios;
GO

CREATE TABLE Recordatorios (
    IdRecordatorio INT IDENTITY(1,1) PRIMARY KEY,
    Titulo NVARCHAR(100) NOT NULL,
    Descripcion NVARCHAR(255),
    Fecha DATE NOT NULL,
    Hora TIME NOT NULL,
    Categoria NVARCHAR(50),
    FechaCreacion DATETIME DEFAULT GETDATE()
);
GO

INSERT INTO Recordatorios
(Titulo, Descripcion, Fecha, Hora, Categoria)
VALUES
('¡Reunión URGENTE!', 'Hablar sobre el proyecto', '2026-06-24', '20:50', 'Escuela'),
('Llamada con cliente', 'Confirmar requerimientos', '2026-06-24', '23:20', 'Trabajo'),
('Entregar reporte', 'Enviar PDF por correo', '2026-06-25', '08:20', 'Escuela'),
('Revisión mensual', 'Preparar presentación', '2026-06-26', '20:20', 'Trabajo'),
('Entrega final', 'Proyecto completo', '2026-06-29', '20:20', 'Escuela');
GO

SELECT* FROM Recordatorios;
