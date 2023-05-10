// 4.1 - Crear 3 variables numéricas con el valor que tu quieras y en otra variable numérica guardar el valor de
// la suma de las 3 anteriores. Mostrar por consola.

using System;

namespace Seccion4.Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1 = 15;
            int numero2 = 20;
            int numero3 = 30;

            int SumaNumeros = numero1 + numero2 + numero3;

            Console.WriteLine("El resultado de la suma es: " + SumaNumeros);
            Console.ReadKey();
        }
    }
}