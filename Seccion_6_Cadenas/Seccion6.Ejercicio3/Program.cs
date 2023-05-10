/* 3 - Crea un programa que pida una frase de al menos 20 caracteres y al menos 4 palabras por consola y se muestre 
la siguiente información de esa cadena (usa funciones para cada caso), se deberá validar que la cadena tiene al menos 
20 caracteres y la frase consta al menos de 4 palabras.

*longitud de la cadena

*pinta la cadena, remplazando la letra "a" por "x", la "A" podrá ser mayúscula o minúscula en cuyo caso si es "a" 
*se cambiara por una "x" y si es "A" se cambiara por una "X"

*pinta la cadena en mayúsculas

*pinta la cadena en minúsculas

*pinta la cadena, removiendo las 3 primeras letras

*pinta la cadena, extrayendo las letras en las posiciones de la 5 a la 10

*invierte la cadena

*escribe el numero de palabras que tiene la frase

*escribe únicamente la tercera palabra */


using System;

namespace Seccion6.Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese una frase de al menos 20 caracteres y al menos 4 palabras:");
            var frase = Console.ReadLine();

            if (CumpleValidacion(frase))
            {
                Console.WriteLine("La frase tiene " + frase.Length + " caracteres");

                Console.WriteLine(frase.Replace("a", "x").Replace("A", "X"));

                Console.WriteLine(frase.ToUpper());

                Console.WriteLine(frase.ToLower());

                Console.WriteLine(frase.Remove(0, 3));  

                Console.WriteLine(frase.Substring(4, 6));

                Console.WriteLine(InvertirFrase(frase));

                Console.WriteLine("La frase tiene " + frase.Split(' ').Length + " palabras");

                Console.WriteLine("La tercera palabra es: " + frase.Split(' ')[2]);
            }
            else
            {
                Console.WriteLine("No se ingresó lo solicitado");
            }
        }


        public static bool CumpleValidacion(string frase)
        {
            if (frase.Length >= 20 && frase.Split(' ').Length >= 4)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public static string InvertirFrase(string frase)
        {
            var fraseAlRevesArray = frase.Reverse(); 

            string fraseAlReves = "";

            foreach (var item in fraseAlRevesArray)
            {
                fraseAlReves = fraseAlReves + item; 
            }

            return fraseAlReves;
        }

    }
}
