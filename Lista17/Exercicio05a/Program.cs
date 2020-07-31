using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio05a
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Loja novaloja = new Loja();
                Aplicativo a1 = new Aplicativo("Word", "Editor", 150);                                   //{ Nome = " Word      ", Categoria = "Editor            ", Preco = decimal.Parse(150,00)};
                novaloja.Inserir(a1);
              
                
                /* Compromisso c2 = new Compromisso { Assunto = "Curso Moodle            ", Local = "Virtual            ", Data = DateTime.Parse("03/08/2020") };
                novagenda.Inserir(c2);
                Compromisso c3 = new Compromisso { Assunto = "Reunião de Grupo        ", Local = "Remoto             ", Data = DateTime.Parse("10/08/2020") };
                novagenda.Inserir(c3);
                Compromisso c4 = new Compromisso { Assunto = "Aula inaugural          ", Local = "Auditório          ", Data = DateTime.Parse("12/09/2020") };
                novagenda.Inserir(c4);
                Compromisso c5 = new Compromisso { Assunto = "Reunião de orientação   ", Local = "Sala de Reuniões   ", Data = DateTime.Parse("15/09/2020") };
                novagenda.Inserir(c5);
                Compromisso c6 = new Compromisso { Assunto = "Formatura               ", Local = "Ginásio            ", Data = DateTime.Parse("20/12/2020") };
                novagenda.Inserir(c6);*/

                Console.WriteLine(" Lista de Compromissos ");


                foreach (Compromisso listacomps in novaloja.Listar())
                {
                    Console.WriteLine(listacomps.ToString());
                }

                Console.ReadKey();
            }
    }
}
