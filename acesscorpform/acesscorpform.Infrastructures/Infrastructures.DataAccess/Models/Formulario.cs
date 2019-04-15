using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Acesscorp.Infrastructures.DataAccess.Models
{
    public class Formulario
    {
        [Key, Column(Order = 0), Required]
        public long FormularioId { get; set; }

        [Column(Order = 1), Required]
        public string Nome { get; set; }

        [Column(Order = 2), Required]
        public string Apelido { get; set; }

        [Column(Order = 3), Required]
        public long FormularioStatusId { get; set; }

        [Column(Order = 4), Required]
        public DateTime DataVigenciaInicial { get; set; }

        [Column(Order = 5), Required]
        public DateTime DataVigenciaFinal { get; set; }

        [Column(Order = 6), Required]
        public long FormularioTipoId { get; set; }

        [Column(Order = 7), Required]
        public bool FlagStatus { get; set; }

        [Column(Order = 8), Required]
        public long CadastroUsuarioId { get; set; }

        [Column(Order = 9), Required]
        public DateTime CadastroDataHora { get; set; }

        [Column(Order = 0), Required]
        public long AtualizacaoUsuarioId { get; set; }

        [Column(Order = 0), Required]
        public DateTime AtualizacaoDataHora { get; set; }

        public FormularioTipo FormulariosTipos { get; set; }

        public FormularioStatus FormulariosStatus { get; set; }

    }
}