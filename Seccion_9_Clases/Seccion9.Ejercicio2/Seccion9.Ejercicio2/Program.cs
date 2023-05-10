// 9.2 - Desarrollar el ejercicio anterior, pero ahora al introducir el nombre, se especificara si es Alumno o Profesor,
// con lo que se crearan 2 clases nuevas que Heredaran ambas de "Persona". Si es Alumno, se pedirá el numero de alumno,
// si es profesor, se pedirá la materia que imparte.

using System;

namespace Seccion9.Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Persona> listaPersonas = new List<Persona>();

            listaPersonas = CargarPersonas(listaPersonas);

            MostrarPersonas(listaPersonas);
        }

        public static List<Persona> CargarPersonas(List<Persona> listaPersonas)
        {
            string nombre, tipo, materia;
            int edad, numeroAlumno;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Ingrese nombre de la persona {i + 1}:");
                nombre = Console.ReadLine();

                Console.WriteLine($"Ingrese edad de la persona {i + 1}:");
                edad = int.Parse(Console.ReadLine());

                Console.WriteLine("Indique si es alumno o profesor:");
                tipo = Console.ReadLine();

                if (tipo.ToUpper() == "ALUMNO")
                {
                    Console.WriteLine("Ingrese numero de alumno:");
                    numeroAlumno = int.Parse(Console.ReadLine());

                    listaPersonas.Add(new Alumno(nombre, edad, numeroAlumno));
                }

                if (tipo.ToUpper() == "PROFESOR")
                {
                    Console.WriteLine("Ingrese materia que imparte:");
                    materia = Console.ReadLine();

                    listaPersonas.Add(new Profesor(nombre, edad, materia));
                }
            }
            return listaPersonas;
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

        public static void MostrarPersonas(List<Persona> listaPersonas)
        {
            foreach (var persona in listaPersonas)
            {
                if (EsMayorDeEdad(persona))
                {
                    Console.WriteLine($" Nombre: {persona.Nombre}, Edad: {persona.Edad}");
                }
            }
        }
    }
}