using System.Collections.Generic;

namespace Acesscorp.Domains.Dtos.FormularioStatus
{
    public class FormularioStatusResponse : ResponseBase
    {
        #region Properties | Fields

        public IList<FormularioStatus> FormularioStatus { get; set; }

        #endregion

        #region Builders

        public FormularioStatusResponse()
        {
            FormularioStatus = new List<FormularioStatus>();
        }

        #endregion
    }
}
