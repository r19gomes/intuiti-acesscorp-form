use DB_ACESSCORP
GO

SET IDENTITY_INSERT FormulariosTipos ON --Desabilita o IDENTITY
GO

IF	NOT EXISTS(SELECT * FROM [dbo].[FormulariosTipos] WHERE FormularioTipoId > 0 AND Nome = 'Padrão')
BEGIN
	DECLARE @FORMULARIO_TIPO_ID BIGINT = 0;
	INSERT [dbo].[FormulariosTipos]
	(
		[FormularioTipoId]
	,	[Nome]
	,	[Apelido]
	,	[FlagStatus]
	,	[CadastroUsuarioId]
	,	[CadastroDataHora]
	,	[AtualizacaoUsuarioId]
	,	[AtualizacaoDataHora]
	)
	SELECT
		[FormularioTipoId] = 1
	,	[Nome] = 'Padrão'
	,	[Apelido] = 'Padrão'
	,	[FlagStatus] = 1
	,	[CadastroUsuarioId] = 1
	,	[CadastroDataHora] = GETDATE()
	,	[AtualizacaoUsuarioId] = NULL
	,	[AtualizacaoDataHora] = NULL
	;
	SET @FORMULARIO_TIPO_ID = SCOPE_IDENTITY();
END
GO

IF	NOT EXISTS(SELECT * FROM [dbo].[FormulariosTipos] WHERE FormularioTipoId > 0 AND Nome = 'Cadastro')
BEGIN
	DECLARE @FORMULARIO_TIPO_ID BIGINT = 0;
	INSERT [dbo].[FormulariosTipos]
	(
		[FormularioTipoId]
	,	[Nome]
	,	[Apelido]
	,	[FlagStatus]
	,	[CadastroUsuarioId]
	,	[CadastroDataHora]
	,	[AtualizacaoUsuarioId]
	,	[AtualizacaoDataHora]
	)
	SELECT
		[FormularioTipoId] = 2
	,	[Nome] = 'Cadastro'
	,	[Apelido] = 'Cadastro'
	,	[FlagStatus] = 1
	,	[CadastroUsuarioId] = 1
	,	[CadastroDataHora] = GETDATE()
	,	[AtualizacaoUsuarioId] = NULL
	,	[AtualizacaoDataHora] = NULL
	;
	SET @FORMULARIO_TIPO_ID = SCOPE_IDENTITY();
END
GO

IF	NOT EXISTS(SELECT * FROM [dbo].[FormulariosTipos] WHERE FormularioTipoId > 0 AND Nome = 'Fale Conosco')
BEGIN
	DECLARE @FORMULARIO_TIPO_ID BIGINT = 0;
	INSERT [dbo].[FormulariosTipos]
	(
		[FormularioTipoId]
	,	[Nome]
	,	[Apelido]
	,	[FlagStatus]
	,	[CadastroUsuarioId]
	,	[CadastroDataHora]
	,	[AtualizacaoUsuarioId]
	,	[AtualizacaoDataHora]
	)
	SELECT
		[FormularioTipoId] = 3
	,	[Nome] = 'Fale Conosco'
	,	[Apelido] = 'Fale Conosco'
	,	[FlagStatus] = 1
	,	[CadastroUsuarioId] = 1
	,	[CadastroDataHora] = GETDATE()
	,	[AtualizacaoUsuarioId] = NULL
	,	[AtualizacaoDataHora] = NULL
	;
	SET @FORMULARIO_TIPO_ID = SCOPE_IDENTITY();
END
GO

SET IDENTITY_INSERT FormulariosTipos OFF --Habilita o IDENTITY
GO