using System.Collections.Generic;

namespace Acesscorp.Domains.Dtos.TipoDeDado
{
    public class TipoDeDadoResponse: ResponseBase
    {
        #region Properties | Fields

        public IList<TipoDeDado> TipoDeDado { get; set; }

        #endregion

        #region Builders

        public TipoDeDadoResponse()
        {
            TipoDeDado = new List<TipoDeDado>();
        }

        #endregion
    }
}
