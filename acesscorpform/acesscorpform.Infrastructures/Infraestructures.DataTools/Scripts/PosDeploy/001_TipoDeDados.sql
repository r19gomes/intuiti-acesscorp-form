SET IDENTITY_INSERT TipoDeDados ON --Desabilita o IDENTITY
GO

IF	NOT EXISTS(SELECT * FROM TipoDeDados WHERE TipoDeDadoId > 0 AND Nome = 'bigint') BEGIN
	INSERT [dbo].[TipoDeDados]
	(
		[TipoDeDadoId]
	,	[Nome]
	,	[FlagStatus]
	,	[CadastroUsuarioId]
	,	[CadastroDataHora]
	,	[AtualizacaoUsuarioId]
	,	[AtualizacaoDataHora]
	)
	SELECT 
		[TipoDeDadoId] = 1
	,	[Nome] = 'bigint'
	,	[FlagStatus] = 1 -- Usuário Master (administrador do sistema)
	,	[CadastroUsuarioId] = 1
	,	[CadastroDataHora] = GETDATE()
	,	[AtualizacaoUsuarioId] = NULL
	,	[AtualizacaoDataHora] = NULL
END
GO

IF	NOT EXISTS(SELECT * FROM TipoDeDados WHERE TipoDeDadoId > 0 AND Nome = 'bit') BEGIN
	INSERT [dbo].[TipoDeDados]
	(
		[TipoDeDadoId]
	,	[Nome]
	,	[FlagStatus]
	,	[CadastroUsuarioId]
	,	[CadastroDataHora]
	,	[AtualizacaoUsuarioId]
	,	[AtualizacaoDataHora]
	)
	SELECT 
		[TipoDeDadoId] = 2
	,	[Nome] = 'bit'
	,	[FlagStatus] = 1 -- Usuário Master (administrador do sistema)
	,	[CadastroUsuarioId] = 1
	,	[CadastroDataHora] = GETDATE()
	,	[AtualizacaoUsuarioId] = NULL
	,	[AtualizacaoDataHora] = NULL
END
GO

IF	NOT EXISTS(SELECT * FROM TipoDeDados WHERE TipoDeDadoId > 0 AND Nome = 'datetime') BEGIN
	INSERT [dbo].[TipoDeDados]
	(
		[TipoDeDadoId]
	,	[Nome]
	,	[FlagStatus]
	,	[CadastroUsuarioId]
	,	[CadastroDataHora]
	,	[AtualizacaoUsuarioId]
	,	[AtualizacaoDataHora]
	)
	SELECT 
		[TipoDeDadoId] = 3
	,	[Nome] = 'datetime'
	,	[FlagStatus] = 1 -- Usuário Master (administrador do sistema)
	,	[CadastroUsuarioId] = 1
	,	[CadastroDataHora] = GETDATE()
	,	[AtualizacaoUsuarioId] = NULL
	,	[AtualizacaoDataHora] = NULL
END
GO

IF	NOT EXISTS(SELECT * FROM TipoDeDados WHERE TipoDeDadoId > 0 AND Nome = 'varchar') BEGIN
	INSERT [dbo].[TipoDeDados]
	(
		[TipoDeDadoId]
	,	[Nome]
	,	[FlagStatus]
	,	[CadastroUsuarioId]
	,	[CadastroDataHora]
	,	[AtualizacaoUsuarioId]
	,	[AtualizacaoDataHora]
	)
	SELECT 
		[TipoDeDadoId] = 4
	,	[Nome] = 'varchar'
	,	[FlagStatus] = 1 -- Usuário Master (administrador do sistema)
	,	[CadastroUsuarioId] = 1
	,	[CadastroDataHora] = GETDATE()
	,	[AtualizacaoUsuarioId] = NULL
	,	[AtualizacaoDataHora] = NULL
END
GO

IF	NOT EXISTS(SELECT * FROM TipoDeDados WHERE TipoDeDadoId > 0 AND Nome = 'float') BEGIN
	INSERT [dbo].[TipoDeDados]
	(
		[TipoDeDadoId]
	,	[Nome]
	,	[FlagStatus]
	,	[CadastroUsuarioId]
	,	[CadastroDataHora]
	,	[AtualizacaoUsuarioId]
	,	[AtualizacaoDataHora]
	)
	SELECT 
		[TipoDeDadoId] = 5
	,	[Nome] = 'float'
	,	[FlagStatus] = 1 -- Usuário Master (administrador do sistema)
	,	[CadastroUsuarioId] = 1
	,	[CadastroDataHora] = GETDATE()
	,	[AtualizacaoUsuarioId] = NULL
	,	[AtualizacaoDataHora] = NULL
END
GO

IF	NOT EXISTS(SELECT * FROM TipoDeDados WHERE TipoDeDadoId > 0 AND Nome = 'decimal') BEGIN
	INSERT [dbo].[TipoDeDados]
	(
		[TipoDeDadoId]
	,	[Nome]
	,	[FlagStatus]
	,	[CadastroUsuarioId]
	,	[CadastroDataHora]
	,	[AtualizacaoUsuarioId]
	,	[AtualizacaoDataHora]
	)
	SELECT 
		[TipoDeDadoId] = 6
	,	[Nome] = 'decimal'
	,	[FlagStatus] = 1 -- Usuário Master (administrador do sistema)
	,	[CadastroUsuarioId] = 1
	,	[CadastroDataHora] = GETDATE()
	,	[AtualizacaoUsuarioId] = NULL
	,	[AtualizacaoDataHora] = NULL
END
GO

IF	NOT EXISTS(SELECT * FROM TipoDeDados WHERE TipoDeDadoId > 0 AND Nome = 'money') BEGIN
	INSERT [dbo].[TipoDeDados]
	(
		[TipoDeDadoId]
	,	[Nome]
	,	[FlagStatus]
	,	[CadastroUsuarioId]
	,	[CadastroDataHora]
	,	[AtualizacaoUsuarioId]
	,	[AtualizacaoDataHora]
	)
	SELECT 
		[TipoDeDadoId] = 7
	,	[Nome] = 'money'
	,	[FlagStatus] = 1 -- Usuário Master (administrador do sistema)
	,	[CadastroUsuarioId] = 1
	,	[CadastroDataHora] = GETDATE()
	,	[AtualizacaoUsuarioId] = NULL
	,	[AtualizacaoDataHora] = NULL
END
GO

IF	NOT EXISTS(SELECT * FROM TipoDeDados WHERE TipoDeDadoId > 0 AND Nome = 'int') BEGIN
	INSERT [dbo].[TipoDeDados]
	(
		[TipoDeDadoId]
	,	[Nome]
	,	[FlagStatus]
	,	[CadastroUsuarioId]
	,	[CadastroDataHora]
	,	[AtualizacaoUsuarioId]
	,	[AtualizacaoDataHora]
	)
	SELECT 
		[TipoDeDadoId] = 8
	,	[Nome] = 'int'
	,	[FlagStatus] = 1 -- Usuário Master (administrador do sistema)
	,	[CadastroUsuarioId] = 1
	,	[CadastroDataHora] = GETDATE()
	,	[AtualizacaoUsuarioId] = NULL
	,	[AtualizacaoDataHora] = NULL
END
GO

IF	NOT EXISTS(SELECT * FROM TipoDeDados WHERE TipoDeDadoId > 0 AND Nome = 'numeric') BEGIN
	INSERT [dbo].[TipoDeDados]
	(
		[TipoDeDadoId]
	,	[Nome]
	,	[FlagStatus]
	,	[CadastroUsuarioId]
	,	[CadastroDataHora]
	,	[AtualizacaoUsuarioId]
	,	[AtualizacaoDataHora]
	)
	SELECT 
		[TipoDeDadoId] = 9
	,	[Nome] = 'numeric'
	,	[FlagStatus] = 1 -- Usuário Master (administrador do sistema)
	,	[CadastroUsuarioId] = 1
	,	[CadastroDataHora] = GETDATE()
	,	[AtualizacaoUsuarioId] = NULL
	,	[AtualizacaoDataHora] = NULL
END
GO

IF	NOT EXISTS(SELECT * FROM TipoDeDados WHERE TipoDeDadoId > 0 AND Nome = 'object') BEGIN
	INSERT [dbo].[TipoDeDados]
	(
		[TipoDeDadoId]
	,	[Nome]
	,	[FlagStatus]
	,	[CadastroUsuarioId]
	,	[CadastroDataHora]
	,	[AtualizacaoUsuarioId]
	,	[AtualizacaoDataHora]
	)
	SELECT 
		[TipoDeDadoId] = 10
	,	[Nome] = 'object'
	,	[FlagStatus] = 1 -- Usuário Master (administrador do sistema)
	,	[CadastroUsuarioId] = 1
	,	[CadastroDataHora] = GETDATE()
	,	[AtualizacaoUsuarioId] = NULL
	,	[AtualizacaoDataHora] = NULL
END
GO

SET IDENTITY_INSERT TipoDeDados OFF --Habilita o IDENTITY
GO