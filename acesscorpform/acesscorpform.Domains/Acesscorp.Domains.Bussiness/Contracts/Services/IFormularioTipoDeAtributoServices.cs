using Acesscorp.Domains.Dtos.FormularioTipoDeAtributo;
using System;

namespace Acesscorp.Domains.Contracts.Services
{
    public interface IFormularioTipoDeAtributoServices
    {
        #region Methods

        FormularioTipoDeAtributoResponse GetAll();

        FormularioTipoDeAtributoResponse Get(Int64 id);

        FormularioTipoDeAtributoResponse Insert(FormularioTipoDeAtributoRequest request);

        FormularioTipoDeAtributoResponse Update(FormularioTipoDeAtributoRequest request);

        FormularioTipoDeAtributoResponse Delete(Int64 id);

        #endregion
    }
}
