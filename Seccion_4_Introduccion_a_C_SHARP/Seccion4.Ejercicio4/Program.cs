// 4.4 - Pedir al usuario el precio de un producto (valor positivo) y la forma de pagar (efectivo o tarjeta)
// si la forma de pago es mediante tarjeta, pedir el numero de cuenta (inventado).

using System;

namespace Seccion4.Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese precio del producto (valor positivo)");
            var precio = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese forma de pago (efectivo o tarjeta)");
            var formaDePago = Console.ReadLine();

            if (formaDePago == "tarjeta")
            {
                Console.WriteLine("Ingrese numero de cuenta");
                var numeroDeCuenta = Console.ReadLine();
                Console.WriteLine("Su numero de tarjeta es " + numeroDeCuenta);
                Console.ReadKey();
            }

        }
    }
}