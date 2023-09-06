using Microsoft.EntityFrameworkCore;

namespace BuilderAux_MVC.Models
{
    public class AplicationDbContext : DbContext
    {
        public DbSet<Itens> Itens { get; set; }
        public DbSet<NomesServicos> Servicos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=03-ASTIN-03;User Id=SEDE\\ioliveira;Database=Estoque;Integrated Security=SSPI;TrustServerCertificate=True");
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
