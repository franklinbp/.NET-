using System;
using System.collecctions.Generic;
using System.linq;

class estudiante(string nombre, int edad)
{
    nombre = nombres;
    edad = edad;
    cursos = new list<string>();
    calificaciones = new Dictionary<string, list<int>>();
}
public void inscribir curso(string curo, int nota)
{
    if (calificaciones.ContainsKey(curso)){
        calificaciones[curso].add(nota);}
    else{
        console.writeline($"El estudiante no esta inscrito en el curso")
    }
}

public double promedionotas()
{
   var todaslasnotas = calificaciones.value.selectMany(n=>n).Tolist();
   return todaslasnotas.count > 0? todaslasnotas.Average() : 0.0;

}

class Program
{
    static void Main()
    {
        Estudiante estudiante1 = new Estudiante("Carlos", 20);

        estudiante1.InscribirCurso("Matemáticas");
        estudiante1.InscribirCurso("Historia");

        estudiante1.AgregarCalificacion("Matemáticas", 90);
        estudiante1.AgregarCalificacion("Matemáticas", 85);
        estudiante1.AgregarCalificacion("Historia", 88);

        Console.WriteLine($"Nombre: {estudiante1.Nombre}");
        Console.WriteLine($"Edad: {estudiante1.Edad}");
        Console.WriteLine($"Cursos inscritos: {string.Join(", ", estudiante1.Cursos)}");
        Console.WriteLine($"Promedio de notas: {estudiante1.PromedioNotas():F2}");
    }
}
