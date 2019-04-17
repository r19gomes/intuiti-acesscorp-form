using Acesscorp.Domains.Dtos.TipoDeDado;
using System;

namespace Acesscorp.Applications.Contract.TipoDeDado
{
    public interface ITipoDeDadoQueries
    {
        TipoDeDadoResponse GetAll();

        TipoDeDadoResponse Get(Int64 id);
    }
}
