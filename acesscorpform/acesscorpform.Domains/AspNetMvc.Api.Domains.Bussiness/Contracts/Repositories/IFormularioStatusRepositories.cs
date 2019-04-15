using Acesscorp.Domains.Dtos.FormularioStatus;
using System.Collections.Generic;

namespace Acesscorp.Domains.Contraects.Repositories
{
    public interface IFormularioStatus
    {
        #region Methods

        IList<FormularioStatus> GetAll();

        FormularioStatus Get(long id);

        FormularioStatus Insert(FormularioStatusRequest request);

        FormularioStatus Update(FormularioStatusRequest request);

        #endregion
    }
}
