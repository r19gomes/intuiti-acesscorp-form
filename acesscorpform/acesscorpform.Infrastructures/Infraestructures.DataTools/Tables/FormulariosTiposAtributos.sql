CREATE TABLE [dbo].[FormulariosTipoDeAtributos]
(
	[FormularioTipoDeAtributoId] BIGINT IDENTITY(1,1) NOT NULL
,	[FormularioId] BIGINT NOT NULL
,	[TipoDeAtributoId] BIGINT NOT NULL
,	[Observacao] VARCHAR(MAX) NULL
,	[FlagStatus] BIT NOT NULL
,	[CadastroUsuarioId] BIGINT NOT NULL
,	[CadastroDataHora] DATETIME2 NOT NULL
,	[AtualizacaoUsuarioId] BIGINT NULL
,	[AtualizacaoDataHora] DATETIME2 NULL, 
    CONSTRAINT [PK_FormulariosTiposAtributos] PRIMARY KEY CLUSTERED 
	(
		[FormularioTipoDeAtributoId] ASC
	)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO 

ALTER TABLE [dbo].[FormulariosTipoDeAtributos] ADD
CONSTRAINT [FK_FormulariosTipoDeAtributos_FormularioId_Formularios_FormularioId] FOREIGN KEY
(
	[FormularioId]
) REFERENCES [dbo].[Formularios] (
	[FormularioId]
) 
GO

ALTER TABLE [dbo].[FormulariosTipoDeAtributos] ADD
CONSTRAINT [FK_FormulariosTipoDeAtributos_TipoDeAtributoId_TipoDeAtributos_TipoDeAtributoId] FOREIGN KEY
(
	[TipoDeAtributoId]
) REFERENCES [dbo].[TipoDeAtributos] (
	[TipoDeAtributoId]
) 
GO