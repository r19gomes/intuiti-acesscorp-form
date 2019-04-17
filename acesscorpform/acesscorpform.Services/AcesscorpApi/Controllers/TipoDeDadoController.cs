using Acesscorp.Applications.Contract.TipoDeDado;
using Acesscorp.Domains.Dtos;
using Acesscorp.Domains.Dtos.TipoDeDado;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Acesscorp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipoDeDadoController : ControllerBase
    {
        private readonly ITipoDeDadoAppService _tipoDeDadoAppService;

        public TipoDeDadoController(ITipoDeDadoAppService tipoDeDadoAppService) : base()
        {
            _tipoDeDadoAppService = tipoDeDadoAppService;
        }

        [Route("Get")]
        [HttpGet]
        public ActionResult<TipoDeDadoResponse> Get(long id)
        {
            var response = new TipoDeDadoResponse();

            try
            {
                response = _tipoDeDadoAppService.Get(id);

                if (response.TipoDeDado.Count == 0)
                {
                    response.Message = "Tipo de Dado não encontrado!";
                }
                return response;
            }
            catch (Exception ex)
            {
                response.ResourceCode = string.Empty;
                response.ErrorCode = 1;
                response.Message = "Erro ao obter a lista dos Tipos de Dados.";
                response.Erros.Add(new Acesscorp.Domains.Dtos.Error(ex.Message, "", ex.StackTrace));
            }

            return response;
        }

        [Route("GetAll")]
        [HttpGet]
        public ActionResult<TipoDeDadoResponse> GetAll()
        {
            var response = new TipoDeDadoResponse();

            try
            {
                response = _tipoDeDadoAppService.GetAll();

                if (response.TipoDeDado.Count == 0)
                {
                    response.Erros.Add(new Error
                    {
                        ErrorCode = "30004",
                        ErrorMessage = "Tipo de Dado não encontrado!"
                    });
                    response.Success = false;
                };
                return response;
            }
            catch (Exception ex)
            {
                response.ResourceCode = string.Empty;
                response.ErrorCode = 1;
                response.Message = "Erro ao obter a lista dos Tipos de Dados.";
                response.Erros.Add(new Acesscorp.Domains.Dtos.Error(ex.Message, "", ex.StackTrace));
            }

            return response;
        }

        [Route("Insert")]
        [HttpPost]
        public ActionResult<TipoDeDadoResponse> Insert(TipoDeDadoRequest request)
        {
            var response = new TipoDeDadoResponse();

            try
            {
                request.IsInserted = true;
                var messages = request.Validate();
                if (messages.Count.Equals(0))
                {
                    response = _tipoDeDadoAppService.Insert(request);
                    if (response.TipoDeDado.Count == 0)
                    {
                        response.Erros.Add(new Error
                        {
                            ErrorCode = "00005",
                            ErrorMessage = "Tipo de Dado salvo não encontrado!"
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
                response.ErrorCode = 6; //- ErrorCode = "00006"
                response.Message = "Erro ao inserrir o Tipo de Dado.";
                response.Erros.Add(new Acesscorp.Domains.Dtos.Error(ex.Message, "", ex.StackTrace));
            }

            return response;
        }

        [Route("Update")]
        [HttpPut]
        public ActionResult<TipoDeDadoResponse> Update(TipoDeDadoRequest request)
        {
            var response = new TipoDeDadoResponse();

            //try
            //{
            //    var messages = request.Validate();
            //    if (messages.Count.Equals(0))
            //    {
            //        response = _tipoDeDadoAppService.Update(request);
            //        if (response.TipoDeDado.Count == 0)
            //        {
            //            response.Erros.Add(new Error
            //            {
            //                ErrorCode = "30001",
            //                ErrorMessage = "Tipo de Dado salvo não encontrado!"
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
            //    response.Message = "Erro ao obter a lista dos Bancos.";
            //    response.Erros.Add
            //        (new Acesscorp.Domains.Dtos.Error(ex.Message, "", ex.StackTrace));
            //}

            return response;
        }

        [Route("SaveOrUpdate")]
        [HttpPost]
        public ActionResult<TipoDeDadoResponse> SaveOrUpdate(TipoDeDadoRequest request)
        {
            var response = new TipoDeDadoResponse();

            //try
            //{
            //    var messages = request.Validate();
            //    if (messages.Count.Equals(0))
            //    {
            //        if (request.TipoDeDado.TipoDeDadoId == 0)
            //        {
            //            response = _tipoDeDadoAppService.Insert(request);
            //        } else
            //        {
            //            response = _tipoDeDadoAppService.Update(request);
            //        }
            //        if (response.TipoDeDado.Count == 0)
            //        {
            //            response.Erros.Add(new Error
            //            {
            //                ErrorCode = "30002",
            //                ErrorMessage = "Tipo de Dado salvo não encontrado!"
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
            //    response.Message = "Erro ao obter a lista do Tipo de Dado.";
            //    response.Erros.Add(new Acesscorp.Domains.Dtos.Error(ex.Message, "", ex.StackTrace));
            //}

            return response;
        }

        [Route("Delete")]
        [HttpDelete]
        public ActionResult<TipoDeDadoResponse> Delete(long id)
        {
            return null;
        }
    }
}