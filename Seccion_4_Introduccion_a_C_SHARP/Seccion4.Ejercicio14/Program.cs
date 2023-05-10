// 4.14 - Crear un programa calcule cuantas cifras tiene un número entero positivo (pista: se puede hacer dividiendo varias veces entre 10).

using System;

namespace Seccion4.Ejercicio14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero entero positivo:");
            int numero = int.Parse(Console.ReadLine());

            float numeroDividido = numero; // Creo una variable float, para que en la division acepte resultados con decimales
            int cantidadDeCifras = 0;

            while (numeroDividido > 1)
            {
                numeroDividido = numeroDividido / 10;
                cantidadDeCifras++;
            }
            Console.WriteLine("El numero ingresado tiene " + cantidadDeCifras + " cifra/s");
            Console.ReadKey();
        }
    }
}