using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SensoresIoT.DispositivosIot.Domain.Models;

namespace SensoresIoT.DispositivosIoTInfrastructure.Mappings
{
    public class DispositivosConfiguration : IEntityTypeConfiguration<Dispositivos>
    {
        public void Configure(EntityTypeBuilder<Dispositivos> builder)
        {
            builder.ToTable("Dispositivos");
            builder.Property(model => model.DispositivoID).HasColumnName("DispositivoID").HasComment("Llave principal de la tabla");

        }
    }
}
