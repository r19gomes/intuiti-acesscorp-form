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

        public DbSet<FormularioTipoDeAtributo> FormulariosTipoDeAtributos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string cn = string.Empty;

            cn = @"Persist Security Info=False;User ID=acesscorp;Password=acesscorp@2019;Initial Catalog=DB_ACESSCORP;Data Source=198.71.226.2;";
            //cn = @"Server=myServerName\myInstanceName;Database=myDataBase;User Id=myUsername;Password=myPassword;";

            optionsBuilder.UseSqlServer(cn);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}
