using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entrada de Dados do Cliente");
            Console.WriteLine("  ");

            Console.WriteLine("Informe o nome do cliente");
            string nm = Console.ReadLine();
            Console.WriteLine("Informe a data da compra");
            DateTime dataCompra = new DateTime();
            dataCompra= DateTime.Parse(Console.ReadLine());

            DateTime dValidade = new DateTime();
            dValidade = dataCompra.AddMonths(2);

            Console.WriteLine("Informe a Descrição do Produto");
            string descricaoProduto = Console.ReadLine();

            Console.WriteLine("Informe o Valor do Produto");
            decimal valorproduto = decimal.Parse(Console.ReadLine());

            decimal valorPremio = valorproduto;

            int opcao = 0;

            while ((opcao != 1)&&(opcao != 2))
            {
                Console.WriteLine("Digite a Opção de premiação:  1: trocar por ValeCompras  -  2: Receber em Produtos ");

                Premio premioescolhido = new Premio(nm, dataCompra);
                opcao = int.Parse(Console.ReadLine());



                switch (opcao)
                {
                    case 1:
                        premioescolhido.SetPremio("Vale Compras");
                        ValeCompras vcompras = new ValeCompras(dValidade, valorPremio);
                        Console.WriteLine(premioescolhido.ToString());
                        Console.WriteLine(vcompras.ToString());
                        break;
                    case 2:
                        premioescolhido.SetPremio("Troca por Produtos");
                        Produto prod = new Produto(descricaoProduto, valorPremio);
                        Console.WriteLine(premioescolhido.ToString());
                        Console.WriteLine(prod.ToString());
                        break;
                    default:
                        Console.WriteLine("opção inválida");
                        break;

                }

            }



                   

            Console.ReadKey();
        }
    }
}
