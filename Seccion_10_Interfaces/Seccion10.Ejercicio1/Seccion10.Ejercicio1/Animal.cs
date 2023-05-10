using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seccion10.Ejercicio1
{
    public class Animal : IAnimal
    {
        public void Andar()
        {
            Console.WriteLine("Animal andando.");
        }

        public bool EsPerro()
        {
            return true;
        }

        public void Saltar()
        {
            Console.WriteLine("Animal saltando.");
        }
    }
}
