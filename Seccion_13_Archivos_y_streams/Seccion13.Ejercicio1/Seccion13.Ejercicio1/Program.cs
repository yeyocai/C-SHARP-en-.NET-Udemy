/* 13.1 - Crear un programa que realice la siguiente funcionalidad:
Se pedirá por consola el nombre de una persona, su edad y su localidad, se guardara en un archivo con el siguiente formato, 
nombre|edad|localidad; uno detrás del otro "|" separa datos ";" separa registros. Cuando se inserte, se pedirá si quiere introducir más personas,
"S o N", se podrán introducir personas hasta que se pulse en "N". cuando se pulse en "N", se listaran todas las personas que están introducidas
en el archivo.
Una vez se salga del programa, si lo volvemos a ejecutar e introducimos mas personas, una vez pulsado de nuevo "N", tendrán que salir 
todas las personas , las introducidas en veces anteriores y las nuevas.
Requisitos: se tendrán que usar todos los componentes vistos hasta la fecha, clases (Clase persona), propiedades, Interfaces, métodos, funciones,
bucles, condicionales control de excepciones y archivos.
Cuidado: tienes que realizar todas las comprobaciones necesarias de validaciones.*/

using System;
using System.IO;
using System.Text;

namespace Seccion13.Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona();
            string opcion;

            FileStream fsCrearOAbrir = new FileStream("personas.txt", FileMode.OpenOrCreate);
            fsCrearOAbrir.Close();

            FileStream fsEscribir = new FileStream("personas.txt", FileMode.Append);

            do
            {
                CargarPersona(persona);

                EscribirArchivo(fsEscribir, persona);

                Console.WriteLine("Quiere introducir más personas? (S o N):");
                opcion = Console.ReadLine();

            } while (opcion.ToUpper() == "S");

            fsEscribir.Close();

            FileStream fsLeer = new FileStream("personas.txt", FileMode.Open);
            byte[] infoArchivo = new byte[500000];

            Console.WriteLine("Personas en el archivo:");
            MostrarArchivo(fsLeer, infoArchivo);
            fsLeer.Close();
        }

        public static void CargarPersona(Persona persona)
        {
            Console.WriteLine("Ingrese nombre de la persona:");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese edad:");
            int edad = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese localidad:");
            string localidad = Console.ReadLine();

            persona.Nombre = nombre;
            persona.Edad = edad;
            persona.Localidad = localidad;
        }

        public static void EscribirArchivo(FileStream fsEscribir, Persona persona)
        {
            string registro = $"{persona.Nombre}|{persona.Edad}|{persona.Localidad};";

            fsEscribir.Write(ASCIIEncoding.ASCII.GetBytes(registro), 0, registro.Length);
        }

        public static void MostrarArchivo(FileStream fsLeer, byte[] infoArchivo)
        {
            fsLeer.Read(infoArchivo, 0, (int)fsLeer.Length);
            string archivo = ASCIIEncoding.ASCII.GetString(infoArchivo);

            var registros = archivo.Split(';').ToList();
            registros.RemoveAt(registros.Count - 1);

            foreach (string registro in registros)
            {
                Persona persona = ExtraerPersona(registro);
                Console.WriteLine($"Nombre: {persona.Nombre}, Edad: {persona.Edad}, Localidad: {persona.Localidad}");
            }
        }

        public static Persona ExtraerPersona(string registro)
        {
            Persona persona = new Persona();
            var campo = registro.Split('|');

            persona.Nombre = campo[0];
            persona.Edad = int.Parse(campo[1].ToString());
            persona.Localidad = campo[2];

            return persona;
        }
    }
}