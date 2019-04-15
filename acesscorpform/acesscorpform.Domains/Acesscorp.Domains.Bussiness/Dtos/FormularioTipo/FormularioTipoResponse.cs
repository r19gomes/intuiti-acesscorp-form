using System.Collections.Generic;

namespace Acesscorp.Domains.Dtos.FormularioTipo
{
    public class FormularioTipoResponse : ResponseBase
    {
        #region Properties | Fields

        public IList<FormularioTipo> FormularioTipo { get; set; }

        #endregion

        #region Builders

        public FormularioTipoResponse()
        {
            FormularioTipo = new List<FormularioTipo>();
        }

        #endregion
    }
}
