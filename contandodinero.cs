using system

class program {
    static void main (){
        double suma = 0;

        while (true){
            Console.write("Ingresa un numero(ingresa un numero negrativi)");
            double numero = Convert.ToDouble(Console.Readline());
            if (numero < 0){
                break;
            }
            suma += numero;
        }
        Console.Writeline("la suma total es: "+ sumaa);
    }
    }
}