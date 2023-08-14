using System;

namespace ArrayValores
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[10];
            RellenarArray(numeros);
            MostrarArray(numeros);
        }

        static void RellenarArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Introduce el valor para la posición {i}:");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        static void MostrarArray(int[] array)
        {
            Console.WriteLine("\nÍndice \t Valor");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"{i} \t {array[i]}");
            }
        }
    }
}
