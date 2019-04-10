/*
"TipoDeAtributos": [
    {
      "TipoDeAtributoId": 2,
      "Nome": "Endereço",
      "Apelido": "Endereço",
      "NomeFisico": "ENDERECO",
      "FlagStatus": true,
      "TipoDeEntidadeId": 1,
      "TipoDeDadoId": 4,
      "CadastroDataHora": "2018-11-29 00:00",
      "CadastroUsuarioId": null,
      "AtualizacaoDataHora": null,
      "AtualizacaoUsuarioId": null
    },
    {
      "TipoDeAtributoId": 2,
      "Nome": "Número",
      "Apelido": "Número",
      "NomeFisico": "NUMERO",
      "FlagStatus": true,
      "TipoDeEntidadeId": 1,
      "TipoDeDadoId": 4,
      "CadastroDataHora": "2018-11-29 00:00",
      "CadastroUsuarioId": null,
      "AtualizacaoDataHora": null,
      "AtualizacaoUsuarioId": null
    },
    {
      "TipoDeAtributoId": 3,
      "Nome": "Complemento",
      "Apelido": "Complemento",
      "NomeFisico": "COMPLEMENTO",
      "FlagStatus": true,
      "TipoDeEntidadeId": 1,
      "TipoDeDadoId": 4,
      "CadastroDataHora": "2018-11-29 00:00",
      "CadastroUsuarioId": null,
      "AtualizacaoDataHora": null,
      "AtualizacaoUsuarioId": null
    },
    {
      "TipoDeAtributoId": 4,
      "Nome": "Bairro",
      "Apelido": "Bairro",
      "NomeFisico": "BAIRRO",
      "FlagStatus": true,
      "TipoDeEntidadeId": 1,
      "TipoDeDadoId": 4,
      "CadastroDataHora": "2018-11-29 00:00",
      "CadastroUsuarioId": null,
      "AtualizacaoDataHora": null,
      "AtualizacaoUsuarioId": null
    },
    {
      "TipoDeAtributoId": 5,
      "Nome": "Cep",
      "Apelido": "Cep",
      "NomeFisico": "CEP",
      "FlagStatus": true,
      "TipoDeEntidadeId": 1,
      "TipoDeDadoId": 4,
      "CadastroDataHora": "2018-11-29 00:00",
      "CadastroUsuarioId": null,
      "AtualizacaoDataHora": null,
      "AtualizacaoUsuarioId": null
    },
    {
      "TipoDeAtributoId": 6,
      "Nome": "Cep Complemento",
      "Apelido": "Cep Complemento",
      "NomeFisico": "CEP_COMPLEMENTO",
      "FlagStatus": true,
      "TipoDeEntidadeId": 1,
      "TipoDeDadoId": 4,
      "CadastroDataHora": "2018-11-29 00:00",
      "CadastroUsuarioId": null,
      "AtualizacaoDataHora": null,
      "AtualizacaoUsuarioId": null
    },
    {
      "TipoDeAtributoId": 7,
      "Nome": "Nome do País",
      "Apelido": "País",
      "NomeFisico": "NOME_PAIS",
      "FlagStatus": true,
      "TipoDeEntidadeId": 1,
      "TipoDeDadoId": 4,
      "CadastroDataHora": "2018-11-29 00:00",
      "CadastroUsuarioId": null,
      "AtualizacaoDataHora": null,
      "AtualizacaoUsuarioId": null
    },
    {
      "TipoDeAtributoId": 8,
      "Nome": "Estado",
      "Apelido": "UF",
      "NomeFisico": "NOME_ESTADO",
      "FlagStatus": true,
      "TipoDeEntidadeId": 1,
      "TipoDeDadoId": 4,
      "CadastroDataHora": "2018-11-29 00:00",
      "CadastroUsuarioId": null,
      "AtualizacaoDataHora": null,
      "AtualizacaoUsuarioId": null
    },
    {
      "TipoDeAtributoId": 9,
      "Nome": "Cidade",
      "Apelido": "Cidade",
      "NomeFisico": "CIDADE",
      "FlagStatus": true,
      "TipoDeEntidadeId": 1,
      "TipoDeDadoId": 4,
      "CadastroDataHora": "2018-11-29 00:00",
      "CadastroUsuarioId": null,
      "AtualizacaoDataHora": null,
      "AtualizacaoUsuarioId": null
    }
*/
IF	NOT EXISTS(SELECT * FROM [dbo].[TiposAtributos] WHERE TipoAtributoId > 0 AND Nome = 'Amortização do Principal')
BEGIN
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
		--[TipoAtributoId] = 11
		[Nome] = 'Amortização do Principal'	
	,	[Descricao] 'Lista de peridiocidade (armazena Peridiocidade + Quantidade de PMTS)'
	,	[TipoDadoId] = @VARCHAR  
	,	[FlagStatus] = 1		
	,	[OrdemExibicao] = 8
	,	[Limitador] = 1
	,	[Qualificador] = 0
	;
	SET @TIPO_ATRIBUTO_ID = SCOPE_IDENTITY()
END
GO

IF	NOT EXISTS(SELECT * FROM [dbo].[TiposAtributos] WHERE TipoAtributoId > 0 AND Nome = 'ArvoreGarantia')
BEGIN
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
		--[TipoAtributoId] = 2000
		[Nome] = 'ArvoreGarantia'	
	,	[Descricao] 'ARVORE DE GARANTIAS'
	,	[TipoDadoId] = @INTEGER
	,	[FlagStatus] = 1		
	,	[OrdemExibicao] = 0
	,	[Limitador] = 1
	,	[Qualificador] = 0
	;
	SET @TIPO_ATRIBUTO_ID = SCOPE_IDENTITY()
END
GO

IF	NOT EXISTS(SELECT * FROM [dbo].[TiposAtributos] WHERE TipoAtributoId > 0 AND Nome = 'ArvoreNostroAccount')
BEGIN
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
		--[TipoAtributoId] = 4000
		[Nome] = 'ArvoreNostroAccount'	
	,	[Descricao] 'ARVORE DE Notro Account'
	,	[TipoDadoId] = @INTEGER
	,	[FlagStatus] = 1		
	,	[OrdemExibicao] = 0
	,	[Limitador] = 1
	,	[Qualificador] = 0
	;
	SET @TIPO_ATRIBUTO_ID = SCOPE_IDENTITY()
END
GO

IF	NOT EXISTS(SELECT * FROM [dbo].[TiposAtributos] WHERE TipoAtributoId > 0 AND Nome = 'ArvoreSettlement')
BEGIN
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
		--[TipoAtributoId] = 3000
		[Nome] = 'ArvoreSettlement'	
	,	[Descricao] 'ARVORE DE Settlement'
	,	[TipoDadoId] = @INTEGER
	,	[FlagStatus] = 1		
	,	[OrdemExibicao] = 0
	,	[Limitador] = 1
	,	[Qualificador] = 0
	;
	SET @TIPO_ATRIBUTO_ID = SCOPE_IDENTITY()
END
GO

IF	NOT EXISTS(SELECT * FROM [dbo].[TiposAtributos] WHERE TipoAtributoId > 0 AND Nome = '')
BEGIN
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
		--[TipoAtributoId] = 2
		[Nome] = 'Banco'	
	,	[Descricao] 'Banco'
	,	[TipoDadoId] = @INTEGER
	,	[FlagStatus] = 1		
	,	[OrdemExibicao] = 1
	,	[Limitador] = 1
	,	[Qualificador] = 0
	;
	SET @TIPO_ATRIBUTO_ID = SCOPE_IDENTITY()
	;
END
GO

IF	NOT EXISTS(SELECT * FROM [dbo].[TiposAtributos] WHERE TipoAtributoId > 0 AND Nome = '')
BEGIN
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
		--[TipoAtributoId] = 9
		[Nome] = 'Carência'	
	,	[Descricao] 'Quantidade de dias'
	,	[TipoDadoId] = @INTEGER
	,	[FlagStatus] = 1		
	,	[OrdemExibicao] = 6
	,	[Limitador] = 1
	,	[Qualificador] = 0
	;
	SET @TIPO_ATRIBUTO_ID = SCOPE_IDENTITY()
	;
END
GO

IF	NOT EXISTS(SELECT * FROM [dbo].[TiposAtributos] WHERE TipoAtributoId > 0 AND Nome = '')
BEGIN
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
	,	[TipoDadoId] = @VARCHAR
	,	[FlagStatus] = 1		
	,	[OrdemExibicao] = 12
	,	[Limitador] = 1
	,	[Qualificador] = 0
	;
	SET @TIPO_ATRIBUTO_ID = SCOPE_IDENTITY()
	;
END
GO

IF	NOT EXISTS(SELECT * FROM [dbo].[TiposAtributos] WHERE TipoAtributoId > 0 AND Nome = '')
BEGIN
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
	,	[TipoDadoId] = @INTEGER
	,	[FlagStatus] = 1		
	,	[OrdemExibicao] = 0
	,	[Limitador] = 1
	,	[Qualificador] = 0
	;
	SET @TIPO_ATRIBUTO_ID = SCOPE_IDENTITY()
	;
END
GO

IF	NOT EXISTS(SELECT * FROM [dbo].[TiposAtributos] WHERE TipoAtributoId > 0 AND Nome = '')
BEGIN
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
	,	[TipoDadoId] = @VARCHAR
	,	[FlagStatus] = 1
	,	[OrdemExibicao] = 13
	,	[Limitador] = 1
	,	[Qualificador] = 0
	;
	SET @TIPO_ATRIBUTO_ID = SCOPE_IDENTITY()
	;
END
GO

IF	NOT EXISTS(SELECT * FROM [dbo].[TiposAtributos] WHERE TipoAtributoId > 0 AND Nome = '')
BEGIN
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
	,	[TipoDadoId] = @VARCHAR
	,	[FlagStatus] = 1
	,	[OrdemExibicao] = 14
	,	[Limitador] = 1
	,	[Qualificador] = 0
	;
	SET @TIPO_ATRIBUTO_ID = SCOPE_IDENTITY()
	;
END
GO

IF	NOT EXISTS(SELECT * FROM [dbo].[TiposAtributos] WHERE TipoAtributoId > 0 AND Nome = '')
BEGIN
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
	,	[TipoDadoId] = @INTEGER
	,	[FlagStatus] = 1
	,	[OrdemExibicao] = 1
	,	[Limitador] = 1
	,	[Qualificador] = 0
	;
	SET @TIPO_ATRIBUTO_ID = SCOPE_IDENTITY()
	;
END
GO

IF	NOT EXISTS(SELECT * FROM [dbo].[TiposAtributos] WHERE TipoAtributoId > 0 AND Nome = '')
BEGIN
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
	,	[TipoDadoId] = @OBJECT
	,	[FlagStatus] = 1
	,	[OrdemExibicao] = 10
	,	[Limitador] = 1
	,	[Qualificador] = 0
	;
	SET @TIPO_ATRIBUTO_ID = SCOPE_IDENTITY()
	;
END
GO

IF	NOT EXISTS(SELECT * FROM [dbo].[TiposAtributos] WHERE TipoAtributoId > 0 AND Nome = '')
BEGIN
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
	,	[TipoDadoId] = @INTEGER
	,	[FlagStatus] = 1
	,	[OrdemExibicao] = 1
	,	[Limitador] = 1
	,	[Qualificador] = 0
	;
	SET @TIPO_ATRIBUTO_ID = SCOPE_IDENTITY()
	;
END
GO

IF	NOT EXISTS(SELECT * FROM [dbo].[TiposAtributos] WHERE TipoAtributoId > 0 AND Nome = '')
BEGIN
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
	,	[TipoDadoId] = @NUMERIC
	,	[FlagStatus] = 1
	,	[OrdemExibicao] = 2
	,	[Limitador] = 1
	,	[Qualificador] = 0
	;
	SET @TIPO_ATRIBUTO_ID = SCOPE_IDENTITY()
	;
END
GO

IF	NOT EXISTS(SELECT * FROM [dbo].[TiposAtributos] WHERE TipoAtributoId > 0 AND Nome = '')
BEGIN
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
	,	[TipoDadoId] = @BIT
	,	[FlagStatus] = 1
	,	[OrdemExibicao] = 4
	,	[Limitador] = 1
	,	[Qualificador] = 0
	;
	SET @TIPO_ATRIBUTO_ID = SCOPE_IDENTITY()
	;
END
GO

IF	NOT EXISTS(SELECT * FROM [dbo].[TiposAtributos] WHERE TipoAtributoId > 0 AND Nome = '')
BEGIN
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
	,	[TipoDadoId] = @VARCHAR
	,	[FlagStatus] = 1
	,	[OrdemExibicao] =  7
	,	[Limitador] = 1
	,	[Qualificador] = 0
	;
	SET @TIPO_ATRIBUTO_ID = SCOPE_IDENTITY()
	;
END
GO

IF	NOT EXISTS(SELECT * FROM [dbo].[TiposAtributos] WHERE TipoAtributoId > 0 AND Nome = '')
BEGIN
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
	,	[TipoDadoId] = @VARCHAR
	,	[FlagStatus] = 1
	,	[OrdemExibicao] =  11
	,	[Limitador] = 1
	,	[Qualificador] = 0
	;
	SET @TIPO_ATRIBUTO_ID = SCOPE_IDENTITY()
	;
END
GO

IF	NOT EXISTS(SELECT * FROM [dbo].[TiposAtributos] WHERE TipoAtributoId > 0 AND Nome = '')
BEGIN
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
	,	[TipoDadoId] = @INTEGER
	,	[FlagStatus] = 1
	,	[OrdemExibicao] =  5
	,	[Limitador] = 1
	,	[Qualificador] = 0
	;
	SET @TIPO_ATRIBUTO_ID = SCOPE_IDENTITY()
	;
END
GO

IF	NOT EXISTS(SELECT * FROM [dbo].[TiposAtributos] WHERE TipoAtributoId > 0 AND Nome = '')
BEGIN
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
	,	[TipoDadoId] = @INTEGER
	,	[FlagStatus] = 1
	,	[OrdemExibicao] =  3
	,	[Limitador] = 1
	,	[Qualificador] = 0
	;
	SET @TIPO_ATRIBUTO_ID = SCOPE_IDENTITY()
	;
END
GO

IF	NOT EXISTS(SELECT * FROM [dbo].[TiposAtributos] WHERE TipoAtributoId > 0 AND Nome = '')
BEGIN
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
	,	[TipoDadoId] = @INTEGER
	,	[FlagStatus] = 0
	,	[OrdemExibicao] =  3
	,	[Limitador] = 1
	,	[Qualificador] = 0
	;
	SET @TIPO_ATRIBUTO_ID = SCOPE_IDENTITY()
	;
END
GO

IF	NOT EXISTS(SELECT * FROM [dbo].[TiposAtributos] WHERE TipoAtributoId > 0 AND Nome = '')
BEGIN
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
	,	[TipoDadoId] = @NUMERIC
	,	[FlagStatus] = 1
	,	[OrdemExibicao] =  4
	,	[Limitador] = 1
	,	[Qualificador] = 0
	;
	SET @TIPO_ATRIBUTO_ID = SCOPE_IDENTITY()
	;
END
GO