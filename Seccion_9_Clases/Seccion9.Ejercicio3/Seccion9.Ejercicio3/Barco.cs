using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seccion9.Ejercicio3
{
    public class Barco : Vehiculo
    {
        public Barco()
        {
            base.NumeroDeVehiculo = 0;
        }

        public Barco(int numero)
        {
            base.NumeroDeVehiculo = numero;
        }

        public override void PonerEnMarcha()
        {
            Console.WriteLine("Barco puesto en marcha.");
        }

        public override void Avanzar()
        {
            Console.WriteLine("Barco avanzando.");
        }

        public override void Detener()
        {
            Console.WriteLine("Barco detenido.");
        }
    }
}
