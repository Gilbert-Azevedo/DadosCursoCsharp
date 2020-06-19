using System;

namespace Exercicio12_Lista2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite dois valores inteiros positivos separados por um operador +, -, * ou /");
            string operanum = Console.ReadLine();
             if (operanum.Contains('+'))
                    {
                    string[] dados = operanum.Split('+');
                    int d1 = int.Parse(dados[0]);
                    int d2 = int.Parse(dados[1]);
                Console.WriteLine($" O resultado da operação é {d1+d2}");

                   }
             if (operanum.Contains('-'))
            {
                string[] dados = operanum.Split('-');
                int d1 = int.Parse(dados[0]);
                int d2 = int.Parse(dados[1]);
                Console.WriteLine($" O resultado da operação é {d1 - d2}");
            }

            if (operanum.Contains('*'))
            {
                string[] dados = operanum.Split('*');
                int d1 = int.Parse(dados[0]);
                int d2 = int.Parse(dados[1]);
                Console.WriteLine($" O resultado da operação é {d1*d2}");
            }

            if (operanum.Contains('/'))
            {
                string[] dados = operanum.Split('/');
                int d1 = int.Parse(dados[0]);
                int d2 = int.Parse(dados[1]);
                Console.WriteLine($" O resultado da operação é {d1/d2}");
            }


            Console.ReadKey();

        }
    }
}
