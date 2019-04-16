using Acesscorp.Domains.Dtos.TipoDeDado;

namespace Acesscorp.Applications.Contract.TipoDeDado
{
    public interface ITipoDeDadoCommand
    {
        TipoDeDadoResponse Insert(TipoDeDadoRequest request);

        TipoDeDadoResponse Update(TipoDeDadoRequest request);
    }
}
