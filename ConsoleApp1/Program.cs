public class Vehículo
{
    // Propiedades encapsuladas
    private int velocidad;
    private string marca;
    private string modelo;

    // Propiedades públicas para acceder a las propiedades encapsuladas
    public int Velocidad
    {
        get { return velocidad; }
        set { velocidad = value; }
    }

    public string Marca
    {
        get { return marca; }
        set { marca = value; }
    }

    public string Modelo
    {
        get { return modelo; }
        set { modelo = value; }
    }

    // Métodos virtuales para ser sobrescritos en las clases derivadas
    public virtual void Frenar()
    {
        // Lógica para frenar
        if (velocidad > 0)
        {
            velocidad -= 10;
        }
    }

    public virtual void Encender()
    {
        // Lógica para encender el vehículo
        Console.WriteLine("El vehículo está encendido.");
    }

    public virtual void Apagar()
    {
        // Lógica para apagar el vehículo
        Console.WriteLine("El vehículo está apagado.");
    }
}
