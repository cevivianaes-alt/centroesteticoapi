namespace CentroEstetico.Domain.Entities;

public class DetalleFactura : BaseEntity
{
    public Guid FacturaId { get; private set; }
    public Factura Factura { get; private set; }

    public Guid ServicioId { get; private set; }
    public Servicio Servicio { get; private set; }

    public int Cantidad { get; private set; }
    public decimal PrecioUnitario { get; private set; }

    public decimal Subtotal => Cantidad * PrecioUnitario;

    protected DetalleFactura() { }

    public DetalleFactura(Guid servicioId, int cantidad, decimal precioUnitario)
    {
        ServicioId = servicioId;
        Cantidad = cantidad;
        PrecioUnitario = precioUnitario;
    }
}
