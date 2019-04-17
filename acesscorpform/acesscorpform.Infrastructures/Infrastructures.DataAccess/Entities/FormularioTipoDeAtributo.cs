using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Acesscorp.Infrastructures.DataAccess.Entities
{
    [Table("FormulariosTipoDeAtributos")]
    public partial class FormularioTipoDeAtributo
    {
        [Key]
        public Int64 FormularioTipoDeAtributoId { get; set; }
        
        public Int64 FormularioId { get; set; }

        public Int64 TipoDeAtributoId { get; set; }

        public string Observacao { get; set; }
        
        public bool FlagStatus { get; set; }

        public Int64 CadastroUsuarioId { get; set; }

        public DateTime CadastroDataHora { get; set; }

        public Int64? AtualizacaoUsuarioId { get; set; }

        public DateTime? AtualizacaoDataHora { get; set; }

        public virtual Formulario Formulario { get; set; }

        public virtual TipoDeAtributo TipoDeAtributos { get; set; }
    }
}
