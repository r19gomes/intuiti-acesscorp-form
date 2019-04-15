using Acesscorp.Domains.Dtos.TipoDeDado;
using System;

namespace Acesscorp.Domains.Contracts.Services
{
    public interface ITipoDeDadoServices
    {
        #region Methods

        TipoDeDadoResponse GetAll();

        TipoDeDadoResponse Get(Int64 id);

        TipoDeDadoResponse Insert(TipoDeDadoRequest request);

        TipoDeDadoResponse Update(TipoDeDadoRequest request);

        #endregion
    }
}
