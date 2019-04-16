using Acesscorp.Applications.Contract.FormularioTipoDeAtributo;
using Acesscorp.Domains.Contracts.Services;
using Acesscorp.Domains.Dtos.FormularioTipoDeAtributo;

namespace Acesscorp.Applications.Implementation.FormularioTipoDeAtributo
{
    public class FormularioTipoDeAtributoAppService: IFormularioTipoDeAtributoAppService
    {
        #region Properties | Fields

        private readonly IFormularioTipoDeAtributoServices _formularioTipoDeAtributoService;

        #endregion

        #region Builders

        public FormularioTipoDeAtributoAppService()
        {

        }

        public FormularioTipoDeAtributoAppService(IFormularioTipoDeAtributoServices formularioTipoDeAtributoService) : base()
        {
            _formularioTipoDeAtributoService = formularioTipoDeAtributoService;
        }

        #endregion

        #region Methods

        public FormularioTipoDeAtributoResponse Get(long id)
        {
            return _formularioTipoDeAtributoService.Get(id);
        }

        public FormularioTipoDeAtributoResponse GetAll()
        {
            return _formularioTipoDeAtributoService.GetAll();
        }

        public FormularioTipoDeAtributoResponse Insert(FormularioTipoDeAtributoRequest request)
        {
            return _formularioTipoDeAtributoService.Insert(request);
        }

        public FormularioTipoDeAtributoResponse Update(FormularioTipoDeAtributoRequest request)
        {
            return _formularioTipoDeAtributoService.Update(request);
        }

        #endregion

    }
}
