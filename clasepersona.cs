using System;

class ClasePersona
{
    private string nombre;
    private int edad;

    public void Inicializar()
    {
        Console.Write("Ingrese el nombre: ");
        nombre = Console.ReadLine();
        Console.Write("Ingrese la edad: ");
        edad = int.Parse(Console.ReadLine());
    }

    public void Imprimir()
    {
        Console.WriteLine($"Nombre: {nombre}");
        Console.WriteLine($"Edad: {edad}");
    }

    public void EsMayorEdad()
    {
        if (edad >= 18)
        {
            Console.WriteLine($"{nombre} es mayor de edad.");
        }
        else
        {
            Console.WriteLine($"{nombre} no es mayor de edad.");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        ClasePersona persona = new ClasePersona();
        persona.Inicializar();
        persona.Imprimir();
        persona.EsMayorEdad();
    }
}
