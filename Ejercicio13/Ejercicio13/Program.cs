using System;

namespace ArrayAleatorio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce la longitud del array:");
            int longitud = Convert.ToInt32(Console.ReadLine());

            int[] numeros = new int[longitud];
            Random rand = new Random();

            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = rand.Next(1, 11); // Los números aleatorios generados estarán en el rango [1, 10].
            }

            MostrarArray(numeros);
        }

        static void MostrarArray(int[] array)
        {
            Console.WriteLine("Contenido del array:");
            foreach (int num in array)
            {
                Console.WriteLine(num);
            }
        }
    }
}

