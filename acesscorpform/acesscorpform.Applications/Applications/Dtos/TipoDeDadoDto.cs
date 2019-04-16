using System;

namespace Acesscorp.Applications.Dtos
{
    public class TipoDeDadoDto
    {
        public Int64 TipoDeDadoId { get; set; }

        public string Nome { get; set; }

        public bool FlagStatus { get; set; }

        public long CadastroUsuarioId { get; set; }

        public DateTime CadastroDataHora { get; set; }

        public long? AtualizacaoUsuarioId { get; set; }

        public long? AtualizacaoDataHora { get; set; }
    }
}
