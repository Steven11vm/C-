using System;

class ConversorMoneda
{
    public double ConvertirDolaresAPesos(double cantidadDolares, double tipoCambio)
    {
        return cantidadDolares * tipoCambio;
    }

    public void CalcularVariacionDolar(double precioActual, double precioAnterior)
    {
        double variacion = ((precioActual - precioAnterior) / precioAnterior) * 100;
        Console.WriteLine($"Variación del precio del dólar: {variacion.ToString("0.00")}%");
    }
}

class Program
{
    static void Main(string[] args)
    {
        ConversorMoneda conversor = new ConversorMoneda();

        double precioDolarActual = 3800.0;
        double precioDolarAnterior = 3700.0;
        double cantidadDolares = 100.0;

        double cantidadPesos = conversor.ConvertirDolaresAPesos(cantidadDolares, precioDolarActual);
        Console.WriteLine($"${cantidadDolares} dólares son ${cantidadPesos} pesos colombianos.");

        conversor.CalcularVariacionDolar(precioDolarActual, precioDolarAnterior);
    }
}
