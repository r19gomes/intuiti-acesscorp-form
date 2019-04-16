using Acesscorp.Domains.Dtos.FormularioTipoDeAtributo;

namespace Acesscorp.Applications.Contract.FormularioTipoDeAtributo
{
    public interface IFormularioTipoDeAtributoQueries
    {
        FormularioTipoDeAtributoResponse GetAll();

        FormularioTipoDeAtributoResponse Get(long id);
    }
}
