using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seccion9.Ejercicio3
{
    public class Coche : Vehiculo
    {
        public Coche()
        {
            base.NumeroDeVehiculo = 0;
        }

        public Coche(int numero)
        {
            base.NumeroDeVehiculo = numero;
        }

        public override void PonerEnMarcha()
        {
            Console.WriteLine("Coche puesto en marcha.");
        }

        public override void Avanzar()
        {
            Console.WriteLine("Coche avanzando.");
        }

        public override void Detener()
        {
            Console.WriteLine("Coche detenido.");
        }
    }
}