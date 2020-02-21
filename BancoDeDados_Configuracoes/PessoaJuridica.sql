CREATE TABLE [dbo].[PessoaJuridica]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Status] VARCHAR(100) NULL, 
    [Message] VARCHAR(100) NULL, 
    [Cnpj] VARCHAR(25) NULL, 
    [Tipo] VARCHAR(100) NULL, 
    [Abertura] VARCHAR(10) NULL, 
    [Nome] VARCHAR(100) NULL, 
    [Fantasia] VARCHAR(100) NULL, 
    [Situacao] VARCHAR(100) NULL, 
    CONSTRAINT [FK_PessoaJuridica_Endereco] FOREIGN KEY ([Id]) REFERENCES [Endereco]([Id]), 
    CONSTRAINT [FK_PessoaJuridica_Contato] FOREIGN KEY ([Id]) REFERENCES [Contato]([Id])

)
