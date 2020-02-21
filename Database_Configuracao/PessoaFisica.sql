CREATE TABLE [dbo].[PessoaFisica] (
    [PessoaFisicaId]             INT          NOT NULL,
    [Nome]           VARCHAR (50) NULL,
    [CPF]            VARCHAR (14) NULL,
    [DataNascimento] DATETIME     NULL,
    [EnderecoId]INT,
    [ContatoId]INT
    PRIMARY KEY CLUSTERED ([PessoaFisicaId] ASC),
    CONSTRAINT [FK_PessoaFisica_Endereco] FOREIGN KEY ([EnderecoId]) REFERENCES [dbo].[Endereco] ([EnderecoId]), 
    CONSTRAINT [FK_PessoaFisica_Contato] FOREIGN KEY ([ContatoId]) REFERENCES [dbo].[Contato]([ContatoId])
);
