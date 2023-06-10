-- 1. Agregando departamentos
USE [DemoTrabajadores]
GO
INSERT INTO [dbo].[Departamento] ([IdDepartamento],[NombreDepartamento]) VALUES (1,'Lima'), (2, 'Cuzco')
GO
INSERT INTO [dbo].[Provincia] ([IdProvincia],[IdDepartamento],[NombreProvincia]) VALUES (1, 1, 'Lima provincia'), (2, 1, 'Barranca'), (3, 2, 'Urubamba')
GO
INSERT INTO [dbo].[Distrito] ([IdDistrito],[IdProvincia],[NombreDistrito]) VALUES (1, 1, 'San Luis'), (2, 2, 'Barranca distrito'), (3, 3, 'Machupicchu')
GO
INSERT INTO [dbo].[Trabajador] ([TipoDocumento],[NroDocumento],[Nombres],[Sexo],[IdDistrito]) 
VALUES ('DNI','15988373','FRANCI RENE ROMERO ALZAMORA','M',1),
	('DNI','32980463','DENNIS GONZALES ESPEJO','M',2),
	('DNI', '32766415', 'FERNANDA VIGO CERNA', 'F', 3)

SELECT * FROM [dbo].[Trabajador]
TRUNCATE TABLE [dbo].[Provincia]
