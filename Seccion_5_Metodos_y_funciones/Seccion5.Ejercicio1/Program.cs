// 5.1 - Hacer un programa que transforme entre dólares y euros y que también pida el tipo de cambio del día.

using System;

namespace Seccion5.Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            var opcion = ImprimirMenu();

            while (opcion != "3")
            {
                EjecutarOpcion(opcion);
                opcion = ImprimirMenu();
            }
        }

        public static string ImprimirMenu()
        {
            Console.WriteLine("**** Menu ****");
            Console.WriteLine("**** 1. Transformar de dolares a euros ****");
            Console.WriteLine("**** 2. Transformar de euros a dolares ****");
            Console.WriteLine("**** 3. Salir ****");
            return Console.ReadLine();
        }

        public static void EjecutarOpcion(string opcion)
        {
            switch (opcion)
            {
                case "1":
                    Console.WriteLine("Cuantos euros es un dolar? (por ejemplo 0.92)");
                    float cambio1 = float.Parse(Console.ReadLine());

                    Console.WriteLine("Cuantos dolares tienes?:");
                    int dolares = int.Parse(Console.ReadLine());

                    Console.WriteLine("Tenes " + dolares * cambio1 + " euros");
                    Console.ReadKey();
                    break;

                case "2":
                    Console.WriteLine("Cuantos dolares es un euro? (por ejemplo 1.09)");
                    float cambio2 = float.Parse(Console.ReadLine());

                    Console.WriteLine("Cuantos euros tienes?:");
                    int euros = int.Parse(Console.ReadLine());

                    Console.WriteLine("Tenes " + euros * cambio2 + " dolares");
                    Console.ReadKey();
                    break;

                default:
                    break;
            }
        }
    }
}