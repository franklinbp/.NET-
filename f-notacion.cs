using system
{
    static void Main(){
        console.write("Cual es tu nombre? ");
        string nombre = console.readline();
        console.write("Cual es tu nombre? ");
        string edad = console.readline();
        console.write("Cual es tu nombre? ");
        string ciudad = console.readline();

        console.writeline($"Hola {nombre} tienes {edad} y vives en la ciudad {ciudad}.");

    }
}