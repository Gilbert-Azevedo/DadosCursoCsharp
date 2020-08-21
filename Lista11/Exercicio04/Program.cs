using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
            int operac=1;
            Conta Contacliente = new Conta();
            Console.WriteLine("informe o nome do cliente da conta");
            Contacliente.nome = Console.ReadLine();
            
            Console.WriteLine("informe o número da conta");
            Contacliente.numero  = Console.ReadLine();

            while (operac!=0)
            {
                Console.WriteLine("Digite o número referente à operação desejada:");
                Console.WriteLine("1 - Mostrar Saldo");
                Console.WriteLine("2 - Depositar");
                Console.WriteLine("3 - Sacar");
                Console.WriteLine("0 - Sair");
                Console.WriteLine(" ");
                Console.WriteLine(" ");


                operac = int.Parse(Console.ReadLine());

                switch (operac)
                {
                    case 1:
                        Console.WriteLine($"Saldo da conta {Contacliente.numero}: {Contacliente.saldo:0.00} ");
                        break;

                    case 2:
                        Console.WriteLine("informe o valor a ser depositado em Reais");
                        Contacliente.depos = decimal.Parse(Console.ReadLine());
                        Contacliente.saldo = Contacliente.depositar();
                        Console.WriteLine(" ");
                        Console.WriteLine($" Novo saldo da conta {Contacliente.numero}: {Contacliente.saldo:0.00} ");
                        Console.WriteLine(" ");
                        break;
                    case 3:
                        Console.WriteLine("informe o valor a ser sacado em Reais");
                        Contacliente.saque = decimal.Parse(Console.ReadLine());
                        Contacliente.saldo = Contacliente.sacar();
                        Console.WriteLine(" ");
                        Console.WriteLine($" Novo saldo da conta {Contacliente.numero}: {Contacliente.saldo:0.00} ");
                        Console.WriteLine(" ");
                        break;
                    case 0:
                        Console.WriteLine(" ");
                        Console.WriteLine("Operação finalizada");
                        Console.WriteLine(" ");
                        break;

                    default:
                        Console.WriteLine("Operação Inválida");
                        break;


                }
            }
             

            Console.ReadKey();
        }
    }
}
