using Acesscorp.Domains.Contracts.Repositories;
using Acesscorp.Domains.Contracts.Services;
using Acesscorp.Domains.Dtos.FormularioTipo;
using System;
using System.Collections.Generic;

namespace Acesscorp.Domains.Services
{
    public class FormularioTipoServices : IFormularioTipoServices
    {
        #region Properties | Fields

        private readonly IFormularioTipoRepositories _formularioTipoRepositories;

        #endregion

        #region Builders

        public FormularioTipoServices()
        {

        }

        public FormularioTipoServices(IFormularioTipoRepositories formularioTipoRepositories) : base()
        {
            _formularioTipoRepositories = formularioTipoRepositories;
        }

        #endregion

        #region Methods

        public FormularioTipoResponse Get(Int64 id)
        {
            var response = new FormularioTipoResponse();

            var result = _formularioTipoRepositories.Get(id);
            IList<FormularioTipo> formularioTipo = new List<FormularioTipo>()
            {
                new FormularioTipo(result)
            };

            response.FormularioTipo = formularioTipo;
            response.Success = (formularioTipo.Count > 0 ? true : false);

            return response;
        }

        public FormularioTipoResponse GetAll()
        {
            var response = new FormularioTipoResponse();

            IList<FormularioTipo> formularioTipo;
            formularioTipo = _formularioTipoRepositories.GetAll();

            response.FormularioTipo = formularioTipo;
            response.Success = (formularioTipo.Count > 0 ? true : false);

            return response;
        }

        public FormularioTipoResponse Insert(FormularioTipoRequest request)
        {
            var response = new FormularioTipoResponse();

            var result = _formularioTipoRepositories.Insert(request);
            IList<FormularioTipo> formularioTipo = new List<FormularioTipo>()
            {
                new FormularioTipo(result)
            };

            response.FormularioTipo = formularioTipo;
            response.Success = (formularioTipo.Count > 0 ? true : false);

            return response;
        }

        public FormularioTipoResponse Update(FormularioTipoRequest request)
        {
            var response = new FormularioTipoResponse();

            var result = _formularioTipoRepositories.Update(request);
            IList<FormularioTipo> formularioTipo = new List<FormularioTipo>()
            {
                new FormularioTipo(result)
            };

            response.FormularioTipo = formularioTipo;
            response.Success = (formularioTipo.Count > 0 ? true : false);

            return response;
        }

        public FormularioTipoResponse Delete(Int64 id)
        {
            var response = new FormularioTipoResponse();

            var result = _formularioTipoRepositories.Delete(id);

            IList<FormularioTipo> formularioTipo = new List<FormularioTipo>();
            formularioTipo.Add(result);

            response.FormularioTipo = formularioTipo;
            response.Success = (formularioTipo.Count > 0 ? true : false);

            return response;
        }

        #endregion

    }
}
