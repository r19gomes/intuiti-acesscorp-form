using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Acesscorp.Infrastructures.DataAccess.Models
{
    public partial class TipoDeAtributo
    {

        [Key, Column(Order = 0), Required]
        public long TipoDeAtributoId { get; set; }

        [Column(Order = 1), Required]
        public string Nome { get; set; }

        [Column(Order = 3), Required]
        public string Apelido { get; set; }

        [Column(Order = 4)]
        public string Descricao { get; set; }

        [Column(Order = 5)]
        public string NomeFisico { get; set; }

        [Column(Order = 6)]
        public long TipoDeDadoId { get; set; }
        
        [Column(Order = 7)]
        public int OrdemExibicao { get; set; }
        
        [Column(Order = 8)]
        public bool Limitador { get; set; }
        
        [Column(Order = 9)]
        public bool Qualificador { get; set; }            
        
        [Column(Order = 10), Required]
        public bool FlagStatus { get; set; }

        [Column(Order = 11), Required]
        public long CadastroUsuarioId { get; set; }

        [Column(Order = 12), Required]
        public DateTime CadastroDataHora { get; set; }

        [Column(Order = 13)]
        public long AtualizacaoUsuarioId { get; set; }

        [Column(Order = 14)]
        public DateTime AtualizacaoDataHora { get; set; }

        public TipoDeDado TipoDeDados { get; set; }

        public List<FormularioTipoDeAtributo> FormulariosTipoDeAtributos { get; set; }
    }
}