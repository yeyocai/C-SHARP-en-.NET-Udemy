// 9.5 - Crea una clase estática "Producto", con un método estático, que sume 2 valores pasados por parámetro, úsalo desde otro lugar.

using System;

namespace Seccion9.Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese primer numero:");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese segundo numero:");
            int num2 = int.Parse(Console.ReadLine());

            var resultado = Producto.SumarProductos(num1, num2);

            Console.WriteLine($"El resultado de la suma es: {resultado}");
        }
    }
}