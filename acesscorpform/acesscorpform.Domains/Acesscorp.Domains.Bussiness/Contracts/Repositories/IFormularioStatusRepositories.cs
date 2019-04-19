using Acesscorp.Domains.Dtos.FormularioStatus;
using System;
using System.Collections.Generic;

namespace Acesscorp.Domains.Contracts.Repositories
{
    public interface IFormularioStatusRepositories
    {
        #region Methods

        IList<FormularioStatus> GetAll();

        FormularioStatus Get(Int64 id);

        FormularioStatus Insert(FormularioStatusRequest request);

        FormularioStatus Update(FormularioStatusRequest request);

        FormularioStatus Delete(Int64 id);

        #endregion
    }
}
