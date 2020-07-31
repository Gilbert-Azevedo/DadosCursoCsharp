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
                Aplicativo a1 = new Aplicativo("Word         ","Editor  ", 150);                                   //{ Nome = " Word      ", Categoria = "Editor            ", Preco = decimal.Parse(150,00)};
                novaloja.Inserir(a1);

                Aplicativo a2 = new Aplicativo("Excel        ","Planilha", 250);                                  
                novaloja.Inserir(a2);

                Aplicativo a3 = new Aplicativo("F1GP         ","Jogos   ", 300);
                novaloja.Inserir(a3);

                Aplicativo a4 = new Aplicativo("AgendaFacil  ","Agenda  ", 80);
                novaloja.Inserir(a4);

                Console.WriteLine(" Lista de Aplicativos ");


                foreach (Aplicativo listacomps in novaloja.Listar())
                {
                    Console.WriteLine(listacomps.ToString());
                }

                Console.ReadKey();

                Console.WriteLine("   ");

                Console.WriteLine("Teste de exclusão de um Aplicativo");
                novaloja.Excluir(a4);

                foreach (Aplicativo listaapps in novaloja.Listar())
                {
                    Console.WriteLine(listaapps.ToString());
                }


                Console.ReadKey();




            }
        }
    }
}
