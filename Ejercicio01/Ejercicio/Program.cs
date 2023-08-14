using System;

namespace CalculaArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¿Qué figura quieres calcular? (circulo, triangulo, cuadrado)");
            string figura = Console.ReadLine().ToLower();

            switch (figura)
            {
                case "circulo":
                    Console.WriteLine("Introduce el radio:");
                    double radio = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"El área del círculo es: {AreaCirculo(radio)}");
                    break;

                case "triangulo":
                    Console.WriteLine("Introduce la base:");
                    double baseTriangulo = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Introduce la altura:");
                    double alturaTriangulo = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"El área del triángulo es: {AreaTriangulo(baseTriangulo, alturaTriangulo)}");
                    break;

                case "cuadrado":
                    Console.WriteLine("Introduce el lado:");
                    double lado = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"El área del cuadrado es: {AreaCuadrado(lado)}");
                    break;

                default:
                    Console.WriteLine("La figura introducida no es válida.");
                    break;
            }
        }

        static double AreaCirculo(double radio)
        {
            return Math.PI * Math.Pow(radio, 2);
        }

        static double AreaTriangulo(double baseTriangulo, double alturaTriangulo)
        {
            return (baseTriangulo * alturaTriangulo) / 2;
        }

        static double AreaCuadrado(double lado)
        {
            return lado * lado;
        }
    }
}

