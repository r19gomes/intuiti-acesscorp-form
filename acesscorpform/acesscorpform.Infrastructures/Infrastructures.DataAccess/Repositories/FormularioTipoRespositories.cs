using Acesscorp.Domains.Contracts.Repositories;
using Acesscorp.Infrastructures.DataAccess.Contexts;
using Acesscorp.Infrastructures.DataAccess.Repositories.Base;
using System.Collections.Generic;
using System.Linq;
using FormularioTipo = Acesscorp.Infrastructures.DataAccess.Entities.FormularioTipo;

namespace Acesscorp.Infrastructures.DataAccess.Repositories
{
    public class FormularioTipoRepositories : RepositoryBase<FormularioTipo>, IFormularioTipoRepositories
    {
        #region Builders

        public FormularioTipoRepositories()
        {
        }

        public FormularioTipoRepositories(DbContext dbContext) : base()
        {
            if (dbContext == null)
                dbContext = base.DbContext;
        }

        #endregion

        #region Methods

        public Acesscorp.Domains.Dtos.FormularioTipo.FormularioTipo Get(long id)
        {
            Acesscorp.Domains.Dtos.FormularioTipo.FormularioTipo result = 
                new Acesscorp.Domains.Dtos.FormularioTipo.FormularioTipo();

            using (var ctx = new DbContext())
            {
                var formularioTipo = ctx.FormulariosTipos.Find(id);

                result.FormularioTipoId = formularioTipo.FormularioTipoId;
                result.Nome = formularioTipo.Nome;
                result.Apelido = formularioTipo.Apelido;
                result.FlagStatus = formularioTipo.FlagStatus;
                result.CadastroUsuarioId = formularioTipo.CadastroUsuarioId;
                result.CadastroDataHora = formularioTipo.CadastroDataHora;
                result.AtualizacaoUsuarioId = formularioTipo.AtualizacaoUsuarioId;
                result.AtualizacaoDataHora = formularioTipo.AtualizacaoDataHora;
            }

            return result;
        }

        public IList<Acesscorp.Domains.Dtos.FormularioTipo.FormularioTipo> GetAll()
        {
            IList<Acesscorp.Domains.Dtos.FormularioTipo.FormularioTipo> result = 
                new List<Acesscorp.Domains.Dtos.FormularioTipo.FormularioTipo>();

            using (var ctx = new DbContext())
            {
                var ret = ctx.FormulariosTipos.ToList();
                if (ret.Count > 0)
                {
                    foreach (var item in ret)
                    {
                        result.Add(new Acesscorp.Domains.Dtos.FormularioTipo.FormularioTipo
                        {
                            FormularioTipoId = item.FormularioTipoId,
                            Nome = item.Nome,
                            Apelido = item.Apelido,
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

        public Acesscorp.Domains.Dtos.FormularioTipo.FormularioTipo Insert
            (Acesscorp.Domains.Dtos.FormularioTipo.FormularioTipoRequest request)
        {
            Acesscorp.Domains.Dtos.FormularioTipo.FormularioTipo result = 
                new Acesscorp.Domains.Dtos.FormularioTipo.FormularioTipo();

            using (var ctx = new DbContext())
            {
                var entities = new Entities.FormularioTipo
                {
                    FormularioTipoId = request.FormularioTipo.FormularioTipoId,
                    Nome = request.FormularioTipo.Nome,
                    Apelido = request.FormularioTipo.Apelido,
                    FlagStatus = request.FormularioTipo.FlagStatus,
                    CadastroUsuarioId = request.FormularioTipo.CadastroUsuarioId,
                    CadastroDataHora = request.FormularioTipo.CadastroDataHora,
                    AtualizacaoUsuarioId = request.FormularioTipo.AtualizacaoUsuarioId > 0 ?
                        request.FormularioTipo.AtualizacaoUsuarioId : null,
                    AtualizacaoDataHora = request.FormularioTipo.AtualizacaoUsuarioId > 0 ?
                        request.FormularioTipo.AtualizacaoDataHora : null
                };
                ctx.FormulariosTipos.Add(entities);
                ctx.SaveChanges();
                if (entities != null)
                {
                    result = new Acesscorp.Domains.Dtos.FormularioTipo.FormularioTipo()
                    {
                        FormularioTipoId = entities.FormularioTipoId,
                        Nome = entities.Nome,
                        Apelido = entities.Apelido,
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

        public Acesscorp.Domains.Dtos.FormularioTipo.FormularioTipo Update
            (Acesscorp.Domains.Dtos.FormularioTipo.FormularioTipoRequest request)
        {
            Acesscorp.Domains.Dtos.FormularioTipo.FormularioTipo result = 
                new Acesscorp.Domains.Dtos.FormularioTipo.FormularioTipo();

            using (var ctx = new DbContext())
            {
                var entities = new Entities.FormularioTipo
                {
                    FormularioTipoId = request.FormularioTipo.FormularioTipoId,
                    Nome = request.FormularioTipo.Nome,
                    Apelido = request.FormularioTipo.Apelido,
                    FlagStatus = request.FormularioTipo.FlagStatus,
                    CadastroUsuarioId = request.FormularioTipo.CadastroUsuarioId,
                    CadastroDataHora = request.FormularioTipo.CadastroDataHora,
                    AtualizacaoUsuarioId = request.FormularioTipo.AtualizacaoUsuarioId > 0 ?
                                        request.FormularioTipo.AtualizacaoUsuarioId : null,
                    AtualizacaoDataHora = request.FormularioTipo.AtualizacaoUsuarioId > 0 ?
                                        request.FormularioTipo.AtualizacaoDataHora : null
                };
                ctx.Update(entities);
                ctx.SaveChanges();
                if (entities != null)
                {
                    result = new Acesscorp.Domains.Dtos.FormularioTipo.FormularioTipo()
                    {
                        FormularioTipoId = entities.FormularioTipoId,
                        Nome = entities.Nome,
                        Apelido = entities.Apelido,
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

        public Acesscorp.Domains.Dtos.FormularioTipo.FormularioTipo Delete(long id)
        {
            Acesscorp.Domains.Dtos.FormularioTipo.FormularioTipo result =
                new Acesscorp.Domains.Dtos.FormularioTipo.FormularioTipo();

            using (var ctx = new DbContext())
            {
                var itemToRemove = ctx.FormulariosTipos.Find(id);

                result.FormularioTipoId = itemToRemove.FormularioTipoId;
                result.Nome = itemToRemove.Nome;
                result.Apelido = itemToRemove.Apelido;
                result.FlagStatus = itemToRemove.FlagStatus;
                result.CadastroUsuarioId = itemToRemove.CadastroUsuarioId;
                result.CadastroDataHora = itemToRemove.CadastroDataHora;
                result.AtualizacaoUsuarioId = itemToRemove.AtualizacaoUsuarioId;
                result.AtualizacaoDataHora = itemToRemove.AtualizacaoDataHora;

                if (itemToRemove != null)
                {
                    ctx.FormulariosTipos.Remove(itemToRemove);
                    ctx.SaveChanges();
                }
            }

            return result;
        }

        #endregion
    }
}
