using Acesscorp.Domains.Contracts.Repositories;
using Acesscorp.Infrastructures.DataAccess.Contexts;
using Acesscorp.Infrastructures.DataAccess.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using TipoDeAtributo = Acesscorp.Infrastructures.DataAccess.Entities.TipoDeAtributo;

namespace AspNetMvc.Api.Infrastructures.DataAccess.Repositories
{
    // public class ContaCorrenteRepositories : RepositoryBase<ContaCorrente>, IContaCorrenteRepositories
    // {
    //     #region Builders

    //     public ContaCorrenteRepositories()
    //     {
    //     }

    //     public ContaCorrenteRepositories(DbContext dbContext) : base()
    //     {
    //         if (dbContext == null)
    //             dbContext = base.DbContext;
    //     }

    //     #endregion

    //     #region Methods

    //     public Domains.Dtos.ContaCorrente.ContaCorrente Get(long id)
    //     {
    //         throw new NotImplementedException();
    //     }

    //     public IList<Domains.Dtos.ContaCorrente.ContaCorrente> GetAll()
    //     {
    //         IList<Domains.Dtos.ContaCorrente.ContaCorrente> result =
    //             new List<Domains.Dtos.ContaCorrente.ContaCorrente>();

        
    // using (var ctx = new DbContext())
    //         {
    //             var ret = ctx.ContasCorrentes.ToList();
    //             if (ret.Count > 0)
    //             {
    //                 foreach (var item in ret)
    //                 {
    //                     result.Add(new Domains.Dtos.ContaCorrente.ContaCorrente
    //                     {
    //                         BancoId = item.BancoId,
    //                         AgenciaId = item.AgenciaId

    //                     });

    //                 }
    //             }
    //         }

    //         return result;
    //     }

    //     #endregion
    // }
}
