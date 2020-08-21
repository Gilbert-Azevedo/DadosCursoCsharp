using System;

namespace Lista09_Exercicio07
{
    class Program
    {
        static void Main(string[] args)
        {
            int ant;
            int suces;
            Console.WriteLine("Digite um numero inteiro");
            int n = int.Parse(Console.ReadLine());
             AntecessorSucessor(n, out ant, out suces);
            Console.WriteLine($" seu antecessor é: {ant}  e o seu sucessor é: {suces}");
            Console.ReadKey();

        }


        public static void AntecessorSucessor(int x, out int antecessor,out int sucessor)
        {
            antecessor = x-1;
            sucessor = x+1;
        }
    }
}
