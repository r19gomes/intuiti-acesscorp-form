using System.Collections.Generic;

namespace Acesscorp.Domains.Dtos.Formulario
{
    public class FormularioResponse : ResponseBase
    {
        #region Properties | Fields

        public IList<Formulario> Formulario { get; set; }

        #endregion

        #region Builders

        public FormularioResponse()
        {
            Formulario = new List<Formulario>();
        }

        #endregion
    }
}
