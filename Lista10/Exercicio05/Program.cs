using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio05
{
    class Program
    {
        static void Main(string[] args)
        {
            Fracao f1 = new Fracao();
            Fracao f2 = new Fracao();
           

            Console.WriteLine("Digite o valor do numerador da fração F1");
            f1.num = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor do Denominador da fração F1");
            f1.den = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor do numerador da fração F2");
            f2.num = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor do Denominador da fração F2");
            f2.den = int.Parse(Console.ReadLine());

            Fracao f3 = Somar(f1,f2);
            Fracao f4 = Subtrair(f1, f2);
            Fracao f5 = Multiplicar(f1, f2);
            Fracao f6 = Dividir(f1, f2);

            Console.WriteLine($"A soma das frações inteiras F1 e F2 é {f3.num}/{f3.den}");
            Console.WriteLine($"A subtração das frações inteiras F1 e F2 é {f4.num}/{f4.den}");
            Console.WriteLine($"A multiplicação das frações inteiras F1 e F2 é {f5.num}/{f5.den}");
            Console.WriteLine($"A divisão das frações inteiras F1 e F2 é {f6.num}/{f6.den}");

            Console.ReadKey();
        }

        public struct Fracao
        {
            public int num;
            public int den;

        }

         public static Fracao Somar(Fracao x, Fracao y)
            {
                Fracao soma = new Fracao();
                soma.num = (x.num* y.den + y.num* x.den);
                soma.den = (x.den * y.den);

                return soma;
            }

        public static Fracao Subtrair(Fracao x, Fracao y)
        {
            Fracao subracao = new Fracao();
            subracao.num = (x.num * y.den - y.num * x.den);
            subracao.den = (x.den * y.den);

            return subracao;
        }

        public static Fracao Multiplicar(Fracao x, Fracao y)
        {
            Fracao multiplicacao = new Fracao();
            multiplicacao.num = (x.num * y.num);
            multiplicacao.den = (x.den * y.den);
            return multiplicacao;
        }


        public static Fracao Dividir(Fracao x, Fracao y)
        {
            Fracao divisao = new Fracao();
            divisao.num = (x.num*y.den);
            divisao.den = (x.den*y.num);
            return divisao;
        }



    }
}
