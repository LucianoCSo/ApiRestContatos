/*    ==Parâmetros de Script==

    Versão do Servidor de Origem : SQL Server 2017 (14.0.1000)
    Edição do Mecanismo de Banco de Dados de Origem : Microsoft SQL Server Enterprise Edition
    Tipo do Mecanismo de Banco de Dados de Origem : SQL Server Autônomo

    Versão do Servidor de Destino : SQL Server 2017
    Edição de Mecanismo de Banco de Dados de Destino : Microsoft SQL Server Enterprise Edition
    Tipo de Mecanismo de Banco de Dados de Destino : SQL Server Autônomo
*/

USE [Cadastro]
GO

/****** Object:  Table [dbo].[Telefones]    Script Date: 06/01/2020 22:06:28 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Telefones](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[telefone] [int] NULL,
	[email] [varchar](255) NULL,
	[site] [varchar](255) NULL,
	[id_contato] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Telefones]  WITH CHECK ADD  CONSTRAINT [FK_Contatos_Telefone] FOREIGN KEY([id_contato])
REFERENCES [dbo].[Contatos] ([id])
GO

ALTER TABLE [dbo].[Telefones] CHECK CONSTRAINT [FK_Contatos_Telefone]
GO


