using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Acesscorp.Infrastructures.DataAccess.Entities
{
    [Table("FormulariosTipos")]
    public partial class FormularioTipo
    {
        [Key]
        public Int64 FormularioTipoId { get; set; }

        public string Nome { get; set; }

        public string Apelido { get; set; }

        public bool FlagStatus { get; set; }

        public Int64 CadastroUsuarioId { get; set; }

        public DateTime CadastroDataHora { get; set; }

        public Int64? AtualizacaoUsuarioId { get; set; }

        public DateTime? AtualizacaoDataHora { get; set; }

        public virtual List<Formulario> Formularios { get; set; }
    }
}
