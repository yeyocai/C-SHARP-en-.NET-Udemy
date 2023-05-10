// 6.1 - Crear un programa que pida al usuario su nombre, y le diga "Hola" si se llama "Alejandro",
// o bien le diga "No te conozco" si teclea otro nombre. tener en cuenta, que el la validación no es case sensitive,
// es decir que si escriben "alejandro" ,"Alejandro", "aleJANdrO" serán valores validos.

using System;

namespace Seccion6.Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su nombre:");
            string nombre = Console.ReadLine();

            if (nombre.ToUpper() == "ALEJANDRO")
            {
                Console.WriteLine("Hola");
            }
            else
            {
                Console.WriteLine("No te conozco");
            }
            Console.ReadKey();
        }
    }
}