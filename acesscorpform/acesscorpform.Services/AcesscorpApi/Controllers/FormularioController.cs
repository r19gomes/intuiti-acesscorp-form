using Acesscorp.Applications.Contract.Formulario;
using Acesscorp.Domains.Dtos;
using Acesscorp.Domains.Dtos.Formulario;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Acesscorp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FormularioController : ControllerBase
    {
        private readonly IFormularioAppService _formularioAppService;

        public FormularioController(IFormularioAppService formularioAppService) : base()
        {
            _formularioAppService = formularioAppService;
        }

        [Route("Get")]
        [HttpGet]
        public ActionResult<FormularioResponse> Get(long id)
        {
            var response = new FormularioResponse();

            try
            {
                response = _formularioAppService.Get(id);

                if (response.Formulario.Count == 0)
                {
                    response.ErrorCode = 30038; //- ErrorCode = "30038"
                    response.Message = string.Format
                        ("Formulário {0} não encontrado!", id.ToString());
                }
                return response;
            }
            catch (Exception ex)
            {
                response.ResourceCode = string.Empty;
                response.ErrorCode = 30039; //- ErrorCode = "30039"
                response.Message = string.Format
                    ("Erro o Formulário: {0}.", id.ToString());
                response.Erros.Add(new Acesscorp.Domains.Dtos.Error(ex.Message, "", ex.StackTrace));
            }

            return response;
        }

        [Route("GetAll")]
        [HttpGet]
        public ActionResult<FormularioResponse> GetAll()
        {
            var response = new FormularioResponse();

            try
            {
                response = _formularioAppService.GetAll();

                if (response.Formulario.Count == 0)
                {
                    response.Erros.Add(new Error
                    {
                        ErrorCode = "30040",
                        ErrorMessage = "Formulário não encontrado!"
                    });
                    response.Success = false;
                };
                return response;
            }
            catch (Exception ex)
            {
                response.ResourceCode = string.Empty;
                response.ErrorCode = 30041; //- ErrorCode = "30041"
                response.Message = "Erro ao obter a lista do Formulário.";
                response.Erros.Add(new Acesscorp.Domains.Dtos.Error(ex.Message, "", ex.StackTrace));
            }

            return response;
        }

        [Route("Insert")]
        [HttpPost]
        public ActionResult<FormularioResponse> Insert(FormularioRequest request)
        {
            var response = new FormularioResponse();

            try
            {
                request.IsInserted = true;
                var messages = request.Validate();
                if (messages.Count.Equals(0))
                {
                    response = _formularioAppService.Insert(request);
                    if (response.Formulario.Count == 0)
                    {
                        response.Erros.Add(new Error
                        {
                            ErrorCode = "30042",
                            ErrorMessage = string.Format
                                ("Formulário {0} salvo não encontrado!",
                                    request.Formulario.Nome)
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
                response.ErrorCode = 30043; //- ErrorCode = "30043"
                response.Message = string.Format
                    ("Erro ao inserrir o Formulário: {0}-{1}.",
                        request.Formulario.FormularioId,
                        request.Formulario.Nome);
                response.Erros.Add(new Acesscorp.Domains.Dtos.Error(ex.Message, "", ex.StackTrace));
            }

            return response;
        }

        [Route("Update")]
        [HttpPut]
        public ActionResult<FormularioResponse> Update(FormularioRequest request)
        {
            var response = new FormularioResponse();

            try
            {
                var messages = request.Validate();
                if (messages.Count.Equals(0))
                {
                    response = _formularioAppService.Update(request);
                    if (response.Formulario.Count == 0)
                    {
                        response.Erros.Add(new Error
                        {
                            ErrorCode = "30044",
                            ErrorMessage = string.Format
                                ("Formulário {0} salvo não encontrado!",
                                    request.Formulario.Nome)
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
                response.ErrorCode = 30045; //- ErrorCode = "30045"
                response.Message = string.Format
                    ("Erro ao atualizar o Formulário: {0}-{1}.",
                        request.Formulario.FormularioId,
                        request.Formulario.Nome);
                response.Erros.Add
                    (new Acesscorp.Domains.Dtos.Error(ex.Message, "", ex.StackTrace));
            }

            return response;
        }

        [Route("SaveOrUpdate")]
        [HttpPost]
        public ActionResult<FormularioResponse> SaveOrUpdate(FormularioRequest request)
        {
            var response = new FormularioResponse();

            try
            {
                var messages = request.Validate();
                if (messages.Count.Equals(0))
                {
                    if (request.Formulario.FormularioId <= 0)
                    {
                        response = _formularioAppService.Insert(request);
                    }
                    else
                    {
                        response = _formularioAppService.Update(request);
                    }
                    if (response.Formulario.Count == 0)
                    {
                        response.Erros.Add(new Error
                        {
                            ErrorCode = "30045",
                            ErrorMessage = string.Format
                                ("Formulário {0} salvo não encontrado!",
                                    request.Formulario.Nome)
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
                response.ErrorCode = 30046; //- ErrorCode = "30046"
                response.Message = string.Format
                    ("Erro ao salvar o Formulário: {0}-{1}.",
                        request.Formulario.FormularioId,
                        request.Formulario.Nome);
                response.Erros.Add(new Acesscorp.Domains.Dtos.Error(ex.Message, "", ex.StackTrace));
            }

            return response;
        }

        [Route("Delete")]
        [HttpDelete]
        public ActionResult<FormularioResponse> Delete(Int64 id)
        {
            var response = new FormularioResponse();

            try
            {
                response = _formularioAppService.Delete(id);

                if (response.Formulario.Count == 0)
                {
                    response.Erros.Add(new Error
                    {
                        ErrorCode = "30047",
                        ErrorMessage = string.Format
                            ("Formulário foi não removido!", id.ToString())
                    });
                    response.Success = false;
                };
                return response;
            }
            catch (Exception ex)
            {
                response.ResourceCode = string.Empty;
                response.ErrorCode = 30048; //- ErrorCode = "30048"
                response.Message = string.Format
                    ("Erro ao remover o Formulário: {0}.", id.ToString());
                response.Erros.Add(new Acesscorp.Domains.Dtos.Error(ex.Message, "", ex.StackTrace));
            }

            return response;
        }
    }
}