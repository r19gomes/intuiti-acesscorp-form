using Acesscorp.Domains.Dtos.TipoDeAtributo;
using System;

namespace Acesscorp.Domains.Contracts.Services
{
    public interface ITipoDeAtributoServices
    {
        #region Methods

        TipoDeAtributoResponse GetAll();

        TipoDeAtributoResponse Get(Int64 id);

        TipoDeAtributoResponse Insert(TipoDeAtributoRequest request);

        TipoDeAtributoResponse Update(TipoDeAtributoRequest request);

        TipoDeAtributoResponse Delete(Int64 id);

        #endregion
    }
}
