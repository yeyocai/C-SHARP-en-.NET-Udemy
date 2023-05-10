// 7.2 - Pedir por pantalla 5 nombres, e insertarlo en una Lista (List). Una vez insertados, se pedirá que introduzcamos un nombre,
// el programa tendrá que decirnos, si ese nombre esta contenido en la lista.

using System;

namespace Seccion7.Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listaNombres = new List<string>();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Introduzca un nombre:");
                listaNombres.Add(Console.ReadLine());
            }

            Console.WriteLine("Introduzca nombre a buscar en la lista:");
            var nombre = Console.ReadLine();


            if (listaNombres.Contains(nombre))
            {
                Console.WriteLine("Ese nombre esta contenido en la lista");
            }
            else
            {
                Console.WriteLine("Ese nombre no esta contenido en la lista");
            }
        }
    }
}