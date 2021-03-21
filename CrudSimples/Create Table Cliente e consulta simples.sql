CREATE TABLE [dbo].[Clientes]
(
	[ClienteId] INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[Nome] VARCHAR(250) NULL,
	[Idade] INT NULL
)

--Drop table Clientes
Select * from Clientes