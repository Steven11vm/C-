using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<double> numeros = new List<double>();
        int n = 5;

        Random random = new Random();
        for (int i = 0; i < n; i++)
        {
            numeros.Add(random.NextDouble() * 100);
        }

        Console.WriteLine("Array en desorden:");
        foreach (var num in numeros)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();

        for (int i = 0; i < numeros.Count - 1; i++)
        {
            for (int j = i + 1; j < numeros.Count; j++)
            {
                if (numeros[i] > numeros[j])
                {
                    double temp = numeros[i];
                    numeros[i] = numeros[j];
                    numeros[j] = temp;
                }
            }
        }

        Console.WriteLine("\nArray en orden ascendente:");
        foreach (var num in numeros)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}
