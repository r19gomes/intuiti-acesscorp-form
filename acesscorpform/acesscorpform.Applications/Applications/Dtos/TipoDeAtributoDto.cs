using System;
using System.Collections.Generic;
using System.Text;

namespace Acesscorp.Applications.Dtos
{
    public class TipoDeAtributoDto
    {
        public long TipoDeAtributoId { get; set; }

        public string Nome { get; set; }

        public string Apelido { get; set; }

        public string Descricao { get; set; }

        public string NomeFisico { get; set; }

        public Int64 TipoDeDadoId { get; set; }

        public bool FlagStatus { get; set; }

        public int OrdemExibicao { get; set; }

        public bool Limitador { get; set; }

        public bool Qualificador { get; set; }

        public DateTime CadastroDataHora { get; set; }

        public long CadastroUsuarioId { get; set; }

        public DateTime? AtualizacaoDataHora { get; set; }

        public long? AtualizacaoUsuarioId { get; set; }
    }
}
