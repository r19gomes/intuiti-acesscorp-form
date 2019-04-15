using Acesscorp.Domains.Dtos.FormularioTipo;
using System.Collections.Generic;

namespace Acesscorp.Domains.Contracts.Repositories
{
    public interface IFormularioTipoRepositories
    {
        #region Methods

        IList<FormularioTipo> GetAll();

        FormularioTipo Get(long id);

        FormularioTipo Insert(FormularioTipoRequest request);

        FormularioTipo Update(FormularioTipoRequest request);

        #endregion
    }
}
