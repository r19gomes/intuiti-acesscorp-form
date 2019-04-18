using Acesscorp.Domains.Dtos.TipoDeDado;
using System;
using System.Collections.Generic;

namespace Acesscorp.Domains.Contracts.Repositories
{
    public interface ITipoDeDadoRepositories
    {
        #region Methods

        IList<TipoDeDado> GetAll();

        TipoDeDado Get(Int64 id);

        TipoDeDado Insert(TipoDeDadoRequest request);

        TipoDeDado Update(TipoDeDadoRequest request);

        TipoDeDado Delete(Int64 id);

        #endregion
    }
}
