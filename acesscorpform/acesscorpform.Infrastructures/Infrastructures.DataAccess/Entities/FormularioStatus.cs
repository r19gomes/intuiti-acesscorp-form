using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Acesscorp.Infrastructures.DataAccess.Entities
{
    [Table("FormulariosStatus")]
    public partial class FormularioStatus
    {
        [Key]
        public Int64 FormularioStatusId { get; set; }

        public string Nome { get; set; }

        public bool FlagStatus { get; set; }

        public Int64 CadastroUsuarioId { get; set; }

        public DateTime CadastroDataHora { get; set; }

        public Int64? AtualizacaoUsuarioId { get; set; }

        public DateTime? AtualizacaoDataHora { get; set; }

        public virtual List<Formulario> Formularios { get; set; }

    }
}
