﻿using Acesscorp.Domains.Contracts.Repositories;
using Acesscorp.Infrastructures.DataAccess.Contexts;
using Acesscorp.Infrastructures.DataAccess.Repositories.Base;
using System.Collections.Generic;
using System.Linq;
using TipoDeAtributo = Acesscorp.Infrastructures.DataAccess.Entities.TipoDeAtributo;

namespace Acesscorp.Infrastructures.DataAccess.Repositories
{
    public class TipoDeAtributoRepositories : RepositoryBase<TipoDeAtributo>, ITipoDeAtributoRepositories
    {
        #region Builders

        public TipoDeAtributoRepositories()
        {
        }

        public TipoDeAtributoRepositories(DbContext dbContext) : base()
        {
            if (dbContext == null)
                dbContext = base.DbContext;
        }

        #endregion

        #region Methods

        public Domains.Dtos.TipoDeAtributo.TipoDeAtributo Get(long id)
        {
            Domains.Dtos.TipoDeAtributo.TipoDeAtributo result =
                new Domains.Dtos.TipoDeAtributo.TipoDeAtributo();

            using (var ctx = new DbContext())
            {
                var tipoDeAtributo = ctx.TipoDeAtributos.Find(id);

                result.TipoDeAtributoId = tipoDeAtributo.TipoDeAtributoId;
                result.Nome = tipoDeAtributo.Nome;
                result.Apelido = tipoDeAtributo.Apelido;
                result.Descricao = tipoDeAtributo.Descricao;
                result.NomeFisico = tipoDeAtributo.NomeFisico;
                result.TipoDeDadoId = tipoDeAtributo.TipoDeDadoId;
                result.FlagStatus = tipoDeAtributo.FlagStatus;
                result.OrdemExibicao = tipoDeAtributo.OrdemExibicao;
                result.Limitador = tipoDeAtributo.Limitador;
                result.Qualificador = tipoDeAtributo.Qualificador;
                result.CadastroUsuarioId = tipoDeAtributo.CadastroUsuarioId;
                result.CadastroDataHora = tipoDeAtributo.CadastroDataHora;
                result.AtualizacaoUsuarioId = tipoDeAtributo.AtualizacaoUsuarioId;
                result.AtualizacaoDataHora = tipoDeAtributo.AtualizacaoDataHora;
            }

            return result;
        }

        public IList<Domains.Dtos.TipoDeAtributo.TipoDeAtributo> GetAll()
        {
            IList<Domains.Dtos.TipoDeAtributo.TipoDeAtributo> result =
                new List<Domains.Dtos.TipoDeAtributo.TipoDeAtributo>();

            using (var ctx = new DbContext())
            {
                var ret = ctx.TipoDeAtributos.ToList();
                if (ret.Count > 0)
                {
                    foreach (var item in ret)
                    {
                        result.Add(new Domains.Dtos.TipoDeAtributo.TipoDeAtributo
                        {
                            TipoDeAtributoId = item.TipoDeAtributoId,
                            Nome = item.Nome,
                            Apelido = item.Apelido,
                            Descricao = item.Descricao,
                            NomeFisico = item.NomeFisico,
                            TipoDeDadoId = item.TipoDeDadoId,
                            FlagStatus = item.FlagStatus,
                            OrdemExibicao = item.OrdemExibicao,
                            Limitador = item.Limitador,
                            Qualificador = item.Qualificador,
                            CadastroUsuarioId = item.CadastroUsuarioId,
                            CadastroDataHora = item.CadastroDataHora,
                            AtualizacaoUsuarioId = item.AtualizacaoUsuarioId,
                            AtualizacaoDataHora = item.CadastroDataHora
                        });
                    }
                }
            }

            return result;
        }

        public Acesscorp.Domains.Dtos.TipoDeAtributo.TipoDeAtributo Insert
            (Acesscorp.Domains.Dtos.TipoDeAtributo.TipoDeAtributoRequest request)
        {
            Acesscorp.Domains.Dtos.TipoDeAtributo.TipoDeAtributo result =
                new Acesscorp.Domains.Dtos.TipoDeAtributo.TipoDeAtributo();

            using (var ctx = new DbContext())
            {
                var entities = new Entities.TipoDeAtributo
                {
                    TipoDeAtributoId = request.TipoDeAtributo.TipoDeAtributoId,
                    Nome = request.TipoDeAtributo.Nome,
                    Apelido = request.TipoDeAtributo.Apelido,
                    Descricao = request.TipoDeAtributo.Descricao,
                    NomeFisico = request.TipoDeAtributo.NomeFisico,
                    TipoDeDadoId = request.TipoDeAtributo.TipoDeDadoId,
                    FlagStatus = request.TipoDeAtributo.FlagStatus,
                    OrdemExibicao = request.TipoDeAtributo.OrdemExibicao,
                    Limitador = request.TipoDeAtributo.Limitador,
                    Qualificador = request.TipoDeAtributo.Qualificador,
                    CadastroUsuarioId = request.TipoDeAtributo.CadastroUsuarioId,
                    CadastroDataHora = request.TipoDeAtributo.CadastroDataHora,
                    AtualizacaoUsuarioId = request.TipoDeAtributo.AtualizacaoUsuarioId,
                    AtualizacaoDataHora = request.TipoDeAtributo.AtualizacaoDataHora
                };
                ctx.TipoDeAtributos.Add(entities);
                ctx.SaveChanges();
                if (entities != null)
                {
                    result = new Acesscorp.Domains.Dtos.TipoDeAtributo.TipoDeAtributo()
                    {
                        TipoDeAtributoId = entities.TipoDeAtributoId,
                        Nome = entities.Nome,
                        Apelido = entities.Apelido,
                        Descricao = entities.Descricao,
                        NomeFisico = entities.NomeFisico,
                        TipoDeDadoId = entities.TipoDeDadoId,
                        FlagStatus = entities.FlagStatus,
                        OrdemExibicao = entities.OrdemExibicao,
                        Limitador = entities.Limitador,
                        Qualificador = entities.Qualificador,
                        CadastroUsuarioId = entities.CadastroUsuarioId,
                        CadastroDataHora = entities.CadastroDataHora,
                        AtualizacaoUsuarioId = entities.AtualizacaoUsuarioId,
                        AtualizacaoDataHora = entities.AtualizacaoDataHora
                    };
                }
            }

            return result;
        }

        public Acesscorp.Domains.Dtos.TipoDeAtributo.TipoDeAtributo Update
            (Acesscorp.Domains.Dtos.TipoDeAtributo.TipoDeAtributoRequest request)
        {
            Acesscorp.Domains.Dtos.TipoDeAtributo.TipoDeAtributo result =
                new Acesscorp.Domains.Dtos.TipoDeAtributo.TipoDeAtributo();

            using (var ctx = new DbContext())
            {
                var entities = new Entities.TipoDeAtributo
                {
                    TipoDeAtributoId = request.TipoDeAtributo.TipoDeAtributoId,
                    Nome = request.TipoDeAtributo.Nome,
                    Apelido = request.TipoDeAtributo.Apelido,
                    Descricao = request.TipoDeAtributo.Descricao,
                    NomeFisico = request.TipoDeAtributo.NomeFisico,
                    TipoDeDadoId = request.TipoDeAtributo.TipoDeDadoId,
                    FlagStatus = request.TipoDeAtributo.FlagStatus,
                    OrdemExibicao = request.TipoDeAtributo.OrdemExibicao,
                    Limitador = request.TipoDeAtributo.Limitador,
                    Qualificador = request.TipoDeAtributo.Qualificador,
                    CadastroUsuarioId = request.TipoDeAtributo.CadastroUsuarioId,
                    CadastroDataHora = request.TipoDeAtributo.CadastroDataHora,
                    AtualizacaoUsuarioId = request.TipoDeAtributo.AtualizacaoUsuarioId > 0 ?
                        request.TipoDeAtributo.AtualizacaoUsuarioId : null,
                    AtualizacaoDataHora = request.TipoDeAtributo.AtualizacaoUsuarioId > 0 ?
                        request.TipoDeAtributo.AtualizacaoDataHora : null
                };
                ctx.Update(entities);
                ctx.SaveChanges();
                if (entities != null)
                {
                    result = new Acesscorp.Domains.Dtos.TipoDeAtributo.TipoDeAtributo()
                    {
                        TipoDeAtributoId = entities.TipoDeAtributoId,
                        Nome = entities.Nome,
                        Apelido = entities.Apelido,
                        Descricao = entities.Descricao,
                        NomeFisico = entities.NomeFisico,
                        TipoDeDadoId = entities.TipoDeDadoId,
                        FlagStatus = entities.FlagStatus,
                        OrdemExibicao = entities.OrdemExibicao,
                        Limitador = entities.Limitador,
                        Qualificador = entities.Qualificador,
                        CadastroUsuarioId = entities.CadastroUsuarioId,
                        CadastroDataHora = entities.CadastroDataHora,
                        AtualizacaoUsuarioId = entities.AtualizacaoUsuarioId,
                        AtualizacaoDataHora = entities.AtualizacaoDataHora
                    };
                }

            }

            return result;
        }

        public Acesscorp.Domains.Dtos.TipoDeAtributo.TipoDeAtributo Delete(long id)
        {
            Acesscorp.Domains.Dtos.TipoDeAtributo.TipoDeAtributo result =
                new Acesscorp.Domains.Dtos.TipoDeAtributo.TipoDeAtributo();

            using (var ctx = new DbContext())
            {
                var itemToRemove = ctx.TipoDeAtributos.Find(id);

                result.TipoDeAtributoId = itemToRemove.TipoDeAtributoId;
                result.Nome = itemToRemove.Nome;
                result.Apelido = itemToRemove.Apelido;
                result.Descricao = itemToRemove.Descricao;
                result.NomeFisico = itemToRemove.NomeFisico;
                result.TipoDeDadoId = itemToRemove.TipoDeDadoId;
                result.FlagStatus = itemToRemove.FlagStatus;
                result.OrdemExibicao = itemToRemove.OrdemExibicao;
                result.Limitador = itemToRemove.Limitador;
                result.Qualificador = itemToRemove.Qualificador;
                result.CadastroUsuarioId = itemToRemove.CadastroUsuarioId;
                result.CadastroDataHora = itemToRemove.CadastroDataHora;
                result.AtualizacaoUsuarioId = itemToRemove.AtualizacaoUsuarioId;
                result.AtualizacaoDataHora = itemToRemove.AtualizacaoDataHora;

                if (itemToRemove != null)
                {
                    ctx.TipoDeAtributos.Remove(itemToRemove);
                    ctx.SaveChanges();
                }
            }

            return result;
        }

        #endregion
    }
}
