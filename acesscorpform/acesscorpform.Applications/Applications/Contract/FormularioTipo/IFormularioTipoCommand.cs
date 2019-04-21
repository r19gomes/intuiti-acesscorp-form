using Acesscorp.Domains.Dtos.FormularioTipo;
using System;

namespace Acesscorp.Applications.Contract.FormularioTipo
{
    public interface IFormularioTipoCommand
    {
        FormularioTipoResponse Insert(FormularioTipoRequest request);

        FormularioTipoResponse Update(FormularioTipoRequest request);

        FormularioTipoResponse Delete(Int64 id);
    }
}
