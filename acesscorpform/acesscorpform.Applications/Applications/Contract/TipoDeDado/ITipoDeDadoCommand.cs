using Acesscorp.Domains.Dtos.TipoDeDado;
using System;

namespace Acesscorp.Applications.Contract.TipoDeDado
{
    public interface ITipoDeDadoCommand
    {
        TipoDeDadoResponse Insert(TipoDeDadoRequest request);

        TipoDeDadoResponse Update(TipoDeDadoRequest request);

        TipoDeDadoResponse Delete(Int64 id);
    }
}
