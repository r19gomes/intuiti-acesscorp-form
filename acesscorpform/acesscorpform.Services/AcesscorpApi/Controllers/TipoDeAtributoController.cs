using Acesscorp.Applications.Contract.TipoDeAtributo;
using Acesscorp.Domains.Dtos;
using Acesscorp.Domains.Dtos.TipoDeAtributo;
using Microsoft.AspNetCore.Mvc;
using System;

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

        [Route("Get")]
        [HttpGet]
        public ActionResult<TipoDeAtributoResponse> Get(Int64 id)
        {
            var response = new TipoDeAtributoResponse();

            try
            {
                response = _tipoDeAtributoAppService.Get(id);

                if (response.TipoDeAtributo.Count == 0)
                {
                    response.Message = string.Format
                        ("Tipo de Atributo {0} não encontrado!", id.ToString());
                }
                return response;
            }
            catch (Exception ex)
            {
                response.ResourceCode = string.Empty;
                response.ErrorCode = 30007; //- ErrorCode = "30007"
                response.Message = string.Format
                    ("Erro o Tipos de Atributos: {0}.", id.ToString());
                response.Erros.Add(new Acesscorp.Domains.Dtos.Error(ex.Message, "", ex.StackTrace));
            }

            return response;
        }

        [Route("GetAll")]
        [HttpGet]
        public ActionResult<TipoDeAtributoResponse> GetAll()
        {
            var response = new TipoDeAtributoResponse();

            try
            {
                response = _tipoDeAtributoAppService.GetAll();

                if (response.TipoDeAtributo.Count == 0)
                {
                    if (response.TipoDeAtributo.Count == 0)
                    {
                        response.Erros.Add(new Error
                        {
                            ErrorCode = "30008",
                            ErrorMessage = "Nenhum Tipo de Atributo foi não encontrado!"
                        });
                        response.Success = false;
                    };
                    return response;
                }
                return response;
            }
            catch (Exception ex)
            {
                response.ResourceCode = string.Empty;
                response.ErrorCode = 30009; //- ErrorCode = "30009"
                response.Message = "Erro ao obter a lista de Tipo de Atributo.";
                response.Erros.Add(new Acesscorp.Domains.Dtos.Error(ex.Message, "", ex.StackTrace));
            }

            return response;

        }

        [Route("Insert")]
        [HttpPost]
        public ActionResult<TipoDeAtributoResponse> Insert(TipoDeAtributoRequest request)
        {
            var response = new TipoDeAtributoResponse();

            try
            {
                request.IsInserted = true;
                var messages = request.Validate();
                if (messages.Count.Equals(0))
                {
                    response = _tipoDeAtributoAppService.Insert(request);
                    if (response.TipoDeAtributo.Count == 0)
                    {
                        response.Erros.Add(new Error
                        {
                            ErrorCode = "30010",
                            ErrorMessage = string.Format
                                ("Tipo de Atributo {0} salvo não encontrado!",
                                    request.TipoDeAtributo.Nome)
                        });
                        response.Success = false;
                    };
                    return response;
                }
                else
                {
                    response.Erros = messages;
                }
            }
            catch (Exception ex)
            {
                response.ResourceCode = string.Empty;
                response.ErrorCode = 30011; //- ErrorCode = "30011"
                response.Message = string.Format
                    ("Erro ao inserrir o Tipo de Dado: {0}-{1}.",
                        request.TipoDeAtributo.TipoDeDadoId,
                        request.TipoDeAtributo.Nome);
                response.Erros.Add(new Acesscorp.Domains.Dtos.Error(ex.Message, "", ex.StackTrace));
            }

            return response;
        }

        [Route("Update")]
        [HttpPut]
        public ActionResult<TipoDeAtributoResponse> Update(TipoDeAtributoRequest request)
        {
            var response = new TipoDeAtributoResponse();

            try
            {
                var messages = request.Validate();
                if (messages.Count.Equals(0))
                {
                    response = _tipoDeAtributoAppService.Update(request);
                    if (response.TipoDeAtributo.Count == 0)
                    {
                        response.Erros.Add(new Error
                        {
                            ErrorCode = "30011",
                            ErrorMessage = string.Format
                                ("Tipo de Atributos {0} salvo não encontrado!",
                                    request.TipoDeAtributo.Nome)
                        });
                        response.Success = false;
                    };
                    return response;
                }
                else
                {
                    response.Erros = messages;
                }
            }
            catch (Exception ex)
            {
                response.ResourceCode = string.Empty;
                response.ErrorCode = 30012; //- ErrorCode = "30012"
                response.Message = string.Format
                    ("Erro ao atualizar o Tipo de Atributo: {0}-{1}.",
                        request.TipoDeAtributo.TipoDeAtributoId,
                        request.TipoDeAtributo.Nome);
                response.Erros.Add
                    (new Acesscorp.Domains.Dtos.Error(ex.Message, "", ex.StackTrace));
            }

            return response;
        }

        [Route("SaveOrUpdate")]
        [HttpPost]
        public ActionResult<TipoDeAtributoResponse> SaveOrUpdate(TipoDeAtributoRequest request)
        {
            var response = new TipoDeAtributoResponse();

            try
            {
                var messages = request.Validate();
                if (messages.Count.Equals(0))
                {
                    if (request.TipoDeAtributo.TipoDeDadoId <= 0)
                    {
                        response = _tipoDeAtributoAppService.Insert(request);
                    }
                    else
                    {
                        response = _tipoDeAtributoAppService.Update(request);
                    }
                    if (response.TipoDeAtributo.Count == 0)
                    {
                        response.Erros.Add(new Error
                        {
                            ErrorCode = "30013",
                            ErrorMessage = string.Format
                                ("Tipo de Atributo {0} salvo não encontrado!",
                                    request.TipoDeAtributo.Nome)
                        });
                        response.Success = false;
                    };
                    return response;
                }
                else
                {
                    response.Erros = messages;
                }
            }
            catch (Exception ex)
            {
                response.ResourceCode = string.Empty;
                response.ErrorCode = 30014; //- ErrorCode = "30014"
                response.Message = string.Format
                    ("Erro ao salvar o Tipo de Atributo: {0}-{1}.",
                        request.TipoDeAtributo.TipoDeAtributoId,
                        request.TipoDeAtributo.Nome);
                response.Erros.Add(new Acesscorp.Domains.Dtos.Error(ex.Message, "", ex.StackTrace));
            }

            return response;
        }

        [Route("Delete")]
        [HttpDelete]
        public ActionResult<TipoDeAtributoResponse> Delete(Int64 id)
        {
            var response = new TipoDeAtributoResponse();

            try
            {
                response = _tipoDeAtributoAppService.Delete(id);

                if (response.TipoDeAtributo.Count == 0)
                {
                    response.Erros.Add(new Error
                    {
                        ErrorCode = "30015",
                        ErrorMessage = string.Format
                            ("Tipo de Atributo foi não removido!", id.ToString())
                    });
                    response.Success = false;
                };
                return response;
            }
            catch (Exception ex)
            {
                response.ResourceCode = string.Empty;
                response.ErrorCode = 30016; //- ErrorCode = "30016"
                response.Message = string.Format
                    ("Erro ao remover o Tipos de Atributos: {0}.", id.ToString());
                response.Erros.Add(new Acesscorp.Domains.Dtos.Error(ex.Message, "", ex.StackTrace));
            }

            return response;
        }
    }
}
