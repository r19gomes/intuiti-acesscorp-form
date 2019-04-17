using System.Collections.Generic;

namespace Acesscorp.Domains.Dtos.FormularioTipoDeAtributo
{
    public class FormularioTipoDeAtributoRequest : RequestBase
    {
        #region Properties | Fields

        public FormularioTipoDeAtributo FormularioTipoDeAtributo { get; set; }

        #endregion

        #region Builders

        public FormularioTipoDeAtributoRequest()
        {
            FormularioTipoDeAtributo = new FormularioTipoDeAtributo();
        }

        #endregion

        #region Methods

        public List<Error> Validate()
        {
            var messages = new List<Error>();

            if (FormularioTipoDeAtributo.FormularioTipoDeAtributoId <= 0 && IsInserted == false)
            {
                var error = new Error()
                {
                    ErrorCode = "00025",
                    ErrorMessage = "Identificador sequencial único do Tipo de Atributo do Formulário é obrigatório!"
                };
                messages.Add(error);
            }

            if (FormularioTipoDeAtributo.FormularioId <= 0)
            {
                var error = new Error()
                {
                    ErrorCode = "00026",
                    ErrorMessage = "Formulário é obrigatório!"
                };
                messages.Add(error);
            }

            if (FormularioTipoDeAtributo.TipoDeAtributoId <= 0)
            {
                var error = new Error()
                {
                    ErrorCode = "00027",
                    ErrorMessage = "Tipo de Atributo do Formulário é obrigatório!"
                };
                messages.Add(error);
            }

            if (FormularioTipoDeAtributo.CadastroUsuarioId <= 0)
            {
                var error = new Error()
                {
                    ErrorCode = "00028",
                    ErrorMessage = "Usuário responsável pelo cadastro do Tipo de Atributo do Formulário é obrigatório!"
                };
                messages.Add(error);
            }

            if (FormularioTipoDeAtributo.CadastroDataHora == null)
            {
                var error = new Error()
                {
                    ErrorCode = "00029",
                    ErrorMessage = "Data e hora de cadastro do Tipo de Atributo do Formulário e obrigatório!"
                };
                messages.Add(error);
            }

            return messages;
        }

        #endregion

    }
 }
