// 4.10 - Pide 10 números por consola, muestra el resultado por consola de sumar los pares y de sumar los impares.

using System;

namespace Seccion4.Ejercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            int sumaPares = 0;
            int sumaImpares = 0;

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Ingrese un numero");
                var numero = Console.ReadLine();

                int numeroInt = int.Parse(numero);

                if (numeroInt % 2 == 0)
                {
                    sumaPares += numeroInt;
                }
                else
                {
                    sumaImpares += numeroInt;
                }
            }
            Console.WriteLine("La suma de los numeros pares es: " + sumaPares);
            Console.WriteLine("La suma de los numeros impares es: " + sumaImpares);
            Console.ReadKey();
        }
    }
}