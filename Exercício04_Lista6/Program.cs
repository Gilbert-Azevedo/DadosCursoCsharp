using System;

namespace Exercício04_Lista6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor;
            vetor = new int[10];
            vetor[0] = 1;
            Console.Write($"{vetor[0]} ");
            for (int i = 1; i <=9; i++)
            {
                vetor[i] = vetor[i - 1] + i;

                Console.Write($"{vetor[i]} ");

            }

            Console.ReadKey();

        }
    }
}
