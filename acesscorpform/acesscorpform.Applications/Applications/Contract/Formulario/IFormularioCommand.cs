using Acesscorp.Domains.Dtos.Formulario;

namespace Acesscorp.Applications.Contract.Formulario
{
    public interface IFormularioCommand
    {
        FormularioResponse Insert(FormularioRequest request);

        FormularioResponse Update(FormularioRequest request);
    }
}
