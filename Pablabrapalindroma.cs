using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Ingrese una palabra o frase: ");
        string entrada = Console.ReadLine().ToLower();

        bool esPalindromo = true;
        int contadorVocales = 0;

        for (int i = 0; i < entrada.Length / 2; i++)
        {
            if (entrada[i] != entrada[entrada.Length - 1 - i])
            {
                esPalindromo = false;
                break;
            }
        }

        foreach (char c in entrada)
        {
            if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
            {
                contadorVocales++;
            }
        }

        if (esPalindromo)
        {
            Console.WriteLine("La palabra/frase es un palíndromo.");
        }
        else
        {
            Console.WriteLine("La palabra/frase no es un palíndromo.");
        }

        Console.WriteLine("Número de vocales en la palabra/frase: " + contadorVocales);
    }
}
