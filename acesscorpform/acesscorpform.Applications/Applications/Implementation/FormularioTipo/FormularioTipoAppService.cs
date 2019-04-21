using Acesscorp.Applications.Contract.FormularioTipo;
using Acesscorp.Domains.Contracts.Services;
using Acesscorp.Domains.Dtos.FormularioTipo;
using System;

namespace Acesscorp.Applications.Implementation.FormularioTipo
{
    public class FormularioTipoAppService: IFormularioTipoAppService
    {
        #region Properties | Fields

        private readonly IFormularioTipoServices _formularioTipoService;

        #endregion

        #region Builders

        public FormularioTipoAppService()
        {

        }

        public FormularioTipoAppService(IFormularioTipoServices formularioTipoService) : base()
        {
            _formularioTipoService = formularioTipoService;
        }

        #endregion

        #region Methods

        public FormularioTipoResponse Get(Int64 id)
        {
            return _formularioTipoService.Get(id);
        }

        public FormularioTipoResponse GetAll()
        {
            return _formularioTipoService.GetAll();
        }

        public FormularioTipoResponse Insert(FormularioTipoRequest request)
        {
            return _formularioTipoService.Insert(request);
        }

        public FormularioTipoResponse Update(FormularioTipoRequest request)
        {
            return _formularioTipoService.Update(request);
        }

        public FormularioTipoResponse Delete(Int64 id)
        {
            return _formularioTipoService.Delete(id);
        }

        #endregion

    }
}
