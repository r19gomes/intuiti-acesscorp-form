namespace Acesscorp.Domains.Dtos.TipoDeAtributo
{
    public class TipoDeAtributoRequest: RequestBase
    {
        #region Properties | Fields

        public TipoDeAtributo TipoDeAtributo { get; set; }

        #endregion

        #region Builders

        public TipoDeAtributoRequest()
        {
            TipoDeAtributo = new TipoDeAtributo();
        }

        #endregion
    }
}
