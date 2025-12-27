using CentroEstetico.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CentroEstetico.Infrastructure.Persistence;

public class CentroEsteticoDbContext : DbContext
{
    public CentroEsteticoDbContext(DbContextOptions<CentroEsteticoDbContext> options)
        : base(options) { }

    public DbSet<Cliente> Clientes => Set<Cliente>();
    public DbSet<Empleado> Empleados => Set<Empleado>();
    public DbSet<Servicio> Servicios => Set<Servicio>();
    public DbSet<Cita> Citas => Set<Cita>();
    public DbSet<Factura> Facturas => Set<Factura>();
    public DbSet<DetalleFactura> DetalleFacturas => Set<DetalleFactura>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Cliente>().HasKey(x => x.Id);
        modelBuilder.Entity<Empleado>().HasKey(x => x.Id);
        modelBuilder.Entity<Servicio>().HasKey(x => x.Id);
        modelBuilder.Entity<Cita>().HasKey(x => x.Id);
        modelBuilder.Entity<Factura>().HasKey(x => x.Id);
        modelBuilder.Entity<DetalleFactura>().HasKey(x => x.Id);
    }
}
