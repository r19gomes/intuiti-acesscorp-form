using Acesscorp.Domains.Dtos.FormularioTipoDeAtributo;

namespace Acesscorp.Applications.Contract.FormularioTipoDeAtributo
{
    public interface IFormularioTipoDeAtributoCommand
    {
        FormularioTipoDeAtributoResponse Insert(FormularioTipoDeAtributoRequest request);

        FormularioTipoDeAtributoResponse Update(FormularioTipoDeAtributoRequest request);
    }
}
