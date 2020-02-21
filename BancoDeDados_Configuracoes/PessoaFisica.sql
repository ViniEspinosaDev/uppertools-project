CREATE TABLE [dbo].[PessoaFisica] (
    [ID]             INT          NOT NULL,
    [Nome]           VARCHAR (50) NULL,
    [CPF]            VARCHAR (14) NULL,
    [DataNascimento] DATETIME     NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC), 
    CONSTRAINT [FK_PessoaFisica_Endereco] FOREIGN KEY ([ID]) REFERENCES [Endereco]([Id]), 
    CONSTRAINT [FK_PessoaFisica_Contato] FOREIGN KEY ([ID]) REFERENCES [Contato]([Id])
);

