namespace Acesscorp.Domains.Dtos.FormularioTipo
{
    public class FormularioTipoRequest: RequestBase
    {
        #region Properties | Fields

        public FormularioTipo FormularioTipo { get; set; }

        #endregion

        #region Builders

        public FormularioTipoRequest()
        {
            FormularioTipo = new FormularioTipo();
        }

        #endregion
    }
}
