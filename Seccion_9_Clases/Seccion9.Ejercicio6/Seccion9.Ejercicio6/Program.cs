// 9.6 - Crea una clase "Animal" con las siguientes propiedades: Tipo, color pelo, es domestico, numero de patas,
// con el tipo de dato que creas conveniente. crea una instancia de esa clase, y asigna los valores a las propiedades.

using System;

namespace Seccion9.Ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Formas de asignar valores¨:

            Animal animal1 = new Animal("Perro", "Negro", true, 4);

            // o
            Animal animal2 = new Animal
            {
                Tipo = "Perro",
                ColorPelo = "Blanco",
                EsDomestico = true,
                NumeroDePatas = 4,
            };

            // o 
            Animal animal3 = new Animal();
            animal2.Tipo = "Gato";
            animal2.ColorPelo = "Marron";
            animal2.EsDomestico = true;
            animal2.NumeroDePatas = 4;
        }
    }
}