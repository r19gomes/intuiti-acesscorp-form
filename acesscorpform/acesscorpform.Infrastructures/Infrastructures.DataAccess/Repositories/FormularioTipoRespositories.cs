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
                ctx.Add(new Entities.FormularioTipo
                {
                    FormularioTipoId = request.FormularioTipo.FormularioTipoId,
                    Nome = request.FormularioTipo.Nome,
                    FlagStatus = request.FormularioTipo.FlagStatus,
                    CadastroUsuarioId = request.FormularioTipo.CadastroUsuarioId,
                    CadastroDataHora = request.FormularioTipo.CadastroDataHora,
                    AtualizacaoUsuarioId = request.FormularioTipo.AtualizacaoUsuarioId,
                    AtualizacaoDataHora = request.FormularioTipo.AtualizacaoDataHora
                });
                ctx.SaveChanges();
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
                ctx.Update(new Entities.FormularioTipo
                {
                    FormularioTipoId = request.FormularioTipo.FormularioTipoId,
                    Nome = request.FormularioTipo.Nome,
                    FlagStatus = request.FormularioTipo.FlagStatus,
                    CadastroUsuarioId = request.FormularioTipo.CadastroUsuarioId,
                    CadastroDataHora = request.FormularioTipo.CadastroDataHora,
                    AtualizacaoUsuarioId = request.FormularioTipo.AtualizacaoUsuarioId,
                    AtualizacaoDataHora = request.FormularioTipo.AtualizacaoDataHora
                });
                ctx.SaveChanges();
            }

            return result;
        }

        #endregion
    }
}
