using System;

namespace Exercicio02_Lista2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite quatro valores inteiros");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());
            int n4 = int.Parse(Console.ReadLine());

            double media = (n1+n2+n3+n4)/4;

            Console.WriteLine($" Média = {media}");
            Console.WriteLine("Números menores que a média");
            if (n1 < media)
            {
            Console.WriteLine(n1);
            }
            if (n2 < media)
            {
            Console.WriteLine(n2);
            }
            if (n3 < media)
            {
            Console.WriteLine(n3);
            }
            if (n4 < media)
            {
            Console.WriteLine(n4);
            }

            Console.WriteLine("Números maiores que a média");
            if (n1 >= media)
            {
                Console.WriteLine(n1);
            }
            if (n2 >= media)
            {
                Console.WriteLine(n2);
            }
            if (n3 >= media)
            {
                Console.WriteLine(n3);
            }
            if (n4 >= media)
            {
                Console.WriteLine(n4);
            }
            Console.ReadKey();
        }
    }
}
