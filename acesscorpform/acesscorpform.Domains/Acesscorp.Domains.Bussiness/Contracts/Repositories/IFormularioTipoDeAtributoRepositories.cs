using Acesscorp.Domains.Dtos.FormularioTipoDeAtributo;
using System;
using System.Collections.Generic;

namespace Acesscorp.Domains.Contracts.Repositories
{
    public interface IFormularioTipoDeAtributoRepositories
    {
        #region Methods

        IList<FormularioTipoDeAtributo> GetAll();

        FormularioTipoDeAtributo Get(Int64 id);

        FormularioTipoDeAtributo Insert(FormularioTipoDeAtributoRequest request);

        FormularioTipoDeAtributo Update(FormularioTipoDeAtributoRequest request);

        FormularioTipoDeAtributo Delete(Int64 id);

        #endregion
    }
}
