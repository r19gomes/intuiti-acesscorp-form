using System.Collections.Generic;

namespace Acesscorp.Domains.Dtos.FormularioTipo
{
    public class FormularioTipoRequest: RequestBase
    {
        #region Properties | Fields

        public FormularioTipo FormularioTipo { get; set; }

        #endregion

        #region Builders

        public FormularioTipoRequest()
        {
            FormularioTipo = new FormularioTipo();
        }

        #endregion

        #region Methods

        public List<Error> Validate()
        {
            var messages = new List<Error>();

            if (FormularioTipo.FormularioTipoId <= 0 && IsInserted == false)
            {
                var error = new Error()
                {
                    ErrorCode = "00011",
                    ErrorMessage = "Identificador sequencial único do Tipo de Formulário é obrigatório!"
                };
                messages.Add(error);
            }

            if (string.IsNullOrEmpty(FormularioTipo.Nome))
            {
                var error = new Error()
                {
                    ErrorCode = "00012",
                    ErrorMessage = "Nome do Tipo de Formulário é obrigatório!"
                };
                messages.Add(error);
            }

            if (FormularioTipo.CadastroUsuarioId <= 0)
            {
                var error = new Error()
                {
                    ErrorCode = "00013",
                    ErrorMessage = "Usuário responsável pelo cadastro do Tipo de Formulário é obrigatório!"
                };
                messages.Add(error);
            }

            if (FormularioTipo.CadastroDataHora == null)
            {
                var error = new Error()
                {
                    ErrorCode = "00014",
                    ErrorMessage = "Data e hora de cadastro do Tipo de Formulário e obrigatório!"
                };
                messages.Add(error);
            }

            return messages;
        }

        #endregion

    }
}
