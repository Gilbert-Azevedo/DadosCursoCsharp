using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio05
{
    class Program
    {
        static void Main(string[] args)
        {
            {
            Loja novaloja = new Loja();
           Aplicativo a1 = new Aplicativo { Nome = "Word      ", Categoria = " Editor de texto          ", Preco = 150,00 } ;
            novaloja.Inserir(a1);
          /* Aplicativo a2 = new Aplicativo { Assunto = "Curso Moodle            ", Local = "Virtual            ", Data = DateTime.Parse("03/08/2020") };
            novaloja.Inserir(a2);
            Aplicativo a3 = new Aplicativo { Assunto = "Reunião de Grupo        ", Local = "Remoto             ", Data = DateTime.Parse("10/08/2020") };
           novaloja.Inserir(a3);
            Aplicativo a4 = new Aplicativo { Assunto = "Aula inaugural          ", Local = "Auditório          ", Data = DateTime.Parse("12/09/2020") };
            novaloja.Inserir(a4);
            Aplicativo a5 = new Aplicativo { Assunto = "Reunião de orientação   ", Local = "Sala de Reuniões   ", Data = DateTime.Parse("15/09/2020") };
           novaloja.Inserir(a5);
            Aplicativo a6 = new Compromisso { Assunto = "Formatura               ", Local = "Ginásio            ", Data = DateTime.Parse("20/12/2020") };
            novaloja.Inserir(a6);*/

            Console.WriteLine(" Lista de Compromissos ");


            foreach (Compromisso listaapps in novaloja.Listar())
            {
                Console.WriteLine(listacomps.ToString());
            }



            Console.ReadKey();
            
                /* Console.WriteLine("  ");

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
            novagenda.Excluir(c2);

            foreach (Compromisso listacomps in novagenda.Listar())
            {
                Console.WriteLine(listacomps.ToString());
            }


            Console.ReadKey();*/

        }

        }
    }
}
