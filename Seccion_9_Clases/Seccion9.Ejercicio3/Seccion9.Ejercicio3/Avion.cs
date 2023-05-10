using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seccion9.Ejercicio3
{
    public class Avion : Vehiculo
    {
        public Avion()
        {
            base.NumeroDeVehiculo = 0;
        }

        public Avion(int numero)
        {
            base.NumeroDeVehiculo = numero;
        }

        public override void PonerEnMarcha()
        {
            Console.WriteLine("Avion puesto en marcha.");
        }

        public override void Avanzar()
        {
            Console.WriteLine("Avion avanzando.");
        }

        public override void Detener()
        {
            Console.WriteLine("Avion detenido.");
        }
    }
}
