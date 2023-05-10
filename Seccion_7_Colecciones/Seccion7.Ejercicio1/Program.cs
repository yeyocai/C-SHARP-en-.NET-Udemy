// 7.1 - Crear un programa, que recorra con un bucle for del 1 al 1000, insertando en cada iteración el valor del numero en un List<T>.
// Una vez acabe el proceso, recorreremos ese List<T> mostrando en consola la suma de los números, ejemplo: 1, 3, 6, 10.

using System;
using System.Collections;

namespace Seccion7.Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int sumaDeNumeros = 0;

            List<int> listaDeNumeros = new List<int>();

            for (int i = 1; i <= 1000; i++)
            {
                listaDeNumeros.Add(i);
            }

            foreach (var numero in listaDeNumeros)
            {
                sumaDeNumeros = sumaDeNumeros + (int)numero;
                Console.WriteLine(sumaDeNumeros);
            }
        }
    }
}