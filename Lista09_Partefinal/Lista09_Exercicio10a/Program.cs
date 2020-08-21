using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Lista09_Exercicio10a
{
    class Program
    {

        static void Main(string[] args)
        {


            Console.WriteLine("digite um texto qualquer");
            string texto = Console.ReadLine();
            Console.WriteLine(texto);
            Console.WriteLine($"A iniciais de todas as palavras do texto são: {Iniciais(texto)} ");
            Console.ReadKey();
        }


        public static string Iniciais(string s)
        {
            int tamanho, tamanhopalavra;

            string[] initexto = s.Split(' ');

            tamanho = initexto.Length;
            string novapalavra = "";
           
            for (int i = 0; i < tamanho; i++)
            {
                tamanhopalavra = initexto[i].Length;
                novapalavra = String.Concat(novapalavra, initexto[i].Remove(1, tamanhopalavra - 1));

            }

            return novapalavra;
        }
           

    }
       
}






