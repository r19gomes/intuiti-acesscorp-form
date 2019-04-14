SET IDENTITY_INSERT TipoDeAtributos ON --Desabilita o IDENTITY
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
	,	[Descricao] = 'Endereço'
	,	[NomeFisico] = 'ENDERECO'
	,	[TipoDeDadoId] = @TIPO_DE_DADO_ID  
	,	[FlagStatus] = 1		
	,	[OrdemExibicao] = 0
	,	[Limitador] = 0
	,	[Qualificador] = 0
	,	[CadastroUsuarioId] = 1
	,	[CadastroDataHora] = GETDATE()
	,	[AtualizacaoUsuarioId] = NULL
	,	[AtualizacaoDataHora] = NULL
	;
	SET @TIPO_DE_ATRIBUTO_ID = SCOPE_IDENTITY()
END
GO

IF	NOT EXISTS(SELECT * FROM [dbo].[TipoDeAtributos] WHERE TipoDeAtributoId > 0 AND Nome = 'Complemento')
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
	,	[Descricao] = 'Complemento'
	,	[NomeFisico] = 'COMPLEMENTO'
	,	[TipoDeDadoId] = @TIPO_DE_DADO_ID  
	,	[FlagStatus] = 1		
	,	[OrdemExibicao] = 0
	,	[Limitador] = 0
	,	[Qualificador] = 0
	,	[CadastroUsuarioId] = 1
	,	[CadastroDataHora] = GETDATE()
	,	[AtualizacaoUsuarioId] = NULL
	,	[AtualizacaoDataHora] = NULL
	;
	SET @TIPO_DE_ATRIBUTO_ID = SCOPE_IDENTITY()
END
GO

IF	NOT EXISTS(SELECT * FROM [dbo].[TipoDeAtributos] WHERE TipoDeAtributoId > 0 AND Nome = 'Bairro')
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
	,	[Descricao] = 'Bairro'
	,	[NomeFisico] = 'BAIRRO'
	,	[TipoDeDadoId] = @TIPO_DE_DADO_ID
	,	[FlagStatus] = 1		
	,	[OrdemExibicao] = 0
	,	[Limitador] = 0
	,	[Qualificador] = 0
	,	[CadastroUsuarioId] = 1
	,	[CadastroDataHora] = GETDATE()
	,	[AtualizacaoUsuarioId] = NULL
	,	[AtualizacaoDataHora] = NULL
	;
	SET @TIPO_DE_ATRIBUTO_ID = SCOPE_IDENTITY()
END
GO

IF	NOT EXISTS(SELECT * FROM [dbo].[TipoDeAtributos] WHERE TipoDeAtributoId > 0 AND Nome = 'Cep')
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
	,	[Descricao] = 'Cep'
	,	[NomeFisico] = 'CEP'
	,	[TipoDeDadoId] = @TIPO_DE_DADO_ID
	,	[FlagStatus] = 1		
	,	[OrdemExibicao] = 0
	,	[Limitador] = 0
	,	[Qualificador] = 0
	,	[CadastroUsuarioId] = 1
	,	[CadastroDataHora] = GETDATE()
	,	[AtualizacaoUsuarioId] = NULL
	,	[AtualizacaoDataHora] = NULL
	;
	SET @TIPO_DE_ATRIBUTO_ID = SCOPE_IDENTITY()
END
GO

IF	NOT EXISTS(SELECT * FROM [dbo].[TipoDeAtributos] WHERE TipoDeAtributoId > 0 AND Nome = 'Cep Complemento')
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
	,	[Descricao] = 'Cep Complemento'
	,	[NomeFisico] = 'CEP_COMPLEMENTO'
	,	[TipoDeDadoId] = @TIPO_DE_DADO_ID
	,	[FlagStatus] = 1		
	,	[OrdemExibicao] = 0
	,	[Limitador] = 0
	,	[Qualificador] = 0
	,	[CadastroUsuarioId] = 1
	,	[CadastroDataHora] = GETDATE()
	,	[AtualizacaoUsuarioId] = NULL
	,	[AtualizacaoDataHora] = NULL
	;
	SET @TIPO_DE_ATRIBUTO_ID = SCOPE_IDENTITY()
END
GO

IF	NOT EXISTS(SELECT * FROM [dbo].[TipoDeAtributos] WHERE TipoDeAtributoId > 0 AND Nome = 'Nome do País')
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
	,	[Descricao] = 'Nome do País'
	,	[NomeFisico] = 'NOME_PAIS'
	,	[TipoDeDadoId] = @TIPO_DE_DADO_ID
	,	[FlagStatus] = 1		
	,	[OrdemExibicao] = 0
	,	[Limitador] = 0
	,	[Qualificador] = 0
	,	[CadastroUsuarioId] = 1
	,	[CadastroDataHora] = GETDATE()
	,	[AtualizacaoUsuarioId] = NULL
	,	[AtualizacaoDataHora] = NULL
	;
	SET @TIPO_DE_ATRIBUTO_ID = SCOPE_IDENTITY()
END
GO

IF	NOT EXISTS(SELECT * FROM [dbo].[TipoDeAtributos] WHERE TipoDeAtributoId > 0 AND Nome = 'Estado')
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
	,	[Descricao] = 'Estado'
	,	[NomeFisico] = 'NOME_ESTADO'
	,	[TipoDeDadoId] = @TIPO_DE_DADO_ID
	,	[FlagStatus] = 1		
	,	[OrdemExibicao] = 0
	,	[Limitador] = 0
	,	[Qualificador] = 0
	,	[CadastroUsuarioId] = 1
	,	[CadastroDataHora] = GETDATE()
	,	[AtualizacaoUsuarioId] = NULL
	,	[AtualizacaoDataHora] = NULL
	;
	SET @TIPO_DE_ATRIBUTO_ID = SCOPE_IDENTITY()
END
GO

IF	NOT EXISTS(SELECT * FROM [dbo].[TipoDeAtributos] WHERE TipoDeAtributoId > 0 AND Nome = 'Cidade')
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
	,	[Descricao] = 'Cidade'
	,	[NomeFisico] = 'CIDADE'
	,	[TipoDeDadoId] = @TIPO_DE_DADO_ID  
	,	[FlagStatus] = 1		
	,	[OrdemExibicao] = 0
	,	[Limitador] = 0
	,	[Qualificador] = 0
	,	[CadastroUsuarioId] = 1
	,	[CadastroDataHora] = GETDATE()
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
	,	[Descricao] = 'Lista de peridiocidade (Armazena Peridiocidade + Quantidade de PMTS)'
	,	[NomeFisico] = 'AMORIZACAO_PRINCIPAL'
	,	[TipoDeDadoId] = @TIPO_DE_DADO_ID
	,	[FlagStatus] = 1		
	,	[OrdemExibicao] = 8
	,	[Limitador] = 1
	,	[Qualificador] = 0
	,	[CadastroUsuarioId] = 1
	,	[CadastroDataHora] = GETDATE()
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
	,	[Apelido] = 'ArvoreGarantia'
	,	[Descricao] = 'ARVORE DE GARANTIAS'
	,	[NomeFisico] = 'ARVORE_GARANTIA'
	,	[TipoDeDadoId] = @TIPO_DE_DADO_ID
	,	[FlagStatus] = 1		
	,	[OrdemExibicao] = 0
	,	[Limitador] = 1
	,	[Qualificador] = 0
	,	[CadastroUsuarioId] = 1
	,	[CadastroDataHora] = GETDATE()
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
	,	[Apelido] = 'ArvoreNostroAccount'	
	,	[Descricao] = 'ARVORE DE Notro Account'
	,	[NomeFisico] = 'ARVORE_NOSTRO_ACCOUNT'
	,	[TipoDeDadoId] = @TIPO_DE_DADO_ID	
	,	[FlagStatus] = 1		
	,	[OrdemExibicao] = 0
	,	[Limitador] = 1
	,	[Qualificador] = 0
	,	[CadastroUsuarioId] = 1
	,	[CadastroDataHora] = GETDATE()
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
	,	[Apelido] = 'ArvoreSettlement'	
	,	[Descricao] = 'ARVORE DE Settlement'
	,	[NomeFisico] = 'ARVORE_SETTLEMENT'
	,	[TipoDeDadoId] = @TIPO_DE_DADO_ID
	,	[FlagStatus] = 1		
	,	[OrdemExibicao] = 0
	,	[Limitador] = 1
	,	[Qualificador] = 0
	,	[CadastroUsuarioId] = 1
	,	[CadastroDataHora] = GETDATE()
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
	,	[Apelido] = 'Banco'	
	,	[Descricao] = 'Banco'
	,	[NomeFisico] = 'BANCO'
	,	[TipoDeDadoId] = @TIPO_DE_DADO_ID
	,	[FlagStatus] = 1		
	,	[OrdemExibicao] = 1
	,	[Limitador] = 1
	,	[Qualificador] = 0
	,	[CadastroUsuarioId] = 1
	,	[CadastroDataHora] = GETDATE()
	,	[AtualizacaoUsuarioId] = NULL
	,	[AtualizacaoDataHora] = NULL
	;
	SET @TIPO_DE_ATRIBUTO_ID = SCOPE_IDENTITY()
	;
END
GO

IF	NOT EXISTS(SELECT * FROM [dbo].[TipoDeAtributos] WHERE TipoDeAtributoId > 0 AND Nome = 'Carência')
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
	,	[Apelido] = 'Carência'	
	,	[Descricao] = 'Quantidade de dias'
	,	[NomeFisico] = 'CARENCIA'
	,	[TipoDeDadoId] = @TIPO_DE_DADO_ID
	,	[FlagStatus] = 1		
	,	[OrdemExibicao] = 6
	,	[Limitador] = 1
	,	[Qualificador] = 0
	,	[CadastroUsuarioId] = 1
	,	[CadastroDataHora] = GETDATE()
	,	[AtualizacaoUsuarioId] = NULL
	,	[AtualizacaoDataHora] = NULL
	;
	SET @TIPO_DE_ATRIBUTO_ID = SCOPE_IDENTITY()
	;
END
GO

IF	NOT EXISTS(SELECT * FROM [dbo].[TipoDeAtributos] WHERE TipoDeAtributoId > 0 AND Nome = 'Condições de Crédito')
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
		[TipoDeAtributoId] = 14
	,	[Nome] = 'Condições de Crédito'	
	,	[Apelido] = 'Condições de Crédito'
	,	[Descricao] = 'Campo texto até 3000 caracteres'
	,	[NomeFisico] = 'CONDICOES_CREDITO'
	,	[TipoDeDadoId] = @TIPO_DE_DADO_ID
	,	[FlagStatus] = 1		
	,	[OrdemExibicao] = 12
	,	[Limitador] = 1
	,	[Qualificador] = 0
	,	[CadastroUsuarioId] = 1
	,	[CadastroDataHora] = GETDATE()
	,	[AtualizacaoUsuarioId] = NULL
	,	[AtualizacaoDataHora] = NULL
	;
	SET @TIPO_DE_ATRIBUTO_ID = SCOPE_IDENTITY()
	;
END
GO

IF	NOT EXISTS(SELECT * FROM [dbo].[TipoDeAtributos] WHERE TipoDeAtributoId > 0 AND Nome = 'Credito')
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
		[TipoAtributoId] = 1
	,	[Nome] = 'Credito'	
	,	[Apelido] = 'Credito'	
	,	[Descricao] = 'Credito'
	,	[NomeFisico] = 'CREDITO'
	,	[TipoDadoId] = @TIPO_DE_DADO_ID
	,	[FlagStatus] = 1		
	,	[OrdemExibicao] = 0
	,	[Limitador] = 1
	,	[Qualificador] = 0
	,	[CadastroUsuarioId] = 1
	,	[CadastroDataHora] = GETDATE()
	,	[AtualizacaoUsuarioId] = NULL
	,	[AtualizacaoDataHora] = NULL
	;
	SET @TIPO_DE_ATRIBUTO_ID = SCOPE_IDENTITY()
	;
END
GO

IF	NOT EXISTS(SELECT * FROM [dbo].[TipoDeAtributos] WHERE TipoDeAtributoId > 0 AND Nome = 'Destaque de Garantias')
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
		[TipoDeAtributoId] = 15
	,	[Nome] = 'Destaque de Garantias'	
	,	[Apelido] = 'Destaque de Garantias'
	,	[Descricao] = 'Campo texto até 3000 caracteres'
	,	[NomeFisico] = 'DESTAQUE_GARANTIAS'
	,	[TipoDeDadoId] = @TIPO_DE_DADO_ID
	,	[FlagStatus] = 1
	,	[OrdemExibicao] = 13
	,	[Limitador] = 1
	,	[Qualificador] = 0
	,	[CadastroUsuarioId] = 1
	,	[CadastroDataHora] = GETDATE()
	,	[AtualizacaoUsuarioId] = NULL
	,	[AtualizacaoDataHora] = NULL
	;
	SET @TIPO_DE_ATRIBUTO_ID = SCOPE_IDENTITY()
	;
END
GO

IF	NOT EXISTS(SELECT * FROM [dbo].[TipoDeAtributos] WHERE TipoDeAtributoId > 0 AND Nome = 'Destaque de Liberação de Risco')
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
		[TipoDeAtributoId] = 16
	,	[Nome] = 'Destaque de Liberação de Risco'
	,	[Apelido] = 'Destaque de Liberação de Risco'	
	,	[Descricao] = 'Campo texto até 3000 caracteres'
	,	[NomeFisico] = 'DESTAQUE_LIBERACAO_RISCO'
	,	[TipoDeDadoId] = @TIPO_DE_DADO_ID
	,	[FlagStatus] = 1
	,	[OrdemExibicao] = 14
	,	[Limitador] = 1
	,	[Qualificador] = 0
	,	[CadastroUsuarioId] = 1
	,	[CadastroDataHora] = GETDATE()
	,	[AtualizacaoUsuarioId] = NULL
	,	[AtualizacaoDataHora] = NULL
	;
	SET @TIPO_DE_ATRIBUTO_ID = SCOPE_IDENTITY()
	;
END
GO

IF	NOT EXISTS(SELECT * FROM [dbo].[TipoDeAtributos] WHERE TipoDeAtributoId > 0 AND Nome = 'Empresa')
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
		[TipoDeAtributoId] = 24
	,	[Nome] = 'Empresa'	
	,	[Apelido] = 'Empresa'
	,	[Descricao] = 'Empresa'
	,	[NomeFisico] = 'EMPRESAS'
	,	[TipoDeDadoId] = @TIPO_DE_DADO_ID
	,	[FlagStatus] = 1
	,	[OrdemExibicao] = 1
	,	[Limitador] = 1
	,	[Qualificador] = 0
	,	[CadastroUsuarioId] = 1
	,	[CadastroDataHora] = GETDATE()
	,	[AtualizacaoUsuarioId] = NULL
	,	[AtualizacaoDataHora] = NULL
	;
	SET @TIPO_DE_ATRIBUTO_ID = SCOPE_IDENTITY()
	;
END
GO

IF	NOT EXISTS(SELECT * FROM [dbo].[TipoDeAtributos] WHERE TipoDeAtributoId > 0 AND Nome = 'Garantia')
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
		[TipoDeAtributoId] = 27
	,	[Nome] = 'Garantia'	
	,	[Apelido] = 'Garantia'
	,	[Descricao] = 'Garantia'
	,	[NomeFisico] = 'GARANTIA'
	,	[TipoDeDadoId] = @TIPO_DE_DADO_ID
	,	[FlagStatus] = 1
	,	[OrdemExibicao] = 10
	,	[Limitador] = 1
	,	[Qualificador] = 0
	,	[CadastroUsuarioId] = 1
	,	[CadastroDataHora] = GETDATE()
	,	[AtualizacaoUsuarioId] = NULL
	,	[AtualizacaoDataHora] = NULL
	;
	SET @TIPO_DE_ATRIBUTO_ID = SCOPE_IDENTITY()
	;
END
GO

IF	NOT EXISTS(SELECT * FROM [dbo].[TipoDeAtributos] WHERE TipoDeAtributoId > 0 AND Nome = 'Grupo Econômico')
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
		[TipoDeAtributoId] = 23
	,	[Nome] = 'Grupo Econômico'	
	,	[Apelido] = 'Grupo Econômico'
	,	[Descricao] = 'GrupoEconomico'
	,	[NomeFisico] = 'GRUPO_ECONOMICO'
	,	[TipoDadoId] = @TIPO_DE_DADO_ID
	,	[FlagStatus] = 1
	,	[OrdemExibicao] = 1
	,	[Limitador] = 1
	,	[Qualificador] = 0
	,	[CadastroUsuarioId] = 1
	,	[CadastroDataHora] = GETDATE()
	,	[AtualizacaoUsuarioId] = NULL
	,	[AtualizacaoDataHora] = NULL
	;
	SET @TIPO_DE_ATRIBUTO_ID = SCOPE_IDENTITY()
	;
END
GO

IF	NOT EXISTS(SELECT * FROM [dbo].[TipoDeAtributos] WHERE TipoDeAtributoId > 0 AND Nome = 'Limite Clean')
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
		[TipoDeAtributoId] = 18
	,	[Nome] = 'Limite Clean'	
	,	[Apelido] = 'Limite Clean'
	,	[Descricao] = 'Limite clean'
	,	[NomeFisico] = 'LIMITE_CLEAN'
	,	[TipoDeDadoId] = @TIPO_DE_DADO_ID
	,	[FlagStatus] = 1
	,	[OrdemExibicao] = 2
	,	[Limitador] = 1
	,	[Qualificador] = 0
	,	[CadastroUsuarioId] = 1
	,	[CadastroDataHora] = GETDATE()
	,	[AtualizacaoUsuarioId] = NULL
	,	[AtualizacaoDataHora] = NULL
	;
	SET @TIPO_DE_ATRIBUTO_ID = SCOPE_IDENTITY()
	;
END
GO

IF	NOT EXISTS(SELECT * FROM [dbo].[TipoDeAtributos] WHERE TipoDeAtributoId > 0 AND Nome = 'Operação Renegociada')
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
		[TipoAtributoId] = 17
	,	[Nome] = 'Operação Renegociada'	
	,	[Apelido] = 'Operação Renegociada' 
	,	[Descricao] = 'bit botao radio (sim/nao)'
	,	[NomeFisico] = 'OPERACAO_RENEGOCIADA'
	,	[TipoDadoId] = @TIPO_DE_DADO_ID
	,	[FlagStatus] = 1
	,	[OrdemExibicao] = 4
	,	[Limitador] = 1
	,	[Qualificador] = 0
	,	[CadastroUsuarioId] = 1
	,	[CadastroDataHora] = GETDATE()
	,	[AtualizacaoUsuarioId] = NULL
	,	[AtualizacaoDataHora] = NULL
	;
	SET @TIPO_DE_ATRIBUTO_ID = SCOPE_IDENTITY()
	;
END
GO

IF	NOT EXISTS(SELECT * FROM [dbo].[TipoDeAtributos] WHERE TipoDeAtributoId > 0 AND Nome = 'Pagamento de Encargos')
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
		[TipoAtributoId] = 10
	,	[Nome] = 'Pagamento de Encargos'	
	,	[Apelido] = 'Pagamento de Encargos' 
	,	[Descricao] = 'lista de peridiocidade(armazena id_peridiocidade + qtd de pmts)'
	,	[NomeFisico] = 'PAGAMENTO_ENCARGOS'
	,	[TipoDadoId] = @TIPO_DE_DADO_ID
	,	[FlagStatus] = 1
	,	[OrdemExibicao] =  7
	,	[Limitador] = 1
	,	[Qualificador] = 0
	,	[CadastroUsuarioId] = 1
	,	[CadastroDataHora] = GETDATE()
	,	[AtualizacaoUsuarioId] = NULL
	,	[AtualizacaoDataHora] = NULL
	;
	SET @TIPO_DE_ATRIBUTO_ID = SCOPE_IDENTITY()
	;
END
GO

IF	NOT EXISTS(SELECT * FROM [dbo].[TipoDeAtributos] WHERE TipoDeAtributoId > 0 AND Nome = 'Parecer do Limite')
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
		[TipoAtributoId] = 13
	,	[Nome] = 'Parecer do Limite'	
	,	[Apelido] = 'Parecer do Limite'
	,	[Descricao] = 'Campo texto até 3000 caracteres'
	,	[NomeFisico] = 'PARECER_LIMITE'
	,	[TipoDadoId] = @TIPO_DE_DADO_ID
	,	[FlagStatus] = 1
	,	[OrdemExibicao] =  11
	,	[Limitador] = 1
	,	[Qualificador] = 0
	,	[CadastroUsuarioId] = 1
	,	[CadastroDataHora] = GETDATE()
	,	[AtualizacaoUsuarioId] = NULL
	,	[AtualizacaoDataHora] = NULL
	;
	SET @TIPO_DE_ATRIBUTO_ID = SCOPE_IDENTITY()
	;
END
GO

IF	NOT EXISTS(SELECT * FROM [dbo].[TipoDeAtributos] WHERE TipoDeAtributoId > 0 AND Nome = 'Prazo')
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
		[TipoDeAtributoId] = 26
	,	[Nome] = 'Prazo'	
	,	[Apelido] = 'Prazo'
	,	[Descricao] = 'Prazo'
	,	[NomeFisico] = 'PRAZO'
	,	[TipoDadoId] = @TIPO_DE_DADO_ID
	,	[FlagStatus] = 1
	,	[OrdemExibicao] =  5
	,	[Limitador] = 1
	,	[Qualificador] = 0
	,	[CadastroUsuarioId] = 1
	,	[CadastroDataHora] = GETDATE()
	,	[AtualizacaoUsuarioId] = NULL
	,	[AtualizacaoDataHora] = NULL
	;
	SET @TIPO_DE_ATRIBUTO_ID = SCOPE_IDENTITY()
	;
END
GO

IF	NOT EXISTS(SELECT * FROM [dbo].[TipoDeAtributos] WHERE TipoDeAtributoId > 0 AND Nome = 'Produto')
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
		[TipoAtributoId] = 28
	,	[Nome] = 'Produto'
	,	[Apelido] = 'Produto'	
	,	[Descricao] = 'Produto'
	,	[NomeFisico] = 'PRODUTO'
	,	[TipoDadoId] = @TIPO_DE_DADO_ID
	,	[FlagStatus] = 1
	,	[OrdemExibicao] =  3
	,	[Limitador] = 1
	,	[Qualificador] = 0
	,	[CadastroUsuarioId] = 1
	,	[CadastroDataHora] = GETDATE()
	,	[AtualizacaoUsuarioId] = NULL
	,	[AtualizacaoDataHora] = NULL
	;
	SET @TIPO_DE_ATRIBUTO_ID = SCOPE_IDENTITY()
	;
END
GO

IF	NOT EXISTS(SELECT * FROM [dbo].[TipoDeAtributos] WHERE TipoDeAtributoId > 0 AND Nome = 'Produto Legado')
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
		[TipoDeAtributoId] = 25
	,	[Nome] = 'Produto Legado'	
	,	[Apelido] = 'Produto Legado'
	,	[Descricao] = 'ProdutoLegado'
	,	[NomeFisico] = 'PRODUTO_LEGADO'
	,	[TipoDadoId] = @TIPO_DE_DADO_ID
	,	[FlagStatus] = 0
	,	[OrdemExibicao] =  3
	,	[Limitador] = 1
	,	[Qualificador] = 0
	,	[CadastroUsuarioId] = 1
	,	[CadastroDataHora] = GETDATE()
	,	[AtualizacaoUsuarioId] = NULL
	,	[AtualizacaoDataHora] = NULL
	;
	SET @TIPO_DE_ATRIBUTO_ID = SCOPE_IDENTITY()
	;
END
GO

IF	NOT EXISTS(SELECT * FROM [dbo].[TipoDeAtributos] WHERE TipoDeAtributoId > 0 AND Nome = 'Valor')
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
		[TipoDeAtributoId] = 29
	,	[Nome] = 'Valor'	
	,	[Apelido] = 'Valor'
	,	[Descricao] = 'Valor'
	,	[NomeFisico] = 'VALOR'
	,	[TipoDadoId] = @TIPO_DE_DADO_ID
	,	[FlagStatus] = 1
	,	[OrdemExibicao] =  4
	,	[Limitador] = 1
	,	[Qualificador] = 0
	,	[CadastroUsuarioId] = 1
	,	[CadastroDataHora] = GETDATE()
	,	[AtualizacaoUsuarioId] = NULL
	,	[AtualizacaoDataHora] = NULL
	;
	SET @TIPO_DE_ATRIBUTO_ID = SCOPE_IDENTITY()
	;
END
GO

IF	NOT EXISTS(SELECT * FROM [dbo].[TipoDeAtributos] WHERE TipoDeAtributoId > 0 AND Nome = 'Nome')
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
		[TipoDeAtributoId] = 30
	,	[Nome] = 'Nome'	
	,	[Apelido] = 'Nome'
	,	[Descricao] = 'Nome'
	,	[NomeFisico] = 'NOME'
	,	[TipoDadoId] = @TIPO_DE_DADO_ID
	,	[FlagStatus] = 1
	,	[OrdemExibicao] =  0
	,	[Limitador] = 1
	,	[Qualificador] = 0
	,	[CadastroUsuarioId] = 1
	,	[CadastroDataHora] = GETDATE()
	,	[AtualizacaoUsuarioId] = NULL
	,	[AtualizacaoDataHora] = NULL
	;
	SET @TIPO_DE_ATRIBUTO_ID = SCOPE_IDENTITY()
	;
END
GO


IF	NOT EXISTS(SELECT * FROM [dbo].[TipoDeAtributos] WHERE TipoDeAtributoId > 0 AND Nome = 'Email')
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
		[TipoDeAtributoId] = 31
	,	[Nome] = 'Email'	
	,	[Apelido] = 'Email'
	,	[Descricao] = 'Email'
	,	[NomeFisico] = 'EMAIL'
	,	[TipoDadoId] = @TIPO_DE_DADO_ID
	,	[FlagStatus] = 1
	,	[OrdemExibicao] =  0
	,	[Limitador] = 1
	,	[Qualificador] = 0
	,	[CadastroUsuarioId] = 1
	,	[CadastroDataHora] = GETDATE()
	,	[AtualizacaoUsuarioId] = NULL
	,	[AtualizacaoDataHora] = NULL
	;
	SET @TIPO_DE_ATRIBUTO_ID = SCOPE_IDENTITY()
	;
END
GO

IF	NOT EXISTS(SELECT * FROM [dbo].[TipoDeAtributos] WHERE TipoDeAtributoId > 0 AND Nome = 'Assunto')
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
		[TipoDeAtributoId] = 32
	,	[Nome] = 'Assunto'	
	,	[Apelido] = 'Assunto'
	,	[Descricao] = 'Assunto'
	,	[NomeFisico] = 'ASSUNTO'
	,	[TipoDadoId] = @TIPO_DE_DADO_ID
	,	[FlagStatus] = 1
	,	[OrdemExibicao] =  0
	,	[Limitador] = 1
	,	[Qualificador] = 0
	,	[CadastroUsuarioId] = 1
	,	[CadastroDataHora] = GETDATE()
	,	[AtualizacaoUsuarioId] = NULL
	,	[AtualizacaoDataHora] = NULL
	;
	SET @TIPO_DE_ATRIBUTO_ID = SCOPE_IDENTITY()
	;
END
GO
IF	NOT EXISTS(SELECT * FROM [dbo].[TipoDeAtributos] WHERE TipoDeAtributoId > 0 AND Nome = 'Mensagem')
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
		[TipoDeAtributoId] = 33
	,	[Nome] = 'Mensagem'	
	,	[Apelido] = 'Mensagem'
	,	[Descricao] = 'Mensagem'
	,	[NomeFisico] = 'MENSAGEM'
	,	[TipoDadoId] = @TIPO_DE_DADO_ID
	,	[FlagStatus] = 1
	,	[OrdemExibicao] =  0
	,	[Limitador] = 1
	,	[Qualificador] = 0
	,	[CadastroUsuarioId] = 1
	,	[CadastroDataHora] = GETDATE()
	,	[AtualizacaoUsuarioId] = NULL
	,	[AtualizacaoDataHora] = NULL
	;
	SET @TIPO_DE_ATRIBUTO_ID = SCOPE_IDENTITY()
	;
END
GO

SET IDENTITY_INSERT TipoDeAtributos OFF --Habilita o IDENTITY
GO