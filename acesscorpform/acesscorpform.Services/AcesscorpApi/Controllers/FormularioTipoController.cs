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
        public ActionResult<FormularioTipoResponse> Get(long id)
        {
            var response = new FormularioTipoResponse();

            try
            {
                response = _formularioTipoAppService.Get(id);

                if (response.FormularioTipo.Count == 0)
                {
                    response.Message = "Formulário Tipo não encontrado!";
                }
                return response;
            }
            catch (Exception ex)
            {
                response.ResourceCode = string.Empty;
                response.ErrorCode = 1;
                response.Message = "Erro ao obter a lista do Formulário Tipo.";
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

                if (response.FormulairoTipo.Count == 0)
                {
                    response.Erros.Add(new Error
                    {
                        ErrorCode = "30004",
                        ErrorMessage = "Formulário Tipo não encontrado!"
                    });
                    response.Success = false;
                };
                return response;
            }
            catch (Exception ex)
            {
                response.ResourceCode = string.Empty;
                response.ErrorCode = 1;
                response.Message = "Erro ao obter a lista do Formulário Tipo.";
                response.Erros.Add(new Acesscorp.Domains.Dtos.Error(ex.Message, "", ex.StackTrace));
            }

            return response;
        }

        [Route("Insert")]
        [HttpPost]
        public ActionResult<FormularioTipoResponse> Insert(FormularioTipoRequest request)
        {
            var response = new FormularioTipoResponse();

            //try
            //{
            //    //var messages = request.Validate();
            //    string[] messages = null;
            //    if (messages.Count.Equals(0))
            //    {
            //        response = _formulairoTipoAppService.Insert(request);
            //        if (response.FormularioTipo.Count == 0)
            //        {
            //            response.Erros.Add(new Error
            //            {
            //                ErrorCode = "30000",
            //                ErrorMessage = "Formulário Tipo salvo não encontrado!"
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
            //    response.Message = "Erro ao obter a lista do Formulário Tipo.";
            //    response.Erros.Add(new AspNetMvc.Api.Domains.Dtos.Error(ex.Message, "", ex.StackTrace));
            //}

            return response;
        }

        [Route("Update")]
        [HttpPut]
        public ActionResult<FormularioTipoResponse> Update(FormularioTipoRequest request)
        {
            var response = new FormularioTipoResponse();

            //try
            //{
            //    var messages = request.Validate();
            //    if (messages.Count.Equals(0))
            //    {
            //        response = _formulairoTipoAppService.Update(request);
            //        if (response.FormularioTipo.Count == 0)
            //        {
            //            response.Erros.Add(new Error
            //            {
            //                ErrorCode = "30001",
            //                ErrorMessage = "Formulário Tipo salvo não encontrado!"
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
            //    response.Message = "Erro ao obter a lista do Formulário Tipo.";
            //    response.Erros.Add
            //        (new Acesscorp.Domains.Dtos.Error(ex.Message, "", ex.StackTrace));
            //}

            return response;
        }

        [Route("SaveOrUpdate")]
        [HttpPost]
        public ActionResult<FormularioTipoResponse> SaveOrUpdate(FormularioTipoRequest request)
        {
            var response = new FormularioTipoResponse();

            //try
            //{
            //    var messages = request.Validate();
            //    if (messages.Count.Equals(0))
            //    {
            //        if (request.FormularioTipo.TipoDeDadoId == 0)
            //        {
            //            response = _formularioTipoAppService.Insert(request);
            //        } else
            //        {
            //            response = _formularioTipoAppService.Update(request);
            //        }
            //        if (response.FormularioTipo.Count == 0)
            //        {
            //            response.Erros.Add(new Error
            //            {
            //                ErrorCode = "30002",
            //                ErrorMessage = "Formulário Tipo salvo não encontrado!"
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
            //    response.Message = "Erro ao obter a lista do Formulário Tipo.";
            //    response.Erros.Add(new Acesscorp.Domains.Dtos.Error(ex.Message, "", ex.StackTrace));
            //}

            return response;
        }

        [Route("Delete")]
        [HttpDelete]
        public ActionResult<FormularioTipoResponse> Delete(long id)
        {
            return null;
        }
    }
}