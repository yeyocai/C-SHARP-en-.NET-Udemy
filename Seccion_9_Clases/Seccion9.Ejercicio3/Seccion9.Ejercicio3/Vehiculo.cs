using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seccion9.Ejercicio3
{
    public abstract class Vehiculo
    {
        public int NumeroDeVehiculo { get; set; }

        public abstract void PonerEnMarcha();

        public virtual void Avanzar()
        {
            Console.WriteLine("Vehículo avanzando.");
        }

        public abstract void Detener();
    }
}