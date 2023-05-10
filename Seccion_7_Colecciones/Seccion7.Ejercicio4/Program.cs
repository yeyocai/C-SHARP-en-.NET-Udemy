// 7.4 - Crear un programa que nos pida introducir 10 números enteros. Esos valores los introduciremos en un Listado
// y mostraremos el numero mayor y menor, consultando los valores en el Listado.

using System;

namespace Seccion7.Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroMayor;
            int numeroMenor;

            List<int> listaNumerosEnteros = new List<int>();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Introduzca un numero entero:");
                listaNumerosEnteros.Add(int.Parse(Console.ReadLine()));
            }

            numeroMayor = numeroMenor = listaNumerosEnteros[0];

            foreach (int numero in listaNumerosEnteros)
            {
                if (numero > numeroMayor)
                {
                    numeroMayor = numero;
                }

                if (numero < numeroMenor)
                {
                    numeroMenor = numero;
                }
            }
            Console.WriteLine($"El numero mayor es: {numeroMayor}");
            Console.WriteLine($"El numero mayor es: {numeroMenor}");
        }
    }
}