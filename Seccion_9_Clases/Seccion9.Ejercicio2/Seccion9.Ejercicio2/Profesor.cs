using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seccion9.Ejercicio2
{
    public class Profesor : Persona
    {
        public string MateriaQueImparte { get; set; }

        public Profesor()
        {
            base.Nombre = String.Empty;
            base.Edad = 0;
            MateriaQueImparte = string.Empty;
        }

        public Profesor(string nombre, int edad, string materiaQueImparte)
        {
            base.Nombre = nombre;
            base.Edad = edad;
            MateriaQueImparte = materiaQueImparte;
        }
    }
}
