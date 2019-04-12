use DB_ACESSCORP
GO

SET IDENTITY_INSERT FormulariosStatus ON --Desabilita o IDENTITY
GO

IF	NOT EXISTS(SELECT * FROM [dbo].[FormulariosStatus] WHERE FormularioStatusId > 0 AND Nome = 'Em Elaboração')
BEGIN
	DECLARE @FORMULARIO_STATUS_ID BIGINT = 0;
	INSERT [dbo].[FormulariosStatus]
	(
		[FormularioStatusId]
	,	[Nome]
	,	[FlagStatus]
	,	[CadastroUsuarioId] 
	,	[CadastroDataHora]
	,	[AtualizacaoUsuarioId]
	,	[AtualizacaoDataHora]
	)
	SELECT
		[FormularioStatusId] = 1
	,	[Nome] = 'Em Elaboração' 
	,	[FlagStatus] = 1
	,	[CadastroUsuarioId] = 1  
	,	[CadastroDataHora] = GETDATE()
	,	[AtualizacaoUsuarioId] = NULL
	,	[AtualizacaoDataHora] = NULL
	;
	SET @FORMULARIO_STATUS_ID = SCOPE_IDENTITY();
END
GO

IF	NOT EXISTS(SELECT * FROM [dbo].[FormulariosStatus] WHERE FormularioStatusId > 0 AND Nome = 'Liberado')
BEGIN
	DECLARE @FORMULARIO_STATUS_ID BIGINT = 0;
	INSERT [dbo].[FormulariosStatus]
	(
		[FormularioStatusId]
	,	[Nome]
	,	[FlagStatus]
	,	[CadastroUsuarioId] 
	,	[CadastroDataHora]
	,	[AtualizacaoUsuarioId]
	,	[AtualizacaoDataHora]
	)
	SELECT
		[FormularioStatusId] = 2
	,	[Nome] = 'Liberado' 
	,	[FlagStatus] = 1
	,	[CadastroUsuarioId] = 1  
	,	[CadastroDataHora] = GETDATE()
	,	[AtualizacaoUsuarioId] = NULL
	,	[AtualizacaoDataHora] = NULL
	;
	SET @FORMULARIO_STATUS_ID = SCOPE_IDENTITY();
END
GO

IF	NOT EXISTS(SELECT * FROM [dbo].[FormulariosStatus] WHERE FormularioStatusId > 0 AND Nome = 'Cancelado')
BEGIN
	DECLARE @FORMULARIO_STATUS_ID BIGINT = 0;
	INSERT [dbo].[FormulariosStatus]
	(
		[FormularioStatusId]
	,	[Nome]
	,	[FlagStatus]
	,	[CadastroUsuarioId] 
	,	[CadastroDataHora]
	,	[AtualizacaoUsuarioId]
	,	[AtualizacaoDataHora]
	)
	SELECT
		[FormularioStatusId] = 3
	,	[Nome] = 'Cancelado' 
	,	[FlagStatus] = 1
	,	[CadastroUsuarioId] = 1  
	,	[CadastroDataHora] = GETDATE()
	,	[AtualizacaoUsuarioId] = NULL
	,	[AtualizacaoDataHora] = NULL
	;
	SET @FORMULARIO_STATUS_ID = SCOPE_IDENTITY();
END
GO

SET IDENTITY_INSERT FormulariosStatus OFF --Habilita o IDENTITY
GO
