using System.Collections.Generic;

namespace Acesscorp.Domains.Dtos.FormularioStatus
{
    public class FormularioStatusRequest : RequestBase
    {
        #region Properties | Fields

        public FormularioStatus FormularioStatus { get; set; }

        #endregion

        #region Builders

        public FormularioStatusRequest()
        {
            FormularioStatus = new FormularioStatus();
        }

        #endregion

        #region Methods

        public List<Error> Validate()
        {
            var messages = new List<Error>();

            if (FormularioStatus.FormularioStatusId <= 0 && IsInserted == false)
            {
                var error = new Error()
                {
                    ErrorCode = "00015",
                    ErrorMessage = "Identificador sequencial único do Status do Formulário é obrigatório!"
                };
                messages.Add(error);
            }

            if (string.IsNullOrEmpty(FormularioStatus.Nome))
            {
                var error = new Error()
                {
                    ErrorCode = "00016",
                    ErrorMessage = "Nome do Status do Formulário é obrigatório!"
                };
                messages.Add(error);
            }

            if (FormularioStatus.CadastroUsuarioId <= 0)
            {
                var error = new Error()
                {
                    ErrorCode = "00017",
                    ErrorMessage = "Usuário responsável pelo cadastro do Status do Formulário é obrigatório!"
                };
                messages.Add(error);
            }

            if (FormularioStatus.CadastroDataHora == null)
            {
                var error = new Error()
                {
                    ErrorCode = "00018",
                    ErrorMessage = "Data e hora de cadastro do Status do Formulário e obrigatório!"
                };
                messages.Add(error);
            }

            return messages;
        }

        #endregion

    }
}
