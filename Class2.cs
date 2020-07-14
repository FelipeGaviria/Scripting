using System;

public class Class1
{
	public Class1()
	{
		Console.write ("Inserte estatura(m): ");

		double estatura = double.Parse(Console.ReadLine());

		Console.write("Inserte peso (kg): ");

		double peso = double.Parse(Console.ReadLine());

		double Indice = (peso / (estatura*estatura));

		if(Indice < 18.5){
			Console.writeLine("Bajo peso");
		}
		else if(18.5 < Indice && Indice < 24.9 ){
			Console.writeLine("Normal");
		}
		else if (25 < Indice && Indice < 29.9)
		{
			Console.writeLine("Sobrepeso");
		}
		if (Indice < 30)
		{
			Console.writeLine("Sobrepeso");
		}
	}
}
