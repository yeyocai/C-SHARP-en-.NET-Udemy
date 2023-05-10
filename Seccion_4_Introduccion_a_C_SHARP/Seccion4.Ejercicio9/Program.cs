// 4.9 - Crea un array e inserta los números pares del 1 al 100 en ese array.

using System;

namespace Seccion4.Ejercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayDeEnteros = new int[50];
            int subindice = 0;

            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    arrayDeEnteros[subindice] = i;
                    subindice++;
                }
            }

            foreach (var numeroPar in arrayDeEnteros)
            {
                Console.WriteLine(numeroPar);
            }
            Console.ReadKey();
        }
    }
}