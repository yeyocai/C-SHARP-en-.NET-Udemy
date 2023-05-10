// 4.11 - Crea un programa, que pida un número del 1 al 7,  devuelva el día de la semana,
// teniendo en cuenta que el 1 es Lunes, hacer con un switch.

using System;

namespace Seccion4.Ejercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero del 1 al 7:");
            var numero = Console.ReadLine();
            int diaDeLaSemana = int.Parse(numero);

            switch (diaDeLaSemana)
            {
                case 1:
                    Console.WriteLine("Lunes");
                    break;

                case 2:
                    Console.WriteLine("Martes");
                    break;

                case 3:
                    Console.WriteLine("Miercoles");
                    break;

                case 4:
                    Console.WriteLine("Jueves");
                    break;

                case 5:
                    Console.WriteLine("Viernes");
                    break;

                case 6:
                    Console.WriteLine("Sabado");
                    break;

                case 7:
                    Console.WriteLine("Domingo");
                    break;

                default:
                    Console.WriteLine("El numero ingresado no corresponde a nungun dia");
                    break;
            }
            Console.ReadKey();
        }
    }
}