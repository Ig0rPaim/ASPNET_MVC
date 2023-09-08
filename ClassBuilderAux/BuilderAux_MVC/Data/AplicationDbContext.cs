using BuilderAux_MVC.Models;
using Microsoft.EntityFrameworkCore;

namespace BuilderAux_MVC.Data
{
    public class AplicationDbContext : DbContext
    {
        public DbSet<Itens> Itens { get; set; }
        public DbSet<NomesServicos> Servicos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfigurationRoot Configuration = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json")
                .Build();
            optionsBuilder.UseSqlServer(Configuration.GetConnectionString("DatabaseEscopo"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Definir a relação entre Itens e NomesServicos
            modelBuilder.Entity<Itens>()
                .HasOne(i => i.TipoServicoNavigation) // Propriedade de navegação para NomesServicos
                .WithMany()
                .HasForeignKey(i => i.TipoServico); // Chave estrangeira em Itens

            modelBuilder.Entity<NomesServicos>()
                .Property(p => p.NomeServico).HasMaxLength(50).IsRequired(true); // definindo tamanho e obrigatoriedade
        }
    }
}
