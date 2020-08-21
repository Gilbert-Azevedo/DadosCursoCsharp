using System;

namespace Exercício08_lista2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite 4 valores inteiros");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            if((a==b)||(a == c)||(a == d)||(b==c)||(b==d)||(c == d))
              {
                Console.WriteLine("Números inválidos");
              }            
             else
             {

                int menor = a;
                int segmenor = b;
                int segmaior = c;
                int maior = d;

                if (b < menor)
                {
                    menor = b;
                    segmenor = a;
                }
                else
                {
                    if (b > segmaior)
                    {
                        segmaior = b;
                        segmenor = c;
                    }
                    else
                    {
                        if (b > maior)
                        {
                            maior = b;
                            segmaior = d;
                        }
                    }
                }



                    if (c < menor)
                    {
                        menor = c;
                        segmenor = a;
                    }
                    else
                    {
                        if (c > maior)
                        {
                          maior = c;
                          segmaior = d;
                         
                        }


                   }



                Console.WriteLine($"A soma do segundo maior número com o segundo menor número é {segmaior + segmenor}");
            }
                
                Console.ReadKey();
        }
    }
}
