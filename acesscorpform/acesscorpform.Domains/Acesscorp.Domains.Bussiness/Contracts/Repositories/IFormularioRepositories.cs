using Acesscorp.Domains.Dtos.Formulario;
using System.Collections.Generic;

namespace Acesscorp.Domains.Contracts.Repositories
{
    public interface IFormularioRepositories
    {
        #region Methods

        IList<Formulario> GetAll();

        Formulario Get(long id);

        Formulario Insert(FormularioRequest request);

        Formulario Update(FormularioRequest request);

        #endregion
    }
}
