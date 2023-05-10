// 9.4 - Crear una Clase Vehículo, con las propiedades , Ruedas, puertas privadas, crear 3 constructores para asignar los valores
// de las propiedades, el constructor por defecto y 2 constructores mas que creas convenientes.

using System;
using System.Timers;

namespace Seccion9.Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehiculo vehiculo1 = new Vehiculo();
            Console.WriteLine($"El vehiculo tiene {vehiculo1.Ruedas} ruedas y {vehiculo1.PuertasPrivadas} puertas privadas.");

            Vehiculo vehiculo2 = new Vehiculo(4, 2);
            Console.WriteLine($"El vehiculo tiene {vehiculo2.Ruedas} ruedas y {vehiculo2.PuertasPrivadas} puertas privadas.");

            Vehiculo vehiculo3 = new Vehiculo(4);
            Console.WriteLine($"El vehiculo tiene {vehiculo3.Ruedas} ruedas y {vehiculo3.PuertasPrivadas} puertas privadas.");
        }
    }
}