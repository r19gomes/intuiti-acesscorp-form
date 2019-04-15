using System.Collections.Generic;

namespace Acesscorp.Domains.Dtos.TipoDeAtributo
{
    public class TipoDeAtributoResponse: ResponseBase
    {
        #region Properties | Fields

        public IList<TipoDeAtributo> TipoDeAtributo { get; set; }

        #endregion

        #region Builders

        public TipoDeAtributoResponse()
        {
            TipoDeAtributo = new List<TipoDeAtributo>();
        }

        #endregion
    }
}
