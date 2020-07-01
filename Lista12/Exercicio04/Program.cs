using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
            int operac = 1;
            Conta Contacliente = new Conta();
            Console.WriteLine("informe o nome do cliente da conta");
            Contacliente.SetNome(Console.ReadLine());

            Console.WriteLine("informe o número da conta");
            Contacliente.SetNumeroConta(Console.ReadLine());

            while (operac != 0)
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
                        Console.WriteLine($"Saldo da conta {Contacliente.GetNumeroConta()}: {Contacliente.GetSaldo():0.00} ");
                        break;

                    case 2:
                        Console.WriteLine("informe o valor a ser depositado em Reais");
                        Contacliente.SetDeposito(decimal.Parse(Console.ReadLine()));
                        Console.WriteLine(" ");
                        Console.WriteLine($" Novo saldo da conta {Contacliente.GetNumeroConta()}: {Contacliente.Deposito():0.00} ");
                        Console.WriteLine(" ");
                        break;



                    case 3:
                        Console.WriteLine("informe o valor a ser sacado em Reais");
                        Contacliente.SetSaque(decimal.Parse(Console.ReadLine()));
                        Console.WriteLine(" ");
                        Console.WriteLine($" Novo saldo da conta {Contacliente.GetNumeroConta()}: {Contacliente.Saque():0.00} ");
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
