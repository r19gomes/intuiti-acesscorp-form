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
	,	[TipoDadoId]
	,	[FlagStatus]
	,	[OrdemExibicao]
	,	[Limitador]
	,	[Qualificador]
	)
	SELECT
		[TipoDeAtributoId] = 2
	,	[Nome] = 'Endereço'	
	,	[Apelido] = 'Endereço'
	,	[Descricao] = NULL
	,	[NomeFisico] = "ENDERECO"
	,	[TipoDadoId] = @TIPO_DE_DADO_ID  
	,	[FlagStatus] = 1		
	,	[OrdemExibicao] = 0
	,	[Limitador] = 0
	,	[Qualificador] = 0
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
	,	[TipoDadoId]
	,	[FlagStatus]
	,	[OrdemExibicao]
	,	[Limitador]
	,	[Qualificador]
	)
	SELECT
		[TipoDeAtributoId] = 2
	,	[Nome] = 'Endereço'	
	,	[Apelido] = 'Endereço'
	,	[Descricao] = NULL
	,	[NomeFisico] = 'ENDERECO'
	,	[TipoDadoId] = @TIPO_DE_DADO_ID  
	,	[FlagStatus] = 1		
	,	[OrdemExibicao] = 0
	,	[Limitador] = 0
	,	[Qualificador] = 0
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
	,	[TipoDadoId]
	,	[FlagStatus]
	,	[OrdemExibicao]
	,	[Limitador]
	,	[Qualificador]
	)
	SELECT
		[TipoDeAtributoId] = 3
	,	[Nome] = 'Complemento'	
	,	[Apelido] = 'Complemento'
	,	[Descricao] = NULL
	,	[NomeFisico] = 'COMPLEMENTO'
	,	[TipoDadoId] = @TIPO_DE_DADO_ID  
	,	[FlagStatus] = 1		
	,	[OrdemExibicao] = 0
	,	[Limitador] = 0
	,	[Qualificador] = 0
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
	,	[TipoDadoId]
	,	[FlagStatus]
	,	[OrdemExibicao]
	,	[Limitador]
	,	[Qualificador]
	)
	SELECT
		[TipoDeAtributoId] = 4
	,	[Nome] = 'Bairro'	
	,	[Apelido] = 'Bairro'
	,	[Descricao] = NULL
	,	[NomeFisico] = 'BAIRRO'
	,	[TipoDadoId] = @TIPO_DE_DADO_ID
	,	[FlagStatus] = 1		
	,	[OrdemExibicao] = 0
	,	[Limitador] = 0
	,	[Qualificador] = 0
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
	,	[TipoDadoId]
	,	[FlagStatus]
	,	[OrdemExibicao]
	,	[Limitador]
	,	[Qualificador]
	)
	SELECT
		[TipoDeAtributoId] = 5
	,	[Nome] = 'Cep'	
	,	[Apelido] = 'Cep'
	,	[Descricao] = NULL
	,	[NomeFisico] = 'CEP'
	,	[TipoDadoId] = @TIPO_DE_DADO_ID
	,	[FlagStatus] = 1		
	,	[OrdemExibicao] = 0
	,	[Limitador] = 0
	,	[Qualificador] = 0
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
	,	[TipoDadoId]
	,	[FlagStatus]
	,	[OrdemExibicao]
	,	[Limitador]
	,	[Qualificador]
	)
	SELECT
		[TipoDeAtributoId] = 6
	,	[Nome] = 'Cep Complemento'	
	,	[Apelido] = 'Cep Complemento'
	,	[Descricao] = NULL
	,	[NomeFisico] = 'CEP_COMPLEMENTO'
	,	[TipoDadoId] = @TIPO_DE_DADO_ID
	,	[FlagStatus] = 1		
	,	[OrdemExibicao] = 0
	,	[Limitador] = 0
	,	[Qualificador] = 0
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
	,	[TipoDadoId]
	,	[FlagStatus]
	,	[OrdemExibicao]
	,	[Limitador]
	,	[Qualificador]
	)
	SELECT
		[TipoDeAtributoId] = 7
	,	[Nome] = 'Nome do País'	
	,	[Apelido] = 'País'
	,	[Descricao] = NULL
	,	[NomeFisico] = 'NOME_PAIS'
	,	[TipoDadoId] = @TIPO_DE_DADO_ID
	,	[FlagStatus] = 1		
	,	[OrdemExibicao] = 0
	,	[Limitador] = 0
	,	[Qualificador] = 0
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
	,	[TipoDadoId]
	,	[FlagStatus]
	,	[OrdemExibicao]
	,	[Limitador]
	,	[Qualificador]
	)
	SELECT
		[TipoDeAtributoId] = 8
	,	[Nome] = 'Estado'	
	,	[Apelido] = 'UF'
	,	[Descricao] = NULL
	,	[NomeFisico] = 'NOME_ESTADO'
	,	[TipoDadoId] = @TIPO_DE_DADO_ID
	,	[FlagStatus] = 1		
	,	[OrdemExibicao] = 0
	,	[Limitador] = 0
	,	[Qualificador] = 0
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
	,	[TipoDadoId]
	,	[FlagStatus]
	,	[OrdemExibicao]
	,	[Limitador]
	,	[Qualificador]
	)
	SELECT
		[TipoDeAtributoId] = 9
	,	[Nome] = 'Cidade'	
	,	[Apelido] = 'Cidade'
	,	[Descricao] = NULL
	,	[NomeFisico] = 'CIDADE'
	,	[TipoDadoId] = @TIPO_DE_DADO_ID  
	,	[FlagStatus] = 1		
	,	[OrdemExibicao] = 0
	,	[Limitador] = 0
	,	[Qualificador] = 0
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
	,	[TipoDadoId]
	,	[FlagStatus]
	,	[OrdemExibicao]
	,	[Limitador]
	,	[Qualificador]
	)
	SELECT
		[TipoDeAtributoId] = 11
	,	[Nome] = 'Amortização do Principal'	
	,	[Apelido] = 'Amortização do Principal'
	,	[Descricao] 'Lista de peridiocidade (Armazena Peridiocidade + Quantidade de PMTS)'
	,	[NomeFisico] = 'AMORIZACAO_PRINCIPAL'
	,	[TipoDadoId] = @TIPO_DE_DADO_ID
	,	[FlagStatus] = 1		
	,	[OrdemExibicao] = 8
	,	[Limitador] = 1
	,	[Qualificador] = 0
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
	,	[Descricao]
	,	[TipoDadoId]
	,	[FlagStatus]
	,	[OrdemExibicao]
	,	[Limitador]
	,	[Qualificador]
	)
	SELECT
		[TipoAtributoId] = 2000
	,	[Nome] = 'ArvoreGarantia'	
	,	[Descricao] 'ARVORE DE GARANTIAS'
	,	[TipoDadoId] = @TIPO_DE_DADO_ID
	,	[FlagStatus] = 1		
	,	[OrdemExibicao] = 0
	,	[Limitador] = 1
	,	[Qualificador] = 0
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
	,	[Descricao]
	,	[TipoDadoId]
	,	[FlagStatus]
	,	[OrdemExibicao]
	,	[Limitador]
	,	[Qualificador]
	)
	SELECT
		[TipoDeAtributoId] = 4000
	,	[Nome] = 'ArvoreNostroAccount'	
	,	[Descricao] 'ARVORE DE Notro Account'
	,	[TipoDadoId] = @TIPO_DE_DADO_ID
	,	[FlagStatus] = 1		
	,	[OrdemExibicao] = 0
	,	[Limitador] = 1
	,	[Qualificador] = 0
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
	,	[Descricao]
	,	[TipoDadoId]
	,	[FlagStatus]
	,	[OrdemExibicao]
	,	[Limitador]
	,	[Qualificador]
	)
	SELECT
		[TipoDeAtributoId] = 3000
	,	[Nome] = 'ArvoreSettlement'	
	,	[Descricao] 'ARVORE DE Settlement'
	,	[TipoDadoId] = @TIPO_DE_DADO_ID
	,	[FlagStatus] = 1		
	,	[OrdemExibicao] = 0
	,	[Limitador] = 1
	,	[Qualificador] = 0
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
	,	[Descricao]
	,	[TipoDadoId]
	,	[FlagStatus]
	,	[OrdemExibicao]
	,	[Limitador]
	,	[Qualificador]
	)
	SELECT
		[TipoDeAtributoId] = 21
	,	[Nome] = 'Banco'	
	,	[Descricao] 'Banco'
	,	[TipoDadoId] = @TIPO_DE_DADO_ID
	,	[FlagStatus] = 1		
	,	[OrdemExibicao] = 1
	,	[Limitador] = 1
	,	[Qualificador] = 0
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
	,	[Descricao]
	,	[TipoDadoId]
	,	[FlagStatus]
	,	[OrdemExibicao]
	,	[Limitador]
	,	[Qualificador]
	)
	SELECT
		[TipoDeAtributoId] = 19
	,	[Nome] = 'Carência'	
	,	[Descricao] 'Quantidade de dias'
	,	[TipoDadoId] = @TIPO_DE_DADO_ID
	,	[FlagStatus] = 1		
	,	[OrdemExibicao] = 6
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
		[TipoAtributoId] 
	,	[Nome] 
	,	[Descricao]
	,	[TipoDadoId]
	,	[FlagStatus]
	,	[OrdemExibicao]
	,	[Limitador]
	,	[Qualificador]
	)
	SELECT
		--[TipoAtributoId] = 14
		[Nome] = 'Condições de Crédito'	
	,	[Descricao] 'Campo texto até 3000 caracteres'
	,	[TipoDadoId] = @TIPO_DE_DADO_ID
	,	[FlagStatus] = 1		
	,	[OrdemExibicao] = 12
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
		[TipoAtributoId] 
	,	[Nome] 
	,	[Descricao]
	,	[TipoDadoId]
	,	[FlagStatus]
	,	[OrdemExibicao]
	,	[Limitador]
	,	[Qualificador]
	)
	SELECT
		--[TipoAtributoId] = 1
		[Nome] = 'Credito'	
	,	[Descricao] 'Credito'
	,	[TipoDadoId] = @TIPO_DE_DADO_ID
	,	[FlagStatus] = 1		
	,	[OrdemExibicao] = 0
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
		[TipoAtributoId] 
	,	[Nome] 
	,	[Descricao]
	,	[TipoDadoId]
	,	[FlagStatus]
	,	[OrdemExibicao]
	,	[Limitador]
	,	[Qualificador]
	)
	SELECT
		--[TipoAtributoId] = 15
		[Nome] = 'Destaque de Garantias'	
	,	[Descricao] 'Campo texto até 3000 caracteres'
	,	[TipoDadoId] = @TIPO_DE_DADO_ID
	,	[FlagStatus] = 1
	,	[OrdemExibicao] = 13
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
		[TipoAtributoId] 
	,	[Nome] 
	,	[Descricao]
	,	[TipoDadoId]
	,	[FlagStatus]
	,	[OrdemExibicao]
	,	[Limitador]
	,	[Qualificador]
	)
	SELECT
		--[TipoAtributoId] = 16
		[Nome] = 'Destaque de Liberação de Risco'	
	,	[Descricao] 'Campo texto até 3000 caracteres'
	,	[TipoDadoId] = @TIPO_DE_DADO_ID
	,	[FlagStatus] = 1
	,	[OrdemExibicao] = 14
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
		[TipoAtributoId] 
	,	[Nome] 
	,	[Descricao]
	,	[TipoDadoId]
	,	[FlagStatus]
	,	[OrdemExibicao]
	,	[Limitador]
	,	[Qualificador]
	)
	SELECT
		--[TipoAtributoId] = 4
		[Nome] = 'Empresa'	
	,	[Descricao] 'Empresa'
	,	[TipoDadoId] = @TIPO_DE_DADO_ID
	,	[FlagStatus] = 1
	,	[OrdemExibicao] = 1
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
		Nome = 'object'
	;	
	INSERT [dbo].[TiposAtributos]
	(
		[TipoAtributoId] 
	,	[Nome] 
	,	[Descricao]
	,	[TipoDadoId]
	,	[FlagStatus]
	,	[OrdemExibicao]
	,	[Limitador]
	,	[Qualificador]
	)
	SELECT
		--[TipoAtributoId] = 7
		[Nome] = '	Garantia'	
	,	[Descricao] 'Garantia'
	,	[TipoDadoId] = @TIPO_DE_DADO_ID
	,	[FlagStatus] = 1
	,	[OrdemExibicao] = 10
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
		[TipoAtributoId] 
	,	[Nome] 
	,	[Descricao]
	,	[TipoDadoId]
	,	[FlagStatus]
	,	[OrdemExibicao]
	,	[Limitador]
	,	[Qualificador]
	)
	SELECT
		--[TipoAtributoId] = 3
		[Nome] = 'Grupo Econômico'	
	,	[Descricao] 'GrupoEconomico'
	,	[TipoDadoId] = @TIPO_DE_DADO_ID
	,	[FlagStatus] = 1
	,	[OrdemExibicao] = 1
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
		[TipoAtributoId] 
	,	[Nome] 
	,	[Descricao]
	,	[TipoDadoId]
	,	[FlagStatus]
	,	[OrdemExibicao]
	,	[Limitador]
	,	[Qualificador]
	)
	SELECT
		--[TipoAtributoId] = 18
		[Nome] = 'Limite Clean'	
	,	[Descricao] 'Limite clean'
	,	[TipoDadoId] = @TIPO_DE_DADO_ID
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
		[TipoAtributoId] 
	,	[Nome] 
	,	[Descricao]
	,	[TipoDadoId]
	,	[FlagStatus]
	,	[OrdemExibicao]
	,	[Limitador]
	,	[Qualificador]
	)
	SELECT
		--[TipoAtributoId] = 17
		[Nome] = 'Operação Renegociada'	
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
		[TipoAtributoId] 
	,	[Nome] 
	,	[Descricao]
	,	[TipoDadoId]
	,	[FlagStatus]
	,	[OrdemExibicao]
	,	[Limitador]
	,	[Qualificador]
	)
	SELECT
		--[TipoAtributoId] = 10
		[Nome] = 'Pagamento de Encargos'	
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
		[TipoAtributoId] 
	,	[Nome] 
	,	[Descricao]
	,	[TipoDadoId]
	,	[FlagStatus]
	,	[OrdemExibicao]
	,	[Limitador]
	,	[Qualificador]
	)
	SELECT
		--[TipoAtributoId] = 13
		[Nome] = 'Parecer do Limite'	
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
		[TipoAtributoId] 
	,	[Nome] 
	,	[Descricao]
	,	[TipoDadoId]
	,	[FlagStatus]
	,	[OrdemExibicao]
	,	[Limitador]
	,	[Qualificador]
	)
	SELECT
		--[TipoAtributoId] = 6
		[Nome] = 'Prazo'	
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
		[TipoAtributoId] 
	,	[Nome] 
	,	[Descricao]
	,	[TipoDadoId]
	,	[FlagStatus]
	,	[OrdemExibicao]
	,	[Limitador]
	,	[Qualificador]
	)
	SELECT
		--[TipoAtributoId] = 8
		[Nome] = 'Produto'	
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
		[TipoAtributoId] 
	,	[Nome] 
	,	[Descricao]
	,	[TipoDadoId]
	,	[FlagStatus]
	,	[OrdemExibicao]
	,	[Limitador]
	,	[Qualificador]
	)
	SELECT
		--[TipoAtributoId] = 5
		[Nome] = '	Produto'	
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
		[TipoAtributoId] 
	,	[Nome] 
	,	[Descricao]
	,	[TipoDadoId]
	,	[FlagStatus]
	,	[OrdemExibicao]
	,	[Limitador]
	,	[Qualificador]
	)
	SELECT
		--[TipoAtributoId] = 19
		[Nome] = '	Valor'	
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