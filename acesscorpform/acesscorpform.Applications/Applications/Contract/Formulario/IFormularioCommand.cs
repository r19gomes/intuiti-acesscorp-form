using Acesscorp.Domains.Dtos.Formulario;
using System;

namespace Acesscorp.Applications.Contract.Formulario
{
    public interface IFormularioCommand
    {
        FormularioResponse Insert(FormularioRequest request);

        FormularioResponse Update(FormularioRequest request);

        FormularioResponse Delete(Int64 id);
    }
}
