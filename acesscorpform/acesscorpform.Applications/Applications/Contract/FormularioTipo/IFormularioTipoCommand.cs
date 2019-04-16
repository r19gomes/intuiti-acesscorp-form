using Acesscorp.Domains.Dtos.FormularioTipo;

namespace Acesscorp.Applications.Contract.FormularioTipo
{
    public interface IFormularioTipoCommand
    {
        FormularioTipoResponse Insert(FormularioTipoRequest request);

        FormularioTipoResponse Update(FormularioTipoRequest request);
    }
}
