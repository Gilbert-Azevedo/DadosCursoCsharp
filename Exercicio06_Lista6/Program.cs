using System;

namespace Exercicio06_Lista6
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, cont=3;
            int[] vetor;
            
            vetor = new int[30];
            vetor[0] = 1;
            vetor[1] = 2;
            vetor[2] = 3;
          //  Console.Write($"{vetor[0]} ");
           // Console.Write($"{vetor[1]} ");
           // Console.Write($"{vetor[2]} ");
            
            for (i = 3; i < 29; i++)
            {
                if (cont == 3)
                {
                    vetor[i] = vetor[i - 1] + vetor[i - 2] + vetor[i - 3];
                    cont = 0;
                    
                }
                else
                { 
                vetor[i] = i;
                cont++;
                }
               
                Console.Write($"{vetor[i]} ");
            }
                          
             
            Console.ReadKey();
        }
    }

}
