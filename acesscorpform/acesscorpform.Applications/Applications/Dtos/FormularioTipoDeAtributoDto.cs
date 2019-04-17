using System;

namespace Acesscorp.Applications.Dtos
{
    public class FormularioTipoDeAtributoDto
    {
        public Int64 FormularioTipoId { get; set; }

        public bool FlagStatus { get; set; }

        public Int64 CadastroUsuarioId { get; set; }

        public DateTime CadastroDataHora { get; set; }

        public Int64? AtualizacaoUsuarioId { get; set; }

        public DateTime? AtualizacaoDataHora { get; set; }
    }
}
