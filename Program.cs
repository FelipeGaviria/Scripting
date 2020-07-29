using System;

namespace Codigos_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double total = 0;
            int i = 0, max = 0, min = 0;
            Console.Write("Ingrese El numero de datos (n):  ");
            int n = int.Parse(Console.ReadLine());

            while (i < n)
            {
                Console.Write("Edad: ");
                int edad = int.Parse(Console.ReadLine());
                    if (i == 0)
                {
                    max = edad;
                    min = edad;
                }
                if (edad > max) max = edad;
                if (edad > min) min = edad;
                total += edad;
                i++;

            }
            double promedio = total / n;
            Console.WriteLine("Promedio= " + promedio);
            Console.WriteLine("Mayor= " + max);
            Console.WriteLine("Menor= " + min);
        }
    }
}
