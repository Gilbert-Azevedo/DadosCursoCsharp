using System;

namespace Exercicio03_Lista2
{
    class Program
    {
        static void Main(string[] args)
        {
            int somapar = 0,somaimpar=0;
            Console.WriteLine("Digite quatro valores inteiros");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());
            int n4 = int.Parse(Console.ReadLine());

            if (n1 % 2 == 0)
            {
                somapar += n1;
            }
            else
            {
                somaimpar += n1;
            }
            if (n2 % 2 == 0)
            {
                somapar += n2;
            }
            else
            {
                somaimpar += n2;
            }
            if (n3 % 2 == 0)
            {
                somapar += n3;
            }
            else
            {
                somaimpar += n3;
            }
            if (n4 % 2 == 0)
            {
                somapar += n4;
            }
            else
            {
                somaimpar += n4;
            }

            Console.WriteLine($"Soma dos números pares = {somapar}");
            Console.WriteLine($"Soma dos números impares = {somaimpar}");
            Console.ReadKey();
        }
    }
}
