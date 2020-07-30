using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            Paciente novopaciente = new Paciente("Jose_Alvaro", "79173497487", "998324328", DateTime.Parse("08/07/1973"));

            //Paciente novopaciente = { Nome = Jose_Alvaro, Cpf = 79173497487, Telefone = 998324328, Nascimento = DateTime.Parse("08/07/1973") }; 
            
            
            Console.WriteLine(novopaciente.ToString());
            Console.ReadKey();

        }
    }
}
