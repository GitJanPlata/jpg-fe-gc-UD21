using System;

namespace ArrayPersonalizado
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
                Console.WriteLine($"Introduce el valor para el elemento {i}:");
                numeros[i] = Convert.ToInt32(Console.ReadLine());
            }

            MostrarContenido(numeros);
        }

        static void MostrarContenido(int[] array)
        {
            Console.WriteLine("Contenido del array:");
            foreach (int num in array)
            {
                Console.WriteLine(num);
            }
        }
    }
}
