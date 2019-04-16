using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Acesscorp.Applications.Contract.TipoDeAtributo;
using Acesscorp.Domains.Dtos.TipoDeAtributo;
using Microsoft.AspNetCore.Mvc;

namespace Acesscorp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipoDeAtributoController : ControllerBase
    {
        private readonly ITipoDeAtributoAppService _tipoDeAtributoAppService;

        public TipoDeAtributoController(ITipoDeAtributoAppService tipoDeAtributoAppService): base()
        {
            _tipoDeAtributoAppService = tipoDeAtributoAppService;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<TipoDeAtributoResponse> Get()
        {
            var response = new TipoDeAtributoResponse();

            try
            {
                response = _tipoDeAtributoAppService.GetAll();

                if (response.TipoDeAtributo.Count == 0)
                {
                    response.Message = "Tipo de Atributo não encontrado!";
                }
                return null;
            }
            catch (Exception ex)
            {
                response.ResourceCode = string.Empty;
                response.ErrorCode = 1;
                response.Message = "Erro ao obter a lista de Tipo de Atributo.";
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
