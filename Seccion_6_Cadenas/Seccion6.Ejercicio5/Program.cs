// 6.5 - Crear un programa que muestre las letras de la Z (mayúscula) a la A (mayúscula, descendiendo)

using System;

namespace Seccion6.Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ABECEDARIO DESCENDENTE:");

            for (int i = 90; i >= 65; i--)
            {
                Console.WriteLine(Convert.ToString((char)i));  
            }
        }
    }
}