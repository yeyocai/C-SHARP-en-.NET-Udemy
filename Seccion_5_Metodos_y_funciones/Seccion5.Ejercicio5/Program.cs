// 5.5 - Crear un programa usando funciones, que introduciendo un número por consola,
// imprima su tabla de multiplicar en la consola.

using System;

namespace Seccion5.Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero:");
            int numero = int.Parse(Console.ReadLine());

            ImprimirTablaDeMultiplicar(numero);
        }

        public static void ImprimirTablaDeMultiplicar(int num)
        {
            Console.WriteLine("Tabla de multiplicar:");

            for (int i = 1; i <= 9; i++)
            {
                Console.WriteLine(num + " * " + i + " = " + Multiplicar(num, i));
            }
            Console.ReadKey();
        }

        public static int Multiplicar(int numero1, int numero2)
        {
            return numero1 * numero2;
        }
    }
}