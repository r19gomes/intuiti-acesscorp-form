using System.Collections.Generic;

namespace Acesscorp.Domains.Dtos.FormularioTipoDeAtributo
{
    public class FormularioTipoDeAtributoResponse : ResponseBase
    {
        #region Properties | Fields

        public IList<FormularioTipoDeAtributo> FormularioTipoDeAtributo { get; set; }

        #endregion

        #region Builders

        public FormularioTipoDeAtributoResponse()
        {
            FormularioTipoDeAtributo = new List<FormularioTipoDeAtributo>();
        }

        #endregion
    }
}
