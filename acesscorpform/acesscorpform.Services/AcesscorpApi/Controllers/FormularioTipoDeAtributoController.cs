using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Acesscorp.Applications.Contract.FormularioTipoDeAtributo;
using Acesscorp.Domains.Dtos;
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


        [Route("Get")]
        [HttpGet]
        public ActionResult<FormularioTipoDeAtributoResponse> Get(Int64 id)
        {
            var response = new FormularioTipoDeAtributoResponse();

            try
            {
                response = _formularioTipoDeAtributoAppService.Get(id);

                if (response.FormularioTipoDeAtributo.Count == 0)
                {
                    response.ErrorCode = 30049; //- ErrorCode = "30049"
                    response.Message = string.Format
                        ("Tipo de Atributo do Formulário {0} não encontrado!", id.ToString());
                }
                return response;
            }
            catch (Exception ex)
            {
                response.ResourceCode = string.Empty;
                response.ErrorCode = 30050; //- ErrorCode = "30050"
                response.Message = string.Format
                    ("Erro o Tipos de Atributos: {0}.", id.ToString());
                response.Erros.Add(new Acesscorp.Domains.Dtos.Error(ex.Message, "", ex.StackTrace));
            }

            return response;
        }

        [Route("GetAll")]
        [HttpGet]
        public ActionResult<FormularioTipoDeAtributoResponse> GetAll()
        {
            var response = new FormularioTipoDeAtributoResponse();

            try
            {
                response = _formularioTipoDeAtributoAppService.GetAll();

                if (response.FormularioTipoDeAtributo.Count == 0)
                {
                    if (response.FormularioTipoDeAtributo.Count == 0)
                    {
                        response.Erros.Add(new Error
                        {
                            ErrorCode = "30051",
                            ErrorMessage = "Nenhum Tipo de Atributo do Formulário foi não encontrado!"
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
                response.ErrorCode = 30052; //- ErrorCode = "30052"
                response.Message = "Erro ao obter a lista de Tipo de Atributo do Formulário.";
                response.Erros.Add(new Acesscorp.Domains.Dtos.Error(ex.Message, "", ex.StackTrace));
            }

            return response;

        }

        [Route("Insert")]
        [HttpPost]
        public ActionResult<FormularioTipoDeAtributoResponse> Insert(FormularioTipoDeAtributoRequest request)
        {
            var response = new FormularioTipoDeAtributoResponse();

            try
            {
                request.IsInserted = true;
                var messages = request.Validate();
                if (messages.Count.Equals(0))
                {
                    response = _formularioTipoDeAtributoAppService.Insert(request);
                    if (response.FormularioTipoDeAtributo.Count == 0)
                    {
                        response.Erros.Add(new Error
                        {
                            ErrorCode = "30053",
                            ErrorMessage = string.Format
                                ("Tipo de Atributo {0} salvo não encontrado!",
                                    request.FormularioTipoDeAtributo.FormularioTipoDeAtributoId)
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
                response.ErrorCode = 30054; //- ErrorCode = "30054"
                response.Message = string.Format
                    ("Erro ao inserrir o Tipo de Dado do Formulário: {0}.",
                        request.FormularioTipoDeAtributo.FormularioTipoDeAtributoId);
                response.Erros.Add(new Acesscorp.Domains.Dtos.Error(ex.Message, "", ex.StackTrace));
            }

            return response;
        }

        [Route("Update")]
        [HttpPut]
        public ActionResult<FormularioTipoDeAtributoResponse> Update(FormularioTipoDeAtributoRequest request)
        {
            var response = new FormularioTipoDeAtributoResponse();

            try
            {
                var messages = request.Validate();
                if (messages.Count.Equals(0))
                {
                    response = _formularioTipoDeAtributoAppService.Update(request);
                    if (response.FormularioTipoDeAtributo.Count == 0)
                    {
                        response.Erros.Add(new Error
                        {
                            ErrorCode = "30054",
                            ErrorMessage = string.Format
                                ("Tipo de Atributos do Formulário {0} salvo não encontrado!",
                                    request.FormularioTipoDeAtributo.FormularioTipoDeAtributoId)
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
                response.ErrorCode = 30055; //- ErrorCode = "30055"
                response.Message = string.Format
                    ("Erro ao atualizar o Tipo de Atributo do Formulário: {0}.",
                        request.FormularioTipoDeAtributo.FormularioTipoDeAtributoId);
                response.Erros.Add
                    (new Acesscorp.Domains.Dtos.Error(ex.Message, "", ex.StackTrace));
            }

            return response;
        }

        [Route("SaveOrUpdate")]
        [HttpPost]
        public ActionResult<FormularioTipoDeAtributoResponse> SaveOrUpdate(FormularioTipoDeAtributoRequest request)
        {
            var response = new FormularioTipoDeAtributoResponse();

            try
            {
                var messages = request.Validate();
                if (messages.Count.Equals(0))
                {
                    if (request.FormularioTipoDeAtributo.FormularioTipoDeAtributoId <= 0)
                    {
                        response = _formularioTipoDeAtributoAppService.Insert(request);
                    }
                    else
                    {
                        response = _formularioTipoDeAtributoAppService.Update(request);
                    }
                    if (response.FormularioTipoDeAtributo.Count == 0)
                    {
                        response.Erros.Add(new Error
                        {
                            ErrorCode = "30056",
                            ErrorMessage = string.Format
                                ("Tipo de Atributo do Formulário {0} salvo não encontrado!",
                                    request.FormularioTipoDeAtributo.FormularioTipoDeAtributoId)
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
                response.ErrorCode = 30057; //- ErrorCode = "30057"
                response.Message = string.Format
                    ("Erro ao salvar o Tipo de Atributo do Formulário: {0}.",
                        request.FormularioTipoDeAtributo.FormularioTipoDeAtributoId);
                response.Erros.Add(new Acesscorp.Domains.Dtos.Error(ex.Message, "", ex.StackTrace));
            }

            return response;
        }

        [Route("Delete")]
        [HttpDelete]
        public ActionResult<FormularioTipoDeAtributoResponse> Delete(Int64 id)
        {
            var response = new FormularioTipoDeAtributoResponse();

            try
            {
                response = _formularioTipoDeAtributoAppService.Delete(id);

                if (response.FormularioTipoDeAtributo.Count == 0)
                {
                    response.Erros.Add(new Error
                    {
                        ErrorCode = "30058",
                        ErrorMessage = string.Format
                            ("Tipo de Atributo do Formulário foi não removido!", id.ToString())
                    });
                    response.Success = false;
                };
                return response;
            }
            catch (Exception ex)
            {
                response.ResourceCode = string.Empty;
                response.ErrorCode = 30059; //- ErrorCode = "30059"
                response.Message = string.Format
                    ("Erro ao remover o Tipos de Atributos do Formulário: {0}.", id.ToString());
                response.Erros.Add(new Acesscorp.Domains.Dtos.Error(ex.Message, "", ex.StackTrace));
            }

            return response;
        }
    }
}
