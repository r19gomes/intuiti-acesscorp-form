using Acesscorp.Domains.Dtos.FormularioTipoDeAtributo;
using System.Collections.Generic;

namespace Acesscorp.Domains.Contracts.Repositories
{
    public interface IFormularioTipoDeAtributoRepositories
    {
        #region Methods

        IList<FormularioTipoDeAtributo> GetAll();

        FormularioTipoDeAtributo Get(long id);

        FormularioTipoDeAtributo Insert(FormularioTipoDeAtributoRequest request);

        FormularioTipoDeAtributo Update(FormularioTipoDeAtributoRequest request);

        #endregion
    }
}
