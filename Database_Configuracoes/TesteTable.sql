CREATE TABLE [dbo].[PessoaFisica] (
    [ID]             INT          NOT NULL,
    [Nome]           VARCHAR (50) NULL,
    [CPF]            VARCHAR (14) NULL,
    [DataNascimento] DATETIME     NULL,
    [Email]          VARCHAR (50) NULL,
    [Telefone]       VARCHAR (15) NULL,
    [Celular]        NCHAR (15)   NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC)
);
