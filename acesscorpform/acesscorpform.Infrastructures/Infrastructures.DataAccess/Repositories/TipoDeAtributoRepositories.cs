using Acesscorp.Domains.Contracts.Repositories;
using Acesscorp.Domains.Dtos.TipoDeAtributo;
using Acesscorp.Infrastructures.DataAccess.Contexts;
using Acesscorp.Infrastructures.DataAccess.Repositories.Base;
using System;
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
                var ret1 = ctx.TipoDeAtributos;
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
                ctx.Add(new Entities.TipoDeAtributo
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
                });
                ctx.SaveChanges();
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
                ctx.Update(new Entities.TipoDeAtributo
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
                });
                ctx.SaveChanges();
            }

            return result;
        }

        #endregion
    }
}
