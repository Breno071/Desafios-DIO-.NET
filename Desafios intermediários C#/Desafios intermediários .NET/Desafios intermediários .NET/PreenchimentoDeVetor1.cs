using System;

class Program
{

    static void Main(string[] args)
    {

        int valorLido = int.Parse(Console.ReadLine());
        int[] n = new int[10];
        n[0] = valorLido;

        for (int i = 1; i < n.Length; i++)
        {
            n[i] = n[i - 1] * 2;

        }

        for (int c = 0; c < n.Length; c++)
        {
            Console.WriteLine($"N[{c}] = {n[c]}");
        }

    }

}