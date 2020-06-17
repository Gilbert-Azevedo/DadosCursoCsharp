using System;

namespace Lista1_Exercício02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite as notas dos dois bimestres da disciplina:");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int media = (2 * n1 + 3 * n2) / 5;
            Console.WriteLine($"Media Parcial = {media}");
            Console.ReadKey();


        }
    }
}
