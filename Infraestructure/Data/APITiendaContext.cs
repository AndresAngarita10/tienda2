
using System.Reflection;
using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infraestructure.Data;

public class APITiendaContext : DbContext
{
    public APITiendaContext(DbContextOptions <APITiendaContext> options) : base(options)
    {

    }
    public DbSet<Estado> Estados { get; set; }
    public DbSet<Pais> Paises { get; set; }
    public DbSet<Persona> Personas { get; set; }
    public DbSet<Producto> Productos { get; set; }
    public DbSet<ProductoPersona> ProductosPersonas { get; set; }
    public DbSet<Region> Regiones { get; set; }
    public DbSet<TipoPersona> TiposPersonas { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {/* 
        modelBuilder.Entity<ProductoPersona>().HasKey(p => p.Id); */
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}
