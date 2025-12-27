namespace CentroEstetico.Domain.Entities;

public class Factura : BaseEntity
{
    public DateTime Fecha { get; private set; }
    public decimal Total { get; private set; }

    public Guid CitaId { get; private set; }
    public Cita Cita { get; private set; }

    public ICollection<DetalleFactura> Detalles { get; private set; }
        = new List<DetalleFactura>();

    protected Factura() { }

    public Factura(Guid citaId)
    {
        Fecha = DateTime.UtcNow;
        CitaId = citaId;
        Total = 0;
    }

    public void CalcularTotal()
    {
        Total = Detalles.Sum(d => d.Subtotal);
    }
}
