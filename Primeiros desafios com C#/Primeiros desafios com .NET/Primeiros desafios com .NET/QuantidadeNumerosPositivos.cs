using System;

public class Program
{
	public static void Main(string[] args)
	{
		int quantidadePositivos = 0;
		for (int i = 0; i < 6; i++)
		{
			double valorInformadoPeloUsuario = double.Parse(Console.ReadLine());
			if (valorInformadoPeloUsuario > 0)
			{
				quantidadePositivos++;
			}
		}
		Console.WriteLine(quantidadePositivos + " valores positivos");
	}
}