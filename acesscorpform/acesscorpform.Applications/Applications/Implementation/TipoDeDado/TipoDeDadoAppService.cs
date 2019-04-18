using Acesscorp.Applications.Contract.TipoDeDado;
using Acesscorp.Domains.Contracts.Services;
using Acesscorp.Domains.Dtos.TipoDeDado;
using System;

namespace Acesscorp.Applications.Implementation.TipoDeDado
{
    public class TipoDeDadoAppService: ITipoDeDadoAppService
    {
        #region Properties | Fields

        private readonly ITipoDeDadoServices _tipoDeDadoService;

        #endregion

        #region Builders

        public TipoDeDadoAppService()
        {

        }

        public TipoDeDadoAppService(ITipoDeDadoServices tipoDeDadoService) : base()
        {
            _tipoDeDadoService = tipoDeDadoService;
        }

        #endregion

        #region Methods

        public TipoDeDadoResponse Get(Int64 id)
        {
            return _tipoDeDadoService.Get(id);
        }

        public TipoDeDadoResponse GetAll()
        {
            return _tipoDeDadoService.GetAll();
        }

        public TipoDeDadoResponse Insert(TipoDeDadoRequest request)
        {
            return _tipoDeDadoService.Insert(request);
        }

        public TipoDeDadoResponse Update(TipoDeDadoRequest request)
        {
            return _tipoDeDadoService.Update(request);
        }

        public TipoDeDadoResponse Delete(Int64 id)
        {
            return _tipoDeDadoService.Delete(id);
        }

        #endregion

    }
}
