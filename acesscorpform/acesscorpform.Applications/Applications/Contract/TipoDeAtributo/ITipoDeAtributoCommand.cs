using Acesscorp.Domains.Dtos.TipoDeAtributo;
using System;

namespace Acesscorp.Applications.Contract.TipoDeAtributo
{
    public interface ITipoDeAtributoCommand
    {
        TipoDeAtributoResponse Insert(TipoDeAtributoRequest request);

        TipoDeAtributoResponse Update(TipoDeAtributoRequest request);

        TipoDeAtributoResponse Delete(Int64 id);
    }
}
