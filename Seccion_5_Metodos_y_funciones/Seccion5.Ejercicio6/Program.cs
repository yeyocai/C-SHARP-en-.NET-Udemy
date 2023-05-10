/* 5.6 - Crea un programa que este preguntando números por consola, hasta que se pulse el numero 0. una vez pulsado el 0 
   se mostrara la siguiente información:
   Numero mas alto, numero mas bajo, la diferencia entre el mayor y el menor, cantidad de números introducidos.
   Usa métodos y funciones y el bucle While para controlar que se introduce el numero 0. */

using System;

namespace Seccion5.Ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("(Para terminar ingrese cero)");
            Console.WriteLine("Ingrese un numero");
            int numero = int.Parse(Console.ReadLine());

            int numeroMasAlto = numero;
            int numeroMasBajo = numero;
            int cantidadDeNumeros = 0;

            while (numero != 0)
            {
                if (numero > numeroMasAlto)
                {
                    numeroMasAlto = numero;
                }
                if (numero < numeroMasBajo)
                {
                    numeroMasBajo = numero;
                }

                cantidadDeNumeros++;

                Console.WriteLine("Ingrese un numero:");
                numero = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Numero mas alto: " + numeroMasAlto);
            Console.WriteLine("Numero mas bajo: " + numeroMasBajo);
            Console.WriteLine("Diferencia entre el mayor y el menor: " + (numeroMasAlto - numeroMasBajo));
            Console.WriteLine("Cantidad de numeros introducidos: " + cantidadDeNumeros);
        }
    }
}