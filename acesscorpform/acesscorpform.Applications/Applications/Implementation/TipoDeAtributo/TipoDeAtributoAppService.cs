using Acesscorp.Applications.Contract.TipoDeAtributo;
using Acesscorp.Domains.Contracts.Services;
using Acesscorp.Domains.Dtos.TipoDeAtributo;
using System;

namespace Acesscorp.Applications.Implementation.TipoDeAtributo
{
    public class TipoDeAtributoAppService : ITipoDeAtributoAppService
    {
        #region Properties | Fields

        private readonly ITipoDeAtributoServices _tipoDeAtributoService;

        #endregion

        #region Builders

        public TipoDeAtributoAppService()
        {

        }

        public TipoDeAtributoAppService(ITipoDeAtributoServices tipoDeAtributoService) : base()
        {
            _tipoDeAtributoService = tipoDeAtributoService;
        }

        #endregion

        #region Methods

        public TipoDeAtributoResponse Get(Int64 id)
        {
            return _tipoDeAtributoService.Get(id);
        }

        public TipoDeAtributoResponse GetAll()
        {
            return _tipoDeAtributoService.GetAll();
        }

        public TipoDeAtributoResponse Insert(TipoDeAtributoRequest request)
        {
            return _tipoDeAtributoService.Insert(request);
        }

        public TipoDeAtributoResponse Update(TipoDeAtributoRequest request)
        {
            return _tipoDeAtributoService.Update(request);
        }

        public TipoDeAtributoResponse Delete(Int64 id)
        {
            return _tipoDeAtributoService.Delete(id);
        }

        #endregion
    }
}