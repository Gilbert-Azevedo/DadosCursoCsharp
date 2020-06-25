using System;

namespace Lista09_Exercicio08
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Digite um numero Real");
            double num = double.Parse(Console.ReadLine());
            Console.WriteLine($" O menor inteiro é: {MenorInteiro(num)}");
            Console.ReadKey();

        }


        public static int MenorInteiro(double x)
        {

            int xint;
            if (x > (int)Math.Round(x))
            {
               xint = (int)Math.Round(x) + 1;
            }
            else
               xint = (int)Math.Round(x);

            return xint;
         }
    }
}
