using System;

namespace ArraySuma
{
    class Program
    {
        static Random random = new Random();

        static void Main(string[] args)
        {
            Console.WriteLine("Introduce el tamaño del array:");
            int tamaño = Convert.ToInt32(Console.ReadLine());

            int[] numeros = new int[tamaño];
            RellenarArray(numeros, 0, 9);
            MostrarArray(numeros);
            Console.WriteLine($"La suma de todos los valores es: {SumaArray(numeros)}");
        }

        static void RellenarArray(int[] array, int min, int max)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = GenerarNumeroAleatorio(min, max);
            }
        }

        static void MostrarArray(int[] array)
        {
            Console.WriteLine("\nPosición \t Valor");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"{i} \t\t {array[i]}");
            }
        }

        static int SumaArray(int[] array)
        {
            int suma = 0;
            foreach (int num in array)
            {
                suma += num;
            }
            return suma;
        }

        private static int GenerarNumeroAleatorio(int min, int max)
        {
            return random.Next(min, max + 1); // Incluye ambos valores, min y max, en el rango de números generados.
        }
    }
}
