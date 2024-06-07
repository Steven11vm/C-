
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese las observaciones:");
        string observaciones = Console.ReadLine();

        // Reemplazar caracteres especiales por "X"
        observaciones = observaciones.Replace("@", "X");
        observaciones = observaciones.Replace("\\", "X");
        observaciones = observaciones.Replace("&", "X");
        observaciones = observaciones.Replace("#", "X");
        
        // Eliminar signos de interrogación
        observaciones = observaciones.Replace("?", "");
        observaciones = observaciones.Replace("¿", "");

        // Añadir "init" al inicio y "end" al final
        observaciones = "init " + observaciones + " end";

        // Convertir a mayúsculas
        Console.WriteLine(observaciones.ToUpper());
    }
}
