using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Acesscorp.Infrastructures.DataAccess.Models
{
    public class FormularioTipoDeAtributo
    {
        [Key, Column(Order = 0), Required]
        public long FormularioTipoDeAtributoId { get; set; }

        [Column(Order = 1), Required]
        public long FormularioId { get; set; }

        [Column(Order = 2), Required]
        public long TipoDeAtributoId { get; set; }

        [Column(Order = 3), Required]
        public string Observacao { get; set; }        

        [Column(Order = 4), Required]
        public bool FlagStatus { get; set; }

        [Column(Order = 5), Required]
        public long CadastroUsuarioId { get; set; }

        [Column(Order = 6), Required]
        public DateTime CadastroDataHora { get; set; }

        [Column(Order = 7)]
        public long AtualizacaoUsuarioId { get; set; }

        [Column(Order = 8)]
        public DateTime AtualizacaoDataHora { get; set; }

        public Formulario Formularios { get; set; }

        public TipoDeAtributo TipoDeAtributos { get; set; }

    }
}