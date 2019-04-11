IF	NOT EXISTS(SELECT * FROM [dbo].[TipoDeAtributos] WHERE TipoDeAtributoId > 0 AND Nome = 'Endereço')
BEGIN
	DECLARE @TIPO_DE_ATRIBUTO_ID INT = 0;
	DECLARE @TIPO_DE_DADO_ID INT = NULL;
	SELECT
		@TIPO_DE_DADO_ID = TipoDeDadoId
	FROM 
		TipoDeDados 
	WHERE
		TipoDeDadoId > 0 
	AND
		Nome = 'varchar'
	;	
	INSERT [dbo].[TipoDeAtributos]
	(
		[TipoDeAtributoId] 
	,	[Nome] 
	,	[Apelido] 
	,	[Descricao] 
	,	[NomeFisico]
	,	[TipoDeDadoId]
	,	[FlagStatus]
	,	[OrdemExibicao]
	,	[Limitador]
	,	[Qualificador]
	,	[CadastroUsuarioId]
	,	[CadastroDataHora]
	,	[AtualizacaoUsuarioId]
	,	[AtualizacaoDataHora]	
	)
	SELECT
		[TipoDeAtributoId] = 2
	,	[Nome] = 'Endereço'	
	,	[Apelido] = 'Endereço'
	,	[Descricao] = NULL
	,	[NomeFisico] = "ENDERECO"
	,	[TipoDeDadoId] = @TIPO_DE_DADO_ID  
	,	[FlagStatus] = 1		
	,	[OrdemExibicao] = 0
	,	[Limitador] = 0
	,	[Qualificador] = 0
	,	[CadastroUsuarioId] = GETDATE()
	,	[CadastroDataHora] = 1
	,	[AtualizacaoUsuarioId] = NULL
	,	[AtualizacaoDataHora] = NULL
	;
	SET @TIPO_DE_ATRIBUTO_ID = SCOPE_IDENTITY()
END
GO

IF	NOT EXISTS(SELECT * FROM [dbo].[TipoDeAtributos] WHERE TipoDeAtributoId > 0 AND Nome = 'Endereço')
BEGIN
	DECLARE @TIPO_DE_ATRIBUTO_ID INT = 0;
		DECLARE @TIPO_DE_DADO_ID INT = NULL;
	SELECT
		@TIPO_DE_DADO_ID = TipoDeDadoId
	FROM 
		TipoDeDados 
	WHERE
		TipoDeDadoId > 0 
	AND
		Nome = 'varchar'
	;	
	INSERT [dbo].[TipoDeAtributos]
	(
		[TipoDeAtributoId] 
	,	[Nome] 
	,	[Apelido] 
	,	[Descricao] 
	,	[NomeFisico]
	,	[TipoDeDadoId]
	,	[FlagStatus]
	,	[OrdemExibicao]
	,	[Limitador]
	,	[Qualificador]
	,	[CadastroUsuarioId]
	,	[CadastroDataHora]
	,	[AtualizacaoUsuarioId]
	,	[AtualizacaoDataHora]	
	)
	SELECT
		[TipoDeAtributoId] = 2
	,	[Nome] = 'Endereço'	
	,	[Apelido] = 'Endereço'
	,	[Descricao] = NULL
	,	[NomeFisico] = 'ENDERECO'
	,	[TipoDeDadoId] = @TIPO_DE_DADO_ID  
	,	[FlagStatus] = 1		
	,	[OrdemExibicao] = 0
	,	[Limitador] = 0
	,	[Qualificador] = 0
	,	[CadastroUsuarioId] = GETDATE()
	,	[CadastroDataHora] = 1
	,	[AtualizacaoUsuarioId] = NULL
	,	[AtualizacaoDataHora] = NULL
	;
	SET @TIPO_DE_ATRIBUTO_ID = SCOPE_IDENTITY()
END
GO

IF	NOT EXISTS(SELECT * FROM [dbo].[TipoDeAtributos] WHERE TipoDeAtributoId > 0 AND Nome = 'Endereço')
BEGIN
	DECLARE @TIPO_DE_ATRIBUTO_ID INT = 0;
	DECLARE @TIPO_DE_DADO_ID INT = NULL;
	SELECT
		@TIPO_DE_DADO_ID = TipoDeDadoId
	FROM 
		TipoDeDados 
	WHERE
		TipoDeDadoId > 0 
	AND
		Nome = 'varchar'
	;	

	INSERT [dbo].[TipoDeAtributos]
	(
		[TipoDeAtributoId] 
	,	[Nome] 
	,	[Apelido] 
	,	[Descricao] 
	,	[NomeFisico]
	,	[TipoDeDadoId]
	,	[FlagStatus]
	,	[OrdemExibicao]
	,	[Limitador]
	,	[Qualificador]
	,	[CadastroUsuarioId]
	,	[CadastroDataHora]
	,	[AtualizacaoUsuarioId]
	,	[AtualizacaoDataHora]	
	)
	SELECT
		[TipoDeAtributoId] = 3
	,	[Nome] = 'Complemento'	
	,	[Apelido] = 'Complemento'
	,	[Descricao] = NULL
	,	[NomeFisico] = 'COMPLEMENTO'
	,	[TipoDeDadoId] = @TIPO_DE_DADO_ID  
	,	[FlagStatus] = 1		
	,	[OrdemExibicao] = 0
	,	[Limitador] = 0
	,	[Qualificador] = 0
	,	[CadastroUsuarioId] = GETDATE()
	,	[CadastroDataHora] = 1
	,	[AtualizacaoUsuarioId] = NULL
	,	[AtualizacaoDataHora] = NULL
	;
	SET @TIPO_DE_ATRIBUTO_ID = SCOPE_IDENTITY()
END
GO

IF	NOT EXISTS(SELECT * FROM [dbo].[TipoDeAtributos] WHERE TipoDeAtributoId > 0 AND Nome = 'Endereço')
BEGIN
	DECLARE @TIPO_DE_ATRIBUTO_ID INT = 0;
	DECLARE @TIPO_DE_DADO_ID INT = NULL;
	SELECT
		@TIPO_DE_DADO_ID = TipoDeDadoId
	FROM 
		TipoDeDados 
	WHERE
		TipoDeDadoId > 0 
	AND
		Nome = 'varchar'
	;	
	INSERT [dbo].[TipoDeAtributos]
	(
		[TipoDeAtributoId] 
	,	[Nome] 
	,	[Apelido] 
	,	[Descricao] 
	,	[NomeFisico]
	,	[TipoDeDadoId]
	,	[FlagStatus]
	,	[OrdemExibicao]
	,	[Limitador]
	,	[Qualificador]
	,	[CadastroUsuarioId]
	,	[CadastroDataHora]
	,	[AtualizacaoUsuarioId]
	,	[AtualizacaoDataHora]	
	)
	SELECT
		[TipoDeAtributoId] = 4
	,	[Nome] = 'Bairro'	
	,	[Apelido] = 'Bairro'
	,	[Descricao] = NULL
	,	[NomeFisico] = 'BAIRRO'
	,	[TipoDeDadoId] = @TIPO_DE_DADO_ID
	,	[FlagStatus] = 1		
	,	[OrdemExibicao] = 0
	,	[Limitador] = 0
	,	[Qualificador] = 0
	,	[CadastroUsuarioId] = GETDATE()
	,	[CadastroDataHora] = 1
	,	[AtualizacaoUsuarioId] = NULL
	,	[AtualizacaoDataHora] = NULL
	;
	SET @TIPO_DE_ATRIBUTO_ID = SCOPE_IDENTITY()
END
GO

IF	NOT EXISTS(SELECT * FROM [dbo].[TipoDeAtributos] WHERE TipoDeAtributoId > 0 AND Nome = 'Endereço')
BEGIN
	DECLARE @TIPO_DE_ATRIBUTO_ID INT = 0;
	DECLARE @TIPO_DE_DADO_ID INT = NULL;
	SELECT
		@TIPO_DE_DADO_ID = TipoDeDadoId
	FROM 
		TipoDeDados 
	WHERE
		TipoDeDadoId > 0 
	AND
		Nome = 'varchar'
	;	
	INSERT [dbo].[TipoDeAtributos]
	(
		[TipoDeAtributoId] 
	,	[Nome] 
	,	[Apelido] 
	,	[Descricao] 
	,	[NomeFisico]
	,	[TipoDeDadoId]
	,	[FlagStatus]
	,	[OrdemExibicao]
	,	[Limitador]
	,	[Qualificador]
	,	[CadastroUsuarioId]
	,	[CadastroDataHora]
	,	[AtualizacaoUsuarioId]
	,	[AtualizacaoDataHora]	
	)
	SELECT
		[TipoDeAtributoId] = 5
	,	[Nome] = 'Cep'	
	,	[Apelido] = 'Cep'
	,	[Descricao] = NULL
	,	[NomeFisico] = 'CEP'
	,	[TipoDeDadoId] = @TIPO_DE_DADO_ID
	,	[FlagStatus] = 1		
	,	[OrdemExibicao] = 0
	,	[Limitador] = 0
	,	[Qualificador] = 0
	,	[CadastroUsuarioId] = GETDATE()
	,	[CadastroDataHora] = 1
	,	[AtualizacaoUsuarioId] = NULL
	,	[AtualizacaoDataHora] = NULL
	;
	SET @TIPO_DE_ATRIBUTO_ID = SCOPE_IDENTITY()
END
GO

IF	NOT EXISTS(SELECT * FROM [dbo].[TipoDeAtributos] WHERE TipoDeAtributoId > 0 AND Nome = 'Endereço')
BEGIN
	DECLARE @TIPO_DE_ATRIBUTO_ID INT = 0;
	DECLARE @TIPO_DE_DADO_ID INT = NULL;
	SELECT
		@TIPO_DE_DADO_ID = TipoDeDadoId
	FROM 
		TipoDeDados 
	WHERE
		TipoDeDadoId > 0 
	AND
		Nome = 'varchar'
	;	
	INSERT [dbo].[TipoDeAtributos]
	(
		[TipoDeAtributoId] 
	,	[Nome] 
	,	[Apelido] 
	,	[Descricao] 
	,	[NomeFisico]
	,	[TipoDeDadoId]
	,	[FlagStatus]
	,	[OrdemExibicao]
	,	[Limitador]
	,	[Qualificador]
	,	[CadastroUsuarioId]
	,	[CadastroDataHora]
	,	[AtualizacaoUsuarioId]
	,	[AtualizacaoDataHora]	
	)
	SELECT
		[TipoDeAtributoId] = 6
	,	[Nome] = 'Cep Complemento'	
	,	[Apelido] = 'Cep Complemento'
	,	[Descricao] = NULL
	,	[NomeFisico] = 'CEP_COMPLEMENTO'
	,	[TipoDeDadoId] = @TIPO_DE_DADO_ID
	,	[FlagStatus] = 1		
	,	[OrdemExibicao] = 0
	,	[Limitador] = 0
	,	[Qualificador] = 0
	,	[CadastroUsuarioId] = GETDATE()
	,	[CadastroDataHora] = 1
	,	[AtualizacaoUsuarioId] = NULL
	,	[AtualizacaoDataHora] = NULL
	;
	SET @TIPO_DE_ATRIBUTO_ID = SCOPE_IDENTITY()
END
GO

IF	NOT EXISTS(SELECT * FROM [dbo].[TipoDeAtributos] WHERE TipoDeAtributoId > 0 AND Nome = 'Endereço')
BEGIN
	DECLARE @TIPO_DE_ATRIBUTO_ID INT = 0;
	DECLARE @TIPO_DE_DADO_ID INT = NULL;
	SELECT
		@TIPO_DE_DADO_ID = TipoDeDadoId
	FROM 
		TipoDeDados 
	WHERE
		TipoDeDadoId > 0 
	AND
		Nome = 'varchar'
	;	
	INSERT [dbo].[TipoDeAtributos]
	(
		[TipoDeAtributoId] 
	,	[Nome] 
	,	[Apelido] 
	,	[Descricao] 
	,	[NomeFisico]
	,	[TipoDeDadoId]
	,	[FlagStatus]
	,	[OrdemExibicao]
	,	[Limitador]
	,	[Qualificador]
	,	[CadastroUsuarioId]
	,	[CadastroDataHora]
	,	[AtualizacaoUsuarioId]
	,	[AtualizacaoDataHora]	
	)
	SELECT
		[TipoDeAtributoId] = 7
	,	[Nome] = 'Nome do País'	
	,	[Apelido] = 'País'
	,	[Descricao] = NULL
	,	[NomeFisico] = 'NOME_PAIS'
	,	[TipoDeDadoId] = @TIPO_DE_DADO_ID
	,	[FlagStatus] = 1		
	,	[OrdemExibicao] = 0
	,	[Limitador] = 0
	,	[Qualificador] = 0
	,	[CadastroUsuarioId] = GETDATE()
	,	[CadastroDataHora] = 1
	,	[AtualizacaoUsuarioId] = NULL
	,	[AtualizacaoDataHora] = NULL
	;
	SET @TIPO_DE_ATRIBUTO_ID = SCOPE_IDENTITY()
END
GO

IF	NOT EXISTS(SELECT * FROM [dbo].[TipoDeAtributos] WHERE TipoDeAtributoId > 0 AND Nome = 'Endereço')
BEGIN
	DECLARE @TIPO_DE_ATRIBUTO_ID INT = 0;
	DECLARE @TIPO_DE_DADO_ID INT = NULL;
	SELECT
		@TIPO_DE_DADO_ID = TipoDeDadoId
	FROM 
		TipoDeDados 
	WHERE
		TipoDeDadoId > 0 
	AND
		Nome = 'varchar'
	;	
	INSERT [dbo].[TipoDeAtributos]
	(
		[TipoDeAtributoId] 
	,	[Nome] 
	,	[Apelido] 
	,	[Descricao] 
	,	[NomeFisico]
	,	[TipoDeDadoId]
	,	[FlagStatus]
	,	[OrdemExibicao]
	,	[Limitador]
	,	[Qualificador]
	,	[CadastroUsuarioId]
	,	[CadastroDataHora]
	,	[AtualizacaoUsuarioId]
	,	[AtualizacaoDataHora]	
	)
	SELECT
		[TipoDeAtributoId] = 8
	,	[Nome] = 'Estado'	
	,	[Apelido] = 'UF'
	,	[Descricao] = NULL
	,	[NomeFisico] = 'NOME_ESTADO'
	,	[TipoDeDadoId] = @TIPO_DE_DADO_ID
	,	[FlagStatus] = 1		
	,	[OrdemExibicao] = 0
	,	[Limitador] = 0
	,	[Qualificador] = 0
	,	[CadastroUsuarioId] = GETDATE()
	,	[CadastroDataHora] = 1
	,	[AtualizacaoUsuarioId] = NULL
	,	[AtualizacaoDataHora] = NULL
	;
	SET @TIPO_DE_ATRIBUTO_ID = SCOPE_IDENTITY()
END
GO

IF	NOT EXISTS(SELECT * FROM [dbo].[TipoDeAtributos] WHERE TipoDeAtributoId > 0 AND Nome = 'Endereço')
BEGIN
	DECLARE @TIPO_DE_ATRIBUTO_ID INT = 0;
	DECLARE @TIPO_DE_DADO_ID INT = NULL;
	SELECT
		@TIPO_DE_DADO_ID = TipoDeDadoId
	FROM 
		TipoDeDados 
	WHERE
		TipoDeDadoId > 0 
	AND
		Nome = 'varchar'
	;	
	INSERT [dbo].[TipoDeAtributos]
	(
		[TipoDeAtributoId] 
	,	[Nome] 
	,	[Apelido] 
	,	[Descricao] 
	,	[NomeFisico]
	,	[TipoDeDadoId]
	,	[FlagStatus]
	,	[OrdemExibicao]
	,	[Limitador]
	,	[Qualificador]
	,	[CadastroUsuarioId]
	,	[CadastroDataHora]
	,	[AtualizacaoUsuarioId]
	,	[AtualizacaoDataHora]	
	)
	SELECT
		[TipoDeAtributoId] = 9
	,	[Nome] = 'Cidade'	
	,	[Apelido] = 'Cidade'
	,	[Descricao] = NULL
	,	[NomeFisico] = 'CIDADE'
	,	[TipoDeDadoId] = @TIPO_DE_DADO_ID  
	,	[FlagStatus] = 1		
	,	[OrdemExibicao] = 0
	,	[Limitador] = 0
	,	[Qualificador] = 0
	,	[CadastroUsuarioId] = GETDATE()
	,	[CadastroDataHora] = 1
	,	[AtualizacaoUsuarioId] = NULL
	,	[AtualizacaoDataHora] = NULL
	;
	SET @TIPO_DE_ATRIBUTO_ID = SCOPE_IDENTITY()
END
GO

IF	NOT EXISTS(SELECT * FROM [dbo].[TipoDeAtributos] WHERE TipoDeAtributoId > 0 AND Nome = 'Amortização do Principal')
BEGIN
	DECLARE @TIPO_DE_ATRIBUTO_ID INT = 0;
	DECLARE @TIPO_DE_DADO_ID INT = NULL;
	SELECT
		@TIPO_DE_DADO_ID = TipoDeDadoId
	FROM 
		TipoDeDados 
	WHERE
		TipoDeDadoId > 0 
	AND
		Nome = 'varchar'
	;	
	INSERT [dbo].[TipoDeAtributos]
	(
		[TipoDeAtributoId] 
	,	[Nome] 
	,	[Apelido] 
	,	[Descricao] 
	,	[NomeFisico]
	,	[TipoDeDadoId]
	,	[FlagStatus]
	,	[OrdemExibicao]
	,	[Limitador]
	,	[Qualificador]
	,	[CadastroUsuarioId]
	,	[CadastroDataHora]
	,	[AtualizacaoUsuarioId]
	,	[AtualizacaoDataHora]	
	)
	SELECT
		[TipoDeAtributoId] = 11
	,	[Nome] = 'Amortização do Principal'	
	,	[Apelido] = 'Amortização do Principal'
	,	[Descricao] 'Lista de peridiocidade (Armazena Peridiocidade + Quantidade de PMTS)'
	,	[NomeFisico] = 'AMORIZACAO_PRINCIPAL'
	,	[TipoDeDadoId] = @TIPO_DE_DADO_ID
	,	[FlagStatus] = 1		
	,	[OrdemExibicao] = 8
	,	[Limitador] = 1
	,	[Qualificador] = 0
	,	[CadastroUsuarioId] = GETDATE()
	,	[CadastroDataHora] = 1
	,	[AtualizacaoUsuarioId] = NULL
	,	[AtualizacaoDataHora] = NULL
	;
	SET @TIPO_DE_ATRIBUTO_ID = SCOPE_IDENTITY()
END
GO

IF	NOT EXISTS(SELECT * FROM [dbo].[TipoDeAtributos] WHERE TipoDeAtributoId > 0 AND Nome = 'ArvoreGarantia')
BEGIN
	DECLARE @TIPO_DE_ATRIBUTO_ID INT = 0;
	DECLARE @TIPO_DE_DADO_ID INT = NULL;
	SELECT
		@TIPO_DE_DADO_ID = TipoDeDadoId
	FROM 
		TipoDeDados 
	WHERE
		TipoDeDadoId > 0 
	AND
		Nome = 'int'
	;	
	INSERT [dbo].[TipoDeAtributos]
	(
		[TipoDeAtributoId] 
	,	[Nome] 
	,	[Apelido] 
	,	[Descricao] 
	,	[NomeFisico]
	,	[TipoDeDadoId]
	,	[FlagStatus]
	,	[OrdemExibicao]
	,	[Limitador]
	,	[Qualificador]
	,	[CadastroUsuarioId]
	,	[CadastroDataHora]
	,	[AtualizacaoUsuarioId]
	,	[AtualizacaoDataHora]	
	)
	SELECT
		[TipoAtributoId] = 2000
	,	[Nome] = 'ArvoreGarantia'	
	,	[Descricao] 'ARVORE DE GARANTIAS'
	,	[NomeFisico] = 'ARVORE_GARANTIA'
	,	[TipoDeDadoId] = @TIPO_DE_DADO_ID
	,	[FlagStatus] = 1		
	,	[OrdemExibicao] = 0
	,	[Limitador] = 1
	,	[Qualificador] = 0
	,	[CadastroUsuarioId] = GETDATE()
	,	[CadastroDataHora] = 1
	,	[AtualizacaoUsuarioId] = NULL
	,	[AtualizacaoDataHora] = NULL
	;
	SET @TIPO_DE_ATRIBUTO_ID = SCOPE_IDENTITY()
END
GO

IF	NOT EXISTS(SELECT * FROM [dbo].[TipoDeAtributos] WHERE TipoDeAtributoId > 0 AND Nome = 'ArvoreNostroAccount')
BEGIN
	DECLARE @TIPO_DE_ATRIBUTO_ID INT = 0;
	DECLARE @TIPO_DE_DADO_ID INT = NULL;
	SELECT
		@TIPO_DE_DADO_ID = TipoDeDadoId
	FROM 
		TipoDeDados 
	WHERE
		TipoDeDadoId > 0 
	AND
		Nome = 'int'
	;	
	INSERT [dbo].[TipoDeAtributos]
	(
		[TipoDeAtributoId] 
	,	[Nome] 
	,	[Apelido] 
	,	[Descricao] 
	,	[NomeFisico]
	,	[TipoDeDadoId]
	,	[FlagStatus]
	,	[OrdemExibicao]
	,	[Limitador]
	,	[Qualificador]
	,	[CadastroUsuarioId]
	,	[CadastroDataHora]
	,	[AtualizacaoUsuarioId]
	,	[AtualizacaoDataHora]	
	)
	SELECT
		[TipoDeAtributoId] = 4000
	,	[Nome] = 'ArvoreNostroAccount'	
	,	[Descricao] 'ARVORE DE Notro Account'
	,	[NomeFisico] = 'ARVORE_NOSTRO_ACCOUNT'
	,	[TipoDeDadoId] = @TIPO_DE_DADO_ID	
	,	[FlagStatus] = 1		
	,	[OrdemExibicao] = 0
	,	[Limitador] = 1
	,	[Qualificador] = 0
	,	[CadastroUsuarioId] = GETDATE()
	,	[CadastroDataHora] = 1
	,	[AtualizacaoUsuarioId] = NULL
	,	[AtualizacaoDataHora] = NULL
	;
	SET @TIPO_DE_ATRIBUTO_ID = SCOPE_IDENTITY()
END
GO

IF	NOT EXISTS(SELECT * FROM [dbo].[TipoDeAtributos] WHERE TipoDeAtributoId > 0 AND Nome = 'ArvoreSettlement')
BEGIN
	DECLARE @TIPO_DE_ATRIBUTO_ID INT = 0;
	DECLARE @TIPO_DE_DADO_ID INT = NULL;
	SELECT
		@TIPO_DE_DADO_ID = TipoDeDadoId
	FROM 
		TipoDeDados 
	WHERE
		TipoDeDadoId > 0 
	AND
		Nome = 'int'
	;	
	INSERT [dbo].[TipoDeAtributos]
	(
		[TipoDeAtributoId] 
	,	[Nome] 
	,	[Apelido] 
	,	[Descricao] 
	,	[NomeFisico]
	,	[TipoDeDadoId]
	,	[FlagStatus]
	,	[OrdemExibicao]
	,	[Limitador]
	,	[Qualificador]
	,	[CadastroUsuarioId]
	,	[CadastroDataHora]
	,	[AtualizacaoUsuarioId]
	,	[AtualizacaoDataHora]	
	)
	SELECT
		[TipoDeAtributoId] = 3000
	,	[Nome] = 'ArvoreSettlement'	
	,	[Descricao] 'ARVORE DE Settlement'
	,	[NomeFisico] = 'ARVORE_SETTLEMENT'
	,	[TipoDeDadoId] = @TIPO_DE_DADO_ID
	,	[FlagStatus] = 1		
	,	[OrdemExibicao] = 0
	,	[Limitador] = 1
	,	[Qualificador] = 0
	,	[CadastroUsuarioId] = GETDATE()
	,	[CadastroDataHora] = 1
	,	[AtualizacaoUsuarioId] = NULL
	,	[AtualizacaoDataHora] = NULL
	;
	SET @TIPO_DE_ATRIBUTO_ID = SCOPE_IDENTITY()
END
GO

IF	NOT EXISTS(SELECT * FROM [dbo].[TipoDeAtributos] WHERE TipoDeAtributoId > 0 AND Nome = 'Banco')
BEGIN
	DECLARE @TIPO_DE_ATRIBUTO_ID INT = 0;
	DECLARE @TIPO_DE_DADO_ID INT = NULL;
	SELECT
		@TIPO_DE_DADO_ID = TipoDeDadoId
	FROM 
		TipoDeDados 
	WHERE
		TipoDeDadoId > 0 
	AND
		Nome = 'int'
	;	
	INSERT [dbo].[TipoDeAtributos]
	(
		[TipoDeAtributoId] 
	,	[Nome] 
	,	[Apelido] 
	,	[Descricao] 
	,	[NomeFisico]
	,	[TipoDeDadoId]
	,	[FlagStatus]
	,	[OrdemExibicao]
	,	[Limitador]
	,	[Qualificador]
	,	[CadastroUsuarioId]
	,	[CadastroDataHora]
	,	[AtualizacaoUsuarioId]
	,	[AtualizacaoDataHora]	
	)
	SELECT
		[TipoDeAtributoId] = 21
	,	[Nome] = 'Banco'	
	,	[Descricao] 'Banco'
	,	[NomeFisico] = 'BANCO'
	,	[TipoDeDadoId] = @TIPO_DE_DADO_ID
	,	[FlagStatus] = 1		
	,	[OrdemExibicao] = 1
	,	[Limitador] = 1
	,	[Qualificador] = 0
	,	[CadastroUsuarioId] = GETDATE()
	,	[CadastroDataHora] = 1
	,	[AtualizacaoUsuarioId] = NULL
	,	[AtualizacaoDataHora] = NULL
	;
	SET @TIPO_DE_ATRIBUTO_ID = SCOPE_IDENTITY()
	;
END
GO

IF	NOT EXISTS(SELECT * FROM [dbo].[TipoDeAtributos] WHERE TipoDeAtributoId > 0 AND Nome = '')
BEGIN
	DECLARE @TIPO_DE_ATRIBUTO_ID INT = 0;
	DECLARE @TIPO_DE_DADO_ID INT = NULL;
	SELECT
		@TIPO_DE_DADO_ID = TipoDeDadoId
	FROM 
		TipoDeDados 
	WHERE
		TipoDeDadoId > 0 
	AND
		Nome = 'int'
	;	
	INSERT [dbo].[TipoDeAtributos]
	(
		[TipoDeAtributoId] 
	,	[Nome] 
	,	[Apelido] 
	,	[Descricao] 
	,	[NomeFisico]
	,	[TipoDeDadoId]
	,	[FlagStatus]
	,	[OrdemExibicao]
	,	[Limitador]
	,	[Qualificador]
	,	[CadastroUsuarioId]
	,	[CadastroDataHora]
	,	[AtualizacaoUsuarioId]
	,	[AtualizacaoDataHora]	
	)
	SELECT
		[TipoDeAtributoId] = 19
	,	[Nome] = 'Carência'	
	,	[Descricao] 'Quantidade de dias'
	,	[NomeFisico] = 'CARENCIA'
	,	[TipoDeDadoId] = @TIPO_DE_DADO_ID
	,	[FlagStatus] = 1		
	,	[OrdemExibicao] = 6
	,	[Limitador] = 1
	,	[Qualificador] = 0
	,	[CadastroUsuarioId] = GETDATE()
	,	[CadastroDataHora] = 1
	,	[AtualizacaoUsuarioId] = NULL
	,	[AtualizacaoDataHora] = NULL
	;
	SET @TIPO_DE_ATRIBUTO_ID = SCOPE_IDENTITY()
	;
END
GO

IF	NOT EXISTS(SELECT * FROM [dbo].[TiposAtributos] WHERE TipoAtributoId > 0 AND Nome = '')
BEGIN
	DECLARE @TIPO_DE_ATRIBUTO_ID INT = 0;
	DECLARE @TIPO_DE_DADO_ID INT = NULL;
	SELECT
		@TIPO_DE_DADO_ID = TipoDeDadoId
	FROM 
		TipoDeDados 
	WHERE
		TipoDeDadoId > 0 
	AND
		Nome = 'varchar'
	;	
	INSERT [dbo].[TiposAtributos]
	(
		[TipoDeAtributoId] 
	,	[Nome] 
	,	[Apelido] 
	,	[Descricao] 
	,	[NomeFisico]
	,	[TipoDeDadoId]
	,	[FlagStatus]
	,	[OrdemExibicao]
	,	[Limitador]
	,	[Qualificador]
	,	[CadastroUsuarioId]
	,	[CadastroDataHora]
	,	[AtualizacaoUsuarioId]
	,	[AtualizacaoDataHora]	
	)
	SELECT
		[TipoDeAtributoId] = 14
	,	[Nome] = 'Condições de Crédito'	
	,	[Apelido] = 'Condições de Crédito'
	,	[Descricao] 'Campo texto até 3000 caracteres'
	,	[NomeFisico] = 'CONDICOES_CREDITO'
	,	[TipoDeDadoId] = @TIPO_DE_DADO_ID
	,	[FlagStatus] = 1		
	,	[OrdemExibicao] = 12
	,	[Limitador] = 1
	,	[Qualificador] = 0
	,	[CadastroUsuarioId] = GETDATE()
	,	[CadastroDataHora] = 1
	,	[AtualizacaoUsuarioId] = NULL
	,	[AtualizacaoDataHora] = NULL
	;
	SET @TIPO_DE_ATRIBUTO_ID = SCOPE_IDENTITY()
	;
END
GO

IF	NOT EXISTS(SELECT * FROM [dbo].[TiposAtributos] WHERE TipoAtributoId > 0 AND Nome = '')
BEGIN
	DECLARE @TIPO_DE_ATRIBUTO_ID INT = 0;
	DECLARE @TIPO_DE_DADO_ID INT = NULL;
	SELECT
		@TIPO_DE_DADO_ID = TipoDeDadoId
	FROM 
		TipoDeDados 
	WHERE
		TipoDeDadoId > 0 
	AND
		Nome = 'int'
	;	
	INSERT [dbo].[TiposAtributos]
	(
		[TipoDeAtributoId] 
	,	[Nome] 
	,	[Apelido] 
	,	[Descricao] 
	,	[NomeFisico]
	,	[TipoDeDadoId]
	,	[FlagStatus]
	,	[OrdemExibicao]
	,	[Limitador]
	,	[Qualificador]
	,	[CadastroUsuarioId]
	,	[CadastroDataHora]
	,	[AtualizacaoUsuarioId]
	,	[AtualizacaoDataHora]	
	)
	SELECT
		[TipoAtributoId] = 1
	,	[Nome] = 'Credito'	
	,	[Descricao] 'Credito'
	,	[TipoDadoId] = @TIPO_DE_DADO_ID
	,	[FlagStatus] = 1		
	,	[OrdemExibicao] = 0
	,	[Limitador] = 1
	,	[Qualificador] = 0
	,	[CadastroUsuarioId] = GETDATE()
	,	[CadastroDataHora] = 1
	,	[AtualizacaoUsuarioId] = NULL
	,	[AtualizacaoDataHora] = NULL
	;
	SET @TIPO_DE_ATRIBUTO_ID = SCOPE_IDENTITY()
	;
END
GO

IF	NOT EXISTS(SELECT * FROM [dbo].[TiposAtributos] WHERE TipoAtributoId > 0 AND Nome = '')
BEGIN
	DECLARE @TIPO_DE_ATRIBUTO_ID INT = 0;
	DECLARE @TIPO_DE_DADO_ID INT = NULL;
	SELECT
		@TIPO_DE_DADO_ID = TipoDeDadoId
	FROM 
		TipoDeDados 
	WHERE
		TipoDeDadoId > 0 
	AND
		Nome = 'varchar'
	;	
	INSERT [dbo].[TiposAtributos]
	(
		[TipoDeAtributoId] 
	,	[Nome] 
	,	[Apelido] 
	,	[Descricao] 
	,	[NomeFisico]
	,	[TipoDeDadoId]
	,	[FlagStatus]
	,	[OrdemExibicao]
	,	[Limitador]
	,	[Qualificador]
	,	[CadastroUsuarioId]
	,	[CadastroDataHora]
	,	[AtualizacaoUsuarioId]
	,	[AtualizacaoDataHora]	
	)
	SELECT
		[TipoDeAtributoId] = 15
	,	[Nome] = 'Destaque de Garantias'	
	,	[Apelido] = 'Destaque de Garantias'
	,	[Descricao] 'Campo texto até 3000 caracteres'
	,	[NomeFisico] = 'DESTAQUE_GARANTIAS'
	,	[TipoDeDadoId] = @TIPO_DE_DADO_ID
	,	[FlagStatus] = 1
	,	[OrdemExibicao] = 13
	,	[Limitador] = 1
	,	[Qualificador] = 0
	,	[CadastroUsuarioId] = GETDATE()
	,	[CadastroDataHora] = 1
	,	[AtualizacaoUsuarioId] = NULL
	,	[AtualizacaoDataHora] = NULL
	;
	SET @TIPO_DE_ATRIBUTO_ID = SCOPE_IDENTITY()
	;
END
GO

IF	NOT EXISTS(SELECT * FROM [dbo].[TiposAtributos] WHERE TipoAtributoId > 0 AND Nome = '')
BEGIN
	DECLARE @TIPO_DE_ATRIBUTO_ID INT = 0;
	DECLARE @TIPO_DE_DADO_ID INT = NULL;
	SELECT
		@TIPO_DE_DADO_ID = TipoDeDadoId
	FROM 
		TipoDeDados 
	WHERE
		TipoDeDadoId > 0 
	AND
		Nome = 'varchar'
	;	
	INSERT [dbo].[TiposAtributos]
	(
		[TipoDeAtributoId] 
	,	[Nome] 
	,	[Apelido] 
	,	[Descricao] 
	,	[NomeFisico]
	,	[TipoDeDadoId]
	,	[FlagStatus]
	,	[OrdemExibicao]
	,	[Limitador]
	,	[Qualificador]
	,	[CadastroUsuarioId]
	,	[CadastroDataHora]
	,	[AtualizacaoUsuarioId]
	,	[AtualizacaoDataHora]	
	)
	SELECT
		[TipoDeAtributoId] = 16
	,	[Nome] = 'Destaque de Liberação de Risco'
	,	[Apelido] = 'Destaque de Liberação de Risco'	
	,	[Descricao] 'Campo texto até 3000 caracteres'
	,	[NomeFisico] = 'DESTAQUE_LIBERACAO_RISCO'
	,	[TipoDeDadoId] = @TIPO_DE_DADO_ID
	,	[FlagStatus] = 1
	,	[OrdemExibicao] = 14
	,	[Limitador] = 1
	,	[Qualificador] = 0
	,	[CadastroUsuarioId] = GETDATE()
	,	[CadastroDataHora] = 1
	,	[AtualizacaoUsuarioId] = NULL
	,	[AtualizacaoDataHora] = NULL
	;
	SET @TIPO_DE_ATRIBUTO_ID = SCOPE_IDENTITY()
	;
END
GO

IF	NOT EXISTS(SELECT * FROM [dbo].[TiposAtributos] WHERE TipoAtributoId > 0 AND Nome = '')
BEGIN
	DECLARE @TIPO_DE_ATRIBUTO_ID INT = 0;
	DECLARE @TIPO_DE_DADO_ID INT = NULL;
	SELECT
		@TIPO_DE_DADO_ID = TipoDeDadoId
	FROM 
		TipoDeDados 
	WHERE
		TipoDeDadoId > 0 
	AND
		Nome = 'int'
	;	
	INSERT [dbo].[TiposAtributos]
	(
		[TipoDeAtributoId] 
	,	[Nome] 
	,	[Apelido] 
	,	[Descricao] 
	,	[NomeFisico]
	,	[TipoDeDadoId]
	,	[FlagStatus]
	,	[OrdemExibicao]
	,	[Limitador]
	,	[Qualificador]
	,	[CadastroUsuarioId]
	,	[CadastroDataHora]
	,	[AtualizacaoUsuarioId]
	,	[AtualizacaoDataHora]	
	)
	SELECT
		[TipoDeAtributoId] = 4
	,	[Nome] = 'Empresa'	
	,	[Apelido] = 'Empresa'
	,	[Descricao] 'Empresa'
	,	[NomeFisico] = 'EMPRESAS'
	,	[TipoDeDadoId] = @TIPO_DE_DADO_ID
	,	[FlagStatus] = 1
	,	[OrdemExibicao] = 1
	,	[Limitador] = 1
	,	[Qualificador] = 0
	,	[CadastroUsuarioId] = GETDATE()
	,	[CadastroDataHora] = 1
	,	[AtualizacaoUsuarioId] = NULL
	,	[AtualizacaoDataHora] = NULL
	;
	SET @TIPO_DE_ATRIBUTO_ID = SCOPE_IDENTITY()
	;
END
GO

IF	NOT EXISTS(SELECT * FROM [dbo].[TiposAtributos] WHERE TipoAtributoId > 0 AND Nome = '')
BEGIN
	DECLARE @TIPO_DE_ATRIBUTO_ID INT = 0;
	DECLARE @TIPO_DE_DADO_ID INT = NULL;
	SELECT
		@TIPO_DE_DADO_ID = TipoDeDadoId
	FROM 
		TipoDeDados 
	WHERE
		TipoDeDadoId > 0 
	AND
		Nome = 'object'
	;	
	INSERT [dbo].[TiposAtributos]
	(
		[TipoDeAtributoId] 
	,	[Nome] 
	,	[Apelido] 
	,	[Descricao] 
	,	[NomeFisico]
	,	[TipoDeDadoId]
	,	[FlagStatus]
	,	[OrdemExibicao]
	,	[Limitador]
	,	[Qualificador]
	,	[CadastroUsuarioId]
	,	[CadastroDataHora]
	,	[AtualizacaoUsuarioId]
	,	[AtualizacaoDataHora]	
	)
	SELECT
		[TipoDeAtributoId] = 7
	,	[Nome] = 'Garantia'	
	,	[Apelido] = 'Garantia'
	,	[Descricao] 'Garantia'
	,	[NomeFisico] = 'GARANTIA'
	,	[TipoDeDadoId] = @TIPO_DE_DADO_ID
	,	[FlagStatus] = 1
	,	[OrdemExibicao] = 10
	,	[Limitador] = 1
	,	[Qualificador] = 0
	,	[CadastroUsuarioId] = GETDATE()
	,	[CadastroDataHora] = 1
	,	[AtualizacaoUsuarioId] = NULL
	,	[AtualizacaoDataHora] = NULL
	;
	SET @TIPO_DE_ATRIBUTO_ID = SCOPE_IDENTITY()
	;
END
GO

IF	NOT EXISTS(SELECT * FROM [dbo].[TiposAtributos] WHERE TipoAtributoId > 0 AND Nome = '')
BEGIN
	DECLARE @TIPO_DE_ATRIBUTO_ID INT = 0;
	DECLARE @TIPO_DE_DADO_ID INT = NULL;
	SELECT
		@TIPO_DE_DADO_ID = TipoDeDadoId
	FROM 
		TipoDeDados 
	WHERE
		TipoDeDadoId > 0 
	AND
		Nome = 'int'
	;	
	INSERT [dbo].[TiposAtributos]
	(
		[TipoDeAtributoId] 
	,	[Nome] 
	,	[Apelido] 
	,	[Descricao] 
	,	[NomeFisico]
	,	[TipoDeDadoId]
	,	[FlagStatus]
	,	[OrdemExibicao]
	,	[Limitador]
	,	[Qualificador]
	,	[CadastroUsuarioId]
	,	[CadastroDataHora]
	,	[AtualizacaoUsuarioId]
	,	[AtualizacaoDataHora]	
	)
	SELECT
		[TipoDeAtributoId] = 3
	,	[Nome] = 'Grupo Econômico'	
	,	[Apelido] = 'Grupo Econômico'
	,	[Descricao] 'GrupoEconomico'
	,	[NomeFisico] = 'GRUPO_ECONOMICO'
	,	[TipoDadoId] = @TIPO_DE_DADO_ID
	,	[FlagStatus] = 1
	,	[OrdemExibicao] = 1
	,	[Limitador] = 1
	,	[Qualificador] = 0
	,	[CadastroUsuarioId] = GETDATE()
	,	[CadastroDataHora] = 1
	,	[AtualizacaoUsuarioId] = NULL
	,	[AtualizacaoDataHora] = NULL
	;
	SET @TIPO_DE_ATRIBUTO_ID = SCOPE_IDENTITY()
	;
END
GO

IF	NOT EXISTS(SELECT * FROM [dbo].[TiposAtributos] WHERE TipoAtributoId > 0 AND Nome = '')
BEGIN
	DECLARE @TIPO_DE_ATRIBUTO_ID INT = 0;
	DECLARE @TIPO_DE_DADO_ID INT = NULL;
	SELECT
		@TIPO_DE_DADO_ID = TipoDeDadoId
	FROM 
		TipoDeDados 
	WHERE
		TipoDeDadoId > 0 
	AND
		Nome = 'numeric'
	;	
	INSERT [dbo].[TiposAtributos]
	(
		[TipoDeAtributoId] 
	,	[Nome] 
	,	[Apelido] 
	,	[Descricao] 
	,	[NomeFisico]
	,	[TipoDeDadoId]
	,	[FlagStatus]
	,	[OrdemExibicao]
	,	[Limitador]
	,	[Qualificador]
	,	[CadastroUsuarioId]
	,	[CadastroDataHora]
	,	[AtualizacaoUsuarioId]
	,	[AtualizacaoDataHora]	
	)
	SELECT
		[TipoDeAtributoId] = 18
	,	[Nome] = 'Limite Clean'	
	,	[Descricao] 'Limite clean'
	,	[TipoDeDadoId] = @TIPO_DE_DADO_ID
	,	[FlagStatus] = 1
	,	[OrdemExibicao] = 2
	,	[Limitador] = 1
	,	[Qualificador] = 0
	;
	SET @TIPO_DE_ATRIBUTO_ID = SCOPE_IDENTITY()
	;
END
GO

IF	NOT EXISTS(SELECT * FROM [dbo].[TiposAtributos] WHERE TipoAtributoId > 0 AND Nome = '')
BEGIN
	DECLARE @TIPO_DE_ATRIBUTO_ID INT = 0;
	DECLARE @TIPO_DE_DADO_ID INT = NULL;
	SELECT
		@TIPO_DE_DADO_ID = TipoDeDadoId
	FROM 
		TipoDeDados 
	WHERE
		TipoDeDadoId > 0 
	AND
		Nome = 'bit'
	;	
	INSERT [dbo].[TiposAtributos]
	(
		[TipoDeAtributoId] 
	,	[Nome] 
	,	[Apelido] 
	,	[Descricao] 
	,	[NomeFisico]
	,	[TipoDeDadoId]
	,	[FlagStatus]
	,	[OrdemExibicao]
	,	[Limitador]
	,	[Qualificador]
	,	[CadastroUsuarioId]
	,	[CadastroDataHora]
	,	[AtualizacaoUsuarioId]
	,	[AtualizacaoDataHora]	
	)
	SELECT
		[TipoAtributoId] = 17
	,	[Nome] = 'Operação Renegociada'	
	,	[Descricao] 'bit botao radio (sim/nao)'
	,	[TipoDadoId] = @TIPO_DE_DADO_ID
	,	[FlagStatus] = 1
	,	[OrdemExibicao] = 4
	,	[Limitador] = 1
	,	[Qualificador] = 0
	;
	SET @TIPO_DE_ATRIBUTO_ID = SCOPE_IDENTITY()
	;
END
GO

IF	NOT EXISTS(SELECT * FROM [dbo].[TiposAtributos] WHERE TipoAtributoId > 0 AND Nome = '')
BEGIN
	DECLARE @TIPO_DE_ATRIBUTO_ID INT = 0;
	DECLARE @TIPO_DE_DADO_ID INT = NULL;
	SELECT
		@TIPO_DE_DADO_ID = TipoDeDadoId
	FROM 
		TipoDeDados 
	WHERE
		TipoDeDadoId > 0 
	AND
		Nome = 'varchar'
	;	
	INSERT [dbo].[TiposAtributos]
	(
		[TipoDeAtributoId] 
	,	[Nome] 
	,	[Apelido] 
	,	[Descricao] 
	,	[NomeFisico]
	,	[TipoDeDadoId]
	,	[FlagStatus]
	,	[OrdemExibicao]
	,	[Limitador]
	,	[Qualificador]
	,	[CadastroUsuarioId]
	,	[CadastroDataHora]
	,	[AtualizacaoUsuarioId]
	,	[AtualizacaoDataHora]	
	)
	SELECT
		[TipoAtributoId] = 10
	,	[Nome] = 'Pagamento de Encargos'	
	,	[Descricao] 'lista de peridiocidade(armazena id_peridiocidade + qtd de pmts)'
	,	[TipoDadoId] = @TIPO_DE_DADO_ID
	,	[FlagStatus] = 1
	,	[OrdemExibicao] =  7
	,	[Limitador] = 1
	,	[Qualificador] = 0
	;
	SET @TIPO_DE_ATRIBUTO_ID = SCOPE_IDENTITY()
	;
END
GO

IF	NOT EXISTS(SELECT * FROM [dbo].[TiposAtributos] WHERE TipoAtributoId > 0 AND Nome = '')
BEGIN
	DECLARE @TIPO_DE_ATRIBUTO_ID INT = 0;
	DECLARE @TIPO_DE_DADO_ID INT = NULL;
	SELECT
		@TIPO_DE_DADO_ID = TipoDeDadoId
	FROM 
		TipoDeDados 
	WHERE
		TipoDeDadoId > 0 
	AND
		Nome = 'varchar'
	;	
	INSERT [dbo].[TiposAtributos]
	(
		[TipoDeAtributoId] 
	,	[Nome] 
	,	[Apelido] 
	,	[Descricao] 
	,	[NomeFisico]
	,	[TipoDeDadoId]
	,	[FlagStatus]
	,	[OrdemExibicao]
	,	[Limitador]
	,	[Qualificador]
	,	[CadastroUsuarioId]
	,	[CadastroDataHora]
	,	[AtualizacaoUsuarioId]
	,	[AtualizacaoDataHora]	
	)
	SELECT
		[TipoAtributoId] = 13
	,	[Nome] = 'Parecer do Limite'	
	,	[Descricao] 'Campo texto até 3000 caracteres'
	,	[TipoDadoId] = @TIPO_DE_DADO_ID
	,	[FlagStatus] = 1
	,	[OrdemExibicao] =  11
	,	[Limitador] = 1
	,	[Qualificador] = 0
	;
	SET @TIPO_DE_ATRIBUTO_ID = SCOPE_IDENTITY()
	;
END
GO

IF	NOT EXISTS(SELECT * FROM [dbo].[TiposAtributos] WHERE TipoAtributoId > 0 AND Nome = '')
BEGIN
	DECLARE @TIPO_DE_ATRIBUTO_ID INT = 0;
	DECLARE @TIPO_DE_DADO_ID INT = NULL;
	SELECT
		@TIPO_DE_DADO_ID = TipoDeDadoId
	FROM 
		TipoDeDados 
	WHERE
		TipoDeDadoId > 0 
	AND
		Nome = 'int'
	;	
	INSERT [dbo].[TiposAtributos]
	(
	(
		[TipoDeAtributoId] 
	,	[Nome] 
	,	[Apelido] 
	,	[Descricao] 
	,	[NomeFisico]
	,	[TipoDeDadoId]
	,	[FlagStatus]
	,	[OrdemExibicao]
	,	[Limitador]
	,	[Qualificador]
	,	[CadastroUsuarioId]
	,	[CadastroDataHora]
	,	[AtualizacaoUsuarioId]
	,	[AtualizacaoDataHora]	
	)
	SELECT
		[TipoAtributoId] = 6
	,	[Nome] = 'Prazo'	
	,	[Descricao] 'Prazo'
	,	[TipoDadoId] = @TIPO_DE_DADO_ID
	,	[FlagStatus] = 1
	,	[OrdemExibicao] =  5
	,	[Limitador] = 1
	,	[Qualificador] = 0
	;
	SET @TIPO_DE_ATRIBUTO_ID = SCOPE_IDENTITY()
	;
END
GO

IF	NOT EXISTS(SELECT * FROM [dbo].[TiposAtributos] WHERE TipoAtributoId > 0 AND Nome = '')
BEGIN
	DECLARE @TIPO_DE_ATRIBUTO_ID INT = 0;
	DECLARE @TIPO_DE_DADO_ID INT = NULL;
	SELECT
		@TIPO_DE_DADO_ID = TipoDeDadoId
	FROM 
		TipoDeDados 
	WHERE
		TipoDeDadoId > 0 
	AND
		Nome = 'int'
	;	
	INSERT [dbo].[TiposAtributos]
	(
		[TipoDeAtributoId] 
	,	[Nome] 
	,	[Apelido] 
	,	[Descricao] 
	,	[NomeFisico]
	,	[TipoDeDadoId]
	,	[FlagStatus]
	,	[OrdemExibicao]
	,	[Limitador]
	,	[Qualificador]
	,	[CadastroUsuarioId]
	,	[CadastroDataHora]
	,	[AtualizacaoUsuarioId]
	,	[AtualizacaoDataHora]	
	)
	SELECT
		[TipoAtributoId] = 8
	,	[Nome] = 'Produto'	
	,	[Descricao] 'Produto'
	,	[TipoDadoId] = @TIPO_DE_DADO_ID
	,	[FlagStatus] = 1
	,	[OrdemExibicao] =  3
	,	[Limitador] = 1
	,	[Qualificador] = 0
	;
	SET @TIPO_DE_ATRIBUTO_ID = SCOPE_IDENTITY()
	;
END
GO

IF	NOT EXISTS(SELECT * FROM [dbo].[TiposAtributos] WHERE TipoAtributoId > 0 AND Nome = '')
BEGIN
	DECLARE @TIPO_DE_ATRIBUTO_ID INT = 0;
	DECLARE @TIPO_DE_DADO_ID INT = NULL;
	SELECT
		@TIPO_DE_DADO_ID = TipoDeDadoId
	FROM 
		TipoDeDados 
	WHERE
		TipoDeDadoId > 0 
	AND
		Nome = 'varchar'
	;	
	INSERT [dbo].[TiposAtributos]
	(
		[TipoDeAtributoId] 
	,	[Nome] 
	,	[Apelido] 
	,	[Descricao] 
	,	[NomeFisico]
	,	[TipoDeDadoId]
	,	[FlagStatus]
	,	[OrdemExibicao]
	,	[Limitador]
	,	[Qualificador]
	,	[CadastroUsuarioId]
	,	[CadastroDataHora]
	,	[AtualizacaoUsuarioId]
	,	[AtualizacaoDataHora]	
	)
	SELECT
		[TipoAtributoId] = 5
	,	[Nome] = '	Produto'	
	,	[Descricao] 'ProdutoLegado'
	,	[TipoDadoId] = @TIPO_DE_DADO_ID
	,	[FlagStatus] = 0
	,	[OrdemExibicao] =  3
	,	[Limitador] = 1
	,	[Qualificador] = 0
	;
	SET @TIPO_DE_ATRIBUTO_ID = SCOPE_IDENTITY()
	;
END
GO

IF	NOT EXISTS(SELECT * FROM [dbo].[TiposAtributos] WHERE TipoAtributoId > 0 AND Nome = '')
BEGIN
	DECLARE @TIPO_DE_ATRIBUTO_ID INT = 0;
	DECLARE @TIPO_DE_DADO_ID INT = NULL;
	SELECT
		@TIPO_DE_DADO_ID = TipoDeDadoId
	FROM 
		TipoDeDados 
	WHERE
		TipoDeDadoId > 0 
	AND
		Nome = 'numeric'
	;	
	INSERT [dbo].[TiposAtributos]
	(
		[TipoDeAtributoId] 
	,	[Nome] 
	,	[Apelido] 
	,	[Descricao] 
	,	[NomeFisico]
	,	[TipoDeDadoId]
	,	[FlagStatus]
	,	[OrdemExibicao]
	,	[Limitador]
	,	[Qualificador]
	,	[CadastroUsuarioId]
	,	[CadastroDataHora]
	,	[AtualizacaoUsuarioId]
	,	[AtualizacaoDataHora]	
	)
	SELECT
		[TipoAtributoId] = 19
	,	[Nome] = 'Valor'	
	,	[Descricao] 'Valor'
	,	[TipoDadoId] = @TIPO_DE_DADO_ID
	,	[FlagStatus] = 1
	,	[OrdemExibicao] =  4
	,	[Limitador] = 1
	,	[Qualificador] = 0
	;
	SET @TIPO_DE_ATRIBUTO_ID = SCOPE_IDENTITY()
	;
END
GO