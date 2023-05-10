using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seccion9.Ejercicio6
{
    public class Animal
    {
        public string Tipo { get; set; }

        public string ColorPelo { get; set; }

        public bool EsDomestico { get; set; }

        public int NumeroDePatas { get; set; }

        public Animal()
        {
            Tipo = String.Empty;
            ColorPelo = String.Empty;
            EsDomestico = false;
            NumeroDePatas = 0;
        }

        public Animal(string tipo, string colorPelo, bool esDomestico, int numeroDePatas)
        {
            Tipo = tipo;
            ColorPelo = colorPelo;
            EsDomestico = esDomestico;
            NumeroDePatas = numeroDePatas;
        }
    }
}