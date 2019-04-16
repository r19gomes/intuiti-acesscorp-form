using Acesscorp.Domains.Dtos.FormularioStatus;

namespace Acesscorp.Applications.Contract.FormularioStatus
{
    public interface IFormularioStatusCommand
    {
        FormularioStatusResponse Insert(FormularioStatusRequest request);

        FormularioStatusResponse Update(FormularioStatusRequest request);
    }
}
