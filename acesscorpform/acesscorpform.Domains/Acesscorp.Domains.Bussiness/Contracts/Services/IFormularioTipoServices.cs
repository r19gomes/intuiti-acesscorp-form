using Acesscorp.Domains.Dtos.FormularioTipo;
using System;

namespace Acesscorp.Domains.Contracts.Services
{
    public interface IFormularioTipoServices
    {
        #region Methods

        FormularioTipoResponse GetAll();

        FormularioTipoResponse Get(Int64 id);

        FormularioTipoResponse Insert(FormularioTipoRequest request);

        FormularioTipoResponse Update(FormularioTipoRequest request);

        FormularioTipoResponse Delete(Int64 id);

        #endregion
    }
}
