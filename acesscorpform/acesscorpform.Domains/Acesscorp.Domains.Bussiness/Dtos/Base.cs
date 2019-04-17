﻿using System;

namespace Acesscorp.Domains.Dtos
{
    public class Base
    {
        #region Properties | Fields

        public bool FlagStatus { get; set; }

        public Int64 CadastroUsuarioId { get; set; }

        public DateTime CadastroDataHora { get; set; }

        public Int64? AtualizacaoUsuarioId { get; set; }

        public DateTime? AtualizacaoDataHora { get; set; }

        #endregion

        #region Builders

        public Base()
        {
            CadastroDataHora = 
                CadastroDataHora > DateTime.MinValue ? CadastroDataHora : DateTime.Now;
            AtualizacaoDataHora = 
                AtualizacaoDataHora.HasValue && AtualizacaoDataHora.Value > DateTime.MinValue ? AtualizacaoDataHora.Value : DateTime.Now;
        }

        public Base(Base dto)
        {
            if (dto != null)
            {
                this.FlagStatus = dto.FlagStatus;
                this.CadastroUsuarioId = dto.CadastroUsuarioId;
                this.CadastroDataHora = dto.CadastroDataHora;
                this.AtualizacaoUsuarioId = dto.AtualizacaoUsuarioId;
                this.AtualizacaoDataHora = dto.AtualizacaoDataHora;
            }
        }

        #endregion
    }

}
