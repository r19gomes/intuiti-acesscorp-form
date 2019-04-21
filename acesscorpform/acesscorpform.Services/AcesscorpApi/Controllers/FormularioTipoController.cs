using Acesscorp.Applications.Contract.FormularioTipo;
using Acesscorp.Domains.Dtos;
using Acesscorp.Domains.Dtos.FormularioTipo;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Acesscorp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FormularioTipoController : ControllerBase
    {
        private readonly IFormularioTipoAppService _formularioTipoAppService;

        public FormularioTipoController(IFormularioTipoAppService formularioTipoAppService) : base()
        {
            _formularioTipoAppService = formularioTipoAppService;
        }

        [Route("Get")]
        [HttpGet]
        public ActionResult<FormularioTipoResponse> Get(Int64 id)
        {
            var response = new FormularioTipoResponse();

            try
            {
                response = _formularioTipoAppService.Get(id);

                if (response.FormularioTipo.Count == 0)
                {
                    response.Message = string.Format
                        ("Tipo do Formulário {0} não encontrado!", id.ToString());
                }
                return response;
            }
            catch (Exception ex)
            {
                response.ResourceCode = string.Empty;
                response.ErrorCode = 30028; //- ErrorCode = "30028"
                response.Message = string.Format
                    ("Erro o Tipo de Formulário: {0}.", id.ToString());
                response.Erros.Add(new Acesscorp.Domains.Dtos.Error(ex.Message, "", ex.StackTrace));
            }

            return response;
        }

        [Route("GetAll")]
        [HttpGet]
        public ActionResult<FormularioTipoResponse> GetAll()
        {
            var response = new FormularioTipoResponse();

            try
            {
                response = _formularioTipoAppService.GetAll();

                if (response.FormularioTipo.Count == 0)
                {
                    response.Erros.Add(new Error
                    {
                        ErrorCode = "30029",
                        ErrorMessage = "Tipo de Formulário não encontrado!"
                    });
                    response.Success = false;
                };
                return response;
            }
            catch (Exception ex)
            {
                response.ResourceCode = string.Empty;
                response.ErrorCode = 30030; //- ErrorCode = "30030"
                response.Message = "Erro ao obter a lista do Tipo de Formulário.";
                response.Erros.Add(new Acesscorp.Domains.Dtos.Error(ex.Message, "", ex.StackTrace));
            }

            return response;
        }

        [Route("Insert")]
        [HttpPost]
        public ActionResult<FormularioTipoResponse> Insert(FormularioTipoRequest request)
        {
            var response = new FormularioTipoResponse();

            try
            {
                request.IsInserted = true;
                var messages = request.Validate();
                if (messages.Count.Equals(0))
                {
                    response = _formularioTipoAppService.Insert(request);
                    if (response.FormularioTipo.Count == 0)
                    {
                        response.Erros.Add(new Error
                        {
                            ErrorCode = "30031",
                            ErrorMessage = string.Format
                                ("Tipo de Formulário {0} salvo não encontrado!",
                                    request.FormularioTipo.Nome)
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
                response.ErrorCode = 30032; //- ErrorCode = "30032"
                response.Message = string.Format
                    ("Erro ao inserrir o Tipo de Formulário: {0}-{1}.",
                        request.FormularioTipo.FormularioTipoId,
                        request.FormularioTipo.Nome);
                response.Erros.Add(new Acesscorp.Domains.Dtos.Error(ex.Message, "", ex.StackTrace));
            }

            return response;
        }

        [Route("Update")]
        [HttpPut]
        public ActionResult<FormularioTipoResponse> Update(FormularioTipoRequest request)
        {
            var response = new FormularioTipoResponse();

            try
            {
                var messages = request.Validate();
                if (messages.Count.Equals(0))
                {
                    response = _formularioTipoAppService.Update(request);
                    if (response.FormularioTipo.Count == 0)
                    {
                        response.Erros.Add(new Error
                        {
                            ErrorCode = "30033",
                            ErrorMessage = string.Format
                                ("Tipo de Formulário {0} salvo não encontrado!",
                                    request.FormularioTipo.Nome)
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
                response.ErrorCode = 30034; //- ErrorCode = "30034
                response.Message = string.Format
                    ("Erro ao atualizar o Tipo de Formulário: {0}-{1}.",
                        request.FormularioTipo.FormularioTipoId,
                        request.FormularioTipo.Nome);
                response.Erros.Add
                    (new Acesscorp.Domains.Dtos.Error(ex.Message, "", ex.StackTrace));
            }

            return response;
        }

        [Route("SaveOrUpdate")]
        [HttpPost]
        public ActionResult<FormularioTipoResponse> SaveOrUpdate(FormularioTipoRequest request)
        {
            var response = new FormularioTipoResponse();

            try
            {
                var messages = request.Validate();
                if (messages.Count.Equals(0))
                {
                    if (request.FormularioTipo.FormularioTipoId <= 0)
                    {
                        response = _formularioTipoAppService.Insert(request);
                    }
                    else
                    {
                        response = _formularioTipoAppService.Update(request);
                    }
                    if (response.FormularioTipo.Count == 0)
                    {
                        response.Erros.Add(new Error
                        {
                            ErrorCode = "30035",
                            ErrorMessage = string.Format
                                ("Tipo de Formulário {0} salvo não encontrado!",
                                    request.FormularioTipo.Nome)
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
                response.ErrorCode = 30036; //- ErrorCode = "30036"
                response.Message = string.Format
                    ("Erro ao salvar o Tipo de Formulário: {0}-{1}.",
                        request.FormularioTipo.FormularioTipoId,
                        request.FormularioTipo.Nome);
                response.Erros.Add(new Acesscorp.Domains.Dtos.Error(ex.Message, "", ex.StackTrace));
            }

            return response;
        }

        [Route("Delete")]
        [HttpDelete]
        public ActionResult<FormularioTipoResponse> Delete(Int64 id)
        {
            var response = new FormularioTipoResponse();

            try
            {
                response = _formularioTipoAppService.Delete(id);

                if (response.FormularioTipo.Count == 0)
                {
                    response.Erros.Add(new Error
                    {
                        ErrorCode = "30036",
                        ErrorMessage = string.Format
                            ("Tipo de Formulário foi não removido!", id.ToString())
                    });
                    response.Success = false;
                };
                return response;
            }
            catch (Exception ex)
            {
                response.ResourceCode = string.Empty;
                response.ErrorCode = 30037; //- ErrorCode = "30027"
                response.Message = string.Format
                    ("Erro ao remover o Tipo de Formulário: {0}.", id.ToString());
                response.Erros.Add(new Acesscorp.Domains.Dtos.Error(ex.Message, "", ex.StackTrace));
            }

            return response;
        }

    }
}