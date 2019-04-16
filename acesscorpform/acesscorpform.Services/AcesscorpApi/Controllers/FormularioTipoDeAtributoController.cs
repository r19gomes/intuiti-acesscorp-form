using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Acesscorp.Applications.Contract.FormularioTipoDeAtributo;
using Acesscorp.Domains.Dtos.FormularioTipoDeAtributo;
using Microsoft.AspNetCore.Mvc;

namespace Acesscorp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FormularioTipoDeAtributoController : ControllerBase
    {
        private readonly IFormularioTipoDeAtributoAppService _formularioTipoDeAtributoAppService;

        public FormularioTipoDeAtributoController(IFormularioTipoDeAtributoAppService formularioTipoDeAtributoAppService): base()
        {
            _formularioTipoDeAtributoAppService = formularioTipoDeAtributoAppService;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<FormularioTipoDeAtributoResponse> Get()
        {
            var response = new FormularioTipoDeAtributoResponse();

            try
            {
                response = _formularioTipoDeAtributoAppService.GetAll();

                if (response.FormularioTipoDeAtributo.Count == 0)
                {
                    response.Message = "Formulário Tipo de Atributo não encontrado!";
                }
                return null;
            }
            catch (Exception ex)
            {
                response.ResourceCode = string.Empty;
                response.ErrorCode = 1;
                response.Message = "Erro ao obter a lista de Formulário Tipo de Atributo.";
                response.Erros.Add(new Acesscorp.Domains.Dtos.Error(ex.Message, "", ex.StackTrace));
            }

            return response;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
