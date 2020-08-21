using System;

namespace Exercicios10_Lista05
{
    class Program
    {
        static void Main(string[] args)
        {
         
                string s = "Minha terra tem palmeiras";
                string x;
                int c = 0;
                for (int k = 0; k < s.Length; k++)
                {
                    x = s.Substring(k, 1);
                    if (x == "a" || x == "e" || x == "i") c++;
                }
                Console.WriteLine(c);
                Console.ReadKey();
           
        }
    }
}
