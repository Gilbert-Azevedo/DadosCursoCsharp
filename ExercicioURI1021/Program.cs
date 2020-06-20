using System;

namespace ExercicioURI1021
{
    class Program
    {
        static void Main(string[] args)
        {
            string novovalor = Console.ReadLine();

            string[] nvalor = novovalor.Split('.');
            double parteint = double.Parse(nvalor[0]);
            double partefrac = double.Parse(nvalor[1]);
                 
             double n100 = Math.Floor(parteint/100.00);
             parteint = parteint%100.00;
             double n50 = Math.Floor(parteint /50.00);
             parteint = parteint% 50.00;
             double n20 = Math.Floor(parteint /20.00);
             parteint = parteint%20.00;
             double n10 = Math.Floor(parteint /10.00);
             parteint = parteint%10.00;
             double n5 = Math.Floor(parteint /5.00);
             parteint = parteint % 5.00;
             double n2 = Math.Floor(parteint /2.00);
             parteint =parteint % 2.00;
             double m1 = Math.Floor(parteint);
               
             partefrac = partefrac/100.00;
                             
             double m05 = Math.Floor(partefrac /.5);
             partefrac = partefrac % .5;
             double m025 = Math.Floor(partefrac /.25);
             partefrac = partefrac % .25;
             double m01 = Math.Floor(partefrac / .1);
             partefrac = partefrac % .1;
             double m005 = Math.Floor(partefrac / .05);
             partefrac = partefrac % .05;
             double m001 = Math.Floor(partefrac / .01);
               
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
