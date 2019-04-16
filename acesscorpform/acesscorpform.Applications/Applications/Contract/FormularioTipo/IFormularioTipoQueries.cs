using Acesscorp.Domains.Dtos.FormularioTipo;

namespace Acesscorp.Applications.Contract.FormularioTipo
{
    public interface IFormularioTipoQueries
    {
        FormularioTipoResponse GetAll();

        FormularioTipoResponse Get(long id);
    }
}
