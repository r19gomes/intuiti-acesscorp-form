﻿--Use DB_ACESSCORP
--GO

--SET IDENTITY_INSERT Formularios ON --Desabilita o IDENTITY
--GO

--IF	NOT EXISTS(SELECT * FROM [dbo].[Formularios] WHERE FormularioId > 0 AND Nome = 'Formulário básico para contato do Fale Conosco.') BEGIN
--	DECLARE @FORMULARIO_ID BIGINT = 0;
--	DECLARE @FORMULARIO_STATUS_ID BIGINT = 0;
--	SELECT
--		@FORMULARIO_STATUS_ID = FormularioStatusId
--	FROM
--		[dbo].[FormulariosStatus]
--	WHERE
--		FormularioStatusId > 0
--	AND
--		Nome = 'Em Elaboração'
--	;	
--	select @FORMULARIO_STATUS_ID
--	DECLARE @DATA_VIGENCIA_INICIAL DATETIME = GETDATE();
--	DECLARE @DATA_VIGENCIA_FINAL DATETIME = DATEADD(year,1, @DATA_VIGENCIA_INICIAL); 
--	DECLARE @FORMULARIO_TIPO_ID BIGINT = 0;
--	SELECT 
--		@FORMULARIO_TIPO_ID = FormularioTipoId
--	FROM
--		FormulariosTipos
--	WHERE
--		FormularioTipoId > 0 
--	AND
--		Nome = 'Fale Conosco'
--	;
--	INSERT [dbo].[Formularios]
--	(
--		[FormularioId]
--	,	[Nome]
--	,	[Apelido]
--	,	[FormularioStatusId]
--	,	[DataVigenciaInicial]
--	,	[DataVigenciaFinal]
--	,	[FormularioTipoId]
--	,	[CadastroUsuarioId]
--	,	[CadastroDataHora]
--	,	[AtualizacaoUsuarioId]
--	,	[AtualizacaoDataHora]
--	)
--	SELECT 
--		[FormularioId] = 1
--	,	[Nome] = 'Formulário básico para contato do Fale Conosco.'
--	,	[Apelido] = 'Fale Conosco'
--	,	[FormularioStatusId] = @FORMULARIO_STATUS_ID 
--	,	[DataVigenciaInicial] = @DATA_VIGENCIA_INICIAL
--	,	[DataVigenciaFinal] = @DATA_VIGENCIA_FINAL
--	,	[FormularioTipoId] = @FORMULARIO_TIPO_ID
--	,	[CadastroUsuarioId] = 1
--	,	[CadastroDataHora] = GETDATE()
--	,	[AtualizacaoUsuarioId] = NULL
--	,	[AtualizacaoDataHora] = NULL
--	;
--	SET @FORMULARIO_ID = SCOPE_IDENTITY();
--END

--SET IDENTITY_INSERT Formularios OFF --Habilita o IDENTITY
--GO