/*    ==Par�metros de Script==

    Vers�o do Servidor de Origem : SQL Server 2017 (14.0.1000)
    Edi��o do Mecanismo de Banco de Dados de Origem : Microsoft SQL Server Enterprise Edition
    Tipo do Mecanismo de Banco de Dados de Origem : SQL Server Aut�nomo

    Vers�o do Servidor de Destino : SQL Server 2017
    Edi��o de Mecanismo de Banco de Dados de Destino : Microsoft SQL Server Enterprise Edition
    Tipo de Mecanismo de Banco de Dados de Destino : SQL Server Aut�nomo
*/

USE [Cadastro]
GO

/****** Object:  Table [dbo].[Contatos]    Script Date: 06/01/2020 20:32:37 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Contatos](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nome] [varchar](100) NULL,
	[endereco] [varchar](100) NULL,
	[bairro] [varchar](50) NULL,
	[cidade] [varchar](50) NULL,
	[estado] [char](2) NULL,
	[cep] [varchar](20) NULL,
	[status] [char](1) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


