using Acesscorp.Domains.Dtos.FormularioTipo;
using System;
using System.Collections.Generic;

namespace Acesscorp.Domains.Contracts.Repositories
{
    public interface IFormularioTipoRepositories
    {
        #region Methods

        IList<FormularioTipo> GetAll();

        FormularioTipo Get(Int64 id);

        FormularioTipo Insert(FormularioTipoRequest request);

        FormularioTipo Update(FormularioTipoRequest request);

        FormularioTipo Delete(Int64 id);

        #endregion
    }
}
