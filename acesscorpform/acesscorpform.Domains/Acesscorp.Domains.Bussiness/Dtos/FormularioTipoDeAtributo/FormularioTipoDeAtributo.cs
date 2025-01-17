﻿using System;

namespace Acesscorp.Domains.Dtos.FormularioTipoDeAtributo
{
    public class FormularioTipoDeAtributo: Base
    {
        #region Properties | Fields

        public Int64 FormularioTipoDeAtributoId { get; set; }

        public Int64 FormularioId { get; set; }

        public Int64 TipoDeAtributoId { get; set; }

        public string Observacao { get; set; }

        #endregion

        #region Builders

        public FormularioTipoDeAtributo(Base dto = null) : base(dto) { }

        public FormularioTipoDeAtributo(FormularioTipoDeAtributo formularioTipoDeAtributo)
        {
            FormularioTipoDeAtributoId = formularioTipoDeAtributo.FormularioTipoDeAtributoId;
            FormularioId = formularioTipoDeAtributo.FormularioId;
            TipoDeAtributoId = formularioTipoDeAtributo.TipoDeAtributoId;
            Observacao = formularioTipoDeAtributo.Observacao;
            FlagStatus = formularioTipoDeAtributo.FlagStatus;
            CadastroUsuarioId = formularioTipoDeAtributo.CadastroUsuarioId;
            CadastroDataHora = formularioTipoDeAtributo.CadastroDataHora;
            AtualizacaoUsuarioId = formularioTipoDeAtributo.AtualizacaoUsuarioId;
            AtualizacaoDataHora = formularioTipoDeAtributo.AtualizacaoDataHora;
        }

        #endregion
    }
}
