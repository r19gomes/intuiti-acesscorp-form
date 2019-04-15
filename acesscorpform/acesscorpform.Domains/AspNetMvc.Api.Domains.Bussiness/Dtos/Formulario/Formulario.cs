using System;

namespace Acesscorp.Domains.Dtos.Formulario
{
    public class Formulario: Base
    {
        #region

        public long FormularioId { get; set; }

        public string Nome { get; set; }

        public string Apelido { get; set; }

        public long FormularioStatusId { get; set; }

        public DateTime DataVigenciaInicial { get; set; }

        public DateTime DataVigenciaFinal { get; set; }

        public long FormularioTipoId { get; set; }

        #endregion

        #region Builders

        public Formulario(Base dto = null) : base(dto) { }

        public Formulario(Formulario formulario)
        {
            FormularioId = formulario.FormularioId;
            Nome = formulario.Nome;
            Apelido = formulario.Apelido;
            FormularioStatusId = formulario.FormularioStatusId;
            DataVigenciaInicial = formulario.DataVigenciaInicial;
            DataVigenciaFinal = formulario.DataVigenciaFinal;
            FormularioTipoId = formulario.FormularioTipoId;
            FlagStatus = formulario.FlagStatus;
            CadastroUsuarioId = formulario.CadastroUsuarioId;
            CadastroDataHora = formulario.CadastroDataHora;
            AtualizacaoUsuarioId = formulario.AtualizacaoUsuarioId;
            AtualizacaoDataHora = formulario.AtualizacaoDataHora;
        }

        #endregion
    }
}
