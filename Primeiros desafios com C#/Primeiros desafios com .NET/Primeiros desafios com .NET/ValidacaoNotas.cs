using System;

class Program
{
    static void Main(string[] args)
    {
        float[] numeros = new float[2] { -1, -1 };

        float media = 0, n = 0;

        while (true)
        {
            n = float.Parse(Console.ReadLine());
            while (n < 0 || n > 10)
            {
                Console.WriteLine("nota invalida");

                n = float.Parse(Console.ReadLine());
            }


            if (numeros[0] != -1)
            {
                numeros[1] = n;
                media = (numeros[0] + numeros[1]) / 2;
                Console.WriteLine($"media = {media.ToString("F")}");
                break;
            }
            else
            {
                numeros[0] = n;
            }
        }
        Console.ReadKey();
    }
}