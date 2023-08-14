using System;

namespace SumaArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[10];
            int suma = 0;

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine($"Introduce el valor para la posición {i}:");
                numeros[i] = Convert.ToInt32(Console.ReadLine());
                suma += numeros[i];
            }

            Console.WriteLine($"La suma total es: {suma}");
        }
    }
}
