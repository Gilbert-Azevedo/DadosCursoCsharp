using System;

namespace ExercicioURI1020
{
    class Program
    {
        static void Main(string[] args)
        {
           int dias=int.Parse(Console.ReadLine());
            int anos = dias / 365;
            dias = dias % 365;
            int meses = dias/30;
            dias = dias % 30;
            Console.WriteLine($"{anos} ano (s)");
            Console.WriteLine($"{meses} mes (es)");
            Console.WriteLine($"{dias} dia (s)");

            Console.ReadKey();
        }
    }
}
