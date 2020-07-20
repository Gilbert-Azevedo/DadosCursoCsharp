using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int i= 0, maxitens=0;
            object item; 
            
            Console.WriteLine("Criação da lista");
            Console.WriteLine("Informe o número máximo de itens da coleção");
            maxitens = int.Parse(Console.ReadLine());
            Colecao itemcolec = new Colecao(maxitens);
            
            int opcao = 1;

            while(opcao!=4)
            { 
            Console.WriteLine(" Escolha a opção desejada: 1 - Inserir item ; 2 - Listar itens inseridos ; 3 - Mostrar o número de itens; 4 - Finalizar a lista");

            opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        if (i < maxitens)
                        {
                            Console.WriteLine($" Digite o item desejado");
                             item = Console.ReadLine();
                             itemcolec.Inserir(item);
                            i++;
                         }
                        else
                        {
                            Console.WriteLine(" O número máximo de itens foi atingido");
                        }

                        break;
                    case 2:

                        Console.WriteLine("lista de elementos");
                        object[] listafinal = new object[itemcolec.NumItens()];
                        listafinal = itemcolec.Listar();
                        for (int j=0; j< itemcolec.NumItens();j++)
                        {
                             Console.WriteLine(listafinal[j]);
                        }

                        break;
                    case 3:
                        Console.WriteLine($"A coleção tem { itemcolec.NumItens()} elemento(s)");

                        break;
                    case 4:
                        Console.WriteLine(" Lista finalizada");
                        break;

                    default:
                        Console.WriteLine("Opção Invalida");

                        break;
                }

            }
                     

            Console.ReadKey();

        }
    }
}
