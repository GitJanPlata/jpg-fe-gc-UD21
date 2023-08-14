using System;

namespace MultiplicacionArrays
{
    class Program
    {
        static Random random = new Random();

        static void Main(string[] args)
        {
            Console.WriteLine("Introduce el tamaño de los arrays:");
            int tamaño = Convert.ToInt32(Console.ReadLine());

            int[] array1 = new int[tamaño];
            RellenarArray(array1);

            // El array2 apunta al mismo lugar en memoria que array1.
            int[] array2 = array1;

            int[] array3 = new int[tamaño];
            RellenarArray(array3);

            int[] arrayResultado = MultiplicarArrays(array1, array3);

            Console.WriteLine("\nContenido de array1:");
            MostrarArray(array1);

            Console.WriteLine("\nContenido de array2 (apunta a array1):");
            MostrarArray(array2);

            Console.WriteLine("\nContenido de array3:");
            MostrarArray(array3);

            Console.WriteLine("\nResultado de multiplicar array1 y array3:");
            MostrarArray(arrayResultado);
        }

        static void RellenarArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = GenerarNumeroAleatorio(1, 10); // Números aleatorios entre 1 y 10
            }
        }

        static int[] MultiplicarArrays(int[] arrayA, int[] arrayB)
        {
            int[] resultado = new int[arrayA.Length];
            for (int i = 0; i < arrayA.Length; i++)
            {
                resultado[i] = arrayA[i] * arrayB[i];
            }
            return resultado;
        }

        static void MostrarArray(int[] array)
        {
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        private static int GenerarNumeroAleatorio(int min, int max)
        {
            return random.Next(min, max + 1);
        }
    }
}
