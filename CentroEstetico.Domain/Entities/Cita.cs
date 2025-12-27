namespace CentroEstetico.Domain.Entities;

public class Cita : BaseEntity
{
    public DateTime Fecha { get; private set; }

    public Guid ClienteId { get; private set; }
    public Cliente Cliente { get; private set; }

    public Guid EmpleadoId { get; private set; }
    public Empleado Empleado { get; private set; }

    public Factura Factura { get; private set; }

    protected Cita() { }

    public Cita(DateTime fecha, Guid clienteId, Guid empleadoId)
    {
        Fecha = fecha;
        ClienteId = clienteId;
        EmpleadoId = empleadoId;
    }
}
