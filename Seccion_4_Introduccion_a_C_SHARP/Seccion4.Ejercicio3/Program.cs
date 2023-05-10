// 4.3 - Pedir el nombre del día de la semana al usuario y decirle si es fin de semana o no. En caso de error, indicarlo.

using System;

namespace Seccion4.Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese dia de la semana (Lunes, Martes, Miercoles, Jueves, Viernes, Sabado o Domingo)");
            string dia = Console.ReadLine();

            if (dia == "Lunes" || dia == "Martes" || dia == "Miercoles" || dia == "Jueves" || dia == "Viernes")
            {
                Console.WriteLine("No es fin de semana");
                Console.ReadKey();
            }
            else if (dia == "Sabado" || dia == "Domingo")
            {
                Console.WriteLine("Es fin de semana");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("El dia ingresado no existe");
                Console.ReadKey();
            }
        }
    }
}