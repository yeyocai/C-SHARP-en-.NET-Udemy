// 6.4 - Escribir un programa que pida 4 números por consola, y escriba la siguiente frase, "El primer numero introducido es el <numero1> ,
// despues han introducido el <numero2> y <numero3> y por ultimo el <numero4>"  utilizar StringBuilder para realizar el ejercicio.

using System;
using System.Text;

namespace Seccion6.Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese primer numero:");
            StringBuilder sb = new StringBuilder($"El primer numero introducido es el {Console.ReadLine()}, ");

            Console.WriteLine("Ingrese segundo numero:");
            sb.Append($"despues han introducido el {Console.ReadLine()}");

            Console.WriteLine("Ingrese tercer numero:");
            sb.Append($" y {Console.ReadLine()}");

            Console.WriteLine("Ingrese cuarto numero:");
            sb.Append($" y por ultimo el {Console.ReadLine()}");

            Console.WriteLine(sb);
        }
    }
}