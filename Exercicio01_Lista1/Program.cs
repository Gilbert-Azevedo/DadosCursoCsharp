using System;

namespace Lista1_Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu nome:");
            String nome = Console.ReadLine();
            Console.WriteLine($"Bem-vindo ao C#, {nome}");
            Console.ReadKey();
        }
    }
}
