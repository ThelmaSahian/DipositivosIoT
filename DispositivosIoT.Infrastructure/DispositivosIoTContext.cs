using Microsoft.EntityFrameworkCore;
using SensoresIoT.DispositivosIoTInfrastructure.Mappings;

namespace SensoresIoT.Repositories
{
    public class DispositivosIoTContext : DbContext
    {
        public DispositivosIoTContext()
        {
        }

        public DispositivosIoTContext(DbContextOptions<DispositivosIoTContext> options) : base(options)
        {
            this.Database.SetCommandTimeout(180);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            ConfigurationBuilder configurationBuilder = new();
            configurationBuilder.AddJsonFile(
                Path.Combine(Directory.GetCurrentDirectory(), "appsettings.json"), false);
            IConfiguration root = configurationBuilder.Build();
            var dbString = root.GetConnectionString("DispositivosIoTDb") ?? "";
            _ = optionsBuilder.UseSqlServer(dbString, builder =>
            {
                builder.EnableRetryOnFailure(5, TimeSpan.FromSeconds(10), null);
            });
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new DispositivosConfiguration());
            modelBuilder.ApplyConfiguration(new EventosConfiguration());
            //modelBuilder.ApplyConfiguration(new UsuarioConfiguration());
            base.OnModelCreating(modelBuilder);
        }

    }
}
