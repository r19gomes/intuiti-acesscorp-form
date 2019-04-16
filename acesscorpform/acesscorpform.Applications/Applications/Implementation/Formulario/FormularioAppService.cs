using Acesscorp.Applications.Contract.Formulario;
using Acesscorp.Domains.Contracts.Services;
using Acesscorp.Domains.Dtos.Formulario;

namespace Acesscorp.Applications.Implementation.Formulario
{
    public class FormularioAppService: IFormularioAppService
    {
        #region Properties | Fields

        private readonly IFormularioServices _formularioService;

        #endregion

        #region Builders

        public FormularioAppService()
        {

        }

        public FormularioAppService(IFormularioServices formularioService) : base()
        {
            _formularioService = formularioService;
        }

        #endregion

        #region Methods

        public FormularioResponse Get(long id)
        {
            return _formularioService.Get(id);
        }

        public FormularioResponse GetAll()
        {
            return _formularioService.GetAll();
        }

        public FormularioResponse Insert(FormularioRequest request)
        {
            return _formularioService.Insert(request);
        }

        public FormularioResponse Update(FormularioRequest request)
        {
            return _formularioService.Update(request);
        }

        #endregion

    }
}
