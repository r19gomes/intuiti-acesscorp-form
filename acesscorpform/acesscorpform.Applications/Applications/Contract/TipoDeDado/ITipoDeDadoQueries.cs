using Acesscorp.Domains.Dtos.TipoDeDado;

namespace Acesscorp.Applications.Contract.TipoDeDado
{
    public interface ITipoDeDadoQueries
    {
        TipoDeDadoResponse GetAll();

        TipoDeDadoResponse Get(long id);
    }
}
