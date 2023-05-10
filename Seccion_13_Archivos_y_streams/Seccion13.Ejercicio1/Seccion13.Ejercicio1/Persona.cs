using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seccion13.Ejercicio1
{
    public class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Localidad { get; set; }

        public Persona()
        {
            Nombre = string.Empty;
            Edad = 0;
            Localidad = string.Empty;
        }

        public Persona(string nombre, int edad, string localidad)
        {
            Nombre = nombre;
            Edad = edad;
            Localidad = localidad;
        }
    }
}
