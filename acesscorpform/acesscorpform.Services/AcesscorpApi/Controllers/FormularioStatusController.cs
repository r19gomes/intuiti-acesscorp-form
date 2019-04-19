using Acesscorp.Applications.Contract.FormularioStatus;
using Acesscorp.Domains.Dtos;
using Acesscorp.Domains.Dtos.FormularioStatus;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Acesscorp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FormularioStatusController : ControllerBase
    {
        private readonly IFormularioStatusAppService _formularioStatusAppService;

        public FormularioStatusController(IFormularioStatusAppService formularioStatusAppService) : base()
        {
            _formularioStatusAppService = formularioStatusAppService;
        }

        [Route("Get")]
        [HttpGet]
        public ActionResult<FormularioStatusResponse> Get(Int64 id)
        {
            var response = new FormularioStatusResponse();

            try
            {
                response = _formularioStatusAppService.Get(id);

                if (response.FormularioStatus.Count == 0)
                {
                    response.Message = string.Format
                        ("Formulário Status {0} não encontrado!", id.ToString());
                }
                return response;
            }
            catch (Exception ex)
            {
                response.ResourceCode = string.Empty;
                response.ErrorCode = 30017; //- ErrorCode = "30017"
                response.Message = string.Format
                    ("Erro o Formulário Status: {0}.", id.ToString());
                response.Erros.Add(new Acesscorp.Domains.Dtos.Error(ex.Message, "", ex.StackTrace));
            }

            return response;
        }

        [Route("GetAll")]
        [HttpGet]
        public ActionResult<FormularioStatusResponse> GetAll()
        {
            var response = new FormularioStatusResponse();

            try
            {
                response = _formularioStatusAppService.GetAll();

                if (response.FormularioStatus.Count == 0)
                {
                    response.Erros.Add(new Error
                    {
                        ErrorCode = "30018",
                        ErrorMessage = "Formulário Status não encontrado!"
                    });
                    response.Success = false;
                };
                return response;
            }
            catch (Exception ex)
            {
                response.ResourceCode = string.Empty;
                response.ErrorCode = 30019; //- ErrorCode = "30019"
                response.Message = "Erro ao obter a lista do Formulário Status.";
                response.Erros.Add(new Acesscorp.Domains.Dtos.Error(ex.Message, "", ex.StackTrace));
            }

            return response;
        }

        [Route("Insert")]
        [HttpPost]
        public ActionResult<FormularioStatusResponse> Insert(FormularioStatusRequest request)
        {
            var response = new FormularioStatusResponse();

            try
            {
                request.IsInserted = true;
                var messages = request.Validate();
                if (messages.Count.Equals(0))
                {
                    response = _formularioStatusAppService.Insert(request);
                    if (response.FormularioStatus.Count == 0)
                    {
                        response.Erros.Add(new Error
                        {
                            ErrorCode = "30020",
                            ErrorMessage = string.Format
                                ("Formulário Status {0} salvo não encontrado!",
                                    request.FormularioStatus.Nome)
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
                response.ErrorCode = 30021; //- ErrorCode = "30021"
                response.Message = string.Format
                    ("Erro ao inserrir o Formulário Status: {0}-{1}.",
                        request.FormularioStatus.FormularioStatusId,
                        request.FormularioStatus.Nome);
                response.Erros.Add(new Acesscorp.Domains.Dtos.Error(ex.Message, "", ex.StackTrace));
            }

            return response;
        }

        [Route("Update")]
        [HttpPut]
        public ActionResult<FormularioStatusResponse> Update(FormularioStatusRequest request)
        {
            var response = new FormularioStatusResponse();

            try
            {
                var messages = request.Validate();
                if (messages.Count.Equals(0))
                {
                    response = _formularioStatusAppService.Update(request);
                    if (response.FormularioStatus.Count == 0)
                    {
                        response.Erros.Add(new Error
                        {
                            ErrorCode = "30022",
                            ErrorMessage = string.Format
                                ("Formulário Status {0} salvo não encontrado!",
                                    request.FormularioStatus.Nome)
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
                response.ErrorCode = 30023; //- ErrorCode = "30023"
                response.Message = string.Format
                    ("Erro ao atualizar o Formulário Status: {0}-{1}.",
                        request.FormularioStatus.FormularioStatusId,
                        request.FormularioStatus.Nome);
                response.Erros.Add
                    (new Acesscorp.Domains.Dtos.Error(ex.Message, "", ex.StackTrace));
            }

            return response;
        }

        [Route("SaveOrUpdate")]
        [HttpPost]
        public ActionResult<FormularioStatusResponse> SaveOrUpdate(FormularioStatusRequest request)
        {
            var response = new FormularioStatusResponse();

            try
            {
                var messages = request.Validate();
                if (messages.Count.Equals(0))
                {
                    if (request.FormularioStatus.FormularioStatusId <= 0)
                    {
                        response = _formularioStatusAppService.Insert(request);
                    }
                    else
                    {
                        response = _formularioStatusAppService.Update(request);
                    }
                    if (response.FormularioStatus.Count == 0)
                    {
                        response.Erros.Add(new Error
                        {
                            ErrorCode = "30024",
                            ErrorMessage = string.Format
                                ("Formulário Status {0} salvo não encontrado!",
                                    request.FormularioStatus.Nome)
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
                response.ErrorCode = 30025; //- ErrorCode = "30025"
                response.Message = string.Format
                    ("Erro ao salvar o Formulário Status: {0}-{1}.",
                        request.FormularioStatus.FormularioStatusId,
                        request.FormularioStatus.Nome);
                response.Erros.Add(new Acesscorp.Domains.Dtos.Error(ex.Message, "", ex.StackTrace));
            }

            return response;
        }

        [Route("Delete")]
        [HttpDelete]
        public ActionResult<FormularioStatusResponse> Delete(Int64 id)
        {
            var response = new FormularioStatusResponse();

            try
            {
                response = _formularioStatusAppService.Delete(id);

                if (response.FormularioStatus.Count == 0)
                {
                    response.Erros.Add(new Error
                    {
                        ErrorCode = "30026",
                        ErrorMessage = string.Format
                            ("Formulário Status foi não removido!", id.ToString())
                    });
                    response.Success = false;
                };
                return response;
            }
            catch (Exception ex)
            {
                response.ResourceCode = string.Empty;
                response.ErrorCode = 30027; //- ErrorCode = "30027"
                response.Message = string.Format
                    ("Erro ao remover o Formulário Status: {0}.", id.ToString());
                response.Erros.Add(new Acesscorp.Domains.Dtos.Error(ex.Message, "", ex.StackTrace));
            }

            return response;
        }
    }
}