using Acesscorp.Domains.Contracts.Repositories;
using Acesscorp.Domains.Dtos.Formulario;
using Acesscorp.Infrastructures.DataAccess.Contexts;
using Acesscorp.Infrastructures.DataAccess.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using Formulario = Acesscorp.Infrastructures.DataAccess.Entities.Formulario;

namespace Acesscorp.Infrastructures.DataAccess.Repositories
{
    public class FormularioRepositories : RepositoryBase<Formulario>, IFormularioRepositories
    {
        #region Builders

        public FormularioRepositories()
        {
        }

        public FormularioRepositories(DbContext dbContext) : base()
        {
            if (dbContext == null)
                dbContext = base.DbContext;
        }

        #endregion

        #region Methods

        public Acesscorp.Domains.Dtos.Formulario.Formulario Get(long id)
        {
            Acesscorp.Domains.Dtos.Formulario.Formulario result = 
                new Acesscorp.Domains.Dtos.Formulario.Formulario();

            using (var ctx = new DbContext())
            {
                var formulario = ctx.Formularios.Find(id);

                result.FormularioId = formulario.FormularioId;
                result.Nome = formulario.Nome;
                result.FlagStatus = formulario.FlagStatus;
                result.CadastroUsuarioId = formulario.CadastroUsuarioId;
                result.CadastroDataHora = formulario.CadastroDataHora;
                result.AtualizacaoUsuarioId = formulario.AtualizacaoUsuarioId;
                result.AtualizacaoDataHora = formulario.AtualizacaoDataHora;
            }

            return result;
        }

        public IList<Acesscorp.Domains.Dtos.Formulario.Formulario> GetAll()
        {
            IList<Acesscorp.Domains.Dtos.Formulario.Formulario> result = 
                new List<Acesscorp.Domains.Dtos.Formulario.Formulario>();

            using (var ctx = new DbContext())
            {
                var ret = ctx.Formularios.ToList();
                if (ret.Count > 0)
                {
                    foreach (var item in ret)
                    {
                        result.Add(new Acesscorp.Domains.Dtos.Formulario.Formulario
                        {
                            FormularioId = item.FormularioId,
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

        public Acesscorp.Domains.Dtos.Formulario.Formulario Insert
            (Acesscorp.Domains.Dtos.Formulario.FormularioRequest request)
        {
            Acesscorp.Domains.Dtos.Formulario.Formulario result = 
                new Acesscorp.Domains.Dtos.Formulario.Formulario();

            using (var ctx = new DbContext())
            {
                ctx.Add(new Entities.Formulario
                {
                    FormularioId = request.Formulario.FormularioId,
                    Nome = request.Formulario.Nome,
                    FlagStatus = request.Formulario.FlagStatus,
                    CadastroUsuarioId = request.Formulario.CadastroUsuarioId,
                    CadastroDataHora = request.Formulario.CadastroDataHora,
                    AtualizacaoUsuarioId = request.Formulario.AtualizacaoUsuarioId,
                    AtualizacaoDataHora = request.Formulario.AtualizacaoDataHora
                });
                ctx.SaveChanges();
            }

            return result;
        }

        public Acesscorp.Domains.Dtos.Formulario.Formulario Update
            (Acesscorp.Domains.Dtos.Formulario.FormularioRequest request)
        {
            Acesscorp.Domains.Dtos.Formulario.Formulario result = 
                new Acesscorp.Domains.Dtos.Formulario.Formulario();

            using (var ctx = new DbContext())
            {
                ctx.Update(new Entities.Formulario
                {
                    FormularioId = request.Formulario.FormularioId,
                    Nome = request.Formulario.Nome,
                    FlagStatus = request.Formulario.FlagStatus,
                    CadastroUsuarioId = request.Formulario.CadastroUsuarioId,
                    CadastroDataHora = request.Formulario.CadastroDataHora,
                    AtualizacaoUsuarioId = request.Formulario.AtualizacaoUsuarioId,
                    AtualizacaoDataHora = request.Formulario.AtualizacaoDataHora
                });
                ctx.SaveChanges();
            }

            return result;
        }

        #endregion
    }
}
