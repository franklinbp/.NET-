using System;

class ClaseAutomovil
{
    public string Color { get; set; }
    public string Marca { get; set; }
    public int Km { get; set; }

    public ClaseAutomovil(string color, string marca, int km)
    {
        Color = color;
        Marca = marca;
        Km = km;
    }
}

class Program
{
    static void Main()
    {
        // Crear un objeto de ClaseAutomovil
        ClaseAutomovil auto = new ClaseAutomovil("Rojo", "Toyota", 12000);

        // Mostrar los valores de los atributos
        Console.WriteLine($"Color: {auto.Color}, Marca: {auto.Marca}, Kilometraje: {auto.Km}");
    }
}
