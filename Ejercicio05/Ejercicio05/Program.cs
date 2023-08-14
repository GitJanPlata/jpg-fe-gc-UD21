using System;
using System.Text;

namespace DecimalABinario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce un número en base decimal para convertir a binario:");
            int numero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"El número {numero} en binario es: {DecimalABinario(numero)}");
        }

        static string DecimalABinario(int n)
        {
            if (n == 0) return "0"; // Si el número es 0, simplemente devolvemos "0"

            StringBuilder binario = new StringBuilder();

            while (n > 0)
            {
                binario.Insert(0, n % 2); // Tomamos el resto de la división y lo agregamos al inicio del string
                n = n / 2;
            }

            return binario.ToString();
        }
    }
}
