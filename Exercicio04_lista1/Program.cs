using System;

namespace Lista1_Exercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a nota dos 3 primeiros bimestres:");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());
            int n4 = (600 - (n1 * 2 + n2 * 2 + n3 * 3)) / 3;
            Console.WriteLine($"Nota para passar: {n4}");
            Console.ReadKey();
        }
    }
}
