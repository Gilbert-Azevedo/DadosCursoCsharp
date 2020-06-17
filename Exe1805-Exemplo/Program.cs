using System;

namespace Exe1805_Exemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, n;
            long soma;
            string s = Console.ReadLine();
            string[] v = s.Split(" ");
            a = int.Parse(v[0]);
            b = int.Parse(v[1]);
            n = b - a + 1;
            soma = ((long)a + b)*n / 2;
           Console.WriteLine(soma);
           Console.ReadKey();

        }
    }
}
