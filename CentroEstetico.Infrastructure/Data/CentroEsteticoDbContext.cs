using Microsoft.EntityFrameworkCore;
using CentroEstetico.Domain.Entities;

namespace CentroEstetico.Infrastructure.Data
{
    public class CentroEsteticoDbContext : DbContext
    {
        public CentroEsteticoDbContext(DbContextOptions<CentroEsteticoDbContext> options)
            : base(options)
        {
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Servicio> Servicios { get; set; }
        public DbSet<Cita> Citas { get; set; }
        public DbSet<Factura> Facturas { get; set; }
        public DbSet<DetalleFactura> DetallesFactura { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Aquí luego agregaremos configuraciones Fluent API
        }
    }
}
