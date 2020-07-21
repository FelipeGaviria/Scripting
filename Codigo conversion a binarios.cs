using System;

namespace Conversión_binario_a_decimal
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ingresamos 5 valores en 1s o 0s

            Console.WriteLine("Digite el primer dígito: ");
            int v0 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite el segundo dígito: ");
            int v1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite el tercer dígito: ");
            int v2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite el cuarto dígito: ");
            int v3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite el quinto dígito: ");
            int v4 = int.Parse(Console.ReadLine());

            //conversión de binario a decimal

            int d0 = (v0 * 16);
            int d1 = (v1 * 8);
            int d2 = (v2 * 4);
            int d3 = (v3 * 2);
            int d4 = (v4 * 1);

            int sumdec = (d0 + d1 + d2 + d3 + d4);
            Console.WriteLine("El resultado en decimal es: " + sumdec);
        }
    }
}
