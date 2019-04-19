using Acesscorp.Domains.Contracts.Repositories;
using Acesscorp.Infrastructures.DataAccess.Contexts;
using Acesscorp.Infrastructures.DataAccess.Repositories.Base;
using System.Collections.Generic;
using System.Linq;
using FormularioStatus = Acesscorp.Infrastructures.DataAccess.Entities.FormularioStatus;

namespace Acesscorp.Infrastructures.DataAccess.Repositories
{
    public class FormularioStatusRepositories : RepositoryBase<FormularioStatus>, IFormularioStatusRepositories
    {
        #region Builders

        public FormularioStatusRepositories()
        {
        }

        public FormularioStatusRepositories(DbContext dbContext) : base()
        {
            if (dbContext == null)
                dbContext = base.DbContext;
        }

        #endregion

        #region Methods

        public Acesscorp.Domains.Dtos.FormularioStatus.FormularioStatus Get(long id)
        {
            Acesscorp.Domains.Dtos.FormularioStatus.FormularioStatus result = 
                new Acesscorp.Domains.Dtos.FormularioStatus.FormularioStatus();

            using (var ctx = new DbContext())
            {
                var formularioStatus = ctx.FormulariosStatus.Find(id);

                result.FormularioStatusId = formularioStatus.FormularioStatusId;
                result.Nome = formularioStatus.Nome;
                result.FlagStatus = formularioStatus.FlagStatus;
                result.CadastroUsuarioId = formularioStatus.CadastroUsuarioId;
                result.CadastroDataHora = formularioStatus.CadastroDataHora;
                result.AtualizacaoUsuarioId = formularioStatus.AtualizacaoUsuarioId;
                result.AtualizacaoDataHora = formularioStatus.AtualizacaoDataHora;
            }

            return result;
        }

        public IList<Acesscorp.Domains.Dtos.FormularioStatus.FormularioStatus> GetAll()
        {
            IList<Acesscorp.Domains.Dtos.FormularioStatus.FormularioStatus> result = 
                new List<Acesscorp.Domains.Dtos.FormularioStatus.FormularioStatus>();

            using (var ctx = new DbContext())
            {
                var ret = ctx.FormulariosStatus.ToList();
                if (ret.Count > 0)
                {
                    foreach (var item in ret)
                    {
                        result.Add(new Acesscorp.Domains.Dtos.FormularioStatus.FormularioStatus
                        {
                            FormularioStatusId = item.FormularioStatusId,
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

        public Acesscorp.Domains.Dtos.FormularioStatus.FormularioStatus Insert
            (Acesscorp.Domains.Dtos.FormularioStatus.FormularioStatusRequest request)
        {
            Acesscorp.Domains.Dtos.FormularioStatus.FormularioStatus result = 
                new Acesscorp.Domains.Dtos.FormularioStatus.FormularioStatus();

            using (var ctx = new DbContext())
            {
                var entities = new Entities.FormularioStatus
                {
                    FormularioStatusId = request.FormularioStatus.FormularioStatusId,
                    Nome = request.FormularioStatus.Nome,
                    FlagStatus = request.FormularioStatus.FlagStatus,
                    CadastroUsuarioId = request.FormularioStatus.CadastroUsuarioId,
                    CadastroDataHora = request.FormularioStatus.CadastroDataHora,
                    AtualizacaoUsuarioId = request.FormularioStatus.AtualizacaoUsuarioId,
                    AtualizacaoDataHora = request.FormularioStatus.AtualizacaoDataHora
                };
                ctx.FormulariosStatus.Add(entities);
                ctx.SaveChanges();
                if (entities != null)
                {
                    result = new Acesscorp.Domains.Dtos.FormularioStatus.FormularioStatus()
                    {
                        FormularioStatusId = request.FormularioStatus.FormularioStatusId,
                        Nome = request.FormularioStatus.Nome,
                        FlagStatus = request.FormularioStatus.FlagStatus,
                        CadastroUsuarioId = request.FormularioStatus.CadastroUsuarioId,
                        CadastroDataHora = request.FormularioStatus.CadastroDataHora,
                        AtualizacaoUsuarioId = request.FormularioStatus.AtualizacaoUsuarioId,
                        AtualizacaoDataHora = request.FormularioStatus.AtualizacaoDataHora
                    };
                }
            }

            return result;
        }

        public Acesscorp.Domains.Dtos.FormularioStatus.FormularioStatus Update
            (Acesscorp.Domains.Dtos.FormularioStatus.FormularioStatusRequest request)
        {
            Acesscorp.Domains.Dtos.FormularioStatus.FormularioStatus result = 
                new Acesscorp.Domains.Dtos.FormularioStatus.FormularioStatus();

            using (var ctx = new DbContext())
            {
                var entities = new Entities.FormularioStatus
                {
                    FormularioStatusId = request.FormularioStatus.FormularioStatusId,
                    Nome = request.FormularioStatus.Nome,
                    FlagStatus = request.FormularioStatus.FlagStatus,
                    CadastroUsuarioId = request.FormularioStatus.CadastroUsuarioId,
                    CadastroDataHora = request.FormularioStatus.CadastroDataHora,
                    AtualizacaoUsuarioId = request.FormularioStatus.AtualizacaoUsuarioId,
                    AtualizacaoDataHora = request.FormularioStatus.AtualizacaoDataHora
                };
                ctx.Update(entities);
                ctx.SaveChanges();
                if (entities != null)
                {
                    result = new Acesscorp.Domains.Dtos.FormularioStatus.FormularioStatus()
                    {
                        FormularioStatusId = request.FormularioStatus.FormularioStatusId,
                        Nome = request.FormularioStatus.Nome,
                        FlagStatus = request.FormularioStatus.FlagStatus,
                        CadastroUsuarioId = request.FormularioStatus.CadastroUsuarioId,
                        CadastroDataHora = request.FormularioStatus.CadastroDataHora,
                        AtualizacaoUsuarioId = request.FormularioStatus.AtualizacaoUsuarioId,
                        AtualizacaoDataHora = request.FormularioStatus.AtualizacaoDataHora
                    };
                }
            }

            return result;
        }

        public Acesscorp.Domains.Dtos.FormularioStatus.FormularioStatus Delete(long id)
        {
            Acesscorp.Domains.Dtos.FormularioStatus.FormularioStatus result =
                new Acesscorp.Domains.Dtos.FormularioStatus.FormularioStatus();

            using (var ctx = new DbContext())
            {
                var itemToRemove = ctx.FormulariosStatus.Find(id);

                result.FormularioStatusId = itemToRemove.FormularioStatusId;
                result.Nome = itemToRemove.Nome;
                result.FlagStatus = itemToRemove.FlagStatus;
                result.CadastroUsuarioId = itemToRemove.CadastroUsuarioId;
                result.CadastroDataHora = itemToRemove.CadastroDataHora;
                result.AtualizacaoUsuarioId = itemToRemove.AtualizacaoUsuarioId;
                result.AtualizacaoDataHora = itemToRemove.AtualizacaoDataHora;

                if (itemToRemove != null)
                {
                    ctx.FormulariosStatus.Remove(itemToRemove);
                    ctx.SaveChanges();
                }
            }

            return result;
        }

        #endregion
    }
}
