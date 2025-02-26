using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SensoresIoT.DispositivosIot.Domain.Models;

namespace SensoresIoT.DispositivosIoTInfrastructure.Mappings
{
    public class EventosConfiguration : IEntityTypeConfiguration<Eventos>
    {
        public void Configure(EntityTypeBuilder<Eventos> builder)
        {
            builder.ToTable("Eventos");
            builder.Property(model => model.IdEvento).HasColumnName("Id").HasComment("Llave principal de la tabla");

        }
    }
}
