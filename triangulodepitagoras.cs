using System;

public class Class1
{
	public Class1()
	{
		Console.WriteLine("Ingrse el numero de la tabla");
		int numero = int.Parse(Console.readline());

		//generar la tabla de pitagoras

		for (int i = 1; i <= numero; i++) {
			for (int j = 1; j <= numero; i ++) {
				Console.write((i * j) + "\t");
			}
			console.writeline();
		}

	}
}
