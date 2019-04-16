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
        private readonly IFormularioStatusAppService _FormularioStatusAppService;

        public FormularioStatusController(IFormularioStatusAppService formularioStatusAppService) : base()
        {
            _formularioStatusAppService = formularioStatusAppService;
        }

        [Route("Get")]
        [HttpGet]
        public ActionResult<FormularioStatusResponse> Get(long id)
        {
            var response = new FormularioStatusResponse();

            try
            {
                response = _formularioStatusAppService.Get(id);

                if (response.FormularioStatus.Count == 0)
                {
                    response.Message = "Formulário Status não encontrado!";
                }
                return response;
            }
            catch (Exception ex)
            {
                response.ResourceCode = string.Empty;
                response.ErrorCode = 1;
                response.Message = "Erro ao obter a lista do Formulário Status.";
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

                if (response.FormulairoStatus.Count == 0)
                {
                    response.Erros.Add(new Error
                    {
                        ErrorCode = "30004",
                        ErrorMessage = "Formulário Status não encontrado!"
                    });
                    response.Success = false;
                };
                return response;
            }
            catch (Exception ex)
            {
                response.ResourceCode = string.Empty;
                response.ErrorCode = 1;
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

            //try
            //{
            //    //var messages = request.Validate();
            //    string[] messages = null;
            //    if (messages.Count.Equals(0))
            //    {
            //        response = _formulairoStatusAppService.Insert(request);
            //        if (response.FormularioStatus.Count == 0)
            //        {
            //            response.Erros.Add(new Error
            //            {
            //                ErrorCode = "30000",
            //                ErrorMessage = "Formulário Status salvo não encontrado!"
            //            });
            //            response.Success = false;
            //        };
            //        return response;
            //    }
            //    else
            //    {
            //        response.Erros = messages;
            //    }
            //}
            //catch (Exception ex)
            //{
            //    response.ResourceCode = string.Empty;
            //    response.ErrorCode = 1;
            //    response.Message = "Erro ao obter a lista do Formulário Status.";
            //    response.Erros.Add(new AspNetMvc.Api.Domains.Dtos.Error(ex.Message, "", ex.StackTrace));
            //}

            return response;
        }

        [Route("Update")]
        [HttpPut]
        public ActionResult<FormularioStatusResponse> Update(FormularioStatusRequest request)
        {
            var response = new FormularioStatusResponse();

            //try
            //{
            //    var messages = request.Validate();
            //    if (messages.Count.Equals(0))
            //    {
            //        response = _formulairoStatusAppService.Update(request);
            //        if (response.FormularioStatus.Count == 0)
            //        {
            //            response.Erros.Add(new Error
            //            {
            //                ErrorCode = "30001",
            //                ErrorMessage = "Formulário Status salvo não encontrado!"
            //            });
            //            response.Success = false;
            //        };
            //        return response;
            //    }
            //    else
            //    {
            //        response.Erros = messages;
            //    }
            //}
            //catch (Exception ex)
            //{
            //    response.ResourceCode = string.Empty;
            //    response.ErrorCode = 1;
            //    response.Message = "Erro ao obter a lista do Formulário Status.";
            //    response.Erros.Add
            //        (new Acesscorp.Domains.Dtos.Error(ex.Message, "", ex.StackTrace));
            //}

            return response;
        }

        [Route("SaveOrUpdate")]
        [HttpPost]
        public ActionResult<FormularioStatusResponse> SaveOrUpdate(FormularioStatusRequest request)
        {
            var response = new FormularioStatusResponse();

            //try
            //{
            //    var messages = request.Validate();
            //    if (messages.Count.Equals(0))
            //    {
            //        if (request.FormularioStatus.TipoDeDadoId == 0)
            //        {
            //            response = _formularioStatusAppService.Insert(request);
            //        } else
            //        {
            //            response = _formularioStatusAppService.Update(request);
            //        }
            //        if (response.FormularioStatus.Count == 0)
            //        {
            //            response.Erros.Add(new Error
            //            {
            //                ErrorCode = "30002",
            //                ErrorMessage = "Formulário Status salvo não encontrado!"
            //            });
            //            response.Success = false;
            //        };
            //        return response;
            //    }
            //    else
            //    {
            //        response.Erros = messages;
            //    }
            //}
            //catch (Exception ex)
            //{
            //    response.ResourceCode = string.Empty;
            //    response.ErrorCode = 1;
            //    response.Message = "Erro ao obter a lista do Formulário Status.";
            //    response.Erros.Add(new Acesscorp.Domains.Dtos.Error(ex.Message, "", ex.StackTrace));
            //}

            return response;
        }

        [Route("Delete")]
        [HttpDelete]
        public ActionResult<FormularioStatusResponse> Delete(long id)
        {
            return null;
        }
    }
}