// 4.12 - Crea un programa que pida por consola un numero del 1 al 1000 (validara que el numero introducido es correcto)
// y sume todos los números del 1 al numero introducido, mostrando por consola el numero de la suma y la media.

using System;

namespace Seccion4.Ejercicio12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero del 1 al 1000");
            var numero = Console.ReadLine();
            int numeroInt = int.Parse(numero);

            int suma = 0;

            if (numeroInt >= 1 && numeroInt <= 1000)
            {
                for (int i = 1; i <= numeroInt; i++)
                {
                    suma += i;
                }
                Console.WriteLine("La suma del 1 al " + numero + " es: " + suma);
                Console.WriteLine("La media es: " + (suma / numeroInt));
            }
            else
            {
                Console.WriteLine("El numero ingresado es incorrecto");
            }
            Console.ReadKey();
        }
    }
}