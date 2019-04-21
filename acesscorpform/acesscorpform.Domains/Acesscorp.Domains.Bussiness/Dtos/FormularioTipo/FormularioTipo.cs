using System;

namespace Acesscorp.Domains.Dtos.FormularioTipo
{
    public class FormularioTipo: Base
    {
        #region Properties | Fields

        public Int64 FormularioTipoId { get; set; }

        public string Nome { get; set; }

        public string Apelido { get; set; }

        #endregion

        #region Builders

        public FormularioTipo(Base dto = null) : base(dto) { }

        public FormularioTipo(FormularioTipo formularioTipo)
        {
            FormularioTipoId = formularioTipo.FormularioTipoId;
            Nome = formularioTipo.Nome;
            Apelido = formularioTipo.Apelido;
            FlagStatus = formularioTipo.FlagStatus;
            CadastroUsuarioId = formularioTipo.CadastroUsuarioId;
            CadastroDataHora = formularioTipo.CadastroDataHora;
            AtualizacaoUsuarioId = formularioTipo.AtualizacaoUsuarioId;
            AtualizacaoDataHora = formularioTipo.AtualizacaoDataHora;
        }

        #endregion
    }
}
