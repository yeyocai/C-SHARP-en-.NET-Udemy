/* 5.2 - Crear una calculadora, usando funciones de suma, resta, multiplicación y división.
   Se creará un menú por consola, de la siguiente forma:
         1- Suma
         2- Resta
         3- Multiplicación
         4- División
    Seleccione la opción:
    dependiendo de la selección, se pedirán 2 números, y usando las funciones creadas, devolverá el resultado por consola */

using System;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;

namespace Seccion5.Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcion = ImprimirMenu();

            while (opcion != "0")
            {
                EjecutarOpcion(opcion);
                opcion = ImprimirMenu();
            }
        }

        public static string ImprimirMenu()
        {
            Console.WriteLine("**** CALCULADORA ****");
            Console.WriteLine("1 - Suma");
            Console.WriteLine("2 - Resta");
            Console.WriteLine("3 - Multiplicacion");
            Console.WriteLine("4 - Division");
            Console.WriteLine("0 - Salir");
            return Console.ReadLine();
        }

        public static void EjecutarOpcion(string opcion)
        {
            Console.WriteLine("Ingrese primer numero:");
            int numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese segundo numero:");
            int numero2 = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case "1":
                    Console.WriteLine(numero1 + " + " + numero2 + " = " + Sumar(numero1, numero2));
                    break;

                case "2":
                    Console.WriteLine(numero1 + " - " + numero2 + " = " + Restar(numero1, numero2));
                    break;

                case "3":
                    Console.WriteLine(numero1 + " * " + numero2 + " = " + Multiplicar(numero1, numero2));
                    break;

                case "4":
                    Console.WriteLine(numero1 + " / " + numero2 + " = " + Dividir(numero1, numero2));
                    break;

                default:
                    break;
            }
            Console.ReadKey();
        }

        public static int Sumar(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int Restar(int num1, int num2)
        {
            return num1 - num2;
        }

        public static int Multiplicar(int num1, int num2)
        {
            return num1 * num2;
        }

        public static float Dividir(int num1, int num2)
        {
            return (float)num1 / (float)num2;
        }
    }
}