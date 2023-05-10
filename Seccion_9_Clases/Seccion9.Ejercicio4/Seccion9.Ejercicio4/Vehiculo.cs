using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seccion9.Ejercicio4
{
    public class Vehiculo
    {
        public int Ruedas { get; set; }
        public int PuertasPrivadas { get; set; }

        public Vehiculo()
        {
            Ruedas = 0;
            PuertasPrivadas = 0;
        }

        public Vehiculo(int ruedas, int puertasPrivadas)
        {
            Ruedas = ruedas;
            PuertasPrivadas = puertasPrivadas;
        }

        public Vehiculo(int puertasPrivadas)
        {
            Ruedas = 4;
            PuertasPrivadas = puertasPrivadas;
        }
    }
}