using Acesscorp.Domains.Dtos.FormularioStatus;
using System.Collections.Generic;

namespace Acesscorp.Domains.Contracts.Repositories
{
    public interface IFormularioStatusRepositories
    {
        #region Methods

        IList<FormularioStatus> GetAll();

        FormularioStatus Get(long id);

        FormularioStatus Insert(FormularioStatusRequest request);

        FormularioStatus Update(FormularioStatusRequest request);

        #endregion
    }
}
