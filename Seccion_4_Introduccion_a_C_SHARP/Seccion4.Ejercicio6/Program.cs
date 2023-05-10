// 4.6 - Recorre los números del 1 al 100. Usa un bucle while.

using System;
using System.Collections;

namespace Seccion4.Ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            int ciclo = 1;
            while (ciclo <= 100)
            {
                Console.WriteLine(ciclo);
                ciclo++;
            }
            Console.ReadKey();
        }
    }
}