using Acesscorp.Domains.Contracts.Repositories;
using Acesscorp.Infrastructures.DataAccess.Contexts;
using Acesscorp.Infrastructures.DataAccess.Repositories.Base;
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
                var entities = new Entities.TipoDeDado
                {
                    TipoDeDadoId = request.TipoDeDado.TipoDeDadoId,
                    Nome = request.TipoDeDado.Nome,
                    FlagStatus = request.TipoDeDado.FlagStatus,
                    CadastroUsuarioId = request.TipoDeDado.CadastroUsuarioId,
                    CadastroDataHora = request.TipoDeDado.CadastroDataHora,
                    AtualizacaoUsuarioId = request.TipoDeDado.AtualizacaoUsuarioId > 0 ?
                        request.TipoDeDado.AtualizacaoUsuarioId : null,
                    AtualizacaoDataHora = request.TipoDeDado.AtualizacaoUsuarioId > 0 ?
                        request.TipoDeDado.AtualizacaoDataHora : null
                };
                ctx.TipoDeDados.Add(entities);
                ctx.SaveChanges();
                if (entities != null)
                {
                    result = new Acesscorp.Domains.Dtos.TipoDeDado.TipoDeDado()
                    {
                        TipoDeDadoId = entities.TipoDeDadoId,
                        Nome = entities.Nome,
                        FlagStatus = entities.FlagStatus,
                        CadastroUsuarioId = entities.CadastroUsuarioId,
                        CadastroDataHora = entities.CadastroDataHora,
                        AtualizacaoUsuarioId = entities.AtualizacaoUsuarioId,
                        AtualizacaoDataHora = entities.AtualizacaoDataHora
                    };
                }
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
                var entities = new Entities.TipoDeDado
                {
                    TipoDeDadoId = request.TipoDeDado.TipoDeDadoId,
                    Nome = request.TipoDeDado.Nome,
                    FlagStatus = request.TipoDeDado.FlagStatus,
                    CadastroUsuarioId = request.TipoDeDado.CadastroUsuarioId,
                    CadastroDataHora = request.TipoDeDado.CadastroDataHora,
                    AtualizacaoUsuarioId = request.TipoDeDado.AtualizacaoUsuarioId > 0 ?
                        request.TipoDeDado.AtualizacaoUsuarioId : null,
                    AtualizacaoDataHora = request.TipoDeDado.AtualizacaoUsuarioId > 0 ?
                        request.TipoDeDado.AtualizacaoDataHora : null
                };
                ctx.Update(entities);
                ctx.SaveChanges();
                if (entities != null)
                {
                    result = new Acesscorp.Domains.Dtos.TipoDeDado.TipoDeDado()
                    {
                        TipoDeDadoId = entities.TipoDeDadoId,
                        Nome = entities.Nome,
                        FlagStatus = entities.FlagStatus,
                        CadastroUsuarioId = entities.CadastroUsuarioId,
                        CadastroDataHora = entities.CadastroDataHora,
                        AtualizacaoUsuarioId = entities.AtualizacaoUsuarioId,
                        AtualizacaoDataHora = entities.AtualizacaoDataHora
                    };
                }
            }

            return result;
        }

        public Acesscorp.Domains.Dtos.TipoDeDado.TipoDeDado Delete(long id)
        {
            Acesscorp.Domains.Dtos.TipoDeDado.TipoDeDado result =
                new Acesscorp.Domains.Dtos.TipoDeDado.TipoDeDado();

            using (var ctx = new DbContext())
            {
                var itemToRemove = ctx.TipoDeDados.Find(id);
                                
                result.TipoDeDadoId = itemToRemove.TipoDeDadoId;
                result.Nome = itemToRemove.Nome;
                result.FlagStatus = itemToRemove.FlagStatus;
                result.CadastroUsuarioId = itemToRemove.CadastroUsuarioId;
                result.CadastroDataHora = itemToRemove.CadastroDataHora;
                result.AtualizacaoUsuarioId = itemToRemove.AtualizacaoUsuarioId;
                result.AtualizacaoDataHora = itemToRemove.AtualizacaoDataHora;

                if (itemToRemove != null)
                {
                    ctx.TipoDeDados.Remove(itemToRemove);
                    ctx.SaveChanges();
                }
            }

            return result;
        }

        #endregion
    }
}
