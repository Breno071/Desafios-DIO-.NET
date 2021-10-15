using System;

class Program
{

    static void Main(string[] args)
    {

        ulong resultado = 0;
        int qtdTeste = int.Parse(Console.ReadLine());
        for (int i = 0; i < qtdTeste; i++)
        {
            ulong casas = ulong.Parse(Console.ReadLine());

            if (casas > 1)
            {
                ulong[] tabuleiro = new ulong[casas];
                tabuleiro[0] = 1;
                resultado += tabuleiro[0];
                for (int c = 1; c < tabuleiro.Length; c++)
                {

                    tabuleiro[c] = tabuleiro[c - 1] * 2;
                    resultado += tabuleiro[c];
                }
                resultado = resultado / 12000;
                Console.WriteLine($"{resultado} kg");
                resultado = 0;
            }
            else
            {
                Console.WriteLine("0 kg");
            }
        }

    }
}