using Acesscorp.Domains.Dtos.TipoDeAtributo;
using System;

namespace Acesscorp.Applications.Contract.TipoDeAtributo
{
    public interface ITipoDeAtributoQueries
    {
        TipoDeAtributoResponse GetAll();

        TipoDeAtributoResponse Get(Int64 id);
    }
}
