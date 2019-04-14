Use DB_ACESSCORP
GO

SET IDENTITY_INSERT FormulariosTipoDeAtributos ON --Desabilita o IDENTITY
GO

IF	NOT EXISTS(
	SELECT * FROM [dbo].[FormulariosTipoDeAtributos] 
		WHERE 
			FormularioId IN (SELECT FormularioId FROM Formularios WHERE FormularioId > 0 AND Nome = 'Formulário básico para contato do Fale Conosco.')
		AND
			TipoDeAtributoId IN (SELECT TipoDeAtributoId FROM TipoDeAtributos WHERE TipoDeAtributoId > 0 AND Nome = 'Nome')
	) 
BEGIN
	DECLARE @FORMULARIO_ID BIGINT = 0;
	SELECT 
		@FORMULARIO_ID = FormularioTipoId
	FROM
		Formularios
	WHERE
		FormularioId > 0 
	AND
		Nome = 'Formulário básico para contato do Fale Conosco.'
	;
	DECLARE @TIPO_DE_ATRIBUTO_ID BIGINT = 0;
	SELECT
		@TIPO_DE_ATRIBUTO_ID = TipoDeAtributoId
	FROM
		TipoDeAtributos
	WHERE
		TipoDeAtributoId > 0 
	AND
		Nome = 'Nome'
	;
	IF	NOT EXISTS(SELECT * FROM FormulariosTipoDeAtributos WHERE FormularioId = @FORMULARIO_ID AND TipoDeAtributoId = @TIPO_DE_ATRIBUTO_ID) BEGIN
		INSERT [dbo].[FormulariosTipoDeAtributos]
		(
			[FormularioTipoDeAtributoId]
		,	[FormularioId]
		,	[TipoDeAtributoId]
		,	[Observacao]
		,	[FlagStatus]
		,	[CadastroUsuarioId]
		,	[CadastroDataHora]
		,	[AtualizacaoUsuarioId]
		,	[AtualizacaoDataHora]
		)
		SELECT 
			[FormularioTipoDeAtributoId] = 1
		,	[FormularioId] = @FORMULARIO_ID
		,	[TipoDeAtributoId] = @TIPO_DE_ATRIBUTO_ID
		,	[Observacao] = ''
		,	[FlagStatus] = 1
		,	[CadastroUsuarioId] = 1 
		,	[CadastroDataHora] = GETDATE()
		,	[AtualizacaoUsuarioId] = NULL
		,	[AtualizacaoDataHora] = NULL
		;
		SET @FORMULARIO_ID = SCOPE_IDENTITY();
	END
END
GO

IF	NOT EXISTS(
	SELECT * FROM [dbo].[FormulariosTipoDeAtributos] 
		WHERE 
			FormularioId IN (SELECT FormularioId FROM Formularios WHERE FormularioId > 0 AND Nome = 'Formulário básico para contato do Fale Conosco.')
		AND
			TipoDeAtributoId IN (SELECT TipoDeAtributoId FROM TipoDeAtributos WHERE TipoDeAtributoId > 0 AND Nome = 'Email')
	) 
BEGIN
	DECLARE @FORMULARIO_ID BIGINT = 0;
	SELECT 
		@FORMULARIO_ID = FormularioTipoId
	FROM
		Formularios
	WHERE
		FormularioId > 0 
	AND
		Nome = 'Formulário básico para contato do Fale Conosco.'
	;
	DECLARE @TIPO_DE_ATRIBUTO_ID BIGINT = 0;
	SELECT
		@TIPO_DE_ATRIBUTO_ID = TipoDeAtributoId
	FROM
		TipoDeAtributos
	WHERE
		TipoDeAtributoId > 0 
	AND
		Nome = 'Email'
	;
	IF	NOT EXISTS(SELECT * FROM FormulariosTipoDeAtributos WHERE FormularioId = @FORMULARIO_ID AND TipoDeAtributoId = @TIPO_DE_ATRIBUTO_ID) BEGIN
		INSERT [dbo].[FormulariosTipoDeAtributos]
		(
			[FormularioTipoDeAtributoId]
		,	[FormularioId]
		,	[TipoDeAtributoId]
		,	[Observacao]
		,	[FlagStatus]
		,	[CadastroUsuarioId]
		,	[CadastroDataHora]
		,	[AtualizacaoUsuarioId]
		,	[AtualizacaoDataHora]
		)
		SELECT 
			[FormularioTipoDeAtributoId] = 2
		,	[FormularioId] = @FORMULARIO_ID
		,	[TipoDeAtributoId] = @TIPO_DE_ATRIBUTO_ID
		,	[Observacao] = ''
		,	[FlagStatus] = 1
		,	[CadastroUsuarioId] = 1 
		,	[CadastroDataHora] = GETDATE()
		,	[AtualizacaoUsuarioId] = NULL
		,	[AtualizacaoDataHora] = NULL
		;
		SET @FORMULARIO_ID = SCOPE_IDENTITY();
	END
END
GO

IF	NOT EXISTS(
	SELECT * FROM [dbo].[FormulariosTipoDeAtributos] 
		WHERE 
			FormularioId IN (SELECT FormularioId FROM Formularios WHERE FormularioId > 0 AND Nome = 'Formulário básico para contato do Fale Conosco.')
		AND
			TipoDeAtributoId IN (SELECT TipoDeAtributoId FROM TipoDeAtributos WHERE TipoDeAtributoId > 0 AND Nome = 'Assunto')
	) 
BEGIN
	DECLARE @FORMULARIO_ID BIGINT = 0;
	SELECT 
		@FORMULARIO_ID = FormularioTipoId
	FROM
		Formularios
	WHERE
		FormularioId > 0 
	AND
		Nome = 'Formulário básico para contato do Fale Conosco.'
	;
	DECLARE @TIPO_DE_ATRIBUTO_ID BIGINT = 0;
	SELECT
		@TIPO_DE_ATRIBUTO_ID = TipoDeAtributoId
	FROM
		TipoDeAtributos
	WHERE
		TipoDeAtributoId > 0 
	AND
		Nome = 'Assunto'
	;
	IF	NOT EXISTS(SELECT * FROM FormulariosTipoDeAtributos WHERE FormularioId = @FORMULARIO_ID AND TipoDeAtributoId = @TIPO_DE_ATRIBUTO_ID) BEGIN
		INSERT [dbo].[FormulariosTipoDeAtributos]
		(
			[FormularioTipoDeAtributoId]
		,	[FormularioId]
		,	[TipoDeAtributoId]
		,	[Observacao]
		,	[FlagStatus]
		,	[CadastroUsuarioId]
		,	[CadastroDataHora]
		,	[AtualizacaoUsuarioId]
		,	[AtualizacaoDataHora]
		)
		SELECT 
			[FormularioTipoDeAtributoId] = 3
		,	[FormularioId] = @FORMULARIO_ID
		,	[TipoDeAtributoId] = @TIPO_DE_ATRIBUTO_ID
		,	[Observacao] = ''
		,	[FlagStatus] = 1
		,	[CadastroUsuarioId] = 1 
		,	[CadastroDataHora] = GETDATE()
		,	[AtualizacaoUsuarioId] = NULL
		,	[AtualizacaoDataHora] = NULL
		;
		SET @FORMULARIO_ID = SCOPE_IDENTITY();
	END
END
GO

IF	NOT EXISTS(
	SELECT * FROM [dbo].[FormulariosTipoDeAtributos] 
		WHERE 
			FormularioId IN (SELECT FormularioId FROM Formularios WHERE FormularioId > 0 AND Nome = 'Formulário básico para contato do Fale Conosco.')
		AND
			TipoDeAtributoId IN (SELECT TipoDeAtributoId FROM TipoDeAtributos WHERE TipoDeAtributoId > 0 AND Nome = 'Mensagem')
	) 
BEGIN
	DECLARE @FORMULARIO_ID BIGINT = 0;
	SELECT 
		@FORMULARIO_ID = FormularioTipoId
	FROM
		Formularios
	WHERE
		FormularioId > 0 
	AND
		Nome = 'Formulário básico para contato do Fale Conosco.'
	;
	DECLARE @TIPO_DE_ATRIBUTO_ID BIGINT = 0;
	SELECT
		@TIPO_DE_ATRIBUTO_ID = TipoDeAtributoId
	FROM
		TipoDeAtributos
	WHERE
		TipoDeAtributoId > 0 
	AND
		Nome = 'Mensagem'
	;
	IF	NOT EXISTS(SELECT * FROM FormulariosTipoDeAtributos WHERE FormularioId = @FORMULARIO_ID AND TipoDeAtributoId = @TIPO_DE_ATRIBUTO_ID) BEGIN
		INSERT [dbo].[FormulariosTipoDeAtributos]
		(
			[FormularioTipoDeAtributoId]
		,	[FormularioId]
		,	[TipoDeAtributoId]
		,	[Observacao]
		,	[FlagStatus]
		,	[CadastroUsuarioId]
		,	[CadastroDataHora]
		,	[AtualizacaoUsuarioId]
		,	[AtualizacaoDataHora]
		)
		SELECT 
			[FormularioTipoDeAtributoId] = 4
		,	[FormularioId] = @FORMULARIO_ID
		,	[TipoDeAtributoId] = @TIPO_DE_ATRIBUTO_ID
		,	[Observacao] = ''
		,	[FlagStatus] = 1
		,	[CadastroUsuarioId] = 1 
		,	[CadastroDataHora] = GETDATE()
		,	[AtualizacaoUsuarioId] = NULL
		,	[AtualizacaoDataHora] = NULL
		;
		SET @FORMULARIO_ID = SCOPE_IDENTITY();
	END
END
GO

SET IDENTITY_INSERT FormulariosTipoDeAtributos OFF --Habilita o IDENTITY
GO