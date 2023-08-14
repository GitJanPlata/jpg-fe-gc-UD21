using System;
using System.Collections.Generic;

namespace NumerosConDigitoFinal
{
    class Program
    {
        static Random random = new Random();

        static void Main(string[] args)
        {
            Console.WriteLine("Introduce el tamaño del array:");
            int tamaño = Convert.ToInt32(Console.ReadLine());

            int[] numeros = new int[tamaño];
            RellenarArray(numeros);

            Console.WriteLine("Introduce el dígito final (entre 0 y 9):");
            int digito;
            while (true)
            {
                digito = Convert.ToInt32(Console.ReadLine());
                if (digito >= 0 && digito <= 9)
                    break;
                else
                    Console.WriteLine("Dígito incorrecto. Introduce un valor entre 0 y 9:");
            }

            List<int> numerosConDigitoFinal = new List<int>();
            foreach (int num in numeros)
            {
                if (num % 10 == digito)
                {
                    numerosConDigitoFinal.Add(num);
                }
            }

            Console.WriteLine($"\nNúmeros en el array original que terminan en {digito}:");
            foreach (var num in numerosConDigitoFinal)
            {
                Console.WriteLine(num);
            }
        }

        static void RellenarArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = GenerarNumeroAleatorio(1, 300);
            }
        }

        private static int GenerarNumeroAleatorio(int min, int max)
        {
            return random.Next(min, max + 1);
        }
    }
}
