CREATE TABLE [dbo].[PessoaJuridica] (
    [PessoaJuridicaId]       INT           NOT NULL,
    [Status]   VARCHAR (100) NULL,
    [Message]  VARCHAR (100) NULL,
    [Cnpj]     VARCHAR (25)  NULL,
    [Tipo]     VARCHAR (100) NULL,
    [Abertura] DATETIME  NULL,
    [Nome]     VARCHAR (100) NULL,
    [Fantasia] VARCHAR (100) NULL,
    [Situacao] VARCHAR (100) NULL,
    [EnderecoId] INT NULL,
    [ContatoId] INT NULL
    PRIMARY KEY CLUSTERED ([PessoaJuridicaId] ASC),
    CONSTRAINT [FK_PessoaJuridica_Endereco] FOREIGN KEY ([EnderecoId]) REFERENCES [dbo].[Endereco] ([EnderecoId]), 
    CONSTRAINT [FK_PessoaJuridica_Contato] FOREIGN KEY ([ContatoId]) REFERENCES [dbo].[Contato]([ContatoId])
);
