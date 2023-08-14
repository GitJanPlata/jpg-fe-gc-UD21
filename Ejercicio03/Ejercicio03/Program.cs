using System;

namespace DetectorDeNumerosPrimos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce un número:");
            int numero = Convert.ToInt32(Console.ReadLine());

            if (EsPrimo(numero))
            {
                Console.WriteLine($"{numero} es un número primo.");
            }
            else
            {
                Console.WriteLine($"{numero} no es un número primo.");
            }
        }

        static bool EsPrimo(int n)
        {
            if (n <= 1) return false; // 0 y 1 no son primos
            if (n == 2) return true; // 2 es el único número primo par
            if (n % 2 == 0) return false; // Descarta todos los números pares mayores que 2

            int raizCuadrada = (int)Math.Sqrt(n);
            for (int i = 3; i <= raizCuadrada; i += 2)
            {
                if (n % i == 0)
                {
                    return false; // n tiene un divisor distinto de 1 y de sí mismo
                }
            }

            return true; // n es primo
        }
    }
}