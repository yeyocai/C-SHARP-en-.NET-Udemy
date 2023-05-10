// 4.8 - Recorre los números del 1 al 100. Muestra los números pares o divisibles entre 3.

using System;

namespace Seccion4.Ejercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0 || i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
    }
}