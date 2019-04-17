using Acesscorp.Domains.Dtos.FormularioStatus;
using System;

namespace Acesscorp.Applications.Contract.FormularioStatus
{
    public interface IFormularioStatusQueries
    {
        FormularioStatusResponse GetAll();

        FormularioStatusResponse Get(Int64 id);
    }
}
