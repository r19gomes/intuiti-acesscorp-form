using Acesscorp.Domains.Dtos.TipoDeAtributo;
using System;
using System.Collections.Generic;

namespace Acesscorp.Domains.Contracts.Repositories
{
    public interface ITipoDeAtributoRepositories
    {
        #region Methods

        IList<TipoDeAtributo> GetAll();

        TipoDeAtributo Get(Int64 id);

        TipoDeAtributo Insert(TipoDeAtributoRequest request);

        TipoDeAtributo Update(TipoDeAtributoRequest request);

        TipoDeAtributo Delete(Int64 id);

        #endregion
    }
}
