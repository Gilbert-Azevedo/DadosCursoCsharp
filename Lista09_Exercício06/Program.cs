using System;

namespace Lista09_Exercício06
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Digite o valor da massa em Kg");
            double mass = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a distância percorrida em km");
            double dist = double.Parse(Console.ReadLine());
            Console.WriteLine($" O valor Total do frete é de {Frete(mass,dist)} Reais");
            Console.ReadKey();

        }


        public static double Frete(double massa, double distancia)
        {
            const double taxa = 0.01;
            double frete = taxa * massa * distancia;
            return frete;

        }
    }
}
