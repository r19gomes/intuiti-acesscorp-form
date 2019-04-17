using System.Collections.Generic;

namespace Acesscorp.Domains.Dtos.Formulario
{
    public class FormularioRequest : RequestBase
    {
        #region Properties | Fields

        public Formulario Formulario { get; set; }

        #endregion

        #region Builders

        public FormularioRequest()
        {
            Formulario = new Formulario();
        }

        #endregion

        #region Methods
        public List<Error> Validate()
        {
            var messages = new List<Error>();

            if (Formulario.FormularioId <= 0 && IsInserted == false)
            {
                var error = new Error()
                {
                    ErrorCode = "00019",
                    ErrorMessage = "Identificador sequencial único do Formulário é obrigatório!"
                };
                messages.Add(error);
            }

            if (string.IsNullOrEmpty(Formulario.Nome))
            {
                var error = new Error()
                {
                    ErrorCode = "00020",
                    ErrorMessage = "Nome do Formulário é obrigatório!"
                };
                messages.Add(error);
            }

            if (Formulario.FormularioStatusId <= 0)
            {
                var error = new Error()
                {
                    ErrorCode = "00021",
                    ErrorMessage = "Status do Formulário é obrigatório!"
                };
                messages.Add(error);
            }

            if (Formulario.FormularioTipoId <= 0)
            {
                var error = new Error()
                {
                    ErrorCode = "00022",
                    ErrorMessage = "Tipo do Formulário é obrigatório!"
                };
                messages.Add(error);
            }

            if (Formulario.CadastroUsuarioId <= 0)
            {
                var error = new Error()
                {
                    ErrorCode = "00023",
                    ErrorMessage = "Usuário responsável pelo cadastro do Formulário é obrigatório!"
                };
                messages.Add(error);
            }

            if (Formulario.CadastroDataHora == null)
            {
                var error = new Error()
                {
                    ErrorCode = "00024",
                    ErrorMessage = "Data e hora de cadastro do Formulário e obrigatório!"
                };
                messages.Add(error);
            }

            return messages;
        }

        #endregion

    }
}
