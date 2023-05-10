using System;

// 7.3 - Pedir por pantalla 10 números, que iremos almacenando en un Listado (o 2 como preferamos). Al terminar de introducir los números,
// tendremos que recorrer el/los listados, diciéndonos cuanto suman los pares y cuanto los impares.

namespace Seccion7.Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int SumaNumerosPares = 0;
            int SumaNumerosImpares = 0;

            List<int> listaNumeros = new List<int>();

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Ingrese un numero:");
                listaNumeros.Add(int.Parse(Console.ReadLine()));
            }

            foreach (int numero in listaNumeros)
            {
                if (numero % 2 == 0)
                {
                    SumaNumerosPares = SumaNumerosPares + numero;
                }
                else
                {
                    SumaNumerosImpares = SumaNumerosImpares + numero;
                }
            }

            Console.WriteLine($"La suma de numeros pares es: {SumaNumerosPares}");
            Console.WriteLine($"La suma de numeros impares es: {SumaNumerosImpares}");
        }
    }
}