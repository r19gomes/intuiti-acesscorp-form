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
                    response.Message = "Formulário não encontrado!";
                }
                return response;
            }
            catch (Exception ex)
            {
                response.ResourceCode = string.Empty;
                response.ErrorCode = 1;
                response.Message = "Erro ao obter a lista do Formulário.";
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
                        ErrorCode = "30004",
                        ErrorMessage = "Formulário não encontrado!"
                    });
                    response.Success = false;
                };
                return response;
            }
            catch (Exception ex)
            {
                response.ResourceCode = string.Empty;
                response.ErrorCode = 1;
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

            //try
            //{
            //    //var messages = request.Validate();
            //    string[] messages = null;
            //    if (messages.Count.Equals(0))
            //    {
            //        response = _formulairoAppService.Insert(request);
            //        if (response.Formulario.Count == 0)
            //        {
            //            response.Erros.Add(new Error
            //            {
            //                ErrorCode = "30000",
            //                ErrorMessage = "Formulário salvo não encontrado!"
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
            //    response.Message = "Erro ao obter a lista do Formulário.";
            //    response.Erros.Add(new AspNetMvc.Api.Domains.Dtos.Error(ex.Message, "", ex.StackTrace));
            //}

            return response;
        }

        [Route("Update")]
        [HttpPut]
        public ActionResult<FormularioResponse> Update(FormularioRequest request)
        {
            var response = new FormularioResponse();

            //try
            //{
            //    var messages = request.Validate();
            //    if (messages.Count.Equals(0))
            //    {
            //        response = _formulairoAppService.Update(request);
            //        if (response.Formulario.Count == 0)
            //        {
            //            response.Erros.Add(new Error
            //            {
            //                ErrorCode = "30001",
            //                ErrorMessage = "Formulário salvo não encontrado!"
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
            //    response.Message = "Erro ao obter a lista do Formulário.";
            //    response.Erros.Add
            //        (new Acesscorp.Domains.Dtos.Error(ex.Message, "", ex.StackTrace));
            //}

            return response;
        }

        [Route("SaveOrUpdate")]
        [HttpPost]
        public ActionResult<FormularioResponse> SaveOrUpdate(FormularioRequest request)
        {
            var response = new FormularioResponse();

            //try
            //{
            //    var messages = request.Validate();
            //    if (messages.Count.Equals(0))
            //    {
            //        if (request.Formulario.TipoDeDadoId == 0)
            //        {
            //            response = _formularioAppService.Insert(request);
            //        } else
            //        {
            //            response = _formularioAppService.Update(request);
            //        }
            //        if (response.Formulario.Count == 0)
            //        {
            //            response.Erros.Add(new Error
            //            {
            //                ErrorCode = "30002",
            //                ErrorMessage = "Formulário salvo não encontrado!"
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
            //    response.Message = "Erro ao obter a lista do Formulário.";
            //    response.Erros.Add(new Acesscorp.Domains.Dtos.Error(ex.Message, "", ex.StackTrace));
            //}

            return response;
        }

        [Route("Delete")]
        [HttpDelete]
        public ActionResult<FormularioResponse> Delete(long id)
        {
            return null;
        }
    }
}