using System;

namespace ArrayAleatorioYBusqueda
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

            Console.WriteLine("\nIntroduce un número para verificar si existe en el array:");
            int numeroBuscado = Convert.ToInt32(Console.ReadLine());

            if (ExisteEnArray(numeros, numeroBuscado))
            {
                Console.WriteLine($"El número {numeroBuscado} sí existe en el array.");
            }
            else
            {
                Console.WriteLine($"El número {numeroBuscado} no existe en el array.");
            }
        }

        static void MostrarArray(int[] array)
        {
            Console.WriteLine("Contenido del array:");
            foreach (int num in array)
            {
                Console.WriteLine(num);
            }
        }

        static bool ExisteEnArray(int[] array, int numero)
        {
            foreach (int num in array)
            {
                if (num == numero)
                {
                    return true;
                }
            }
            return false;
        }
    }
}

