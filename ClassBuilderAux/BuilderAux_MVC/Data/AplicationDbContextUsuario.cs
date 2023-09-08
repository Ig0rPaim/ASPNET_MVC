using BuilderAux_MVC.Models;
using Microsoft.EntityFrameworkCore;

namespace BuilderAux_MVC.Data
{
    public class AplicationDbContextUsuario : DbContext
    {
        public DbSet<UsuarioModel> Usuarios { get; set; }

        public AplicationDbContextUsuario(DbContextOptions<AplicationDbContextUsuario> context) : base(context) 
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfigurationRoot Configuration = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json")
                .Build();
            optionsBuilder.UseSqlServer(Configuration.GetConnectionString("DatabaseUsuario"));
        }
    }
}
