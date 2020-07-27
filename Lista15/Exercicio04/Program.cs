using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Criação da Agenda Pessoal");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
           // Console.WriteLine("Informe o número máximo de contatos para a agenda");
            int numcontatos = 5;//; int.Parse(Console.ReadLine());
            Agenda novaAgenda = new Agenda(numcontatos);
            /*
              for (int i = 1; i <= numcontatos;i++)
              {
                  Console.WriteLine(" ");
                  Console.WriteLine(" ");
                  Console.WriteLine($"Informe o Nome do Contato: { i } ");
                  string nome = Console.ReadLine();
                  Console.WriteLine($"Informe o Telefone do Contato:{ i } ");
                  string tel = Console.ReadLine();
                  Console.WriteLine($"Informe a Data de Nascimento do contato { i }");
                  DateTime nasc = DateTime.Parse(Console.ReadLine());
                  Contato novo = new Contato(nome, tel, nasc);
                  novaAgenda.inserir(novo);
              }*/
            Contato c1 = new Contato("Alvaro    ", "99438432", DateTime.Parse("08/07/1973"));
            novaAgenda.inserir(c1);
            Contato c2 = new Contato("Alessandra", "99443434", DateTime.Parse("26/08/1976"));
            novaAgenda.inserir(c2);
            Contato c3 = new Contato("Eduardo   ", "99767446", DateTime.Parse("20/07/1971"));
            novaAgenda.inserir(c3);
            Contato c4 = new Contato("Gilbert   ", "94334312", DateTime.Parse("08/08/1972"));
            novaAgenda.inserir(c4);
            Contato c5 = new Contato("Adriana   ", "94544331", DateTime.Parse("01/01/1977"));
            novaAgenda.inserir(c5);

            Console.WriteLine(" ");
            Console.WriteLine("Lista de contatos");
            Console.WriteLine(" ");

            foreach (Contato contatoregs in novaAgenda.Listar())
            {
              
                Console.WriteLine(contatoregs.ToString());
            }

            /*******************************************************************/


           int mesatual = DateTime.Now.Month;
           
            Console.WriteLine(" ");
            Console.WriteLine($"Lista de Aniversariantes do mês {mesatual}");
            Console.WriteLine(" ");

         /*     Contato[] aniversariantes = novaAgenda.AniversariantesMes(mesatual);

           
            for (int k= 0; k < aniversariantes.Length; k++) 
            {
                Console.WriteLine($"{aniversariantes[k]}");
            }
         */

            foreach (Contato aniv in novaAgenda.AniversariantesMes(mesatual))
            {

                Console.WriteLine(aniv.ToString());
            }



            Console.ReadKey();

        }
    }
}
