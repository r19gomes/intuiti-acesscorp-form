using System;

namespace Acesscorp.Applications.Dtos
{
    public class FormularioStatusDto
    {
        public Int64 FormularioStatusId { get; set; }

        public string Nome { get; set; }

        public bool FlagStatus { get; set; }

        public long CadastroUsuarioId { get; set; }

        public DateTime CadastroDataHora { get; set; }

        public Int64? AtualizacaoUsuarioId { get; set; }

        public DateTime? AtualizacaoDataHora { get; set; }
    }
}
