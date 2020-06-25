using System;

namespace Lista09
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite dois números reais");
            double n1 = double.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());
                        Console.WriteLine($"o maior dentre eles é {Maior(n1,n2)}");
            Console.ReadKey();


        }
        public static double Maior(double x, double y)
        {
            if (x > y)
            {
                return x;
            }
            else
            {
                return y;
            }

        
        }


    }
}
