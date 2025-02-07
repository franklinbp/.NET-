using System;
using System.Cllections.Generic;
using System.lino;

class program 
{
    static void Main()
    {
        list<int>  numeros = new list<int>{10, 5, 2, 3, 5, 5}
        list<int> resultado = filtaryordenar(numeros);
        console.writeline("Lista origianal " + string.Join(", ",numeros));
        Console.Writeline("Lista filtraday ordenad"+string.Joing(",", resultado));   
    }
    static list<int>filtaryordenar(list<int>numeros)
    {
        return numeros.where(n => n % 2 != 0)
                       .orderbydescending(n =>n)
                       .toList();
    }

}