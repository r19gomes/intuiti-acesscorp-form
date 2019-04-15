using Acesscorp.Domains.Dtos.TipoDeDado;
using System.Collections.Generic;

namespace Acesscorp.Domains.Contracts.Repositories
{
    public interface ITipoDeDadoRepositories
    {
        #region Methods

        IList<TipoDeDado> GetAll();

        TipoDeDado Get(long id);

        TipoDeDado Insert(TipoDeDadoRequest request);

        TipoDeDado Update(TipoDeDadoRequest request);

        #endregion
    }
}
