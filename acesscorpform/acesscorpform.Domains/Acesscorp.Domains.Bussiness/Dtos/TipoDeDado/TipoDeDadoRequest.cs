using System.Collections.Generic;

namespace Acesscorp.Domains.Dtos.TipoDeDado
{
    public class TipoDeDadoRequest: RequestBase
    {
        #region Properties | Fields

        public TipoDeDado TipoDeDado { get; set; }

        #endregion

        #region Builders

        public TipoDeDadoRequest()
        {
            TipoDeDado = new TipoDeDado();
        }

        #endregion

        #region Methods

        public List<Error> Validate()
        {
            var messages = new List<Error>();

            if (TipoDeDado.TipoDeDadoId <= 0 && IsInserted == false)
            {
                var error = new Error()
                {
                    ErrorCode = "00001",
                    ErrorMessage = "Identificador sequencial único do Tipo de Dado é obrigatório!"
                };
                messages.Add(error);
            }

            if (string.IsNullOrEmpty(TipoDeDado.Nome))
            {
                var error = new Error()
                {
                    ErrorCode = "00002",
                    ErrorMessage = "Nome do Tipo de Dado é obrigatório!"
                };
                messages.Add(error);
            }

            if (TipoDeDado.CadastroUsuarioId <= 0)
            {
                var error = new Error()
                {
                    ErrorCode = "00003",
                    ErrorMessage = "Usuário responsável pelo cadastro do Tipo de Dado é obrigatório!"
                };
                messages.Add(error);
            }

            if (TipoDeDado.CadastroDataHora == null)
            {
                var error = new Error()
                {
                    ErrorCode = "00004",
                    ErrorMessage = "Data e hora de cadastro do Tipo de Dado e obrigatório!"
                };
                messages.Add(error);
            }

            return messages;
        }

        #endregion
    }
}
