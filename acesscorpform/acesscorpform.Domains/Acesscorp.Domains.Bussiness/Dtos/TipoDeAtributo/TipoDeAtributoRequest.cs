using System.Collections.Generic;

namespace Acesscorp.Domains.Dtos.TipoDeAtributo
{
    public class TipoDeAtributoRequest: RequestBase
    {
        #region Properties | Fields

        public TipoDeAtributo TipoDeAtributo { get; set; }

        #endregion

        #region Builders

        public TipoDeAtributoRequest()
        {
            TipoDeAtributo = new TipoDeAtributo();
        }

        #endregion

        #region Methods

        public List<Error> Validate()
        {
            var messages = new List<Error>();

            if (TipoDeAtributo.TipoDeAtributoId <= 0 && IsInserted == false)
            {
                var error = new Error()
                {
                    ErrorCode = "00007",
                    ErrorMessage = "Identificador sequencial único do Tipo de Atributo é obrigatório!"
                };
                messages.Add(error);
            }

            if (string.IsNullOrEmpty(TipoDeAtributo.Nome))
            {
                var error = new Error()
                {
                    ErrorCode = "00008",
                    ErrorMessage = "Nome do Tipo de Atributo é obrigatório!"
                };
                messages.Add(error);
            }

            if (TipoDeAtributo.CadastroUsuarioId <= 0)
            {
                var error = new Error()
                {
                    ErrorCode = "00009",
                    ErrorMessage = "Usuário responsável pelo cadastro do Tipo de Atributo é obrigatório!"
                };
                messages.Add(error);
            }

            if (TipoDeAtributo.CadastroDataHora == null)
            {
                var error = new Error()
                {
                    ErrorCode = "00010",
                    ErrorMessage = "Data e hora de cadastro do Tipo de Atributo e obrigatório!"
                };
                messages.Add(error);
            }

            return messages;
        }

        #endregion

    }
}
