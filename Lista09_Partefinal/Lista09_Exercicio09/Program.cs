using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista09_Exercicio09
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o 1° valor inteiro");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o 2° valor inteiro");
            int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"A soma dos inteiros dentro do intervalo entre os números é: {Soma(n1,n2)}");
            Console.ReadKey();         

        }
    public static int Soma(int x, int y)

        {
            int soma = 0, i = 0;

            i = x;

            while (i <=y)
            { 
            soma = soma + i;
                i++;
             }

            return soma;
        
        }

    }
 }
