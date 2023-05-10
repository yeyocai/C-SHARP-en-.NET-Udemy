using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seccion9.Ejercicio2
{
    public class Alumno : Persona
    {
        public int NumeroDeAlumno { get; set; }

        public Alumno()
        {
            base.Nombre = String.Empty;
            base.Edad = 0;
            NumeroDeAlumno = 0;
        }

        public Alumno(string nombre, int edad, int numeroDeAlumno)
        {
            base.Nombre = nombre;
            base.Edad = edad;
            NumeroDeAlumno = numeroDeAlumno;
        }
    }
}
