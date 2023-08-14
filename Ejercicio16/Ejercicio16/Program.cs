using System;

namespace ArrayCapicua
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

            if (EsCapicua(numeros))
            {
                Console.WriteLine("El array es capicúa.");
            }
            else
            {
                Console.WriteLine("El array no es capicúa.");
            }
        }

        static bool EsCapicua(int[] array)
        {
            for (int i = 0; i < array.Length / 2; i++)
            {
                if (array[i] != array[array.Length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
