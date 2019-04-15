using Acesscorp.Domains.Contracts.Repositories;
using Acesscorp.Domains.Contracts.Services;
using Acesscorp.Domains.Dtos.TipoDeAtributo;
using System;
using System.Collections.Generic;

namespace Acesscorp.Domains.Services
{
    public class TipoDeAtributoServices : ITipoDeAtributoServices
    {
        #region Properties | Fields

        private readonly ITipoDeAtributoRepositories _tipoDeAtributoRepositories;

        #endregion

        #region Builders

        public TipoDeAtributoServices()
        {

        }

        public TipoDeAtributoServices(ITipoDeAtributoRepositories tipoDeAtributoRepositories) : base()
        {
            _tipoDeAtributoRepositories = tipoDeAtributoRepositories;
        }

        #endregion

        #region Methods

        public TipoDeAtributoResponse Get(long id)
        {
            var response = new TipoDeAtributoResponse();

            var result = _tipoDeAtributoRepositories.Get(id);
            IList<TipoDeAtributo> tipoDeAtributo = new List<TipoDeAtributo>()
            {
                new TipoDeAtributo(result)
            };

            response.TipoDeAtributo = tipoDeAtributo;
            response.Success = true;

            return response;
        }

        public TipoDeAtributoResponse GetAll()
        {
            var response = new TipoDeAtributoResponse();

            IList<TipoDeAtributo> tipoDeAtributo;
            tipoDeAtributo = _tipoDeAtributoRepositories.GetAll();

            response.TipoDeAtributo = tipoDeAtributo;
            response.Success = true;

            return response;
        }

        public TipoDeAtributoResponse Insert(TipoDeAtributoRequest request)
        {
            var response = new TipoDeAtributoResponse();

            var result = _tipoDeAtributoRepositories.Insert(request);
            IList<TipoDeAtributo> tipoDeAtributo = new List<TipoDeAtributo>()
            {
                new TipoDeAtributo(result)
            };

            response.TipoDeAtributo = tipoDeAtributo;
            response.Success = true;

            return response;
        }

        public TipoDeAtributoResponse Update(TipoDeAtributoRequest request)
        {
            var response = new TipoDeAtributoResponse();

            var result = _tipoDeAtributoRepositories.Update(request);
            IList<TipoDeAtributo> tipoDeAtributo = new List<TipoDeAtributo>()
            {
                new TipoDeAtributo(result)
            };

            response.TipoDeAtributo = tipoDeAtributo;
            response.Success = true;

            return response;
        }

        #endregion

    }
}
