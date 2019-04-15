using Acesscorp.Domains.Dtos.TipoDeAtributo;
using System.Collections.Generic;

namespace Acesscorp.Domains.Contracts.Repositories
{
    public interface ITipoDeAtributoRepositories
    {
        #region Methods

        IList<TipoDeAtributo> GetAll();

        TipoDeAtributo Get(long id);

        TipoDeAtributo Insert(TipoDeAtributoRequest request);

        TipoDeAtributo Update(TipoDeAtributoRequest request);

        #endregion
    }
}
