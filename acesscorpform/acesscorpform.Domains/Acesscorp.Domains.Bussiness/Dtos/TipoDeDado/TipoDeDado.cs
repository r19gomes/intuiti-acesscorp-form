using System;

namespace Acesscorp.Domains.Dtos.TipoDeDado
{
    public class TipoDeDado: Base
    {
        #region Properties | Fields
        
        public Int64 TipoDeDadoId { get; set; }

        public string Nome { get; set; }

        #endregion

        #region Builders

        public TipoDeDado(Base dto = null) : base(dto) { }

        public TipoDeDado(TipoDeDado tipoDeDado)
        {
            TipoDeDadoId = tipoDeDado.TipoDeDadoId;
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
