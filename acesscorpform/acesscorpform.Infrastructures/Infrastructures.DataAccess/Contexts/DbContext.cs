using Acesscorp.Infrastructures.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace Acesscorp.Infrastructures.DataAccess.Contexts
{
    public class DbContext: Microsoft.EntityFrameworkCore.DbContext
    {
        public DbSet<TipoDeDado> TipoDeDados { get; set; }

        public DbSet<TipoDeAtributo> TipoDeAtributos { get; set; }

        public DbSet<FormularioTipo> FormulariosTipos { get; set; }

        public DbSet<FormularioStatus> FormulariosStatus { get; set; }

        public DbSet<Formulario> Formularios { get; set; }

        //public DbSet<FormularioTipoDeAtributo> FormulariosTipoDeAtributos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string cn = string.Empty;

            // ConnectionString do notebook Intel(R) Core(TM) i7-7500U CPU @ 2.70GHz 2,90 GHz
            //cn = @"Data Source=DESKTOP-F4SIQSG\SQLEXPRESS;Initial Catalog=DB_INTRA_BANK;Integrated Security=SSPI;";

            // ConnectionString do MACBook
            cn = @"Data Source=MACOS472F\MSSQL2014;Initial Catalog=DB_INTRA_BANK;Integrated Security=True";

            optionsBuilder.UseSqlServer(cn);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}
