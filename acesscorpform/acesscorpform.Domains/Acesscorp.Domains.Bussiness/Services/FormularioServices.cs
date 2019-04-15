using Acesscorp.Domains.Contracts.Repositories;
using Acesscorp.Domains.Contracts.Services;
using Acesscorp.Domains.Dtos.Formulario;
using System;
using System.Collections.Generic;

namespace Acesscorp.Domains.Services
{
    public class FormularioServices : IFormularioServices
    {
        #region Properties | Fields

        private readonly IFormularioRepositories _formularioRepositories;

        #endregion

        #region Builders

        public FormularioServices()
        {

        }

        public FormularioServices(IFormularioRepositories formularioRepositories) : base()
        {
            _formularioRepositories = formularioRepositories;
        }

        #endregion

        #region Methods

        public FormularioResponse Get(long id)
        {
            var response = new FormularioResponse();

            var result = _formularioRepositories.Get(id);
            IList<Formulario> formulario = new List<Formulario>()
            {
                new Formulario(result)
            };

            response.Formulario = formulario;
            response.Success = true;

            return response;
        }

        public FormularioResponse GetAll()
        {
            var response = new FormularioResponse();

            IList<Formulario> formulario;
            formulario = _formularioRepositories.GetAll();

            response.Formulario = formulario;
            response.Success = true;

            return response;
        }

        public FormularioResponse Insert(FormularioRequest request)
        {
            var response = new FormularioResponse();

            var result = _formularioRepositories.Insert(request);
            IList<Formulario> formulario = new List<Formulario>()
            {
                new Formulario(result)
            };

            response.Formulario = formulario;
            response.Success = true;

            return response;
        }

        public FormularioResponse Update(FormularioRequest request)
        {
            var response = new FormularioResponse();

            var result = _formularioRepositories.Update(request);
            IList<Formulario> formulario = new List<Formulario>()
            {
                new Formulario(result)
            };

            response.Formulario = formulario;
            response.Success = true;

            return response;
        }

        #endregion

    }
}
