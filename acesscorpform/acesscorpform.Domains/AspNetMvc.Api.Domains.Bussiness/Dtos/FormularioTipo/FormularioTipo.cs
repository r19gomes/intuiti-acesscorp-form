namespace Acesscorp.Domains.Dtos.FormularioTipo
{
    public class FormularioTipo: Base
    {
        #region Properties | Fields

        public long FormularioTipoId { get; set; }

        public string Nome { get; set; }

        public string Apelido { get; set; }

        #endregion

        #region Builders

        public FormularioTipo(Base dto = null) : base(dto) { }

        public FormularioTipo(FormularioTipo formularioTipo)
        {
            FormularioTipoId = formularioTipo.FormularioTipoId;
            Nome = formularioTipo.Nome;
            FlagStatus = formularioTipo.FlagStatus;
            CadastroUsuarioId = formularioTipo.CadastroUsuarioId;
            CadastroDataHora = formularioTipo.CadastroDataHora;
            AtualizacaoUsuarioId = formularioTipo.AtualizacaoUsuarioId;
            AtualizacaoDataHora = formularioTipo.AtualizacaoDataHora;
        }

        #endregion
    }
}
