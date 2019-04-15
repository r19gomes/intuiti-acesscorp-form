namespace Acesscorp.Domains.Dtos.FormularioStatus
{
    public class FormularioStatusRequest : RequestBase
    {
        #region Properties | Fields

        public FormularioStatus FormularioStatus { get; set; }

        #endregion

        #region Builders

        public FormularioStatusRequest()
        {
            FormularioStatus = new FormularioStatus();
        }

        #endregion
    }
}
