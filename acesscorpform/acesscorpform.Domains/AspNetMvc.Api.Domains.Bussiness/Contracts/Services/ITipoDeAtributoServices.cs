using Acesscorp.Domains.Dtos.TipoDeAtributo;

namespace Acesscorp.Domains.Contracts.Services
{
    public interface ITipoDeAtributoServices
    {
        #region Methods

        TipoDeAtributoResponse GetAll();

        TipoDeAtributoResponse Get(long id);

        TipoDeAtributoResponse Insert(TipoDeAtributoRequest request);

        TipoDeAtributoResponse Update(TipoDeAtributoRequest request);

        #endregion
    }
}
