using System;

namespace ContadorDeCifras
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;

            do
            {
                Console.WriteLine("Introduce un número entero positivo:");
                numero = Convert.ToInt32(Console.ReadLine());

                if (numero < 0)
                {
                    Console.WriteLine("El número introducido no es positivo. Inténtalo de nuevo.");
                }

            } while (numero < 0);

            Console.WriteLine($"El número {numero} tiene {NumeroDeCifras(numero)} cifras.");
        }

        static int NumeroDeCifras(int n)
        {
            int contador = 0;

            while (n > 0)
            {
                contador++;
                n /= 10;
            }

            return contador;
        }
    }
}
