using Acesscorp.Domains.Dtos.Formulario;
using System;
using System.Collections.Generic;

namespace Acesscorp.Domains.Contracts.Repositories
{
    public interface IFormularioRepositories
    {
        #region Methods

        IList<Formulario> GetAll();

        Formulario Get(Int64 id);

        Formulario Insert(FormularioRequest request);

        Formulario Update(FormularioRequest request);

        Formulario Delete(Int64 id);

        #endregion
    }
}
