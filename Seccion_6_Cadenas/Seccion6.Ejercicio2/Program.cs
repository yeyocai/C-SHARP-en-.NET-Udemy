// 6.2 - Escribir un programa que pida una palabra, y la escriba a su inversa , por ejemplo si se introduce Paris,
// devolverá "Sirap".

using System;

namespace Seccion6.Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese una palabra:");
            var palabra = Console.ReadLine();

            var palabraAlRevesArray = palabra.Reverse(); // Reverse() devuelve un array de chars invertido

            string palabraAlReves = "";

            foreach (var item in palabraAlRevesArray)
            {
                palabraAlReves = palabraAlReves + item; // Concateno
            }

            Console.WriteLine(palabraAlReves);
            Console.ReadKey();
        }
    }
}