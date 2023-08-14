using System;

namespace ArrayDePrimos
{
    class Program
    {
        static Random random = new Random();

        static void Main(string[] args)
        {
            Console.WriteLine("Introduce el tamaño del array:");
            int tamaño = Convert.ToInt32(Console.ReadLine());

            int[] numerosPrimos = new int[tamaño];

            // Supondré que los números aleatorios primos están entre 2 y 100 para simplificar. Puedes ajustar estos valores.
            RellenarArrayConPrimos(numerosPrimos, 2, 100);
            Console.WriteLine($"El mayor número primo en el array es: {MayorNumero(numerosPrimos)}");
        }

        static void RellenarArrayConPrimos(int[] array, int min, int max)
        {
            int i = 0;
            while (i < array.Length)
            {
                int numAleatorio = GenerarNumeroAleatorio(min, max);
                if (EsPrimo(numAleatorio))
                {
                    array[i] = numAleatorio;
                    i++;
                }
            }
        }

        static int MayorNumero(int[] array)
        {
            int mayor = array[0];
            foreach (int num in array)
            {
                if (num > mayor)
                {
                    mayor = num;
                }
            }
            return mayor;
        }

        private static int GenerarNumeroAleatorio(int min, int max)
        {
            return random.Next(min, max + 1);
        }

        private static bool EsPrimo(int numero)
        {
            if (numero < 2) return false;
            for (int i = 2; i <= Math.Sqrt(numero); i++)
            {
                if (numero % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
