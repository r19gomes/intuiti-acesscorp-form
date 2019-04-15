using Acesscorp.Domains.Contracts.Repositories;
using Acesscorp.Domains.Contracts.Services;
using Acesscorp.Domains.Dtos.FormularioTipoDeAtributo;
using System;
using System.Collections.Generic;

namespace Acesscorp.Domains.Services
{
    public class FormularioTipoDeAtributoServices : IFormularioTipoDeAtributoServices
    {
        #region Properties | Fields

        private readonly IFormularioTipoDeAtributoRepositories _formularioTipoDeAtributoRepositories;

        #endregion

        #region Builders

        public FormularioTipoDeAtributoServices()
        {

        }

        public FormularioTipoDeAtributoServices(IFormularioTipoDeAtributoRepositories formularioTipoDeAtributoRepositories) : base()
        {
            _formularioTipoDeAtributoRepositories = formularioTipoDeAtributoRepositories;
        }

        #endregion

        #region Methods

        public FormularioTipoDeAtributoResponse Get(long id)
        {
            var response = new FormularioTipoDeAtributoResponse();

            var result = _formularioTipoDeAtributoRepositories.Get(id);
            IList<FormularioTipoDeAtributo> formularioTipoDeAtributo = new List<FormularioTipoDeAtributo>()
            {
                new FormularioTipoDeAtributo(result)
            };

            response.FormularioTipoDeAtributo = formularioTipoDeAtributo;
            response.Success = true;

            return response;
        }

        public FormularioTipoDeAtributoResponse GetAll()
        {
            var response = new FormularioTipoDeAtributoResponse();

            IList<FormularioTipoDeAtributo> formularioTipoDeAtributo;
            formularioTipoDeAtributo = _formularioTipoDeAtributoRepositories.GetAll();

            response.FormularioTipoDeAtributo = formularioTipoDeAtributo;
            response.Success = true;

            return response;
        }

        public FormularioTipoDeAtributoResponse Insert(FormularioTipoDeAtributoRequest request)
        {
            var response = new FormularioTipoDeAtributoResponse();

            var result = _formularioTipoDeAtributoRepositories.Insert(request);
            IList<FormularioTipoDeAtributo> formularioTipoDeAtributo = new List<FormularioTipoDeAtributo>()
            {
                new FormularioTipoDeAtributo(result)
            };

            response.FormularioTipoDeAtributo = formularioTipoDeAtributo;
            response.Success = true;

            return response;
        }

        public FormularioTipoDeAtributoResponse Update(FormularioTipoDeAtributoRequest request)
        {
            var response = new FormularioTipoDeAtributoResponse();

            var result = _formularioTipoDeAtributoRepositories.Update(request);
            IList<FormularioTipoDeAtributo> formularioTipoDeAtributo = new List<FormularioTipoDeAtributo>()
            {
                new FormularioTipoDeAtributo(result)
            };

            response.FormularioTipoDeAtributo = formularioTipoDeAtributo;
            response.Success = true;

            return response;
        }

        #endregion

    }
}
