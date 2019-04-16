using Acesscorp.Domains.Contracts.Repositories;
using Acesscorp.Domains.Dtos.TipoDeDado;
using Acesscorp.Infrastructures.DataAccess.Contexts;
using Acesscorp.Infrastructures.DataAccess.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using TipoDeDado = Acesscorp.Infrastructures.DataAccess.Entities.TipoDeDado;

namespace Acesscorp.Infrastructures.DataAccess.Repositories
{
    public class TipoDeDadoRepositories : RepositoryBase<TipoDeDado>, ITipoDeDadoRepositories
    {
        #region Builders

        public TipoDeDadoRepositories()
        {
        }

        public TipoDeDadoRepositories(DbContext dbContext) : base()
        {
            if (dbContext == null)
                dbContext = base.DbContext;
        }

        #endregion

        #region Methods

        public Acesscorp.Domains.Dtos.TipoDeDado.TipoDeDado Get(long id)
        {
            Acesscorp.Domains.Dtos.TipoDeDado.TipoDeDado result = 
                new Acesscorp.Domains.Dtos.TipoDeDado.TipoDeDado();

            using (var ctx = new DbContext())
            {
                var tipoDeDado = ctx.TipoDeDados.Find(id);

                result.TipoDeDadoId = tipoDeDado.TipoDeDadoId;
                result.Nome = tipoDeDado.Nome;
                result.FlagStatus = tipoDeDado.FlagStatus;
                result.CadastroUsuarioId = tipoDeDado.CadastroUsuarioId;
                result.CadastroDataHora = tipoDeDado.CadastroDataHora;
                result.AtualizacaoUsuarioId = tipoDeDado.AtualizacaoUsuarioId;
                result.AtualizacaoDataHora = tipoDeDado.AtualizacaoDataHora;
            }

            return result;
        }

        public IList<Acesscorp.Domains.Dtos.TipoDeDado.TipoDeDado> GetAll()
        {
            IList<Acesscorp.Domains.Dtos.TipoDeDado.TipoDeDado> result = 
                new List<Acesscorp.Domains.Dtos.TipoDeDado.TipoDeDado>();

            using (var ctx = new DbContext())
            {
                var ret = ctx.TipoDeDados.ToList();
                if (ret.Count > 0)
                {
                    foreach (var item in ret)
                    {
                        result.Add(new Acesscorp.Domains.Dtos.TipoDeDado.TipoDeDado
                        {
                            TipoDeDadoId = item.TipoDeDadoId,
                            Nome = item.Nome,
                            FlagStatus = item.FlagStatus,
                            CadastroUsuarioId = item.CadastroUsuarioId,
                            CadastroDataHora = item.CadastroDataHora,
                            AtualizacaoUsuarioId = item.AtualizacaoUsuarioId,
                            AtualizacaoDataHora = item.AtualizacaoDataHora
                        });

                    }
                }
            }

            return result;
        }

        public Acesscorp.Domains.Dtos.TipoDeDado.TipoDeDado Insert
            (Acesscorp.Domains.Dtos.TipoDeDado.TipoDeDadoRequest request)
        {
            Acesscorp.Domains.Dtos.TipoDeDado.TipoDeDado result = 
                new Acesscorp.Domains.Dtos.TipoDeDado.TipoDeDado();

            using (var ctx = new DbContext())
            {
                ctx.Add(new Entities.TipoDeDado
                {
                    TipoDeDadoId = request.TipoDeDado.TipoDeDadoId,
                    Nome = request.TipoDeDado.Nome,
                    FlagStatus = request.TipoDeDado.FlagStatus,
                    CadastroUsuarioId = request.TipoDeDado.CadastroUsuarioId,
                    CadastroDataHora = request.TipoDeDado.CadastroDataHora,
                    AtualizacaoUsuarioId = request.TipoDeDado.AtualizacaoUsuarioId,
                    AtualizacaoDataHora = request.TipoDeDado.AtualizacaoDataHora
                });
                ctx.SaveChanges();
            }

            return result;
        }

        public Acesscorp.Domains.Dtos.TipoDeDado.TipoDeDado Update
            (Acesscorp.Domains.Dtos.TipoDeDado.TipoDeDadoRequest request)
        {
            Acesscorp.Domains.Dtos.TipoDeDado.TipoDeDado result = 
                new Acesscorp.Domains.Dtos.TipoDeDado.TipoDeDado();

            using (var ctx = new DbContext())
            {
                ctx.Update(new Entities.TipoDeDado
                {
                    TipoDeDadoId = request.TipoDeDado.TipoDeDadoId,
                    Nome = request.TipoDeDado.Nome,
                    FlagStatus = request.TipoDeDado.FlagStatus,
                    CadastroUsuarioId = request.TipoDeDado.CadastroUsuarioId,
                    CadastroDataHora = request.TipoDeDado.CadastroDataHora,
                    AtualizacaoUsuarioId = request.TipoDeDado.AtualizacaoUsuarioId,
                    AtualizacaoDataHora = request.TipoDeDado.AtualizacaoDataHora
                });
                ctx.SaveChanges();
            }

            return result;
        }

        #endregion
    }
}
