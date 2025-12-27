namespace CentroEstetico.Domain.Entities;

public class Empleado : BaseEntity
{
    public string Nombre { get; private set; }
    public string Especialidad { get; private set; }

    public ICollection<Cita> Citas { get; private set; } = new List<Cita>();

    protected Empleado() { }

    public Empleado(string nombre, string especialidad)
    {
        Nombre = nombre;
        Especialidad = especialidad;
    }
}
