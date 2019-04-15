using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Acesscorp.Infrastructures.DataAccess.Models
{
    public class TipoDeDado
    {
        [Key, Column(Order = 0)]
        public long TipoDeDadoId { get; set; }

        [Column(Order = 1), Required]
        public string Nome { get; set; }

        [Column(Order = 2), Required]
        public bool FlagStatus { get; set; }

        [Column(Order = 3), Required]
        public long CadastroUsuarioId { get; set; }

        [Column(Order = 4), Required]
        public DateTime CadastroDataHora { get; set; }

        [Column(Order = 5)]
        public long AtualizacaoUsuarioId { get; set; }

        [Column(Order = 6)]
        public DateTime AtualizacaoDataHora { get; set; }

        public List<TipoDeAtributo> TipoDeAtributos { get; set; }
    }
}
