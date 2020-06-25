using System;

namespace Lista_09_Exercício03
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite o valor da base do retangulo"); 
            double b1= double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor da altura do retangulo");
            double h1 = double.Parse(Console.ReadLine());
            Console.WriteLine($"A diagonal do retângulo é :{Diagonal(b1,h1):00.00} m2");
            Console.ReadKey();

        }

        public static double Diagonal(double b, double h)
        {
            double diag = Math.Sqrt(Math.Pow(b, 2)+ Math.Pow(h, 2)) ;
            return diag;
        }
    }
}
