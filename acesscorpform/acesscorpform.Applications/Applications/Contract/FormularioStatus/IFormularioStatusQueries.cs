using Acesscorp.Domains.Dtos.FormularioStatus;

namespace Acesscorp.Applications.Contract.FormularioStatus
{
    public interface IFormularioStatusQueries
    {
        FormularioStatusResponse GetAll();

        FormularioStatusResponse Get(long id);
    }
}
