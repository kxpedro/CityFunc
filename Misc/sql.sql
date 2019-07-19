CREATE TABLE Municipio(
	Id INT NOT NULL IDENTITY,
	UF CHAR(2) NOT NULL,
	Nome VARCHAR(MAX) NOT NULL,
	
	CONSTRAINT Municipio_PK PRIMARY KEY(Id)
)

CREATE TABLE Funcionario(
	Id INT NOT NULL IDENTITY,
	Nome VARCHAR(MAX) NOT NULL,
	Telefone VARCHAR(20) NOT NULL,
	CPF CHAR(11) NOT NULL,
	CEP CHAR(7) NOT NULL,
	Endereco VARCHAR(MAX) NOT NULL,
	Numero VARCHAR(MAX) NOT NULL,
	Complemento VARCHAR(MAX) NULL,
	Municipio VARCHAR(MAX) NOT NULL,
	UF CHAR(2) NOT NULL,
	Foto VARCHAR(MAX) NULL,
	
	CONSTRAINT Funcionario_PK PRIMARY KEY(Id)
)
