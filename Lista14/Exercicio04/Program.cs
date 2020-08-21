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

            int d1 = 0, d2 = 0, d3 = 0, d4 = 0, turnoE;
            Console.WriteLine("Informe o nome do Estagiário");
            string nmE = Console.ReadLine();
            Console.WriteLine("Informe o CPF do Estagiario");
            string cpfE = Console.ReadLine();
            Console.WriteLine("Informe o Telefone do Estagiário");
            string telE = Console.ReadLine();
            Estagiario novoEstagiario = new Estagiario(nmE, cpfE, telE);

            while ((d1 == 0) || (d2 == 0) || (d3 == 0) || (d4 == 0))
            { 
            Console.WriteLine("Informe os números referentes aos dias desejados para realizar o estágio de acordo com o menu abaixo:");
            Console.WriteLine("2 - Segunda | 4 - Terca | 8 - Quarta | 16 Quinta | Sexta - 32");
                      
            d1 = int.Parse(Console.ReadLine());
            d2 = int.Parse(Console.ReadLine());
            d3 = int.Parse(Console.ReadLine());
            d4 = int.Parse(Console.ReadLine());
                             

            }

            int diasestagio = d1 | d2 | d3 | d4;

            novoEstagiario.SetDias((Estagiario.Dias)diasestagio);

            Console.WriteLine("Informe os turno desejado para realizar o estágio de acordo com o menu abaixo:");
            Console.WriteLine(" 1 - Matutino | 2 - Vespertino | 3 - Noturno");

            turnoE = int.Parse(Console.ReadLine());

            novoEstagiario.SetTurnos((Estagiario.Turno) turnoE);

            Console.WriteLine(novoEstagiario.ToString());

            

            Console.ReadKey();
        }
    }
}
