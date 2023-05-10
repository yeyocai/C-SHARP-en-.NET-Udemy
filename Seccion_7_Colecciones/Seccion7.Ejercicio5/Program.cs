// 7.5 - Usando Arrays, crea un programa que nos pida cuantos elementos tendrá el array,
// dependiendo de ese numero de elementos, nos ira pidiendo valores, que introduciremos en el array.
// Una vez introducidos, nos pedirá un nuevo valor a insertar y la posición donde queremos reemplazarlo en el array.

using System;

namespace Seccion7.Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese cantidad de elementos del array:");
            int cantidadElementos = int.Parse(Console.ReadLine());

            int[] arrayEnteros = new int[cantidadElementos];

            for (int i = 0; i < cantidadElementos; i++)
            {
                Console.WriteLine("Ingrese numero para el array:");
                arrayEnteros[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Ingrese un nuevo valor:");
            int nuevoValor = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese posicion del array donde insertarlo:");
            int posicion = int.Parse(Console.ReadLine());

            arrayEnteros[posicion - 1] = nuevoValor;

            Console.WriteLine("Nuevo array:");
            for (int i = 0; i < cantidadElementos; i++)
            {
                Console.WriteLine(arrayEnteros[i]);
            }
        }
    }
}