namespace CentroEstetico.Domain.Entities;

public class Servicio : BaseEntity
{
    public string Nombre { get; private set; }
    public decimal Precio { get; private set; }

    protected Servicio() { }

    public Servicio(string nombre, decimal precio)
    {
        Nombre = nombre;
        Precio = precio;
    }
}
