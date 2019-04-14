CREATE TABLE [dbo].[Formularios]
(
	[FormularioId] BIGINT IDENTITY(1,1) NOT NULL
,	[Nome] VARCHAR(1000) NOT NULL
,	[Apelido] VARCHAR(100) NOT NULL
,	[FormularioStatusId] INT NOT NULL
,	[DataVigenciaInicial] DATE NULL
,	[DataVigenciaFinal] DATE NULL
,	[FormularioTipoId] INT NULL
,	[CadastroUsuarioId] BIGINT NOT NULL
,	[CadastroDataHora] DATETIME2 NOT NULL
,	[AtualizacaoUsuarioId] BIGINT NULL
,	[AtualizacaoDataHora] DATETIME2 NULL
,	CONSTRAINT [PK_Formularios] PRIMARY KEY CLUSTERED 
	(
		[FormularioId] ASC
	)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO 

ALTER TABLE [dbo].[Formularios] ADD
CONSTRAINT [FK_Formularios_FormularioTipoId_FormulariosTipos_FormularioTipoId] FOREIGN KEY
(
	[FormularioTipoId]
) REFERENCES [dbo].[FormulariosTipos] (
	[FormularioTipoId]
) 
GO

ALTER TABLE [dbo].[Formularios] ADD
CONSTRAINT [FK_Formularios_FormularioStatusId_FormulariosStatus_FormularioStatusId] FOREIGN KEY
(
	[FormularioStatusId]
) REFERENCES [dbo].[FormulariosStatus] (
	[FormularioStatusId]
) 
GO