/* 5.3 - Se creará un programa que mediante funciones, nos ayude a desglosar un importe introducido por consola,
   en el numero mínimo posible de billetes y monedas.

  billetes:
  500€ 100€ 50€ 20€ 10€ 5€ 
  monedas:
  2€ 1€ 50cent 20cent 10cent 5cent 2cent 1cent */

using System;

namespace Seccion5.Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese importe:");
            double importe = double.Parse(Console.ReadLine());

            if (importe >= 500)
            {
                int cantidadBilletesDe500 = ContarBilletesDe500(importe);
                importe = importe - (cantidadBilletesDe500 * 500);
                Console.WriteLine("Hay " + cantidadBilletesDe500 + " billete/s de 500");
            }

            if (importe >= 100)
            {
                int cantidadBilletesDe100 = ContarBilletesDe100(importe);
                importe = importe - (cantidadBilletesDe100 * 100);
                Console.WriteLine("Hay " + cantidadBilletesDe100 + " billete/s de 100");
            }

            if (importe >= 50)
            {
                int cantidadBilletesDe50 = ContarBilletesDe50(importe);
                importe = importe - (cantidadBilletesDe50 * 50);
                Console.WriteLine("Hay " + cantidadBilletesDe50 + " billete/s de 50");
            }

            if (importe >= 20)
            {
                int cantidadBilletesDe20 = ContarBilletesDe20(importe);
                importe = importe - (cantidadBilletesDe20 * 20);
                Console.WriteLine("Hay " + cantidadBilletesDe20 + " billete/s de 20");
            }

            if (importe >= 10)
            {
                int cantidadBilletesDe10 = ContarBilletesDe10(importe);
                importe = importe - (cantidadBilletesDe10 * 10);
                Console.WriteLine("Hay " + cantidadBilletesDe10 + " billete/s de 10");
            }

            if (importe >= 5)
            {
                int cantidadBilletesDe5 = ContarBilletesDe5(importe);
                importe = importe - (cantidadBilletesDe5 * 5);
                Console.WriteLine("Hay " + cantidadBilletesDe5 + " billete/s de 5");
            }

            if (importe >= 2)
            {
                int cantidadMonedasDe2 = ContarMonedasDe2(importe);
                importe = importe - (cantidadMonedasDe2 * 2);
                Console.WriteLine("Hay " + cantidadMonedasDe2 + " moneda/s de 2");
            }

            if (importe >= 1)
            {
                int cantidadMonedasDe1 = ContarMonedasDe1(importe);
                importe = importe - (cantidadMonedasDe1 * 1);
                Console.WriteLine("Hay " + cantidadMonedasDe1 + " moneda/s de 1");
            }

            if (importe >= 0.5)
            {
                int cantidadMonedasDe50Cent = ContarMonedasDe50Cent(importe);
                importe = importe - (cantidadMonedasDe50Cent * 0.5);
                Console.WriteLine("Hay " + cantidadMonedasDe50Cent + " moneda/s de 0.50");
            }

            if (importe >= 0.2)
            {
                int cantidadMonedasDe20Cent = ContarMonedasDe20Cent(importe);
                importe = importe - (cantidadMonedasDe20Cent * 0.2);
                Console.WriteLine("Hay " + cantidadMonedasDe20Cent + " moneda/s de 0.20");
            }

            if (importe >= 0.1)
            {
                int cantidadMonedasDe10Cent = ContarMonedasDe10Cent(importe);
                importe = importe - (cantidadMonedasDe10Cent * 0.1);
                Console.WriteLine("Hay " + cantidadMonedasDe10Cent + " moneda/s de 0.10");
            }

            if (importe >= 0.05)
            {
                int cantidadMonedasDe5Cent = ContarMonedasDe5Cent(importe);
                importe = importe - (cantidadMonedasDe5Cent * 0.05);
                Console.WriteLine("Hay " + cantidadMonedasDe5Cent + " moneda/s de 0.05");
            }

            if (importe >= 0.02)
            {
                int cantidadMonedasDe2Cent = ContarMonedasDe2Cent(importe);
                importe = importe - (cantidadMonedasDe2Cent * 0.02);
                Console.WriteLine("Hay " + cantidadMonedasDe2Cent + " moneda/s de 0.02");
            }

            if (importe >= 0.01)
            {
                int cantidadMonedasDe1Cent = ContarMonedasDe1Cent(importe);
                importe = importe - (cantidadMonedasDe1Cent * 0.01);
                Console.WriteLine("Hay " + cantidadMonedasDe1Cent + " moneda/s de 0.01");
            }
        }



        public static int ContarBilletesDe500(double importe)
        {
            return (int)(importe / 500);
        }

        public static int ContarBilletesDe100(double importe)
        {
            return (int)(importe / 100);
        }

        public static int ContarBilletesDe50(double importe)
        {
            return (int)(importe / 50);
        }

        public static int ContarBilletesDe20(double importe)
        {
            return (int)(importe / 20);
        }
        public static int ContarBilletesDe10(double importe)
        {
            return (int)(importe / 10);
        }

        public static int ContarBilletesDe5(double importe)
        {
            return (int)(importe / 5);
        }

        public static int ContarMonedasDe2(double importe)
        {
            return (int)(importe / 2);
        }

        public static int ContarMonedasDe1(double importe)
        {
            return (int)(importe / 1);
        }

        public static int ContarMonedasDe50Cent(double importe)
        {
            return (int)(importe / 0.5);
        }

        public static int ContarMonedasDe20Cent(double importe)
        {
            return (int)(importe / 0.2);
        }

        public static int ContarMonedasDe10Cent(double importe)
        {
            return (int)(importe / 0.1);
        }

        public static int ContarMonedasDe5Cent(double importe)
        {
            return (int)(importe / 0.05);
        }

        public static int ContarMonedasDe2Cent(double importe)
        {
            return (int)(importe / 0.02);
        }

        public static int ContarMonedasDe1Cent(double importe)
        {
            return (int)(importe / 0.01);
        }
    }
}