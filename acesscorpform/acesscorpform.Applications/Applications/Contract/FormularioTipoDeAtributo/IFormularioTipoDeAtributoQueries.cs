using Acesscorp.Domains.Dtos.FormularioTipoDeAtributo;
using System;

namespace Acesscorp.Applications.Contract.FormularioTipoDeAtributo
{
    public interface IFormularioTipoDeAtributoQueries
    {
        FormularioTipoDeAtributoResponse GetAll();

        FormularioTipoDeAtributoResponse Get(Int64 id);
    }
}