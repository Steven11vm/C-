using System;
using System.Collections.Generic;

class Producto
{
    public string Nombre { get; set; }
    public double Precio { get; set; }

    public Producto(string nombre, double precio)
    {
        Nombre = nombre;
        Precio = precio;
    }
}

class Servicio
{
    public string Nombre { get; set; }
    public int Duracion { get; set; }

    public Servicio(string nombre, int duracion)
    {
        Nombre = nombre;
        Duracion = duracion;
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<object> array = new List<object>();

        Producto producto1 = new Producto("Laptop", 1200.0);
        Producto producto2 = new Producto("Teléfono", 800.0);

        Servicio servicio1 = new Servicio("Limpieza", 60);
        Servicio servicio2 = new Servicio("Reparación", 90);

        array.Add(producto1);
        array.Add(producto2);
        array.Add(servicio1);
        array.Add(servicio2);

        Console.WriteLine("Array de objetos:");
        foreach (var item in array)
        {
            if (item is Producto)
            {
                Producto producto = (Producto)item;
                Console.WriteLine($"Producto: {producto.Nombre}, Precio: ${producto.Precio}");
            }
            else if (item is Servicio)
            {
                Servicio servicio = (Servicio)item;
                Console.WriteLine($"Servicio: {servicio.Nombre}, Duración: {servicio.Duracion} minutos");
            }
        }
    }
}
