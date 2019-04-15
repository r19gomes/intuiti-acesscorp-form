using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Acesscorp.Infrastructures.DataAccess.Entities
{
    [Table("FormulariosStatus")]
    public partial class FormularioStatus
    {
        [Key]
        public long FormularioStatusId { get; set; }

        public string Nome { get; set; }

        public bool FlagStatus { get; set; }

        public long CadastroUsuarioId { get; set; }

        public DateTime CadastroDataHora { get; set; }

        public long AtualizacaoUsuarioId { get; set; }

        public DateTime AtualizacaoDataHora { get; set; }

        public virtual List<Formulario> Formularios { get; set; }

    }
}
