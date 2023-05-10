// 4.2 - Pedir dos números al usuario por teclado y decir que número es el mayor.

using System;
using System.ComponentModel.Design;

namespace Seccion4.Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un numero: ");
            var numero1 = Console.ReadLine();
            Console.Write("Ingrese otro numero: ");
            var numero2 = Console.ReadLine();

            if (int.Parse(numero1) > int.Parse(numero2))
            {
                Console.WriteLine(numero1 + " es mayor que " + numero2);
            }
            else if (int.Parse(numero1) < int.Parse(numero2))
            {
                Console.WriteLine(numero2 + " es mayor que " + numero1);
            }
            else
            {
                Console.WriteLine(numero1 + " es igual que " + numero2);
            }
        }
    }
}