using Acesscorp.Domains.Contracts.Repositories;
using Acesscorp.Infrastructures.DataAccess.Contexts;
using Acesscorp.Infrastructures.DataAccess.Repositories.Base;
using System.Collections.Generic;
using System.Linq;
using FormularioTipoDeAtributo = Acesscorp.Infrastructures.DataAccess.Entities.FormularioTipoDeAtributo;

namespace Acesscorp.Infrastructures.DataAccess.Repositories
{
    public class FormularioTipoDeAtributoRepositories : RepositoryBase<FormularioTipoDeAtributo>, IFormularioTipoDeAtributoRepositories
    {
        #region Builders

        public FormularioTipoDeAtributoRepositories()
        {
        }

        public FormularioTipoDeAtributoRepositories(DbContext dbContext) : base()
        {
            if (dbContext == null)
                dbContext = base.DbContext;
        }

        #endregion

        #region Methods

        public Acesscorp.Domains.Dtos.FormularioTipoDeAtributo.FormularioTipoDeAtributo Get(long id)
        {
            Acesscorp.Domains.Dtos.FormularioTipoDeAtributo.FormularioTipoDeAtributo result = 
                new Acesscorp.Domains.Dtos.FormularioTipoDeAtributo.FormularioTipoDeAtributo();

            using (var ctx = new DbContext())
            {
                var formularioTipoDeAtributo = ctx.FormulariosTipoDeAtributos.Find(id);

                result.FormularioTipoDeAtributoId = formularioTipoDeAtributo.FormularioTipoDeAtributoId;
                result.FlagStatus = formularioTipoDeAtributo.FlagStatus;
                result.CadastroUsuarioId = formularioTipoDeAtributo.CadastroUsuarioId;
                result.CadastroDataHora = formularioTipoDeAtributo.CadastroDataHora;
                result.AtualizacaoUsuarioId = formularioTipoDeAtributo.AtualizacaoUsuarioId;
                result.AtualizacaoDataHora = formularioTipoDeAtributo.AtualizacaoDataHora;
            }

            return result;
        }

        public IList<Acesscorp.Domains.Dtos.FormularioTipoDeAtributo.FormularioTipoDeAtributo> GetAll()
        {
            IList<Acesscorp.Domains.Dtos.FormularioTipoDeAtributo.FormularioTipoDeAtributo> result = 
                new List<Acesscorp.Domains.Dtos.FormularioTipoDeAtributo.FormularioTipoDeAtributo>();

            using (var ctx = new DbContext())
            {
                var ret = ctx.FormulariosTipoDeAtributos.ToList();
                if (ret.Count > 0)
                {
                    foreach (var item in ret)
                    {
                        result.Add(new Acesscorp.Domains.Dtos.FormularioTipoDeAtributo.FormularioTipoDeAtributo
                        {
                            FormularioTipoDeAtributoId = item.FormularioTipoDeAtributoId,
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

        public Acesscorp.Domains.Dtos.FormularioTipoDeAtributo.FormularioTipoDeAtributo Insert
            (Acesscorp.Domains.Dtos.FormularioTipoDeAtributo.FormularioTipoDeAtributoRequest request)
        {
            Acesscorp.Domains.Dtos.FormularioTipoDeAtributo.FormularioTipoDeAtributo result = 
                new Acesscorp.Domains.Dtos.FormularioTipoDeAtributo.FormularioTipoDeAtributo();

            using (var ctx = new DbContext())
            {
                ctx.Add(new Entities.FormularioTipoDeAtributo
                {
                    FormularioTipoDeAtributoId = request.FormularioTipoDeAtributo.FormularioTipoDeAtributoId,
                    FlagStatus = request.FormularioTipoDeAtributo.FlagStatus,
                    CadastroUsuarioId = request.FormularioTipoDeAtributo.CadastroUsuarioId,
                    CadastroDataHora = request.FormularioTipoDeAtributo.CadastroDataHora,
                    AtualizacaoUsuarioId = request.FormularioTipoDeAtributo.AtualizacaoUsuarioId,
                    AtualizacaoDataHora = request.FormularioTipoDeAtributo.AtualizacaoDataHora
                });
                ctx.SaveChanges();
            }

            return result;
        }

        public Acesscorp.Domains.Dtos.FormularioTipoDeAtributo.FormularioTipoDeAtributo Update
            (Acesscorp.Domains.Dtos.FormularioTipoDeAtributo.FormularioTipoDeAtributoRequest request)
        {
            Acesscorp.Domains.Dtos.FormularioTipoDeAtributo.FormularioTipoDeAtributo result = 
                new Acesscorp.Domains.Dtos.FormularioTipoDeAtributo.FormularioTipoDeAtributo();

            using (var ctx = new DbContext())
            {
                ctx.Update(new Entities.FormularioTipoDeAtributo
                {
                    FormularioTipoDeAtributoId = request.FormularioTipoDeAtributo.FormularioTipoDeAtributoId,
                    FlagStatus = request.FormularioTipoDeAtributo.FlagStatus,
                    CadastroUsuarioId = request.FormularioTipoDeAtributo.CadastroUsuarioId,
                    CadastroDataHora = request.FormularioTipoDeAtributo.CadastroDataHora,
                    AtualizacaoUsuarioId = request.FormularioTipoDeAtributo.AtualizacaoUsuarioId,
                    AtualizacaoDataHora = request.FormularioTipoDeAtributo.AtualizacaoDataHora
                });
                ctx.SaveChanges();
            }

            return result;
        }

        #endregion
    }
}
