CREATE TABLE [dbo].[FormulariosTiposAtributos]
(
	[FormularioTipoAtributoId] BIGINT NOT NULL
,	[FormularioId] BIGINT NOT NULL
,	[TipoAtributoId] BIGINT IDENTITY(1,1) NOT NULL
,	[Observacao] VARCHAR(MAX) NULL
,	[FlagStatus] BIT NOT NULL
,	[CadastroUsuarioId] BIGINT NOT NULL
,	[CadastroDataHora] DATETIME2 NOT NULL
,	[AtualizacaoUsuarioId] BIGINT NULL
,	[AtualizacaoDataHora] DATETIME2 NULL, 
    CONSTRAINT [PK_FormulariosTiposAtributos] PRIMARY KEY CLUSTERED 
	(
		[FormularioTipoAtributoId] ASC
	)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO 

ALTER TABLE [dbo].[FormulariosTiposAtributos] ADD
CONSTRAINT [FK_FormulariosTiposAtributos_FormularioId_Formularios_FormularioId] FOREIGN KEY
(
	[FormularioId]
) REFERENCES [dbo].[Formularios] (
	[FormularioId]
) 
GO

ALTER TABLE [dbo].[FormulariosTiposAtributos] ADD
CONSTRAINT [FK_FormulariosTiposAtributos_TipoAtributoId_TiposAtributos_TipoAtributoId] FOREIGN KEY
(
	[TipoAtributoId]
) REFERENCES [dbo].[TiposAtributos] (
	[TipoAtributoId]
) 
GO