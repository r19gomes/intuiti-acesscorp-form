using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Acesscorp.Infrastructures.DataAccess.Entities
{
    [Table("FormulariosTipoDeAtributos")]
    public partial class FormulariosTipoDeAtributo
    {
        [Key]
        public long FormularioTipoDeAtributoId { get; set; }
        
        public long FormularioId { get; set; }

        public long TipoDeAtributoId { get; set; }

        public string Observacao { get; set; }
        
        public bool FlagStatus { get; set; }

        public long CadastroUsuarioId { get; set; }

        public DateTime CadastroDataHora { get; set; }

        public long AtualizacaoUsuarioId { get; set; }

        public DateTime AtualizacaoDataHora { get; set; }

        public virtual Formulario Formulario { get; set; }

        public virtual TipoDeAtributo TipoDeAtributos { get; set; }
    }
}
