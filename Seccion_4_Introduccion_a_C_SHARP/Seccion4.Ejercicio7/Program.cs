// 4.7 - Recorre los números del 1 al 100. Muestra los números pares. Usar el tipo de bucle que quieras.

using System;

namespace Seccion4.Ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
    }
}