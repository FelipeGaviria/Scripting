using System;

public class Program
{
	public static void Main()
	{

		Console.Write("Inserte estatura(m): ");

		double estatura = double.Parse(Console.ReadLine());

		Console.Write("Inserte peso (kg): ");

		double peso = double.Parse(Console.ReadLine());

		double Indice = (peso / (estatura * estatura));

		if (Indice < 18.5)
		{
			Console.WriteLine("Bajo peso");
		}
		else if (18.5 < Indice && Indice < 24.9)
		{
			Console.WriteLine("Normal");
		}
		else if (25 < Indice && Indice < 29.9)
		{
			Console.WriteLine("Sobrepeso");
		}
		if (Indice < 30)
		{
			Console.WriteLine("Sobrepeso");
		}

	}
}