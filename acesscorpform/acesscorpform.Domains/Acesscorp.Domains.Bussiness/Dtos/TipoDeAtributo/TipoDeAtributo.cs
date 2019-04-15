namespace Acesscorp.Domains.Dtos.TipoDeAtributo
{
    public class TipoDeAtributo: Base
    {
        #region Properties | Fields

        public long TipoDeAtributoId { get; set; }

        public string Nome { get; set; }

        public string Apelido { get; set; }

        public string Descricao { get; set; }

        public string NomeFisico { get; set; }

        public long TipoDeDadoId { get; set; }

        public int OrdemExibicao { get; set; }

        public bool Limitador { get; set; }

        public bool Qualificador { get; set; }

        #endregion

        #region Builders

        public TipoDeAtributo(Base dto = null) : base(dto) { }

        public TipoDeAtributo(TipoDeAtributo tipoDeAtributo)
        {
            TipoDeAtributoId = tipoDeAtributo.TipoDeAtributoId;
            Nome = tipoDeAtributo.Nome;
            Apelido = tipoDeAtributo.Apelido;
            Descricao = tipoDeAtributo.Descricao;
            NomeFisico = tipoDeAtributo.NomeFisico;
            TipoDeDadoId = tipoDeAtributo.TipoDeDadoId;
            FlagStatus = tipoDeAtributo.FlagStatus;
            OrdemExibicao = tipoDeAtributo.OrdemExibicao;
            Limitador = tipoDeAtributo.Limitador;
            Qualificador = tipoDeAtributo.Qualificador;
            CadastroUsuarioId = tipoDeAtributo.CadastroUsuarioId;
            CadastroDataHora = tipoDeAtributo.CadastroDataHora;
            AtualizacaoUsuarioId = tipoDeAtributo.AtualizacaoUsuarioId;
            AtualizacaoDataHora = tipoDeAtributo.AtualizacaoDataHora;
        }

        #endregion
    }
}
