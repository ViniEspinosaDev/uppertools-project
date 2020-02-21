CREATE TABLE [dbo].[Endereco] (
    [EnderecoId]          INT           NOT NULL,
    [Cep]         VARCHAR (15)  NULL,
    [Cidade]      VARCHAR (30)  NULL,
    [Uf]          VARCHAR (30)  NULL,
    [Logradouro]  VARCHAR (100) NULL,
    [Bairro]      VARCHAR (50)  NULL,
    [Numero]      VARCHAR (10)  NULL,
    [Complemento] VARCHAR (130) NULL,
    PRIMARY KEY CLUSTERED ([EnderecoId] ASC)
);

