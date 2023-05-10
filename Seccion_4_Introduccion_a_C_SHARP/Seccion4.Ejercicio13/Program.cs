// 4.13 - Comprobar si un numero introducido por consola es primo

using System;

namespace Seccion4.Ejercicio13
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 0, numero;

            Console.WriteLine("Introduzca un numero:");
            numero = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numero; i++)
            {
                if (numero % i == 0)
                {
                    contador++;
                }
            }
            if (contador == 2)
            {
                Console.WriteLine("El numero es primo");
            }
            else
            {
                Console.WriteLine("El numero no es primo");
            }
            Console.ReadKey();
        }
    }
}