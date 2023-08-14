using System;

namespace GeneradorNumerosAleatorios
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¿Cuántos números aleatorios deseas generar?");
            int cantidad = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduce el valor mínimo:");
            int minimo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduce el valor máximo:");
            int maximo = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine(GenerarNumeroAleatorio(minimo, maximo));
            }
        }

        static int GenerarNumeroAleatorio(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max + 1); //El límite superior en Next() es exclusivo, por eso sumamos 1.
        }
    }
}

