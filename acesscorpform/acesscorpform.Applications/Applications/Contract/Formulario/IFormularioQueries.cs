using Acesscorp.Domains.Dtos.Formulario;
using System;

namespace Acesscorp.Applications.Contract.Formulario
{
    public interface IFormularioQueries
    {
        FormularioResponse GetAll();

        FormularioResponse Get(Int64 id);
    }
}
