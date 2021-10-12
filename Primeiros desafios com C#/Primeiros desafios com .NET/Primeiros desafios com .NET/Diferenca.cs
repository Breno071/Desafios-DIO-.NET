using System;
using System.Collections.Generic;
using System.Text;

namespace Primeiros_desafios_com_.NET
{
    class Diferenca
    {
        public static void Main(String[] args)
        {
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int C = int.Parse(Console.ReadLine());
            int D = int.Parse(Console.ReadLine());
            Console.WriteLine("DIFERENCA = " + ((A * B) - (C * D)));
            Console.ReadKey();
        }
        
    }
}
