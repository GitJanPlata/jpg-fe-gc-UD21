using System;

namespace CalculadorFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce un número para calcular su factorial:");
            int numero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"El factorial de {numero} es: {Factorial(numero)}");
        }

        static long Factorial(int n)
        {
            if (n <= 1) return 1; // El factorial de 0 y 1 es 1
            return n * Factorial(n - 1);
        }
    }
}
