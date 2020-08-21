using System;

namespace Exercício04_Lista2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite o primeiro horário no formato hh:mm");
            string hora1 = (Console.ReadLine());
            string[] h1 = hora1.Split(":");
            int hh1 = int.Parse(h1[0]);
            int mh1 = int.Parse(h1[1]);
            //Console.WriteLine(hh1);
            //Console.WriteLine(mh1);

            Console.WriteLine("Digite o segundo horário no formato hh:mm");
            string hora2 = (Console.ReadLine());
            string[] h2 = hora2.Split(":");
            int hh2 = int.Parse(h2[0]);
            int mh2 = int.Parse(h2[1]);
                      
            int somamin = mh1 + mh2;
            int somahora = hh1 + hh2;
            if (somamin >=60)
            {
                somamin -=60;
                somahora += 1; 
            }
            Console.WriteLine($"Total de Horas = {somahora:00}:{somamin:00}");
            Console.ReadKey();
        }
    }
}
