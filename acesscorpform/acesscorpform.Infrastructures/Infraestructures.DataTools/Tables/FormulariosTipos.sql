CREATE TABLE [dbo].[FormulariosTipos]
(
	[FormularioTipoId] BIGINT IDENTITY(1,1) NOT NULL 
,	[Nome] VARCHAR(100) NOT NULL
,	[Apelido] VARCHAR(40) NOT NULL
,	[FlagStatus] [bit] NOT NULL
,	[CadastroUsuarioId] BIGINT NOT NULL
,	[CadastroDataHora] DATETIME2 NOT NULL
,	[AtualizacaoUsuarioId] BIGINT NULL
,	[AtualizacaoDataHora] DATETIME2 NULL
,	CONSTRAINT [PK_FormulariosTipos] PRIMARY KEY CLUSTERED 
	(
		[FormularioTipoId] ASC
	)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO 