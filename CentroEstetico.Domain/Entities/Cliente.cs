namespace CentroEstetico.Domain.Entities;

public class Cliente : BaseEntity
{
    public string Nombre { get; private set; }
    public string Email { get; private set; }
    public string Telefono { get; private set; }

    public ICollection<Cita> Citas { get; private set; } = new List<Cita>();

    protected Cliente() { }

    public Cliente(string nombre, string email, string telefono)
    {
        Nombre = nombre;
        Email = email;
        Telefono = telefono;
    }
}
