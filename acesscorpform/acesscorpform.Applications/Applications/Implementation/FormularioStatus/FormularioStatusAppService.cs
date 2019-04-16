using Acesscorp.Applications.Contract.FormularioStatus;
using Acesscorp.Domains.Contracts.Services;
using Acesscorp.Domains.Dtos.FormularioStatus;

namespace Acesscorp.Applications.Implementation.FormularioStatus
{
    public class FormularioStatusAppService: IFormularioStatusAppService
    {
        #region Properties | Fields

        private readonly IFormularioStatusServices _formularioStatusService;

        #endregion

        #region Builders

        public FormularioStatusAppService()
        {

        }

        public FormularioStatusAppService(IFormularioStatusServices formularioStatusService) : base()
        {
            _formularioStatusService = formularioStatusService;
        }

        #endregion

        #region Methods

        public FormularioStatusResponse Get(long id)
        {
            return _formularioStatusService.Get(id);
        }

        public FormularioStatusResponse GetAll()
        {
            return _formularioStatusService.GetAll();
        }

        public FormularioStatusResponse Insert(FormularioStatusRequest request)
        {
            return _formularioStatusService.Insert(request);
        }

        public FormularioStatusResponse Update(FormularioStatusRequest request)
        {
            return _formularioStatusService.Update(request);
        }

        #endregion

    }
}
