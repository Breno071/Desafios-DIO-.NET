using System;

class Classe
{
    static void Main()
    {
        string[] line = Console.ReadLine().Split(" ");

        double media = (double.Parse(line[0]) / double.Parse(line[1]));
        Console.WriteLine(media.ToString("F"));

    }
}