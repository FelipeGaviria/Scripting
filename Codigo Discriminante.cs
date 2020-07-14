using System;

namespace Fórmula_cuadrática
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ingresa a: ");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa b: ");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa c: ");
            double c = double.Parse(Console.ReadLine());

            double discriminante = ((b * b) - 4 * a * c);


            if (discriminante == 0)
            {
                double discrimCero = -b / (a * 2);
                Console.WriteLine("Tiene solucion única: " + discrimCero);
            }
            else if (discriminante > 0)
            {
                double formuCua = (-b + Math.Sqrt(discrim)) / (a * 2);
                double formuNeg = (-b - Math.Sqrt(discrim)) / (a * 2);
                Console.WriteLine("tiene dos soluciones. X1: " + formuCua);
                Console.WriteLine("X2: " + formuNeg);
            }
            else
            {
                Console.WriteLine("No tiene solución.");
            }
        }
    }
}