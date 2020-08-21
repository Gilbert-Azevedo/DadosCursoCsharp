using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entrada de Dados do Paciente");
            Console.WriteLine("  ");

            Console.WriteLine("Informe o nome do Paciente");
            string nm = Console.ReadLine();
            Console.WriteLine("Informe o CPF do paciente");
            string cp = Console.ReadLine();
            Console.WriteLine("Informe o Telefone do paciente");
            string tel = Console.ReadLine();
            Console.WriteLine("Informe a data de nascimento no formato dd/mm/aaaa");
            DateTime nscmto = DateTime.Parse(Console.ReadLine());
            Paciente novopaciente = new Paciente(nm,cp,tel,nscmto);

            Console.WriteLine(novopaciente.ToString());

            Console.ReadKey();



        }
    }
}
