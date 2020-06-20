using System;

namespace ExercicioURI1021
{
    class Program
    {
        static void Main(string[] args)
        {
            string novovalor = Console.ReadLine();

            string[] nvalor = novovalor.Split('.');
            int parteint = int.Parse(nvalor[0]);
            int partefrac = int.Parse(nvalor[1]);
                 
             int n100 = parteint/100;
             parteint = parteint%100;
             int n50 = parteint/50;
             parteint = parteint% 50;
            int n20 = parteint/20;
             parteint = parteint%20;
            int n10 = parteint/10;
             parteint = parteint%10;
            int n5 = parteint/5;
             parteint = parteint%5;
            int n2 = parteint/2;
             parteint =parteint%2;
            int m1 = parteint;
               
                               
             int m05 = partefrac /50;
             partefrac = partefrac % 50;
            int m025 = partefrac /25;
             partefrac = partefrac %25;
            int m01 = partefrac / 10;
             partefrac = partefrac % 10;
            int m005 = partefrac / 5;
             partefrac = partefrac % 5;
            int m001 = partefrac;
               
               Console.WriteLine("NOTAS:");
               Console.WriteLine($"{n100} nota(s) de R$ 100.00");
               Console.WriteLine($"{n50} nota(s) de R$ 50.00");
               Console.WriteLine($"{n20} nota(s) de R$ 20.00");
               Console.WriteLine($"{n10} nota(s) de R$ 10.00");
               Console.WriteLine($"{n5} nota(s) de R$ 5.00");
               Console.WriteLine($"{n2} nota(s) de R$ 2.00"); 
               Console.WriteLine("MOEDAS:");
               Console.WriteLine($"{m1} moedas(s) de R$ 1.00");
               Console.WriteLine($"{m05} moedas(s) de R$ 0.50");
               Console.WriteLine($"{m025} moedas(s) de R$ 0.25");
               Console.WriteLine($"{m01} moedas(s) de R$ 0.10");
               Console.WriteLine($"{m005} moedas(s) de R$ 0.05");
               Console.WriteLine($"{m001} moedas(s) de R$ 0.01"); 
               Console.ReadKey();

        }
    }
}
