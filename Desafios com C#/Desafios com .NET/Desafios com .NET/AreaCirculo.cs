using System;

class Classe
{

    static void Main(string[] args)
    {

        double pi = 3.14159;
        double area = 0;
        double raio = double.Parse(Console.ReadLine());

        area = pi * Math.Pow(raio, 2);
        Console.WriteLine($"A={area.ToString("N4").Replace(",", "")}");

    }


}