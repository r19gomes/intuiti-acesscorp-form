using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Acesscorp.Infrastructures.DataAccess.Models
{
    public class FormularioTipo
    {
        [Key, Column(Order = 0), Required]
        public int FormularioTipoId { get; set; }

        [Column(Order = 1), Required]
        public string Nome { get; set; }

        [Column(Order = 3), Required]
        public long CadastroUsuarioId { get; set; }

        [Column(Order = 4), Required]
        public DateTime CadastroDataHora { get; set; }

        [Column(Order = 5)]
        public long AtualizacaoUsuarioId { get; set; }

        [Column(Order = 6)]
        public DateTime AtualizacaoDataHora { get; set; }

        public List<Formulario> Formularios { get; set; }
    }
}
