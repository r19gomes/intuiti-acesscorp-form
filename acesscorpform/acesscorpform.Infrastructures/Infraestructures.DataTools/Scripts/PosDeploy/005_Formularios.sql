use DB_ACESSCORP
GO

SET IDENTITY_INSERT FormulariosTipos ON --Desabilita o IDENTITY
GO

IF	NOT EXISTS(SELECT * FROM [dbo].[FormulariosTipos] WHERE FormularioTipoId > 0 AND Nome = 'Padrão')
BEGIN
    DECLARE @FORMULARIO_ID BIGINT = 0;    
    DECLARE @FORMULARIO_STATUS_ID BIGINT = 0;
    SELECT 
        @FORMULARIO_STATUS_ID = FormularioStatusId
    FROM    
        FormulariosStatus 
    WHERE   
        FormularioStatusId > 0 
    AND
        Nome = 'Em Elaboração' 
    ;
    DECLARE @FORMULARIO_TIPO_ID BIGINT = 0;
    SELECT
        @FORMULARIO_TIPO_ID = FormularioTipoId
    FROM
        FormulariosTipos
    WHERE
        FormularioTipoId > 0 
    AND
        Nome = 'Fale Conosco'
    ;
    INSERT [dbo].[Formularios]
    (
        [FormularioId]
    ,	[Nome]
    ,	[Apelido]
    ,	[FormularioStatusId]
    ,	[DataVigenciaInicial]
    ,	[DataVigenciaFinal]
    ,	[FormularioTipoId]
    ,	[CadastroUsuarioId]
    ,	[CadastroDataHora]
    ,	[AtualizacaoUsuarioId]
    ,	[AtualizacaoDataHora]
    )
    SELECT
        [FormularioId] = 1
    ,	[Nome] = 'Fale Conosco'
    ,	[Apelido] = 'Fale Conosco'
    ,	[FormularioStatusId] = @FORMULARIO_STATUS_ID
    ,	[DataVigenciaInicial] = GETDATE()
    ,	[DataVigenciaFinal] = DATEADD(year, 12, GETDATE()) 
    ,	[FormularioTipoId] = @FORMULARIO_TIPO_ID
    ,	[CadastroUsuarioId] = 1
    ,	[CadastroDataHora] = GETDATE()
    ,	[AtualizacaoUsuarioId] = NULL
    ,	[AtualizacaoDataHora] = NULL
    ;
    SET @FORMULARIO_ID = SCOPE_IDENTITY();
END
GO

SET IDENTITY_INSERT FormulariosTipos OFF --Habilita o IDENTITY
GO