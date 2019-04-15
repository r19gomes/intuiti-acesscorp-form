using Microsoft.EntityFrameworkCore;

namespace Acesscorp.Infrastructures.DataAccess.Models
{
    public class BaseContext : DbContext
    {
        public DbSet<TipoDeDado> TipoDeDados { get; set; }

        public DbSet<TipoDeAtributo> TipoDeAtributos { get; set; }

        public DbSet<FormularioTipo> FormulariosTipos { get; set; }

        public DbSet<FormularioStatus> FormulariosStatus { get; set; }

        public DbSet<Formulario> Formularios { get; set; }

        public DbSet<FormularioTipoDeAtributo> FormulariosTipoDeAtributos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // ConnectionString do notebook Intel(R) Core(TM) i7-7500U CPU @ 2.70GHz 2,90 GHz
            string cn = @"Data Source=DESKTOP-F4SIQSG\SQLEXPRESS;Initial Catalog=DB_INTRA_BANK;Integrated Security=SSPI;";

            optionsBuilder.UseSqlServer(cn);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region TipoDeAtributos

            // modelBuilder.Entity<TipoDeAtributo>(b =>
            // {
            //     b.HasKey(o => o.TipoDeAtributoId);
            //     b.Property(o => o.TipoDeAtributoId).ValueGeneratedOnAdd();

            //     b.Property(o => o.Nome).HasColumnType("varchar(200)").IsRequired();
            //     b.Property(o => o.Apelido).HasColumnType("varchar(200)");
            //     b.Property(o => o.Descricao).HasColumnType("varchar(200)");
            //     b.Property(o => o.NomeFisico).HasColumnType("varchar(200)");
            //     b.Property(o => o.TipoDeDadoId).HasColumnType("bigint");
            //     b.Property(o => o.OrdemExibicao).HasColumnType("int");
            //     b.Property(o => o.Limitador).HasColumnType("bit");
            //     b.Property(o => o.Qualificador).HasColumnType("bit");

            //     b.Property(o => o.FlagStatus).HasColumnType("bit");
            //     b.Property(o => o.CadastroUsuarioId).HasColumnType("bigint").IsRequired();
            //     b.Property(o => o.CadastroDataHora).HasColumnType("datetime2").IsRequired();
            //     b.Property(o => o.AtualizacaoUsuarioId).HasColumnType("bigint");
            //     b.Property(o => o.AtualizacaoDataHora).HasColumnType("datetime2");

            //     //b.HasMany(o => o.TipoDeDadoId).WithOne(p => p);

            #endregion

        }

    }
}