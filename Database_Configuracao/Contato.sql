CREATE TABLE [dbo].[Contato] (
    [ContatoId]       INT         NOT NULL,
    [Email]    VARCHAR(100) NULL,
    [Telefone] VARCHAR(20)  NULL,
    [Celular]  VARCHAR(20)  NULL,
    PRIMARY KEY CLUSTERED ([ContatoId] ASC)
);