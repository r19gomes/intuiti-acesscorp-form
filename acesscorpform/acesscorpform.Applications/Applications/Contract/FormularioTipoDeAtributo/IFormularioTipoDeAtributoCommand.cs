using Acesscorp.Domains.Dtos.FormularioTipoDeAtributo;
using System;

namespace Acesscorp.Applications.Contract.FormularioTipoDeAtributo
{
    public interface IFormularioTipoDeAtributoCommand
    {
        FormularioTipoDeAtributoResponse Insert(FormularioTipoDeAtributoRequest request);

        FormularioTipoDeAtributoResponse Update(FormularioTipoDeAtributoRequest request);

        FormularioTipoDeAtributoResponse Delete(Int64 id);
    }
}
