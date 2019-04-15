using Acesscorp.Domains.Dtos.Formulario;
using System;

namespace Acesscorp.Domains.Contracts.Services
{
    public interface IFormularioServices
    {
        #region Methods

        FormularioResponse GetAll();

        FormularioResponse Get(Int64 id);

        FormularioResponse Insert(FormularioRequest request);

        FormularioResponse Update(FormularioRequest request);

        #endregion
    }
}
