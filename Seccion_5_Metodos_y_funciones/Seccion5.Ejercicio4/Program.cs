// 5.4 - Crear un programa que lea una letra tecleada por el usuario y diga si se trata de una vocal,
// una cifra numérica o una consonante (realizar obligatoriamente 3 funciones, "EsNumero", "EsVocal", "EsConsonante").

using System;
using System.Runtime.ConstrainedExecution;

namespace Seccion5.Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese una letra:");
            char letra = char.Parse(Console.ReadLine());

            if (EsNumero(letra))
            {
                Console.WriteLine("Es un numero");
            }

            if (EsVocal(letra))
            {
                Console.WriteLine("Es una vocal");
            }

            if (EsConsonante(letra))
            {
                Console.WriteLine("Es una consonante");
            }

            Console.ReadKey();
        }

        public static bool EsNumero(char letra)
        {
            if (letra >= 48 && letra <= 57)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool EsVocal(char letra)
        {
            if (letra == 'a' || letra == 'e' || letra == 'i' || letra == 'o' || letra == 'u' || letra == 'A' || letra == 'E'
                || letra == 'I' || letra == 'O' || letra == 'U')
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool EsConsonante(char letra)
        {
            if (((letra >= 65 && letra <= 90) || (letra >= 97 && letra <= 122)) && !EsVocal(letra))
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