using Acesscorp.Domains.Contracts.Repositories;
using Acesscorp.Domains.Contracts.Services;
using Acesscorp.Domains.Dtos.TipoDeDado;
using System;
using System.Collections.Generic;

namespace Acesscorp.Domains.Services
{
    public class TipoDeDadoServices : ITipoDeDadoServices
    {
        #region Properties | Fields

        private readonly ITipoDeDadoRepositories _tipoDeDadoRepositories;

        #endregion

        #region Builders

        public TipoDeDadoServices()
        {

        }

        public TipoDeDadoServices(ITipoDeDadoRepositories contaCorrenteRepositories):base()
        {
            _tipoDeDadoRepositories = contaCorrenteRepositories;
        }

        #endregion

        #region Methods

        public TipoDeDadoResponse Get(long id)
        {
            _tipoDeDadoRepositories.Get(id);
            throw new NotImplementedException();
        }

        public TipoDeDadoResponse GetAll()
        {
            var response = new TipoDeDadoResponse();

            IList<TipoDeDado> tipoDeDado;
            tipoDeDado = _tipoDeDadoRepositories.GetAll();

            response.TipoDeDado = tipoDeDado;
            response.Success = true;

            return response;
        }

        public TipoDeDadoResponse Insert(TipoDeDadoRequest request)
        {
            var response = new TipoDeDadoResponse();

            var result = _tipoDeDadoRepositories.Insert(request);
            IList<TipoDeDado> tipoDeDado = new List<TipoDeDado>()
            {
                new TipoDeDado(result)
            };

            response.TipoDeDado = tipoDeDado;
            response.Success = true;

            return response;
        }

        public TipoDeDadoResponse Update(TipoDeDadoRequest request)
        {
            var response = new TipoDeDadoResponse();

            var result = _tipoDeDadoRepositories.Update(request);
            IList<TipoDeDado> tipoDeAtributo = new List<TipoDeDado>()
            {
                new TipoDeDado(result)
            };

            response.TipoDeDado = tipoDeAtributo;
            response.Success = true;

            return response;
        }

        #endregion
    }
}
