namespace Acesscorp.Domains.Dtos.TipoDeDado
{
    public class TipoDeDadoRequest: RequestBase
    {
        #region Properties | Fields

        public TipoDeDado TipoDeDado { get; set; }

        #endregion

        #region Builders

        public TipoDeDadoRequest()
        {
            TipoDeDado = new TipoDeDado();
        }

        #endregion
    }
}
