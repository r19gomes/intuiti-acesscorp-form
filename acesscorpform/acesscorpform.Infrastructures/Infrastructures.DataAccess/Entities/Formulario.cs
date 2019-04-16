using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Acesscorp.Infrastructures.DataAccess.Entities
{
    [Table("Formularios")]
    public partial class Formulario
    {
        [Key]
        public long FormularioId { get; set; }

        public string Nome { get; set; }

        public string Apelido { get; set; }

        public long FormularioStatusId { get; set; }

        public DateTime DataVigenciaInicial { get; set; }

        public DateTime DataVigenciaFinal { get; set; }

        public long FormularioTipoId { get; set; }

        public bool FlagStatus { get; set; }

        public long CadastroUsuarioId { get; set; }

        public DateTime CadastroDataHora { get; set; }

        public long AtualizacaoUsuarioId { get; set; }

        public DateTime AtualizacaoDataHora { get; set; }

        public virtual List<FormularioTipoDeAtributo> FormulariosTipoDeAtributos { get; set; }

        public virtual FormularioStatus FormularioStatus { get; set; }

        public virtual FormularioTipo FormularioTipos { get; set; }

    }
}
