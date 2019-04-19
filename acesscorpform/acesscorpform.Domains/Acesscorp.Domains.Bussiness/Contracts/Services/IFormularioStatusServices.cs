using Acesscorp.Domains.Dtos.FormularioStatus;
using System;

namespace Acesscorp.Domains.Contracts.Services
{
    public interface IFormularioStatusServices
    {
        #region Methods

        FormularioStatusResponse GetAll();

        FormularioStatusResponse Get(Int64 id);

        FormularioStatusResponse Insert(FormularioStatusRequest request);

        FormularioStatusResponse Update(FormularioStatusRequest request);

        FormularioStatusResponse Delete(Int64 id);

        #endregion
    }
}
