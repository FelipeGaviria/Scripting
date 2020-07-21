using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("número de votos por el partido 1: ");
        int a = int.Parse(Console.ReadLine());

        Console.WriteLine("número de votos por el partido 2: ");
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine("número de votos en blanco: ");
        int blancos = int.Parse(Console.ReadLine());

        Console.WriteLine("número de votos anulados: ");
        int anulados = int.Parse(Console.ReadLine());

        Console.WriteLine("número total de la población de todas las edades: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("el porcentaje (de 0 a 100%) de la población que es mayor de edad: ");
        double p = int.Parse(Console.ReadLine());


        int NumVot = (a + b + blancos + anulados);

        int abs = (int)((n * (p / 100)) - NumVot);

        if ((anulados < ((30.0 / 100) * (a + b))) || ((((a + b) > blancos)) && (abs < NumVot)))
        {
            Console.WriteLine("las votaciones fueron exitosas");
            if (a > b)
            {
                Console.WriteLine("Ganador es A");
            }
            else
            {
                Console.WriteLine("Ganador es B");
            }
        }
        else
        {
            Console.WriteLine("las votaciones deben repetirse");
        }
    }
}