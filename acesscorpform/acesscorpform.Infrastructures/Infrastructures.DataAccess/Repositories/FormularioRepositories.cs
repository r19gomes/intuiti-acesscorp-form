using Acesscorp.Domains.Contracts.Repositories;
using Acesscorp.Infrastructures.DataAccess.Contexts;
using Acesscorp.Infrastructures.DataAccess.Repositories.Base;
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
                result.FlagStatus = true; //formulario.FlagStatus;
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
                            Apelido = item.Apelido,
                            FormularioStatusId = item.FormularioStatusId,
                            DataVigenciaInicial = item.DataVigenciaInicial,
                            DataVigenciaFinal = item.DataVigenciaFinal,
                            FormularioTipoId = item.FormularioTipoId,
                            FlagStatus = true,
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
                var entities = new Entities.Formulario
                {
                    FormularioId = request.Formulario.FormularioId,
                    Nome = request.Formulario.Nome,
                    Apelido = request.Formulario.Apelido,
                    FormularioStatusId = request.Formulario.FormularioStatusId,
                    DataVigenciaInicial = request.Formulario.DataVigenciaInicial,
                    DataVigenciaFinal = request.Formulario.DataVigenciaFinal,
                    FormularioTipoId = request.Formulario.FormularioTipoId,
                    CadastroUsuarioId = request.Formulario.CadastroUsuarioId,
                    CadastroDataHora = request.Formulario.CadastroDataHora,
                    AtualizacaoUsuarioId = request.Formulario.AtualizacaoUsuarioId,
                    AtualizacaoDataHora = request.Formulario.AtualizacaoDataHora
                };
                ctx.Add(entities);
                ctx.SaveChanges();
                if (entities != null)
                {
                    result = new Acesscorp.Domains.Dtos.Formulario.Formulario()
                    {
                        FormularioId = entities.FormularioId,
                        Nome = entities.Nome,
                        Apelido = entities.Apelido,
                        FormularioStatusId = entities.FormularioStatusId,
                        DataVigenciaInicial = entities.DataVigenciaInicial,
                        DataVigenciaFinal = entities.DataVigenciaFinal,
                        FormularioTipoId = entities.FormularioTipoId,
                        CadastroUsuarioId = entities.CadastroUsuarioId,
                        CadastroDataHora = entities.CadastroDataHora,
                        AtualizacaoUsuarioId = entities.AtualizacaoUsuarioId,
                        AtualizacaoDataHora = entities.AtualizacaoDataHora
                    };
                }
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
                var entities = new Entities.Formulario
                {
                    FormularioId = request.Formulario.FormularioId,
                    Nome = request.Formulario.Nome,
                    Apelido = request.Formulario.Apelido,
                    FormularioStatusId = request.Formulario.FormularioStatusId,
                    DataVigenciaInicial = request.Formulario.DataVigenciaInicial,
                    DataVigenciaFinal = request.Formulario.DataVigenciaFinal,
                    FormularioTipoId = request.Formulario.FormularioTipoId,
                    CadastroUsuarioId = request.Formulario.CadastroUsuarioId,
                    CadastroDataHora = request.Formulario.CadastroDataHora,
                    AtualizacaoUsuarioId = request.Formulario.AtualizacaoUsuarioId,
                    AtualizacaoDataHora = request.Formulario.AtualizacaoDataHora
                };
                ctx.Update(entities);
                ctx.SaveChanges();
                if (entities != null)
                {
                    result = new Acesscorp.Domains.Dtos.Formulario.Formulario()
                    {
                        FormularioId = entities.FormularioId,
                        Nome = entities.Nome,
                        Apelido = entities.Apelido,
                        FormularioStatusId = entities.FormularioStatusId,
                        DataVigenciaInicial = entities.DataVigenciaInicial,
                        DataVigenciaFinal = entities.DataVigenciaFinal,
                        FormularioTipoId = entities.FormularioTipoId,
                        CadastroUsuarioId = entities.CadastroUsuarioId,
                        CadastroDataHora = entities.CadastroDataHora,
                        AtualizacaoUsuarioId = entities.AtualizacaoUsuarioId,
                        AtualizacaoDataHora = entities.AtualizacaoDataHora
                    };
                }
            }

            return result;
        }

        public Acesscorp.Domains.Dtos.Formulario.Formulario Delete(long id)
        {
            Acesscorp.Domains.Dtos.Formulario.Formulario result =
                new Acesscorp.Domains.Dtos.Formulario.Formulario();

            using (var ctx = new DbContext())
            {
                var itemToRemove = ctx.Formularios.Find(id);

                result.FormularioId = itemToRemove.FormularioId;
                result.Nome = itemToRemove.Nome;
                result.Apelido = itemToRemove.Apelido;
                result.FormularioStatusId = itemToRemove.FormularioStatusId;
                result.DataVigenciaInicial = itemToRemove.DataVigenciaInicial;
                result.DataVigenciaFinal = itemToRemove.DataVigenciaFinal;
                result.FormularioTipoId = itemToRemove.FormularioTipoId;
                result.FlagStatus = true; // itemToRemove.FlagStatus;
                result.CadastroUsuarioId = itemToRemove.CadastroUsuarioId;
                result.CadastroDataHora = itemToRemove.CadastroDataHora;
                result.AtualizacaoUsuarioId = itemToRemove.AtualizacaoUsuarioId;
                result.AtualizacaoDataHora = itemToRemove.AtualizacaoDataHora;

                if (itemToRemove != null)
                {
                    ctx.Formularios.Remove(itemToRemove);
                    ctx.SaveChanges();
                }
            }

            return result;
        }

        #endregion
    }
}
