using System;

namespace Acesscorp.Applications.Dtos
{
    public class FormularioDto
    {
        public Int64 FormularioId { get; set; }

        public string Nome { get; set; }

        public string Apelido { get; set; }

        public Int64 FormularioStatusId { get; set; }

        public DateTime DataVigenciaInicial { get; set; }

        public DateTime DataVigenciaFinal { get; set; }

        public Int64 FormularioTipoId { get; set; }

        public bool FlagStatus { get; set; }

        public Int64 CadastroUsuarioId { get; set; }

        public DateTime CadastroDataHora { get; set; }

        public Int64? AtualizacaoUsuarioId { get; set; }

        public DateTime? AtualizacaoDataHora { get; set; }
    }
}
