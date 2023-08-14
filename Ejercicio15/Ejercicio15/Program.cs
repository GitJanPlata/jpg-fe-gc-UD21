using System;

namespace InvertirArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce la longitud del array:");
            int longitud = Convert.ToInt32(Console.ReadLine());

            int[] numeros = new int[longitud];
            for (int i = 0; i < longitud; i++)
            {
                Console.WriteLine($"Introduce el valor para la posición {i}:");
                numeros[i] = Convert.ToInt32(Console.ReadLine());
            }

            int[] invertido = Invertir(numeros);

            Console.WriteLine("\nArray original:");
            MostrarArray(numeros);

            Console.WriteLine("\nArray invertido:");
            MostrarArray(invertido);
        }

        static int[] Invertir(int[] array)
        {
            int[] invertido = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                invertido[i] = array[array.Length - 1 - i];
            }
            return invertido;
        }

        static void MostrarArray(int[] array)
        {
            foreach (int num in array)
            {
                Console.WriteLine(num);
            }
        }
    }
}

