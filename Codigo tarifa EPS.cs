using System;

public class Tarifa
{
	public static void Main()
	{

		Console.Write("Inserte Salario: ");

		double Sal = double.Parse(Console.ReadLine());

		int smmlv = 877803;

		double twoSals = (2 * smmlv);
		double fiveSals = (5 * smmlv);

		if (Sal < (twoSals))
		{
			Console.WriteLine("Valor de la Cuota Moderadora: $3.400");
			Console.WriteLine("Tarifa: $21.200");
		}
		else if (twoSals < Sal && Sal < fiveSals)
		{
			Console.WriteLine("Valor de la Cuota Moderadora:$13.500");
			Console.WriteLine("Tarifa: $27.600");
		}
		if (fiveSals < Sal)
		{
			Console.WriteLine("Valor de la Cuota Moderadora:$35.600");
			Console.WriteLine("Tarifa: $37.100");
		}
	}
}
