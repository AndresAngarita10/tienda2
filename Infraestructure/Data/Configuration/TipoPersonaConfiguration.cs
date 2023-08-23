using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration
{
    public class Configuration : IEntityTypeConfiguration<TipoPersona>
    {
        public void Configure(EntityTypeBuilder<TipoPersona> builder)
        {
            // Aquí puedes configurar las propiedades de la entidad Marca
            // utilizando el objeto 'builder'.
            builder.ToTable("tipopersona");

            builder.Property(p => p.Descripcion)
            .IsRequired()
            .HasMaxLength(50);

/*             builder.HasKey(e => );
            builder.Property(e => ); */
        }
    }
}