// 10.1 - Crea una Clase "Animal" que implemente la interfaz "IAnimal" , la interfaz "IAnimal" tendrá los métodos, Andar, es perro, saltar.
// implementa estos métodos en la clase. y usa esa clase en un programa de consola.

using System;

namespace Seccion10.Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();

            if (animal.EsPerro())
            {
                animal.Andar();
                animal.Saltar();
            }
        }
    }
}