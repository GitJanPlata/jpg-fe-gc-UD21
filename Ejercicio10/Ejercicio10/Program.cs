using System;

namespace TablaDeMultiplicar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce un número para ver su tabla de multiplicar:");
            int numero = Convert.ToInt32(Console.ReadLine());

            MostrarTabla(numero);
        }

        static void MostrarTabla(int numero)
        {
            Console.WriteLine($"Tabla de multiplicar del {numero}:");

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"{numero} * {i} = {numero * i}");
            }
        }
    }
}
