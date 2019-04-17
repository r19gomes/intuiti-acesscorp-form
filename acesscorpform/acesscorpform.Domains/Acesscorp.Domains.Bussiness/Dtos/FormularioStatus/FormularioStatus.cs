using System;

namespace Acesscorp.Domains.Dtos.FormularioStatus
{
    public class FormularioStatus: Base
    {
        #region Properties | Fields

        public Int64 FormularioStatusId { get; set; }

        public string Nome { get; set; }

        #endregion

        #region Builders

        public FormularioStatus(Base dto = null) : base(dto) { }

        public FormularioStatus(FormularioStatus tipoDeDado)
        {
            FormularioStatusId = tipoDeDado.FormularioStatusId;
            Nome = tipoDeDado.Nome;
            FlagStatus = tipoDeDado.FlagStatus;
            CadastroUsuarioId = tipoDeDado.CadastroUsuarioId;
            CadastroDataHora = tipoDeDado.CadastroDataHora;
            AtualizacaoUsuarioId = tipoDeDado.AtualizacaoUsuarioId;
            AtualizacaoDataHora = tipoDeDado.AtualizacaoDataHora;
        }

        #endregion
    }
}
