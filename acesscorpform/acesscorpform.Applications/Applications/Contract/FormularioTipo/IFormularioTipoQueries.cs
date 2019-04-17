using Acesscorp.Domains.Dtos.FormularioTipo;
using System;

namespace Acesscorp.Applications.Contract.FormularioTipo
{
    public interface IFormularioTipoQueries
    {
        FormularioTipoResponse GetAll();

        FormularioTipoResponse Get(Int64 id);
    }
}
