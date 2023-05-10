// 9.1 - Desarrollar un programa que permita cargar 5 nombres de personas y sus edades respectivas.
// Luego de realizar la carga por teclado de todos los datos imprimir los nombres de las personas mayores de edad
// (mayores o iguales a 18 años), se tendrá que crear una clase "Persona" que contenga las propiedades "Nombre" y "Edad".
// Utilizar todos los componentes vistos hasta la fecha (bucles, funciones, clases).

using System;

namespace Seccion9.Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            int edad;
            List<Persona> listaPersonas = new List<Persona>();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Ingrese nombre de la persona {i + 1}:");
                nombre = Console.ReadLine();
                Console.WriteLine($"Ingrese edad de la persona {i + 1}:");
                edad = int.Parse(Console.ReadLine());

                listaPersonas.Add(new Persona(nombre, edad));
            }

            foreach (Persona persona in listaPersonas)
            {
                if (EsMayorDeEdad(persona))
                {
                    Console.WriteLine($" Nombre: {persona.Nombre}, Edad: {persona.Edad}");
                }
            }
        }

        public static bool EsMayorDeEdad(Persona persona)
        {
            if (persona.Edad >= 18)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}