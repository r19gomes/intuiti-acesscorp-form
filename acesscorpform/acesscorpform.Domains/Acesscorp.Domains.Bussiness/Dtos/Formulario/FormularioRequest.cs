namespace Acesscorp.Domains.Dtos.Formulario
{
    public class FormularioRequest : RequestBase
    {
        #region Properties | Fields

        public Formulario Formulario { get; set; }

        #endregion

        #region Builders

        public FormularioRequest()
        {
            Formulario = new Formulario();
        }

        #endregion
    }
}
