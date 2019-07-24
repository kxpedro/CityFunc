CREATE DATABASE CityFunc

CREATE TABLE [dbo].[Municipio](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UF] [char](2) NOT NULL,
	[Nome] [varchar](max) NOT NULL,
	CONSTRAINT [Municipio_PK] PRIMARY KEY CLUSTERED (Id)
)

CREATE TABLE [dbo].[Funcionario](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](max) NOT NULL,
	[Telefone] [varchar](20) NOT NULL,
	[CPF] [char](11) NOT NULL,
	[Endereco] [varchar](max) NOT NULL,
	[Numero] [varchar](max) NOT NULL,
	[Complemento] [varchar](max) NULL,
	[Municipio] [varchar](max) NOT NULL,
	[UF] [char](2) NOT NULL,
	[Foto] [varchar](max) NULL,
	[CEP] [char](8) NULL,
	CONSTRAINT [Funcionario_PK] PRIMARY KEY CLUSTERED (Id)
)