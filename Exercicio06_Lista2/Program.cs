using System;

namespace Exercicio06_Lista2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite 3 valores inteiros");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int menor = a;
            int maior = b;
            if (b < menor)
            {
               menor = b;
            }
            if (c < menor)
            {
                menor = c;
            }
            if (a > maior)
            {
              maior = a;

            }
            if (c > maior)
            {
                maior = c;
            }

            Console.WriteLine($"A soma do maior com o menor número é {maior+menor}");
            Console.ReadKey();

        }
    }
}
