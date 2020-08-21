using System;

namespace Exercicio01_lista2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite dois valores inteiros");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            if (n1 > n2)
            {
                Console.WriteLine($"Maior= {n1}");
            }
            else
            {
                Console.WriteLine($"Maior= {n2}");
            }
            Console.ReadKey();

        }
    }
}
