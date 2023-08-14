using System;

namespace ConvertidorDeMoneda
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce una cantidad de euros:");
            double euros = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("¿A qué moneda quieres convertir? (libras, dolares, yenes)");
            string moneda = Console.ReadLine().ToLower();

            ConvertirYMostrar(euros, moneda);
        }

        static void ConvertirYMostrar(double euros, string moneda)
        {
            switch (moneda)
            {
                case "libras":
                    Console.WriteLine($"{euros} euros son {euros * 0.86} libras.");
                    break;

                case "dolares":
                    Console.WriteLine($"{euros} euros son {euros * 1.28611} dólares.");
                    break;

                case "yenes":
                    Console.WriteLine($"{euros} euros son {euros * 129.852} yenes.");
                    break;

                default:
                    Console.WriteLine("La moneda introducida no es válida.");
                    break;
            }
        }
    }
}
