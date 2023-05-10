// 9.3 - Crear una Clase Base "Vehículo", y 3 clases derivadas de Vehículo, Coche, Barco, Avión, crea unos métodos en vehículo,
// y sobrecargarlos en la clase derivada.

using System;

namespace Seccion9.Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vehiculo> listaVehiculos = new List<Vehiculo>();

            listaVehiculos.Add(new Coche(1));
            listaVehiculos.Add(new Barco(2));
            listaVehiculos.Add(new Avion(3));

            foreach (var item in listaVehiculos)
            {
                Console.WriteLine($"Numero de vehiculo: {item.NumeroDeVehiculo}");
                item.PonerEnMarcha();
                item.Avanzar();
                item.Detener();
            }
        }
    }
}