using Acesscorp.Domains.Dtos.Formulario;

namespace Acesscorp.Applications.Contract.Formulario
{
    public interface IFormularioQueries
    {
        FormularioResponse GetAll();

        FormularioResponse Get(long id);
    }
}
