using Acesscorp.Domains.Contracts.Repositories;
using Acesscorp.Domains.Contracts.Services;
using Acesscorp.Domains.Dtos.FormularioStatus;
using System;
using System.Collections.Generic;

namespace Acesscorp.Domains.Services
{
    public class FormularioStatusServices : IFormularioStatusServices
    {
        #region Properties | Fields

        private readonly IFormularioStatusRepositories _formularioStatusRepositories;

        #endregion

        #region Builders

        public FormularioStatusServices()
        {

        }

        public FormularioStatusServices(IFormularioStatusRepositories formularioStatusRepositories):base()
        {
            _formularioStatusRepositories = formularioStatusRepositories;
        }

        #endregion

        #region Methods

        public FormularioStatusResponse Get(long id)
        {           
            var response = new FormularioStatusResponse();

            var result = _formularioStatusRepositories.Get(id); ;

            IList<FormularioStatus> formularioStatus = new List<FormularioStatus>();
            formularioStatus.Add(result);

            response.FormularioStatus = formularioStatus;
            response.Success = (formularioStatus.Count > 0 ? true : false);

            return response;
        }

        public FormularioStatusResponse GetAll()
        {
            var response = new FormularioStatusResponse();

            IList<FormularioStatus> formularioStatus;
            formularioStatus = _formularioStatusRepositories.GetAll();

            response.FormularioStatus = formularioStatus;
            response.Success = true;

            return response;
        }

        public FormularioStatusResponse Insert(FormularioStatusRequest request)
        {
            var response = new FormularioStatusResponse();

            var result = _formularioStatusRepositories.Insert(request);
            IList<FormularioStatus> formularioStatus = new List<FormularioStatus>()
            {
                new FormularioStatus(result)
            };

            response.FormularioStatus = formularioStatus;
            response.Success = true;

            return response;
        }

        public FormularioStatusResponse Update(FormularioStatusRequest request)
        {
            var response = new FormularioStatusResponse();

            var result = _formularioStatusRepositories.Update(request);
            IList<FormularioStatus> formularioStatus = new List<FormularioStatus>()
            {
                new FormularioStatus(result)
            };

            response.FormularioStatus = formularioStatus;
            response.Success = true;

            return response;
        }

        #endregion
    }
}
