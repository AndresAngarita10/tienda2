using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration
{
    public class PaisConfiguration : IEntityTypeConfiguration<Pais>
    {
        public void Configure(EntityTypeBuilder<Pais> builder)
        {
            // Aquí puedes configurar las propiedades de la entidad Marca
            // utilizando el objeto 'builder'.
            builder.ToTable("pais");

            builder.Property(p => p.NombrePais)
            .IsRequired()
            .HasMaxLength(50);

            

           /*  builder.HasKey(e => );
            builder.Property(e => ); */
        }
    }
}