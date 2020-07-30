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
            Agenda novagenda = new Agenda();
            Compromisso c1 = new Compromisso { Assunto = "Reunião Pedagogica      ", Local = "Virtual            ", Data = DateTime.Parse("30/07/2020") } ;
            novagenda.Inserir(c1);
            Compromisso c2 = new Compromisso { Assunto = "Curso Moodle            ", Local = "Virtual            ", Data = DateTime.Parse("03/08/2020") };
            novagenda.Inserir(c2);
            Compromisso c3 = new Compromisso { Assunto = "Reunião de Grupo        ", Local = "Remoto             ", Data = DateTime.Parse("10/08/2020") };
            novagenda.Inserir(c3);
            Compromisso c4 = new Compromisso { Assunto = "Aula inaugural          ", Local = "Auditório          ", Data = DateTime.Parse("12/09/2020") };
            novagenda.Inserir(c4);
            Compromisso c5 = new Compromisso { Assunto = "Reunião de orientação   ", Local = "Sala de Reuniões   ", Data = DateTime.Parse("15/09/2020") };
            novagenda.Inserir(c5);
            Compromisso c6 = new Compromisso { Assunto = "Formatura               ", Local = "Ginásio            ", Data = DateTime.Parse("20/12/2020") };
            novagenda.Inserir(c6);

            Console.WriteLine(" Lista de Compromissos ");


            foreach (Compromisso listacomps in novagenda.Listar())
            {
                Console.WriteLine(listacomps.ToString());
            }

            Console.ReadKey();
            Console.WriteLine("  ");

            Console.WriteLine("  ");

            Console.WriteLine(" Compromissos do mês de agosto");

            foreach (Compromisso listapesq in novagenda.Pesquisar(8,2020))
            {
                Console.WriteLine(listapesq.ToString());
            }

            Console.WriteLine("  ");

            Console.WriteLine(" Compromissos do mês de Setembro");

            foreach (Compromisso listapesq in novagenda.Pesquisar(9, 2020))
            {
                Console.WriteLine(listapesq.ToString());
            }
            Console.WriteLine("  ");
            Console.WriteLine(" Compromissos do mês de Outubro");

            foreach (Compromisso listapesq in novagenda.Pesquisar(10, 2020))
            {
                Console.WriteLine(listapesq.ToString());
            }
            Console.WriteLine("  ");
            Console.WriteLine(" Compromissos do mês de dezembro");
            foreach (Compromisso listapesq in novagenda.Pesquisar(12, 2020))
            {
                Console.WriteLine(listapesq.ToString());
            }
            Console.WriteLine("  ");
            Console.ReadKey();
            Console.WriteLine("Teste de exclusão de um compromisso");
            novagenda.Excluir(c1);

            foreach (Compromisso listacomps in novagenda.Listar())
            {
                Console.WriteLine(listacomps.ToString());
            }


            Console.ReadKey();

        }
    }
}
